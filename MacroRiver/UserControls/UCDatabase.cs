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
                this.metroGrid1.DataSource = DbConnection.Query<string>("show databases;").ToList();
            }
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCTable());
            this.Parent.Controls.Remove(this);
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Add(new UCConnection());
            this.Parent.Controls.Remove(this);
        }
    }
}
