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
		int Pagenumber = 0;
        public Uninstaller()
        {
            InitializeComponent();
			gradients();
		}
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams Crp = base.CreateParams;
                Crp.ClassStyle = Crp.ClassStyle | CP_NOCLOSE_BUTTON;
                return Crp;
            }
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
			Pagenumber = Pagenumber + 1;
			
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

        private void button3_Click(object sender, EventArgs e)
        {
			if (Pagenumber == 2)
			{
				InitiateSelfDestructSequence();
			}
			else
			{
				Application.Exit();
			}
        }

        private void button1_Click(object sender, EventArgs e)
        {
			Pagenumber = Pagenumber + 1;
			pagenumber();
        }
		private void pagenumber()
		{
			if (Pagenumber == 0)
			{
				page1.Visible = true;
                page2.Visible = false;
				page3.Visible = false;
				button1.Text = "Next";
				button1.Enabled = true;
                button3.Enabled = true;
				s1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                s2.Font = new Font("Segoe UI", 12);
                s3.Font = new Font("Segoe UI", 12);
            }
            if (Pagenumber == 1)
            {
                page1.Visible = true;
                page2.Visible = true;
                page3.Visible = false;
                button1.Text = "Next";
                button1.Enabled = false;
                button3.Enabled = false;
				BeginUninstall();
                s1.Font = new Font("Segoe UI", 12);
                s2.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                s3.Font = new Font("Segoe UI", 12);
            }
            if (Pagenumber == 2)
            {
                page1.Visible = true;
                page2.Visible = true;
                page3.Visible = true;
                button1.Text = "Next";
                button1.Enabled = false;
                button3.Enabled = true;
                s1.Font = new Font("Segoe UI", 12);
                s2.Font = new Font("Segoe UI", 12);
                s3.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            }
        }
    } 
    
}
