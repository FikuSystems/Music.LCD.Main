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
    public partial class checksuminvalid : Form
    {
        public checksuminvalid()
        {
            InitializeComponent();
        }

        private void checksuminvalid_Load(object sender, EventArgs e)
        {

        }
        private void grad()
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
        private void checksuminvalid_Load_1(object sender, EventArgs e)
        {
            grad();
        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
