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
    public partial class UCValidation : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string TableName { get; set; }
        public string ExcelFileName { get; set; }
        public List<ColumnMapping> ColumnMappingList { get; set; }

        private DataTable dtFailCells = null;

        public UCValidation(IDbConnection DbConnection, string tableName, string fileName, List<ColumnMapping> lstColumnMapping)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.TableName = tableName;
            this.ExcelFileName = fileName;
            this.ColumnMappingList = lstColumnMapping;
            InitializeComponent();
        }

        private void UCValidation_Load(object sender, EventArgs e)
        {
            dtFailCells = new DataTable();
            dtFailCells.Columns.Add("Row");
            dtFailCells.Columns.Add("Col");
            dtFailCells.Columns.Add("Explanation");
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCImport(DbConnection, TableName, ExcelFileName, ColumnMappingList));
            this.Parent.Controls.Remove(this);
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCMapping(DbConnection, TableName, ExcelFileName));
            this.Parent.Controls.Remove(this);
        }

        private void mtValidate_Click(object sender, EventArgs e)
        {
            this.metroProgressSpinner1.Visible = true;
            this.metroProgressSpinner1.CustomBackground = true;
            this.backgroundWorker1.RunWorkerAsync();
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

                    var errorLog = String.Empty;

                    dtFailCells = new DataTable();
                    dtFailCells.Columns.Add("Row");
                    dtFailCells.Columns.Add("Col");
                    dtFailCells.Columns.Add("Explanation");

                    foreach (var item in ColumnMappingList)
                    {
                        // 根据字段信息，逐行校验
                        for (int row = sheet.Dimension.Start.Row + 1; row <= sheet.Dimension.End.Row; row++)
                        {
                            var error = String.Empty;
                            if (!Validate(item.DbColInfo, Convert.ToString(sheet.Cells[row, item.ColIndex].Value), out error))
                            {
                                DataRow newRow = dtFailCells.NewRow();
                                newRow["Row"] = row;
                                newRow["Col"] = item.ExcelColName;
                                newRow["Explanation"] = error;
                                dtFailCells.Rows.Add(newRow);
                            }
                        }
                    }
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.metroProgressSpinner1.Visible = false;

            this.dgvValidation.DataSource = dtFailCells;

            if (dtFailCells.Rows.Count > 0)
            {
                MetroMsgBoxUtil.Warning(this, String.Format("有 {0} 个单元格的内容未通过校验。", dtFailCells.Rows.Count), "Warning");
            }
            else
            {
                MetroMsgBoxUtil.Success(this, "数据校验通过", "Success");
            }
        }

        private bool Validate(InformationSchemaColumns field, string columnValue, out string error)
        {
            bool ret = true;
            error = String.Empty;

            // 非空验证
            if (String.IsNullOrEmpty(columnValue) || columnValue.ToUpper() == "NULL")
            {
                if (field.IS_NULLABLE == "NO")
                {
                    error = "非空验证未通过";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "tinyint")
            {
                int val;
                if (!Int32.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
                else if (val < SByte.MinValue || val > SByte.MaxValue)
                {
                    error = "数值超出范围 [-128 ~ 127]";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "smallint")
            {
                int val;
                if (!Int32.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
                else if (val < Int16.MinValue || val > Int16.MaxValue)
                {
                    error = "数值超出范围 [-32,768 ~ 32,767]";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "mediumint")
            {
                int val;
                if (!Int32.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
                else if (val < -8388608 || val > 8388607)
                {
                    error = "数值超出范围 [-8,388,608 ~ 8,388,607]";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "int")
            {
                int val;
                if (!Int32.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
                else if (val < Int32.MinValue || val > Int32.MaxValue)
                {
                    error = "数值超出范围 [-2,147,483,648 ~ 2,147,483,647]";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "bigint")
            {
                long val;
                if (!Int64.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
                else if (val < Int64.MinValue || val > Int64.MaxValue)
                {
                    error = "数值超出范围 [-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807]";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "float")
            {
                float val;
                if (!Single.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "double")
            {
                double val;
                if (!Double.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "decimal")
            {
                decimal val;
                if (!Decimal.TryParse(columnValue, out val))
                {
                    error = "非合法数字";
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "char" ||
                field.DATA_TYPE == "nchar" ||
                field.DATA_TYPE == "varchar" ||
                field.DATA_TYPE == "nvarchar" ||
                field.DATA_TYPE == "text" ||
                field.DATA_TYPE == "mediumtext" ||
                field.DATA_TYPE == "longtext")
            {
                uint maxLen = UInt32.Parse(field.CHARACTER_MAXIMUM_LENGTH);
                if (columnValue.Length > maxLen)
                {
                    error = String.Format("字符数超出最大限制 [{0}]", maxLen);
                    ret = false;
                }
            }
            else if (field.DATA_TYPE == "date" ||
                field.DATA_TYPE == "time" ||
                field.DATA_TYPE == "datetime" ||
                field.DATA_TYPE == "timestamp")
            {
                if (columnValue.ToUpper() != "NOW()")
                {
                    DateTime val;
                    if (!DateTime.TryParse(columnValue, out val))
                    {
                        error = "非合法日期/时间";
                        ret = false;
                    }
                }
            }

            return ret;
        }
    }
}
