using System;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace tsMuxerJoin
{
    public partial class MainForm : Form
    {
        private string directory
        {
            get { return directoryEdit.Text; }
            set { directoryEdit.Text = value; }
        }
        private string output
        {
            get { return outputEdit.Text; }
            set { outputEdit.Text = value; }
        }
        private string extension
        {
            get { return "*.MTS"; }
        }

        public MainForm(string[] args)
        {
            InitializeComponent();
            Win32Utility.SetCueText(directoryEdit, Properties.Resources.chooseFolderHint);
            Win32Utility.SetCueText(outputEdit, Properties.Resources.chooseOutputHint);
            if (args.Length > 0)
                setSourceDirectory(args[0]);
        }

        private bool setSourceDirectory(string dir)
        {
            if (getSourceFiles(dir, extension).Length == 0)
            {
                if (MessageBox.Show("Selected directory doesn't have supported files", this.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Retry)
                    return browseFolder();
                return false;
            }
            directory = chooseFolder.SelectedPath;
            outputFile.InitialDirectory = chooseFolder.SelectedPath;
            if (output.Length == 0)
                browseOutput();
            return true;
        }

        private bool browseFolder()
        {
            if (chooseFolder.ShowDialog() != DialogResult.OK)
                return false;
            return setSourceDirectory(chooseFolder.SelectedPath);
        }

        private void browseOutput()
        {
            if (outputFile.ShowDialog() == DialogResult.OK)
                output = outputFile.FileName;
        }

        private string quotedPath(string path)
        {
            return "\"" + path + "\"";
        }

        string[] getSourceFiles(string dir, string extension)
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

        private void writeFileList(TextWriter writer, string[] files)
        {
            writer.Write(quotedPath(files[0]));
            for (int i = 1; i < files.Length; i++)
            {
                writer.Write("+");
                writer.Write(quotedPath(files[i]));
            }
        }

        private void writeMetaFile(TextWriter writer, string dir, string extension)
        {
            string[] tsFiles = getSourceFiles(dir, extension);
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

        private void browse_Click(object sender, EventArgs e)
        {
            browseFolder();
        }

        private void directory_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None; 
        }

        private void directory_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in FileList)
                if (Directory.Exists(path))
                {
                    directory = path;
                    return;
                }
        }

        private void browseOutputButton_Click(object sender, EventArgs e)
        {
            browseOutput();
        }

        private void mux()
        {
            string metaName = output + ".meta";
            using (StreamWriter writer = new StreamWriter(File.Open(metaName, FileMode.Create), System.Text.Encoding.Default))
                writeMetaFile(writer, directory, extension);
            Process muxer = new Process();
            try
            {
                muxer.StartInfo.FileName = @tsMuxeR.FileName;
                muxer.StartInfo.Arguments = quotedPath(metaName) + " " + quotedPath(output);
                muxer.EnableRaisingEvents = true;
                muxer.Exited += new EventHandler(muxer_Exited);
                muxer.Start();
            }
            catch (Win32Exception)
            {
                if (tsMuxeR.ShowDialog() == DialogResult.OK)
                    mux();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to launch tsMuxer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void muxer_Exited(object sender, EventArgs e)
        {
            Process muxer = sender as Process;
            if (muxer.ExitCode != 0)
                MessageBox.Show(String.Format("Muxer process exited with code {0}", muxer.ExitCode), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                Process.Start("explorer.exe", "/select," + quotedPath(output));
        }

        private void mux_Click(object sender, EventArgs e)
        {
            mux();
        }

        private void preview_Click(object sender, EventArgs e)
        {
            StringWriter writer = new StringWriter();
            writeMetaFile(writer, directory, extension);
            PreviewForm preview = new PreviewForm(writer.ToString());
            preview.ShowDialog();
        }
    }
}
