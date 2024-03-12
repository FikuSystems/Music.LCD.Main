namespace Music.LCD
{
    partial class Flasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flasher));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.errtext = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BCS = new System.Windows.Forms.RadioButton();
            this.BCSI2C = new System.Windows.Forms.RadioButton();
            this.LiqCry = new System.Windows.Forms.RadioButton();
            this.LiqCryI2C = new System.Windows.Forms.RadioButton();
            this.DoneButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DownloadFileName = new System.Windows.Forms.Label();
            this.Download = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.FlashProgress = new System.Windows.Forms.ProgressBar();
            this.Flash = new System.Windows.Forms.Button();
            this.ArdSoftRepTitle = new System.Windows.Forms.Label();
            this.ArdSoftRep = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ArdCOM = new System.Windows.Forms.ComboBox();
            this.oktext = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.LCD1602 = new System.Windows.Forms.RadioButton();
            this.LCD2004 = new System.Windows.Forms.RadioButton();
            this.ArdModel = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.CheckPorts = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okico = new System.Windows.Forms.PictureBox();
            this.errico = new System.Windows.Forms.PictureBox();
            this.okunderstand = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arduino Flash Tool";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to the Arduino flash tool.";
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadProgress.Location = new System.Drawing.Point(7, 51);
            this.DownloadProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(187, 23);
            this.DownloadProgress.TabIndex = 3;
            // 
            // errtext
            // 
            this.errtext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errtext.ForeColor = System.Drawing.Color.Black;
            this.errtext.Location = new System.Drawing.Point(44, 279);
            this.errtext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errtext.Name = "errtext";
            this.errtext.Size = new System.Drawing.Size(923, 30);
            this.errtext.TabIndex = 4;
            this.errtext.Text = "We are not responisble for any damage caused. (Arduino Nano R3 is experimental)\r\n" +
    "Do not distrupt the connection when uploading to the arduino as it may cause per" +
    "nament damage to your device!\r\n";
            this.errtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BCS);
            this.groupBox1.Controls.Add(this.BCSI2C);
            this.groupBox1.Controls.Add(this.LiqCry);
            this.groupBox1.Controls.Add(this.LiqCryI2C);
            this.groupBox1.Location = new System.Drawing.Point(7, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(276, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select Version - Hover on selection for info";
            // 
            // BCS
            // 
            this.BCS.AutoSize = true;
            this.BCS.Location = new System.Drawing.Point(6, 97);
            this.BCS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BCS.Name = "BCS";
            this.BCS.Size = new System.Drawing.Size(244, 19);
            this.BCS.TabIndex = 4;
            this.BCS.Text = "Arduino MusicLCD - BCS Edition (Offline)";
            this.toolTip1.SetToolTip(this.BCS, resources.GetString("BCS.ToolTip"));
            this.BCS.UseVisualStyleBackColor = true;
            // 
            // BCSI2C
            // 
            this.BCSI2C.AutoSize = true;
            this.BCSI2C.Location = new System.Drawing.Point(6, 72);
            this.BCSI2C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BCSI2C.Name = "BCSI2C";
            this.BCSI2C.Size = new System.Drawing.Size(261, 19);
            this.BCSI2C.TabIndex = 3;
            this.BCSI2C.Text = "Arduino MusicLCD - BCSI2C Edition (Offline)";
            this.toolTip1.SetToolTip(this.BCSI2C, resources.GetString("BCSI2C.ToolTip"));
            this.BCSI2C.UseVisualStyleBackColor = true;
            // 
            // LiqCry
            // 
            this.LiqCry.AutoSize = true;
            this.LiqCry.Location = new System.Drawing.Point(6, 47);
            this.LiqCry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LiqCry.Name = "LiqCry";
            this.LiqCry.Size = new System.Drawing.Size(216, 19);
            this.LiqCry.TabIndex = 1;
            this.LiqCry.TabStop = true;
            this.LiqCry.Text = "Arduino MusicLCD - LIQCRY Edition";
            this.toolTip1.SetToolTip(this.LiqCry, "Requires download from github repository.\r\n\r\nArduino MusicLCD Project standard Ed" +
        "ition.\r\nFor use on displays without any modules like I2C (Direct attatch the 14 " +
        "or 16 pins).");
            this.LiqCry.UseVisualStyleBackColor = true;
            // 
            // LiqCryI2C
            // 
            this.LiqCryI2C.AutoSize = true;
            this.LiqCryI2C.Checked = true;
            this.LiqCryI2C.Location = new System.Drawing.Point(6, 22);
            this.LiqCryI2C.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LiqCryI2C.Name = "LiqCryI2C";
            this.LiqCryI2C.Size = new System.Drawing.Size(233, 19);
            this.LiqCryI2C.TabIndex = 0;
            this.LiqCryI2C.TabStop = true;
            this.LiqCryI2C.Text = "Arduino MusicLCD - LIQCRYI2C Edition";
            this.toolTip1.SetToolTip(this.LiqCryI2C, "Requires download from github repository.\r\n\r\nArduino MusicLCD Project I2C Edition" +
        ".\r\nFor use with displays with the I2C module.");
            this.LiqCryI2C.UseVisualStyleBackColor = true;
            this.LiqCryI2C.CheckedChanged += new System.EventHandler(this.LiqCryI2C_CheckedChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(1061, 237);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 28);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(12, 271);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 1);
            this.panel3.TabIndex = 8;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Version Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DownloadFileName);
            this.groupBox2.Controls.Add(this.Download);
            this.groupBox2.Controls.Add(this.DownloadProgress);
            this.groupBox2.Location = new System.Drawing.Point(392, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Choose and/ or download";
            // 
            // DownloadFileName
            // 
            this.DownloadFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadFileName.Location = new System.Drawing.Point(7, 77);
            this.DownloadFileName.Name = "DownloadFileName";
            this.DownloadFileName.Size = new System.Drawing.Size(186, 39);
            this.DownloadFileName.TabIndex = 5;
            this.DownloadFileName.Text = "MLCD-(Version)-(Edition)-(LCDSize).HEX";
            this.DownloadFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Download
            // 
            this.Download.Location = new System.Drawing.Point(7, 22);
            this.Download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(187, 23);
            this.Download.TabIndex = 0;
            this.Download.Text = "Download Selected Version";
            this.Download.UseVisualStyleBackColor = true;
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FlashProgress);
            this.groupBox3.Controls.Add(this.Flash);
            this.groupBox3.Location = new System.Drawing.Point(310, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(200, 123);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "6. Upload/ Flash";
            // 
            // FlashProgress
            // 
            this.FlashProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FlashProgress.Location = new System.Drawing.Point(8, 51);
            this.FlashProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FlashProgress.Name = "FlashProgress";
            this.FlashProgress.Size = new System.Drawing.Size(184, 23);
            this.FlashProgress.TabIndex = 5;
            // 
            // Flash
            // 
            this.Flash.Enabled = false;
            this.Flash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flash.Location = new System.Drawing.Point(8, 22);
            this.Flash.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Flash.Name = "Flash";
            this.Flash.Size = new System.Drawing.Size(184, 23);
            this.Flash.TabIndex = 1;
            this.Flash.Text = "Flash";
            this.Flash.UseVisualStyleBackColor = true;
            this.Flash.Click += new System.EventHandler(this.Flash_Click);
            // 
            // ArdSoftRepTitle
            // 
            this.ArdSoftRepTitle.AutoSize = true;
            this.ArdSoftRepTitle.Location = new System.Drawing.Point(10, 235);
            this.ArdSoftRepTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArdSoftRepTitle.Name = "ArdSoftRepTitle";
            this.ArdSoftRepTitle.Size = new System.Drawing.Size(136, 15);
            this.ArdSoftRepTitle.TabIndex = 11;
            this.ArdSoftRepTitle.Text = "Arduino software report:";
            // 
            // ArdSoftRep
            // 
            this.ArdSoftRep.Location = new System.Drawing.Point(10, 250);
            this.ArdSoftRep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArdSoftRep.Name = "ArdSoftRep";
            this.ArdSoftRep.Size = new System.Drawing.Size(1010, 15);
            this.ArdSoftRep.TabIndex = 12;
            this.ArdSoftRep.Text = "MLCD-(Edition Name)-(Version)-(Compilation Date)-(LCD Size)-(Release, Beta)";
            this.ArdSoftRep.Click += new System.EventHandler(this.ArdSoftRep_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.ArdCOM);
            this.groupBox4.Location = new System.Drawing.Point(214, 22);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(88, 123);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "5. COM port";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 65);
            this.label4.TabIndex = 7;
            this.label4.Text = "COM port. What else to say.\r\n ¯\\_(ツ)_/¯";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArdCOM
            // 
            this.ArdCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArdCOM.Enabled = false;
            this.ArdCOM.FormattingEnabled = true;
            this.ArdCOM.Location = new System.Drawing.Point(7, 22);
            this.ArdCOM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ArdCOM.Name = "ArdCOM";
            this.ArdCOM.Size = new System.Drawing.Size(75, 23);
            this.ArdCOM.TabIndex = 0;
            // 
            // oktext
            // 
            this.oktext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oktext.ForeColor = System.Drawing.Color.Black;
            this.oktext.Location = new System.Drawing.Point(44, 279);
            this.oktext.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oktext.Name = "oktext";
            this.oktext.Size = new System.Drawing.Size(923, 30);
            this.oktext.TabIndex = 18;
            this.oktext.Text = "Ready";
            this.oktext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.oktext.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.LCD1602);
            this.groupBox6.Controls.Add(this.LCD2004);
            this.groupBox6.Location = new System.Drawing.Point(291, 22);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox6.Size = new System.Drawing.Size(93, 123);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "2. Display size";
            // 
            // LCD1602
            // 
            this.LCD1602.AutoSize = true;
            this.LCD1602.Location = new System.Drawing.Point(7, 47);
            this.LCD1602.Name = "LCD1602";
            this.LCD1602.Size = new System.Drawing.Size(61, 19);
            this.LCD1602.TabIndex = 1;
            this.LCD1602.TabStop = true;
            this.LCD1602.Text = "16 x 02";
            this.LCD1602.UseVisualStyleBackColor = true;
            // 
            // LCD2004
            // 
            this.LCD2004.AutoSize = true;
            this.LCD2004.Checked = true;
            this.LCD2004.Location = new System.Drawing.Point(7, 22);
            this.LCD2004.Name = "LCD2004";
            this.LCD2004.Size = new System.Drawing.Size(61, 19);
            this.LCD2004.TabIndex = 0;
            this.LCD2004.TabStop = true;
            this.LCD2004.Text = "20 x 04";
            this.LCD2004.UseVisualStyleBackColor = true;
            this.LCD2004.CheckedChanged += new System.EventHandler(this.LCD2004_CheckedChanged);
            // 
            // ArdModel
            // 
            this.ArdModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArdModel.Enabled = false;
            this.ArdModel.FormattingEnabled = true;
            this.ArdModel.Items.AddRange(new object[] {
            "Leonardo - ATMega32U4",
            "Mega 1284 - ATMega1284",
            "Mega 2560 - ATMega2560",
            "Micro - ATMega32U4",
            "Nano (R2)\t- ATMega168",
            "Nano (R3) (Ex) - ATMega328P",
            "Uno (R3) - ATMega328P"});
            this.ArdModel.Location = new System.Drawing.Point(7, 22);
            this.ArdModel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ArdModel.Name = "ArdModel";
            this.ArdModel.Size = new System.Drawing.Size(184, 23);
            this.ArdModel.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.ArdModel);
            this.groupBox5.Location = new System.Drawing.Point(7, 22);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(199, 123);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "4. Arduino model";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "Select your Arduino model from the dropdown, required so that the liblaries know " +
    "what processor is used.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox1);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.groupBox2);
            this.groupBox7.Location = new System.Drawing.Point(12, 77);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(600, 153);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Stage 1. Edition select and download";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Controls.Add(this.groupBox3);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Location = new System.Drawing.Point(618, 77);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(518, 153);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Stage 2. File flash/ upload";
            // 
            // CheckPorts
            // 
            this.CheckPorts.Enabled = true;
            this.CheckPorts.Interval = 10;
            this.CheckPorts.Tick += new System.EventHandler(this.CheckPorts_Tick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(925, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 71);
            this.panel1.TabIndex = 22;
            // 
            // okico
            // 
            this.okico.Image = global::Music.LCD.Properties.Resources.confirmglass1;
            this.okico.Location = new System.Drawing.Point(13, 280);
            this.okico.Name = "okico";
            this.okico.Size = new System.Drawing.Size(29, 29);
            this.okico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.okico.TabIndex = 17;
            this.okico.TabStop = false;
            this.okico.Visible = false;
            // 
            // errico
            // 
            this.errico.Image = global::Music.LCD.Properties.Resources.errorglass;
            this.errico.Location = new System.Drawing.Point(13, 280);
            this.errico.Name = "errico";
            this.errico.Size = new System.Drawing.Size(29, 29);
            this.errico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.errico.TabIndex = 16;
            this.errico.TabStop = false;
            // 
            // okunderstand
            // 
            this.okunderstand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okunderstand.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.okunderstand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.okunderstand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.okunderstand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okunderstand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.okunderstand.Image = global::Music.LCD.Properties.Resources.confirmglass1;
            this.okunderstand.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.okunderstand.Location = new System.Drawing.Point(999, 275);
            this.okunderstand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.okunderstand.Name = "okunderstand";
            this.okunderstand.Size = new System.Drawing.Size(135, 39);
            this.okunderstand.TabIndex = 15;
            this.okunderstand.Text = "OK, I understand";
            this.okunderstand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.okunderstand.UseVisualStyleBackColor = true;
            this.okunderstand.Click += new System.EventHandler(this.button7_Click);
            // 
            // Flasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 322);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.oktext);
            this.Controls.Add(this.okico);
            this.Controls.Add(this.errico);
            this.Controls.Add(this.okunderstand);
            this.Controls.Add(this.ArdSoftRep);
            this.Controls.Add(this.ArdSoftRepTitle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.errtext);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Flasher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music LCD | Arduino Flash Tool";
            this.Load += new System.EventHandler(this.Flasher_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.okico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Label errtext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton BCSI2C;
        private System.Windows.Forms.RadioButton LiqCry;
        private System.Windows.Forms.RadioButton LiqCryI2C;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Download;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Flash;
        private System.Windows.Forms.ProgressBar FlashProgress;
        private System.Windows.Forms.Label ArdSoftRepTitle;
        private System.Windows.Forms.Label ArdSoftRep;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox ArdCOM;
        private System.Windows.Forms.Label DownloadFileName;
        private System.Windows.Forms.Button okunderstand;
        private System.Windows.Forms.PictureBox errico;
        private System.Windows.Forms.PictureBox okico;
        private System.Windows.Forms.Label oktext;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton LCD1602;
        private System.Windows.Forms.RadioButton LCD2004;
        private System.Windows.Forms.ComboBox ArdModel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton BCS;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Timer CheckPorts;
		private System.Windows.Forms.Label label5;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}