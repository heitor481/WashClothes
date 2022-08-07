using System;
using System.Collections.Generic;
using System.Text;
using WashClothes.Localization;
using Volo.Abp.Application.Services;

namespace WashClothes;

/* Inherit your application services from this class.
 */
public abstract class WashClothesAppService : ApplicationService
{
    protected WashClothesAppService()
    {
        LocalizationResource = typeof(WashClothesResource);
    }
}
