using Autodesk.AutoCAD.DatabaseServices;
using SyncPrime.Application.ViewModel;
using System.Collections.Generic;

namespace SyncPrime.Application.Services.Interfaces
{
    public interface IServiceApp
    {
        void Save(LineViewModel line);
        IEnumerable<LineViewModel> GetLines();
        IEnumerable<LineViewModel> GetCurrentLines();
        IEnumerable<MText> GetCurrentMText();
        IEnumerable<Polyline> GetCurrentLWPolyLine();
        IEnumerable<BlockReference> GetCurrentInsert();


    }
}
