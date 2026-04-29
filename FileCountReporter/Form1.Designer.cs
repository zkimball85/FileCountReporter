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
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtSelectedFolder = new System.Windows.Forms.TextBox();
            this.btnCountFiles = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(120, 23);
            this.btnSelectFolder.TabIndex = 0;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtSelectedFolder
            // 
            this.txtSelectedFolder.Location = new System.Drawing.Point(138, 14);
            this.txtSelectedFolder.Name = "txtSelectedFolder";
            this.txtSelectedFolder.ReadOnly = true;
            this.txtSelectedFolder.Size = new System.Drawing.Size(534, 23);
            this.txtSelectedFolder.TabIndex = 1;
            // 
            // btnCountFiles
            // 
            this.btnCountFiles.Location = new System.Drawing.Point(678, 12);
            this.btnCountFiles.Name = "btnCountFiles";
            this.btnCountFiles.Size = new System.Drawing.Size(110, 23);
            this.btnCountFiles.TabIndex = 2;
            this.btnCountFiles.Text = "Count Files";
            this.btnCountFiles.UseVisualStyleBackColor = true;
            this.btnCountFiles.Click += new System.EventHandler(this.btnCountFiles_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(12, 41);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(776, 397);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.btnCountFiles);
            this.Controls.Add(this.txtSelectedFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.Name = "Form1";
            this.Text = "File Count Reporter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtSelectedFolder;
        private System.Windows.Forms.Button btnCountFiles;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}
