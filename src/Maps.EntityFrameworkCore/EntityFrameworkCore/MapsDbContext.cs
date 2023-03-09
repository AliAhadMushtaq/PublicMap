using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Maps.Authorization.Roles;
using Maps.Authorization.Users;
using Maps.MultiTenancy;

namespace Maps.EntityFrameworkCore
{
    public class MapsDbContext : AbpZeroDbContext<Tenant, Role, User, MapsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MapsDbContext(DbContextOptions<MapsDbContext> options)
            : base(options)
        {
        }
    }
}
