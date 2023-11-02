using System;

namespace SyncPrime.Infrastructure.CrossCutting.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
