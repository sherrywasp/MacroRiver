using Dapper;
using Dapper.Contrib.Extensions;
using MacroRiver.Common.Class;
using MacroRiver.Common.Constants;
using MacroRiver.Model;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace MacroRiver
{
    public partial class FormMain : MetroForm
    {
        private static readonly SQLiteConnection sqliteConn = DapperUtil.GetAppSQLiteConnection();
        private static MySqlConnection currMySqlConnection;

        public FormMain()
        {
            InitializeComponent();
        }

        #region 窗体&控件事件

        private void FormMain_Load(object sender, EventArgs e)
        {
            var ucHome = new UCHome();
            ucHome.Dock = DockStyle.Fill;
            this.Controls.Add(ucHome);
            //ConnectionTreeRefresh();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MsgBoxUtil.Confirm("确定退出？") != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }

        // 单击节点
        private void treeConnection_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //this.treeConnection.SelectedNode = e.Node;  // 保证当在节点上点击右键时可选中节点
        }

        // 双击节点
        private void treeConnection_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var nodeTag = Convert.ToString(e.Node.Tag);
            switch (nodeTag)  
            {
                case NodeTag.CONNECTION:
                    if (e.Node.GetNodeCount(false) == 0)
                    {
                        ConnectionOpen(e.Node);
                    }
                    break;
                case NodeTag.DATABASE:
                    if (e.Node.GetNodeCount(false) == 0)
                    {
                        DatabaseOpen(e.Node);
                    }
                    break;
                case NodeTag.TABLE:
                    break;
                default:
                    // pass
                    break;
            }
        }

        #endregion

        #region 菜单栏

        #region 文件菜单

        private void tsmiNewConnection_Click(object sender, EventArgs e)
        {
            var frm = new FormConnectionEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ConnectionTreeRefresh();
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #endregion

        #region 右键菜单

        #region treeConnection树形控件一级节点右键菜单(cmsConnTreeNode1)

        // 打开连接
        private void cmsConnTreeNode1ConnectionOpen_Click(object sender, EventArgs e)
        {
            //if (this.treeConnection.SelectedNode != null)
            //{
            //    ConnectionOpen(this.treeConnection.SelectedNode);
            //}
            //else
            //{
            //    MsgBoxUtil.Warning("请先选中一个连接");
            //}
        }

        // 编辑连接
        private void cmsConnTreeNode1ConnectionEdit_Click(object sender, EventArgs e)
        {
            //if (this.treeConnection.SelectedNode != null)
            //{
            //    var frm = new FormConnectionEdit();
            //    frm.ConnectionId = this.treeConnection.SelectedNode.Name;
            //    if (frm.ShowDialog() == DialogResult.OK)
            //    {
            //        ConnectionTreeRefresh();
            //    }
            //}
            //else
            //{
            //    MsgBoxUtil.Warning("请先选中一个连接");
            //}
        }

        // 删除连接
        private void cmsConnTreeNode1ConnectionDel_Click(object sender, EventArgs e)
        {
            //if (this.treeConnection.SelectedNode != null)
            //{
            //    var name = this.treeConnection.SelectedNode.Text;
            //    var prompt = String.Format("确实要删除此连接吗？\n{0}", name);
            //    if (MsgBoxUtil.Confirm(prompt) == DialogResult.Yes)
            //    {
            //        sqliteConn.Delete(new DatabaseConnection { Id = this.treeConnection.SelectedNode.Name });
            //        ConnectionTreeRefresh();
            //    }
            //}
            //else
            //{
            //    MsgBoxUtil.Warning("请先选中一个连接");
            //}
        }

        #endregion

        #region treeConnection树形控件二级节点右键菜单(cmsConnTreeNode2)

        // 打开数据库
        private void cmsConnTreeNode2DBOpen_Click(object sender, EventArgs e)
        {
            //if (this.treeConnection.SelectedNode != null)
            //{
            //    DatabaseOpen(this.treeConnection.SelectedNode);
            //}
            //else
            //{
            //    MsgBoxUtil.Warning("请先选中一个数据库");
            //}
        }

        #endregion

        #endregion

        // 更新连接信息树形控件节点
        private void ConnectionTreeRefresh()
        {
            //this.treeConnection.Nodes.Clear();

            //var dbConnections = sqliteConn.GetAll<DatabaseConnection>();
            //foreach (var item in dbConnections)
            //{
            //    TreeNode node = new TreeNode();
            //    node.Name = item.Id;
            //    node.Text = item.Name;
            //    node.Tag = NodeTag.CONNECTION;
            //    node.ContextMenuStrip = this.cmsConnTreeNode1;
            //    this.treeConnection.Nodes.Add(node);
            //}
        }

        private void ConnectionOpen(TreeNode connectionNode)
        {
            var dbConn = sqliteConn.Get<DatabaseConnection>(connectionNode.Name);
            if (dbConn != null)
            {
                var mysqlConnStr = String.Format("server={0};uid={1};pwd={2};", dbConn.Hostname, dbConn.Username, dbConn.Password);
                if (dbConn.Port.HasValue)
                {
                    mysqlConnStr += String.Format("port={0};", dbConn.Port.Value);
                }
                currMySqlConnection = new MySqlConnection(mysqlConnStr);
                connectionNode.Nodes.Clear();
                var databases = currMySqlConnection.Query<string>("show databases;");
                foreach (var item in databases)
                {
                    TreeNode node = new TreeNode(item);
                    node.Tag = NodeTag.DATABASE;
                    //node.ContextMenuStrip = cmsConnTreeNode2;
                    connectionNode.Nodes.Add(node);
                }
                connectionNode.ExpandAll();
            }
        }

        private void DatabaseOpen(TreeNode databaseNode)
        {
            databaseNode.Nodes.Clear();
            var sql = String.Format("use `{0}`; show tables; ", databaseNode.Text);
            var tables = currMySqlConnection.Query<string>(sql);
            TreeNode nodeTable = new TreeNode(String.Format("表 ({0})", tables.AsList().Count));
            databaseNode.Nodes.Add(nodeTable);
            foreach (var item in tables)
            {
                TreeNode node = new TreeNode(item);
                node.Tag = NodeTag.TABLE;
                //node.ContextMenuStrip = cmsConnTreeNode2;
                nodeTable.Nodes.Add(node);
            }
            databaseNode.ExpandAll();
        }
    }
}
