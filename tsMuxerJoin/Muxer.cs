using System;
using System.IO;

namespace tsMuxerJoin
{
    public static class Utils
    {
        public static string DoubleQuote(this string text)
        {
            return SurroundWith(text, "\"");
        }

        public static string Quote(this string text)
        {
            return SurroundWith(text, "'");
        }

        public static string SurroundWith(this string text, string ends)
        {
            return ends + text + ends;
        }

        public static string[] GetSourceFiles(string dir, string extension)
        {
            try
            {
                return Directory.GetFiles(@dir, extension, SearchOption.TopDirectoryOnly);
            }
            catch (Exception)
            {
                return new string[0];
            }
        }
    }

    public abstract class Muxer
    {
        public abstract string ExeName { get; }
        public abstract string GetArguments(string input, string extension, string output);
        public abstract string Preview(string input, string extension);

        public string ExeFilter
        {
            get { return ExeName + "|" + ExeName + "|Executable file|*.exe"; }
        }

        public static Muxer GetMuxer()
        {
            return new FfMuxer();
        }
    }

    public class FfMuxer : Muxer
    {
        public override string ExeName { get { return "ffmpeg.exe"; } }
        public override string Preview(string input, string extension)
        {
            return "-i " + ("concat:" + String.Join("|", Utils.GetSourceFiles(input, extension))).DoubleQuote() + " -c copy ";
        }

        public override string GetArguments(string input, string extension, string output)
        {
            return Preview(input, extension) + output.DoubleQuote();
        }
    }

    public class TsMuxer : Muxer
    {
        public override string ExeName { get { return "tsmuxer.exe"; } }
        public override string Preview(string input, string extension)
        {
            StringWriter writer = new StringWriter();
            writeMetaFile(writer, input, extension);
            return writer.ToString();
        }

        public override string GetArguments(string input, string extension, string output)
        {
            string metaName = output + ".meta";
            using (StreamWriter writer = new StreamWriter(File.Open(metaName, FileMode.Create), System.Text.Encoding.Default))
                writeMetaFile(writer, input, extension);
            return metaName.DoubleQuote() + " " + output.DoubleQuote();
        }

        private void writeFileList(TextWriter writer, string[] files)
        {
            writer.Write(files[0].DoubleQuote());
            for (int i = 1; i < files.Length; i++)
            {
                writer.Write("+");
                writer.Write(files[i].DoubleQuote());
            }
        }

        private void writeMetaFile(TextWriter writer, string dir, string extension)
        {
            string[] tsFiles = Utils.GetSourceFiles(dir, extension);
            if (tsFiles.Length < 1)
                return;

            writer.WriteLine("MUXOPT --no-pcr-on-video-pid --new-audio-pes --vbr  --vbv-len=500");

            writer.Write("V_MPEG4/ISO/AVC, ");
            //writer.Write("V_MPEG-2, ");
            writeFileList(writer, tsFiles);
            //writer.WriteLine(", fps=25, track=224");
            writer.WriteLine(", fps=50, insertSEI, contSPS, track=4113");

            writer.Write("A_AC3, ");
            writeFileList(writer, tsFiles);
            //writer.WriteLine(", track=128");
            writer.WriteLine(", track=4352");

            writer.Write("S_HDMV/PGS, ");
            writeFileList(writer, tsFiles);
            writer.WriteLine(", bottom-offset=24,font-border=2,text-align=center,video-width=1920,video-height=1080,fps=50, track=4608");
        }
    }
}
