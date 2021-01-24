using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Secretary
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("teachers")]
        public List<Teacher> Teachers { get; set; }
        [JsonPropertyName("classes")]
        public List<Class> Classes { get; set; }
    }
}