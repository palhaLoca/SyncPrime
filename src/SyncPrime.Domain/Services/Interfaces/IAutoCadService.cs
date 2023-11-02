using Autodesk.AutoCAD.DatabaseServices;
using System.Collections.Generic;

namespace SyncPrime.Domain.CadSevices
{
    public interface IAutoCadService
    {
        List<Line> GetCurrentLines();
    }
}
