using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Providers;

[DependsOn(
    typeof(ProvidersApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ProvidersHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ProvidersApplicationContractsModule).Assembly,
            ProvidersRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ProvidersHttpApiClientModule>();
        });

    }
}
