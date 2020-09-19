using Dapper;
using MacroRiver.Common.Utils;
using MacroRiver.Model;
using MetroFramework.Controls;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MacroRiver.UserControls
{
    public partial class UCMapping : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string TableName { get; set; }
        public string ExcelFileName { get; set; }

        private List<ColumnMapping> lstColumnMapping = new List<ColumnMapping>();

        private List<string> excelColumnHeaderNameList = new List<string>();
        private List<int> excelColumnHeaderIndexList = new List<int>();

        private string cellValueBeforeEdit;

        public UCMapping(IDbConnection DbConnection, string tableName, string fileName)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.TableName = tableName;
            this.ExcelFileName = fileName;
            InitializeComponent();
        }

        private void UCMapping_Load(object sender, EventArgs e)
        {
            if (this.DbConnection != null &&
                !String.IsNullOrEmpty(TableName) &&
                !(String.IsNullOrEmpty(ExcelFileName)))
            {
                // 获取数据库字段
                var currDB = this.DbConnection.Database;
                if (this.DbConnection.State == ConnectionState.Closed)
                {
                    this.DbConnection.Open();
                }
                this.DbConnection.ChangeDatabase("information_schema");
                var dbColumns = DbConnection.Query<string>(String.Format("select column_name from columns where table_schema = '{0}' and table_name = '{1}';", currDB, TableName)).ToList();
                this.DbConnection.ChangeDatabase(currDB);
                this.DbConnection.Close();
                // 获取Excel列头
                var existingFile = new FileInfo(ExcelFileName);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    // get the first worksheet in the workbook
                    var sheet = package.Workbook.Worksheets[1];

                    for (int col = sheet.Dimension.Start.Column; col <= sheet.Dimension.End.Column; col++)
                    {
                        this.excelColumnHeaderIndexList.Add(col);
                        this.excelColumnHeaderNameList.Add(Convert.ToString(sheet.Cells[sheet.Dimension.Start.Row, col].Value));
                    }
                }

                var loopTo = Math.Max(dbColumns.Count, this.excelColumnHeaderNameList.Count);
                var dt = new DataTable();
                dt.Columns.Add("DBCol");
                dt.Columns.Add("Mapping");
                dt.Columns.Add("ExcelCol");
                for (int i = 0; i < loopTo; i++)
                {
                    var row = dt.NewRow();
                    row[0] = i < dbColumns.Count ? dbColumns[i] : null;
                    row[1] = "-->";
                    row[2] = i < this.excelColumnHeaderNameList.Count ? this.excelColumnHeaderNameList[i] : null;
                    dt.Rows.Add(row);
                }
                this.dgvMapping.AutoGenerateColumns = false;
                this.dgvMapping.DataSource = dt;

                for (int i = 0; i < this.dgvMapping.Rows.Count; i++)
                {
                    this.dgvMapping.Rows[i].Height = 30;
                }
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            var currDB = this.DbConnection.Database;
            if (this.DbConnection.State == ConnectionState.Closed)
            {
                this.DbConnection.Open();
            }
            this.DbConnection.ChangeDatabase("information_schema");

            for (int i = 0; i < this.dgvMapping.Rows.Count; i++)
            {
                var excelColName = Convert.ToString(this.dgvMapping.Rows[i].Cells["ColExcelColumn"].Value);
                if (!String.IsNullOrEmpty(excelColName))
                {
                    var dbCol = Convert.ToString(this.dgvMapping.Rows[i].Cells["ColDBColumn"].Value);
                    if (!String.IsNullOrEmpty(dbCol))
                    {
                        // 获取字段信息
                        var select_columns = String.Format(
                            "select column_name, is_nullable, data_type, column_type, character_maximum_length, character_octet_length, numeric_precision, numeric_scale, datetime_precision, column_key, extra, column_comment "
                            + "from columns "
                            + "where table_schema = '{0}' and table_name = '{1}' and column_name = '{2}'",
                            currDB, TableName, dbCol
                        );

                        var field = DbConnection.Query<InformationSchemaColumns>(select_columns).First();

                        // 因为 sheet.Dimension.Start.Column 的起始值为1, 
                        // 而此处遍历行索引的 i 起始值为 0，
                        // 所以需要加 1 再赋值给 ColumnMapping 的 ColIndex 属性.


                        int index = this.excelColumnHeaderNameList.IndexOf(excelColName);
                        int excelColIndex = this.excelColumnHeaderIndexList[index];
                        lstColumnMapping.Add(new ColumnMapping(excelColIndex, excelColName, field));
                    }
                }
            }

            this.DbConnection.ChangeDatabase(currDB);
            this.DbConnection.Close();

            this.Parent.Controls.Add(new UCValidation(DbConnection, TableName, ExcelFileName, lstColumnMapping));
            this.Parent.Controls.Remove(this);
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCExcel(DbConnection, TableName, ExcelFileName));
            this.Parent.Controls.Remove(this);
        }

        private void dgvMapping_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var colName = Convert.ToString(dgvMapping.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            if (!String.IsNullOrEmpty(colName) && !excelColumnHeaderNameList.Contains(colName.Trim()))
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
