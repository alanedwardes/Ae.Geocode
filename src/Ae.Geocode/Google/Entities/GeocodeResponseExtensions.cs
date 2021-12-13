using System.Collections.Generic;
using System.Linq;

namespace Ae.Geocode.Google.Entities
{
    public static class GeocodeResponseExtensions
    {
        public static AddressComponent? GetFirstMatchingAddressComponent(this GeocodeResponse response, ResultType resultType)
        {
            return response.Results.SelectMany(x => x.AddressComponents.Where(y => y.Types.Contains(resultType))).FirstOrDefault();
        }

        public static IEnumerable<AddressComponent> GetSimpleLocation(this GeocodeResponse response)
        {
            var components = new List<AddressComponent>();

            void AddUniqueComponent(AddressComponent? addressComponent)
            {
                if (addressComponent == null || string.IsNullOrWhiteSpace(addressComponent.LongName))
                {
                    return;
                }

                if (components.Any(x => x.LongName == addressComponent.LongName))
                {
                    return;
                }

                if (!addressComponent.LongName.Any(char.IsLetter))
                {
                    return;
                }

                components.Add(addressComponent);
            }

            var typesToExclude = new ResultType[]
            {
                ResultType.PlusCode,
                ResultType.PostalCode,
                ResultType.StreetAddress,
                ResultType.StreetNumber,
                ResultType.Route,
                ResultType.Country // This will be added explicitly
            };

            var addressComponentsWithBounds = response.Results
                .Where(x => x.Geometry.Bounds != null && !typesToExclude.Any(x.Types.Contains))
                .OrderBy(x => x.Geometry.Bounds.Area);

            foreach (var result in addressComponentsWithBounds)
            {
                AddUniqueComponent(result.AddressComponents.FirstOrDefault());
            }

            AddUniqueComponent(response.GetFirstMatchingAddressComponent(ResultType.Country));

            return components;
        }
    }
}
