using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class AddressComponent
    {
        [JsonPropertyName("long_name")]
        public string LongName { get; set; }
        [JsonPropertyName("short_name")]
        public string ShortName { get; set; }
        [JsonPropertyName("types")]
        public IReadOnlyList<ResultType> Types { get; set; } = new List<ResultType>();
        public override string ToString() => $"LongName={LongName},ShortName={ShortName},Types={string.Join(",", Types)}";
    }
}
