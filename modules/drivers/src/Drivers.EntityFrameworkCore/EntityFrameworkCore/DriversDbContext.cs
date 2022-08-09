using Drivers.Drivers;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Drivers.EntityFrameworkCore;

[ConnectionStringName(DriversDbProperties.ConnectionStringName)]
public class DriversDbContext : AbpDbContext<DriversDbContext>, IDriversDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Driver> Drivers { get; set; }

    public DriversDbContext(DbContextOptions<DriversDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDrivers();

        builder.Entity<Driver>(b =>
        {
            b.ConfigureByConvention();
            b.Property(p => p.Name).IsRequired();
        });
    }
}
