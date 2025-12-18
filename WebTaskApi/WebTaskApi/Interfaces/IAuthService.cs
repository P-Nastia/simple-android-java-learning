using WebTaskApi.Models.Auth;

namespace WebTaskApi.Interfaces;

public interface IAuthService
{
    public Task<string> LoginAsync(LoginModel model);
    public Task<string> RegisterAsync(RegisterModel model);
}
