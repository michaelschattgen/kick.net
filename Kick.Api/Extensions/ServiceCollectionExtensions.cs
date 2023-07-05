using Kick.Api.Clients;
using Kick.Api.Clients.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kick.Api.Extensions;

public static class ServiceCollectionExtensions
{
    public static IHttpClientBuilder AddKickApiClient(
        this IServiceCollection services,
        Action<HttpClient> configureClient) => services.AddHttpClient<IKickClient, KickClient>((httpClient) =>
        {
            KickClientFactory.ConfigureHttpClientCore(httpClient);
            configureClient(httpClient);
        }
    );
}
