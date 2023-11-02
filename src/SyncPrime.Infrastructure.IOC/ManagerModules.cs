using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymcPrime.Infrastructure.IOC
{
    public class ManagerModules
    {
        public static INinjectModule[] GetModules()
            => new INinjectModule[]
                {
                    new ServicesModule(),
                    new ServicesAppModule(),
                    new RepositoryModule(),
                    new InfraModule(),
                };

        public static StandardKernel CreateKernel() 
            => new StandardKernel(GetModules());
        

    }
}
