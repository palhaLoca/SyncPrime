using AutoMapper;

namespace SyncPrime.Application.AutoMapper
{
    public sealed class MapperBootStrap
    {
        public IMapper _mapper { get; }
        public MapperBootStrap()
        {
            _mapper = new MapperConfiguration(
              cfg =>
              {
                  cfg.AddProfile(typeof(CadProfile));
                  cfg.AddProfile(typeof(ModelToViewModelProfile));
                  cfg.AddProfile(typeof(ViewModelToModel));
              }).CreateMapper();
        }
    }
}
