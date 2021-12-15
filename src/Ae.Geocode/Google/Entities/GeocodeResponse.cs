using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class GeocodeResponse : GoogleResponse
    {
        [JsonPropertyName("plus_code")]
        public PlusCode? PlusCode { get; set; }
        [JsonPropertyName("results")]
        public IReadOnlyList<GeocodeResult> Results { get; set; } = Array.Empty<GeocodeResult>();
    }
}
