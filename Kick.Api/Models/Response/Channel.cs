using System.Text.Json.Serialization;

public class Channel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("slug")]
    public string Slug { get; set; }

    [JsonPropertyName("is_banned")]
    public bool IsBanned { get; set; }

    [JsonPropertyName("playback_url")]
    public string PlaybackUrl { get; set; }

    [JsonPropertyName("name_updated_at")]
    public object NameUpdatedAt { get; set; }

    [JsonPropertyName("vod_enabled")]
    public bool VodEnabled { get; set; }

    [JsonPropertyName("subscription_enabled")]
    public bool SubscriptionEnabled { get; set; }

    [JsonPropertyName("followersCount")]
    public int FollowersCount { get; set; }

    [JsonPropertyName("following")]
    public bool Following { get; set; }

    [JsonPropertyName("subscription")]
    public object Subscription { get; set; }

    [JsonPropertyName("subscriber_badges")]
    public List<SubscriberBadge> SubscriberBadges { get; set; }

    [JsonPropertyName("banner_image")]
    public BannerImage BannerImage { get; set; }

    [JsonPropertyName("recent_categories")]
    public List<RecentCategory> RecentCategories { get; set; }

    [JsonPropertyName("livestream")]
    public Livestream Livestream { get; set; }

    [JsonPropertyName("role")]
    public object Role { get; set; }

    [JsonPropertyName("muted")]
    public bool Muted { get; set; }

    [JsonPropertyName("follower_badges")]
    public List<object> FollowerBadges { get; set; }

    [JsonPropertyName("offline_banner_image")]
    public OfflineBannerImage OfflineBannerImage { get; set; }

    [JsonPropertyName("can_host")]
    public bool CanHost { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; }

    [JsonPropertyName("chatroom")]
    public Chatroom Chatroom { get; set; }

    [JsonPropertyName("ascending_links")]
    public List<AscendingLink> AscendingLinks { get; set; }

    [JsonPropertyName("plan")]
    public Plan Plan { get; set; }

    [JsonPropertyName("previous_livestreams")]
    public List<PreviousLivestream> PreviousLivestreams { get; set; }

    [JsonPropertyName("verified")]
    public Verified Verified { get; set; }

    [JsonPropertyName("media")]
    public List<Medium> Media { get; set; }
}
