namespace FileCountReporter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSelectFolder = new Button();
            txtSelectedFolder = new TextBox();
            btnCountFiles = new Button();
            rtbOutput = new RichTextBox();
            SuspendLayout();
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Location = new Point(22, 26);
            btnSelectFolder.Margin = new Padding(6, 6, 6, 6);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(223, 49);
            btnSelectFolder.TabIndex = 0;
            btnSelectFolder.Text = "Select Folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtSelectedFolder
            // 
            txtSelectedFolder.Location = new Point(256, 30);
            txtSelectedFolder.Margin = new Padding(6, 6, 6, 6);
            txtSelectedFolder.Name = "txtSelectedFolder";
            txtSelectedFolder.ReadOnly = true;
            txtSelectedFolder.Size = new Size(988, 39);
            txtSelectedFolder.TabIndex = 1;
            // 
            // btnCountFiles
            // 
            btnCountFiles.Location = new Point(1259, 26);
            btnCountFiles.Margin = new Padding(6, 6, 6, 6);
            btnCountFiles.Name = "btnCountFiles";
            btnCountFiles.Size = new Size(204, 49);
            btnCountFiles.TabIndex = 2;
            btnCountFiles.Text = "Count Files";
            btnCountFiles.UseVisualStyleBackColor = true;
            btnCountFiles.Click += btnCountFiles_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(22, 87);
            rtbOutput.Margin = new Padding(6, 6, 6, 6);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(1438, 842);
            rtbOutput.TabIndex = 3;
            rtbOutput.Text = "";
            // 
            // Form1
            // 
            AcceptButton = btnCountFiles;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(rtbOutput);
            Controls.Add(btnCountFiles);
            Controls.Add(txtSelectedFolder);
            Controls.Add(btnSelectFolder);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "File Count Reporter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtSelectedFolder;
        private System.Windows.Forms.Button btnCountFiles;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}
