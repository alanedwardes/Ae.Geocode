using Ae.StringEnum;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    [JsonConverter(typeof(StringEnumConverterFactory))]
    public sealed class LocationAccuracy : StringEnum<LocationAccuracy>
    {
        public static readonly LocationAccuracy Rooftop = new("ROOFTOP");
        public static readonly LocationAccuracy RangeInterpolated = new("RANGE_INTERPOLATED");
        public static readonly LocationAccuracy GeometricCenter = new("GEOMETRIC_CENTER");
        public static readonly LocationAccuracy Approximate = new("APPROXIMATE");

        public LocationAccuracy(string value) : base(value)
        {
        }
    }
}
