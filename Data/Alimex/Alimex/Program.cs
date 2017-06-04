using System;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.Themes;

namespace Alimex
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new TelerikMetroTheme();
            Application.Run(new MainForm());
            //Application.Run(new Form1());

        }
    }
}