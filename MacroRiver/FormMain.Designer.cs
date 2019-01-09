namespace MacroRiver
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeConnection = new System.Windows.Forms.TreeView();
            this.cmsConnTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsConnTreeNewConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConnTreeRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConnTreeNode1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsConnTreeNode1ConnectionEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConnTreeNode1ConnectionDel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConnTreeNode1ConnectionOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsConnTreeNode2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsConnTreeNode2DBOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsConnTree.SuspendLayout();
            this.cmsConnTreeNode1.SuspendLayout();
            this.cmsConnTreeNode2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewConnection,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiNewConnection
            // 
            this.tsmiNewConnection.Name = "tsmiNewConnection";
            this.tsmiNewConnection.Size = new System.Drawing.Size(142, 22);
            this.tsmiNewConnection.Text = "新建连接(&N)";
            this.tsmiNewConnection.Click += new System.EventHandler(this.tsmiNewConnection_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(142, 22);
            this.tsmiExit.Text = "退出(&x)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmiAbout.Text = "关于(&A)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel1.Text = "v0.1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeConnection);
            this.splitContainer1.Panel1MinSize = 100;
            this.splitContainer1.Panel2MinSize = 200;
            this.splitContainer1.Size = new System.Drawing.Size(784, 414);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeConnection
            // 
            this.treeConnection.ContextMenuStrip = this.cmsConnTree;
            this.treeConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeConnection.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeConnection.Location = new System.Drawing.Point(0, 0);
            this.treeConnection.Name = "treeConnection";
            this.treeConnection.Size = new System.Drawing.Size(200, 414);
            this.treeConnection.TabIndex = 0;
            this.treeConnection.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeConnection_NodeMouseClick);
            // 
            // cmsConnTree
            // 
            this.cmsConnTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsConnTreeNewConnection,
            this.cmsConnTreeRefresh});
            this.cmsConnTree.Name = "cmsConnTree";
            this.cmsConnTree.Size = new System.Drawing.Size(125, 48);
            // 
            // cmsConnTreeNewConnection
            // 
            this.cmsConnTreeNewConnection.Name = "cmsConnTreeNewConnection";
            this.cmsConnTreeNewConnection.Size = new System.Drawing.Size(124, 22);
            this.cmsConnTreeNewConnection.Text = "新建连接";
            this.cmsConnTreeNewConnection.Click += new System.EventHandler(this.cmsConnTreeNewConnection_Click);
            // 
            // cmsConnTreeRefresh
            // 
            this.cmsConnTreeRefresh.Name = "cmsConnTreeRefresh";
            this.cmsConnTreeRefresh.Size = new System.Drawing.Size(124, 22);
            this.cmsConnTreeRefresh.Text = "刷新";
            this.cmsConnTreeRefresh.Click += new System.EventHandler(this.cmsConnTreeRefresh_Click);
            // 
            // cmsConnTreeNode1
            // 
            this.cmsConnTreeNode1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsConnTreeNode1ConnectionOpen,
            this.cmsConnTreeNode1ConnectionEdit,
            this.cmsConnTreeNode1ConnectionDel});
            this.cmsConnTreeNode1.Name = "cmsConnTreeNode";
            this.cmsConnTreeNode1.Size = new System.Drawing.Size(125, 70);
            // 
            // cmsConnTreeNode1ConnectionEdit
            // 
            this.cmsConnTreeNode1ConnectionEdit.Name = "cmsConnTreeNode1ConnectionEdit";
            this.cmsConnTreeNode1ConnectionEdit.Size = new System.Drawing.Size(124, 22);
            this.cmsConnTreeNode1ConnectionEdit.Text = "编辑连接";
            this.cmsConnTreeNode1ConnectionEdit.Click += new System.EventHandler(this.cmsConnTreeNode1ConnectionEdit_Click);
            // 
            // cmsConnTreeNode1ConnectionDel
            // 
            this.cmsConnTreeNode1ConnectionDel.Name = "cmsConnTreeNode1ConnectionDel";
            this.cmsConnTreeNode1ConnectionDel.Size = new System.Drawing.Size(124, 22);
            this.cmsConnTreeNode1ConnectionDel.Text = "删除连接";
            this.cmsConnTreeNode1ConnectionDel.Click += new System.EventHandler(this.cmsConnTreeNode1ConnectionDel_Click);
            // 
            // cmsConnTreeNode1ConnectionOpen
            // 
            this.cmsConnTreeNode1ConnectionOpen.Name = "cmsConnTreeNode1ConnectionOpen";
            this.cmsConnTreeNode1ConnectionOpen.Size = new System.Drawing.Size(124, 22);
            this.cmsConnTreeNode1ConnectionOpen.Text = "打开连接";
            this.cmsConnTreeNode1ConnectionOpen.Click += new System.EventHandler(this.cmsConnTreeNode1ConnectionOpen_Click);
            // 
            // cmsConnTreeNode2
            // 
            this.cmsConnTreeNode2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsConnTreeNode2DBOpen});
            this.cmsConnTreeNode2.Name = "cmsConnTreeNode2";
            this.cmsConnTreeNode2.Size = new System.Drawing.Size(153, 48);
            // 
            // cmsConnTreeNode2DBOpen
            // 
            this.cmsConnTreeNode2DBOpen.Name = "cmsConnTreeNode2DBOpen";
            this.cmsConnTreeNode2DBOpen.Size = new System.Drawing.Size(152, 22);
            this.cmsConnTreeNode2DBOpen.Text = "打开数据库";
            this.cmsConnTreeNode2DBOpen.Click += new System.EventHandler(this.cmsConnTreeNode2DBOpen_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MacroRiver";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsConnTree.ResumeLayout(false);
            this.cmsConnTreeNode1.ResumeLayout(false);
            this.cmsConnTreeNode2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeConnection;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewConnection;
        private System.Windows.Forms.ContextMenuStrip cmsConnTreeNode1;
        private System.Windows.Forms.ToolStripMenuItem cmsConnTreeNode1ConnectionEdit;
        private System.Windows.Forms.ToolStripMenuItem cmsConnTreeNode1ConnectionDel;
        private System.Windows.Forms.ContextMenuStrip cmsConnTree;
        private System.Windows.Forms.ToolStripMenuItem cmsConnTreeNewConnection;
        private System.Windows.Forms.ToolStripMenuItem cmsConnTreeRefresh;
        private System.Windows.Forms.ToolStripMenuItem cmsConnTreeNode1ConnectionOpen;
        private System.Windows.Forms.ContextMenuStrip cmsConnTreeNode2;
        private System.Windows.Forms.ToolStripMenuItem cmsConnTreeNode2DBOpen;
    }
}