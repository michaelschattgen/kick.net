
using System.Text.Json.Serialization;

public class BadgeImage
{
    [JsonPropertyName("srcset")]
    public string Srcset { get; set; }

    [JsonPropertyName("src")]
    public string Src { get; set; }
}
