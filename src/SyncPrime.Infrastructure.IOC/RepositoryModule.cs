using Ninject.Modules;
using SyncPrime.Domain;

namespace SymcPrime.Infrastructure.IOC
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<Repository>();
        }
    }
}
