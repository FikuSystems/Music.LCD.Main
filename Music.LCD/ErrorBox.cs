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

namespace Music.LCD
{
    public partial class ErrorBox : Form
    {

        public ErrorBox()
        {
            InitializeComponent();

        }

        private void notisend_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Windows\Media\windows foreground.wav");
            player.Play();
            jajo();
            int margin = 0;
            Screen screen = Screen.FromControl(this);
            int newX = screen.WorkingArea.Right - this.Width;
            int newY = screen.WorkingArea.Bottom - this.Height - margin;
            this.Location = new Point(newX, newY);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void kext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
