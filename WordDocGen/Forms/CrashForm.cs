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
    internal partial class CrashForm : Form
    {
        // Constructor(s)
        internal CrashForm(string error)
        {
            InitializeComponent();

            // Set window title
            Text = Language.CrashTitle;

            // Set "Send message" button text
            _b.Text = Language.CrashSend;

            // Show error message
            _rtbError.Text = error;
        }

        // Events
    }
}
