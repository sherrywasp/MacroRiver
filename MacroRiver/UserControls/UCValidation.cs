using System;
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

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCMapping(DbConnection, TableName, ExcelFileName));
            this.Parent.Controls.Remove(this);
        }
    }
}
