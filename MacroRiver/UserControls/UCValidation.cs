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

                    var failCells = new List<string>();
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
                                for (int row = sheet.Dimension.Start.Row + 1; row < sheet.Dimension.End.Row; row++)
                                {
                                    var error = String.Empty;
                                    if (!Validate(field, Convert.ToString(sheet.Cells[row, col].Value), out error))
                                    {
                                        failCells.Add(row.ToString() + col.ToString());
                                        errorLog += error + Environment.NewLine;
                                    }
                                }
                            }
                        }
                    }

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
            error = String.Empty;

            if (field.DATA_TYPE == "tinyint")
            {

            }
            else if(field.DATA_TYPE == "smallint")
            {

            }
            else if (field.DATA_TYPE == "int")
            {

            }
            else if (field.DATA_TYPE == "mediumint")
            {

            }
            else if (field.DATA_TYPE == "bigint")
            {

            }
            else if (field.DATA_TYPE == "float")
            {

            }
            else if (field.DATA_TYPE == "double")
            {

            }
            else if (field.DATA_TYPE == "decimal")
            {

            }
            else if (field.DATA_TYPE == "char")
            {

            }
            else if (field.DATA_TYPE == "nchar")
            {

            }
            else if (field.DATA_TYPE == "varchar")
            {

            }
            else if (field.DATA_TYPE == "nvarchar")
            {

            }            
            else if (field.DATA_TYPE == "text")
            {

            }
            else if (field.DATA_TYPE == "mediumtext")
            {

            }
            else if (field.DATA_TYPE == "longtext")
            {

            }
            else if (field.DATA_TYPE == "time")
            {

            }
            else if (field.DATA_TYPE == "datetime")
            {

            }
            else
            {

            }

            return true;
        }

    }
}
