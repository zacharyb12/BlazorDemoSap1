using System.Text.Json.Serialization;

namespace BlazorDemoSap1.Client.Models
{
    public class MovieApi
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [JsonPropertyName("posterURL")]
        public string PosterUrl { get; set; } = "";

        [JsonPropertyName("imdbId")]
        public string ImdbId { get; set; } = "";
    }
}
