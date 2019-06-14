using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

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
            Win32Utility.SetCueText(outputEdit,    Properties.Resources.chooseOutputHint);
            richTextBox1.Rtf = Properties.Resources.rtfHelp;
            if (args.Length > 0)
                setSourceDirectory(args[0]);
        }

        private bool setSourceDirectory(string dir)
        {
            if (Utils.GetSourceFiles(dir, extension).Length == 0)
            {
                if (MessageBox.Show(Properties.Resources.dirHasNoSupportedFiles, this.Name, MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation) == DialogResult.Retry)
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
            Muxer m = Muxer.GetMuxer();
            muxerExe.FileName = m.ExeName;
            muxerExe.Filter = m.ExeFilter;

            if (!File.Exists(muxerExe.FileName) && muxerExe.ShowDialog() != DialogResult.OK)
                return;

            Process muxer = new Process();
            try
            {
                muxer.StartInfo.FileName = muxerExe.FileName;
                muxer.StartInfo.Arguments = m.GetArguments(directory, extension, output);
                muxer.EnableRaisingEvents = true;
                muxer.Exited += new EventHandler(muxer_Exited);
                muxer.Start();
                TaskbarManager.Instance.SetProgressValue(0, 1);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.muxerExecFailed, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaskbarManager.Instance.SetProgressValue(1, 1);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
            }
        }

        private void muxer_Exited(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(1, 1);

            Process muxer = sender as Process;
            if (muxer.ExitCode != 0)
            {
                MessageBox.Show(String.Format(Properties.Resources.muxerFailed, muxer.ExitCode), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
            }
            else
            {
                Process.Start("explorer.exe", "/select," + output.DoubleQuote());
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            }
        }

        private void mux_Click(object sender, EventArgs e)
        {
            mux();
        }

        private void preview_Click(object sender, EventArgs e)
        {
            new PreviewForm(Muxer.GetMuxer().Preview(directory, extension)).ShowDialog();
        }
    }
}
