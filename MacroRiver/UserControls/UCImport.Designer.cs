namespace MacroRiver.UserControls
{
    partial class UCImport
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
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtRun = new MetroFramework.Controls.MetroTile();
            this.mchkRemoveWrap = new MetroFramework.Controls.MetroCheckBox();
            this.mchkSingleInsert = new MetroFramework.Controls.MetroCheckBox();
            this.mchkUseReplaceInto = new MetroFramework.Controls.MetroCheckBox();
            this.mchkUseRawForFunc = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mchkTrim = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 25);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "导入";
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.White;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(3, 547);
            this.metroProgressSpinner1.Maximum = 3;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(50, 50);
            this.metroProgressSpinner1.Speed = 2F;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroProgressSpinner1.TabIndex = 18;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Value = 1;
            this.metroProgressSpinner1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "SQL 脚本|*.sql";
            this.saveFileDialog1.Title = "导入脚本另存为";
            // 
            // mtSave
            // 
            this.mtSave.ActiveControl = null;
            this.mtSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtSave.BackColor = System.Drawing.Color.Transparent;
            this.mtSave.Location = new System.Drawing.Point(663, 549);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(64, 48);
            this.mtSave.TabIndex = 19;
            this.mtSave.TileImage = global::MacroRiver.Properties.Resources.save_48;
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.UseCustomBackColor = true;
            this.mtSave.UseSelectable = true;
            this.mtSave.UseTileImage = true;
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(593, 549);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(64, 48);
            this.mtBack.TabIndex = 16;
            this.mtBack.TileImage = global::MacroRiver.Properties.Resources.back_48;
            this.mtBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBack.UseCustomBackColor = true;
            this.mtBack.UseSelectable = true;
            this.mtBack.UseTileImage = true;
            this.mtBack.Click += new System.EventHandler(this.mtBack_Click);
            // 
            // mtRun
            // 
            this.mtRun.ActiveControl = null;
            this.mtRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtRun.BackColor = System.Drawing.Color.Transparent;
            this.mtRun.Location = new System.Drawing.Point(733, 549);
            this.mtRun.Name = "mtRun";
            this.mtRun.Size = new System.Drawing.Size(64, 48);
            this.mtRun.TabIndex = 15;
            this.mtRun.TileImage = global::MacroRiver.Properties.Resources.play_48;
            this.mtRun.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRun.UseCustomBackColor = true;
            this.mtRun.UseSelectable = true;
            this.mtRun.UseTileImage = true;
            this.mtRun.Click += new System.EventHandler(this.mtRun_Click);
            // 
            // mchkRemoveWrap
            // 
            this.mchkRemoveWrap.AutoSize = true;
            this.mchkRemoveWrap.Checked = true;
            this.mchkRemoveWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkRemoveWrap.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkRemoveWrap.Location = new System.Drawing.Point(47, 116);
            this.mchkRemoveWrap.Name = "mchkRemoveWrap";
            this.mchkRemoveWrap.Size = new System.Drawing.Size(237, 25);
            this.mchkRemoveWrap.TabIndex = 20;
            this.mchkRemoveWrap.Text = "去除单元格内容中的换行";
            this.mchkRemoveWrap.UseSelectable = true;
            // 
            // mchkSingleInsert
            // 
            this.mchkSingleInsert.AutoSize = true;
            this.mchkSingleInsert.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkSingleInsert.Location = new System.Drawing.Point(47, 260);
            this.mchkSingleInsert.Name = "mchkSingleInsert";
            this.mchkSingleInsert.Size = new System.Drawing.Size(184, 25);
            this.mchkSingleInsert.TabIndex = 21;
            this.mchkSingleInsert.Text = "生成单条 SQL 语句";
            this.mchkSingleInsert.UseSelectable = true;
            // 
            // mchkUseReplaceInto
            // 
            this.mchkUseReplaceInto.AutoSize = true;
            this.mchkUseReplaceInto.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkUseReplaceInto.Location = new System.Drawing.Point(47, 212);
            this.mchkUseReplaceInto.Name = "mchkUseReplaceInto";
            this.mchkUseReplaceInto.Size = new System.Drawing.Size(187, 25);
            this.mchkUseReplaceInto.TabIndex = 22;
            this.mchkUseReplaceInto.Text = "使用 REPLACE INTO";
            this.mchkUseReplaceInto.UseSelectable = true;
            // 
            // mchkUseRawForFunc
            // 
            this.mchkUseRawForFunc.AutoSize = true;
            this.mchkUseRawForFunc.Checked = true;
            this.mchkUseRawForFunc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkUseRawForFunc.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkUseRawForFunc.Location = new System.Drawing.Point(47, 164);
            this.mchkUseRawForFunc.Name = "mchkUseRawForFunc";
            this.mchkUseRawForFunc.Size = new System.Drawing.Size(309, 25);
            this.mchkUseRawForFunc.TabIndex = 23;
            this.mchkUseRawForFunc.Text = "原样输出以 “()” 结尾的单元格内容";
            this.mchkUseRawForFunc.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(362, 170);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(229, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "（视为SQL函数，生成时不加引号）";
            // 
            // mchkTrim
            // 
            this.mchkTrim.AutoSize = true;
            this.mchkTrim.Checked = true;
            this.mchkTrim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mchkTrim.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.mchkTrim.Location = new System.Drawing.Point(47, 68);
            this.mchkTrim.Name = "mchkTrim";
            this.mchkTrim.Size = new System.Drawing.Size(275, 25);
            this.mchkTrim.TabIndex = 25;
            this.mchkTrim.Text = "去除单元格内容中的首尾空格";
            this.mchkTrim.UseSelectable = true;
            // 
            // UCImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mchkTrim);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mchkUseRawForFunc);
            this.Controls.Add(this.mchkUseReplaceInto);
            this.Controls.Add(this.mchkSingleInsert);
            this.Controls.Add(this.mchkRemoveWrap);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtRun);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCImport";
            this.Size = new System.Drawing.Size(800, 600);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtRun;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Controls.MetroCheckBox mchkRemoveWrap;
        private MetroFramework.Controls.MetroCheckBox mchkSingleInsert;
        private MetroFramework.Controls.MetroCheckBox mchkUseReplaceInto;
        private MetroFramework.Controls.MetroCheckBox mchkUseRawForFunc;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox mchkTrim;
    }
}
