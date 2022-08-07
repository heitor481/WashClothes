using WashClothes.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace WashClothes.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(WashClothesEntityFrameworkCoreModule),
    typeof(WashClothesApplicationContractsModule)
    )]
public class WashClothesDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
