using Kick.Api.Clients;
using Kick.Api.Clients.Interfaces;

namespace Kick.Api;

public class KickClient : IKickClient
{
    public KickClient(HttpClient httpClient)
    {
        Channels = new ChannelsClient(httpClient);
    }

    public IChannelsClient Channels { get; }
}
