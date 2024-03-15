namespace Music.LCD.Updater
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.BackupProgress = new System.Windows.Forms.ProgressBar();
            this.InstallProgress = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "MusicLCD Updater";
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(13, 85);
            this.DownloadProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(395, 23);
            this.DownloadProgress.TabIndex = 1;
            // 
            // BackupProgress
            // 
            this.BackupProgress.Location = new System.Drawing.Point(13, 193);
            this.BackupProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BackupProgress.Name = "BackupProgress";
            this.BackupProgress.Size = new System.Drawing.Size(395, 23);
            this.BackupProgress.TabIndex = 2;
            // 
            // InstallProgress
            // 
            this.InstallProgress.Location = new System.Drawing.Point(13, 139);
            this.InstallProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InstallProgress.Name = "InstallProgress";
            this.InstallProgress.Size = new System.Drawing.Size(395, 23);
            this.InstallProgress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Download update files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Backup exising files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apply new update";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(333, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current version: 1.0.0.0";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "New version:     1.0.0.1";
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 270);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InstallProgress);
            this.Controls.Add(this.BackupProgress);
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Updater";
            this.Text = "| MusicLCD | Updater";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.ProgressBar BackupProgress;
        private System.Windows.Forms.ProgressBar InstallProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

