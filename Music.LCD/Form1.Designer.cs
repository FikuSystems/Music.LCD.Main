namespace Music.LCD
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComSelec = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.EnableNoteHiding = new System.Windows.Forms.CheckBox();
            this.soundMute = new System.Windows.Forms.CheckBox();
            this.hidetotrayconnect = new System.Windows.Forms.CheckBox();
            this.enabletray = new System.Windows.Forms.CheckBox();
            this.launchtray = new System.Windows.Forms.CheckBox();
            this.autoconn = new System.Windows.Forms.CheckBox();
            this.savecom = new System.Windows.Forms.CheckBox();
            this.startlogon = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LCDLN1 = new System.Windows.Forms.Label();
            this.LCDLN2 = new System.Windows.Forms.Label();
            this.LCDLN3 = new System.Windows.Forms.Label();
            this.LCDLN4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Logbox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.GetMusicSync = new System.Windows.Forms.Timer(this.components);
            this.Arduinosync = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.MusictimeTimer = new System.Windows.Forms.Timer(this.components);
            this.MusicTimeSyncroniser = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.DisconnectDelay = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music LCD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome, Select COM port to begin.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComSelec);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(13, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(427, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup Connection";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ComSelec
            // 
            this.ComSelec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComSelec.FormattingEnabled = true;
            this.ComSelec.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.ComSelec.Location = new System.Drawing.Point(8, 24);
            this.ComSelec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ComSelec.Name = "ComSelec";
            this.ComSelec.Size = new System.Drawing.Size(191, 23);
            this.ComSelec.TabIndex = 2;
            this.ComSelec.SelectedIndexChanged += new System.EventHandler(this.ComSelec_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(331, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.EnableNoteHiding);
            this.groupBox2.Controls.Add(this.soundMute);
            this.groupBox2.Controls.Add(this.hidetotrayconnect);
            this.groupBox2.Controls.Add(this.enabletray);
            this.groupBox2.Controls.Add(this.launchtray);
            this.groupBox2.Controls.Add(this.autoconn);
            this.groupBox2.Controls.Add(this.savecom);
            this.groupBox2.Controls.Add(this.startlogon);
            this.groupBox2.Location = new System.Drawing.Point(13, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(199, 243);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 220);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 19);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Don\'t show welcome";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EnableNoteHiding
            // 
            this.EnableNoteHiding.AutoSize = true;
            this.EnableNoteHiding.Location = new System.Drawing.Point(7, 195);
            this.EnableNoteHiding.Name = "EnableNoteHiding";
            this.EnableNoteHiding.Size = new System.Drawing.Size(129, 19);
            this.EnableNoteHiding.TabIndex = 15;
            this.EnableNoteHiding.Text = "Enable Note Hiding";
            this.EnableNoteHiding.UseVisualStyleBackColor = true;
            this.EnableNoteHiding.CheckedChanged += new System.EventHandler(this.EnableNoteHiding_CheckedChanged);
            // 
            // soundMute
            // 
            this.soundMute.AutoSize = true;
            this.soundMute.Enabled = false;
            this.soundMute.Location = new System.Drawing.Point(7, 171);
            this.soundMute.Name = "soundMute";
            this.soundMute.Size = new System.Drawing.Size(91, 19);
            this.soundMute.TabIndex = 14;
            this.soundMute.Text = "Sound mute";
            this.soundMute.UseVisualStyleBackColor = true;
            this.soundMute.CheckedChanged += new System.EventHandler(this.soundMute_CheckedChanged);
            // 
            // hidetotrayconnect
            // 
            this.hidetotrayconnect.AutoSize = true;
            this.hidetotrayconnect.Location = new System.Drawing.Point(7, 147);
            this.hidetotrayconnect.Name = "hidetotrayconnect";
            this.hidetotrayconnect.Size = new System.Drawing.Size(151, 19);
            this.hidetotrayconnect.TabIndex = 6;
            this.hidetotrayconnect.Text = "Hide to tray on connect";
            this.hidetotrayconnect.UseVisualStyleBackColor = true;
            this.hidetotrayconnect.CheckedChanged += new System.EventHandler(this.hidetotrayconnect_CheckedChanged);
            // 
            // enabletray
            // 
            this.enabletray.AutoSize = true;
            this.enabletray.Location = new System.Drawing.Point(7, 122);
            this.enabletray.Name = "enabletray";
            this.enabletray.Size = new System.Drawing.Size(111, 19);
            this.enabletray.TabIndex = 5;
            this.enabletray.Text = "Enable Tray Icon";
            this.enabletray.UseVisualStyleBackColor = true;
            this.enabletray.CheckedChanged += new System.EventHandler(this.enabletray_CheckedChanged);
            // 
            // launchtray
            // 
            this.launchtray.AutoSize = true;
            this.launchtray.Location = new System.Drawing.Point(7, 97);
            this.launchtray.Name = "launchtray";
            this.launchtray.Size = new System.Drawing.Size(101, 19);
            this.launchtray.TabIndex = 3;
            this.launchtray.Text = "Launch in tray";
            this.launchtray.UseVisualStyleBackColor = true;
            this.launchtray.CheckedChanged += new System.EventHandler(this.launchtray_CheckedChanged);
            // 
            // autoconn
            // 
            this.autoconn.AutoSize = true;
            this.autoconn.Location = new System.Drawing.Point(7, 47);
            this.autoconn.Name = "autoconn";
            this.autoconn.Size = new System.Drawing.Size(98, 19);
            this.autoconn.TabIndex = 2;
            this.autoconn.Text = "Auto connect";
            this.autoconn.UseVisualStyleBackColor = true;
            this.autoconn.CheckedChanged += new System.EventHandler(this.autoconn_CheckedChanged);
            // 
            // savecom
            // 
            this.savecom.AutoSize = true;
            this.savecom.Location = new System.Drawing.Point(7, 72);
            this.savecom.Name = "savecom";
            this.savecom.Size = new System.Drawing.Size(156, 19);
            this.savecom.TabIndex = 1;
            this.savecom.Text = "Save COM Port selection";
            this.savecom.UseVisualStyleBackColor = true;
            this.savecom.CheckedChanged += new System.EventHandler(this.savecom_CheckedChanged);
            // 
            // startlogon
            // 
            this.startlogon.AutoSize = true;
            this.startlogon.Location = new System.Drawing.Point(7, 22);
            this.startlogon.Name = "startlogon";
            this.startlogon.Size = new System.Drawing.Size(104, 19);
            this.startlogon.TabIndex = 0;
            this.startlogon.Text = "Start on log on";
            this.startlogon.UseVisualStyleBackColor = true;
            this.startlogon.CheckedChanged += new System.EventHandler(this.startlogon_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LCDLN1);
            this.groupBox3.Controls.Add(this.LCDLN2);
            this.groupBox3.Controls.Add(this.LCDLN3);
            this.groupBox3.Controls.Add(this.LCDLN4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(448, 59);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(366, 243);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // LCDLN1
            // 
            this.LCDLN1.AutoEllipsis = true;
            this.LCDLN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(247)))));
            this.LCDLN1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLN1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCDLN1.Location = new System.Drawing.Point(75, 86);
            this.LCDLN1.Name = "LCDLN1";
            this.LCDLN1.Size = new System.Drawing.Size(210, 22);
            this.LCDLN1.TabIndex = 1;
            this.LCDLN1.Text = "TITLE";
            // 
            // LCDLN2
            // 
            this.LCDLN2.AutoEllipsis = true;
            this.LCDLN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(247)))));
            this.LCDLN2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLN2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCDLN2.Location = new System.Drawing.Point(75, 106);
            this.LCDLN2.Name = "LCDLN2";
            this.LCDLN2.Size = new System.Drawing.Size(210, 22);
            this.LCDLN2.TabIndex = 2;
            this.LCDLN2.Text = "ARTIST";
            // 
            // LCDLN3
            // 
            this.LCDLN3.AutoSize = true;
            this.LCDLN3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(247)))));
            this.LCDLN3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLN3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCDLN3.Location = new System.Drawing.Point(75, 129);
            this.LCDLN3.Name = "LCDLN3";
            this.LCDLN3.Size = new System.Drawing.Size(210, 22);
            this.LCDLN3.TabIndex = 3;
            this.LCDLN3.Text = "--:-- | --:--   Play";
            // 
            // LCDLN4
            // 
            this.LCDLN4.AutoSize = true;
            this.LCDLN4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(3)))), ((int)(((byte)(247)))));
            this.LCDLN4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCDLN4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LCDLN4.Location = new System.Drawing.Point(75, 149);
            this.LCDLN4.Name = "LCDLN4";
            this.LCDLN4.Size = new System.Drawing.Size(210, 22);
            this.LCDLN4.TabIndex = 4;
            this.LCDLN4.Text = "[------------------]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Music.LCD.Properties.Resources.LCDON;
            this.pictureBox1.Location = new System.Drawing.Point(7, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(639, 308);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Close to tray";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(544, 308);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 27);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(448, 308);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 27);
            this.button5.TabIndex = 7;
            this.button5.Text = "Restart";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(544, 341);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 27);
            this.button6.TabIndex = 8;
            this.button6.Text = "Open logs";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.Logbox);
            this.groupBox4.Location = new System.Drawing.Point(220, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 243);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Logs";
            this.groupBox4.Visible = false;
            // 
            // Logbox
            // 
            this.Logbox.BackColor = System.Drawing.Color.White;
            this.Logbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logbox.Location = new System.Drawing.Point(6, 22);
            this.Logbox.Multiline = true;
            this.Logbox.Name = "Logbox";
            this.Logbox.ReadOnly = true;
            this.Logbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Logbox.Size = new System.Drawing.Size(208, 215);
            this.Logbox.TabIndex = 5;
            this.Logbox.Text = "Music LCD (Ver)\r\n(c) FikuSystems 2024\r\n=========================\r\nCode info:\r\ni -" +
    " Information\r\n! - Warning\r\nX - Error\r\n=========================\r\ni: Process star" +
    "ted";
            this.Logbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(544, 341);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 27);
            this.button7.TabIndex = 11;
            this.button7.Text = "Hide logs";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // GetMusicSync
            // 
            this.GetMusicSync.Enabled = true;
            this.GetMusicSync.Interval = 1000;
            this.GetMusicSync.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Arduinosync
            // 
            this.Arduinosync.Interval = 1050;
            this.Arduinosync.Tick += new System.EventHandler(this.Arduinosync_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Double click to open UI";
            this.notifyIcon1.BalloonTipTitle = "Music LCD";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Music LCD | Double click to open UI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(448, 341);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 27);
            this.button8.TabIndex = 12;
            this.button8.Text = "Flash tool";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // MusictimeTimer
            // 
            this.MusictimeTimer.Interval = 1000;
            this.MusictimeTimer.Tick += new System.EventHandler(this.MusictimeTimer_Tick);
            // 
            // MusicTimeSyncroniser
            // 
            this.MusicTimeSyncroniser.Enabled = true;
            this.MusicTimeSyncroniser.Interval = 1;
            this.MusicTimeSyncroniser.Tick += new System.EventHandler(this.MusicTimeSyncroniser_Tick);
            // 
            // DisconnectDelay
            // 
            this.DisconnectDelay.Interval = 1300;
            this.DisconnectDelay.Tick += new System.EventHandler(this.DisconnectDelay_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 381);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Music LCD | Select COM port";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.HelpButtonClickeda);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox ComSelec;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.CheckBox autoconn;
		private System.Windows.Forms.CheckBox savecom;
		private System.Windows.Forms.CheckBox startlogon;
		private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label LCDLN4;
		private System.Windows.Forms.Label LCDLN3;
		private System.Windows.Forms.Label LCDLN2;
		private System.Windows.Forms.Label LCDLN1;
		private System.Windows.Forms.Timer GetMusicSync;
		private System.Windows.Forms.Timer Arduinosync;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.IO.Ports.SerialPort serialPort;
		private System.Windows.Forms.CheckBox launchtray;
		private System.Windows.Forms.CheckBox hidetotrayconnect;
		private System.Windows.Forms.CheckBox enabletray;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Timer MusictimeTimer;
		private System.Windows.Forms.Timer MusicTimeSyncroniser;
        private System.Windows.Forms.CheckBox soundMute;
        private System.Windows.Forms.TextBox Logbox;
		private System.Windows.Forms.CheckBox EnableNoteHiding;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Timer DisconnectDelay;
	}
}