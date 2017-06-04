namespace Alimex.MenuForm
{
    partial class NarrowMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myPanelTop)).BeginInit();
            this.myPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanelTop
            // 
            this.myPanelTop.Controls.Add(this.btnOpen);
            this.myPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanelTop.Location = new System.Drawing.Point(0, 0);
            this.myPanelTop.Name = "myPanelTop";
            this.myPanelTop.Size = new System.Drawing.Size(60, 34);
            this.myPanelTop.TabIndex = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnOpen.Image = global::Alimex.Properties.Resources.menu;
            this.btnOpen.Location = new System.Drawing.Point(17, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(26, 28);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // NarrowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myPanelTop);
            this.Name = "NarrowMenu";
            this.Size = new System.Drawing.Size(60, 537);
            ((System.ComponentModel.ISupportInitialize)(this.myPanelTop)).EndInit();
            this.myPanelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel myPanelTop;
        private System.Windows.Forms.Button btnOpen;
    }
}
