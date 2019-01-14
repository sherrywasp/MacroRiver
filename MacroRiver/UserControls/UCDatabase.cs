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
    public partial class UCDatabase : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }

        public UCDatabase(IDbConnection DbConnection)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            InitializeComponent();
        }

        private void UCDatabase_Load(object sender, EventArgs e)
        {
            if (this.DbConnection != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Database");
                var databases = DbConnection.Query<string>("show databases;");
                foreach (var item in databases)
                {
                    DataRow row = dt.NewRow();
                    row[0] = item;
                    dt.Rows.Add(row);
                }
                this.mGridDB.DataSource = dt;

                for (int i = 0; i < this.mGridDB.Rows.Count; i++)
                {
                    this.mGridDB.Rows[i].Height = 30;
                }
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void mGridDB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Next();
        }

        private void Next()
        {
            if (this.mGridDB.SelectedRows.Count > 0)
            {
                var dbName = this.mGridDB.SelectedRows[0].Cells[0].Value.ToString();
                this.DbConnection.Open();
                this.DbConnection.ChangeDatabase(dbName);
                this.DbConnection.Close();
                this.Parent.Controls.Add(new UCTable(this.DbConnection));
                this.Parent.Controls.Remove(this);
            }
        }

        private void Back()
        {
            this.Parent.Controls.Add(new UCConnection());
            this.Parent.Controls.Remove(this);
        }
    }
}
