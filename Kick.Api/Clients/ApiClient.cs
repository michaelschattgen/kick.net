using System.Text.Json;
using Kick.Api.Exceptions;
using Kick.Api.Utils;

namespace Kick.Api.Clients;

public abstract class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T?> GetAsync<T>(string endpoint, CancellationToken cancellationToken)
    {
        var response = await this._httpClient.GetAsync(endpoint, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            HandleRequestFailure<T>(response);
        }

        string content = await response.Content.ReadAsStringAsync();

        if (!string.IsNullOrEmpty(content))
        {
            return JsonSerializer.Deserialize<T>(content);
        }

        return default(T);
    }

    protected void HandleRequestFailure<T>(HttpResponseMessage response)
    {
        try
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new KickException($"{TypeUtils.GetFriendlyName<T>()} was not found.", response.StatusCode);
            }
        }
        finally
        {
            response.Dispose();
        }
    }
}
