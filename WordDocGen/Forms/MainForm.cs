using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Microsoft.Office.Interop.Word;
using WordDocGen.DataTypes;

namespace WordDocGen.Forms
{
    internal partial class MainForm : Form
    {
        // Constructor(s)
        internal MainForm()
        {
            InitializeComponent();
            
            // Load user settings
            WordDoc.LoadUserSettings();

            // Language
            //_lAssignment.Text = Lageuage.MainAssignment;
            _lSubject.Text = Language.SubjectsSubject;

            // Update subject list
            UpdateSubjectList();
        }

        //
        private void UpdateSubjectList()
        {
            // Update list (of subjects)
            _cbSubject.DataSource = WordDoc.User.Subjects;

            // Update the height of the drop-down menu
            _cbSubject.DropDownHeight = (WordDoc.User.Subjects.Count + 1) * _cbSubject.ItemHeight;
        }

        // Events
        private void KeyDownSelectNext(object sender, KeyEventArgs e) // KeyDown (Tabba)
        {
            // If the [Enter] is pressed
            if (e.KeyCode == Keys.Enter)
            {
                // Perform the same action as [TAB]
                SelectNextControl((Control)sender, true, true, false, false);
            }
        }

        private void genButtonClick(object sender, EventArgs e) // Create document
        {
            // Get current subject
            UserSubject sub = (UserSubject)_cbSubject.SelectedItem;

            // Cancel if no subject is selected
            if (sub == null)
                return;

            // Create document
            CreateDocumentError error = WordDoc.CreateDocument(WordDoc.User.FullName, WordDoc.User.Grade, sub.Name, _tbAssignment.Text, sub.FolderPath);

            // Catch errors
            switch (error)
            {
                case CreateDocumentError.WordNotInstalled: // Microsoft Word not found
                    MessageBox.Show("Microsoft Word was not found.", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
                case CreateDocumentError.PathDoesntMakeSense: // Path is invalid
                    MessageBox.Show("Document path is not valid.", "Error!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    break;
            }
        }

        private void folderSettingsToolStripMenuItem_Click(object sender, EventArgs e) // User settings
        {
            using (UserSettingsForm form = new UserSettingsForm())
            {
                // Set up the user settings form
                form.Setup(WordDoc.User.FullName, WordDoc.User.Grade);

                // Open the settings form
                DialogResult result = form.ShowDialog();

                // If the user chose to save
                if (result == DialogResult.OK)
                {
                    // Abort if no settings were changed
                    if (!form.Changed)
                        return;

                    // Update settings
                    WordDoc.User.FullName = form.FullName;
                    WordDoc.User.Grade = form.Grade;

                    // Save settings
                    WordDoc.SaveUserSettings();
                }
            }
        }

        private void identitySettingsToolStripMenuItem_Click(object sender, EventArgs e) // Ämnen
        {
            using (SubjectSettingsForm form = new SubjectSettingsForm())
            {
                // Set up the subjects form
                form.Setup(WordDoc.User.Subjects);

                // Open the subjects form
                DialogResult result = form.ShowDialog();

                // If the user chose to save
                if (result == DialogResult.OK)
                {
                    // Abort if no settings were changed
                    if (!form.Changed)
                        return;

                    // Update settings
                    WordDoc.User.Subjects = form.Subjects;

                    // Update list of subjects
                    UpdateSubjectList();

                    // Save settings
                    WordDoc.SaveUserSettings();
                }
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e) // Hjälp
        {
            using (HelpForm form = new HelpForm())
            {
                // Open the help form
                form.ShowDialog();
            }
        }
    }
}