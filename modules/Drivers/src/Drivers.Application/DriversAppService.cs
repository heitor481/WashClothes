using Drivers.Localization;
using Volo.Abp.Application.Services;

namespace Drivers;

public abstract class DriversAppService : ApplicationService
{
    protected DriversAppService()
    {
        LocalizationResource = typeof(DriversResource);
        ObjectMapperContext = typeof(DriversApplicationModule);
    }
}
