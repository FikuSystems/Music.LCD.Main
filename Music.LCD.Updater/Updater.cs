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

namespace Music.LCD.Updater
{

    public partial class Updater : Form
    {
        private string link1, newestVersion;
		private String directory = AppDomain.CurrentDomain.BaseDirectory;

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
            gradients();
            try
            {
                string htmlContent = await GetHtmlAsync("https://fikusystems.github.io/Music.LCD.WebService/Music.LCD.WebService.appVersion.html");
                var parser = new HtmlParser();
                var document = await parser.ParseDocumentAsync(htmlContent);
                // Extract the link and version
                var link1Node = document.QuerySelector("#link1");
                link1 = link1Node != null ? link1Node.TextContent.Trim() : null;
                var versionNode = document.QuerySelector("#version");
                newestVersion = versionNode != null ? versionNode.TextContent.Trim() : null;
                label6.Text = "new version: " + newestVersion;

            } catch (Exception ex)
            {
                displayError("Can't connect to the server: " + ex);
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
            OverallProgress.Value = DownloadProgress.Value + BackupProgress.Value + InstallProgress.Value;
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
            DownloadProgress.Value = 0;
            DownloadProgress.SetState(2);
        }
        void downloadUpdate()
        {
            if (!Directory.Exists(directory + @"UpdateTemp"))
            {
				DirectoryInfo di = Directory.CreateDirectory(directory + @"UpdateTemp");
				di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
			}
			WebClient webClient = new WebClient();
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
			Uri url = new Uri(link1);
			webClient.DownloadFileAsync(url, @"");
			
		}
		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			DownloadProgress.Value = e.ProgressPercentage;
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
            DownloadProgress.Increment(1);
            if (DownloadProgress.Value == 100)
            {
                // start mlcd
                timer2.Stop();
                Application.Exit();
            }
        }

        void displayError(string message)
        {

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
