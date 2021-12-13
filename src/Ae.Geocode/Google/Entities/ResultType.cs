using Ae.StringEnum;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    [JsonConverter(typeof(StringEnumConverterFactory))]
    public sealed class ResultType : StringEnum<ResultType>
    {
        public static readonly ResultType StreetAddress = new("street_address");
        public static readonly ResultType Route = new("route");
        public static readonly ResultType Intersection = new("intersection");
        public static readonly ResultType Political = new("political");
        public static readonly ResultType Country = new("country");
        public static readonly ResultType AdministrativeAreaLevel1 = new("administrative_area_level_1");
        public static readonly ResultType AdministrativeAreaLevel2 = new("administrative_area_level_2");
        public static readonly ResultType AdministrativeAreaLevel3 = new("administrative_area_level_3");
        public static readonly ResultType AdministrativeAreaLevel4 = new("administrative_area_level_4");
        public static readonly ResultType AdministrativeAreaLevel5 = new("administrative_area_level_5");
        public static readonly ResultType ColloquialArea = new("colloquial_area");
        public static readonly ResultType Locality = new("locality");
        public static readonly ResultType Sublocality = new("sublocality");
        public static readonly ResultType Neighborhood = new("neighborhood");
        public static readonly ResultType Premise = new("premise");
        public static readonly ResultType Subpremise = new("subpremise");
        public static readonly ResultType PlusCode = new("plus_code");
        public static readonly ResultType PostalCode = new("postal_code");
        public static readonly ResultType NaturalFeature = new("natural_feature");
        public static readonly ResultType Airport = new("airport");
        public static readonly ResultType Park = new("park");
        public static readonly ResultType PointOfInterest = new("point_of_interest");
        public static readonly ResultType Floor = new("floor");
        public static readonly ResultType Establishment = new("establishment");
        public static readonly ResultType Landmark = new("landmark");
        public static readonly ResultType Parking = new("parking");
        public static readonly ResultType PostBox = new("post_box");
        public static readonly ResultType PostalTown = new("postal_town");
        public static readonly ResultType Room = new("room");
        public static readonly ResultType StreetNumber = new("street_number");
        public static readonly ResultType BusStation = new("bus_station");
        public static readonly ResultType TrainStation = new("train_station");
        public static readonly ResultType TransitStation = new("transit_station");

        public ResultType(string value) : base(value)
        {
        }
    }
}
