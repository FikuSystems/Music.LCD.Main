using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
			if (AppDomain.CurrentDomain.BaseDirectory.ToString() != Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp\")
			{
				string tempFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Temp\";
				string tempUninstallerPath = Path.Combine(tempFolder, "Music.LCD.Uninstaller.exe");
				CopyUninstallerToTemp(tempUninstallerPath);
				Process.Start(tempUninstallerPath);
				Application.Exit();
				return;
			} 
			if (!IsRunAsAdmin())
			{
				ElevateProcess();
				return;
			}
			

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
		private static void CopyUninstallerToTemp(string tempUninstallerPath)
		{
			try
			{
				// Copy the uninstaller executable to the temporary folder
				string originalUninstallerPath = Application.ExecutablePath;
				File.Copy(originalUninstallerPath, tempUninstallerPath, true);
			}
			catch {}
		}
	}
}
