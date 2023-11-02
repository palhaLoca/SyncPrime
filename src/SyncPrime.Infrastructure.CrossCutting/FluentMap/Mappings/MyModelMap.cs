using Dapper.FluentMap.Mapping;
using SyncPrime.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncPrime.Infrastructure.CrossCutting.FluentMap.Mappings
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
