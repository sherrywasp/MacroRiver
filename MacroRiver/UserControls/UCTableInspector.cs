using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MacroRiver.Model;
using Dapper;

namespace MacroRiver.UserControls
{
    public partial class UCTableInspector : MetroUserControl
    {
        public IDbConnection DbConnection { get; set; }
        public string tableName { get; set; }

        public UCTableInspector(IDbConnection DbConnection, string tableName)
        {
            this.DbConnection = DbConnection;
            this.Dock = DockStyle.Fill;
            this.tableName = tableName;
            InitializeComponent();
        }

        private void UCTableInspector_Load(object sender, EventArgs e)
        {
            if (this.DbConnection != null)
            {
                this.dgvTableInspector.AutoGenerateColumns = false;
                this.dgvTableInspector.DataSource = DbConnection.Query<FullColumns>(String.Format("show full columns from {0};", tableName)).ToList();
                for (int i = 0; i < this.dgvTableInspector.Rows.Count; i++)
                {
                    this.dgvTableInspector.Rows[i].Height = 30;
                }
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCExcel(this.DbConnection, this.tableName));
            this.Parent.Controls.Remove(this);
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCTable(this.DbConnection));
            this.Parent.Controls.Remove(this);
        }
    }
}
