using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using insideNutri.Authorization.Roles;
using insideNutri.Authorization.Users;
using insideNutri.MultiTenancy;

namespace insideNutri.EntityFrameworkCore
{
    public class insideNutriDbContext : AbpZeroDbContext<Tenant, Role, User, insideNutriDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public insideNutriDbContext(DbContextOptions<insideNutriDbContext> options)
            : base(options)
        {
        }
    }
}
