using System.Text.Json.Serialization;

namespace RSFrontEnd.Models
{
    public class Song
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("artistid")]
        public int ArtistId { get; set; }

        [JsonPropertyName("artist")]
        public Artist Artist { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
        
        [JsonPropertyName("spotifyurl")]
        public string SpotifyUrl { get; set; }
        
        [JsonPropertyName("releasedate")]
        public DateTime ReleaseDate { get; set; }



    }
}
