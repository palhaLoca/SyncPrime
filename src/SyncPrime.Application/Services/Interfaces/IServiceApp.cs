using SyncPrime.Application.ViewModel;
using System.Collections.Generic;

namespace SyncPrime.Application.Services.Interfaces
{
    public interface IServiceApp
    {
        void Save(LineViewModel line);
        IEnumerable<LineViewModel> GetCurrentLines();
        IEnumerable<LineViewModel> GetLines();


    }
}
