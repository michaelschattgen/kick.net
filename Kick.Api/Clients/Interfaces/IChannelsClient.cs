namespace Kick.Api.Clients.Interfaces;

public interface IChannelsClient
{
    Task<Channel> Get(string channelName, CancellationToken cancel = default);
}
