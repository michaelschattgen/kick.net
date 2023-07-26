namespace Kick.Api.Clients.Interfaces;

public interface IKickClient
{
    IChannelsClient Channels { get; }
    IUsersClient Users { get; }
    ILivestreamClient Livestream { get; }
}
