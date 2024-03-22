using System;
using System.Diagnostics;
using System.Security.Principal;
using System.Windows.Forms;

namespace Music.LCD.Installer
{

    internal static class Program
    {
		public static string[] CommandLineArgs { get; private set; }
		[STAThread]

		static void Main(string[] args)
		{
			CommandLineArgs = args;
			/*
			if (!IsRunAsAdmin())
			{
				//ElevateProcess();
				return;
			}
			*/
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Installer());
        }
		static bool IsRunAsAdmin()
		{
			WindowsIdentity identity = WindowsIdentity.GetCurrent();
			WindowsPrincipal principal = new WindowsPrincipal(identity);
			return principal.IsInRole(WindowsBuiltInRole.Administrator);
		}

		static void ElevateProcess()
		{
			string tmp = null;
			foreach (string arg in CommandLineArgs)
			{
				if (arg == "-s")
				{
					tmp = "-s";
					break;
				}
			}

			var exeName = Process.GetCurrentProcess().MainModule.FileName;
			ProcessStartInfo startInfo = new ProcessStartInfo(exeName);
			startInfo.Verb = "runas";
			startInfo.Arguments = tmp;
			Process.Start(startInfo);
			Application.Exit();
		}

	}
}
