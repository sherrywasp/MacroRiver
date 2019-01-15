namespace MacroRiver.UserControls
{
    partial class UCConnection
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtxtHostname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mtxtPassword = new MetroFramework.Controls.MetroTextBox();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtNext = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "创建一个连接";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(71, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "主机";
            // 
            // mtxtHostname
            // 
            // 
            // 
            // 
            this.mtxtHostname.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.mtxtHostname.CustomButton.Image = null;
            this.mtxtHostname.CustomButton.Location = new System.Drawing.Point(553, 2);
            this.mtxtHostname.CustomButton.Name = "";
            this.mtxtHostname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtHostname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtHostname.CustomButton.TabIndex = 1;
            this.mtxtHostname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtHostname.CustomButton.UseSelectable = true;
            this.mtxtHostname.CustomButton.UseVisualStyleBackColor = false;
            this.mtxtHostname.CustomButton.Visible = false;
            this.mtxtHostname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtHostname.Lines = new string[0];
            this.mtxtHostname.Location = new System.Drawing.Point(71, 98);
            this.mtxtHostname.MaxLength = 20;
            this.mtxtHostname.Name = "mtxtHostname";
            this.mtxtHostname.PasswordChar = '\0';
            this.mtxtHostname.PromptText = "主机名或 IP";
            this.mtxtHostname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtHostname.SelectedText = "";
            this.mtxtHostname.SelectionLength = 0;
            this.mtxtHostname.SelectionStart = 0;
            this.mtxtHostname.ShortcutsEnabled = true;
            this.mtxtHostname.ShowClearButton = true;
            this.mtxtHostname.Size = new System.Drawing.Size(581, 30);
            this.mtxtHostname.TabIndex = 0;
            this.mtxtHostname.UseSelectable = true;
            this.mtxtHostname.WaterMark = "主机名或 IP";
            this.mtxtHostname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtHostname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtHostname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(71, 141);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "端口";
            // 
            // mtxtPort
            // 
            // 
            // 
            // 
            this.mtxtPort.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.mtxtPort.CustomButton.Image = null;
            this.mtxtPort.CustomButton.Location = new System.Drawing.Point(553, 2);
            this.mtxtPort.CustomButton.Name = "";
            this.mtxtPort.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPort.CustomButton.TabIndex = 1;
            this.mtxtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPort.CustomButton.UseSelectable = true;
            this.mtxtPort.CustomButton.UseVisualStyleBackColor = false;
            this.mtxtPort.CustomButton.Visible = false;
            this.mtxtPort.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtPort.Lines = new string[0];
            this.mtxtPort.Location = new System.Drawing.Point(71, 179);
            this.mtxtPort.MaxLength = 5;
            this.mtxtPort.Name = "mtxtPort";
            this.mtxtPort.PasswordChar = '\0';
            this.mtxtPort.PromptText = "不填则采用默认端口 3306";
            this.mtxtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPort.SelectedText = "";
            this.mtxtPort.SelectionLength = 0;
            this.mtxtPort.SelectionStart = 0;
            this.mtxtPort.ShortcutsEnabled = true;
            this.mtxtPort.ShowClearButton = true;
            this.mtxtPort.Size = new System.Drawing.Size(581, 30);
            this.mtxtPort.TabIndex = 1;
            this.mtxtPort.UseSelectable = true;
            this.mtxtPort.WaterMark = "不填则采用默认端口 3306";
            this.mtxtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(71, 222);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "用户名";
            // 
            // mtxtUsername
            // 
            // 
            // 
            // 
            this.mtxtUsername.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.mtxtUsername.CustomButton.Image = null;
            this.mtxtUsername.CustomButton.Location = new System.Drawing.Point(553, 2);
            this.mtxtUsername.CustomButton.Name = "";
            this.mtxtUsername.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtUsername.CustomButton.TabIndex = 1;
            this.mtxtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtUsername.CustomButton.UseSelectable = true;
            this.mtxtUsername.CustomButton.UseVisualStyleBackColor = false;
            this.mtxtUsername.CustomButton.Visible = false;
            this.mtxtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtUsername.Lines = new string[0];
            this.mtxtUsername.Location = new System.Drawing.Point(71, 260);
            this.mtxtUsername.MaxLength = 20;
            this.mtxtUsername.Name = "mtxtUsername";
            this.mtxtUsername.PasswordChar = '\0';
            this.mtxtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtUsername.SelectedText = "";
            this.mtxtUsername.SelectionLength = 0;
            this.mtxtUsername.SelectionStart = 0;
            this.mtxtUsername.ShortcutsEnabled = true;
            this.mtxtUsername.ShowClearButton = true;
            this.mtxtUsername.Size = new System.Drawing.Size(581, 30);
            this.mtxtUsername.TabIndex = 2;
            this.mtxtUsername.UseSelectable = true;
            this.mtxtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(71, 303);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(48, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "密码";
            // 
            // mtxtPassword
            // 
            // 
            // 
            // 
            this.mtxtPassword.CustomButton.BackColor = System.Drawing.Color.Transparent;
            this.mtxtPassword.CustomButton.Image = null;
            this.mtxtPassword.CustomButton.Location = new System.Drawing.Point(553, 2);
            this.mtxtPassword.CustomButton.Name = "";
            this.mtxtPassword.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.mtxtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtPassword.CustomButton.TabIndex = 1;
            this.mtxtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtPassword.CustomButton.UseSelectable = true;
            this.mtxtPassword.CustomButton.UseVisualStyleBackColor = false;
            this.mtxtPassword.CustomButton.Visible = false;
            this.mtxtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtPassword.Lines = new string[0];
            this.mtxtPassword.Location = new System.Drawing.Point(71, 341);
            this.mtxtPassword.MaxLength = 20;
            this.mtxtPassword.Name = "mtxtPassword";
            this.mtxtPassword.PasswordChar = '●';
            this.mtxtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtPassword.SelectedText = "";
            this.mtxtPassword.SelectionLength = 0;
            this.mtxtPassword.SelectionStart = 0;
            this.mtxtPassword.ShortcutsEnabled = true;
            this.mtxtPassword.ShowClearButton = true;
            this.mtxtPassword.Size = new System.Drawing.Size(581, 30);
            this.mtxtPassword.TabIndex = 3;
            this.mtxtPassword.UseSelectable = true;
            this.mtxtPassword.UseSystemPasswordChar = true;
            this.mtxtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxt_KeyPress);
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(720, 503);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(64, 48);
            this.mtBack.TabIndex = 5;
            this.mtBack.TileImage = global::MacroRiver.Properties.Resources.back_48;
            this.mtBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBack.UseCustomBackColor = true;
            this.mtBack.UseSelectable = true;
            this.mtBack.UseTileImage = true;
            this.mtBack.Click += new System.EventHandler(this.mtBack_Click);
            // 
            // mtNext
            // 
            this.mtNext.ActiveControl = null;
            this.mtNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtNext.BackColor = System.Drawing.Color.Transparent;
            this.mtNext.Location = new System.Drawing.Point(790, 503);
            this.mtNext.Name = "mtNext";
            this.mtNext.Size = new System.Drawing.Size(64, 48);
            this.mtNext.TabIndex = 4;
            this.mtNext.TileImage = global::MacroRiver.Properties.Resources.next_48;
            this.mtNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNext.UseCustomBackColor = true;
            this.mtNext.UseSelectable = true;
            this.mtNext.UseTileImage = true;
            this.mtNext.Click += new System.EventHandler(this.mtNext_Click);
            // 
            // UCConnection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mtxtPassword);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.mtxtUsername);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.mtxtPort);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtxtHostname);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtNext);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCConnection";
            this.Size = new System.Drawing.Size(857, 554);
            this.Load += new System.EventHandler(this.UCConnection_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UCConnection_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtNext;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtxtHostname;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mtxtPort;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtUsername;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox mtxtPassword;
    }
}
