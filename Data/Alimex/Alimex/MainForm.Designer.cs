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
            this.radMainTopPanel = new Telerik.WinControls.UI.RadPanel();
            this.MainsplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.radMainTitleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMainTopPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainsplitContainer)).BeginInit();
            this.MainsplitContainer.SuspendLayout();
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
            this.radMainTitleBar.Size = new System.Drawing.Size(805, 20);
            this.radMainTitleBar.TabIndex = 0;
            this.radMainTitleBar.TabStop = false;
            this.radMainTitleBar.Text = "Alimex";
            ((Telerik.WinControls.UI.RadTitleBarElement)(this.radMainTitleBar.GetChildAt(0))).Text = "Alimex";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMainTitleBar.GetChildAt(0).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMainTitleBar.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // radMainTopPanel
            // 
            this.radMainTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(126)))), ((int)(((byte)(20)))));
            this.radMainTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.radMainTopPanel.Location = new System.Drawing.Point(0, 20);
            this.radMainTopPanel.Name = "radMainTopPanel";
            this.radMainTopPanel.Size = new System.Drawing.Size(805, 29);
            this.radMainTopPanel.TabIndex = 1;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radMainTopPanel.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            // 
            // MainsplitContainer
            // 
            this.MainsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainsplitContainer.Location = new System.Drawing.Point(0, 49);
            this.MainsplitContainer.Name = "MainsplitContainer";
            // 
            // MainsplitContainer.Panel1
            // 
            this.MainsplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            // 
            // MainsplitContainer.Panel2
            // 
            this.MainsplitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.MainsplitContainer.Size = new System.Drawing.Size(805, 579);
            this.MainsplitContainer.SplitterDistance = 267;
            this.MainsplitContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 628);
            this.Controls.Add(this.MainsplitContainer);
            this.Controls.Add(this.radMainTopPanel);
            this.Controls.Add(this.radMainTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Alimex";
            ((System.ComponentModel.ISupportInitialize)(this.radMainTitleBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMainTopPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainsplitContainer)).EndInit();
            this.MainsplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radMainTitleBar;
        private Telerik.WinControls.UI.RadPanel radMainTopPanel;
        private System.Windows.Forms.SplitContainer MainsplitContainer;
    }
}