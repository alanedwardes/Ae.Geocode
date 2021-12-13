using Ae.Geocode.Google.Entities;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Ae.Geocode.Tests.Google
{
    public sealed class GoogleGeocodeClientTests
    {
        [Theory]
        [InlineData(1, "Victoria Park,Kingston upon Hull,Hull,England,United Kingdom")]
        [InlineData(2, "Chatsworth House,Chatsworth,Bakewell,Derbyshire Dales District,Derbyshire,England,United Kingdom")]
        [InlineData(3, "Leninsky District,Sevastopol")]
        [InlineData(4, "Southend-on-Sea,England,United Kingdom")]
        [InlineData(5, "Bystrinsky District,Kamchatka Krai,Russia")]
        [InlineData(6, "人和村,Xinyi Township,Nantou County,Taiwan Province,Taiwan")]
        [InlineData(7, "Portobello,Dublin 8,Dublin City,Dublin,County Dublin,Ireland")]
        [InlineData(8, "Tsentar,Sozopol,Burgas,Bulgaria")]
        [InlineData(9, "Hôtel de Ville - Quinconces,Canton de Bordeaux-1,Downtown,Bordeaux,Arrondissement de Bordeaux,Gironde,Nouvelle-Aquitaine,France")]
        [InlineData(10, "Central Park West Historic District,Manhattan,New York County,New York,United States")]
        [InlineData(11, "City of Westminster,London,Greater London,England,United Kingdom")]
        [InlineData(12, "Litton,Skipton,Craven District,North Yorkshire,England,United Kingdom")]
        [InlineData(13, "Lound,Retford,Bassetlaw District,Nottinghamshire,England,United Kingdom")]
        [InlineData(14, "Withern with Stain,Alford,East Lindsey District,Lincolnshire,England,United Kingdom")]
        [InlineData(15, "Samokov Municipality,Sofia Province,Bulgaria")]
        [InlineData(16, "Niagara Falls,Niagara County,New York,United States")]
        [InlineData(17, "Sund,Háaleiti,Reykjavík,Capital Region,Iceland")]
        [InlineData(18, "Western Region,Iceland")]
        [InlineData(19, "Newton Stewart,Dumfries and Galloway,Scotland,United Kingdom")]
        [InlineData(20, "Shetland,Shetland Islands,Scotland,United Kingdom")]
        [InlineData(21, "Gmina Mieleszyn,Gniezno County,Greater Poland Voivodeship,Poland")]
        [InlineData(22, "Maeva,Huahine,Leeward Islands,French Polynesia")]
        [InlineData(23, "Selwyn District,Canterbury,New Zealand")]
        [InlineData(24, "Gisborne,Gisborne District,New Zealand")]
        [InlineData(25, "Hobart,City of Hobart,Tasmania,Australia")]
        [InlineData(26, "Hart,Central Desert Shire,Northern Territory,Australia")]
        [InlineData(27, "Bulunsky District,Sakha Republic,Russia")]
        [InlineData(28, "Antarctica")]
        [InlineData(29, "Cabo de Hornos,Chile")]
        [InlineData(30, "Alofi,Niue")]
        [InlineData(31, "Three Cocks,Gwernyfed,Brecon,Powys,Wales,United Kingdom")]
        [InlineData(32, "Templeton,Narberth,Pembrokeshire,Wales,United Kingdom")]
        [InlineData(33, "Stranocum,Ballymoney,Causeway Coast and Glens,Northern Ireland,United Kingdom")]
        [InlineData(34, "Glengoole South,South Tipperary,County Tipperary,Ireland")]
        [InlineData(35, "Russia")]
        [InlineData(36, "Svalbard")]
        [InlineData(37, "N'Djamena,N'Djaména,Chad")]
        [InlineData(38, "Kitante,Kampala Central Division,Kampala,Kyadondo,Central Region,Uganda")]
        [InlineData(39, "Oraby,Al Azbakeya,Cairo,Cairo Governorate,Egypt")]
        [InlineData(40, "İstiklal,Bursa,Osmangazi,Turkey")]
        [InlineData(41, "Gyan Kunj,Guru Angad Nagar West,Laxmi Nagar,East Delhi,Delhi,India")]
        public async Task Test(int file, string expected)
        {
            using var stream = File.OpenRead("Google/Files/response" + file + ".json");
            var response = await JsonSerializer.DeserializeAsync<GeocodeResponse>(stream, null);
            var components = string.Join(',', response.GetSimpleLocation().Select(x => x.LongName));
            Assert.Equal(expected, components);
        }
    }
}
