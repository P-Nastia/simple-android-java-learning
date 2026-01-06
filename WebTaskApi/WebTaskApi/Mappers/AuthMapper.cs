using AutoMapper;
using WebTaskApi.Entities.Identity;
using WebTaskApi.Models.Auth;
using WebTaskApi.Models.Seeder;

namespace WebTaskApi.Mappers;

public class AuthMapper : Profile
{
    public AuthMapper()
    {
        CreateMap<RegisterModel, UserEntity>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Email));

        CreateMap<SeederUserModel, UserEntity>()
    .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.Email));
    }
}
