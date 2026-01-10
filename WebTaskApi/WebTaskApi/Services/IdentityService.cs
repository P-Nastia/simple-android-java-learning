using Microsoft.AspNetCore.Identity;
using WebTaskApi.Entities.Identity;
using WebTaskApi.Interfaces;

namespace WebTaskApi.Services;

public class IdentityService(IHttpContextAccessor httpContextAccessor,
    UserManager<UserEntity> userManager) : IIdentityService
{
    public async Task<long> GetUserIdAsync()
    {
        var email = httpContextAccessor.HttpContext?.User?.Claims.First()?.Value;
        if (String.IsNullOrEmpty(email))
            throw new UnauthorizedAccessException("User is not authenticated");
        var user = await userManager.FindByEmailAsync(email);
        return user!.Id;
    }
}
