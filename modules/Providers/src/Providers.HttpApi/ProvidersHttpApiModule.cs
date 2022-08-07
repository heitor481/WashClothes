using Localization.Resources.AbpUi;
using Providers.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Providers;

[DependsOn(
    typeof(ProvidersApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class ProvidersHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(ProvidersHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<ProvidersResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
