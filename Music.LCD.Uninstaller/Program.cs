using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.LCD.Uninstaller
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			/*
			if (!IsRunAsAdmin())
			{
				ElevateProcess();
				return;
			}
			*/
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Uninstaller());
        }
		static bool IsRunAsAdmin()
		{
			WindowsIdentity identity = WindowsIdentity.GetCurrent();
			WindowsPrincipal principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}
		static void ElevateProcess()
		{
			var exeName = Process.GetCurrentProcess().MainModule.FileName;
			ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
			startInfo.Verb = "runas";
			Process.Start(startInfo);
			Application.Exit();
		}
	}
}
