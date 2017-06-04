using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.Themes;

namespace Organization
{
    static class Program
    {
        public static bool IsStart { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         
            LoadThemes();
            IsStart = false;
            Application.Run(new OrganizationShemaForm());
        }
        private static void LoadThemes()
        {
            new TelerikMetroTheme();           
        }

   
    }
}
