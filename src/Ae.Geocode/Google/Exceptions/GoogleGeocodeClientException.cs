using System;

namespace Ae.Geocode.Google.Exceptions
{
    public sealed class GoogleGeocodeClientException : Exception
    {
        public GoogleGeocodeClientException(string message) : base(message)
        {

        }
    }
}
