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




namespace Music.LCD
{
	
	public partial class Flasher : Form
    {
		public Senddata senddata = new Senddata();
		private String filePath;
		private String fileNameChoosen;
		private String selectedCOM;
		private String directory = AppDomain.CurrentDomain.BaseDirectory;
		private String selectedModel;
		string link1, link2, link3, link4, NewestArduinoFirmwareVersion;
		public Flasher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void Flasher_Load(object sender, EventArgs e)
		{
			gradients();
			// Fetch data from PHP script
			try
			{
				using (WebClient client = new WebClient())
				{
					string data = client.DownloadString("http://newestversion.xlx.pl/links.php");

					using (StringReader reader = new StringReader(data))
					{
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							string[] parts = line.Split('|');
							if (parts.Length >= 2)
							{
								string name = parts[0];
								string value = parts[1];

								if (name == "version")
								{
									NewestArduinoFirmwareVersion = value;
								}
								else
								{
									switch (name)
									{
										case "link1":
											link1 = value;
											break;
										case "link2":
											link2 = value;
											break;
										case "link3":
											link3 = value;
											break;
										case "link4":
											link4 = value;
											break;
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1 form1 = new Form1();
				form1.LogWrite("err", "cannot connect to the server" + ex.ToString(), true);
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
			ShoworHidesendData(false);
			FlashProgress.Style = ProgressBarStyle.Blocks;
			FlashProgress.Value = 0;
			FlashProgress.Style = ProgressBarStyle.Marquee;
			selectedCOM = ArdCOM.Text;
			selectedModel = ArdModel.Text;
			directory = AppDomain.CurrentDomain.BaseDirectory;

			if (LiqCry.Checked && LCD2004.Checked)
			{

				//LIQCRY 2004
				if(File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-2004.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-2004.hex";
					backgroundWorker1.RunWorkerAsync();
				} else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (LiqCryI2C.Checked && LCD2004.Checked)
			{

				//LIQCRYI2C-2004
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-2004.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-2004.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCS.Checked && LCD2004.Checked)
			{

				//BCS-2004
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCS-2004.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-BCS-2004.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCSI2C.Checked && LCD2004.Checked) 
			{

				//BCSI2C-2004
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCSI2C-2004.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-BCSI2C-2004.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (LiqCry.Checked && LCD1602.Checked)
			{

				//LIQCRY-1602
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-1602.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-1602.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (LiqCryI2C.Checked && LCD1602.Checked)
			{

				//LIQCRYI2C-1602
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-1602.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-1602.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCS.Checked && LCD1602.Checked)
			{

				//BCS-1602
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCS-1602.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-BCS-1602.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}

			} else if (BCSI2C.Checked && LCD1602.Checked)
			{

				//BCSI2C-1602
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCSI2C-1602.hex"))
				{
					fileNameChoosen = "MLCD-" + NewestArduinoFirmwareVersion + @"-BCSI2C-1602.hex";
					backgroundWorker1.RunWorkerAsync();
				}
				else
				{
					ShowFileNotFoundErrorMessageBox();
				}
			}
			
			

			
		}
		private void uploadToArduino()
		{

            System.IO.Directory.CreateDirectory(directory + @"Temp");
			filePath = directory + @"Temp/" + fileNameChoosen;
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
					FlashProgress.Style = ProgressBarStyle.Blocks;
					FlashProgress.Value = 100; this.Close(); 					
					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); 
					flashdone.Show();

				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
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
					ShoworHidesendData(false);
					uploader.UploadSketch();
                    ShoworHidesendData(true);
					FlashProgress.Style = ProgressBarStyle.Blocks;
					FlashProgress.Value = 100; this.Close(); 					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); flashdone.Show();

				} catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
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
                    ShoworHidesendData(true);
					FlashProgress.Style = ProgressBarStyle.Blocks;
					FlashProgress.Value = 100; this.Close(); 					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); flashdone.Show();
				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
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
                    ShoworHidesendData(true);
					FlashProgress.Style = ProgressBarStyle.Blocks;
					FlashProgress.Value = 100; this.Close(); 					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); flashdone.Show();
				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
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
					FlashProgress.Style = ProgressBarStyle.Blocks;
					FlashProgress.Value = 100; this.Close(); 					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); flashdone.Show();
				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
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
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
				//FlashProgress.Style = ProgressBarStyle.Blocks;
				//FlashProgress.Value = 100; this.Close();
				ShoworHidesendData(true);
				flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie();
				flashdone.Show();
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
                    ShoworHidesendData(true);
					FlashProgress.Style = ProgressBarStyle.Blocks;
					FlashProgress.Value = 100; this.Close(); 					flashdonehappyyaynodie flashdone = new flashdonehappyyaynodie(); flashdone.Show();
				}
				catch (Exception ex) { ShowErrorWhileFlashingArduino(ex.ToString()); ShoworHidesendData(true); }
			}
		}

		//message box for File not found
		private void ShowErrorWhileFlashingArduino(string error)
		{
			//FIKU ADD ERROR MSG
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

			if (LiqCry.Checked && LCD2004.Checked)
			{
				//LIQCRY 2004
				Uri url = new Uri(link1);
				webClient.DownloadFileAsync(url, @"Temp/MLCD-"+ NewestArduinoFirmwareVersion + "-LIQCRY-2004.hex");
			}
			else if (LiqCryI2C.Checked && LCD2004.Checked)
			{
				//LIQCRYI2C-2004
				Uri url = new Uri(link2);
				webClient.DownloadFileAsync(url, @"Temp/MLCD-" + NewestArduinoFirmwareVersion + " - LIQCRYI2C-2004.hex");
			}
			else if (LiqCry.Checked && LCD1602.Checked)
			{

				//LIQCRY-1602
				Uri url = new Uri(link3);
				webClient.DownloadFileAsync(url, @"Temp/MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRY-1602.hex");
			}
			else if (LiqCryI2C.Checked && LCD1602.Checked)
			{

				//LIQCRYI2C-1602
				Uri url = new Uri(link4);
				webClient.DownloadFileAsync(url, @"Temp/MLCD-" + NewestArduinoFirmwareVersion + "-LIQCRYI2C-1602.hex");
			}
			
		}

		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			DownloadProgress.Value = e.ProgressPercentage;
			
		}
		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
            okunderstand.Visible = false;
            errico.Visible = false;
            errtext.Visible = false;
            oktext.Visible = true;
            okico.Visible = true;
            System.Media.SystemSounds.Asterisk.Play();
            oktext.Text = "Download complete.";
        }

		private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			ShoworHidesendData(true);
		}

		private void showFileDoesNotExist()
		{
			
		}

		private void CheckPorts_Tick(object sender, EventArgs e)
		{
			ShoworHidesendData(true);
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


			if (LiqCry.Checked && LCD2004.Checked)
			{

				//LIQCRY 2004
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-2004.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-2004.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCS-2004.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCSI2C-2004.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRY-1602.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-LIQCRYI2C-1602.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCS-1602.hex"))
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
				if (File.Exists(directory + @"Temp/MLCD-" + NewestArduinoFirmwareVersion + @"-BCSI2C-1602.hex"))
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

		private void ShoworHidesendData(bool hide)
		{

			if (hide)
			{
				if (!senddata.IsDisposed)
				{
					senddata.Close();
				}
			} else
			{
				
				senddata.Show();
			}
		}
	}
}
