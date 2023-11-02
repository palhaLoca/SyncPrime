using SyncPrime.Infrastructure.Data.DBFactory;

namespace SyncPrime.Infrastructure.CrossCutting.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbSession _session;

        public UnitOfWork(DbSession session)
        {
            _session = session;
        }

        public void BeginTransaction()
        {
            if(_session.Connection.State == System.Data.ConnectionState.Closed)
                _session.Connection.Open();

            _session.Transaction = _session.Connection.BeginTransaction();
        }

        public void Commit()
        {
            _session.Transaction.Commit();
            Dispose();
        }

        public void Dispose()
        {
            _session?.Dispose();
        }

        public void Rollback()
        {
            _session.Transaction.Rollback();
            Dispose();
        }
    }
}