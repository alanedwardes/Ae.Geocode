using System.Text.Json.Serialization;

namespace Ae.Geocode.Google.Entities
{
    public sealed class PlusCode
    {
        [JsonPropertyName("compound_code")]
        public string CompoundCode { get; set; }
        [JsonPropertyName("global_code")]
        public string GlobalCode { get; set; }
        public override string ToString() => $"CompoundCode={CompoundCode},GlobalCode={GlobalCode}";
    }
}
