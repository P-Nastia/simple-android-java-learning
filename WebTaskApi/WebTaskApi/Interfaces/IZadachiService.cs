using WebTaskApi.Models.Zadacha;

namespace WebTaskApi.Interfaces;

public interface IZadachiService
{
    Task<IEnumerable<ZadachaItemModel>> GetAllAsync();
    Task<ZadachaItemModel> CreateZadachyAsync(ZadachaCreateModel model);
}