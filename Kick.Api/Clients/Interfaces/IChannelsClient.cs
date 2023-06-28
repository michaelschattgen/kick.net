namespace Kick.Api.Clients.Interfaces;

public interface IChannelsClient
{
    Task<string> Get(string channelName, CancellationToken cancel = default);
}
