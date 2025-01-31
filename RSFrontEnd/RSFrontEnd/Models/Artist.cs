using RSFrontEnd.Models.Validators;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace RSFrontEnd.Models
{
    public class Artist
    {

        [JsonPropertyName("id")]
        public int Id { get; set; }


        [Required(ErrorMessage = "Artist name is required")]
        [JsonPropertyName("name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Image UrL is required"), ValidUrlAttribute]
        [JsonPropertyName("imageurl")]
        public string ImageUrl {  get; set; }


        [Required(ErrorMessage = "Years active is required")]
        [Range(1, 60, ErrorMessage ="Years active must be greater than 0")]
        [JsonPropertyName("yearsactive")]
        public int YearsActive { get; set; }


        [JsonPropertyName("songs")]
        public List<Song> Songs { get; set; }
        
        
        [JsonPropertyName("genres")]
        public List<Genre> Genres { get; set; }

    }
}
