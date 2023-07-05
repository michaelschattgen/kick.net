using System.Text.Json.Serialization;

public class Plan
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("channel_id")]
    public int ChannelId { get; set; }

    [JsonPropertyName("stripe_plan_id")]
    public string StripePlanId { get; set; }

    [JsonPropertyName("amount")]
    public string Amount { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
