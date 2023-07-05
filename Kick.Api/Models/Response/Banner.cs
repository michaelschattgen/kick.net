using System.Text.Json.Serialization;

public class Banner
{
    [JsonPropertyName("responsive")]
    public string Responsive { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
