using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Providers.EntityFrameworkCore;

public class ProvidersHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ProvidersHttpApiHostMigrationsDbContext>
{
    public ProvidersHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProvidersHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ProvidersHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
