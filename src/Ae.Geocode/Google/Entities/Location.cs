using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class Location
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }
        [JsonPropertyName("lng")]
        public double Longitude { get; set; }
        public override string ToString() => $"{Latitude},{Longitude}";
    }
}
