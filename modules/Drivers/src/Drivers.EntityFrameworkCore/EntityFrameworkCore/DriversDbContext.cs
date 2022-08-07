using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Drivers.EntityFrameworkCore;

[ConnectionStringName(DriversDbProperties.ConnectionStringName)]
public class DriversDbContext : AbpDbContext<DriversDbContext>, IDriversDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DriversDbContext(DbContextOptions<DriversDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDrivers();
    }
}
