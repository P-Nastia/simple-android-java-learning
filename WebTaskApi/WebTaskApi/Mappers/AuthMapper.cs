using AutoMapper;
using WebTaskApi.Entities.Identity;
using WebTaskApi.Models.Auth;

namespace WebTaskApi.Mappers;

public class AuthMapper : Profile
{
    public AuthMapper()
    {
        CreateMap<RegisterModel, UserEntity>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Email));
    }
}
