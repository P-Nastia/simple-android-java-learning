using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebTaskApi.Entities;

[Table("tbl_zadacha")]
public class ZadachaEntity : BaseEntity<long>
{
    [StringLength(250)]
    public string Name { get; set; } = String.Empty;

    [StringLength(200)]
    public string Image { get; set; } = String.Empty;
}
