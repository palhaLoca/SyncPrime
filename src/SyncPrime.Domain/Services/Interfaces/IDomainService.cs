using SyncPrime.Domain.Models;
using System.Collections.Generic;

namespace SyncPrime.Domain
{
    public  interface IDomainService
    {       
        IEnumerable<LineModel> GetLines();
        void Insert(LineModel line);
    }
}
