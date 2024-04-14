using ArduinoUploader;
using ArduinoUploader.Hardware;
using Music.LCD.Properties;
using System;
using System.Drawing;
using System.ComponentModel;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
using System.Net.Http;
using AngleSharp.Html.Parser;
using System.Security.Cryptography;
using System.Text;
using AngleSharp.Io;
using System.Diagnostics;

namespace Music.LCD
{
	public partial class DownloadUtility : Form
	{
		string directory = AppDomain.CurrentDomain.BaseDirectory;
		string link5, NewestVersion;
		bool downloadError;
		public DownloadUtility()
		{
			InitializeComponent();
		}
		public void checksumInvalidButtonClicked(bool button)
		{//true - cancel		false - continue anyway
			if (button && File.Exists(directory + @"\Temp\Music.LCD.Installer.exe"))
			{
				try
				{
					File.Delete(directory + @"\Temp\Music.LCD.Installer.exe");
				}
				catch { }

			} else
			{
				BeginUpdate();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private static HttpClient _client = new HttpClient();
		private static async Task<string> GetHtmlAsync(string uri)
		{
			var response = await _client.GetAsync(uri);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
		}
		private async void DownloadUtility_Load(object sender, EventArgs e)
		{
			gradients();
			try
			{
				string htmlContent = await GetHtmlAsync("https://fikusystems.github.io/Music.LCD.WebService/Music.LCD.WebService.Versions.html");
				var parser = new HtmlParser();
				var document = await parser.ParseDocumentAsync(htmlContent);
				// Extract the links and version
				var link1Node = document.QuerySelector("#link1");
				link5 = link1Node != null ? link1Node.TextContent.Trim() : null;
				var versionNode = document.QuerySelector("#version");
				NewestVersion = versionNode != null ? versionNode.TextContent.Trim() : null;
			}
			catch (Exception ex)
			{
				Form1 form1 = new Form1();
				form1.LogWrite("err", "cannot connect to the server" + ex.ToString(), true);
			}
			NewVersion.Text = NewestVersion;


		}
		private void gradients()
		{
            panel6.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel6.ClientRectangle,
                    Color.FromArgb(242, 177, 0),
                    Color.FromArgb(252, 205, 77),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel6.ClientRectangle); ;
                }
            };
        }

		private void button2_Click(object sender, EventArgs e)
		{
			Directory.CreateDirectory(directory + @"\Temp");
			WebClient webClient = new WebClient();
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadCompleted);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
			Uri url = new Uri(link5);
			webClient.DownloadFileAsync(url, directory + @"Temp\Music.LCD.Installer.exe");
		}
		private async void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
		{
			string link5Checksum = null;
			try
			{
				string htmlContent = await GetHtmlAsync("https://fikusystems.github.io/Music.LCD.WebService/Music.LCD.Checksum.html");
				var parser = new HtmlParser();
				var document = await parser.ParseDocumentAsync(htmlContent);
				// Extract the links and version
				var link5Node = document.QuerySelector("#link5");
				link5Checksum = link5Node != null ? link5Node.TextContent.Trim() : null;
			}
			catch (Exception ex)
			{
				Form1 form1 = new Form1();
				form1.LogWrite("err", "cannot connect to the server" + ex.ToString(), true);
			}
			if (link5Checksum != CalculateMD5(directory + @"Temp\Music.LCD.Installer.exe").ToString())
			{
				if (!downloadError)
				{
					downloadError = true;
					button2.PerformClick();
				}
				else
				{
					downloadError = false;
					checksuminvalid checksuminvalid = new checksuminvalid("DownloadUtility"); checksuminvalid.Show();
				}
			} else
			{
				BeginUpdate();
			}
		}
		private void ProgressChanged(object sender,  DownloadProgressChangedEventArgs e)
		{

		}
		public static string CalculateMD5(string filename)
		{
			using (var md5 = MD5.Create())
			{
				using (var stream = File.OpenRead(filename))
				{
					return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
				}
			}
		}
		private void BeginUpdate()
		{
			//it is wrong will be changed, do not touch
			if (File.Exists(directory + @"\Temp\Music.LCD.Installer.exe"))
			{
				Process.Start(directory + @"\Temp\Music.LCD.Installer.exe", "-s");
			}
		}
	}
}
