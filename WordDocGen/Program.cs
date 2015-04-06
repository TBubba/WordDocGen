using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WordDocGen.Forms;

namespace WordDocGen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            // Start in debug mode (not crash-safe)
            Run();
#else
            // Start in normal (regular user) mode
            try
            {
                Run();
            }
            catch (Exception e)
            {
                // Filename of error file
                string errorPath = string.Format("{0}WordGenCrash_{1}.txt", AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.Ticks.ToString());

                // Format error message
                string error = string.Format("Message:\n{0}\n\nSource:\n{1}\n\nData:\n{2}\n\nTargetSite:\n{3}\n\nStackTrace:\n{4}",
                    e.Message, e.Source, e.Data, e.TargetSite, e.StackTrace);

                // Save error message in the file (after the dump)
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(errorPath, true))
                {
                    // Write error message in file
                    sw.Write(error + "\n\n"); // Extra spacing between error message and dump

                    // Close file
                    sw.Close();
                }

                // Add dump to error file
                MiniDump.MiniDumpToFile(errorPath);

                // Open crash window
                new CrashForm(error).ShowDialog();
            }
#endif
        }

        static void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
