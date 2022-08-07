using Drivers.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Drivers.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class DriversPageModel : AbpPageModel
{
    protected DriversPageModel()
    {
        LocalizationResourceType = typeof(DriversResource);
        ObjectMapperContext = typeof(DriversWebModule);
    }
}
