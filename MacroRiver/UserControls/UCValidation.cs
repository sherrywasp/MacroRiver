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
    public partial class UCValidation : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string TableName { get; set; }
        public string ExcelFileName { get; set; }
        public Dictionary<string, string> ColMapping { get; set; }

        public UCValidation(IDbConnection DbConnection, string tableName, string fileName, Dictionary<string, string> colMapping)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.TableName = tableName;
            this.ExcelFileName = fileName;
            this.ColMapping = colMapping;
            InitializeComponent();
        }

        private void UCValidation_Load(object sender, EventArgs e)
        {

        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCImport(DbConnection, TableName, ExcelFileName, ColMapping));
            this.Parent.Controls.Remove(this);
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCMapping(DbConnection, TableName, ExcelFileName));
            this.Parent.Controls.Remove(this);
        }

        private void mtValidate_Click(object sender, EventArgs e)
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

                var existingFile = new FileInfo(ExcelFileName);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    var sheet = package.Workbook.Worksheets[1];

                    var failCells = new List<FailCell>();
                    var errorLog = String.Empty;

                    foreach (var item in ColMapping)
                    {
                        // 获取字段信息
                        var select_columns = String.Format(
                            "select column_name, is_nullable, data_type, column_type, character_maximum_length, character_octet_length, numeric_precision, numeric_scale, datetime_precision, column_key, extra, column_comment "
                            + "from columns "
                            + "where table_schema = '{0}' and table_name = '{1}' and column_name = '{2}'",
                            currDB, TableName, item.Value
                        );

                        var field = DbConnection.Query<InformationSchemaColumns>(select_columns).First();

                        for (int col = sheet.Dimension.Start.Column; col <= sheet.Dimension.End.Column; col++)
                        {
                            // 寻找对应列的索引
                            if (item.Key == Convert.ToString(sheet.Cells[sheet.Dimension.Start.Row, col].Value))
                            {
                                // 根据字段信息，逐行校验
                                for (int row = sheet.Dimension.Start.Row + 1; row <= sheet.Dimension.End.Row; row++)
                                {
                                    var error = String.Empty;
                                    if (!Validate(field, Convert.ToString(sheet.Cells[row, col].Value), out error))
                                    {
                                        var fc = new FailCell() { Row = row, Col = item.Key, Explanation = error };
                                        failCells.Add(fc);
                                    }
                                }
                            }
                        }
                    }

                    this.dgvValidation.DataSource = failCells;
                    if (failCells.Count > 0)
                    {
                        MetroMsgBoxUtil.Warning(this, String.Format("有 {0} 个单元格的内容未通过校验。", failCells.Count), "Warning");
                    }
                    else
                    {
                        MetroMsgBoxUtil.Success(this, "数据校验通过", "Success");
                    }                    
                }

                this.DbConnection.ChangeDatabase(currDB);
                this.DbConnection.Close();
            }
        }

        private bool Validate(InformationSchemaColumns field, string columnValue, out string error)
        {
            bool ret = true;
            error = String.Empty;

            // 非空验证
            if (String.IsNullOrEmpty(columnValue))
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
                DateTime val;
                if (!DateTime.TryParse(columnValue, out val))
                {
                    error = "非合法日期/时间";
                    ret = false;
                }
            }

            return ret;
        }

    }
}
