using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string name;
        public string ImageUrl;
        public int level;
    }
}
