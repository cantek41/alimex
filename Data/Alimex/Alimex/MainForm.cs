using Alimex.MenuForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
namespace Alimex
{

    public partial class MainForm : RadForm
    {
        private WideMenu _wideMenu;
        public MainForm()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _wideMenu = new WideMenu();
            _wideMenu.Dock = DockStyle.Fill;
            MainsplitContainer.Panel1.BackColor = Color.FromArgb(234, 235, 236);
            MainsplitContainer.Panel1.Controls.Add(_wideMenu);

        }

        public void showForm(string namesapace, string formName)
        {
            hideAllForm();
            Form myForm = checkHistory(formName);
            if (myForm == null)
                myForm = PreperForm.getForm(namesapace, formName);
            myForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            MainsplitContainer.Panel2.Controls.Add(myForm);
            myForm.Show();
            myForm.Dock = DockStyle.Fill;
        }

        private void hideAllForm()
        {
            foreach (var item in MainsplitContainer.Panel2.Controls)
            {
                var a = item as Form;
                if (a == null)
                    continue;
                a.Hide();

            }
        }

        private Form checkHistory(string nameSpace)
        {
            foreach (var item in MainsplitContainer.Panel2.Controls)
            {
                var a = item as Form;
                if (a == null)
                    continue;
                if (a.ProductName + a.Name == nameSpace)
                    return a;
            }
            return null;
        }

        private void setTheme()
        {
            this.ThemeName = "TelerikMetro";
            foreach (var item in this.Controls)
            {
                var c = item as RadControl;
                if (c != null)
                {
                    c.ThemeName = "TelerikMetro";
                }
            }
            radMainTitleBar.ThemeName = "";
        }
    }
}
