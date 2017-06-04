namespace Alimex
{
    partial class MainForm
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
            this.radMainTitleBar = new Telerik.WinControls.UI.RadTitleBar();
            this.myButtonUser = new Telerik.WinControls.UI.RadButton();
            this.myPanelUser = new Telerik.WinControls.UI.RadPanel();
            this.myButtonSettings = new Telerik.WinControls.UI.RadButton();
            this.myPanelTop = new Telerik.WinControls.UI.RadPanel();
            this.myButtonNext = new Telerik.WinControls.UI.RadButton();
            this.myButtonHome = new Telerik.WinControls.UI.RadButton();
            this.myButtonPrevious = new Telerik.WinControls.UI.RadButton();
            this.object_599861ba_fd37_4bec_9615_64a256f88766 = new Telerik.WinControls.RootRadElement();
            this.object_3ac0dd08_8014_4d55_865c_aa0963692a9c = new Telerik.WinControls.RootRadElement();
            this.mySplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.radMainTitleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPanelUser)).BeginInit();
            this.myPanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPanelTop)).BeginInit();
            this.myPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySplitContainer)).BeginInit();
            this.mySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMainTitleBar
            // 
            this.radMainTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.radMainTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.radMainTitleBar.ForeColor = System.Drawing.Color.White;
            this.radMainTitleBar.Location = new System.Drawing.Point(0, 0);
            this.radMainTitleBar.Name = "radMainTitleBar";
            this.radMainTitleBar.Size = new System.Drawing.Size(805, 30);
            this.radMainTitleBar.TabIndex = 0;
            this.radMainTitleBar.TabStop = false;
            this.radMainTitleBar.Text = "Alimex";
            ((Telerik.WinControls.UI.RadTitleBarElement)(this.radMainTitleBar.GetChildAt(0))).Text = "Alimex";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMainTitleBar.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMainTitleBar.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // myButtonUser
            // 
            this.myButtonUser.BackColor = System.Drawing.Color.Transparent;
            this.myButtonUser.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.myButtonUser.ForeColor = System.Drawing.Color.White;
            this.myButtonUser.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.myButtonUser.Location = new System.Drawing.Point(3, 4);
            this.myButtonUser.Name = "myButtonUser";
            this.myButtonUser.Size = new System.Drawing.Size(62, 32);
            this.myButtonUser.TabIndex = 1;
            this.myButtonUser.Text = "Admin";
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonUser.GetChildAt(0))).Image = null;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonUser.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonUser.GetChildAt(0))).Text = "Admin";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myButtonUser.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myPanelUser
            // 
            this.myPanelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myPanelUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.myPanelUser.Controls.Add(this.myButtonUser);
            this.myPanelUser.Controls.Add(this.myButtonSettings);
            this.myPanelUser.Location = new System.Drawing.Point(700, 5);
            this.myPanelUser.Name = "myPanelUser";
            this.myPanelUser.Size = new System.Drawing.Size(105, 32);
            this.myPanelUser.TabIndex = 3;
            ((Telerik.WinControls.UI.RadPanelElement)(this.myPanelUser.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myPanelUser.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myButtonSettings
            // 
            this.myButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myButtonSettings.BackColor = System.Drawing.Color.Transparent;
            this.myButtonSettings.Image = global::Alimex.Properties.Resources.appbar_settings;
            this.myButtonSettings.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.myButtonSettings.Location = new System.Drawing.Point(68, 4);
            this.myButtonSettings.Name = "myButtonSettings";
            this.myButtonSettings.Size = new System.Drawing.Size(32, 32);
            this.myButtonSettings.TabIndex = 1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonSettings.GetChildAt(0))).Image = global::Alimex.Properties.Resources.appbar_settings;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonSettings.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myButtonSettings.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myPanelTop
            // 
            this.myPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.myPanelTop.Controls.Add(this.myButtonNext);
            this.myPanelTop.Controls.Add(this.myPanelUser);
            this.myPanelTop.Controls.Add(this.myButtonHome);
            this.myPanelTop.Controls.Add(this.myButtonPrevious);
            this.myPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.myPanelTop.Location = new System.Drawing.Point(0, 30);
            this.myPanelTop.Name = "myPanelTop";
            this.myPanelTop.Size = new System.Drawing.Size(805, 40);
            this.myPanelTop.TabIndex = 4;
            ((Telerik.WinControls.UI.RadPanelElement)(this.myPanelTop.GetChildAt(0))).Text = "";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myPanelTop.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myButtonNext
            // 
            this.myButtonNext.BackColor = System.Drawing.Color.Transparent;
            this.myButtonNext.Image = global::Alimex.Properties.Resources.appbar_next;
            this.myButtonNext.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.myButtonNext.Location = new System.Drawing.Point(74, 8);
            this.myButtonNext.Name = "myButtonNext";
            this.myButtonNext.Size = new System.Drawing.Size(32, 32);
            this.myButtonNext.TabIndex = 1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonNext.GetChildAt(0))).Image = global::Alimex.Properties.Resources.appbar_next;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonNext.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myButtonNext.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myButtonHome
            // 
            this.myButtonHome.BackColor = System.Drawing.Color.Transparent;
            this.myButtonHome.Image = global::Alimex.Properties.Resources.appbar1;
            this.myButtonHome.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.myButtonHome.Location = new System.Drawing.Point(12, 6);
            this.myButtonHome.Name = "myButtonHome";
            this.myButtonHome.Size = new System.Drawing.Size(32, 32);
            this.myButtonHome.TabIndex = 0;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonHome.GetChildAt(0))).Image = global::Alimex.Properties.Resources.appbar1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonHome.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myButtonHome.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // myButtonPrevious
            // 
            this.myButtonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.myButtonPrevious.Image = global::Alimex.Properties.Resources.appbar_previous;
            this.myButtonPrevious.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.myButtonPrevious.Location = new System.Drawing.Point(50, 8);
            this.myButtonPrevious.Name = "myButtonPrevious";
            this.myButtonPrevious.Size = new System.Drawing.Size(32, 32);
            this.myButtonPrevious.TabIndex = 1;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonPrevious.GetChildAt(0))).Image = global::Alimex.Properties.Resources.appbar_previous;
            ((Telerik.WinControls.UI.RadButtonElement)(this.myButtonPrevious.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.myButtonPrevious.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // object_599861ba_fd37_4bec_9615_64a256f88766
            // 
            this.object_599861ba_fd37_4bec_9615_64a256f88766.Name = "object_599861ba_fd37_4bec_9615_64a256f88766";
            this.object_599861ba_fd37_4bec_9615_64a256f88766.StretchHorizontally = true;
            this.object_599861ba_fd37_4bec_9615_64a256f88766.StretchVertically = true;
            // 
            // object_3ac0dd08_8014_4d55_865c_aa0963692a9c
            // 
            this.object_3ac0dd08_8014_4d55_865c_aa0963692a9c.MinSize = new System.Drawing.Size(25, 25);
            this.object_3ac0dd08_8014_4d55_865c_aa0963692a9c.Name = "object_3ac0dd08_8014_4d55_865c_aa0963692a9c";
            this.object_3ac0dd08_8014_4d55_865c_aa0963692a9c.StretchHorizontally = true;
            this.object_3ac0dd08_8014_4d55_865c_aa0963692a9c.StretchVertically = true;
            // 
            // mySplitContainer
            // 
            this.mySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mySplitContainer.Location = new System.Drawing.Point(0, 70);
            this.mySplitContainer.Name = "mySplitContainer";
            this.mySplitContainer.Size = new System.Drawing.Size(805, 565);
            this.mySplitContainer.SplitterDistance = 268;
            this.mySplitContainer.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 635);
            this.Controls.Add(this.mySplitContainer);
            this.Controls.Add(this.myPanelTop);
            this.Controls.Add(this.radMainTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Alimex";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.radMainTitleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPanelUser)).EndInit();
            this.myPanelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myButtonSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPanelTop)).EndInit();
            this.myPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myButtonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mySplitContainer)).EndInit();
            this.mySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radMainTitleBar;
        private Telerik.WinControls.UI.RadButton myButtonHome;
        private Telerik.WinControls.UI.RadButton myButtonNext;
        private Telerik.WinControls.UI.RadButton myButtonPrevious;
        private Telerik.WinControls.UI.RadButton myButtonUser;
        private Telerik.WinControls.UI.RadButton myButtonSettings;
        private Telerik.WinControls.UI.RadPanel myPanelUser;
        private Telerik.WinControls.UI.RadPanel myPanelTop;
        private Telerik.WinControls.RootRadElement object_599861ba_fd37_4bec_9615_64a256f88766;
        private Telerik.WinControls.RootRadElement object_3ac0dd08_8014_4d55_865c_aa0963692a9c;
        private System.Windows.Forms.SplitContainer mySplitContainer;
    }
}