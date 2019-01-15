namespace MacroRiver
{
    partial class FormMain
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
            this.ucHome1 = new MacroRiver.UserControls.UCHome();
            this.SuspendLayout();
            // 
            // ucHome1
            // 
            this.ucHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucHome1.Location = new System.Drawing.Point(4, 60);
            this.ucHome1.Name = "ucHome1";
            this.ucHome1.Size = new System.Drawing.Size(998, 551);
            this.ucHome1.TabIndex = 0;
            this.ucHome1.UseSelectable = true;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1006, 615);
            this.Controls.Add(this.ucHome1);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(4, 60, 4, 4);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "MacroRiver";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private UserControls.UCHome ucHome1;
    }
}