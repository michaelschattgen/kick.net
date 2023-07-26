using Kick.Api.Clients.Interfaces;

namespace Kick.Api.Clients;

public class UsersClient : ApiClient, IUsersClient
{
    public UsersClient(HttpClient httpClient) : base(httpClient)
    {
    }

    public async Task<User> Get(string userName, CancellationToken cancel)
    {
        var user = await this.GetAsync<User>(Endpoints.Users + "/" + userName, cancel);
        return user!;
    }
}
