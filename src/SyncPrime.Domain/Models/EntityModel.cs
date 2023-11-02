using System;

namespace SyncPrime.Domain.Models
{
    public class EntityModel
    {
        public long id { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
        public DateTime? deletedAt { get; set; }

    }
}
