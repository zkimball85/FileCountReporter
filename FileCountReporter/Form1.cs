using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FileCountReporter
{
    // Main form class for the application, inheriting from the standard Windows Forms 'Form' class.
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Initializes the components and controls placed on the form in the designer.
            InitializeComponent();
        }

        // Event handler triggered when the "Select Folder" button is clicked.
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            // Create a new instance of FolderBrowserDialog to let the user pick a directory.
            // The 'using' statement ensures the dialog is properly disposed of after use to free up resources.
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                // Set a description to guide the user.
                folderBrowserDialog.Description = "Select a folder to search";
                // Disable the "Make New Folder" button since we only want to read existing folders.
                folderBrowserDialog.ShowNewFolderButton = false;

                // Show the dialog to the user and check if they clicked "OK".
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Update the text box with the path the user selected.
                    txtSelectedFolder.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        // Event handler triggered when the "Count Files" button is clicked.
        private void btnCountFiles_Click(object sender, EventArgs e)
        {
            // Retrieve the target folder path from the text box.
            var folderPath = txtSelectedFolder.Text;
            
            // Validate the input: Ensure it's not empty and that the directory actually exists on the disk.
            if (string.IsNullOrWhiteSpace(folderPath) || !Directory.Exists(folderPath))
            {
                // If invalid, show an error message to the user and exit the method.
                MessageBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear any previous output from the rich text box before starting a new scan.
            rtbOutput.Clear();
            // Append the starting header to the output.
            rtbOutput.AppendText($"Scanning folder: {folderPath}\n\n");

            try
            {
                // Fetch the full paths of all files in the chosen directory.
                // SearchOption.AllDirectories ensures we also recursively search through all subdirectories.
                var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
                
                // Process the array of file paths using LINQ to count files by their extension.
                var extensionCounts = files
                    // Step 1: Extract the extension for each file and convert it to lowercase for consistency (e.g., .TXT and .txt become .txt).
                    .Select(file => Path.GetExtension(file).ToLowerInvariant())
                    // Step 2: Group the extensions together. If a file has no extension (empty string), group it under "No Extension".
                    .GroupBy(ext => string.IsNullOrEmpty(ext) ? "No Extension" : ext)
                    // Step 3: Create an anonymous object containing the Extension name and the total Count of files in that group.
                    .Select(group => new { Extension = group.Key, Count = group.Count() })
                    // Step 4: Sort the results by the count in descending order (highest count first).
                    .OrderByDescending(x => x.Count)
                    // Step 5: For identical counts, sort alphabetically by the extension name.
                    .ThenBy(x => x.Extension);

                // Check if the resulting sequence has any elements. If not, the folder is empty.
                if (!extensionCounts.Any())
                {
                    rtbOutput.AppendText("No files found in the selected folder.\n");
                    return;
                }

                // Build and display the table header for the results.
                // "{0,-20}" pads the first column (Extension) to be 20 characters wide, left-aligned.
                rtbOutput.AppendText(string.Format("{0,-20} | {1}\n", "Extension", "Count"));
                rtbOutput.AppendText(new string('-', 35) + "\n");

                // Iterate through each grouped extension and append its details to the output.
                foreach (var item in extensionCounts)
                {
                    rtbOutput.AppendText(string.Format("{0,-20} | {1}\n", item.Extension, item.Count));
                }

                // Finally, display the total number of files processed.
                rtbOutput.AppendText($"\nTotal Files: {files.Length}\n");
            }
            catch (UnauthorizedAccessException ex)
            {
                // Handle the case where the application lacks permission to read a specific folder or file.
                rtbOutput.AppendText($"\nAccess Denied to one or more directories: {ex.Message}\n");
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors, such as path-too-long exceptions.
                rtbOutput.AppendText($"\nAn error occurred: {ex.Message}\n");
            }
        }
    }
}

