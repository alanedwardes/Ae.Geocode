using Ae.Geocode.Google;
using Ae.Geocode.Google.Entities;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Ae.Geocode.Tests.Google
{
    public sealed class GoogleGeocodeClientTests
    {
        private readonly IGoogleGeocodeClient _geocodeClient = new GoogleGeocodeClient(new HttpClient
        {
            BaseAddress = new Uri("https://maps.googleapis.com/")
        });

        private readonly string API_KEY = Environment.GetEnvironmentVariable("GOOGLE_MAPS_API_KEY");

        [Theory]
        [InlineData(53.741697, -0.313853, "Victoria Park,Kingston upon Hull,Hull,England,Great Britain,United Kingdom")]
        [InlineData(53.229116, -1.615255, "Chatsworth House,Chatsworth,Bakewell,Derbyshire Dales District,Derbyshire,England,Great Britain,United Kingdom")]
        [InlineData(44.591133, 33.506989, "Leninsky District,Sevastopol,Crimean Peninsula")]
        [InlineData(51.533317, 0.713909, "Southend-on-Sea,England,Great Britain,United Kingdom")]
        [InlineData(56.413901, 159.294959, "Bystrinsky District,Kamchatka Krai,Russia")]
        [InlineData(23.675719, 120.977318, "人和村,Xinyi Township,Nantou County,Taiwan,Taiwan Province")]
        [InlineData(53.334107, -6.271100, "Portobello,Dublin 8,Dublin City,Dublin,County Dublin,Ireland")]
        [InlineData(42.418829, 27.692754, "Tsentar,Sozopol,Burgas,Bulgaria")]
        [InlineData(44.835961, -0.569279, "Hôtel de Ville - Quinconces,Canton de Bordeaux-1,Downtown,Bordeaux,Arrondissement de Bordeaux,Gironde,Nouvelle-Aquitaine,France")]
        [InlineData(40.782864, -73.965355, "Central Park West Historic District,Manhattan,New York County,New York,United States")]
        [InlineData(51.508873, -0.160518, "City of Westminster,London,Greater London,England,Great Britain,United Kingdom")]
        [InlineData(54.173207, -2.167186, "Litton,Skipton,Craven District,North Yorkshire,England,Great Britain,United Kingdom")]
        [InlineData(53.372927, -0.934697, "Lound,Retford,Bassetlaw District,Nottinghamshire,England,Great Britain,United Kingdom")]
        [InlineData(53.300852, 0.1541388, "Withern with Stain,Alford,East Lindsey District,Lincolnshire,England,Great Britain,United Kingdom")]
        [InlineData(42.356497, 23.383783, "Samokov Municipality,Sofia Province,Bulgaria")]
        [InlineData(43.080720, -79.069865, "Niagara Falls,Niagara County,New York,United States")]
        [InlineData(64.139029, -21.855955, "Sund,Háaleiti,Reykjavík,Capital Region,Iceland")]
        [InlineData(64.600526, -21.063457, "Western Region,Iceland")]
        [InlineData(55.066939, -4.478690, "Newton Stewart,Dumfries and Galloway,Scotland,Great Britain,United Kingdom")]
        [InlineData(60.318686, -1.510724, "Shetland,Shetland Islands,Scotland,United Kingdom")]
        [InlineData(26.714219, -41.772814, "Atlantic Ocean")]
        [InlineData(-16.714647, -151.008915, "Maeva,Huahine,Leeward Islands,French Polynesia")]
        [InlineData(-42.928412, 171.755361, "Selwyn District,Canterbury,New Zealand")]
        [InlineData(-38.661171, 178.022943, "Gisborne,Gisborne District,New Zealand")]
        [InlineData(-42.883679, 147.327609, "Hobart,City of Hobart,Tasmania,Australia")]
        [InlineData(-23.317540, 135.727730, "Hart,Central Desert Shire,Northern Territory,Australia")]
        [InlineData(75.455555, 139.598239, "Bulunsky District,Sakha Republic,Russia")]
        [InlineData(-71.009811, -67.972639, "Antarctica")]
        [InlineData(-56.510591, -68.728173, "Cabo de Hornos,Chile")]
        [InlineData(-19.061144, -169.869073, "Alofi,Niue")]
        [InlineData(52.029149, -3.209366, "Three Cocks,Gwernyfed,Brecon,Powys,Wales,Great Britain,United Kingdom")]
        [InlineData(51.782667, -4.722841, "Templeton,Narberth,Pembrokeshire,Wales,Great Britain,United Kingdom")]
        [InlineData(55.109070, -6.418931, "Stranocum,Ballymoney,Causeway Coast and Glens,Northern Ireland,Ireland,United Kingdom")]
        [InlineData(52.617720, -7.637490, "Glengoole South,South Tipperary,County Tipperary,Ireland")]
        [InlineData(81.408560, 91.242273, "Russia")]
        [InlineData(79.117123, 14.239917, "Svalbard")]
        [InlineData(12.164736, 15.031309, "N'Djamena,N'Djaména,Chad")]
        [InlineData(0.334177, 32.582489, "Kitante,Kampala Central Division,Kampala,Kyadondo,Central Region,Uganda")]
        [InlineData(30.054448, 31.239990, "Oraby,Al Azbakeya,Cairo,Cairo Governorate,Egypt")]
        [InlineData(40.223220, 29.011015, "İstiklal,Bursa,Osmangazi,Turkey")]
        [InlineData(28.640334, 77.281621, "Gyan Kunj,Guru Angad Nagar West,Laxmi Nagar,East Delhi,Delhi,India")]
        public async Task Test(double latitude, double longitude, string expected)
        {
            var location = (latitude, longitude);
            var response = await _geocodeClient.ReverseGeoCode(new GeocodeRequest(API_KEY, location), CancellationToken.None);
            var components = string.Join(',', response.GetSimpleLocation().Select(x => x.LongName));
            Assert.Equal(expected, components);
        }
    }
}
