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

namespace Music.LCD
{
	public partial class DownloadUtility : Form
	{
		string directory = AppDomain.CurrentDomain.BaseDirectory;
		string link5, NewestVersion;
		public DownloadUtility()
		{
			InitializeComponent();
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
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
			Uri url = new Uri(link5);
			webClient.DownloadFileAsync(url, @"Temp/Music.LCD.Installer.exe");
		}
		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			
		}
		private void ProgressChanged(object sender,  DownloadProgressChangedEventArgs e)
		{

		}
	}
}
