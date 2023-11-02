using AutoMapper;
using SyncPrime.Application.ViewModel;
using SyncPrime.Domain.Models;

namespace SyncPrime.Application.AutoMapper
{
    public  class ViewModelToModel : Profile
    {
        public ViewModelToModel()
        {
            CreateMap<LineViewModel, LineModel>();
        }
          
    }
}
