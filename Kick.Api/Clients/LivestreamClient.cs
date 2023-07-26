using Kick.Api.Clients.Interfaces;

namespace Kick.Api.Clients;

public class LivestreamClient : ApiClient, ILivestreamClient
{
    public LivestreamClient(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<Livestream> Get(string channelName, CancellationToken cancel = default)
    {
        var livestream = await this.GetAsync<Livestream>(Endpoints.Livestream(channelName), cancel);
        return livestream!;
    }
}
