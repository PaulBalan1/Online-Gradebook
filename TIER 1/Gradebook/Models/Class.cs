using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication.Models
{
    public class Class
    {
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("letter")]
        public char Letter { get; set; }
        [JsonPropertyName("teacherID")]
        public string TeacherID { get; set; }
        [JsonPropertyName("students")]
        public List<Student> Students { get; set; }
        [JsonPropertyName("courses")]
        
        public List<Course> Courses { get; set; }
    }
}