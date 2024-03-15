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
    public partial class Updater : Form
    {
        public Updater()
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
        private void Updater_Load(object sender, EventArgs e)
        {
            gradients();
        }
        private void gradients()
        {
            panel1.Paint += (sender, e) =>
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    panel1.ClientRectangle,
                    Color.FromArgb(82, 183, 0),
                    Color.FromArgb(73, 116, 40),
                    LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, panel1.ClientRectangle); ;
                }
            };
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
