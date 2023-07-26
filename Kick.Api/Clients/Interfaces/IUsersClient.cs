namespace Kick.Api.Clients.Interfaces;

public interface IUsersClient
{
    Task<User> Get(string userName, CancellationToken cancel = default);
}
