using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.LCD.Installer
{

    internal static class Program
    {
		public static string[] CommandLineArgs { get; private set; }
		/// <summary>
		/// </summary>
		[STAThread]

		static void Main(string[] args)
		{
			CommandLineArgs = args;
			if (!IsRunAsAdmin())
			{
				ElevateProcess();
				return;
			}
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
			string tmp = Application.ExecutablePath;
			foreach (string arg in CommandLineArgs)
			{
				if (arg == "-s")
				{
					tmp += " -s";
					break;
				}
			}

			try
			{
				Process.Start(tmp);
			}
			catch {}
		}

	}
}
