using Ae.Geocode.Google.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Ae.Geocode.Google
{
    public sealed class GoogleGeocodeClient : IGoogleGeocodeClient
    {
        private readonly HttpClient _httpClient;

        public GoogleGeocodeClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        private string EncodeQueryComponents(IEnumerable<KeyValuePair<string, string?>> parameters)
        {
            var validParameters = parameters.Where(kvp => kvp.Value != null);
            if (validParameters.Any())
            {
                return '?' + string.Join("&", validParameters.Select(kvp => string.Format("{0}={1}", kvp.Key, HttpUtility.UrlEncode(kvp.Value))));
            }

            return string.Empty;
        }

        public async Task<GeocodeResponse> ReverseGeoCode(GeocodeRequest request, CancellationToken token)
        {
            var parameters = new Dictionary<string, string?>
            {
                { "key", request.ApiKey },
                { "language", request.Language },
                { "latlng", $"{request.Coordinates.Latitude},{request.Coordinates.Longitude}" }
            };

            var requestUri = new Uri($"/maps/api/geocode/json" + EncodeQueryComponents(parameters), UriKind.Relative);
            var response = await _httpClient.GetStreamAsync(requestUri);
            return await JsonSerializer.DeserializeAsync<GeocodeResponse>(response, null, token);
        }
    }
}
