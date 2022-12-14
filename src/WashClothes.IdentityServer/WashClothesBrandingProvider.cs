using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace WashClothes;

[Dependency(ReplaceServices = true)]
public class WashClothesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "WashClothes";
}
