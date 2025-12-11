namespace WebTaskApi.Data;

using Microsoft.EntityFrameworkCore;
using WebTaskApi.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<ZadachaEntity> Zadachi { get; set; }
}
