using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace insideNutri.EntityFrameworkCore
{
    public static class insideNutriDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<insideNutriDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<insideNutriDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
