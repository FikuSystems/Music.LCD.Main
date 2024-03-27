using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using WindowsMediaController;
using Windows.Media.Control;
using System.IO;
using System.ComponentModel;
using Microsoft.Win32;
using System.Net.Http;
using System.Drawing.Drawing2D;

namespace Music.LCD
{
    public partial class Form1 : Form
    {
		//TEST

		RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
		public bool pressed;
        public string finalData;
        public static String songTitle;
        public static String songArtist;
        public static String MaxMusic;
        public static String CurrentMusic;
		public int MaxMusicLastStateInt;
		public int CurrentMusicLastStateInt;
		public int MaxMusicInt;
		public int CurrentMusicInt;
		public static string COMData;
        public bool ForwardPressed;
        public bool PlayPausePressed;
        public bool BackPressed;
        static MediaManager mediaManager;
        public string playpausestatus;
        public bool connected = false;
        public string ArduinoHrdWareData;
        public string currentPath = AppDomain.CurrentDomain.BaseDirectory;
        public string[] config = { "COM1", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "1"};
        public bool fileCreate = false;
        public string eepromData = null;
        public bool closeApp = false;
        private string MusicLCDType;
        public static string NewestArduinCodeVersion;
        public Form1()
        {
            InitializeComponent();
			
			mediaManager = new MediaManager();
            mediaManager.OnAnyMediaPropertyChanged += MediaManager_OnAnyMediaPropertyChanged;
            mediaManager.OnAnyPlaybackStateChanged += MediaManager_OnAnyPlaybackStateChanged;
            mediaManager.OnAnyTimelinePropertyChanged += MediaManager_OnAnyTimelinePropertyChanged;
			mediaManager.StartAsync();
		}

		public int progressBarStatus()
		{
            int progressBarInt = 0;

			if (MaxMusicInt != 0 )
            {
				progressBarInt = CurrentMusicInt * 21 / MaxMusicInt;
				return progressBarInt;
			} else { return 0; }
            


		}


		public void findComPorts()
        {//Handles detecting arduino
            try
            {
                if(ComSelec.Text.ToString() == "")
                {
					string[] ports = SerialPort.GetPortNames();
					ComSelec.Items.Clear();
					foreach (string comport in ports)
					{
						ComSelec.Items.Add(comport);
					}

                    
				}
            } catch {}
            
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
        private async void Form1_Load(object sender, EventArgs e)
            
        {//Handles setting the settings group box to intended size
            gradients();
			string latestVersionUrl = "http://newestversion.xlx.pl/version.php";

			try
			{
				using (HttpClient client = new HttpClient())
				{
					HttpResponseMessage response = await client.GetAsync(latestVersionUrl);

					if (response.IsSuccessStatusCode)
					{
						string jsonString = await response.Content.ReadAsStringAsync();
						dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonString);

						string latestVersion = data.version;
                        NewestArduinCodeVersion = latestVersion;
					}
					else
					{
					}
				}
			}
			catch
			{
			}

			ReadConfigFile();
            if (config[4] == "1")
            {
				this.WindowState = FormWindowState.Minimized;
				this.ShowInTaskbar = false;
				LogWrite("info", "Hidden to tray", false);
			} else if (config[9] == "0")
            {
				welcome welcome = new welcome();
				welcome.Show();
			}
			LogWrite("deb", config[0], false);
            if (config[2] == "1")
            {
                findComPorts();

                try
                {
                    string[] ports = SerialPort.GetPortNames();


                    ComSelec.Items.Clear();
                    foreach (string comport in ports)
                    {
                        ComSelec.Items.Add(comport);
                        if (comport == config[0])
                        {
                            ComSelec.Text = comport;
                            button1.PerformClick();
                            break;
                        }
                    }
                } catch (Exception ex) { LogWrite("err", "Cannot get COM ports: " + ex, true); }
			} else if (config[3] == "1")
            {
				findComPorts();
                try
                {
                    string[] ports = SerialPort.GetPortNames();
                    ComSelec.Items.Clear();
                    foreach (string comport in ports)
                    {
                        ComSelec.Items.Add(comport);
                        if (comport == config[0])
                        {
                            LogWrite("deb", "found", true);
                            ComSelec.Text = comport;
                            break;
                        }
                    }
                } catch (Exception ex) { LogWrite("err", "Cannot get COM ports: " + ex, true); }
			}
            
			LogWrite("info", "Logging started", true);
            groupBox2.Size = new Size(427, 243);
            
            LogWrite("info", "Welcome opened", false);
			CurrentMusic = "00:00:00.0000000";
            MaxMusic = "00:00:00.0000001";
			

			LogWrite("info", "Load success", true);


		}

