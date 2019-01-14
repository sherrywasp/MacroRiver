using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace MacroRiver.Common.Utils
{
    public class DapperUtil
    {
        private static SQLiteConnection appSQLiteConnection;

        public static SQLiteConnection GetAppSQLiteConnection()
        {
            if (appSQLiteConnection == null)
            {
                appSQLiteConnection = new SQLiteConnection(String.Format(@"Data Source={0}\App.db;Version=3;", Application.StartupPath));
            }

            return appSQLiteConnection;
        }
    }
}
