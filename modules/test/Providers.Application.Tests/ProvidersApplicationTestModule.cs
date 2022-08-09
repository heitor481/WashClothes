using Volo.Abp.Modularity;

namespace Providers;

[DependsOn(
    typeof(ProvidersApplicationModule),
    typeof(ProvidersDomainTestModule)
    )]
public class ProvidersApplicationTestModule : AbpModule
{

}
