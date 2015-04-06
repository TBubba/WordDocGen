using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordDocGen
{
    /// <summary>
    /// Contains all the words and phrases for various forms and such
    /// </summary>
    internal static class Language
    {
        // Svenska / Swedish (sv) (Not complete)
        // Save popup (When a settings-window is closed without saving)
        internal static readonly string SavePopupTitle = "Spara?"; // Window title
        internal static readonly string SavePopupText = "Vill du spara innan du stänger fönstret?"; // Popup-text

        // Crash popup (If the program crashes)
        internal static readonly string CrashTitle = "Krash"; // Window title
        internal static readonly string CrashSend = "Skicka Krash-data"; // Send error message button text

        // Help popup (Contains additional informaton about the program)
        internal static readonly string HelpTitle = "Hjälp"; // Window title

        // Subjects Settings (Where the user changes settings about their subjects)
        internal static readonly string SubjectsTitle = "Ämnen (inställningar)"; // Window title
        internal static readonly string SubjectsSubject = "Ämne:"; // Subject name field text
        internal static readonly string SubjectsFolderPath = "Sökväg:"; // Subject folder path field text
        internal static readonly string SubjectsFindPath = "Hitta sökväg"; // Find subject folder button text
        internal static readonly string SubjectsApply = "Verkställ"; // Apply settings button text
        internal static readonly string SubjectsDefaultName = "Nytt ämne"; // Default name for new subjects (numbers will be added if name is taken)

        internal static readonly string SubjectsClearTitle = "Ta bort alla ämnen"; // Window title (for clear all subjects popup)
        internal static readonly string SubjectsClearText = "Är du säker på att du vill ta bort alla ämnen?"; // Popup-text (for clear all subjects popup)

        /* English (en) (Not complete)
        // Save popup (When a settings-window is closed without saving)
        internal static readonly string SavePopupTitle = "Save?"; // Window title
        internal static readonly string SavePopupText = "Do you want to save before closing?"; // Popup-text

        // Crash popup (If the program crashes)
        internal static readonly string CrashTitle = "Crash"; // Window title
        internal static readonly string CrashSend = "Send Crash-data"; // Send error message button text

        // Help popup (Contains additional informaton about the program)
        internal static readonly string HelpTitle = "Help"; // Window title

        // Subjects Settings (Where the user changes settings about their subjects)
        internal static readonly string SubjectsTitle = "Subjects (settings)"; // Window title
        internal static readonly string SubjectsSubject = "Subject:"; // Subject name field text
        internal static readonly string SubjectsFolderPath = "Path:"; // Subject folder path field text
        internal static readonly string SubjectsFindPath = "Find Path"; // Find subject folder button text
        internal static readonly string SubjectsApply = "Apply"; // Apply settings button text
        internal static readonly string SubjectsDefaultName = "New Subject"; // Default name for new subjects (numbers will be added if name is taken)

        internal static readonly string SubjectsClearTitle = "Remove all subjects"; // Window title (for clear all subjects popup)
        internal static readonly string SubjectsClearText = "Are you sure you want to remove all subjects?"; // Popup-text (for clear all subjects popup)
        */
    }
}
