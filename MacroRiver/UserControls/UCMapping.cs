﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using Dapper;
using OfficeOpenXml;
using System.IO;
using MacroRiver.Common.Utils;

namespace MacroRiver.UserControls
{
    public partial class UCMapping : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string tableName { get; set; }
        public string excelFileName { get; set; }

        private List<string> excelColumnHeaders = new List<string>();
        private string cellValueBeforeEdit;

        public UCMapping(IDbConnection DbConnection, string tableName, string fileName)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.tableName = tableName;
            this.excelFileName = fileName;
            InitializeComponent();
        }

        private void UCMapping_Load(object sender, EventArgs e)
        {
            if (this.DbConnection != null &&
                !String.IsNullOrEmpty(this.tableName) &&
                !(String.IsNullOrEmpty(this.excelFileName)))
            {
                // 获取数据库字段
                var currDB = this.DbConnection.Database;
                this.DbConnection.Open();
                this.DbConnection.ChangeDatabase("information_schema");
                var dbColumns = DbConnection.Query<string>(String.Format("select column_name from columns where table_schema = '{0}' and table_name = '{1}';", currDB, tableName)).ToList();
                this.DbConnection.ChangeDatabase(currDB);
                this.DbConnection.Close();
                // 获取Excel列头
                var existingFile = new FileInfo(this.excelFileName);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    // get the first worksheet in the workbook
                    var sheet = package.Workbook.Worksheets[1];

                    for (int col = sheet.Dimension.Start.Column; col <= sheet.Dimension.End.Column; col++)
                    {
                        this.excelColumnHeaders.Add(Convert.ToString(sheet.Cells[sheet.Dimension.Start.Row, col].Value));
                    }
                }

                var loopTo = Math.Max(dbColumns.Count, this.excelColumnHeaders.Count);
                var dt = new DataTable();
                dt.Columns.Add("DBCol");
                dt.Columns.Add("Mapping");
                dt.Columns.Add("ExcelCol");
                for (int i = 0; i < loopTo; i++)
                {
                    var row = dt.NewRow();
                    row[0] = i < dbColumns.Count ? dbColumns[i] : null;
                    row[1] = "<-->";
                    row[2] = i < this.excelColumnHeaders.Count ? this.excelColumnHeaders[i] : null;
                    dt.Rows.Add(row);
                }
                this.dgvMapping.DataSource = dt;

                for (int i = 0; i < this.dgvMapping.Rows.Count; i++)
                {
                    this.dgvMapping.Rows[i].Height = 30;
                }
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvMapping.Rows.Count; i++)
            {
                this.excelColumnHeaders[i] = Convert.ToString(this.dgvMapping.Rows[i].Cells["ColExcelColumn"].Value);
            }
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCExcel(DbConnection, tableName, excelFileName));
            this.Parent.Controls.Remove(this);
        }

        private void dgvMapping_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var colName = Convert.ToString(dgvMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            if (!String.IsNullOrEmpty(colName) && !excelColumnHeaders.Contains(colName.Trim()))
            {
                MetroMsgBoxUtil.Fail(this, String.Format("不存在名为\"{0}\"的列头。", colName), "列头错误");
                this.dgvMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellValueBeforeEdit;
            }
        }

        private void dgvMapping_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellValueBeforeEdit = Convert.ToString(this.dgvMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }
    }
}
