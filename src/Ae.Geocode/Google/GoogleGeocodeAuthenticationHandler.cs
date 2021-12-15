using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Ae.Geocode.Google
{
    public sealed class GoogleGeocodeAuthenticationHandler : DelegatingHandler
    {
        private readonly string _apiKey;

        public GoogleGeocodeAuthenticationHandler(string apiKey) => _apiKey = apiKey;

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var uri = new UriBuilder(request.RequestUri);
            uri.Query += (string.IsNullOrWhiteSpace(uri.Query) ? '?' : '&') + "key=" + _apiKey;
            request.RequestUri = uri.Uri;
            return base.SendAsync(request, cancellationToken);
        }
    }
}
