using System.Text.Json.Serialization;

public class OfflineBannerImage
{
    [JsonPropertyName("src")]
    public string Src { get; set; }

    [JsonPropertyName("srcset")]
    public string Srcset { get; set; }
}
