using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.LCD.Updater
{
    public partial class NoUpdates : Form
    {
        public NoUpdates()
        {
            InitializeComponent();
        }

        private void NoUpdates_Load(object sender, EventArgs e)
        {
            jajo();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\windows foreground.wav");
            player.Play();
            
        }
        private void jajo()
        {
            panel1.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(254, 7, 7),
                    Color.FromArgb(177, 4, 4),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/FikuSystems/Music.LCD.Main/issues");
        }
    }
}
