using Autodesk.AutoCAD.Runtime;
using Ninject;
using SymcPrime.Infrastructure.IOC;
using SyncPrime.Infrastructure.CrossCutting.FluentMap;

namespace SyncPrime
{
    public class Startup
    {
        public static StandardKernel stdKernel { get; private set; }     

        public Startup()
        {
            stdKernel = ManagerModules.CreateKernel();
            FluentMapperConfig.Inicialize();           
        }

        [CommandMethod("SyncPrimeRun")]
        public void SyncPrimeRun()
        {
            new Home().ShowDialog();
        }

    }
}
