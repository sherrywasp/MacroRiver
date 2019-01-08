using Dapper;
using MacroRiver.Common.Class;
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
            for (int i = 0; i < dbConnections.Count; i++)
            {
                TreeNode node = new TreeNode(dbConnections[i].Name);
                node.Name = dbConnections[i].Id;
                node.ContextMenuStrip = this.cmsConnTreeNode;
                this.treeConnection.Nodes.Add(node);
            }
        }

        #region 菜单栏

        #region 文件菜单

        private void tsmiNewConnection_Click(object sender, EventArgs e)
        {
            var frm = new FormConnectionEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        #endregion

        #endregion

        #region 右键菜单

        #region treeConnection树形控件节点右键菜单

        private void tsmiConnectionEdit_Click(object sender, EventArgs e)
        {
            var frm = new FormConnectionEdit();
            frm.ConnectionId = this.treeConnection.SelectedNode.Name;
            if (frm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void tsmiConnectionDel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBoxUtil.Confirm("确定退出？") != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
