using Volo.Abp.Reflection;

namespace Providers.Permissions;

public class ProvidersPermissions
{
    public const string GroupName = "Providers";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(ProvidersPermissions));
    }
}
