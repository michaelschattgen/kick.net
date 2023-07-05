using System.Text.Json.Serialization;

public class Verified
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("channel_id")]
    public int ChannelId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
