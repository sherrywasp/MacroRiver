using Dapper;
using MacroRiver.Common.Utils;
using MacroRiver.Model;
using MetroFramework.Controls;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace MacroRiver.UserControls
{
    public partial class UCImport : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string TableName { get; set; }
        public string ExcelFileName { get; set; }
        public List<ColumnMapping> ColumnMappingList { get; set; }

        public UCImport(IDbConnection DbConnection, string tableName, string fileName, List<ColumnMapping> lstColumnMapping)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.TableName = tableName;
            this.ExcelFileName = fileName;
            this.ColumnMappingList = lstColumnMapping;
            InitializeComponent();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCValidation(DbConnection, TableName, ExcelFileName, ColumnMappingList));
            this.Parent.Controls.Remove(this);
        }

        private void mtRun_Click(object sender, EventArgs e)
        {
            this.metroProgressSpinner1.Visible = true;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (this.DbConnection != null &&
                !String.IsNullOrEmpty(TableName) &&
                !(String.IsNullOrEmpty(ExcelFileName)))
            {
                var existingFile = new FileInfo(ExcelFileName);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    var sheet = package.Workbook.Worksheets[1];

                    var sqlInsert = "REPLACE INTO " + TableName;

                    var insertFields = String.Empty;
                    foreach (var item in ColumnMappingList)
                    {
                        if (insertFields.Length == 0)
                        {
                            insertFields = item.DbColInfo.COLUMN_NAME;
                        }
                        else
                        {
                            insertFields += ", " + item.DbColInfo.COLUMN_NAME;
                        }
                    }

                    sqlInsert += "(" + insertFields + ") VALUES";

                    for (int row = sheet.Dimension.Start.Row + 1; row <= sheet.Dimension.End.Row; row++)
                    {
                        var insertValues = String.Empty;
                        foreach (var item in ColumnMappingList)
                        {
                            var insertValue = Convert.ToString(sheet.Cells[row, item.ColIndex].Value);
                            if (insertValue.ToUpper() != "NULL" && item.NeedSingleQuotes)
                            {
                                insertValue = "'" + insertValue + "'";
                            }

                            if (insertValues.Length == 0)
                            {
                                insertValues = insertValue;
                            }
                            else
                            {
                                insertValues += ", " + insertValue;
                            }
                        }

                        sqlInsert += "(" + insertValues + ")";
                        sqlInsert += row < sheet.Dimension.End.Row ? ", " : ";";
                    }

                    int affected = DbConnection.Execute(sqlInsert);

                    MetroMsgBoxUtil.Success(this, "导入完成(" + affected + "行受影响)", "成功");
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.metroProgressSpinner1.Visible = false;
        }
    }
}
