namespace MacroRiver.UserControls
{
    partial class UCTableInspector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvTableInspector = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtNext = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInspector)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(107, 25);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "检查表结构";
            // 
            // dgvTableInspector
            // 
            this.dgvTableInspector.AllowUserToAddRows = false;
            this.dgvTableInspector.AllowUserToDeleteRows = false;
            this.dgvTableInspector.AllowUserToResizeRows = false;
            this.dgvTableInspector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTableInspector.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTableInspector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTableInspector.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableInspector.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTableInspector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableInspector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTableInspector.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTableInspector.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvTableInspector.Location = new System.Drawing.Point(0, 40);
            this.dgvTableInspector.Margin = new System.Windows.Forms.Padding(0);
            this.dgvTableInspector.Name = "dgvTableInspector";
            this.dgvTableInspector.ReadOnly = true;
            this.dgvTableInspector.RowHeadersVisible = false;
            this.dgvTableInspector.RowTemplate.Height = 23;
            this.dgvTableInspector.Size = new System.Drawing.Size(800, 506);
            this.dgvTableInspector.TabIndex = 11;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Key";
            this.Column4.HeaderText = "键";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 60;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Field";
            this.Column1.HeaderText = "字段名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Type";
            this.Column2.HeaderText = "类型";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Null";
            this.Column3.HeaderText = "可空";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Default";
            this.Column6.HeaderText = "默认值";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Comment";
            this.Column7.HeaderText = "注释";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Extra";
            this.Column5.HeaderText = "附加信息";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Privileges";
            this.Column8.HeaderText = "Privileges";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Collation";
            this.Column9.HeaderText = "Collation";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
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
            // UCTableInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvTableInspector);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtNext);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCTableInspector";
            this.Size = new System.Drawing.Size(800, 600);
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.UCTableInspector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableInspector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtNext;
        private System.Windows.Forms.DataGridView dgvTableInspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
