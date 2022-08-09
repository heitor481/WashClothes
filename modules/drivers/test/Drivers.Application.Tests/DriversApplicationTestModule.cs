using Volo.Abp.Modularity;

namespace Drivers;

[DependsOn(
    typeof(DriversApplicationModule),
    typeof(DriversDomainTestModule)
    )]
public class DriversApplicationTestModule : AbpModule
{

}
