using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Drivers;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DriversHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class DriversConsoleApiClientModule : AbpModule
{

}
