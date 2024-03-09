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

namespace Music.LCD.Installer
{
    public partial class Installer : Form
    {
        public int PageNumber;

        public Installer()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Selectinstalllocation.Visible = false;
            shortcuts.Visible = false;
            instruct.Visible = false;
            installation.Visible = false;
            Complete.Visible = false;
            backbtn.Enabled = false;
            gradients();
            PageNumber = 0;
            this.Size = new System.Drawing.Size(793, 417);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/FikuSystems/MusicLCD");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PageNumber +=1;
            if(PageNumber == 0)
            {
                Selectinstalllocation.Visible = false;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = false;
                instalprogress.Value = 0;
                s1.Font = new Font("Segoe UI", 9);
                label4.Text = "Welcome!";
            }
            if (PageNumber == 1)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = true;
                instalprogress.Value = 1;
                s1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s2.Font = new Font("Segoe UI", 9);
                label4.Text = "Preperation";
            }
            if (PageNumber == 2)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 2;
                s1.Font = new Font("Segoe UI", 9);
                s2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s3.Font = new Font("Segoe UI", 9);
                label4.Text = "Preperation";
            }
            if (PageNumber == 3)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 3;
                s2.Font = new Font("Segoe UI", 9);
                s3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s4.Font = new Font("Segoe UI", 9);
                label4.Text = "Preperation";
            }
            if (PageNumber == 4)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = false;
                nextbtn.Enabled = true;
                backbtn.Enabled = false;
                exitbtn.Enabled = false;
                instalprogress.Value = 4;
                label4.Text = "Installation";
                s3.Font = new Font("Segoe UI", 9);
                s4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s8.Font = new Font("Segoe UI", 12);
            }
            if (PageNumber == 5)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = true;
                nextbtn.Enabled = true;
                instalprogress.Value = 5;
                label4.Text = "Installation Complete!";
                s4.Font = new Font("Segoe UI", 9);
                s8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                nextbtn.Text = "Finish";
            }
            if (PageNumber == 6)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PageNumber -= 1;
            if (PageNumber == 0)
            {
                Selectinstalllocation.Visible = false;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = false;
                instalprogress.Value = 0;
                s1.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 1)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = false;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                backbtn.Enabled = true;
                instalprogress.Value = 1;
                s1.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s2.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 2)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = false;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 2;
                s1.Font = new Font("Segoe UI", 9);
                s2.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s3.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 3)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = false;
                Complete.Visible = false;
                instalprogress.Value = 3;
                s2.Font = new Font("Segoe UI", 9);
                s3.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s4.Font = new Font("Segoe UI", 9);
            }
            if (PageNumber == 4)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = false;
                nextbtn.Enabled = true;
                backbtn.Enabled = false;
                exitbtn.Enabled = false;
                instalprogress.Value = 4;
                s3.Font = new Font("Segoe UI", 9);
                s4.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                s8.Font = new Font("Segoe UI", 12);
            }
            if (PageNumber == 5)
            {
                Selectinstalllocation.Visible = true;
                shortcuts.Visible = true;
                instruct.Visible = true;
                installation.Visible = true;
                Complete.Visible = true;
                nextbtn.Enabled = true;
                instalprogress.Value = 5;
                s4.Font = new Font("Segoe UI", 9);
                s8.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                nextbtn.Text = "Finish";
            }
            if (PageNumber == 6)
            {
                Application.Exit();
            }
        }
    }
}
