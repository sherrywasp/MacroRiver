namespace MacroRiver.UserControls
{
    partial class UCMapping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtNext = new MetroFramework.Controls.MetroTile();
            this.dgvMapping = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColExcelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapping)).BeginInit();
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
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "设置列对应关系";
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(663, 549);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(64, 48);
            this.mtBack.TabIndex = 12;
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
            this.mtNext.TabIndex = 11;
            this.mtNext.TileImage = global::MacroRiver.Properties.Resources.next_48;
            this.mtNext.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtNext.UseCustomBackColor = true;
            this.mtNext.UseSelectable = true;
            this.mtNext.UseTileImage = true;
            this.mtNext.Click += new System.EventHandler(this.mtNext_Click);
            // 
            // dgvMapping
            // 
            this.dgvMapping.AllowUserToAddRows = false;
            this.dgvMapping.AllowUserToDeleteRows = false;
            this.dgvMapping.AllowUserToResizeRows = false;
            this.dgvMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMapping.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMapping.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMapping.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMapping.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMapping.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMapping.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMapping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.ColExcelColumn});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMapping.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMapping.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMapping.Location = new System.Drawing.Point(0, 40);
            this.dgvMapping.Margin = new System.Windows.Forms.Padding(0);
            this.dgvMapping.MultiSelect = false;
            this.dgvMapping.Name = "dgvMapping";
            this.dgvMapping.RowHeadersVisible = false;
            this.dgvMapping.RowTemplate.Height = 23;
            this.dgvMapping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMapping.Size = new System.Drawing.Size(800, 506);
            this.dgvMapping.TabIndex = 13;
            this.dgvMapping.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMapping_CellBeginEdit);
            this.dgvMapping.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMapping_CellEndEdit);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DBCol";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FillWeight = 200F;
            this.Column1.HeaderText = "数据库字段名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Mapping";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // ColExcelColumn
            // 
            this.ColExcelColumn.DataPropertyName = "ExcelCol";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColExcelColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColExcelColumn.FillWeight = 200F;
            this.ColExcelColumn.HeaderText = "Excel列名";
            this.ColExcelColumn.Name = "ColExcelColumn";
            // 
            // UCMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMapping);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtNext);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UCMapping";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UCMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtNext;
        private System.Windows.Forms.DataGridView dgvMapping;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColExcelColumn;
    }
}
