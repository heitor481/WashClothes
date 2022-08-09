using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Drivers;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DriversDomainSharedModule)
)]
public class DriversDomainModule : AbpModule
{

}
