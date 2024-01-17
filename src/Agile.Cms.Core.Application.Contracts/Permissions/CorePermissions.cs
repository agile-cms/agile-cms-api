using Volo.Abp.Reflection;

namespace Agile.Cms.Core.Permissions;

public class CorePermissions
{
    public const string GroupName = "AgileCmsCore";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(CorePermissions));
    }
}
