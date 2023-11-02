using Autodesk.AutoCAD.DatabaseServices;
using AutoMapper;
using SyncPrime.Application.ViewModel;
using SyncPrime.Domain.Models;

namespace SyncPrime.Application.AutoMapper
{
    public class CadProfile : Profile
    {
        public CadProfile()
        {
            CreateMap<MText, MTextModel>()
               .ForMember(dest => dest.text, opt => opt.MapFrom(src => src.Text))
               .ForMember(dest => dest.insPtX, opt => opt.MapFrom(src => src.Location.X))
               .ForMember(dest => dest.text, opt => opt.MapFrom(src => src.Location.Y));


            CreateMap<Line, LineModel>()
               .ForMember(dest => dest.layer, opt => opt.MapFrom(src => src.Layer))
               .ForMember(dest => dest.startPtX, opt => opt.MapFrom(src => src.StartPoint.X))
               .ForMember(dest => dest.startPtY, opt => opt.MapFrom(src => src.StartPoint.Y))
               .ForMember(dest => dest.endPtX, opt => opt.MapFrom(src => src.EndPoint.X))
               .ForMember(dest => dest.endPtY, opt => opt.MapFrom(src => src.EndPoint.Y));

            CreateMap<Line, LineViewModel>()
               .ForMember(dest => dest.layer, opt => opt.MapFrom(src => src.Layer))
               .ForMember(dest => dest.startPtX, opt => opt.MapFrom(src => src.StartPoint.X))
               .ForMember(dest => dest.startPtY, opt => opt.MapFrom(src => src.StartPoint.Y))
               .ForMember(dest => dest.endPtX, opt => opt.MapFrom(src => src.EndPoint.X))
               .ForMember(dest => dest.endPtY, opt => opt.MapFrom(src => src.EndPoint.Y));
        }

    }
}
