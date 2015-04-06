using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WordDocGen.DataTypes;

namespace WordDocGen.Forms
{
    internal partial class SubjectSettingsForm : Form
    {
        // Private
        private bool _changed;
        private BindingList<UserSubject> _subjects;

        // Internal
        /// <summary>
        /// Whether or not the user changed any settings
        /// </summary>
        internal bool Changed
        { get { return _changed; } }
        /// <summary>
        /// Current list of subjects (not necessarily saved)
        /// </summary>
        internal List<UserSubject> Subjects
        {
            get
            {
                // Copy list
                List<UserSubject> subs = new List<UserSubject>();
                int length = _subjects.Count;
                for (int i = 0; i < length; i++)
                    subs.Add(_subjects[i]);

                return subs;
            }
        }

        // Constructor(s)
        internal SubjectSettingsForm()
        {
            InitializeComponent();

            // Language
            _lSubject.Text = Language.SubjectsSubject;
            _lFolder.Text = Language.SubjectsFolderPath;
        }

        //
        internal void Setup(List<UserSubject> subjects)
        {
            // Creates a list for all subjects
            _subjects = new BindingList<UserSubject>();

            // Sets subject list as data source
            _lbSubjects.DataSource = _subjects;

            // Copy subjects to data source list
            int length = subjects.Count;
            for (int i = 0; i < length; i++)
                Add(new UserSubject(subjects[i]));

            // Enable the text field events
            ApplyChanged();
        }

        private void LockPanels() // Disables the user from interacting with the settings
        {
            // Lock panels
            _tbSubject.ReadOnly = true;
            _tbFolder.ReadOnly = true;

            // Clear text
            _tbSubject.Text = "";
            _tbFolder.Text = "";
        }
        private void UnlockPanels() // Enables the user to interact with the settings
        {
            // Unlock panels
            _tbSubject.ReadOnly = false;
            _tbFolder.ReadOnly = false;
        }

        // Subjects
        private void Add(UserSubject subject)
        {
            // Unlock panels
            if (_subjects.Count == 0)
                UnlockPanels();

            // Add subjects
            _subjects.Add(new UserSubject(subject));

            // If it is the only subject in the list
            if (_subjects.Count == 1)
            {
                // Select it
                _lbSubjects.SelectedIndex = -1;
                _lbSubjects.SelectedIndex = 0;
            }
        }
        private bool Remove(UserSubject subject)
        {
            // Remove subject from list (try to)
            bool success = _subjects.Remove(subject);

            // Lock panels if there are no subject left
            if (_subjects.Count == 0)
                LockPanels();
            
            // Returns whether or not the subject was removed (found)
            return success;
        }
        private void Clear()
        {
            // Clear list (remove all)
            _subjects.Clear();

            // Lock panels
            LockPanels();
        }

        private void Copy(UserSubject subject)
        {
            // Clear the clipboard
            Clipboard.Clear();

            // Copy subject data to the clipboard
            Clipboard.SetData("UserSubject", subject);
        }
        private bool Paste()
        {
            // Get subject from clipboard
            UserSubject sub = (UserSubject)Clipboard.GetData("UserSubject");
            
            // Abort if no subject data was found (in the clipboard)
            if (sub == null)
                return false;

            // Add a new subject with copied data
            Add(new UserSubject(sub));

            // Success
            return true;
        }

        private UserSubject GetCurrent()
        {
            // Return null if no subject is selected
            if (_lbSubjects.SelectedIndex == -1)
                return null;

            // Return selected subject
            return (UserSubject)_lbSubjects.SelectedItem;
        }
        private void RefreshSubjects()
        {
            // Add a subject and then remove it (causes a refresh)
            UserSubject sub = new UserSubject("", "");
            _subjects.Add(sub);
            _subjects.Remove(sub);
        }

        // Subject Fields Changed
        private void ApplyChanged()
        {
            // Adds method handlers to events
            _tbSubject.TextChanged += _tbSubject_TextChanged; // Subject name text field
            _tbFolder.TextChanged += _tbFolder_TextChanged; // Subject folder path text field
        }
        private void RemoveChanged()
        {
            // Removed method handlers from events
            _tbSubject.TextChanged -= _tbSubject_TextChanged; // Subject name text field
            _tbFolder.TextChanged -= _tbFolder_TextChanged; // Subject folder path text field
        }

        // Changed
        private void SubjectChanged()
        {
            // Remembers the change (for warning the user if they forgets to save)
            if (_changed != true)
            {
                _changed = true;
                Text += " *";
            }
        }
        private void SubjectChanged(object sender, EventArgs e)
        {
            // Calls the actual method (this is just for the event)
            SubjectChanged();
        }

