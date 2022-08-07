using Volo.Abp.Settings;

namespace WashClothes.Settings;

public class WashClothesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(WashClothesSettings.MySetting1));
    }
}
