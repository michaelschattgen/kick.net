namespace Kick.Api.Attributes;

[AttributeUsage(AttributeTargets.Class)]
public class FriendlyNameAttribute : Attribute
{
    public string Name { get; }

    public FriendlyNameAttribute(string name)
    {
        Name = name;
    }
}