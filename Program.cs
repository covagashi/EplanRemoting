using System;
using System.Diagnostics;
using System.IO;

namespace EPLAN_Launcher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eplanPath = @"C:\Program Files\EPLAN\Electric P8\2023.0.3\Bin\W3u.exe";
            if (!string.IsNullOrEmpty(eplanPath))
            {
                ExecuteEplan(eplanPath);
            }
        }

        

        private static void ExecuteEplan(string eplanPath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = eplanPath,
                Arguments = "Actionname",
                WindowStyle = ProcessWindowStyle.Normal
            };

            Process.Start(startInfo);
        }
    }
}