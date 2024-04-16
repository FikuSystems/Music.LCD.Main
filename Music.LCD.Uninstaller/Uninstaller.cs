using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Music.LCD.Uninstaller
{
    public partial class Uninstaller : Form
    {
        public Uninstaller()
        {
            InitializeComponent();
            BeginUninstall();
		}
		private void BeginUninstall()
		{
			//take data from registry and delete it
			string installLocation;

            installLocation = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MusicLCD", "InstallLocation", null).ToString();
            Registry.LocalMachine.DeleteSubKeyTree(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\MusicLCD");
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"Music.LCD.lnk"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"Music.LCD.lnk");
			}
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\Programs\Music.LCD.lnk"))
            {
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + @"\Programs\Music.LCD.lnk");
            }
            this.Close();
		}
	} 
    
}
