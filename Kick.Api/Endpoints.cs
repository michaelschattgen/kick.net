namespace Kick.Api;

public static class Endpoints
{
    public static readonly Uri V1 = new("https://kick.com/api/v1/");

    public static string Channels => $"channels";
    public static string Users => $"users";
}