        // Events
        private void _msiAdd_Click(object sender, EventArgs e) // "Create new (subject)"
        {
            // Create (and add) a new subject
            Add(new UserSubject(string.Format("{0}{1}", Language.SubjectsDefaultName, ((_subjects.Count > 0) ? ("(" + (_subjects.Count + 1) + ")") : "")), ""));

            // Settings changed
            SubjectChanged();
        }

        private void taBortToolStripMenuItem_Click(object sender, EventArgs e) // "Remove (subject)"
        {
            // Remove 
            bool success = Remove(GetCurrent());

            // Select adjacent subject in list (deselect if there are none)
            int index = _lbSubjects.SelectedIndex;
            _lbSubjects.SelectedIndex = -1;
            _lbSubjects.SelectedIndex = index;

            // If the subject was removed
            if (success)
                SubjectChanged(); // Settings were changed
        }

        private void _msiEmpty_Click(object sender, EventArgs e) // "Clear (subjects)"
        {
            // Abort if there are no subjects
            if (_subjects.Count == 0)
                return;

            // Open window asking if the user is sure
            DialogResult result = MessageBox.Show(Language.SubjectsClearText, Language.SubjectsClearTitle, MessageBoxButtons.YesNo, MessageBoxIcon.None);

            // If the user was sure
            if (result == DialogResult.Yes)
            {
                // Clear subject list
                Clear();

                // Settings were changed
                SubjectChanged();
            }
        }

        void _lbSubjects_SelectedIndexChanged(object sender, EventArgs e) // Selected another subject
        {
            // Get selected subject
            UserSubject sub = (UserSubject)_lbSubjects.SelectedItem;
            if (sub == null)
                return;

            // Disable text field events (temporarily)
            RemoveChanged();

            // Copy subject data from newly selected subject to the text fields
            _tbSubject.Text = sub.Name;
            _tbFolder.Text = sub.FolderPath;

            // Enable the text field events again
            ApplyChanged();
        }

        void _tbSubject_TextChanged(object sender, EventArgs e) // Subject name text field changed
        {
            // Get selected subject
            UserSubject sub = GetCurrent();
            if (sub == null)
                return;

            // Set selected subjects name to the same as the text fields (update subject in list)
            sub.Name = _tbSubject.Text;

            // Refresh subject list
            RefreshSubjects();

            // Settings changed
            SubjectChanged();
        }

        void _tbFolder_TextChanged(object sender, EventArgs e) // Folder path text field changed
        {
            // Get selected subject
            UserSubject sub = GetCurrent();
            if (sub == null)
                return;

            // Set selected subjects fold path to the same as the text fields (update subject in list)
            sub.FolderPath = _tbFolder.Text;

            // Settings changed
            SubjectChanged();
        }

        private void _bFindPath_Click(object sender, EventArgs e) // Coose a subject folder (and get path)
        {
            // Open folder chooser window
            DialogResult result = _fbdFolder.ShowDialog();

            // If the user picks a folder
            if (result == DialogResult.OK)
            {
                // Set folder path field text to the picked folder path
                _tbFolder.Text = _fbdFolder.SelectedPath;

                // Settings changed
                SubjectChanged();
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e) // KeyDown (keyboard input)
        {
            // If the user presses [Esc]
            if (e.KeyCode == Keys.Escape)
            {
                // Close (this) window
                Close();
            }

            // If the user presses [Ctrl] + [C]
            if (e.KeyCode == Keys.C && e.Control)
            {
                // Copy selected subjects data
                Copy(GetCurrent());
            }

            // If the user presses [Ctrl] + [V]
            if (e.KeyCode == Keys.V && e.Control)
            {
                // Get (previously copied)  
                bool success = Paste();

                // If the clipboard contained subject data
                if (success)
                    SubjectChanged(); // Settings were changed
            }
        }

        private void SubjectSettingsForm_FormClosing(object sender, FormClosingEventArgs e) // Window is closing
        {
            // If there are unsaved settings (and the user closed the window)
            if (_changed && DialogResult != DialogResult.OK)
            {
                // Open save popup (ask if the user wants to save)
                DialogResult result = MessageBox.Show(Language.SavePopupText, Language.SavePopupTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);

                // If the user wants to save
                if (result == DialogResult.Yes)
                    DialogResult = DialogResult.OK;

                // If the user do not want to save
                if (result == DialogResult.No)
                    _changed = false;

                // If the user canceled
                if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
