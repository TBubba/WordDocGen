using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using WordDocGen.DataTypes;
using Microsoft.Office.Interop.Word;
using System.Runtime.Serialization;
using System.Xml;

namespace WordDocGen
{
    /// <summary>
    /// Types of errors that can occur when creating a Word document
    /// </summary>
    internal enum CreateDocumentError
    {
        PathDoesntMakeSense,
        WordNotInstalled,
        None
    }

    static internal class WordDoc
    {
        // Private
        static private readonly string _userFile = AppDomain.CurrentDomain.BaseDirectory + "WordGenSettings.txt"; // User settings file path
        static private UserSettings _user; // User settings container

        // Internal
        /// <summary>
        /// Current user settings
        /// </summary>
        static internal UserSettings User
        { get { return _user; } }

        // UserSettings
        static internal void LoadUserSettings()
        {
            // Try loading user settings
            try
            {
                // Open user settings file
                using (FileStream stream = new FileStream(_userFile, FileMode.Open)) // Create stream
                    using (XmlReader xr = XmlReader.Create(stream, new XmlReaderSettings() { })) // Create XML-Reader
                    {
                        // Read and serialize file
                        DataContractSerializer dcs = new DataContractSerializer(typeof(UserSettings));
                        _user = (UserSettings)dcs.ReadObject(xr);
                    }
            }
            catch
            {
                // Set user settings to default
                _user = UserSettings.Default();

                // Error message? (Could not load user settings)
            }
        }
        static internal void SaveUserSettings()
        {
            // Try to save user settings in its file
            try
            {
                // Create a file if there is none
                if (!File.Exists(_userFile))
                    File.Create(_userFile).Close();


                // Open user settings file
                using (FileStream stream = new FileStream(_userFile, FileMode.Truncate)) // Create stream
                    using (XmlWriter xw = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = true })) // Create XML-Reader
                    {
                        // Serialize settings and write them
                        DataContractSerializer dcs = new DataContractSerializer(typeof(UserSettings));
                        dcs.WriteObject(xw, _user);
                    }
            }
            catch
            {
                // Error message? (Could not save user settings)
            }

        }

        // Word
        internal static bool IsWordInstalled()
        {
            // Check if Word is installed
            using (var regWord = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("Word.Application"))
            {
                if (regWord == null)
                    return false;
                return true;
            }
        }

        // Document
        internal static CreateDocumentError CreateDocument(string fullName, string grade, string subject, string assignment, string path)
        {
            // Check if MsWord is installed
            if (!IsWordInstalled())
                return CreateDocumentError.WordNotInstalled;

            // Format the path to the document folder
            string folderPath = FormatFolderPath(path);

            // Check if the path is valid (correctly formatted)
            if (!CanCreatePath(folderPath))
                return CreateDocumentError.PathDoesntMakeSense;

            // Create folder(s)
            Directory.CreateDirectory(folderPath);

            // Ref to MsWord
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

            // Create a new document
            object missing = System.Reflection.Missing.Value;
            Document document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);

            // Hide MsWord
            word.Visible = false;

            // Create header
            foreach (Section section in document.Sections)
            {
                // Create fields for header (to type info in)
                Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                
                // Set font
                headerRange.Font.ColorIndex = WdColorIndex.wdAuto;
                headerRange.Font.Size = 12;

                // Type info to header
                headerRange.Text = string.Format("{0}\t\t{1} {2}\n{3}\t\t{4}", 
                    assignment, fullName, grade, subject, DateTime.Now.Date.ToString("yyyy-MM-dd"));
            }

            // Document file path
            object filePath = (object)FormatDocumentPath(folderPath, FormatDocumentName(fullName, grade, subject, assignment));

            // Save and exit
            document.SaveAs2(ref filePath);
            document.Close(ref missing, ref missing, ref missing);
            word.Quit(ref missing, ref missing, ref missing);

            // Open MsWord again
            word = new Microsoft.Office.Interop.Word.Application();
            word.Visible = true;
            
            // Load the document
            document = word.Documents.Open(filePath);
            document.Activate();

            // Success
            return CreateDocumentError.None;
        }

        // Document path
        internal static string FormatDocumentPath(string path, string name)
        {
            // Add '\' at the end of the path (if there is none)
            if (path[path.Length - 1] != '\\')
                path += '\\';

            // Combine folder path, file name and file format
            return string.Format("{0}{1}.docx", path, name);
        }

        internal static string FormatDocumentName(string fullName, string grade, string subject, string assignment)
        {
            // Replace all spaces with underscores
            fullName = fullName.Replace(' ', '_');
            grade = grade.Replace(' ', '_');
            subject = subject.Replace(' ', '_');
            assignment = assignment.Replace(' ', '_');

            // Format the document name
            return string.Format("{0}_{1}_{2}_{3}", fullName, grade, subject, assignment);
        }

        // Folder
        internal static bool CanCreatePath(string path)
        {
            // Check if path is valid
            try { path = Path.GetFullPath(path); }
            catch { return false; } // Abort if not

            // Check what drive the path leads to (C:\, F:\ etc.)
            bool driveExists = false;
            DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            int length = drives.Length;
            for (int i = 0; i < length; i++)
            {
                if (path.Contains(drives[i].Name))
                {
                    driveExists = true;
                    break;
                }
            }

            // Check if the drive is valid
            if (!driveExists)
                return false; // Abort if not

            // Success
            return true;
        }

        /// <summary>
        /// Formats a path with relative path to a normal path
        /// (replaces "...\" with the programs currect directory path)
        /// </summary>
        /// <param name="path">The path</param>
        /// <returns>Fromatted path</returns>
        internal static string FormatFolderPath(string path)
        {
            // Rpelace "...\" with the programs directory
            if (path.Length >= 4)
            {
                if (path.Substring(0, 4) == @"...\")
                    path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + path.Substring(3);
            }

            // Return formatted path
            return path;
        }
    }
}
