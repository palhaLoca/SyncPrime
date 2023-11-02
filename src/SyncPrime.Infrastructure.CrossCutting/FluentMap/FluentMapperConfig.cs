using Dapper.FluentMap;
using SyncPrime.Infrastructure.CrossCutting.FluentMap.Mappings;

namespace SyncPrime.Infrastructure.CrossCutting.FluentMap
{
    public class FluentMapperConfig
    {
        public static void Inicialize()
        {

            FluentMapper.Initialize(config =>
            {
                config.AddMap(new MyModelMap());
                config.AddMap(new LineModelMap());
            });

        }
    }
}
