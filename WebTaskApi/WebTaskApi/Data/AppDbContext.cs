namespace WebTaskApi.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebTaskApi.Entities;
using WebTaskApi.Entities.Identity;

public class AppDbContext : IdentityDbContext<
    UserEntity,
    RoleEntity,
    long,
    IdentityUserClaim<long>,
    UserRoleEntity,
    IdentityUserLogin<long>,
    IdentityRoleClaim<long>,
    IdentityUserToken<long>>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<ZadachaEntity> Zadachi { get; set; }
}
