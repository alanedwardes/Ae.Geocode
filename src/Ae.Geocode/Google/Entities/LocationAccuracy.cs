using Ae.StringEnum;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    /// <summary>
    /// Additional data about the specified location.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverterFactory))]
    public sealed class LocationAccuracy : StringEnum<LocationAccuracy>
    {
        /// <summary>
        /// Indicates that the returned result is a precise geocode for which we have location information accurate down to street address precision.
        /// </summary>
        public static readonly LocationAccuracy Rooftop = new("ROOFTOP");
        /// <summary>
        /// Indicates that the returned result reflects an approximation (usually on a road) interpolated between
        /// two precise points (such as intersections). Interpolated results are generally
        /// returned when rooftop geocodes are unavailable for a street address.
        /// </summary>
        public static readonly LocationAccuracy RangeInterpolated = new("RANGE_INTERPOLATED");
        /// <summary>
        /// Indicates that the returned result is the geometric center of a result
        /// such as a polyline (for example, a street) or polygon (region).
        /// </summary>
        public static readonly LocationAccuracy GeometricCenter = new("GEOMETRIC_CENTER");
        /// <summary>
        /// Indicates that the returned result is approximate.
        /// </summary>
        public static readonly LocationAccuracy Approximate = new("APPROXIMATE");
        /// <inheritdoc/>
        public LocationAccuracy(string value) : base(value)
        {
        }
    }
}
