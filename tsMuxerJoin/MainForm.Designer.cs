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
            this.tsMuxeR = new System.Windows.Forms.OpenFileDialog();
            this.previewButton = new System.Windows.Forms.Button();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.muxButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // directoryEdit
            // 
            this.directoryEdit.AllowDrop = true;
            this.directoryEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryEdit.Location = new System.Drawing.Point(12, 227);
            this.directoryEdit.Name = "directoryEdit";
            this.directoryEdit.Size = new System.Drawing.Size(403, 20);
            this.directoryEdit.TabIndex = 4;
            this.tip.SetToolTip(this.directoryEdit, global::tsMuxerJoin.Properties.Resources.chooseFolderHint);
            this.directoryEdit.DragDrop += new System.Windows.Forms.DragEventHandler(this.directory_DragDrop);
            this.directoryEdit.DragEnter += new System.Windows.Forms.DragEventHandler(this.directory_DragEnter);
            // 
            // browse
            // 
            this.browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browse.Location = new System.Drawing.Point(421, 224);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(31, 23);
            this.browse.TabIndex = 0;
            this.browse.Text = "...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // chooseFolder
            // 
            this.chooseFolder.Description = global::tsMuxerJoin.Properties.Resources.chooseFolderHint;
            this.chooseFolder.ShowNewFolderButton = false;
            // 
            // outputEdit
            // 
            this.outputEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputEdit.Location = new System.Drawing.Point(12, 257);
            this.outputEdit.Name = "outputEdit";
            this.outputEdit.Size = new System.Drawing.Size(402, 20);
            this.outputEdit.TabIndex = 5;
            this.tip.SetToolTip(this.outputEdit, global::tsMuxerJoin.Properties.Resources.chooseOutputHint);
            // 
            // outputFile
            // 
            this.outputFile.Filter = "M2TS Files|*.m2ts|All files|*.*";
            this.outputFile.Title = global::tsMuxerJoin.Properties.Resources.chooseOutputHint;
            // 
            // tsMuxeR
            // 
            this.tsMuxeR.FileName = "tsMuxeR.exe";
            this.tsMuxeR.Filter = "tsmuxer.exe|tsmuxer.exe|Executable file|*.exe";
            this.tsMuxeR.Title = "Choose tsMuxer executable";
            // 
            // previewButton
            // 
            this.previewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.previewButton.Location = new System.Drawing.Point(356, 284);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(96, 23);
            this.previewButton.TabIndex = 3;
            this.previewButton.Text = "Preview";
            this.previewButton.UseVisualStyleBackColor = true;
            this.previewButton.Click += new System.EventHandler(this.preview_Click);
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutputButton.Location = new System.Drawing.Point(421, 254);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(31, 23);
            this.browseOutputButton.TabIndex = 1;
            this.browseOutputButton.Text = "...";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            this.browseOutputButton.Click += new System.EventHandler(this.browseOutputButton_Click);
            // 
            // muxButton
            // 
            this.muxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.muxButton.Location = new System.Drawing.Point(13, 284);
            this.muxButton.Name = "muxButton";
            this.muxButton.Size = new System.Drawing.Size(96, 23);
            this.muxButton.TabIndex = 2;
            this.muxButton.Text = "Mux";
            this.muxButton.UseVisualStyleBackColor = true;
            this.muxButton.Click += new System.EventHandler(this.mux_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(440, 206);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Rtf = Properties.Resources.rtfHelp;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 319);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.muxButton);
            this.Controls.Add(this.browseOutputButton);
            this.Controls.Add(this.outputEdit);
            this.Controls.Add(this.previewButton);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.directoryEdit);
            this.MinimumSize = new System.Drawing.Size(244, 38);
            this.Name = "MainForm";
            this.Text = "tsMuxerJoin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directoryEdit;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.FolderBrowserDialog chooseFolder;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.SaveFileDialog outputFile;
        private System.Windows.Forms.OpenFileDialog tsMuxeR;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.TextBox outputEdit;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.Button muxButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

