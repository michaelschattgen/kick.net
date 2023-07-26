using Kick.Api.Clients.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Kick.Example.Controllers;

[ApiController]
[Route("[controller]")]
public class LivestreamController : ControllerBase
{
    private readonly IKickClient _kickClient;

    private readonly ILogger<LivestreamController> _logger;

    public LivestreamController(IKickClient kickClient, ILogger<LivestreamController> logger)
    {
        _kickClient = kickClient;
        _logger = logger;
    }

    [HttpGet(Name = "GetLivestream")]
    public async Task<Livestream> GetName(string channelName)
    {
        var livestream = await _kickClient.Livestream.Get(channelName);
        return livestream;
    }
}
