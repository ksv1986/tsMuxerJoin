namespace tsMuxerJoin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.directoryEdit = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.chooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.outputEdit = new System.Windows.Forms.TextBox();
            this.outputFile = new System.Windows.Forms.SaveFileDialog();
            this.muxerExe = new System.Windows.Forms.OpenFileDialog();
            this.previewButton = new System.Windows.Forms.Button();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.muxButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // directoryEdit
            // 
            resources.ApplyResources(this.directoryEdit, "directoryEdit");
            this.directoryEdit.AllowDrop = true;
            this.directoryEdit.Name = "directoryEdit";
            this.tip.SetToolTip(this.directoryEdit, global::tsMuxerJoin.Properties.Resources.chooseFolderHint);
            this.directoryEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.directory_DragDrop);
            this.directoryEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.directory_DragEnter);
            // 
            // browse
            // 
            resources.ApplyResources(this.browse, "browse");
            this.browse.Name = "browse";
            this.tip.SetToolTip(this.browse, resources.GetString("browse.ToolTip"));
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.Description = global::tsMuxerJoin.Properties.Resources.chooseFolderHint;
            resources.ApplyResources(this.chooseFolder, "chooseFolder");
            this.chooseFolder.ShowNewFolderButton = false;
            // 
            // outputEdit
            // 
            resources.ApplyResources(this.outputEdit, "outputEdit");
            this.outputEdit.Name = "outputEdit";
            this.tip.SetToolTip(this.outputEdit, global::tsMuxerJoin.Properties.Resources.chooseOutputHint);
            // 
            // outputFile
            // 
            resources.ApplyResources(this.outputFile, "outputFile");
            this.outputFile.Title = global::tsMuxerJoin.Properties.Resources.chooseOutputHint;
            // 
            // muxerExe
            // 
            this.muxerExe.FileName = "tsMuxeR.exe";
            resources.ApplyResources(this.muxerExe, "muxerExe");
            // 
            // previewButton
            // 
            resources.ApplyResources(this.previewButton, "previewButton");
            this.previewButton.Name = "previewButton";
            this.tip.SetToolTip(this.previewButton, resources.GetString("previewButton.ToolTip"));
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.preview_Click);
            // 
            // browseOutputButton
            // 
            resources.ApplyResources(this.browseOutputButton, "browseOutputButton");
            this.browseOutputButton.Name = "browseOutputButton";
            this.tip.SetToolTip(this.browseOutputButton, resources.GetString("browseOutputButton.ToolTip"));
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // muxButton
            // 
            resources.ApplyResources(this.muxButton, "muxButton");
            this.muxButton.Name = "muxButton";
            this.tip.SetToolTip(this.muxButton, resources.GetString("muxButton.ToolTip"));
            this.muxButton.UseVisualStyleBackColor = true;
            this.muxButton.Click += new System.EventHandler(this.mux_Click);
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.TabStop = false;
            this.tip.SetToolTip(this.richTextBox1, resources.GetString("richTextBox1.ToolTip"));
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.muxButton);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.outputEdit);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.directoryEdit);
            this.Name = "MainForm";
            this.tip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryEdit;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog chooseFolder;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.SaveFileDialog outputFile;
        private System.Windows.Forms.OpenFileDialog muxerExe;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.TextBox outputEdit;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.Button muxButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

