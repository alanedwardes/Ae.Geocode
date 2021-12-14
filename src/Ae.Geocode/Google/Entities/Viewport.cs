using Geolocation;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class Viewport
    {
        [JsonPropertyName("northeast")]
        public Location? NorthEast { get; set; }

        [JsonPropertyName("southwest")]
        public Location? SouthWest { get; set; }

        [JsonIgnore]
        public Location? SouthEast => NorthEast == null || SouthWest == null ? null : new Location { Latitude = SouthWest.Latitude, Longitude = NorthEast.Longitude };

        [JsonIgnore]
        public Location? NorthWest => NorthEast == null || SouthWest == null ? null : new Location { Latitude = NorthEast.Latitude, Longitude = SouthWest.Longitude };

        [JsonIgnore]
        public double WidthKilometers
        {
            get
            {
                if (NorthEast == null || SouthWest == null || NorthWest == null || SouthEast == null)
                {
                    return 0;
                }

                return GeoCalculator.GetDistance(LocationToCoordinate(NorthWest), LocationToCoordinate(NorthEast), 1, DistanceUnit.Kilometers);
            }
        }

        [JsonIgnore]
        public double HeightKilometers
        {
            get
            {
                if (NorthEast == null || SouthWest == null || NorthWest == null || SouthEast == null)
                {
                    return 0;
                }

                return GeoCalculator.GetDistance(LocationToCoordinate(NorthWest), LocationToCoordinate(SouthWest), 1, DistanceUnit.Kilometers);
            }
        }

        private static Coordinate LocationToCoordinate(Location location) => new() { Latitude = location.Latitude, Longitude = location.Longitude };

        [JsonIgnore]
        public double AreaKilometers => WidthKilometers * HeightKilometers;

        public override string ToString() => $"NorthEast={NorthEast},SouthWest={SouthWest}";
    }
}
