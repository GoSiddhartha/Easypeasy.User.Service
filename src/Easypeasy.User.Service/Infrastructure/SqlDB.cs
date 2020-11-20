using MySql.Data.MySqlClient;
using System;

namespace Easypeasy.User.Service.Infrastructure
{
    public class SqlDB: IDisposable
    {
        public MySqlConnection Connection;

        public SqlDB(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
            this.Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
