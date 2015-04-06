using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WordDocGen
{
    /// <summary>
    /// Dumps data from this instance of the program
    /// (Useful for finding bugs when the program crashes)
    /// </summary>
    public class MiniDump
    {
        internal enum MINIDUMP_TYPE
        {
            MiniDumpNormal = 0x00000000,
            MiniDumpWithDataSegs = 0x00000001,
            MiniDumpWithFullMemory = 0x00000002,
            MiniDumpWithHandleData = 0x00000004,
            MiniDumpFilterMemory = 0x00000008,
            MiniDumpScanMemory = 0x00000010,
            MiniDumpWithUnloadedModules = 0x00000020,
            MiniDumpWithIndirectlyReferencedMemory = 0x00000040,
            MiniDumpFilterModulePaths = 0x00000080,
            MiniDumpWithProcessThreadData = 0x00000100,
            MiniDumpWithPrivateReadWriteMemory = 0x00000200,
            MiniDumpWithoutOptionalData = 0x00000400,
            MiniDumpWithFullMemoryInfo = 0x00000800,
            MiniDumpWithThreadInfo = 0x00001000,
            MiniDumpWithCodeSegs = 0x00002000
        }

        [DllImport("dbghelp.dll")]
        static extern bool MiniDumpWriteDump(
            IntPtr hProcess,
            Int32 ProcessId,
            IntPtr hFile,
            MINIDUMP_TYPE DumpType,
            IntPtr ExceptionParam,
            IntPtr UserStreamParam,
            IntPtr CallackParam);

        /// <summary>
        /// Creates a dump file based on the current state of the program
        /// </summary>
        /// <param name="dumpFilePath">Relative path to where the dump should be created</param>
        public static void MiniDumpToFile(String dumpFilePath)
        {
            FileStream fsToDump = null;
            if (File.Exists(dumpFilePath))
                fsToDump = File.Open(dumpFilePath, FileMode.Append);
            else
                fsToDump = File.Create(dumpFilePath);
            Process thisProcess = Process.GetCurrentProcess();
            MiniDumpWriteDump(thisProcess.Handle, thisProcess.Id,
                fsToDump.SafeFileHandle.DangerousGetHandle(), MINIDUMP_TYPE.MiniDumpNormal,
                IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
            fsToDump.Close();
        }
    };
}
