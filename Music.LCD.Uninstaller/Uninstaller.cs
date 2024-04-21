using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Music.LCD.Uninstaller
{
    public partial class Uninstaller : Form
    {
        public Uninstaller()
        {
            InitializeComponent();
			gradients();
		}
		private void gradients()
		{
			panel1.Paint += (sender, e) =>
			{
				using (LinearGradientBrush brush = new LinearGradientBrush(
					panel1.ClientRectangle,
					Color.FromArgb(255, 70, 50),
					Color.FromArgb(255, 30, 30),
					LinearGradientMode.Vertical))
				{
					e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
				}
			};
		}
		private void BeginUninstall()
		{
			if (Process.GetProcessesByName("Music.LCD").Length > 0)
			{
				try
				{
					Process[] localByName = Process.GetProcessesByName("Music.LCD");
					foreach (Process p in localByName)
					{
						p.Kill();
					}
				}
				catch { }

			}
			if (Process.GetProcessesByName("Music.LCD.Installer").Length > 0)
			{
				try
				{
					Process[] localByName = Process.GetProcessesByName("Music.LCD.Installer");
					foreach (Process p in localByName)
					{
						p.Kill();
					}
				}
				catch { }

			}
			if (Process.GetProcessesByName("Music.LCD.Updater").Length > 0)
			{
				try
				{
					Process[] localByName = Process.GetProcessesByName("Music.LCD.Updater");
					foreach (Process p in localByName)
					{
						p.Kill();
					}
				}
				catch { }

			}
			string installLocation = null;
			try { 
				RegistryKey keyRead = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\MusicLCD");
				installLocation = keyRead.GetValue("InstallLocation").ToString();
				keyRead.Close();
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = @"/c reg delete ""HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MusicLCD"" /f";
				process.StartInfo.Verb = "runas";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
			} catch(Exception ex) { //can't delete registry
			}

			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"Music.LCD.lnk"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"Music.LCD.lnk");
			}
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\Programs\Music.LCD.lnk"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\Programs\Music.LCD.lnk");
            }
			try
			{
				clearFolder(installLocation);
				Directory.Delete(installLocation);
			} catch (Exception ex) { }
			
			
		}
		private void clearFolder(string FolderName)
		{
			DirectoryInfo dir = new DirectoryInfo(FolderName);

			foreach (FileInfo fi in dir.GetFiles())
			{
				fi.Delete();
			}

			foreach (DirectoryInfo di in dir.GetDirectories())
			{
				clearFolder(di.FullName);
				di.Delete();
			}
		}

		private void Uninstaller_Load(object sender, EventArgs e)
		{

		}

		static void InitiateSelfDestructSequence()
		{
			string batchScriptPath = "Music.LCD.Installer.exe.delete.bat";
			using (StreamWriter writer = File.AppendText(batchScriptPath))
			{
				writer.WriteLine(":Loop");
				writer.WriteLine("Tasklist /fi \"PID eq " + Process.GetCurrentProcess().Id.ToString() + "\" | find \":\"");
				writer.WriteLine("if Errorlevel 1 (");
				writer.WriteLine("  Timeout /T 1 /Nobreak");
				writer.WriteLine("  Goto Loop");
				writer.WriteLine(")");
				writer.WriteLine("Del \"" + (new FileInfo((new Uri(Assembly.GetExecutingAssembly().CodeBase)).LocalPath)).Name + "\"");
			}
			Process.Start(new ProcessStartInfo() { Arguments = "/C " + batchScriptPath + " & Del " + batchScriptPath, WindowStyle = ProcessWindowStyle.Hidden, CreateNoWindow = true, FileName = "cmd.exe" });
			Application.Exit();
			return;
		}
	} 
    
}
