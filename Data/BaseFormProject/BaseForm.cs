using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Themes;
using Telerik.WinControls.UI;
namespace BaseFormProject
{
    public partial class BaseForm : RadForm
    {
        protected string  themeName = "TelerikMetro";
        public BaseForm()
        {
            LoadThemes();
            InitializeComponent();
            this.ThemeName = themeName;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            this.ApplyThemeRecursively(this.Controls);
        }
        private static void LoadThemes()
        {
            new TelerikMetroTheme();            
        }
        protected void ApplyThemeRecursively(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null)
                {
                    radControl.ThemeName = this.themeName;
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }    
    }
}