        private void button6_Click(object sender, EventArgs e)
        {//handles shrinking the settings box to show logs
            groupBox2.Size = new Size(199, 243);
            groupBox4.Show();
            button6.Hide();
            button7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {//handles expanding the settings box to hide logs
            groupBox2.Size = new Size(427, 243);
            groupBox4.Hide();
            button7.Hide();
            button6.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {//Opens COM PORT to start sending data
            if (ComSelec.Text != "")
            {
                if (playpausestatus == "Playing")
                {
                    await mediaManager.WindowsSessionManager.GetCurrentSession().TryPauseAsync();
                }
                button1.Enabled = false;
                button2.Enabled = true;
                soundMute.Enabled = true;
                ComSelec.Enabled = false;
                LogWrite("info", "Connect attempt", false);
                try
                {
                    if (!serialPort.IsOpen && ComSelec.SelectedItem.ToString() != "")
                    {
                        try
                        {
                            serialPort.PortName = ComSelec.Text.ToString();
                            serialPort.Open();
                            config[0] = serialPort.PortName.ToString();
                            Arduinosync.Start();

                            if (config[6] == "1")
                            {
                                this.WindowState = FormWindowState.Minimized;
                                this.ShowInTaskbar = false;
                                LogWrite("info", "Hidden to tray", false);
                            }
                        }
                        catch
                        {
                            LogWrite("err", "Connection fail", false);
                        }
                    }
                } catch (Exception ex) { LogWrite("err", "Cannot use serialPort: " + ex, true); }

                pressed = true;
                LogWrite("info", "Connection success", false);
                if (playpausestatus == "Paused")
                {
                    await mediaManager.WindowsSessionManager.GetCurrentSession().TryPlayAsync();
                }
            } else
            {

                WarningBox warningbox = new WarningBox();
                warningbox.Show();
                warningbox.warningtitle.Text = "COM port not selected.";
                warningbox.warningtext.Text = "Please select a COM port from the dropdown before connecting.";
                LogWrite("warn", "Please select COM port", false);
            }

           
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Handles consolidating titles and artist names to send to data

			//Handles finding comports every tick and settings label text to song titles, etc. Handles receiving infromation from arduino when song paused, skipped or backed
			if (!serialPort.IsOpen)
            {
				findComPorts();
			}

			LCDLN1.Text = songTitle;
            LCDLN2.Text = songArtist;
            label2.Text = ArduinoHrdWareData;
            
            
            
		} 
        private void MediaManager_OnAnyMediaPropertyChanged(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionMediaProperties args)
        {
            songArtist = args.Artist;
            songTitle = args.Title;
        }
		private  void MediaManager_OnAnyPlaybackStateChanged(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionPlaybackInfo args)
        {
            //Handles getting PLAY and PAUSED status
            playpausestatus = args.PlaybackStatus.ToString();
        }
        private void MediaManager_OnAnyTimelinePropertyChanged(MediaManager.MediaSession sender, GlobalSystemMediaTransportControlsSessionTimelineProperties args)
        {
            //gets current and max song position.
            MaxMusic = args.EndTime.ToString();
            CurrentMusic = args.Position.ToString();
		}
        public void Arduinosync_Tick(object sender, EventArgs e)
        {           
            //sends data every tick
            sendData();
		}


		public static string TimeSyncInt(int seconds)
		{
			string tmpmin = (seconds / 60).ToString();
			string tmpsec = (seconds % 60).ToString();
            if (tmpmin.Length == 1 && tmpsec.Length == 1)
            {
                return "0" + tmpmin + ":" + "0" + tmpsec;
            } else if (tmpmin.Length > 1 && tmpsec.Length > 1)
            {
                return tmpmin + ":" + tmpsec;
            } else if (tmpmin.Length > 1 && tmpsec.Length == 1)
            {
                return tmpmin + ":" + "0" + tmpsec;

            } else if (tmpmin.Length == 1 && tmpsec.Length > 1)
            {
				return "0" + tmpmin + ":" + tmpsec;
			} else
            {
                return null;
            }
			
		}

		public void sendData()
        {
            //Handles sending final data to the arduino
			if (pressed)
            {

                string L2 = null;
                string L1 = null;
                string L3 = null;
                string L4 = null;
				string L5 = null;
				try
                {
                    if(songTitle != null) 
                    {
                        
                        String artistRemoval = songArtist;
						artistRemoval = artistRemoval.Replace("Official", "");
						artistRemoval = artistRemoval.Replace("VEVO", "");
						L2 = Strings.RemoveDiacritics(songArtist);
                        L1 = Strings.RemoveDiacritics(songTitle);

                        // Reinsert spaces in the updated title
                        L1 = ReplaceIgnoreSpacesInTitle(L1, artistRemoval);
                       
                        
						L1 = L1.Replace("(Official Video)", "");
                        L1 = L1.Replace("(Official Music Video)", "");
						L1 = L1.Replace("(Official Lyric Video)", "");
						L1 = L1.Replace("(Lyric Video)", "");
						L1 = L1.Replace("(Lyrics)", "");

                        if (config[8] == "1")
                        {
                            L1 += "-";
                            if (L1.Contains("feat")) { L1 = L1.Replace(L1.Substring(L1.IndexOf("feat"), L1.IndexOf("-") - L1.IndexOf("feat") + 1), ""); }
                            if (L1.Contains("ft")) { L1 = L1.Replace(L1.Substring(L1.IndexOf("ft"), L1.IndexOf("-") - L1.IndexOf("ft")), ""); }
							
                            if(L1.Substring(L1.Length - 1, 1) == "-")
                            {
                                L1 = L1.Substring(0, L1.Length - 1);
                            } else if (L1.Substring(L1.Length - 1, 1) == "(")
                            {
								L1 = L1.Substring(0, L1.Length - 1);
							}
						}

					}
					else
                    {
                        L2 = Strings.RemoveDiacritics(songArtist);
                        L1 = "No media application";
                    }
                    
                }
                catch { }

                if (playpausestatus == "Playing")
                {
					L4 = progressBarStatus().ToString();
					L3 = TimeSyncInt(CurrentMusicInt) + " | " + MaxMusic.Substring(3, 5) + "   PLAY";
                    if(L3.Substring(8, 5) == "00:00")
                    {
                        L3 = "--:-- | --:--   PLAY";
						L4 = System.DateTime.Now.ToString().Substring(0, 10) + "  " + System.DateTime.Now.ToString().Substring(11, 8); 
					}
                    
				} else
                {
                    if(!string.IsNullOrEmpty(CurrentMusic) && !string.IsNullOrEmpty(MaxMusic))
                    {
                        L3 = CurrentMusic.Substring(3, 5) + " | " + MaxMusic.Substring(3, 5) + "  PAUSE";
						if (L3.Substring(8, 5) == "00:00")
						{
							L3 = "--:-- | --:--   PLAY";
						}

					}   
 
                    L4 = System.DateTime.Now.ToString().Substring(0, 10) + "  " + System.DateTime.Now.ToString().Substring(11,8); 
                }
				if (!string.IsNullOrEmpty(eepromData))
				{
					L5 = eepromData;
					eepromData = string.Empty;
				}
                if (MusicLCDType == "BCS")
                {
                    finalData = L1 + ">1" + L2 + ">2" + "\n";
                } else
                {
					finalData = L1 + ">1" + L2 + ">2" + L3 + ">3" + L4 + ">4" + L5 + "\n";
				}

				// Open the serial po

				try
                {
                    //writes data into the arduino
                    serialPort.Write(finalData);
                } catch { LogWrite("warn", "Writing data failed", false); }
                         

            }
            
        }
        private void HelpButtonClickeda(object sender, CancelEventArgs e)
        {
            About about = new About();
            about.Show();
            LogWrite("info", "About opened", false);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            button5.Enabled = false;
			Arduinosync.Stop();
			//Handles disconnecting from the arduino
			button2.Enabled = false;
            soundMute.Enabled = false;
            DisconnectDelay.Start();
            LogWrite("info", "Discconect attm.", false);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Exit application
            LogWrite("warn", "Application closing", true);
            if (connected)
            {
                closeAppSafetly();
            } else
            {
				Application.Exit();
			}

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //restart appliction (broken, to be fixed)
            LogWrite("warn", "Application restarting", true);
			if (connected)
			{
				writeConfigToFIle();
				if (serialPort.IsOpen)
				{
					try
					{
						button2.PerformClick();
					}
					catch (Exception ex) { LogWrite("err", ex.ToString(), true); }
					Application.Restart();
				}
			}
			else
			{
                Application.Restart();
			}
		}

        private void button3_Click(object sender, EventArgs e)
        {
            //Minimizes the window into the notificationicon
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            LogWrite("info", "Hidden to tray", false);
            ConfirmBox confirmbox = new ConfirmBox();
            confirmbox.Show();
            confirmbox.notificationtext.Text = "MusicLCD is hidden to your system tray. If a problem is encountered, the application will show a notification. Double click the icon to open the main control panel.";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Shows the window after dubble click of notifictation icon
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            LogWrite("info", "Unhidden to tray", false);
        }

		private async void MusicTimeSyncroniser_Tick(object sender, EventArgs e)
		{
            if (closeApp)
            {
                Application.Exit();
			}
            if(fileCreate)
            {
                config[9] = "1";
                checkBox1.Checked = true;
                writeConfigToFIle();
            }

            if (WindowState != FormWindowState.Minimized && config[5] == "0")
            {
				notifyIcon1.Visible = false;
			} else
            {
				notifyIcon1.Visible = true;
			}
			if (!string.IsNullOrEmpty(COMData) && COMData.Length > 1)
			{

                if (COMData.Substring(0, 1) == "0")
                {
                    if (!BackPressed)
                    {
						await mediaManager.WindowsSessionManager.GetCurrentSession().TrySkipPreviousAsync();
                        BackPressed = true;
					}
                    
                } else if (COMData.Substring(0, 1) == "1")
                {
                    BackPressed = false;
                }

				if (COMData.Substring(1, 1) == "0")
				{
					if (!PlayPausePressed)
					{
						await mediaManager.WindowsSessionManager.GetCurrentSession().TryTogglePlayPauseAsync();
                        PlayPausePressed = true;
					}
	
				} else if (COMData.Substring(1, 1) == "1")
                {
                    PlayPausePressed = false;
                }
				if (COMData.Substring(2, 1) == "0")
				{
                    if(!ForwardPressed)
                    {
						await mediaManager.WindowsSessionManager.GetCurrentSession().TrySkipNextAsync();
                        ForwardPressed = true;
					}
					
				} else if (COMData.Substring(2, 1) == "1")
                {
                    ForwardPressed = false;
                }

			}
            

			if (playpausestatus == "Playing")
            {
		        MusictimeTimer.Start();

            } else if (playpausestatus == "Paused")
            {
                MusictimeTimer.Stop();
				MaxMusicLastStateInt = 0;
				CurrentMusicLastStateInt = 0;
			}
            
		}

		private void MusictimeTimer_Tick(object sender, EventArgs e)
		{
            String CTimemin = CurrentMusic.Substring(3, 2);//min
            String CTimesec = CurrentMusic.Substring(6, 2);//sec
            int tmpCurrTime = Int32.Parse(CTimemin) * 60 + Int32.Parse(CTimesec);
            if(tmpCurrTime == CurrentMusicLastStateInt )
            {
                CurrentMusicInt++;
			} else 
            {
                CurrentMusicInt = tmpCurrTime;
            }
            CurrentMusicLastStateInt = tmpCurrTime;

			String Maximemin = MaxMusic.Substring(3, 2);//min
			String Maximesec = MaxMusic.Substring(6, 2);//sec
			int tmpMaxTime = Int32.Parse(Maximemin) * 60 + Int32.Parse(Maximesec);
			MaxMusicInt = tmpMaxTime;






		}
	

    private void ComSelec_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    private void button8_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen && !DisconnectDelay.Enabled)
            {
				button2.PerformClick();
			}
			Flasher flasher = new Flasher();   
            flasher.Show();
            LogWrite("info", "Flasher opened", false);
        }
		string ReplaceIgnoreSpacesInTitle(string input, string pattern)
		{
            string text = input;
            if (pattern.Contains(text.Substring(0, text.IndexOf(" ")))) {
                text = text.Replace(text.Substring(0, text.IndexOf(" ")) + " ", "");
                text = ReplaceIgnoreSpacesInTitle(text, pattern);
			} else
            {
				if (text.Substring(0, 2) == "- ")
				{
					text = text.Remove(0, 2);
				}
			}
            return text;
   		}




        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string tmp = serialPort.ReadLine();
                if (!connected && tmp.Length > 4)
                {
                    ArduinoHrdWareData = tmp;

                    if (ArduinoHrdWareData.Contains("T:") && ArduinoHrdWareData.Contains("V:") && ArduinoHrdWareData.Substring(ArduinoHrdWareData.IndexOf("T:") + 2, ArduinoHrdWareData.IndexOf("V:") - ArduinoHrdWareData.IndexOf("T:") - 3) == "BCS 16x02" | ArduinoHrdWareData.Substring(ArduinoHrdWareData.IndexOf("T:") + 2, ArduinoHrdWareData.IndexOf("V:") - ArduinoHrdWareData.IndexOf("T:") - 3) == "BCS 20x4")
                    {
                        MusicLCDType = "BCS";
                    }
                    else
                    {
                        MusicLCDType = ArduinoHrdWareData.Substring(ArduinoHrdWareData.IndexOf("T:") + 2, ArduinoHrdWareData.IndexOf("V:") - ArduinoHrdWareData.IndexOf("T:") - 3);
                    }
                    connected = true;
                    ArduinoHrdWareData = ArduinoHrdWareData.Replace("T:", " ");
                    ArduinoHrdWareData = ArduinoHrdWareData.Replace("V:", " ");
                }
                else
                {
                    COMData = tmp;
                }
            } catch(Exception ex) { LogWrite("err", "Cannot read from COM port: " + ex, true); }

		}

		

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Logbox.SelectionStart = Logbox.Text.Length;
            // scroll it automatically
            Logbox.ScrollToCaret();

        }

		

        private void ReadConfigFile()
        {
            string read = null;

            if (File.Exists(currentPath + "config.MLCD"))
            {
                read = File.ReadAllText(currentPath + "config.MLCD");

                if (read.Contains("com_port = "))
                {
                    config[0] = read.Substring(read.IndexOf("com_port = ") + 11, read.IndexOf("start_logon = ") - read.IndexOf("com_port = ") - 12);
                    if (!string.IsNullOrEmpty(config[0]))
                    {
						serialPort.PortName = config[0];
					}
                    
                } else
                {
                    LogWrite("warn", "config property: com_port failed", false);
                }

                if (read.Contains("start_logon = "))
                {
                    config[1] = read.Substring(read.IndexOf("start_logon = ") + 14, 1);
                    if (Convert.ToInt16(config[1]) == 1)
                    {
                        startlogon.Checked = true;
                    }
                    else
                    {
                        startlogon.Checked = false;
                    }
                }
                else {
                    LogWrite("warn", "config property: start_logon failed", false);
                }


                if (read.Contains("auto_con = "))
                {
                    config[2] = read.Substring(read.IndexOf("auto_con = ") + 11, 1);
                    if (Convert.ToInt16(config[2]) == 1)
                    {
                        autoconn.Checked = true;
                    } else
                    {
                        autoconn.Checked = false;
                    }
                } else
                {
					LogWrite("warn", "config property: auto_con failed", false);
				}

				if (read.Contains("save_com = "))
				{ 
                    config[3] = read.Substring(read.IndexOf("save_com = ") + 11, 1); 
                    if (Convert.ToInt16(config[3]) == 1)
                    {
                        savecom.Checked = true;
                    } else
                    {
                        savecom.Checked = false;
                    }
                } else
                {
					LogWrite("warn", "config property: save_com failed", false);
				}

                if (read.Contains("launch_tray = "))
                {
                    config[4] = read.Substring(read.IndexOf("launch_tray = ") + 14, 1);
                    if (Convert.ToInt16(config[4]) == 1)
                    {
                        launchtray.Checked = true;
                    }
                    else
                    {
                        launchtray.Checked = false;
                    }
                } else {
					LogWrite("warn", "config property: launch_tray failed", false);
				}

                if (read.Contains("enable_tray = "))
                {
                    config[5] = read.Substring(read.IndexOf("enable_tray = ") + 14, 1);
                    if (Convert.ToInt16(config[5]) == 1)
                    {
                        enabletray.Checked = true;
                    }
                    else
                    {
                        enabletray.Checked = false;
                    }
                }
                else {
					LogWrite("warn", "config property: enable_tray failed", false);
				}


                if (read.Contains("hide_to_trayoncon = "))
                {
                    config[6] = read.Substring(read.IndexOf("hide_to_trayoncon = ") + 20, 1);
                    if (Convert.ToInt16(config[6]) == 1)
                    {
                        hidetotrayconnect.Checked = true;
                    } else
                    {
                        hidetotrayconnect.Checked = false;
                    }
                } else
                {
					LogWrite("warn", "config property: hide_to_trayoncon failed", false);
				}

				if (read.Contains("sound_mute = "))
				{
                    config[7] = read.Substring(read.IndexOf("sound_mute = ") + 13, 1);
                    if (Convert.ToInt16(config[7]) == 1)
                    {
                        soundMute.Checked = true;
                    }
                    else
                    {
                        soundMute.Checked = false;
                    }
                } else
                {
					LogWrite("warn", "config property: sound_mute failed", false);
				}

				if (read.Contains("note_hiding = "))
				{ 
                    config[8] = read.Substring(read.IndexOf("note_hiding = ") + 14, 1);
                    if (Convert.ToInt16(config[8]) == 1)
                    {
                        EnableNoteHiding.Checked = true;
                    }
                    else
                    {
                        EnableNoteHiding.Checked = false;
                    }
                } else
                {
					LogWrite("warn", "config property: note_hiding failed", false);
				}
                   
                if(read.Contains("dont_show_welcome = "))
                {
                    config[9] = read.Substring(read.IndexOf("dont_show_welcome = ") + 20, 1);
                    if (Convert.ToInt16(config[9]) == 1)
                    {
                        checkBox1.Checked = true;
                    } else
                    {
                        checkBox1.Checked = false;
                    }
                }

			} else
            {
				LogWrite("warn", "Config File Not Found", true);
				LogWrite("info", "Creating new config file", true);
				try
				{
					LogWrite("info", "File created succesfully", false);
                    fileCreate = true;
				}
				catch (Exception e)
				{
					LogWrite("err", "File creation failed: " + e, false);
				}
			}

            
           
        }


        void writeConfigToFIle()
        {
			File.WriteAllText(currentPath + "config.MLCD", "com_port = " + config[0] + "\n" + "start_logon = " + config[1] + "\n" + "auto_con = " + config[2] + "\n" + "save_com = " + config[3] + "\n" + "launch_tray = " + config[4] + "\n" + "enable_tray = " + config[5] + "\n" + "hide_to_trayoncon = " + config[6] + "\n" + "sound_mute = " + config[7] + "\n" + "note_hiding = " + config[8] + "\n" + "dont_show_welcome = " + config[9] + "\n");
		}

        public void LogWrite(string type, string text, bool printSeperation)
        {
            if(printSeperation)
            {
                Logbox.Text += Environment.NewLine + "=========================";
			}
            if(type == "info")
            {
                Logbox.Text += Environment.NewLine + "i: " + text;
			} else if (type == "warn")
            {
                Logbox.Text += Environment.NewLine + "!: " + text;
			} else if (type == "err")
            {
                Logbox.Text += Environment.NewLine + "X: " + text;
                ErrorBox notisend = new ErrorBox();
                notisend.Show();
                notisend.kext.Text = "An error has occured: " + text;
			} else if (type == "deb")
            {
                Logbox.Text += Environment.NewLine + "D**" + text;
            }
            else 
            {
                Logbox.Text += Environment.NewLine + " : " + text;
            }
        }
		private void startlogon_CheckedChanged(object sender, EventArgs e)
		{
            if (startlogon.Checked)
            {
                config[1] = "1";
				rkApp.SetValue("Music.LCD.exe", Application.ExecutablePath);
			} else
            {
                config[1] = "0";
				rkApp.DeleteValue("Music.LCD.exe", false);
			}
            writeConfigToFIle();
		}

        private void autoconn_CheckedChanged(object sender, EventArgs e)
        {
            if (autoconn.Checked)
            {
                config[2] = "1";
            } else
            {
                config[2] = "0";
            }
			writeConfigToFIle();
		}

        private void savecom_CheckedChanged(object sender, EventArgs e)
        {
            if (savecom.Checked)
            {
                config[3] = "1";
            } else
            {
                config[3] = "0";
            }
			writeConfigToFIle();
		}

		private void launchtray_CheckedChanged(object sender, EventArgs e)
		{
            if(launchtray.Checked)
            {
                config[4] = "1";
            } else
            {
                config[4] = "0";
            }
			writeConfigToFIle();
		}

		private void enabletray_CheckedChanged(object sender, EventArgs e)
		{
            if(enabletray.Checked)
            {
                config[5] = "1";
            } else
            {
                config[5] = "0";
            }
			writeConfigToFIle();
		}

		private void hidetotrayconnect_CheckedChanged(object sender, EventArgs e)
		{
            if (hidetotrayconnect.Checked)
            {
                config[6] = "1";
            } else
            {
                config[6] = "0";
            }
			writeConfigToFIle();
		}

		private void soundMute_CheckedChanged(object sender, EventArgs e)
		{
            if (soundMute.Checked)
            {
                eepromData = "1x11";
				config[7] = "1";
            }
            else {
                eepromData = "0x11";
				config[7] = "0";
            }
			writeConfigToFIle();
		} 

		private void EnableNoteHiding_CheckedChanged(object sender, EventArgs e)
		{
            if (EnableNoteHiding.Checked)
            {
                config[8] = "1";
            } else
            {
                config[8] = "0";
            }
			writeConfigToFIle();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
            if (checkBox1.Checked)
            {
                config[9] = "1";
            } else
            {
                config[9] = "0";
            }
            writeConfigToFIle();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
            if (connected)
            {
				e.Cancel = true;
				closeAppSafetly();
			}
			
		}

        void closeAppSafetly()
        {
            writeConfigToFIle();
			if (serialPort.IsOpen)
			{
                try
                {
					button2.PerformClick();
				} catch (Exception ex) { LogWrite("err", ex.ToString(), true);  }
				closeApp = true;
			}
			else
            {
                closeApp = true;
			}
		}

		private void DisconnectDelay_Tick(object sender, EventArgs e)
		{

            if (serialPort.IsOpen)
            {
                try
                {

                    string L2 = null;
                    string L1 = null;
                    string L3 = null;
                    string L4 = null;



                    L1 = "      No Data       ";
                    L2 = "  Connection lost!  ";
                    L3 = "Disconnect request";
                    L4 = "Disconnect";
					if (MusicLCDType == "BCS")
					{
                        L2 = "D*I^S$C)O%N#E%C&T";
						finalData = L1 + ">1" + L2 + ">2" + "\n";
					}
					else
					{
						finalData = L1 + ">1" + L2 + ">2" + L3 + ">3" + L4 + ">4";
					}

                    Arduinosync.Stop();
                    serialPort.Write(finalData);

                    serialPort.Close();
                    connected = false;
                }
                catch { 
                    LogWrite("err", "Disconnect failed", false);
					shit shit = new shit();
					shit.Show();
					System.Threading.Thread.Sleep(5000);
					shit.Dispose();
				}
                LogWrite("info", "Disconnected", false);
            }
			button1.Enabled = true;
			ComSelec.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			DisconnectDelay.Stop();

		}
	}
	public static class Strings
    {
        //Turns special symbols into standard latin letters
        static Dictionary<string, string> foreign_characters = new Dictionary<string, string>
    {
        { "äæǽ", "ae" },
        { "öœ", "oe" },
        { "ü", "ue" },
        { "Ä", "Ae" },
        { "Ü", "Ue" },
        { "Ö", "Oe" },
        { "ÀÁÂÃÄÅǺĀĂĄǍΑΆẢẠẦẪẨẬẰẮẴẲẶА", "A" },
        { "àáâãåǻāăąǎªαάảạầấẫẩậằắẵẳặа", "a" },
        { "Б", "B" },
        { "б", "b" },
        { "ÇĆĈĊČ", "C" },
        { "çćĉċč", "c" },
        { "Д", "D" },
        { "д", "d" },
        { "ÐĎĐΔ", "Dj" },
        { "ðďđδ", "dj" },
        { "ÈÉÊËĒĔĖĘĚΕΈẼẺẸỀẾỄỂỆЕЭ", "E" },
        { "èéêëēĕėęěέεẽẻẹềếễểệеэ", "e" },
        { "Ф", "F" },
        { "ф", "f" },
        { "ĜĞĠĢΓГҐ", "G" },
        { "ĝğġģγгґ", "g" },
        { "ĤĦ", "H" },
        { "ĥħ", "h" },
        { "ÌÍÎÏĨĪĬǏĮİΗΉΊΙΪỈỊИЫ", "I" },
        { "ìíîïĩīĭǐįıηήίιϊỉịиыї", "i" },
        { "Ĵ", "J" },
        { "ĵ", "j" },
        { "ĶΚК", "K" },
        { "ķκк", "k" },
        { "ĹĻĽĿŁΛЛ", "L" },
        { "ĺļľŀłλл", "l" },
        { "М", "M" },
        { "м", "m" },
        { "ÑŃŅŇΝН", "N" },
        { "ñńņňŉνн", "n" },
        { "ÒÓÔÕŌŎǑŐƠØǾΟΌΩΏỎỌỒỐỖỔỘỜỚỠỞỢО", "O" },
        { "òóôõōŏǒőơøǿºοόωώỏọồốỗổộờớỡởợо", "o" },
        { "П", "P" },
        { "п", "p" },
        { "ŔŖŘΡР", "R" },
        { "ŕŗřρр", "r" },
        { "ŚŜŞȘŠΣС", "S" },
        { "śŝşșšſσςс", "s" },
        { "ȚŢŤŦτТ", "T" },
        { "țţťŧт", "t" },
        { "ÙÚÛŨŪŬŮŰŲƯǓǕǗǙǛŨỦỤỪỨỮỬỰУ", "U" },
        { "ùúûũūŭůűųưǔǖǘǚǜυύϋủụừứữửựу", "u" },
        { "ÝŸŶΥΎΫỲỸỶỴЙ", "Y" },
        { "ýÿŷỳỹỷỵй", "y" },
        { "В", "V" },
        { "в", "v" },
        { "Ŵ", "W" },
        { "ŵ", "w" },
        { "ŹŻŽΖЗ", "Z" },
        { "źżžζз", "z" },
        { "ÆǼ", "AE" },
        { "ß", "ss" },
        { "Ĳ", "IJ" },
        { "ĳ", "ij" },
        { "Œ", "OE" },
        { "ƒ", "f" },
        { "ξ", "ks" },
        { "π", "p" },
        { "β", "v" },
        { "μ", "m" },
        { "ψ", "ps" },
        { "Ё", "Yo" },
        { "ё", "yo" },
        { "Є", "Ye" },
        { "є", "ye" },
        { "Ї", "Yi" },
        { "Ж", "Zh" },
        { "ж", "zh" },
        { "Х", "Kh" },
        { "х", "kh" },
        { "Ц", "Ts" },
        { "ц", "ts" },
        { "Ч", "Ch" },
        { "ч", "ch" },
        { "Ш", "Sh" },
        { "ш", "sh" },
        { "Щ", "Shch" },
        { "щ", "shch" },
        { "ЪъЬь", "" },
        { "Ю", "Yu" },
        { "ю", "yu" },
        { "Я", "Ya" },
        { "я", "ya" },
        { "ą", "a" },
        { "ę", "e" },
        { "ś", "s" },
        { "ć", "c" },
        { "ł", "l" },
        { "ó", "o" },
        { "ż", "z" },
        { "ź", "z" },
    };

        public static char RemoveDiacritics(this char c)
        {
            foreach (KeyValuePair<string, string> entry in foreign_characters)
            {
                if (entry.Key.IndexOf(c) != -1)
                {
                    return entry.Value[0];
                }
            }
            return c;
        }

        public static string RemoveDiacritics(this string s)
        {
            //StringBuilder sb = new StringBuilder ();
            string text = "";
            if (!string.IsNullOrEmpty(s))
            {
                foreach (char c in s)
                {
                    int len = text.Length;

                    foreach (KeyValuePair<string, string> entry in foreign_characters)
                    {
                        if (entry.Key.IndexOf(c) != -1)
                        {
                            text += entry.Value;
                            break;
                        }
                    }

                    if (len == text.Length)
                    {
                        text += c;
                    }
                }
            }
            return text;
        }

		
	}
}
