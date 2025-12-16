namespace WebTaskApi.Models.Zadacha;

public class ZadachaUpdateModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public IFormFile? Image { get; set; }
}
