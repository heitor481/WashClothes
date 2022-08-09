using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Providers.EntityFrameworkCore;

public class ProvidersHttpApiHostMigrationsDbContext : AbpDbContext<ProvidersHttpApiHostMigrationsDbContext>
{
    public ProvidersHttpApiHostMigrationsDbContext(DbContextOptions<ProvidersHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureProviders();
    }
}
