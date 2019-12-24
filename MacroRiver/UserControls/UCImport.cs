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
        public Dictionary<string, string> ColMapping { get; set; }

        public UCImport(IDbConnection DbConnection, string tableName, string fileName, Dictionary<string, string> colMapping)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.TableName = tableName;
            this.ExcelFileName = fileName;
            this.ColMapping = colMapping;
            InitializeComponent();
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            if (this.DbConnection != null &&
                !String.IsNullOrEmpty(TableName) &&
                !(String.IsNullOrEmpty(ExcelFileName)))
            {
                var existingFile = new FileInfo(ExcelFileName);
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    var sheet = package.Workbook.Worksheets[1];

                    string insertFields = String.Empty;
                    string insertValues = String.Empty;

                    foreach (var item in ColMapping)
                    {
                        if (String.IsNullOrEmpty(insertFields))
                        {
                            insertFields = item.Value;
                            insertValues = "@" + item.Value;
                        }
                        else
                        {
                            insertFields += ", " + item.Value;
                            insertValues += ", @" + item.Value;
                        }
                    }

                    var sqlInsert = String.Format("INSERT INTO {0}({1}) VALUES({2})", TableName, insertFields, insertValues);

                    for (int row = sheet.Dimension.Start.Row + 1; row <= sheet.Dimension.End.Row; row++)
                    {
                        for (int col = sheet.Dimension.Start.Column; col <= sheet.Dimension.End.Column; col++)
                        {

                        }
                    }
                }
            }
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCValidation(DbConnection, TableName, ExcelFileName, ColMapping));
            this.Parent.Controls.Remove(this);
        }
    }
}
