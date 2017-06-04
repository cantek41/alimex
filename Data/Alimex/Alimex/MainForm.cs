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
        private NarrowMenu _narrowMenu;
        
        
        public MainForm()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            _wideMenu = new WideMenu();
            _wideMenu.Dock = DockStyle.Fill;

            _narrowMenu = new NarrowMenu();
            _narrowMenu.Dock = DockStyle.Fill;
            _narrowMenu.Visible = false;


            mySplitContainer.Panel1.BackColor = Color.FromArgb(234, 235, 236);
            

            mySplitContainer.Panel1.Controls.Add(_wideMenu);
            mySplitContainer.Panel1.Controls.Add(_narrowMenu);

            
            //Panel1 genişlik veriyor
           // mySplitContainer.SplitterDistance = 125;
            //mySplitContainer.SplitterWidth = 1;
            
        }

        public void btnOpenClose_Click(object sender, EventArgs e)
        {


            if (_wideMenu.Visible)
            {             
              
              
                _wideMenu.Visible = false;
                _narrowMenu.Visible = true;
                mySplitContainer.SplitterDistance = _narrowMenu.Width; 
            }
            else
            {
                mySplitContainer.SplitterDistance = _wideMenu.Width; 
                _narrowMenu.Visible = false;
                _wideMenu.Visible = true;
            }
        }


        public void showForm(string namesapace,string formName)
        {
            
            Form myForm = PreperForm.getForm(namesapace, formName);
            myForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            mySplitContainer.Panel2.Controls.Add(myForm);
            myForm.Show();
            myForm.Dock = DockStyle.Fill;
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

        private void MainForm_Resize(object sender, EventArgs e)
        {
            reSizeNavi();
        }

        private void reSizeNavi()
        {
            if (_wideMenu.Visible)
            {
                mySplitContainer.SplitterDistance = _wideMenu.Width;
            }
            else
            {
                mySplitContainer.SplitterDistance = _narrowMenu.Width;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            reSizeNavi();
        }

        private void mySplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

            if (mySplitContainer.SplitterDistance <= 60 && _wideMenu.Visible)
            {
                //MessageBox.Show(mySplitContainer.SplitterDistance.ToString());
                _wideMenu.Visible = false;
                _narrowMenu.Visible = true;
            }
            else
            {
                _wideMenu.Visible = true;
                _narrowMenu.Visible = false;
            }
            
        }

     
    }
}
