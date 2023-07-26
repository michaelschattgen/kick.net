using Kick.Api.Clients.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Kick.Example.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly IKickClient _kickClient;

    private readonly ILogger<UserController> _logger;

    public UserController(IKickClient kickClient, ILogger<UserController> logger)
    {
        _kickClient = kickClient;
        _logger = logger;
    }

    [HttpGet(Name = "GetUser")]
    public async Task<User> GetUser(string username)
    {
        var user = await _kickClient.Users.Get(username);
        return user;
    }
}
