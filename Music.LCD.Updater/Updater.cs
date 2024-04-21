using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using System.Net.Http;
using System.IO;
using System.IO.Ports;
using System.Net;
using HtmlAgilityPack;
using AngleSharp.Html.Parser;
using System.Net.NetworkInformation;
using AngleSharp.Html.Dom;
using System.Diagnostics;

namespace Music.LCD.Updater
{

    public partial class Updater : Form
    {
        private string newestVersion;
		private String directory = AppDomain.CurrentDomain.BaseDirectory.Replace(@"\Music.LCD.Updater", "");
        private string currentDate = System.DateTime.Now.ToString();
        private int overallProgressInt = 0;

		public Updater()
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
        private static HttpClient _client = new HttpClient();

        private static async Task<string> GetHtmlAsync(string uri)
        {
            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
        private async void Updater_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show(directory);
            gradients();
            try
            {
                string htmlContent = await GetHtmlAsync("https://fikusystems.github.io/Music.LCD.WebService/Music.LCD.WebService.appVersion.html");
                var parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(htmlContent);
                // Extract the link and version
                var versionNode = document.QuerySelector("#version");
                newestVersion = versionNode != null ? versionNode.TextContent.Trim() : null;
                label6.Text = "new version: " + newestVersion;

            } catch (Exception ex)
            {
                displayError("Can't connect to the server: " + ex);
            }
            if (Process.GetProcessesByName("Music.LCD").Length > 0)
            {
                try
                {
                    Process[] localByName = Process.GetProcessesByName("Music.LCD");
                    foreach (Process p in localByName)
                    {
                        p.Kill();
                    }
                } catch { }

            } else
            {
                if (File.Exists(directory + @"\Temp\Music.LCD.Installer.exe"))
                {
                    Process.Start(directory + @"\Temp\Music.LCD.Installer.exe", "-s" + currentDate);
                } else
                {
                    //  NoUpdates noUpdates = new NoUpdates();
                    displayError("Update cannot be performed due to lack of update files. Please download the update files from Music.LCD when an update becomes avalible.");
                    // noUpdates.Show();
                }
			} 
			
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/FikuSystems/MusicLCD");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music.LCD.Installer.Logs") && File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music.LCD.Installer.Logs\Music.LCD.Installer.Log " + currentDate + ".txt"))
            {
                string tmp = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Music.LCD.Installer.Logs\Music.LCD.Installer.Log " + currentDate + ".txt");
                if (tmp.Contains("Progress$"))
                {
                    tmp = tmp.Substring(tmp.IndexOf("Progress$") + 9, 3);
                    overallProgressInt = Convert.ToInt16(tmp);
                }
			}
            if (overallProgressInt <= 15)
            {//Gathering
                gatherProgress.Value = overallProgressInt;
            } else if (overallProgressInt > 15 && overallProgressInt <= 30)
            {//Backup
                
                BackupProgress.Value = overallProgressInt;
            } else if (overallProgressInt > 30 && overallProgressInt < 100)
            {//Apply
                BackupProgress.Value = overallProgressInt;
			} else if (overallProgressInt == 100)
            {//Updated
                updatedone();
			}
			OverallProgress.Value = overallProgressInt;
        }
        private void updatedone()
        {
            label2.Text = "Opening Music LCD in 5 seconds...";
            label3.Visible = false;
            label4.Visible = false;
            BackupProgress.Visible = false;
            InstallProgress.Visible = false;
            OverallProgress.Visible = false;
            timer2.Enabled = true;
            gatherProgress.Value = 0;
            gatherProgress.SetState(2);
        }
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			gatherProgress.Value = e.ProgressPercentage;
		}

		private void button1_Click(object sender, EventArgs e)
        {
            updatedone();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatedone();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            gatherProgress.Increment(1);
            if (gatherProgress.Value == 100)
            {
                // start mlcd
                timer2.Stop();
                Application.Exit();
            }
        }

        void displayError(string message)
        {
            NoUpdates noupdates = new NoUpdates();
            noupdates.titlelabel.Text = "Update has failed";
            noupdates.descriptionlabel.Text = "An error has been encountered";
            noupdates.bodylabel.Text = $"The updater updater has performed an illegal operation and will be closed.\r\nIf the problem persists, contact the program vendor.\r\n\r\nError information:\r\n{message}";
            noupdates.Show();
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.Enabled = false;
        }
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
