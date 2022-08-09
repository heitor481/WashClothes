using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Providers;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProvidersHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ProvidersConsoleApiClientModule : AbpModule
{

}
