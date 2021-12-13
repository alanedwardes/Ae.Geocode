using Ae.Geocode.Google.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Ae.Geocode.Google
{
    public interface IGoogleGeocodeClient
    {
        Task<GeocodeResponse> ReverseGeoCode(GeocodeRequest request, CancellationToken token);
    }
}