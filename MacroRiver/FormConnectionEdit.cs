using MacroRiver.Common.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MacroRiver
{
    public partial class FormConnectionEdit : Form
    {
        public string ConnectionId { get; set; }

        public FormConnectionEdit()
        {
            InitializeComponent();
        }

        private void FormConnectionEdit_Load(object sender, EventArgs e)
        {
            this.Text = String.IsNullOrEmpty(this.ConnectionId) ? "新连接" : "编辑连接";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InputValidate())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var hostname = this.txtHostname.Text;
            if (!String.IsNullOrEmpty(this.txtPort.Text))
            {
                hostname += ";port=" + this.txtPort.Text + ";";
            }
            var connStr = String.Format("server={0};uid={1};pwd={2};", hostname, this.txtUsername.Text, this.txtPassword.Text);
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    MsgBoxUtil.Success("连接成功");
                }
                catch (Exception ex)
                {
                    MsgBoxUtil.Fail(ex.Message);
                }
            }
        }

        private bool InputValidate()
        {
            if (String.IsNullOrEmpty(this.txtConnectionName.Text.Trim()))
            {
                MsgBoxUtil.Fail("连接名称未填");
                return false;
            }
            if (String.IsNullOrEmpty(this.txtHostname.Text.Trim()))
            {
                MsgBoxUtil.Fail("主机未填");
                return false;
            }
            if (String.IsNullOrEmpty(this.txtUsername.Text.Trim()))
            {
                MsgBoxUtil.Fail("用户名未填");
                return false;
            }

            return true;
        }
    }
}
