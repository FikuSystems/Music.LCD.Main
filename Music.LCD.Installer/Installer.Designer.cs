namespace Music.LCD.Installer
{
    partial class Installer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installer));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.s8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.s7 = new System.Windows.Forms.Label();
			this.s6 = new System.Windows.Forms.Label();
			this.s5 = new System.Windows.Forms.Label();
			this.s4 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.s3 = new System.Windows.Forms.Label();
			this.s2 = new System.Windows.Forms.Label();
			this.s1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.backbtn = new System.Windows.Forms.Button();
			this.exitbtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.preinstallinfo = new System.Windows.Forms.GroupBox();
			this.Selectinstalllocation = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.openexplorer = new System.Windows.Forms.Button();
			this.filepath = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.shortcuts = new System.Windows.Forms.GroupBox();
			this.instruct = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.cdesktopshortcut = new System.Windows.Forms.CheckBox();
			this.ctaskbarpin = new System.Windows.Forms.CheckBox();
			this.cstartmenupin = new System.Windows.Forms.CheckBox();
			this.cstartmenufolder = new System.Windows.Forms.CheckBox();
			this.label17 = new System.Windows.Forms.Label();
			this.installation = new System.Windows.Forms.GroupBox();
			this.Complete = new System.Windows.Forms.GroupBox();
			this.label18 = new System.Windows.Forms.Label();
			this.logs = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.instalprogress = new System.Windows.Forms.ProgressBar();
			this.nextbtn = new System.Windows.Forms.Button();
			this.copyingFiles = new System.ComponentModel.BackgroundWorker();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.preinstallinfo.SuspendLayout();
			this.Selectinstalllocation.SuspendLayout();
			this.shortcuts.SuspendLayout();
			this.instruct.SuspendLayout();
			this.installation.SuspendLayout();
			this.Complete.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(24, 41);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Welcome to the Music LCD installer!";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Music LCD Installer";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(164)))), ((int)(((byte)(132)))));
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(246, 381);
			this.panel1.TabIndex = 4;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(13, 342);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(221, 27);
			this.linkLabel1.TabIndex = 11;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "View Github Page";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(254)))), ((int)(((byte)(219)))));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.groupBox4);
			this.panel2.Controls.Add(this.groupBox3);
			this.panel2.Controls.Add(this.groupBox2);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(13, 69);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(220, 266);
			this.panel2.TabIndex = 4;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.s8);
			this.groupBox4.Location = new System.Drawing.Point(3, 212);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(214, 51);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Installation Complete";
			// 
			// s8
			// 
			this.s8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s8.BackColor = System.Drawing.Color.Transparent;
			this.s8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s8.Location = new System.Drawing.Point(7, 20);
			this.s8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s8.Name = "s8";
			this.s8.Size = new System.Drawing.Size(200, 24);
			this.s8.TabIndex = 14;
			this.s8.Text = "Finished";
			this.s8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.s7);
			this.groupBox3.Controls.Add(this.s6);
			this.groupBox3.Controls.Add(this.s5);
			this.groupBox3.Controls.Add(this.s4);
			this.groupBox3.Location = new System.Drawing.Point(3, 114);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(214, 92);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Installation";
			// 
			// s7
			// 
			this.s7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s7.BackColor = System.Drawing.Color.Transparent;
			this.s7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s7.Location = new System.Drawing.Point(7, 69);
			this.s7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s7.Name = "s7";
			this.s7.Size = new System.Drawing.Size(200, 17);
			this.s7.TabIndex = 13;
			this.s7.Text = "Creating Uninstaller";
			this.s7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// s6
			// 
			this.s6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s6.BackColor = System.Drawing.Color.Transparent;
			this.s6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s6.Location = new System.Drawing.Point(7, 52);
			this.s6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s6.Name = "s6";
			this.s6.Size = new System.Drawing.Size(200, 17);
			this.s6.TabIndex = 12;
			this.s6.Text = "Creating Config Files";
			this.s6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// s5
			// 
			this.s5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s5.BackColor = System.Drawing.Color.Transparent;
			this.s5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s5.Location = new System.Drawing.Point(7, 35);
			this.s5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s5.Name = "s5";
			this.s5.Size = new System.Drawing.Size(200, 17);
			this.s5.TabIndex = 11;
			this.s5.Text = "Creating Shortcuts";
			this.s5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// s4
			// 
			this.s4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s4.BackColor = System.Drawing.Color.Transparent;
			this.s4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s4.Location = new System.Drawing.Point(7, 18);
			this.s4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s4.Name = "s4";
			this.s4.Size = new System.Drawing.Size(200, 17);
			this.s4.TabIndex = 10;
			this.s4.Text = "Copying Files";
			this.s4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.s3);
			this.groupBox2.Controls.Add(this.s2);
			this.groupBox2.Controls.Add(this.s1);
			this.groupBox2.Location = new System.Drawing.Point(3, 33);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(214, 75);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Preperation";
			// 
			// s3
			// 
			this.s3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s3.BackColor = System.Drawing.Color.Transparent;
			this.s3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s3.Location = new System.Drawing.Point(7, 52);
			this.s3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s3.Name = "s3";
			this.s3.Size = new System.Drawing.Size(200, 17);
			this.s3.TabIndex = 9;
			this.s3.Text = "Instructions";
			this.s3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// s2
			// 
			this.s2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s2.BackColor = System.Drawing.Color.Transparent;
			this.s2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s2.Location = new System.Drawing.Point(7, 35);
			this.s2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s2.Name = "s2";
			this.s2.Size = new System.Drawing.Size(200, 17);
			this.s2.TabIndex = 8;
			this.s2.Text = "Shortcuts";
			this.s2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// s1
			// 
			this.s1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.s1.BackColor = System.Drawing.Color.Transparent;
			this.s1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.s1.Location = new System.Drawing.Point(7, 18);
			this.s1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.s1.Name = "s1";
			this.s1.Size = new System.Drawing.Size(200, 17);
			this.s1.TabIndex = 7;
			this.s1.Text = "Select install location";
			this.s1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(4, 4);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(212, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "Install Steps";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// backbtn
			// 
			this.backbtn.Enabled = false;
			this.backbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.backbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backbtn.Location = new System.Drawing.Point(586, 342);
			this.backbtn.Name = "backbtn";
			this.backbtn.Size = new System.Drawing.Size(87, 27);
			this.backbtn.TabIndex = 6;
			this.backbtn.Text = "Back";
			this.backbtn.UseVisualStyleBackColor = true;
			this.backbtn.Click += new System.EventHandler(this.button2_Click);
			// 
			// exitbtn
			// 
			this.exitbtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
			this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.exitbtn.Location = new System.Drawing.Point(258, 342);
			this.exitbtn.Name = "exitbtn";
			this.exitbtn.Size = new System.Drawing.Size(87, 27);
			this.exitbtn.TabIndex = 8;
			this.exitbtn.Text = "Exit";
			this.exitbtn.UseVisualStyleBackColor = true;
			this.exitbtn.Click += new System.EventHandler(this.button4_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(253, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "Welcome!";
			// 
			// preinstallinfo
			// 
			this.preinstallinfo.Controls.Add(this.Selectinstalllocation);
			this.preinstallinfo.Controls.Add(this.textBox1);
			this.preinstallinfo.Controls.Add(this.label13);
			this.preinstallinfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.preinstallinfo.Location = new System.Drawing.Point(260, 44);
			this.preinstallinfo.Name = "preinstallinfo";
			this.preinstallinfo.Size = new System.Drawing.Size(504, 291);
			this.preinstallinfo.TabIndex = 10;
			this.preinstallinfo.TabStop = false;
			this.preinstallinfo.Text = "Pre-Install Information";
			// 
			// Selectinstalllocation
			// 
			this.Selectinstalllocation.Controls.Add(this.label15);
			this.Selectinstalllocation.Controls.Add(this.label14);
			this.Selectinstalllocation.Controls.Add(this.openexplorer);
			this.Selectinstalllocation.Controls.Add(this.filepath);
			this.Selectinstalllocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Selectinstalllocation.Location = new System.Drawing.Point(0, 1);
			this.Selectinstalllocation.Name = "Selectinstalllocation";
			this.Selectinstalllocation.Size = new System.Drawing.Size(504, 291);
			this.Selectinstalllocation.TabIndex = 11;
			this.Selectinstalllocation.TabStop = false;
			this.Selectinstalllocation.Text = "Select Install Location";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(7, 69);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(491, 40);
			this.label15.TabIndex = 3;
			this.label15.Text = "This is where Music LCD will store it\'s configuration information and temporary f" +
    "iles, and required files.";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(6, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(55, 15);
			this.label14.TabIndex = 2;
			this.label14.Text = "File Path:";
			// 
			// openexplorer
			// 
			this.openexplorer.Location = new System.Drawing.Point(469, 38);
			this.openexplorer.Name = "openexplorer";
			this.openexplorer.Size = new System.Drawing.Size(29, 25);
			this.openexplorer.TabIndex = 1;
			this.openexplorer.Text = "...";
			this.openexplorer.UseVisualStyleBackColor = true;
			this.openexplorer.Click += new System.EventHandler(this.openexplorer_Click);
			// 
			// filepath
			// 
			this.filepath.Location = new System.Drawing.Point(6, 39);
			this.filepath.Name = "filepath";
			this.filepath.Size = new System.Drawing.Size(457, 23);
			this.filepath.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(6, 37);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(492, 248);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = resources.GetString("textBox1.Text");
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(208, 15);
			this.label13.TabIndex = 0;
			this.label13.Text = "Please read the following information:";
			// 
			// shortcuts
			// 
			this.shortcuts.Controls.Add(this.instruct);
			this.shortcuts.Controls.Add(this.cdesktopshortcut);
			this.shortcuts.Controls.Add(this.ctaskbarpin);
			this.shortcuts.Controls.Add(this.cstartmenupin);
			this.shortcuts.Controls.Add(this.cstartmenufolder);
			this.shortcuts.Controls.Add(this.label17);
			this.shortcuts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shortcuts.Location = new System.Drawing.Point(259, 45);
			this.shortcuts.Name = "shortcuts";
			this.shortcuts.Size = new System.Drawing.Size(506, 291);
			this.shortcuts.TabIndex = 12;
			this.shortcuts.TabStop = false;
			this.shortcuts.Text = "Shortcuts";
			// 
			// instruct
			// 
			this.instruct.Controls.Add(this.textBox3);
			this.instruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.instruct.Location = new System.Drawing.Point(0, 0);
			this.instruct.Name = "instruct";
			this.instruct.Size = new System.Drawing.Size(506, 291);
			this.instruct.TabIndex = 13;
			this.instruct.TabStop = false;
			this.instruct.Text = "Instructions";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.Location = new System.Drawing.Point(6, 23);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox3.Size = new System.Drawing.Size(492, 261);
			this.textBox3.TabIndex = 0;
			this.textBox3.Text = resources.GetString("textBox3.Text");
			// 
			// cdesktopshortcut
			// 
			this.cdesktopshortcut.AutoSize = true;
			this.cdesktopshortcut.Location = new System.Drawing.Point(9, 116);
			this.cdesktopshortcut.Name = "cdesktopshortcut";
			this.cdesktopshortcut.Size = new System.Drawing.Size(152, 19);
			this.cdesktopshortcut.TabIndex = 6;
			this.cdesktopshortcut.Text = "Create desktop shortcut";
			this.cdesktopshortcut.UseVisualStyleBackColor = true;
			// 
			// ctaskbarpin
			// 
			this.ctaskbarpin.AutoSize = true;
			this.ctaskbarpin.Enabled = false;
			this.ctaskbarpin.Location = new System.Drawing.Point(9, 91);
			this.ctaskbarpin.Name = "ctaskbarpin";
			this.ctaskbarpin.Size = new System.Drawing.Size(234, 19);
			this.ctaskbarpin.TabIndex = 5;
			this.ctaskbarpin.Text = "Create taskbar pin (Under construction)";
			this.ctaskbarpin.UseVisualStyleBackColor = true;
			// 
			// cstartmenupin
			// 
			this.cstartmenupin.AutoSize = true;
			this.cstartmenupin.Enabled = false;
			this.cstartmenupin.Location = new System.Drawing.Point(9, 66);
			this.cstartmenupin.Name = "cstartmenupin";
			this.cstartmenupin.Size = new System.Drawing.Size(253, 19);
			this.cstartmenupin.TabIndex = 4;
			this.cstartmenupin.Text = "Create start menu pin (Under construction)";
			this.cstartmenupin.UseVisualStyleBackColor = true;
			// 
			// cstartmenufolder
			// 
			this.cstartmenufolder.AutoSize = true;
			this.cstartmenufolder.Enabled = false;
			this.cstartmenufolder.Location = new System.Drawing.Point(9, 41);
			this.cstartmenufolder.Name = "cstartmenufolder";
			this.cstartmenufolder.Size = new System.Drawing.Size(154, 19);
			this.cstartmenufolder.TabIndex = 3;
			this.cstartmenufolder.Text = "Create start menu folder";
			this.cstartmenufolder.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 19);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(217, 15);
			this.label17.TabIndex = 2;
			this.label17.Text = "Select shortcuts you want to be created.";
			// 
			// installation
			// 
			this.installation.Controls.Add(this.Complete);
			this.installation.Controls.Add(this.logs);
			this.installation.Controls.Add(this.label16);
			this.installation.Controls.Add(this.pictureBox1);
			this.installation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.installation.Location = new System.Drawing.Point(259, 45);
			this.installation.Name = "installation";
			this.installation.Size = new System.Drawing.Size(506, 291);
			this.installation.TabIndex = 14;
			this.installation.TabStop = false;
			this.installation.Text = "Installation";
			// 
			// Complete
			// 
			this.Complete.Controls.Add(this.label18);
			this.Complete.Location = new System.Drawing.Point(0, 0);
			this.Complete.Name = "Complete";
			this.Complete.Size = new System.Drawing.Size(506, 291);
			this.Complete.TabIndex = 3;
			this.Complete.TabStop = false;
			this.Complete.Text = "Installation Complete";
			this.Complete.Visible = false;
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(6, 19);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(494, 268);
			this.label18.TabIndex = 0;
			this.label18.Text = "Music LCD is installed!";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// logs
			// 
			this.logs.BackColor = System.Drawing.Color.Black;
			this.logs.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logs.ForeColor = System.Drawing.Color.White;
			this.logs.Location = new System.Drawing.Point(6, 236);
			this.logs.Multiline = true;
			this.logs.Name = "logs";
			this.logs.ReadOnly = true;
			this.logs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.logs.Size = new System.Drawing.Size(492, 49);
			this.logs.TabIndex = 1;
			this.logs.Text = "Music LCD Install Logs\r\n(c) FikuSystems 2024\r\n===================================" +
    "===============================";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 19);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(158, 15);
			this.label16.TabIndex = 0;
			this.label16.Text = "Music LCD is being installed.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Music.LCD.Installer.Properties.Resources.INSTALLING;
			this.pictureBox1.Location = new System.Drawing.Point(6, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(494, 189);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// instalprogress
			// 
			this.instalprogress.Location = new System.Drawing.Point(352, 343);
			this.instalprogress.Maximum = 5;
			this.instalprogress.Name = "instalprogress";
			this.instalprogress.Size = new System.Drawing.Size(228, 25);
			this.instalprogress.TabIndex = 15;
			// 
			// nextbtn
			// 
			this.nextbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextbtn.Location = new System.Drawing.Point(679, 342);
			this.nextbtn.Name = "nextbtn";
			this.nextbtn.Size = new System.Drawing.Size(87, 27);
			this.nextbtn.TabIndex = 5;
			this.nextbtn.Text = "Next";
			this.nextbtn.UseVisualStyleBackColor = true;
			this.nextbtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// copyingFiles
			// 
			this.copyingFiles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.copyingFiles_DoWork);
			this.copyingFiles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.copyingFiles_RunWorkerCompleted);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Installer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(777, 381);
			this.Controls.Add(this.instalprogress);
			this.Controls.Add(this.installation);
			this.Controls.Add(this.shortcuts);
			this.Controls.Add(this.preinstallinfo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.exitbtn);
			this.Controls.Add(this.backbtn);
			this.Controls.Add(this.nextbtn);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Installer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "| Music LCD | Installer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.preinstallinfo.ResumeLayout(false);
			this.preinstallinfo.PerformLayout();
			this.Selectinstalllocation.ResumeLayout(false);
			this.Selectinstalllocation.PerformLayout();
			this.shortcuts.ResumeLayout(false);
			this.shortcuts.PerformLayout();
			this.instruct.ResumeLayout(false);
			this.instruct.PerformLayout();
			this.installation.ResumeLayout(false);
			this.installation.PerformLayout();
			this.Complete.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox preinstallinfo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label s6;
        private System.Windows.Forms.Label s5;
        private System.Windows.Forms.Label s4;
        private System.Windows.Forms.Label s3;
        private System.Windows.Forms.Label s2;
        private System.Windows.Forms.Label s1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label s8;
        private System.Windows.Forms.Label s7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox Selectinstalllocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button openexplorer;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.GroupBox shortcuts;
        private System.Windows.Forms.GroupBox instruct;
        private System.Windows.Forms.CheckBox cdesktopshortcut;
        private System.Windows.Forms.CheckBox ctaskbarpin;
        private System.Windows.Forms.CheckBox cstartmenupin;
        private System.Windows.Forms.CheckBox cstartmenufolder;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox installation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox logs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Complete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar instalprogress;
        private System.Windows.Forms.Button nextbtn;
		private System.ComponentModel.BackgroundWorker copyingFiles;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

