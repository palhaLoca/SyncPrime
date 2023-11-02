using SyncPrime.Domain.Models;
using System.Collections.Generic;

namespace SyncPrime.Domain
{
    public class DomainService : IDomainService
    {
        private readonly IRepository _repository;
        public DomainService(IRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<LineModel> GetLines()
            => _repository.GetLines();
        public void Insert(LineModel line)
            => _repository.Insert(line);

    }
}
