using Microsoft.AspNetCore.SignalR;

namespace Streaming.API.Hubs;

public class SignalingHub(ILogger _logger) : Hub
{
    public async Task SendOffer(string user, string offer)
    {
        _logger.LogInformation($"ReceiveOffer {offer}");
        await Clients.User(user).SendAsync("ReceiveOffer", offer);
    }

    public async Task SendAnswer(string user, string answer)
    {
        _logger.LogInformation($"ReceiveOffer {answer}");

        await Clients.User(user).SendAsync("ReceiveAnswer", answer);
    }

    public async Task SendIceCandidate(string user, string candidate)
    {
        _logger.LogInformation($"ReceiveOffer {candidate}");

        await Clients.User(user).SendAsync("ReceiveIceCandidate", candidate);
    }
}