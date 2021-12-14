using Ae.Geocode.Google.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Ae.Geocode.Google
{
    public static class GeocodeResponseExtensions
    {
        private static readonly ResultType[] _typesToExclude = new ResultType[]
        {
            ResultType.PlusCode,
            ResultType.PostalCode,
            ResultType.StreetAddress,
            ResultType.StreetNumber,
            ResultType.Route
        };

        public static AddressComponent? GetMostDescriptiveAddressComponent(this GeocodeResult result)
        {
            return result.AddressComponents.FirstOrDefault(x => !_typesToExclude.Any(x.Types.Contains));
        }

        /// <summary>
        /// Attempts to guess the major <see cref="AddressComponent"/> parts of a location.
        /// The first element is most specific, the last element is least specific (typically a country).
        /// </summary>
        public static IEnumerable<GeocodeResult> GuessMajorLocationParts(this GeocodeResponse response)
        {
            var components = new List<GeocodeResult>();

            void AddUniqueComponent(GeocodeResult? geocodeResult)
            {
                var addressComponent = geocodeResult?.AddressComponents.FirstOrDefault();
                if (addressComponent == null || string.IsNullOrWhiteSpace(addressComponent.LongName))
                {
                    return;
                }

                if (components.Any(x => x.AddressComponents.FirstOrDefault().LongName == addressComponent.LongName))
                {
                    return;
                }

                if (!addressComponent.LongName.Any(char.IsLetter))
                {
                    return;
                }

                components.Add(geocodeResult!);
            }

            var addressComponentsWithBounds = response.Results
                .Where(x => x.Geometry?.Bounds != null && !_typesToExclude.Any(x.Types.Contains))
                .OrderBy(x => x.Geometry?.Bounds?.Area);

            foreach (var result in addressComponentsWithBounds)
            {
                AddUniqueComponent(result);
            }

            return components;
        }
    }
}
