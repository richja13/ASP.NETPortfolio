using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("UnityProjects")]
    public class UnityProjectsModel
    {
        [Key]
        public int GameID { get; set; }

        public string GameName { get; set; }

        public string GameDescription { get; set; }

        public string YoutubeLink { get; set; }
    }
}
