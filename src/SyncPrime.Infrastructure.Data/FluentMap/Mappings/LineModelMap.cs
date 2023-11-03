using Dapper.FluentMap.Mapping;
using SyncPrime.Domain.Models;

namespace SyncPrime.Infrastructure.Data.FluentMap.Mappings
{
    public class LineModelMap : EntityMap<LineModel>
    {
        public LineModelMap()
        {
            Map(p => p.id).ToColumn("ID");
            Map(p => p.layer).ToColumn("LAYER");
            Map(p => p.startPtX).ToColumn("START_PT_X");
            Map(p => p.startPtY).ToColumn("START_PT_Y");
            Map(p => p.endPtX).ToColumn("END_PT_X");
            Map(p => p.endPtY).ToColumn("END_PT_Y");
            Map(p => p.createdAt).ToColumn("CREATED_AT");
            Map(p => p.deletedAt).ToColumn("DELETED_AT");

        }
    }
}
