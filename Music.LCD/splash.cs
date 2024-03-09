using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.Activation;


namespace Music.LCD
{
    public partial class splash : Form
    {
        private int durationInSeconds = 5;
        private int languageIndex = 0;
        public splash()
        {
            InitializeComponent();

        }

        private void splash_Load(object sender, EventArgs e)
        {
            AnimateLabel();
        }
        private async Task AnimateLabel()
        {
            // Initial position and opacity
            int startX = label4.Left;
            int endX = (this.ClientSize.Width - label4.Width) / 2; // Center of the form
            float startOpacity = 0f;
            float endOpacity = 1f;

            // Slide in animation
            for (int i = 0; i <= 100; i += 5)
            {
                int currentX = (int)Math.Round(EaseInOut(startX, endX, i / 100.0));
                label4.Left = currentX;

                float currentOpacity = (float)EaseInOut(startOpacity, endOpacity, i / 100.0);

                label4.ForeColor = Color.FromArgb((int)(currentOpacity * 255), label4.ForeColor);
                await Task.Delay(15);
            }

            // Reset position and hide label
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            //
        }

        private double EaseInOut(double start, double end, double progress)
        {
            // Simple ease-in-out function
            return start + (end - start) * ((Math.Sin(progress * Math.PI - Math.PI / 2.0) + 1.0) / 2.0);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int elapsedMilliseconds = timer2.Interval * timer2Count;
            double progress = (double)elapsedMilliseconds / (durationInSeconds * 10);

            Color newColor = InterpolateColor(Color.FromArgb(86, 165, 132), Color.White, progress);
            label4.ForeColor = newColor;

            if (progress >= 1.0)
            {
                timer2.Stop();
            }

            timer2Count++;
        }

        private Color InterpolateColor(Color startColor, Color endColor, double progress)
        {
            int r = Clamp((int)(startColor.R + (endColor.R - startColor.R) * progress), 0, 255);
            int g = Clamp((int)(startColor.G + (endColor.G - startColor.G) * progress), 0, 255);
            int b = Clamp((int)(startColor.B + (endColor.B - startColor.B) * progress), 0, 255);

            return Color.FromArgb(r, g, b);
        }

        private int Clamp(int value, int min, int max)
        {
            return Math.Min(Math.Max(value, min), max);
        }

        private int timer2Count = 0;
    }
}
