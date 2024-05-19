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
	
	public partial class Flasher : Form
    {
		public Senddata senddata = new Senddata();
		private String filePath;
		private String fileNameChoosen;
		private String selectedCOM;
		private String directory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Music.LCD\";
		private String selectedModel;
		string link1, link2, link3, link4, NewestArduinoFirmwareVersion;
		private bool downloadError;
		private string lastDownloaded;

		public Flasher()
        {
            InitializeComponent();
        }
		public void checksumInvalidButtonClicked(bool button)
		{//true - cancel		false - continue anyway
			if (button && File.Exists(directory + lastDownloaded))
			{
				try
				{
					File.Delete(directory + lastDownloaded);
				} catch {}
				
			} 
		}
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
		private static HttpClient _client = new HttpClient();

		private static async Task<string> GetHtmlAsync(string uri)
		{
			var response = await _client.GetAsync(uri);
			response.EnsureSuccessStatusCode();
			return await response.Content.ReadAsStringAsync();
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
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        private async void Flasher_Load(object sender, EventArgs e)
		{
			gradients();
			// Fetch data from PHP script
			try
			{
				string htmlContent = await GetHtmlAsync("https://fikusystems.github.io/Music.LCD.WebService/Music.LCD.WebService.Versions.html");
				var parser = new HtmlParser();
				var document = await parser.ParseDocumentAsync(htmlContent);
				// Extract the links and version
				var link1Node = document.QuerySelector("#link1");
				link1 = link1Node != null ? link1Node.TextContent.Trim() : null;
				var link2Node = document.QuerySelector("#link2");
				link2 = link2Node != null ? link2Node.TextContent.Trim() : null;
				var link3Node = document.QuerySelector("#link3");
				link3 = link3Node != null ? link3Node.TextContent.Trim() : null;
				var link4Node = document.QuerySelector("#link4");
				link4 = link4Node != null ? link4Node.TextContent.Trim() : null;
				var versionNode = document.QuerySelector("#version");
				NewestArduinoFirmwareVersion = versionNode != null ? versionNode.TextContent.Trim() : null;
			}
			catch (Exception ex)
			{
				Form1 form1 = new Form1();
				form1.LogWrite("err", "Cannot connect to the server", "Server Error" + ex.ToString(), true);
			}
		}


		private void button7_Click(object sender, EventArgs e)
        {
            okunderstand.Visible = false;
            errico.Visible = false;
            errtext.Visible = false;
            oktext.Visible = true;
            okico.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FlashCatcher flashCatcher = new FlashCatcher();
            flashCatcher.Show();
        }

		private void Flash_Click(object sender, EventArgs e)
		{
			
			FlashProgress.Value = 0;
			FlashProgress.Style = ProgressBarStyle.Marquee;
			selectedCOM = ArdCOM.Text;
			selectedModel = ArdModel.Text;
			string currentDir = AppDomain.CurrentDomain.BaseDirectory.ToString();
			if (LiqCry.Checked && LCD2004.Checked)
			{

				//LIQCRY 2004
				if(File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-2004.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-2004.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				} else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (LiqCryI2C.Checked && LCD2004.Checked)
			{

				//LIQCRYI2C-2004
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-2004.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-2004.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCS.Checked && LCD2004.Checked)
			{

				//BCS-2004
				if (File.Exists(currentDir + @"MLCD-BCSLIQCRY-2004.hex"))
				{
					fileNameChoosen = "MLCD-BCSLIQCRY-2004.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCSI2C.Checked && LCD2004.Checked) 
			{

				//BCSI2C-2004
				if (File.Exists(currentDir + @"MLCD-BCSI2C-2004.hex"))
				{
					fileNameChoosen = "MLCD-BCSI2C-2004.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (LiqCry.Checked && LCD1602.Checked)
			{

				//LIQCRY-1602
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-1602.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-1602.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (LiqCryI2C.Checked && LCD1602.Checked)
			{

				//LIQCRYI2C-1602
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-1602.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-1602.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCS.Checked && LCD1602.Checked)
			{

				//BCS-1602
				if (File.Exists(currentDir + @"MLCD-BCSLIQCRY-1602.hex"))
				{
					fileNameChoosen = "MLCD-BCSLIQCRY-1602.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCSI2C.Checked && LCD1602.Checked)
			{

				//BCSI2C-1602
				if (File.Exists(currentDir + @"MLCD-BCSI2C-1602.hex"))
				{
					fileNameChoosen = "MLCD-BCSI2C-1602.hex";
					senddata.Show();
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}
			}
			
			

			
		}
		private void flasherror()
		{
            //Form1 form1 = new Form1(); form1.LogWrite("err", "Failed to flash", false);
        }
		private void uploadToArduino()
		{


			
			if (fileNameChoosen.Contains("BCS"))
			{
				filePath = AppDomain.CurrentDomain.BaseDirectory + fileNameChoosen;
			} else
			{
				filePath = directory + fileNameChoosen;
			}
			if (selectedModel == "Leonardo - ATMega32U4")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.Leonardo
				});

				try
				{
					uploader.UploadSketch();
					
 					
					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); 
					flashdone.Show();

				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror(); }
			}
			else if (selectedModel == "Mega 1284 - ATMega1284")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.Mega1284
				});
				try
				{
					uploader.UploadSketch();
					
 					


				} catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror(); }
			}
			else if (selectedModel == "Mega 2560 - ATMega2560")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.Mega2560
				});
				try
				{
					uploader.UploadSketch();
					


				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror(); }
			}
			else if (selectedModel == "Micro - ATMega32U4")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.Micro
				});
				try
				{
					uploader.UploadSketch();
					
 					

				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror(); }
			}
			else if (selectedModel == "Nano (R2)    - ATMega168")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.NanoR2
				});
				try
				{
					uploader.UploadSketch();
				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror(); }
			}
			else if (selectedModel == "Nano (R3) (Ex) - ATMega328P")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.NanoR3
				});

				try 
				{	
					uploader.UploadSketch();
					


				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror();  }
			}
			else if (selectedModel == "Uno (R3) - ATMega328P")
			{
				var uploader = new ArduinoSketchUploader(
				new ArduinoSketchUploaderOptions()
				{
					FileName = filePath,
					PortName = selectedCOM,
					ArduinoModel = ArduinoModel.UnoR3
				});
				try
				{
					uploader.UploadSketch();
					
 					

				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); flasherror(); }
			}
		}

		//message box for File not found
		private void ShowErrorWhileFlashingArduino(string error)
		{
            MessageBox.Show($"{error}");
            try
			{
			
			}
			catch
			{
				MessageBox.Show($"{error}");
			}
        }
		private void ShowFileNotFoundErrorMessageBox()
		{
			// Create and show the MessageBox
			// MessageBox.Show("File not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            okunderstand.Visible = true;
            errico.Visible = true;
            errtext.Visible = true;
            oktext.Visible = false;
            okico.Visible = false;
			System.Media.SystemSounds.Asterisk.Play();
            errtext.Text = "Downloaded file not found. Please download file to flash.";
        }

		private void Download_Click(object sender, EventArgs e)
		{
			
			WebClient webClient = new WebClient();
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            
		//	form1.LogWrite("info", "Load success", true);
            if (LiqCry.Checked && LCD2004.Checked)
			{
				//LIQCRY 2004
				Uri url = new Uri(link1);
				webClient.DownloadFileAsync(url, directory + @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRY-2004.hex");
			}
			else if (LiqCryI2C.Checked && LCD2004.Checked)
			{
				//LIQCRYI2C-2004
				Uri url = new Uri(link2);
				webClient.DownloadFileAsync(url, directory + @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRYI2C-2004.hex");
			}
			else if (LiqCry.Checked && LCD1602.Checked)
			{

				//LIQCRY-1602
				Uri url = new Uri(link3);
				webClient.DownloadFileAsync(url, directory + @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRY-1602.hex");
			}
			else if (LiqCryI2C.Checked && LCD1602.Checked)
			{

				//LIQCRYI2C-1602
				Uri url = new Uri(link4);
				webClient.DownloadFileAsync(url, directory + @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRYI2C-1602.hex");
			}
			
		}

		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			DownloadProgress.Value = e.ProgressPercentage;
		}
		private async void Chekcksum()
		{
			string filename = null;
			string fileChecksum = null, link1Checksum = null, link2Checksum = null, link3Checksum = null, link4Checksum = null;
			try
			{
				string htmlContent = await GetHtmlAsync("https://fikusystems.github.io/Music.LCD.WebService/Music.LCD.Checksum.html");
				var parser = new HtmlParser();
				var document = await parser.ParseDocumentAsync(htmlContent);
				// Extract the links and version
				var link1Node = document.QuerySelector("#link1");
				link1Checksum = link1Node != null ? link1Node.TextContent.Trim() : null;
				var link2Node = document.QuerySelector("#link2");
				link2Checksum = link2Node != null ? link2Node.TextContent.Trim() : null;
				var link3Node = document.QuerySelector("#link3");
				link3Checksum = link3Node != null ? link3Node.TextContent.Trim() : null;
				var link4Node = document.QuerySelector("#link4");
				link4Checksum = link4Node != null ? link4Node.TextContent.Trim() : null;
			}
			catch (Exception ex)
			{
				Form1 form1 = new Form1();
				form1.LogWrite("err", "Cannot connect to the server.", "Server Error" + ex.ToString(), true);
			}
			if (LiqCry.Checked && LCD2004.Checked)
			{
				//LIQCRY 2004
				filename = @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRY-2004.hex";
				fileChecksum = link1Checksum;
			}
			else if (LiqCryI2C.Checked && LCD2004.Checked)
			{
				//LIQCRYI2C-2004
				filename = @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRYI2C-2004.hex";
				fileChecksum = link2Checksum;
			}
			else if (LiqCry.Checked && LCD1602.Checked)
			{

				//LIQCRY-1602
				filename = @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRY-1602.hex";
				fileChecksum = link3Checksum;
			}
			else if (LiqCryI2C.Checked && LCD1602.Checked)
			{

				//LIQCRYI2C-1602
				filename = @"MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRYI2C-1602.hex";
				fileChecksum = link4Checksum;
			}
			lastDownloaded = directory + filename;
			if(fileChecksum != CalculateMD5(lastDownloaded).ToString())
			{

				if (!downloadError)
				{
					downloadError = true;
					Download.PerformClick();
				}
				else
				{
					downloadError = false;
					checksuminvalid checksuminvalid = new checksuminvalid("Flasher"); checksuminvalid.Show();
				}
			}
			


		}

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			senddata.Hide();
			FlashProgress.Style = ProgressBarStyle.Blocks;
			FlashProgress.Value = 100; this.Hide();
			flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); flashdone.Show();
		}

        private void ArdSoftRep_Click(object sender, EventArgs e)
        {

        }

        private void LCD2004_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LiqCryI2C_CheckedChanged(object sender, EventArgs e)
        {
			groupBox2.Enabled = true;
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

		private void LiqCry_CheckedChanged(object sender, EventArgs e)
		{
			groupBox2.Enabled = true;
		}

		private void BCSI2C_CheckedChanged(object sender, EventArgs e)
		{
			groupBox2.Enabled = false;
		}

		private void BCS_CheckedChanged(object sender, EventArgs e)
		{
			groupBox2.Enabled = false;
		}

		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			Chekcksum();
			okunderstand.Visible = false;
            errico.Visible = false;
            errtext.Visible = false;
            oktext.Visible = true;
            okico.Visible = true;
            System.Media.SystemSounds.Asterisk.Play();
            oktext.Text = "Download complete.";
        }

		private void showFileDoesNotExist()
		{
			
		}

		private void CheckPorts_Tick(object sender, EventArgs e)
		{
			if (ArdCOM.Text.ToString() == "") 
			{
				try
				{
					if (ArdCOM.Text.ToString() == "")
					{
						string[] ports = SerialPort.GetPortNames();
						ArdCOM.Items.Clear();
						foreach (string comport in ports)
						{
							ArdCOM.Items.Add(comport);
						}


					}
				}
				catch { }
			}

			string currentDir = AppDomain.CurrentDomain.BaseDirectory.ToString();
			if (LiqCry.Checked && LCD2004.Checked)
			{

				//LIQCRY 2004
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-2004.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if(ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (LiqCryI2C.Checked && LCD2004.Checked)
			{

				//LIQCRYI2C-2004
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-2004.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (BCS.Checked && LCD2004.Checked)
			{

				//BCS-2004
				if (File.Exists(currentDir + @"MLCD-BCSLIQCRY-2004.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (BCSI2C.Checked && LCD2004.Checked)
			{
				//BCSI2C-2004
				if (File.Exists(currentDir + @"MLCD-BCSI2C-2004.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (LiqCry.Checked && LCD1602.Checked)
			{

				//LIQCRY-1602
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-1602.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (LiqCryI2C.Checked && LCD1602.Checked)
			{

				//LIQCRYI2C-1602
				if (File.Exists(directory + @"MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-1602.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (BCS.Checked && LCD1602.Checked)
			{

				//BCS-1602
				if (File.Exists(currentDir + @"MLCD-BCSLIQCRY-1602.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}

			}
			else if (BCSI2C.Checked && LCD1602.Checked)
			{

				//BCSI2C-1602
				if (File.Exists(currentDir + @"MLCD-BCSI2C-1602.hex"))
				{
					if (!ArdModel.Enabled)
					{
						ArdModel.Enabled = true;
					}
					if (ArdModel.Text != "" && !ArdCOM.Enabled)
					{
						ArdCOM.Enabled = true;
					}
					if (ArdCOM.Text != "" && !Flash.Enabled)
					{
						Flash.Enabled = true;
					}
				}
				else
				{
					if (ArdModel.Enabled)
					{
						ArdModel.Enabled = false;
					}
					if (ArdCOM.Enabled)
					{
						ArdCOM.Enabled = false;
					}
					if (Flash.Enabled)
					{
						Flash.Enabled = false;
					}
					showFileDoesNotExist();
				}
			}
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			uploadToArduino();
		}
	}
}
