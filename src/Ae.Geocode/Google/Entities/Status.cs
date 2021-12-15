using Ae.StringEnum;
using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    [JsonConverter(typeof(StringEnumConverterFactory))]
    public sealed class Status : StringEnum<Status>
    {
        /// <summary>
        /// Indicates that no errors occurred; the address was successfully parsed and at least one geocode was returned.
        /// </summary>
        public static readonly Status Ok = new("OK");
        /// <summary>
        /// Indicates that the geocode was successful but returned no results. This may occur if the geocoder was passed a non-existent address.
        /// </summary>
        public static readonly Status ZeroResults = new("ZERO_RESULTS");
        /// <summary>
        /// Indicates any of the following: 
        /// * The API key is missing or invalid.
        /// * Billing has not been enabled on your account.
        /// * A self-imposed usage cap has been exceeded.
        /// * The provided method of payment is no longer valid (for example, a credit card has expired).
        /// </summary>
        public static readonly Status OverDailyLimit = new("OVER_DAILY_LIMIT");
        /// <summary>
        /// Indicates that you are over your quota.
        /// </summary>
        public static readonly Status OverQueryLimit = new("OVER_QUERY_LIMIT");
        /// <summary>
        /// Indicates that your request was denied.
        /// </summary>
        public static readonly Status RequestDenied = new("REQUEST_DENIED");
        /// <summary>
        /// Generally indicates that the query (address, components or latlng) is missing.
        /// </summary>
        public static readonly Status InvalidRequest = new("INVALID_REQUEST");
        /// <summary>
        /// Indicates that the request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        public static readonly Status UnknownError = new("UNKNOWN_ERROR");

        public Status(string value) : base(value)
        {
        }
    }
}
