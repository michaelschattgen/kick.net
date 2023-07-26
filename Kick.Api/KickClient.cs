using Kick.Api.Clients;
using Kick.Api.Clients.Interfaces;

namespace Kick.Api;

public class KickClient : IKickClient
{
    public KickClient(HttpClient httpClient)
    {
        Channels = new ChannelsClient(httpClient);
        Users = new UsersClient(httpClient);
    }

    public IChannelsClient Channels { get; }
    public IUsersClient Users { get; }
}
