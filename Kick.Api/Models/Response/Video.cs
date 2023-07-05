using System.Text.Json.Serialization;

public class Video
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("live_stream_id")]
    public int LiveStreamId { get; set; }

    [JsonPropertyName("slug")]
    public object Slug { get; set; }

    [JsonPropertyName("thumb")]
    public object Thumb { get; set; }

    [JsonPropertyName("s3")]
    public object S3 { get; set; }

    [JsonPropertyName("trading_platform_id")]
    public object TradingPlatformId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("views")]
    public int Views { get; set; }

    [JsonPropertyName("deleted_at")]
    public object DeletedAt { get; set; }
}
