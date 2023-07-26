namespace Kick.Api;

public static class Endpoints
{
    public static readonly Uri KickBaseUrl = new("https://kick.com/api/");
    public static readonly string V1 = "v1/";
    public static readonly string V2 = "v2/";

    public static string Channels => $"{V1}channels";
    public static string Users => $"{V1}users";
    public static string Livestream(string channelName) => $"{V2}channels/{channelName}/livestream";
}
