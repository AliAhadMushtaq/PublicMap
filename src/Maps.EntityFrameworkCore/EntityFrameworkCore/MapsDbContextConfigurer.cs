using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Maps.EntityFrameworkCore
{
    public static class MapsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MapsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MapsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
