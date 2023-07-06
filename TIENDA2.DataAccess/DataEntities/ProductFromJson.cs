using System.Text.Json.Serialization;

namespace TIENDA2.DataAccess.DataEntities
{
    public class ProductFromJson
    {
        [JsonPropertyName("id")]
        public int? Id { get; set; }

        [JsonPropertyName("price")]
        public decimal? Price { get; set; }

        [JsonPropertyName("rate")]
        public int? Rate { get; set; }

        [JsonPropertyName("discontinued")]
        public string? Discontinued { get; set; }
    }
}
