using Kick.Api.Clients.Interfaces;

namespace Kick.Api.Clients;

public static class KickClientFactory
{
    public static IKickClient Create()
    {
        var httpClient = new HttpClient()
        {
            BaseAddress = Endpoints.V1
        };

        ConfigureHttpClient(httpClient);
        return new KickClient(httpClient);
    }

    internal static void ConfigureHttpClient(HttpClient httpClient)
    {
        ConfigureHttpClientCore(httpClient);
    }

    internal static void ConfigureHttpClientCore(HttpClient httpClient)
    {
        httpClient.DefaultRequestHeaders.Accept.Clear();
        httpClient.DefaultRequestHeaders.Accept.Add(new("application/json"));
    }
}
