using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WashClothes.Data;
using Volo.Abp.DependencyInjection;

namespace WashClothes.EntityFrameworkCore;

public class EntityFrameworkCoreWashClothesDbSchemaMigrator
    : IWashClothesDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreWashClothesDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the WashClothesDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<WashClothesDbContext>()
            .Database
            .MigrateAsync();
    }
}
