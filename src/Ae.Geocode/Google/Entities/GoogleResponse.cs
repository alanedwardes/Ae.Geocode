using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public abstract class GoogleResponse
    {
        [JsonPropertyName("status")]
        public Status? Status { get; set; }
        [JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }
    }
}
