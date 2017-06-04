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
using BaseFormProject;
namespace Organization
{
    public class RoleNode : BaseForm
    {
        private RadButton radButton1;
        private RadButton radButton2;
        private RadLabel radLabel1;
        private RadLabel radLabel2;
        private RadDropDownList radDropDownList2;
        private RadTextBox radTextBox1;
        IOrganiztionForm _parentForm;
        public RoleNode(List<AlimexDAL.Entity.Organization> parents,IOrganiztionForm parentForm)
        {
            InitializeComponent();
           // this.ThemeName = "TelerikMetro";
            this.ApplyThemeRecursively(this.Controls);            
            this.radDropDownList2.ValueMember = "Id";
            this.radDropDownList2.DisplayMember = "Name";
            this.radDropDownList2.DataSource = parents;
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDropDownList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
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
            this.radLabel1.Size = new System.Drawing.Size(36, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Name";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(32, 84);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(38, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Parent";
            // 
            // radDropDownList2
            // 
            this.radDropDownList2.Location = new System.Drawing.Point(133, 84);
            this.radDropDownList2.Name = "radDropDownList2";
            this.radDropDownList2.Size = new System.Drawing.Size(125, 20);
            this.radDropDownList2.TabIndex = 0;
            this.radDropDownList2.Text = "radDropDownList1";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Location = new System.Drawing.Point(133, 39);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(125, 20);
            this.radTextBox1.TabIndex = 5;
            // 
            // RoleNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(278, 177);
            this.Controls.Add(this.radTextBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
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
            _parentForm.addUnit(radTextBox1.Text, (int)radDropDownList2.SelectedItem.Value);
            this.Close();

        }       
    }
}
