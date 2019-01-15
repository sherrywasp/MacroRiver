namespace MacroRiver.UserControls
{
    partial class UCExcel
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mlnkFind = new MetroFramework.Controls.MetroLink();
            this.mtxtFileName = new MetroFramework.Controls.MetroTextBox();
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
            this.metroLabel1.Size = new System.Drawing.Size(136, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "选择 Excel 文件";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Excel 工作簿(*.xlsx)|*.xlsx";
            // 
            // mlnkFind
            // 
            this.mlnkFind.BackColor = System.Drawing.Color.Transparent;
            this.mlnkFind.BackgroundImage = global::MacroRiver.Properties.Resources.find_32;
            this.mlnkFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mlnkFind.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mlnkFind.ImageSize = 32;
            this.mlnkFind.Location = new System.Drawing.Point(637, 78);
            this.mlnkFind.Name = "mlnkFind";
            this.mlnkFind.Size = new System.Drawing.Size(40, 40);
            this.mlnkFind.TabIndex = 13;
            this.mlnkFind.UseCustomBackColor = true;
            this.mlnkFind.UseCustomForeColor = true;
            this.mlnkFind.UseSelectable = true;
            this.mlnkFind.UseStyleColors = true;
            this.mlnkFind.Click += new System.EventHandler(this.mlnkFind_Click);
            // 
            // mtxtFileName
            // 
            // 
            // 
            // 
            this.mtxtFileName.CustomButton.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mtxtFileName.CustomButton.Image = null;
            this.mtxtFileName.CustomButton.Location = new System.Drawing.Point(559, 2);
            this.mtxtFileName.CustomButton.Name = "";
            this.mtxtFileName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.mtxtFileName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtxtFileName.CustomButton.TabIndex = 1;
            this.mtxtFileName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtxtFileName.CustomButton.UseSelectable = true;
            this.mtxtFileName.CustomButton.Visible = false;
            this.mtxtFileName.DisplayIcon = true;
            this.mtxtFileName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mtxtFileName.Icon = global::MacroRiver.Properties.Resources.excel_24;
            this.mtxtFileName.Lines = new string[0];
            this.mtxtFileName.Location = new System.Drawing.Point(42, 83);
            this.mtxtFileName.MaxLength = 255;
            this.mtxtFileName.Name = "mtxtFileName";
            this.mtxtFileName.PasswordChar = '\0';
            this.mtxtFileName.ReadOnly = true;
            this.mtxtFileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtFileName.SelectedText = "";
            this.mtxtFileName.SelectionLength = 0;
            this.mtxtFileName.SelectionStart = 0;
            this.mtxtFileName.ShortcutsEnabled = true;
            this.mtxtFileName.ShowClearButton = true;
            this.mtxtFileName.Size = new System.Drawing.Size(589, 32);
            this.mtxtFileName.TabIndex = 12;
            this.mtxtFileName.UseSelectable = true;
            this.mtxtFileName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtxtFileName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(663, 549);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(64, 48);
            this.mtBack.TabIndex = 10;
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
            this.mtNext.Location = new System.Drawing.Point(733, 549);
            this.mtNext.Name = "mtNext";
            this.mtNext.Size = new System.Drawing.Size(64, 48);
            this.mtNext.TabIndex = 9;
            this.mtNext.TileImage = global::MacroRiver.Properties.Resources.next_48;
            this.mtNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNext.UseCustomBackColor = true;
            this.mtNext.UseSelectable = true;
            this.mtNext.UseTileImage = true;
            this.mtNext.Click += new System.EventHandler(this.mtNext_Click);
            // 
            // UCExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mlnkFind);
            this.Controls.Add(this.mtxtFileName);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtNext);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCExcel";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UCExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtNext;
        private MetroFramework.Controls.MetroTextBox mtxtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLink mlnkFind;
    }
}
