using System.Text.Json.Serialization;

public class SubscriberBadge
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("channel_id")]
    public int ChannelId { get; set; }

    [JsonPropertyName("months")]
    public int Months { get; set; }

    [JsonPropertyName("badge_image")]
    public BadgeImage BadgeImage { get; set; }
}
