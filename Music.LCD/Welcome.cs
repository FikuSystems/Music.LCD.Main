using Music.LCD.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Globalization;

namespace Music.LCD
{
    public partial class welcome : Form
    {
        private int durationInSeconds = 5;
        private int languageIndex = 0;
        private List<string> languages = new List<string> {
            "English", "Polish", "French", "Spanish", "German", "Italian",
            "Chinese", "Japanese", "Korean", "Russian", "Arabic",
            "Portuguese", "Dutch", "Swedish", "Turkish", "Greek" };

        public welcome()
        {
            InitializeComponent();
        }

        private async void welcome_Load(object sender, EventArgs e)
        {
            panel1.Size = new Size(825, 742);
            await AnimateLabel();
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

            // Wait for 5 seconds
            await Task.Delay(5000);

            // Fade out animation
            for (int i = 100; i >= 0; i -= 5)
            {
                int currentX = (int)Math.Round(EaseInOut(endX, startX, i / 100.0));
                label4.Left = currentX;

                float currentOpacity = (float)EaseInOut(startOpacity, endOpacity, i / 100.0);

                label4.ForeColor = Color.FromArgb((int)(currentOpacity * 255), label4.ForeColor);
                await Task.Delay(15);
            }

            // Reset position and hide label
            label4.Left = startX;
            label4.Visible = false;
        }

        private double EaseInOut(double start, double end, double progress)
        {
            // Simple ease-in-out function
            return start + (end - start) * ((Math.Sin(progress * Math.PI - Math.PI / 2.0) + 1.0) / 2.0);
        }
        private string GetWelcomeMessage(string language)
        {
            switch(language)
            {
                case "English":
                    return "Welcome";
                case "Polish":
                    return "Witaj";
                case "French":
                    return "Bienvenue";
                case "Spanish":
                    return "Bienvenido";
                case "German":
                    return "Willkommen";
                case "Italian":
                    return "Benvenuto";
                case "Chinese":
                    return "欢迎";
                case "Japanese":
                    return "ようこそ";
                case "Korean":
                    return "환영합니다";
                case "Russian":
                    return "Добро пожаловать";
                case "Arabic":
                    return "أهلاً بك";
                case "Portuguese":
                    return "Bem-vindo";
                case "Dutch":
                    return "Welkom";
                case "Swedish":
                    return "Välkommen";
                case "Turkish":
                    return "Hoş geldiniz";
                case "Greek":
                    return "Καλώς ορίσατε";
                default:
                    return "Welcome";
                }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Change label text to "Welcome" in the current language
            label1.Text = GetWelcomeMessage(languages[languageIndex]);

            // Increment the language index
            languageIndex = (languageIndex + 1) % languages.Count;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/FikuSystems/MusicLCD#readme");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flasher flasher = new Flasher();
            flasher.Show();
            this.Close();
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int elapsedMilliseconds = timer2.Interval * timer2Count;
            double progress = (double)elapsedMilliseconds / (durationInSeconds * 10);

            Color newColor = InterpolateColor(Color.White, Color.Black, progress);
            label4.ForeColor = newColor;

            if (progress >= 1.0)
            {
                timer2.Stop();
            }

            timer2Count++;
        }

        private Color InterpolateColor(Color startColor, Color endColor, double progress)
        {
            int r = (int)(startColor.R + (endColor.R - startColor.R) * progress);
            int g = (int)(startColor.G + (endColor.G - startColor.G) * progress);
            int b = (int)(startColor.B + (endColor.B - startColor.B) * progress);

            return Color.FromArgb(r, g, b);
        }

        private int timer2Count = 0;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
