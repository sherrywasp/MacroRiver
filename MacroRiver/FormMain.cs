using Dapper;
using MacroRiver.Model;
using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace MacroRiver
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var conn = new SQLiteConnection(String.Format(@"Data Source={0}\App.db;Version=3;", Application.StartupPath));
            var dbConnections = conn.Query<DatabaseConnection>("select * from db_connection").ToList();
            TreeNode node = new TreeNode(dbConnections[0].Name);
            this.treeView1.Nodes.Add(node);
        }

        private void tsmiNewConnection_Click(object sender, EventArgs e)
        {
            var frm = new FormNewConnection();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
