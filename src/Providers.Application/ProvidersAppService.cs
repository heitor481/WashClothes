using Providers.Localization;
using Volo.Abp.Application.Services;

namespace Providers;

public abstract class ProvidersAppService : ApplicationService
{
    protected ProvidersAppService()
    {
        LocalizationResource = typeof(ProvidersResource);
        ObjectMapperContext = typeof(ProvidersApplicationModule);
    }
}
