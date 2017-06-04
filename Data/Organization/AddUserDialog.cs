using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using AlimexDAL.Entity;
using AlimexDAL;
namespace Organization
{
    public class AddUserDialog : RadForm
    {
        private RadButton radButton1;
        private RadButton radButton2;
        private RadLabel radLabel1;
        private RadLabel radLabel2;
        private RadDropDownList radDropDownList2;
        private RadDropDownList radDropDownList1;
        IOrganiztionForm _parentForm;
        public AddUserDialog(List<AlimexDAL.Entity.Organization> parents,List<User> users, IOrganiztionForm parentForm)
        {
            InitializeComponent();
            this.ThemeName = "TelerikMetro";
            this.ApplyThemeRecursively(this.Controls);            
            this.radDropDownList2.ValueMember = "Id";
            this.radDropDownList2.DisplayMember = "Name";
            this.radDropDownList2.DataSource = parents;


            this.radDropDownList1.ValueMember = "Id";
            this.radDropDownList1.DisplayMember = "Name";
            this.radDropDownList1.DataSource = users;

            _parentForm = parentForm;

        }
        private void ApplyThemeRecursively(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                RadControl radControl = control as RadControl;
                if (radControl != null)
                {
                    radControl.ThemeName = this.ThemeName;
                }

                this.ApplyThemeRecursively(control.Controls);
            }
        }    

        private void InitializeComponent()
        {
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radDropDownList2 = new Telerik.WinControls.UI.RadDropDownList();
            this.radDropDownList1 = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(32, 128);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(110, 24);
            this.radButton1.TabIndex = 3;
            this.radButton1.Text = "Cancel";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(148, 128);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(110, 24);
            this.radButton2.TabIndex = 3;
            this.radButton2.Text = "Ok";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(32, 39);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "User";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(32, 84);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(27, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Unit";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.Location = new System.Drawing.Point(133, 84);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(125, 20);
            this.radDropDownList2.TabIndex = 0;
            this.radDropDownList2.Text = "radDropDownList1";
            // 
            // radDropDownList1
            // 
            this.radDropDownList1.Location = new System.Drawing.Point(133, 37);
            this.radDropDownList1.Name = "radDropDownList1";
            this.radDropDownList1.Size = new System.Drawing.Size(125, 20);
            this.radDropDownList1.TabIndex = 0;
            this.radDropDownList1.Text = "radDropDownList1";
            // 
            // RoleNode
            // 
            this.ClientSize = new System.Drawing.Size(278, 177);
            this.Controls.Add(this.radDropDownList1);
            this.Controls.Add(this.radDropDownList2);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoleNode";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radButton2_Click(object sender, EventArgs e)
        {
            _parentForm.addMember(radDropDownList1.SelectedItem.Value.ToString(), (int)radDropDownList2.SelectedItem.Value);
            this.Close();

        }       
    }
}
