namespace MacroRiver.UserControls
{
    partial class UCHome
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
            this.mBtnStart = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mBtnStart
            // 
            this.mBtnStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mBtnStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.mBtnStart.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mBtnStart.Location = new System.Drawing.Point(159, 120);
            this.mBtnStart.Name = "mBtnStart";
            this.mBtnStart.Size = new System.Drawing.Size(151, 37);
            this.mBtnStart.TabIndex = 0;
            this.mBtnStart.Text = "开始使用";
            this.mBtnStart.UseSelectable = true;
            this.mBtnStart.Click += new System.EventHandler(this.mBtnStart_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(126, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(217, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Welcome to MacroRiver";
            // 
            // UCHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mBtnStart);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(477, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton mBtnStart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
