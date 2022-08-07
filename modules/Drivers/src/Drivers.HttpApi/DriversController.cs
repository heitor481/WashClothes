using Drivers.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Drivers;

public abstract class DriversController : AbpControllerBase
{
    protected DriversController()
    {
        LocalizationResource = typeof(DriversResource);
    }
}
