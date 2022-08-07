using WashClothes.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace WashClothes.Web.Pages;

public abstract class WashClothesPageModel : AbpPageModel
{
    protected WashClothesPageModel()
    {
        LocalizationResourceType = typeof(WashClothesResource);
    }
}
