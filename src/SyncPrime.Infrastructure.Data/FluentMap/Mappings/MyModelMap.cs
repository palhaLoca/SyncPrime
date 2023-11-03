using Dapper.FluentMap.Mapping;
using SyncPrime.Domain.Models;

namespace SyncPrime.Infrastructure.Data.FluentMap.Mappings
{
    public class MyModelMap : EntityMap<MyModel>
    {
        public MyModelMap()
        {
            Map(p => p.Id)
                .ToColumn("Id");

            Map(p => p.nomeDoMano)
                .ToColumn("NAME");


        }
    }
}
