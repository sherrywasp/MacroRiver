using Dapper;
using MetroFramework.Controls;
using System;
using System.Data;
using System.Windows.Forms;

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
                var tables = DbConnection.Query<string>("show tables;");
                foreach (var item in tables)
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
            Next();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCDatabase(this.DbConnection));
            this.Parent.Controls.Remove(this);
        }

        private void Next()
        {
            if (this.mGridTable.SelectedRows.Count > 0)
            {
                var tableName = this.mGridTable.SelectedRows[0].Cells[0].Value.ToString();
                this.Parent.Controls.Add(new UCTableInspector(this.DbConnection, tableName));
                this.Parent.Controls.Remove(this);
            }
        }

        private void mGridTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                Next();
            }
        }
    }
}
