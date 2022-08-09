using Volo.Abp.Reflection;

namespace Drivers.Permissions;

public class DriversPermissions
{
    public const string GroupName = "Drivers";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(DriversPermissions));
    }
}
