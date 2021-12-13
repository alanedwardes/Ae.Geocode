namespace Ae.Geocode.Google.Entities
{
    public sealed class GeocodeRequest
    {
        public GeocodeRequest(string apiKey, (double Latitude, double Longitude) coordinates)
        {
            ApiKey = apiKey;
            Coordinates = coordinates;
        }

        public string ApiKey { get; set; }
        public string? Language { get; set; }
        public (double Latitude, double Longitude) Coordinates { get; set; }
    }
}
