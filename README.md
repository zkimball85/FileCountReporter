# FileCountReporter

## Overview

FileCountReporter is a Windows Forms application that scans a specified directory and its subdirectories, providing a count of files organized by their extensions. This report helps users quickly understand the makeup of a folder's contents and identify the most common file types.

### Screenshots

![Main window](Screen%20Shot%202026-04-29%20at%2014.48.50%20PM.png)

![Example results](Screen%20Shot%202026-04-29%20at%2014.49.51%20PM.png)

### Features

- Select any folder on your system to scan for files.
- Counts files of all types, categorizing them by their extensions.
- Displays results in an easy-to-read format, showing the extension type and corresponding file count.
- Handles errors gracefully, informing the user of any issues encountered during the scan (e.g., access denied to certain folders).

## Getting Started

These instructions will guide you on how to set up and use the FileCountReporter application.

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or later

### Installation

1. Clone or download the repository files to your local machine.
2. Open the solution (`FileCountReporter.sln`) or the project folder in Visual Studio.
3. Build the solution to restore dependencies and compile the project.
4. Run the application (`F5` in Visual Studio).

## How to Use

1. Launch the application.
2. Click the **"Select Folder"** button.
3. In the folder browser dialog, navigateto the directory you want to analyze and click **OK**. The path will appear in the text box.
4. Click the **"Count Files"** button.
5. The application will scan the directory and display a breakdown of file counts by extension in the main output area.

### Example Output

```
Scanning folder: C:\MyDocuments\Reports

Extension          | Count
-----------------------------------
.docx              | 120
.xlsx              | 85
.pptx              | 45
.pdf               | 30
.txt               | 10
No Extension       | 5

Total Files: 295
```

## Troubleshooting

- **Access Denied**: If the top-level folder or any of its subdirectories require administrator privileges that you do not have, the application will display an "Access Denied" error message in the output area.
- **No Files Found**: Ensure you have selected a folder that actually contains files.

## License

This project is open-source and available for educational and personal use.
