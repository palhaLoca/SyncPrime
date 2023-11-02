using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace SyncPrime.Infrastructure.Data.DBFactory
{

    public sealed class DbSession : IDisposable
    {
        private Guid _id;
        public IDbConnection Connection { get; }
        public IDbTransaction Transaction { get; set; }      
        public DbSession()
        {
            _id = Guid.NewGuid();
            Connection = new MySqlConnection(Settings1.Default.strConnection);
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    }
}
