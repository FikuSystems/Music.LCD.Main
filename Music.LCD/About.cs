using Microsoft.Win32;
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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/FikuSystems/MusicLCD#readme");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OSL osl = new OSL();
            osl.Show();
        }

        private void About_Load(object sender, EventArgs e)
        {
            gradients();
            CurVer.Text = Application.ProductVersion.ToString();
            try
            {
                OldVer.Text = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\MusicLCD\OldVersionNumber").ToString();
            }
            catch
            {
                MessageBox.Show("Could not get registry value.\r\nDownload installer to create neccessary registry values!");
            }

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
    }
}
