namespace WebTaskApi.Interfaces;

public interface IIdentityService
{
    Task<long> GetUserIdAsync();
}
