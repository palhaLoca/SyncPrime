using SyncPrime.Domain.Enums;
using System.Collections.Generic;

namespace SyncPrime.Domain.CadSevices
{
    public interface IAutoCadService
    {
        List<object> GetCurrentElement(CadEmun.TypedValue typedValue);
    }
}
