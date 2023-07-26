using Kick.Api.Clients.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Kick.Example.Controllers;

[ApiController]
[Route("[controller]")]
public class ChannelController : ControllerBase
{
    private readonly IKickClient _kickClient;

    private readonly ILogger<ChannelController> _logger;

    public ChannelController(IKickClient kickClient, ILogger<ChannelController> logger)
    {
        _kickClient = kickClient;
        _logger = logger;
    }

    [HttpGet(Name = "GetChannel")]
    public async Task<Channel> GetName(string channelName)
    {
        var channel = await _kickClient.Channels.Get(channelName);
        return channel;
    }
}
