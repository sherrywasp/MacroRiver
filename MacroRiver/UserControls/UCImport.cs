using Dapper;
using MacroRiver.Common.Utils;
using MacroRiver.Model;
using MetroFramework.Controls;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MacroRiver.UserControls
{
    public partial class UCImport : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string TableName { get; set; }
        public string ExcelFileName { get; set; }
        public List<ColumnMapping> ColumnMappingList { get; set; }

        private string operationFlag;

        private string sqlGenerated;

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
            MetroMsgBoxUtil.Warning(this, "该功能暂停使用", "Sorry");

            //operationFlag = "excute";
            //this.metroProgressSpinner1.Visible = true;
            //backgroundWorker1.RunWorkerAsync();
        }

        private void mtSave_Click(object sender, EventArgs e)
        {
            operationFlag = "save";
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

                    var commandStart = this.mchkUseReplaceInto.Checked ? "REPLACE" : "INSERT";

                    var sqlInsertSingle = commandStart + " INTO " + TableName;

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

                    sqlInsertSingle += "(" + insertFields + ") VALUES";

                    var sqlInsert = "";
                    for (int row = sheet.Dimension.Start.Row + 1; row <= sheet.Dimension.End.Row; row++)
                    {
                        sqlInsert += commandStart + " INTO " + TableName + "(" + insertFields + ") VALUES";

                        var insertValues = String.Empty;
                        foreach (var item in ColumnMappingList)
                        {
                            var insertValue = Convert.ToString(sheet.Cells[row, item.ColIndex].Value);
                            if (this.mchkRemoveWrap.Checked)
                            {
                                insertValue = insertValue.Replace("\n", String.Empty);
                            }
                            if (insertValue.ToUpper() != "NULL" && item.NeedSingleQuotes)
                            {
                                if (!insertValue.EndsWith("()") || !this.mchkUseRawForFunc.Checked)
                                {
                                    insertValue = "'" + insertValue + "'";
                                }
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

                        sqlInsert += "(" + insertValues + ");\r\n";

                        sqlInsertSingle += "(" + insertValues + ")";
                        sqlInsertSingle += row < sheet.Dimension.End.Row ? ", " : ";";
                    }

                    this.sqlGenerated = this.mchkSingleInsert.Checked ? sqlInsertSingle : sqlInsert;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.metroProgressSpinner1.Visible = false;

            switch (operationFlag)
            {
                case "excute":
                    int affected = ExcuteSql();
                    MetroMsgBoxUtil.Success(this, "导入完成(" + affected + "行受影响)", "成功");
                    break;
                case "save":
                    SaveSql();
                    break;
                default:
                    break;
            }
        }

        private int ExcuteSql()
        {
            int ret = 0;

            if (!String.IsNullOrEmpty(this.sqlGenerated))
            {
                ret = DbConnection.Execute(this.sqlGenerated);
            }

            return ret;
        }

        private void SaveSql()
        {
            if (!String.IsNullOrEmpty(this.sqlGenerated))
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(this.saveFileDialog1.FileName))
                        {
                            sw.Write(this.sqlGenerated);
                            MetroMsgBoxUtil.Success(this, "已保存", "成功");
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMsgBoxUtil.Fail(this, ex.Message, "失败");
                    }

                }
            }
        }
    }
}
