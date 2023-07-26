using FlareSolverrSharp;
using Kick.Api.Clients;
using Kick.Api.Clients.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kick.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddKickApiClient(
        this IServiceCollection services,
        Action<HttpClient> configureClient,
        bool useFlareSolverr)
    {
        var builder = services.AddHttpClient<IKickClient, KickClient>((httpClient) =>
        {
            KickClientFactory.ConfigureHttpClientCore(httpClient);
            configureClient(httpClient);
        });

        if (useFlareSolverr)
        {
            builder.ConfigurePrimaryHttpMessageHandler(() =>
                new ClearanceHandler("http://localhost:8191/")
                {
                    MaxTimeout = 60000,
                });
        }

        return builder;
    }
}
