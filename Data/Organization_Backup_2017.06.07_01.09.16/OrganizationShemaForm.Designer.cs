namespace Organization
{
    partial class OrganizationShemaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationShemaForm));
            this.radDiagram1 = new Telerik.WinControls.UI.RadDiagram();
            this.diagramPanel = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).BeginInit();
            this.diagramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(45, 544);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.diagramPanel);
            this.panel2.Size = new System.Drawing.Size(1114, 544);
            this.panel2.Controls.SetChildIndex(this.diagramPanel, 0);
            this.panel2.Controls.SetChildIndex(this.lblFormName, 0);
            // 
            // radDiagram1
            // 
            this.radDiagram1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radDiagram1.Location = new System.Drawing.Point(0, 0);
            this.radDiagram1.Name = "radDiagram1";
            this.radDiagram1.Size = new System.Drawing.Size(1094, 496);
            this.radDiagram1.TabIndex = 0;
            this.radDiagram1.Text = "radDiagram1";
          
            // 
            // diagramPanel
            // 
            this.diagramPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.diagramPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diagramPanel.Controls.Add(this.radDiagram1);
            this.diagramPanel.Location = new System.Drawing.Point(6, 34);
            this.diagramPanel.Name = "diagramPanel";
            this.diagramPanel.Size = new System.Drawing.Size(1096, 498);
            this.diagramPanel.TabIndex = 2;
           
            // 
            // OrganizationShemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 544);
            this.Name = "OrganizationShemaForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "OrganizationShemaForm";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFormName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDiagram1)).EndInit();
            this.diagramPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDiagram radDiagram1;
        private System.Windows.Forms.Panel diagramPanel;
    }
}
