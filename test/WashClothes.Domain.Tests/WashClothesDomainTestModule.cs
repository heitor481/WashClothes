using WashClothes.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace WashClothes;

[DependsOn(
    typeof(WashClothesEntityFrameworkCoreTestModule)
    )]
public class WashClothesDomainTestModule : AbpModule
{

}
