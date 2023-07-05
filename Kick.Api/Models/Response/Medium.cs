using System.Text.Json.Serialization;

public class Medium
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("model_type")]
    public string ModelType { get; set; }

    [JsonPropertyName("model_id")]
    public int ModelId { get; set; }

    [JsonPropertyName("collection_name")]
    public string CollectionName { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("file_name")]
    public string FileName { get; set; }

    [JsonPropertyName("mime_type")]
    public string MimeType { get; set; }

    [JsonPropertyName("disk")]
    public string Disk { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("manipulations")]
    public List<object> Manipulations { get; set; }

    [JsonPropertyName("custom_properties")]
    public CustomProperties CustomProperties { get; set; }

    [JsonPropertyName("responsive_images")]
    public object ResponsiveImages { get; set; }

    [JsonPropertyName("order_column")]
    public int OrderColumn { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("uuid")]
    public string Uuid { get; set; }

    [JsonPropertyName("conversions_disk")]
    public string ConversionsDisk { get; set; }
}
