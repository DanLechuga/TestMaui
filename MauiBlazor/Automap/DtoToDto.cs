using AutoMapper;
using MauiBlazor.Data;
using MiddlewareMaui.Dtos.Collectios;

namespace MiddlewareMaui.Automap
{
    public class DtoToDto : Profile
    {
        public DtoToDto()
        {
            CreateMap<QueryOperationsDto, Operations>().ReverseMap()
                .ForMember(dest => dest.operation, a => a.MapFrom(src => src.Opertaions))
                .ForMember(dest => dest._id, a => a.MapFrom(src => src._id));
        }
    }
}
