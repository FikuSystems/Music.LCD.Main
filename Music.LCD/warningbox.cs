﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.LCD
{
    public partial class WarningBox : Form
    {
        public WarningBox()
        {
            InitializeComponent();
        }

        private void warningbox_Load(object sender, EventArgs e)
        {
            gradients();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\Windows background.wav");
            player.Play();
            int margin = 0;
            Screen screen = Screen.FromControl(this);
            int newX = screen.WorkingArea.Right - this.Width;
            int newY = screen.WorkingArea.Bottom - this.Height - margin;
            this.Location = new Point(newX, newY);
        }
        private void gradients()
        {
            panel1.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(246, 174, 1),
                    Color.FromArgb(246, 144, 1),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
                }
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
