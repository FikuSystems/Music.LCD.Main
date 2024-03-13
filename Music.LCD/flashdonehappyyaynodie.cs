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
	public partial class flashdonehappyyaynodie : Form
	{
		public flashdonehappyyaynodie()
		{
			InitializeComponent();
		}
		private const int CP_NOCLOSE_BUTTON = 0x200;
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams Crp = base.CreateParams;
				Crp.ClassStyle = Crp.ClassStyle | CP_NOCLOSE_BUTTON;
				return Crp;
			}
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.Close();
		}

        private void flashdonehappyyaynodie_Load(object sender, EventArgs e)
        {
			gradients();
			ConfirmBox confirmbox = new ConfirmBox();
			confirmbox.Show();
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
