using System;
using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Grade
    {
        [JsonPropertyName("grade")]
        public int GradeValue { get; set; }
        [JsonPropertyName("date")]
        public string Date { get; set; }
        [JsonPropertyName("course")]
        public string Course { get; set; }

    }
}