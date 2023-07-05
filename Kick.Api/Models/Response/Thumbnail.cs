using System.Text.Json.Serialization;

public class Thumbnail
{
    [JsonPropertyName("responsive")]
    public string Responsive { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("src")]
    public string Src { get; set; }

    [JsonPropertyName("srcset")]
    public string Srcset { get; set; }
}
