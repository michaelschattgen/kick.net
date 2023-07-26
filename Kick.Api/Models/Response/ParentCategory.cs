using System.Text.Json.Serialization;

namespace Kick.Api.Models.Response;

public class ParentCategory
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }
}
