using Ninject.Modules;
using SyncPrime.Application;
using SyncPrime.Application.Services.Interfaces;

namespace SymcPrime.Infrastructure.IOC
{
    public class ServicesAppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IServiceApp>().To<ServiceApp>();
        }
    }
}
