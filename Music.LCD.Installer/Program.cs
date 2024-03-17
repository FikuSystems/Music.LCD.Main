using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music.LCD.Installer
{

    internal static class Program
    {
		public static string[] CommandLineArgs { get; private set; }
		/// <summary>
		/// </summary>
		[STAThread]

		static void Main(string[] args)
		{
			CommandLineArgs = args;
			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Installer());
        }

	}
}
