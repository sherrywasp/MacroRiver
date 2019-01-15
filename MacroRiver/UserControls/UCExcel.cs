﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace MacroRiver.UserControls
{
    public partial class UCExcel : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string tableName { get; set; }
        public string excelFileName { get; set; }

        public UCExcel(IDbConnection DbConnection, string tableName)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.tableName = tableName;
            InitializeComponent();
        }

        private void UCExcel_Load(object sender, EventArgs e)
        {
            this.mtxtFileName.Text = this.excelFileName;
        }

        private void mtNext_Click(object sender, EventArgs e)
        {

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCTableInspector(this.DbConnection, this.tableName));
            this.Parent.Controls.Remove(this);
        }

        private void mlnkFind_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.excelFileName = this.openFileDialog1.FileName;
                this.mtxtFileName.Text = this.openFileDialog1.FileName;
            }
        }
    }
}