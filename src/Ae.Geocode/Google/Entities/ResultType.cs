using Ae.StringEnum;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    /// <summary>
    /// The types[] array in the result indicates the address type.
    /// Examples of address types include a street address, a country,
    /// or a political entity. There is also a types[] array in the
    /// address_components[], indicating the type of each part of the address.
    /// Examples include street number or country. (Below is a full list of types.)
    /// Addresses may have multiple types. The types may be considered 'tags'.
    /// For example, many cities are tagged with the political and the locality type.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverterFactory))]
    public sealed class ResultType : StringEnum<ResultType>
    {
        /// <summary>
        /// Indicates a precise street address.
        /// </summary>
        public static readonly ResultType StreetAddress = new("street_address");
        /// <summary>
        /// Indicates a named route (such as "US 101").
        /// </summary>
        public static readonly ResultType Route = new("route");
        /// <summary>
        /// Indicates a major intersection, usually of two major roads.
        /// </summary>
        public static readonly ResultType Intersection = new("intersection");
        /// <summary>
        /// Indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        /// </summary>
        public static readonly ResultType Political = new("political");
        /// <summary>
        /// Indicates the national political entity, and is typically the highest order type returned by the Geocoder.
        /// </summary>
        public static readonly ResultType Country = new("country");
        /// <summary>
        /// Indicates a first-order civil entity below the country level.
        /// Within the United States, these administrative levels are states.
        /// Not all nations exhibit these administrative levels.
        /// In most cases, administrative_area_level_1 short names will closely 
        /// match ISO 3166-2 subdivisions and other widely circulated lists;
        /// however this is not guaranteed as our geocoding results are based
        /// on a variety of signals and location data.
        /// </summary>
        public static readonly ResultType AdministrativeAreaLevel1 = new("administrative_area_level_1");
        /// <summary>
        /// Indicates a second-order civil entity below the country level.
        /// Within the United States, these administrative levels are counties.
        /// Not all nations exhibit these administrative levels.
        /// </summary>
        public static readonly ResultType AdministrativeAreaLevel2 = new("administrative_area_level_2");
        /// <summary>
        /// Indicates a third-order civil entity below the country level.
        /// This type indicates a minor civil division.
        /// Not all nations exhibit these administrative levels.
        /// </summary>
        public static readonly ResultType AdministrativeAreaLevel3 = new("administrative_area_level_3");
        /// <summary>
        /// Indicates a fourth-order civil entity below the country level.
        /// This type indicates a minor civil division.
        /// Not all nations exhibit these administrative levels.
        /// </summary>
        public static readonly ResultType AdministrativeAreaLevel4 = new("administrative_area_level_4");
        /// <summary>
        /// Indicates a fifth-order civil entity below the country level.
        /// This type indicates a minor civil division.
        /// Not all nations exhibit these administrative levels.
        /// </summary>
        public static readonly ResultType AdministrativeAreaLevel5 = new("administrative_area_level_5");
        /// <summary>
        /// Indicates a commonly-used alternative name for the entity.
        /// </summary>
        public static readonly ResultType ColloquialArea = new("colloquial_area");
        /// <summary>
        /// Indicates an incorporated city or town political entity.
        /// </summary>
        public static readonly ResultType Locality = new("locality");
        /// <summary>
        /// Indicates a first-order civil entity below a locality.
        /// For some locations may receive one of the additional types:
        /// sublocality_level_1 to sublocality_level_5. Each sublocality
        /// level is a civil entity. Larger numbers indicate a smaller geographic area.
        /// </summary>
        public static readonly ResultType Sublocality = new("sublocality");
        /// <summary>
        /// Indicates a named neighborhood.
        /// </summary>
        public static readonly ResultType Neighborhood = new("neighborhood");
        /// <summary>
        /// Indicates a named location, usually a building or collection of buildings
        /// with a common name.
        /// </summary>
        public static readonly ResultType Premise = new("premise");
        /// <summary>
        /// Indicates a first-order entity below a named location, usually a
        /// singular building within a collection of buildings with a common name.
        /// </summary>
        public static readonly ResultType Subpremise = new("subpremise");
        /// <summary>
        /// indicates an encoded location reference, derived from latitude and longitude.
        /// Plus codes can be used as a replacement for street addresses in places where
        /// they do not exist (where buildings are not numbered or streets are not named).
        /// See https://plus.codes for details.
        /// </summary>
        public static readonly ResultType PlusCode = new("plus_code");
        /// <summary>
        /// Indicates a postal code as used to address postal mail within the country.
        /// </summary>
        public static readonly ResultType PostalCode = new("postal_code");
        /// <summary>
        /// Indicates a prominent natural feature.
        /// </summary>
        public static readonly ResultType NaturalFeature = new("natural_feature");
        /// <summary>
        /// Indicates an airport.
        /// </summary>
        public static readonly ResultType Airport = new("airport");
        /// <summary>
        /// Indicates a named park.
        /// </summary>
        public static readonly ResultType Park = new("park");
        /// <summary>
        /// Indicates a named point of interest. Typically, these "POI"s are
        /// prominent local entities that don't easily fit in another category,
        /// such as "Empire State Building" or "Eiffel Tower".
        /// </summary>
        public static readonly ResultType PointOfInterest = new("point_of_interest");
        /// <summary>
        /// Indicates the floor of a building address.
        /// </summary>
        public static readonly ResultType Floor = new("floor");
        /// <summary>
        /// Typically indicates a place that has not yet been categorized.
        /// </summary>
        public static readonly ResultType Establishment = new("establishment");
        /// <summary>
        /// Indicates a nearby place that is used as a reference, to aid navigation.
        /// </summary>
        public static readonly ResultType Landmark = new("landmark");
        /// <summary>
        /// Indicates a parking lot or parking structure.
        /// </summary>
        public static readonly ResultType Parking = new("parking");
        /// <summary>
        /// Indicates a specific postal box.
        /// </summary>
        public static readonly ResultType PostBox = new("post_box");
        /// <summary>
        /// Indicates a grouping of geographic areas, such as locality and
        /// sublocality, used for mailing addresses in some countries.
        /// </summary>
        public static readonly ResultType PostalTown = new("postal_town");
        /// <summary>
        /// Indicates the room of a building address.
        /// </summary>
        public static readonly ResultType Room = new("room");
        /// <summary>
        /// Indicates the precise street number.
        /// </summary>
        public static readonly ResultType StreetNumber = new("street_number");
        /// <summary>
        /// Indicates the location of a bus stop.
        /// </summary>
        public static readonly ResultType BusStation = new("bus_station");
        /// <summary>
        /// Indicates the location of at train station.
        /// </summary>
        public static readonly ResultType TrainStation = new("train_station");
        /// <summary>
        /// Indicates the location of a transit station.
        /// </summary>
        public static readonly ResultType TransitStation = new("transit_station");
        /// <inheritdoc/>
        public ResultType(string value) : base(value)
        {
        }
    }
}
