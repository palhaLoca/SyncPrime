using Ninject.Modules;
using SyncPrime.Domain;
using SyncPrime.Domain.CadSevices;

namespace SymcPrime.Infrastructure.IOC
{
    public class ServicesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDomainService>().To<DomainService>();
            Bind<IAutoCadService>().To<AutoCadService>();
            
        }
    }
}
