using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RSFrontEnd.Models
{
    public class Artist
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("imageurl")]
        public string ImageUrl {  get; set; }

        [JsonPropertyName("yearsactive")]
        public int YearsActive { get; set; }

        [JsonPropertyName("albums")]
        public List<Album> Albums { get; set; }

    }
}
