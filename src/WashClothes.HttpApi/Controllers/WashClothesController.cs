using WashClothes.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WashClothes.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WashClothesController : AbpControllerBase
{
    protected WashClothesController()
    {
        LocalizationResource = typeof(WashClothesResource);
    }
}
