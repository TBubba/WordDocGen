using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordDocGen.Forms
{
    internal partial class UserSettingsForm : Form
    {
        // Private
        private bool _changed;

        // Internal
        internal string FullName
        { get { return _tbFullName.Text; } }
        internal string Grade
        { get { return _tbGrade.Text; } }

        internal bool Changed
        { get { return _changed; } }

        // Constructor(s)
        internal UserSettingsForm()
        {
            InitializeComponent();
        }
        
        //
        internal void Setup(string fullName, string grade)
        {
            _tbFullName.Text = fullName;
            _tbGrade.Text = grade;

            _tbFullName.TextChanged += TextChanged;
            _tbGrade.TextChanged += TextChanged;
        }

        // Text
        private void TextChanged(object sender, EventArgs e)
        {
            if (_changed != true)
            {
                _changed = true;
                Text += " *";
            }
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            // Om användaren trycker ESC
            if (e.KeyCode == Keys.Escape)
            {
                // Stäng fönstret
                Close();
            }
        }

        private void UserSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ifall användaren stänger fönstret
            if (_changed && DialogResult != DialogResult.OK)
            {
                // Öppna dialog
                DialogResult result = MessageBox.Show(Language.SavePopupText, Language.SavePopupTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.None);

                // Om användaren valde att spara
                if (result == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                }

                // Om användaren valde att inte spara
                if (result == DialogResult.No)
                {
                    _changed = false;
                }

                // Om användaren valde att avbryta
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
