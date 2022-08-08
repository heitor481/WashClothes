using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Providers.EntityFrameworkCore;

[ConnectionStringName(ProvidersDbProperties.ConnectionStringName)]
public class ProvidersDbContext : AbpDbContext<ProvidersDbContext>, IProvidersDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ProvidersDbContext(DbContextOptions<ProvidersDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureProviders();
    }
}
