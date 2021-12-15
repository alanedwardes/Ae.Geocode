namespace Ae.Geocode.Google.Entities
{
    public sealed class GeocodeRequest
    {
        public GeocodeRequest((double Latitude, double Longitude) coordinates)
        {
            Coordinates = coordinates;
        }

        public string? Language { get; set; }
        public (double Latitude, double Longitude) Coordinates { get; set; }
    }
}
