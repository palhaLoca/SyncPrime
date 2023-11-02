

using Autodesk.AutoCAD.DatabaseServices;

namespace SyncPrime.Domain.CadSevices
{
    public interface IAutoCadService
    {
        List<Line> GetLines();
    }
}
