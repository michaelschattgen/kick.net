using Kick.Api.Attributes;

namespace Kick.Api.Utils;

public static class TypeUtils
{
    public static string GetFriendlyName<T>()
    {
        var type = typeof(T);
        var attribute = (FriendlyNameAttribute)Attribute.GetCustomAttribute(type, typeof(FriendlyNameAttribute));

        return attribute?.Name ?? type.Name;
    }
}