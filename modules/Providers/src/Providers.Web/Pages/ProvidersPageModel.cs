using Providers.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Providers.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ProvidersPageModel : AbpPageModel
{
    protected ProvidersPageModel()
    {
        LocalizationResourceType = typeof(ProvidersResource);
        ObjectMapperContext = typeof(ProvidersWebModule);
    }
}
