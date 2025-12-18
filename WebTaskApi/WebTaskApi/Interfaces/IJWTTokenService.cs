using WebTaskApi.Entities.Identity;

namespace WebTaskApi.Interfaces;

public interface IJWTTokenService
{
    Task<string> CreateTokenAsync(UserEntity user);
}
