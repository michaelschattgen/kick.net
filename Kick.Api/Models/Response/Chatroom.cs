using System.Text.Json.Serialization;

public class Chatroom
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chatable_type")]
    public string ChatableType { get; set; }

    [JsonPropertyName("channel_id")]
    public int ChannelId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("chat_mode_old")]
    public string ChatModeOld { get; set; }

    [JsonPropertyName("chat_mode")]
    public string ChatMode { get; set; }

    [JsonPropertyName("slow_mode")]
    public bool SlowMode { get; set; }

    [JsonPropertyName("chatable_id")]
    public int ChatableId { get; set; }

    [JsonPropertyName("followers_mode")]
    public bool FollowersMode { get; set; }

    [JsonPropertyName("subscribers_mode")]
    public bool SubscribersMode { get; set; }

    [JsonPropertyName("emotes_mode")]
    public bool EmotesMode { get; set; }

    [JsonPropertyName("message_interval")]
    public int MessageInterval { get; set; }

    [JsonPropertyName("following_min_duration")]
    public int FollowingMinDuration { get; set; }
}
