using Ninject.Modules;
using SyncPrime.Application.AutoMapper;
using SyncPrime.Infrastructure.CrossCutting.UnitOfWork;
using SyncPrime.Infrastructure.Data.DBFactory;

namespace SymcPrime.Infrastructure.IOC
{
    internal class InfraModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>().InTransientScope();
            Bind<DbSession>().ToSelf().InSingletonScope();
            Bind<MapperBootStrap>().ToSelf().InSingletonScope();
        }
    }
}
