using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MySql.Data.MySqlClient;
using MetroFramework;
using MacroRiver.Common.Utils;
using System.Data.SQLite;
using MacroRiver.Model;
using Dapper.Contrib.Extensions;

namespace MacroRiver.UserControls
{
    public partial class UCConnection : MetroUserControl
    {
        private static readonly SQLiteConnection sqliteConn = DapperUtil.GetAppSQLiteConnection();
        private static string connectionId;

        public UCConnection()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void UCConnection_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLastConnection();
            }
            catch
            {
                // TODO: log
            }
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void mtNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void UCConnection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Next();
            }
        }

        private IDbConnection GetConnection()
        {
            var connStr = String.Format("server={0};uid={1};pwd={2};", this.mtxtHostname.Text.Trim(), this.mtxtUsername.Text.Trim(), this.mtxtPassword.Text);
            if (!String.IsNullOrEmpty(this.mtxtPort.Text.Trim()))
            {
                connStr += String.Format("port={0};", this.mtxtPort.Text.Trim());
            }
            try
            {
                using (var conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    return conn;
                }
            }
            catch (Exception ex)
            {
                MetroMsgBoxUtil.Fail(this, ex.Message, "连接失败");
                return null;
            }
        }

        private void LoadLastConnection()
        {
            var dbConnection = sqliteConn.GetAll<DatabaseConnection>().FirstOrDefault();
            if (dbConnection != null)
            {
                connectionId = dbConnection.Id;
                this.mtxtHostname.Text = dbConnection.Hostname;
                this.mtxtPort.Text = Convert.ToString(dbConnection.Port);
                this.mtxtUsername.Text = dbConnection.Username;
                this.mtxtPassword.Text = dbConnection.Password;
            }
        }

        private void SaveLastConnection()
        {
            int? port = null;
            if (!String.IsNullOrEmpty(this.mtxtPort.Text))
            {
                port = Int32.Parse(this.mtxtPort.Text);
            }

            string password = null;
            if (!String.IsNullOrEmpty(this.mtxtPassword.Text))
            {
                password = this.mtxtPassword.Text;
            }

            if (String.IsNullOrEmpty(connectionId))
            {
                sqliteConn.Insert(new DatabaseConnection
                {
                    Id = Guid.NewGuid().ToString(),
                    Hostname = this.mtxtHostname.Text.Trim(),
                    Port = port,
                    Username = this.mtxtUsername.Text.Trim(),
                    Password = this.mtxtPassword.Text
                });
            }
            else
            {
                sqliteConn.Update<DatabaseConnection>(new DatabaseConnection
                {
                    Id = connectionId,
                    Hostname = this.mtxtHostname.Text.Trim(),
                    Port = port,
                    Username = this.mtxtUsername.Text.Trim(),
                    Password = this.mtxtPassword.Text
                });
            }
        }

        private void Next()
        {
            var conn = GetConnection();
            if (conn != null)
            {
                try
                {
                    SaveLastConnection();
                }
                catch
                {
                    // TODO: log
                }

                this.Parent.Controls.Add(new UCDatabase(conn));
                this.Parent.Controls.Remove(this);
            }
        }

        private void Back()
        {
            this.Parent.Controls.Add(new UCHome());
            this.Parent.Controls.Remove(this);
        }

        private void mtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) Next();
        }        
    }
}
