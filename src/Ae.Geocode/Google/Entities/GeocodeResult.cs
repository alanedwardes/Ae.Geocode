using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class GeocodeResult
    {
        [JsonPropertyName("address_components")]
        public IReadOnlyList<AddressComponent> AddressComponents { get; set; } = Array.Empty<AddressComponent>();
        [JsonPropertyName("formatted_address")]
        public string? FormattedAddress { get; set; }
        [JsonPropertyName("geometry")]
        public Geometry? Geometry { get; set; }
        [JsonPropertyName("place_id")]
        public string? PlaceId { get; set; }
        [JsonPropertyName("plus_code")]
        public PlusCode? PlusCode { get; set; }
        [JsonPropertyName("types")]
        public IReadOnlyList<ResultType> Types { get; set; } = Array.Empty<ResultType>();
        public override string ToString() => $"{FormattedAddress},Types={string.Join(",", Types)}";
    }
}
