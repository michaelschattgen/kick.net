using System.Text.Json.Serialization;

public class CustomProperties
{
    [JsonPropertyName("generated_conversions")]
    public GeneratedConversions GeneratedConversions { get; set; }
}
