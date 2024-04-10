using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.IO.Compression;
using Microsoft.Win32;

namespace Music.LCD.Installer
{
    //TEST
    public partial class Installer : Form
    {

		public int PageNumber;
        public string choosenPath;
        public bool silentStart;
        private static string Currentdate = System.DateTime.Now.ToString().Replace(".", "-").Replace(":", ".");
		public Installer()
        {
            InitializeComponent();

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
        private void Form1_Load(object sender, EventArgs e)
        {
            saveFileLogs("Music LCD Install Logs\r\n(c) FikuSystems 2024\r\n==================================================================");
			if (Program.CommandLineArgs != null)
            {
                string[] args = Program.CommandLineArgs;
                foreach (string arg in args)
                {
                    if (arg == "-s")
                    {
                        silentStart = true; break;
                    }
                    else
                    {
                        silentStart = false; break;
                    }
                }
            }

            if (silentStart)
            {
                this.Hide();
                ShowInTaskbar = false;
                choosenPath = AppDomain.CurrentDomain.BaseDirectory.Replace(@"Temp\", "");
                MessageBox.Show(choosenPath);
                copyingFiles.RunWorkerAsync();
            }
            else
            {
                gradients();
                filepath.Text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Music.LCD";
            }
            Selectinstalllocation.Visible = false;
            shortcuts.Visible = false;
            instruct.Visible = false;
            installation.Visible = false;
            Complete.Visible = false;
            backbtn.Enabled = false;

            PageNumber = 0;
            this.Size = new System.Drawing.Size(793, 417);
        }
        private void gradients()
        {
            panel1.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(86, 165, 132),
                    Color.FromArgb(62, 120, 96),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
                }
            };
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/FikuSystems/MusicLCD");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageNumber += 1;
            if (PageNumber == 0)
            {
                Selectinstalllocation.Visible = false;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = false;
                instalprogress.Value = 0;
                s1.Font = new Font("Segoe UI", 9);
                label4.Text = "Welcome!";
            }
            if (PageNumber == 1)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = true;
                instalprogress.Value = 1;
                s1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s2.Font = new Font("Segoe UI", 9);
                label4.Text = "Preperation";
            }
            if (PageNumber == 2)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 2;
                s1.Font = new Font("Segoe UI", 9);
                s2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s3.Font = new Font("Segoe UI", 9);
                label4.Text = "Preperation";
            }
            if (PageNumber == 3)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 3;
                s2.Font = new Font("Segoe UI", 9);
                s3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s4.Font = new Font("Segoe UI", 9);
                label4.Text = "Preperation";
            }
            if (PageNumber == 4)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = false;
                nextbtn.Enabled = false;
                backbtn.Enabled = false;
                exitbtn.Enabled = false;
                instalprogress.Value = 4;
                label4.Text = "Installation";
                s3.Font = new Font("Segoe UI", 9);
                s4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s8.Font = new Font("Segoe UI", 12);

                copyingFiles.RunWorkerAsync();

            }
            if (PageNumber == 5)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = true;
                nextbtn.Enabled = true;
                instalprogress.Value = 5;
                label4.Text = "Installation Complete!";
                s4.Font = new Font("Segoe UI", 9);
                s8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                nextbtn.Text = "Finish";
            }
            if (PageNumber == 6)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageNumber -= 1;
            if (PageNumber == 0)
            {
                Selectinstalllocation.Visible = false;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = false;
                instalprogress.Value = 0;
                s1.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 1)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = true;
                instalprogress.Value = 1;
                s1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s2.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 2)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 2;
                s1.Font = new Font("Segoe UI", 9);
                s2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s3.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 3)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 3;
                s2.Font = new Font("Segoe UI", 9);
                s3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s4.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 4)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = false;
                nextbtn.Enabled = true;
                backbtn.Enabled = false;
                exitbtn.Enabled = false;
                instalprogress.Value = 4;
                s3.Font = new Font("Segoe UI", 9);
                s4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s8.Font = new Font("Segoe UI", 12);
            }
            if (PageNumber == 5)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = true;
                nextbtn.Enabled = true;
                instalprogress.Value = 5;
                s4.Font = new Font("Segoe UI", 9);
                s8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                nextbtn.Text = "Finish";
            }
            if (PageNumber == 6)
            {
                Application.Exit();
            }
        }
        void createShortcuts()
        {
            if (cdesktopshortcut.Checked)
            {
				string data = "Option Explicit\n" + "Dim objShell, objShortcut\n" + @"Set objShell = CreateObject(""WScript.Shell"")" + "\nDim TargetPath, ShortcutName\n" + "TargetPath = \"" + choosenPath + "Music.LCD.exe\"" + "\n" + @"ShortcutName = ""Music.LCD""" + "\n" + @"Set objShortcut = objShell.CreateShortcut(objShell.SpecialFolders(""Desktop"") & ""\"" & ShortcutName & "".lnk"")" + "\nobjShortcut.TargetPath = TargetPath\nobjShortcut.Save\nSet objShortcut = Nothing\nSet objShell = Nothing\n";
				File.Create(choosenPath + "createDesktopShort.vbs").Close();
				TextWriter vbs = new StreamWriter(choosenPath + @"\createDesktopShort.vbs");
				vbs.Write(data);
				vbs.Close();
				System.Diagnostics.Process.Start(choosenPath + @"\createDesktopShort.vbs");

			}
            if (cstartmenufolder.Checked)
            {
				string data = "Option Explicit\n" + "Dim objShell, objShortcut\n" + @"Set objShell = CreateObject(""WScript.Shell"")" + "\nDim TargetPath, ShortcutName\n" + "TargetPath = \"" + choosenPath + "Music.LCD.exe\"" + "\n" + @"ShortcutName = ""Music.LCD""" + "\n" + @"Set objShortcut = objShell.CreateShortcut(objShell.SpecialFolders(""StartMenu"") & ""\"" & ""Programs"" &""\""& ShortcutName & "".lnk"")" + "\nobjShortcut.TargetPath = TargetPath\nobjShortcut.Save\nSet objShortcut = Nothing\nSet objShell = Nothing\n";
				File.Create(choosenPath + "createStartShort.vbs").Close();
				TextWriter vbs = new StreamWriter(choosenPath + @"\createStartShort.vbs");
				vbs.Write(data);
				vbs.Close();
				System.Diagnostics.Process.Start(choosenPath + @"\createStartShort.vbs");
			}
            
		}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void copyingFiles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
			nextbtn.Enabled = true;
			nextbtn.PerformClick();
		}

        private void copyingFiles_DoWork(object sender, DoWorkEventArgs e)
        {
            if (silentStart)
            {

                if (!Directory.Exists(choosenPath + @"InstallTemp"))
                {
                    DirectoryInfo di = Directory.CreateDirectory(choosenPath + @"InstallTemp");
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                string resourceName = "Music.LCD.Installer.Resources.Music.LCD.zip";

                using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    byte[] buffer = new byte[resourceStream.Length];
                    resourceStream.Read(buffer, 0, buffer.Length);
                    try
                    {
                        File.WriteAllBytes(Path.Combine(choosenPath + @"InstallTemp", "MusicLCD.zip"), buffer);
                    }
                    catch { }
                }

                DirectoryInfo dir = Directory.CreateDirectory(choosenPath + @"Music.LCD.Old");
                dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                string sourceDir = choosenPath;
                string destDir = choosenPath + @"Music.LCD.Old";
                Directory.CreateDirectory(destDir);
                string[] files = Directory.GetFiles(sourceDir);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (true)
                    {
                        string destFile = Path.Combine(destDir, fileName);
                        File.Copy(file, destFile, true);
                    }
                }
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName != @"config.MLCD")
                    {
                        File.Delete(file);
                    }
                }

                ZipFile.ExtractToDirectory(choosenPath + @"InstallTemp\MusicLCD.zip", choosenPath);
                File.Delete(choosenPath + @"InstallTemp\MusicLCD.zip");
                Directory.Delete(choosenPath + @"InstallTemp");
				//unsinstaller

				if (silentStart)
                {
                    this.Close();
                }
            }
            else
            {
                choosenPath = filepath.Text;
                if (!Directory.Exists(choosenPath))
                {
                    Directory.CreateDirectory(choosenPath);
                }
                choosenPath += @"\";
                if (!Directory.Exists(choosenPath + @"InstallTemp"))
                {
                    DirectoryInfo di = Directory.CreateDirectory(choosenPath + @"InstallTemp");
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                string resourceName = "Music.LCD.Installer.Resources.Music.LCD.zip";

                using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    byte[] buffer = new byte[resourceStream.Length];
                    resourceStream.Read(buffer, 0, buffer.Length);
                    try
                    {
                        File.WriteAllBytes(Path.Combine(choosenPath + @"InstallTemp", "MusicLCD.zip"), buffer);
                    }
                    catch { }
                }
				string resourceIcon = "Music.LCD.Installer.Resources.favicon.ico";
				using (Stream resourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceIcon))
				{
					byte[] buffer = new byte[resourceStream.Length];
					resourceStream.Read(buffer, 0, buffer.Length);
					try
					{
						File.WriteAllBytes(Path.Combine(choosenPath, "Music.LCD.ico"), buffer);
					}
					catch { }
				}
				DirectoryInfo dir = Directory.CreateDirectory(choosenPath + @"Music.LCD.Old");
                dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                string sourceDir = choosenPath;
                string destDir = choosenPath + @"Music.LCD.Old";
                Directory.CreateDirectory(destDir);
                string[] files = Directory.GetFiles(sourceDir);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName != "Music.LCD.ico")
                    {
                        string destFile = Path.Combine(destDir, fileName);
                        File.Copy(file, destFile, true);
                    }
                }
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName != "Music.LCD.ico")
                    {
                        File.Delete(file);
                    }
                }
                ZipFile.ExtractToDirectory(choosenPath + @"InstallTemp\MusicLCD.zip", choosenPath);
                File.Delete(choosenPath + @"InstallTemp\MusicLCD.zip");
                Directory.Delete(choosenPath + @"InstallTemp");
                createShortcuts();
                RegistryKey key = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MusicLCD\", true);
                key.SetValue("DisplayName", "Music.LCD");
				key.SetValue("UninstallString", choosenPath + "Music.LCD.Uninstaller.exe");
                key.SetValue("DisplayIcon", choosenPath + "Music.LCD.ico");
                key.SetValue("Publisher", "FikuSystems");
                key.SetValue("HelpLink", @"https:\\www.fikusystems.com\");
                key.SetValue("InstallLocation", choosenPath);
                key.SetValue("DisplayVersion", "0.0.0.5");
                key.SetValue("URLInfoAbout", @"https:\\www.fikusystems.com\");
                key.Close();
            }
        }
		

		private void openexplorer_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath.Text = folderBrowserDialog1.SelectedPath + @"\Music.LCD";
                choosenPath = filepath.Text;
            }
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
            
		}
        private void saveFileLogs(string text)
        {
            
			string path = @"C:\Music.LCD.Installer.Logs\";
			if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
           
            if (File.Exists(path  + "Music.LCD.Installer.Log " + Currentdate + ".txt"))
            {
				text = File.ReadAllText(path + "Music.LCD.Installer.Log " + Currentdate + ".txt").ToString() + text;
			}
            File.WriteAllText(path + "Music.LCD.Installer.Log " + Currentdate + ".txt", text);
        }

	}

}