using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("Skills")]
    public class SkillModel
    {
        [Key]
        public int ID;

        public string ImageURL;

        public string SkillName;

        public int SkillLevel;
    }
}
