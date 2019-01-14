using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using Dapper;

namespace MacroRiver.UserControls
{
    public partial class UCTable : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }

        public UCTable(IDbConnection DbConnection)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void UCTable_Load(object sender, EventArgs e)
        {
            if (this.DbConnection != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Tables");
                var databases = DbConnection.Query<string>("show tables;");
                foreach (var item in databases)
                {
                    DataRow row = dt.NewRow();
                    row[0] = item;
                    dt.Rows.Add(row);
                }
                this.mGridTable.DataSource = dt;

                for (int i = 0; i < this.mGridTable.Rows.Count; i++)
                {
                    this.mGridTable.Rows[i].Height = 30;
                }
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCDatabase(this.DbConnection));
            this.Parent.Controls.Remove(this);
        }
    }
}
