using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryToExcel
{
    public class ConnectionSetting
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string UserPW { get; set; }
        public string Database { get; set; }
        public string SQL { get; set; }
        public string ConnectionString { get; set; }

        public void MakeConnection(string ser, string port, string name, string pw, string db, string SQL)
        {
            switch (SQL)
            {
                case "MYSQL":
                    ConnectionString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};SslMode=None;Connect Timeout=100", ser, port, db, name, pw);
                    break;
                case "MSSQL":
                    ConnectionString = string.Format("Server={0},{1};Database={2};User Id={3};Password={4};", ser, port, db, name, pw);
                    break;
            }
        }
        public void MakeConnection()
        {
            Server = Settings.Default.Server;
            Port = Settings.Default.Port;
            Database = Settings.Default.Database;
            UserName = Settings.Default.Uid;
            SQL = Settings.Default.SQL;
            UserPW = Settings.Default.Password;

            switch (SQL)
            {
                case "MYSQL":
                    ConnectionString = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};SslMode=None;", Server, Port, Database, UserName, UserPW);
                    break;
                case "MSSQL":
                    ConnectionString = string.Format("Server={0},{1};Database={2};User Id={3};Password={4};", Server, Port, Database, UserName, UserPW);
                    break;
            }
        }
    }
}
