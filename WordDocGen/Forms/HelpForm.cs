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
    public partial class HelpForm : Form
    {
        // Constructor(s)
        public HelpForm()
        {
            InitializeComponent();

            // Set window title
            Text = Language.HelpTitle;
        }

        // Events
        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            // If [Esc] is pressed
            if (e.KeyCode == Keys.Escape)
            {
                // Close (this) window
                Close();
            }
        }
    }
}
