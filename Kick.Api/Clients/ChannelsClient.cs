using Kick.Api.Clients.Interfaces;

namespace Kick.Api.Clients;

public class ChannelsClient : ApiClient, IChannelsClient
{
    public ChannelsClient(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<string> Get(string channelName, CancellationToken cancel = default)
    {
        var channel = await this.GetAsync<Channel>(Endpoints.Channels + "/" + channelName, cancel);
        return channel.Slug ?? "";
    }
}
