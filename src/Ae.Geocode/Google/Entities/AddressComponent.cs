using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class AddressComponent
    {
        /// <summary>
        /// The full text description or name of the address
        /// component as returned by the Geocoder.
        /// </summary>
        [JsonPropertyName("long_name")]
        public string? LongName { get; set; }
        /// <summary>
        /// An abbreviated textual name for the address component,
        /// if available. For example, an address component for the
        /// state of Alaska may have a long_name of "Alaska" and a
        /// short_name of "AK" using the 2-letter postal abbreviation. 
        /// </summary>
        [JsonPropertyName("short_name")]
        public string? ShortName { get; set; }
        /// <summary>
        /// An array indicating the type of the address component.
        /// </summary>
        [JsonPropertyName("types")]
        public IReadOnlyList<ResultType> Types { get; set; } = Array.Empty<ResultType>();
        public override string ToString() => $"LongName={LongName},ShortName={ShortName},Types={string.Join(",", Types)}";
    }
}
