using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Course
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}