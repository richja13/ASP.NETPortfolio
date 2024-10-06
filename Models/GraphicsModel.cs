using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("Graphics")]
    public class GraphicsModel
    {
        [Key]
        public int ID;

        public string ImageURL;

        public string GraphicType;
    }
}
