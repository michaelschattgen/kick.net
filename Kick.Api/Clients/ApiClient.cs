using System.Text.Json;
using Kick.Api.Clients.Interfaces;

namespace Kick.Api.Clients;

public abstract class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T> GetAsync<T>(string endpoint, CancellationToken cancellationToken)
    {
        var response = await this._httpClient.GetAsync(endpoint, cancellationToken);
        response.EnsureSuccessStatusCode();

        string content = await response.Content.ReadAsStringAsync();
        T result = JsonSerializer.Deserialize<T>(content);

        return result;
    }
}
