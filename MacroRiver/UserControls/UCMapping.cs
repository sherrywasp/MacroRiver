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
    public partial class UCMapping : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string tableName { get; set; }
        public string excelFileName { get; set; }

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

        }

        private void mtNext_Click(object sender, EventArgs e)
        {

        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCExcel(this.DbConnection, this.tableName, this.excelFileName));
            this.Parent.Controls.Remove(this);
        }
    }
}
