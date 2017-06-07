namespace Alimex.MenuForm
{
    partial class WideMenu
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
            this.radWideFormPanel = new Telerik.WinControls.UI.RadPanel();
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.radTreeView = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.radWideFormPanel)).BeginInit();
            this.radWideFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView)).BeginInit();
            this.SuspendLayout();
            // 
            // radWideFormPanel
            // 
            this.radWideFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.radWideFormPanel.Controls.Add(this.myTextBox);
            this.radWideFormPanel.Controls.Add(this.btnClose);
            this.radWideFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.radWideFormPanel.Location = new System.Drawing.Point(0, 0);
            this.radWideFormPanel.Name = "radWideFormPanel";
            this.radWideFormPanel.Size = new System.Drawing.Size(339, 34);
            this.radWideFormPanel.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radWideFormPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myTextBox
            // 
            this.myTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox.Location = new System.Drawing.Point(7, 9);
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.Size = new System.Drawing.Size(270, 15);
            this.myTextBox.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.Image = global::Alimex.Properties.Resources.appbar3;
            this.btnClose.Location = new System.Drawing.Point(290, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 28);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // radTreeView
            // 
            this.radTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.radTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radTreeView.Location = new System.Drawing.Point(0, 34);
            this.radTreeView.Margin = new System.Windows.Forms.Padding(10);
            this.radTreeView.Name = "radTreeView";
            this.radTreeView.Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
            this.radTreeView.Size = new System.Drawing.Size(339, 531);
            this.radTreeView.SpacingBetweenNodes = -1;
            this.radTreeView.TabIndex = 1;
            this.radTreeView.Text = "radTreeView1";
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.radTreeView.GetChildAt(0))).NodeSpacing = -1;
            ((Telerik.WinControls.UI.RadTreeViewElement)(this.radTreeView.GetChildAt(0))).Padding = new System.Windows.Forms.Padding(10, 2, 0, 0);
            ((Telerik.WinControls.UI.RadScrollBarElement)(this.radTreeView.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTreeView.GetChildAt(0).GetChildAt(2).GetChildAt(4).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radTreeView.GetChildAt(0).GetChildAt(2).GetChildAt(4).GetChildAt(1))).AngleTransform = -180F;
            // 
            // WideMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radTreeView);
            this.Controls.Add(this.radWideFormPanel);
            this.Name = "WideMenu";
            this.Size = new System.Drawing.Size(339, 565);
            ((System.ComponentModel.ISupportInitialize)(this.radWideFormPanel)).EndInit();
            this.radWideFormPanel.ResumeLayout(false);
            this.radWideFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTreeView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radWideFormPanel;
        private Telerik.WinControls.UI.RadTreeView radTreeView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox myTextBox;
    }
}
