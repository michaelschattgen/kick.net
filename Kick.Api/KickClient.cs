using Kick.Api.Clients;
using Kick.Api.Clients.Interfaces;

namespace Kick.Api;
public class KickClient
{
    public KickClient()
    {
        Channels = new ChannelsClient();
    }

    public IChannelsClient Channels { get; }
}
