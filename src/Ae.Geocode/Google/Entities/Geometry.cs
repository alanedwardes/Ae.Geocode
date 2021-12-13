using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class Geometry
    {
        [JsonPropertyName("location")]
        public Location? Location { get; set; }
        [JsonPropertyName("location_type")]
        public LocationAccuracy? LocationType { get; set; }
        [JsonPropertyName("viewport")]
        public Viewport? Viewport { get; set; }
        [JsonPropertyName("bounds")]
        public Viewport? Bounds { get; set; }
    }
}
