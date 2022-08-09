using Providers.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Providers;

public abstract class ProvidersController : AbpControllerBase
{
    protected ProvidersController()
    {
        LocalizationResource = typeof(ProvidersResource);
    }
}
