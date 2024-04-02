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
	public partial class DownloadUtility : Form
	{
		public DownloadUtility()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DownloadUtility_Load(object sender, EventArgs e)
		{
			gradients();
		}
		private void gradients()
		{
            panel6.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel6.ClientRectangle,
                    Color.FromArgb(242, 177, 0),
                    Color.FromArgb(252, 205, 77),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel6.ClientRectangle); ;
                }
            };
        }
	}
}
