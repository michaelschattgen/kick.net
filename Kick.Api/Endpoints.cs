namespace Kick.Api;

public static class Endpoints
{
    public static readonly Uri V1 = new("https://kick.com/api/v1/");

    public static Uri Channels() => new($"{V1}/channels");
}
