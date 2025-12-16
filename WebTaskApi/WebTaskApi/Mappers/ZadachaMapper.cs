using AutoMapper;
using WebTaskApi.Entities;
using WebTaskApi.Models.Zadacha;

namespace WebTaskApi.Mappers;

public class ZadachaMapper : Profile
{
    public ZadachaMapper()
    {
        CreateMap<ZadachaItemModel, ZadachaEntity>().ReverseMap();
        CreateMap<ZadachaCreateModel, ZadachaEntity>()
                .ForMember(dest => dest.Image, opt => opt.Ignore());
        CreateMap<ZadachaUpdateModel, ZadachaEntity>()
            .ForMember(dest => dest.Image, opt => opt.Ignore())
            .ForMember(dest => dest.Image, opt => opt.Ignore());
    }
}
