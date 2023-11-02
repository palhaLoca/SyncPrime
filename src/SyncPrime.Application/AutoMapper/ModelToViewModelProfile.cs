using Autodesk.AutoCAD.DatabaseServices;
using AutoMapper;
using SyncPrime.Application.ViewModel;
using SyncPrime.Domain.Models;

namespace SyncPrime.Application.AutoMapper
{
    public class ModelToViewModelProfile : Profile
    {
        public ModelToViewModelProfile()
        {
            CreateMap<LineModel, LineViewModel>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.id))
                .ForMember(dest => dest.layer, opt => opt.MapFrom(src => src.layer))
                .ForMember(dest => dest.startPtX, opt => opt.MapFrom(src => src.startPtX))
                .ForMember(dest => dest.startPtY, opt => opt.MapFrom(src => src.startPtY))
                .ForMember(dest => dest.endPtX, opt => opt.MapFrom(src => src.endPtX))
                .ForMember(dest => dest.endPtY, opt => opt.MapFrom(src => src.endPtY))
                .ForMember(dest => dest.createdAt, opt => opt.MapFrom(src => src.createdAt))
                .ForMember(dest => dest.deletedAt, opt => opt.MapFrom(src => src.deletedAt))
                ;
        }
    }
}
