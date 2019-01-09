using MacroRiver.Common.Class;
using MySql.Data.MySqlClient;
using System;
using System.Data.SQLite;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using MacroRiver.Model;

namespace MacroRiver
{
    public partial class FormConnectionEdit : Form
    {
        private static readonly SQLiteConnection sqliteConn = DapperUtil.GetAppSQLiteConnection();

        public string ConnectionId { get; set; }

        public FormConnectionEdit()
        {
            InitializeComponent();
        }

        private void FormConnectionEdit_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.ConnectionId))
            {
                this.Text = "新连接";
            }
            else
            {
                this.Text = "编辑连接";

                var dbConnection = sqliteConn.Get<DatabaseConnection>(this.ConnectionId);
                if (dbConnection != null)
                {
                    this.txtConnectionName.Text = dbConnection.Name;
                    this.txtHostname.Text = dbConnection.Hostname;
                    this.txtPort.Text = Convert.ToString(dbConnection.Port);
                    this.txtUsername.Text = dbConnection.Username;
                    this.txtPassword.Text = dbConnection.Password;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (InputValidate())
            {
                int? port = null;
                if (!String.IsNullOrEmpty(this.txtPort.Text))
                {
                    port = Int32.Parse(this.txtPort.Text);
                }

                string password = null;
                if (!String.IsNullOrEmpty(this.txtPassword.Text))
                {
                    password = this.txtPassword.Text;
                }

                if (String.IsNullOrEmpty(this.ConnectionId))
                {
                    sqliteConn.Insert(new DatabaseConnection
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = this.txtConnectionName.Text.Trim(),
                        Hostname = this.txtHostname.Text.Trim(),
                        Port = port,
                        Username = this.txtUsername.Text.Trim(),
                        Password = this.txtPassword.Text
                    });
                }
                else
                {
                    sqliteConn.Update<DatabaseConnection>(new DatabaseConnection
                    {
                        Id = this.ConnectionId,
                        Name = this.txtConnectionName.Text.Trim(),
                        Hostname = this.txtHostname.Text.Trim(),
                        Port = port,
                        Username = this.txtUsername.Text.Trim(),
                        Password = this.txtPassword.Text
                    });
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var connStr = String.Format("server={0};uid={1};pwd={2};", this.txtHostname.Text.Trim(), this.txtUsername.Text.Trim(), this.txtPassword.Text);
            if (!String.IsNullOrEmpty(this.txtPort.Text.Trim()))
            {
                connStr += String.Format("port={0};", this.txtPort.Text.Trim());
            }
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                }
                MsgBoxUtil.Success("连接成功");
            }
            catch (Exception ex)
            {
                MsgBoxUtil.Fail(ex.Message);
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
            if (!String.IsNullOrEmpty(this.txtPort.Text))
            {
                int i;
                if (!Int32.TryParse(this.txtPort.Text, out i))
                {
                    MsgBoxUtil.Fail("端口不合法");
                    return false;
                }
            }

            return true;
        }
    }
}
