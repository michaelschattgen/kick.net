using Kick.Api.Clients.Interfaces;

namespace Kick.Api.Clients;

public class ChannelsClient : IChannelsClient
{
    public Task<string> Get(string channelName, CancellationToken cancel = default)
    {
        return Task.FromResult(channelName);
    }
}
