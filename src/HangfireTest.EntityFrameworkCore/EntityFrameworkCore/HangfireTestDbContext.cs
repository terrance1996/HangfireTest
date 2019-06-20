using Microsoft.EntityFrameworkCore;
using HangfireTest.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Users.EntityFrameworkCore;

namespace HangfireTest.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class HangfireTestDbContext : AbpDbContext<HangfireTestDbContext>
    {
        public DbSet<AppUser> Users { get; set; }

        public HangfireTestDbContext(DbContextOptions<HangfireTestDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable("AbpUsers"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureFullAudited();
                b.ConfigureExtraProperties();
                b.ConfigureConcurrencyStamp();
                b.ConfigureAbpUser();

                //Moved customization to a method so we can share it with the HangfireTestMigrationsDbContext class
                b.ConfigureCustomUserProperties();
            });

            /* Configure your own tables/entities inside the ConfigureHangfireTest method */

            builder.ConfigureHangfireTest();
        }
    }
}
