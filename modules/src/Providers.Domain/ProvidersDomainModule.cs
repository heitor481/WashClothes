using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Providers;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ProvidersDomainSharedModule)
)]
public class ProvidersDomainModule : AbpModule
{

}
