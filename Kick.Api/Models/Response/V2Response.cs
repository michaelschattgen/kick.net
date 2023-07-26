using System.Text.Json.Serialization;

namespace Kick.Api.Models.Response;

public class V2Response<T>
{
    [JsonPropertyName("data")]
    public T Data { get; set; }
}
