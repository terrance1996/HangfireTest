using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HangfireTest.EntityFrameworkCore
{
    public class HangfireTestMigrationsDbContextFactory : IDesignTimeDbContextFactory<HangfireTestMigrationsDbContext>
    {
        public HangfireTestMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<HangfireTestMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new HangfireTestMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
