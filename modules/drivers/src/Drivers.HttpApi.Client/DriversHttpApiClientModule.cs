using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Drivers;

[DependsOn(
    typeof(DriversApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class DriversHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DriversApplicationContractsModule).Assembly,
            DriversRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DriversHttpApiClientModule>();
        });

    }
}
