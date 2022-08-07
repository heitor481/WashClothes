using Volo.Abp.Modularity;

namespace WashClothes;

[DependsOn(
    typeof(WashClothesApplicationModule),
    typeof(WashClothesDomainTestModule)
    )]
public class WashClothesApplicationTestModule : AbpModule
{

}
