using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FileCountReporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a folder to search";
                folderBrowserDialog.ShowNewFolderButton = false;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSelectedFolder.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnCountFiles_Click(object sender, EventArgs e)
        {
            var folderPath = txtSelectedFolder.Text;
            if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath))
            {
                MessageBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            rtbOutput.Clear();
            rtbOutput.AppendText($"Scanning folder: {folderPath}\n\n");

            try
            {
                // Get all files in the directory and subdirectories
                var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
                
                // Group by extension and count
                var extensionCounts = files
                    .Select(file => Path.GetExtension(file).ToLowerInvariant())
                    .GroupBy(ext => string.IsNullOrEmpty(ext) ? "No Extension" : ext)
                    .Select(group => new { Extension = group.Key, Count = group.Count() })
                    .OrderByDescending(x => x.Count)
                    .ThenBy(x => x.Extension);

                if (!extensionCounts.Any())
                {
                    rtbOutput.AppendText("No files found in the selected folder.\n");
                    return;
                }

                // Display results
                rtbOutput.AppendText(string.Format("{0,-20} | {1}\n", "Extension", "Count"));
                rtbOutput.AppendText(new string('-', 35) + "\n");

                foreach (var item in extensionCounts)
                {
                    rtbOutput.AppendText(string.Format("{0,-20} | {1}\n", item.Extension, item.Count));
                }

                rtbOutput.AppendText($"\nTotal Files: {files.Length}\n");
            }
            catch (UnauthorizedAccessException ex)
            {
                rtbOutput.AppendText($"\nAccess Denied to one or more directories: {ex.Message}\n");
            }
            catch (Exception ex)
            {
                rtbOutput.AppendText($"\nAn error occurred: {ex.Message}\n");
            }
        }
    }
}
