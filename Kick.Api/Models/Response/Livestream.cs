using System.Text.Json.Serialization;

public class Livestream
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("channel_id")]
    public int ChannelId { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("session_title")]
    public string SessionTitle { get; set; }

    [JsonPropertyName("is_live")]
    public bool IsLive { get; set; }

    [JsonPropertyName("risk_level_id")]
    public object RiskLevelId { get; set; }

    [JsonPropertyName("source")]
    public object Source { get; set; }

    [JsonPropertyName("twitch_channel")]
    public object TwitchChannel { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("is_mature")]
    public bool IsMature { get; set; }

    [JsonPropertyName("viewer_count")]
    public int ViewerCount { get; set; }

    [JsonPropertyName("thumbnail")]
    public Thumbnail Thumbnail { get; set; }

    [JsonPropertyName("viewers")]
    public int Viewers { get; set; }

    [JsonPropertyName("categories")]
    public List<Category> Categories { get; set; }

    [JsonPropertyName("tags")]
    public List<object> Tags { get; set; }
}
