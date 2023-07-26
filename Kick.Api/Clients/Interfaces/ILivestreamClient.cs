namespace Kick.Api.Clients.Interfaces;

public interface ILivestreamClient
{
    Task<Livestream> Get(string channelName, CancellationToken cancel = default);
}
