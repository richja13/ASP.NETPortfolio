using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class UnityProjectsModel
    {
        [Key]
        public int GameID { get; set; }

        public string GameName { get; set; }

        public string GameDescription { get; set; }

        public string YoutubeLink { get; set; }
    }
}
