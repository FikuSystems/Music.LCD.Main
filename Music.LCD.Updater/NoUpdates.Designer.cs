namespace Music.LCD.Updater
{
    partial class NoUpdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoUpdates));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titlelabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.bodylabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(165)))), ((int)(((byte)(132)))));
            this.panel1.Controls.Add(this.titlelabel);
            this.panel1.Controls.Add(this.descriptionlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 71);
            this.panel1.TabIndex = 2;
            // 
            // titlelabel
            // 
            this.titlelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.titlelabel.BackColor = System.Drawing.Color.Transparent;
            this.titlelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.titlelabel.ForeColor = System.Drawing.Color.White;
            this.titlelabel.Location = new System.Drawing.Point(13, 9);
            this.titlelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(488, 32);
            this.titlelabel.TabIndex = 1;
            this.titlelabel.Text = "No Update Avalible!";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionlabel.BackColor = System.Drawing.Color.Transparent;
            this.descriptionlabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionlabel.ForeColor = System.Drawing.Color.White;
            this.descriptionlabel.Location = new System.Drawing.Point(13, 42);
            this.descriptionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(488, 15);
            this.descriptionlabel.TabIndex = 0;
            this.descriptionlabel.Text = "The updater did not find any updates.";
            this.descriptionlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bodylabel
            // 
            this.bodylabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bodylabel.Location = new System.Drawing.Point(12, 74);
            this.bodylabel.Name = "bodylabel";
            this.bodylabel.Size = new System.Drawing.Size(490, 148);
            this.bodylabel.TabIndex = 4;
            this.bodylabel.Text = "No updates found!\r\n\r\nPlease exit the updater to continue.";
            this.bodylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(209, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit updater";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 35);
            this.panel2.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Image = global::Music.LCD.Updater.Properties.Resources._1532_Flag_Red1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(389, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Report Problem";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NoUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 260);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bodylabel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoUpdates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "An error has occured";
            this.Load += new System.EventHandler(this.NoUpdates_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label titlelabel;
        public System.Windows.Forms.Label descriptionlabel;
        public System.Windows.Forms.Label bodylabel;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}