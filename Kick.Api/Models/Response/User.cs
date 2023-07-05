using System.Text.Json.Serialization;

public class User
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("agreed_to_terms")]
    public bool AgreedToTerms { get; set; }

    [JsonPropertyName("email_verified_at")]
    public DateTime EmailVerifiedAt { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    [JsonPropertyName("country")]
    public object Country { get; set; }

    [JsonPropertyName("state")]
    public object State { get; set; }

    [JsonPropertyName("city")]
    public object City { get; set; }

    [JsonPropertyName("instagram")]
    public object Instagram { get; set; }

    [JsonPropertyName("twitter")]
    public object Twitter { get; set; }

    [JsonPropertyName("youtube")]
    public object Youtube { get; set; }

    [JsonPropertyName("discord")]
    public object Discord { get; set; }

    [JsonPropertyName("tiktok")]
    public object Tiktok { get; set; }

    [JsonPropertyName("facebook")]
    public object Facebook { get; set; }

    [JsonPropertyName("profile_pic")]
    public string ProfilePic { get; set; }
}
