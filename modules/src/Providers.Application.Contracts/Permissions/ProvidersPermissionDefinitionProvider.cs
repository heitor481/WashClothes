using Providers.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Providers.Permissions;

public class ProvidersPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ProvidersPermissions.GroupName, L("Permission:Providers"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ProvidersResource>(name);
    }
}
