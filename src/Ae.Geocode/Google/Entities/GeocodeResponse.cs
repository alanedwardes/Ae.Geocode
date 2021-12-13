using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class GeocodeResponse
    {
        [JsonPropertyName("plus_code")]
        public PlusCode PlusCode { get; set; }
        [JsonPropertyName("results")]
        public IReadOnlyList<GeocodeResult> Results { get; set; } = new List<GeocodeResult>();
    }
}
