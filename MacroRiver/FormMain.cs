using Dapper;
using Dapper.Contrib.Extensions;
using MacroRiver.Common.Class;
using MacroRiver.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MacroRiver
{
    public partial class FormMain : Form
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
            ConnectionTreeRefresh();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MsgBoxUtil.Confirm("确定退出？") != DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }

        private void treeConnection_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.treeConnection.SelectedNode = e.Node;  // 保证当在节点上点击右键时可选中节点
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
            if (this.treeConnection.SelectedNode != null)
            {
                var dbConn = sqliteConn.Get<DatabaseConnection>(this.treeConnection.SelectedNode.Name);
                if (dbConn != null)
                {
                    var mysqlConnStr = String.Format("server={0};uid={1};pwd={2};", dbConn.Hostname, dbConn.Username, dbConn.Password);
                    if (dbConn.Port.HasValue)
                    {
                        mysqlConnStr += String.Format("port={0};", dbConn.Port.Value);
                    }
                    currMySqlConnection = new MySqlConnection(mysqlConnStr);
                    this.treeConnection.SelectedNode.Nodes.Clear();
                    var databases = currMySqlConnection.Query<string>("show databases;");
                    foreach (var item in databases)
                    {
                        TreeNode node = new TreeNode(item);
                        node.ContextMenuStrip = cmsConnTreeNode2;
                        this.treeConnection.SelectedNode.Nodes.Add(node);
                    }
                    this.treeConnection.SelectedNode.ExpandAll();
                }
            }
            else
            {
                MsgBoxUtil.Warning("请先选中一个连接");
            }
        }

        // 编辑连接
        private void cmsConnTreeNode1ConnectionEdit_Click(object sender, EventArgs e)
        {
            if (this.treeConnection.SelectedNode != null)
            {
                var frm = new FormConnectionEdit();
                frm.ConnectionId = this.treeConnection.SelectedNode.Name;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    ConnectionTreeRefresh();
                }
            }
            else
            {
                MsgBoxUtil.Warning("请先选中一个连接");
            }
        }

        // 删除连接
        private void cmsConnTreeNode1ConnectionDel_Click(object sender, EventArgs e)
        {
            if (this.treeConnection.SelectedNode != null)
            {
                var name = this.treeConnection.SelectedNode.Text;
                var prompt = String.Format("确实要删除此连接吗？\n{0}", name);
                if (MsgBoxUtil.Confirm(prompt) == DialogResult.Yes)
                {
                    sqliteConn.Delete(new DatabaseConnection { Id = this.treeConnection.SelectedNode.Name });
                    ConnectionTreeRefresh();
                }
            }
            else
            {
                MsgBoxUtil.Warning("请先选中一个连接");
            }
        }

        #endregion

        #region treeConnection树形控件二级节点右键菜单(cmsConnTreeNode2)

        // 打开数据库
        private void cmsConnTreeNode2DBOpen_Click(object sender, EventArgs e)
        {
            if (this.treeConnection.SelectedNode != null)
            {
                this.treeConnection.SelectedNode.Nodes.Clear();
                var sql = String.Format("use `{0}`; show tables; ", this.treeConnection.SelectedNode.Text);
                var tables = currMySqlConnection.Query<string>(sql);
                foreach (var item in tables)
                {
                    TreeNode node = new TreeNode(item);
                    //node.ContextMenuStrip = cmsConnTreeNode2;
                    this.treeConnection.SelectedNode.Nodes.Add(node);
                }
                this.treeConnection.SelectedNode.ExpandAll();
            }
            else
            {
                MsgBoxUtil.Warning("请先选中一个数据库");
            }
        }

        #endregion

        #region treeConnection树形控件右键菜单(cmsConnTree)

        // 新建连接
        private void cmsConnTreeNewConnection_Click(object sender, EventArgs e)
        {
            var frm = new FormConnectionEdit();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ConnectionTreeRefresh();
            }
        }

        // 刷新连接信息树形控件
        private void cmsConnTreeRefresh_Click(object sender, EventArgs e)
        {
            ConnectionTreeRefresh();
        }

        #endregion

        #endregion

        // 更新连接信息树形控件节点
        private void ConnectionTreeRefresh()
        {
            this.treeConnection.Nodes.Clear();

            var dbConnections = sqliteConn.GetAll<DatabaseConnection>();
            foreach (var item in dbConnections)
            {
                TreeNode node = new TreeNode();
                node.Name = item.Id;
                node.Text = item.Name;
                node.ContextMenuStrip = this.cmsConnTreeNode1;
                this.treeConnection.Nodes.Add(node);
            }
        }
    }
}
