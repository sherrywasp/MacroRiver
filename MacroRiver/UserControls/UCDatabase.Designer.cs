namespace MacroRiver.UserControls
{
    partial class UCDatabase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mGridDB = new MetroFramework.Controls.MetroGrid();
            this.ColDatabase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtNext = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.mGridDB)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(145, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "选择一个数据库";
            // 
            // mGridDB
            // 
            this.mGridDB.AllowUserToAddRows = false;
            this.mGridDB.AllowUserToDeleteRows = false;
            this.mGridDB.AllowUserToResizeRows = false;
            this.mGridDB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mGridDB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mGridDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mGridDB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mGridDB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mGridDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mGridDB.ColumnHeadersVisible = false;
            this.mGridDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDatabase});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mGridDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.mGridDB.EnableHeadersVisualStyles = false;
            this.mGridDB.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mGridDB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.mGridDB.Location = new System.Drawing.Point(0, 40);
            this.mGridDB.Margin = new System.Windows.Forms.Padding(0);
            this.mGridDB.MultiSelect = false;
            this.mGridDB.Name = "mGridDB";
            this.mGridDB.ReadOnly = true;
            this.mGridDB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mGridDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mGridDB.RowHeadersVisible = false;
            this.mGridDB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mGridDB.RowTemplate.Height = 23;
            this.mGridDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mGridDB.Size = new System.Drawing.Size(800, 506);
            this.mGridDB.TabIndex = 0;
            this.mGridDB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mGridDB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mGridDB_KeyPress);
            // 
            // ColDatabase
            // 
            this.ColDatabase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColDatabase.DataPropertyName = "Database";
            this.ColDatabase.HeaderText = "Database";
            this.ColDatabase.Name = "ColDatabase";
            this.ColDatabase.ReadOnly = true;
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(663, 549);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(64, 48);
            this.mtBack.TabIndex = 2;
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
            this.mtNext.TabIndex = 1;
            this.mtNext.TileImage = global::MacroRiver.Properties.Resources.next_48;
            this.mtNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNext.UseCustomBackColor = true;
            this.mtNext.UseSelectable = true;
            this.mtNext.UseTileImage = true;
            this.mtNext.Click += new System.EventHandler(this.mtNext_Click);
            // 
            // UCDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mGridDB);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtNext);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCDatabase";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UCDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mGridDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtNext;
        private MetroFramework.Controls.MetroGrid mGridDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDatabase;
    }
}
