using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace DukkatTekProject.EntityFrameworkCore
{
    public static class DukkatTekProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<DukkatTekProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<DukkatTekProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
