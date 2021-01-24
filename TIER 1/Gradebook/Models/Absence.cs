using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Absence
    {
        [JsonPropertyName("motivated")]
        public bool Motivated { get; set; }
        [JsonPropertyName("date")]
        public string Date { get; set; }
        [JsonPropertyName("course")]
        public string Course { get; set; }

       
    }
}