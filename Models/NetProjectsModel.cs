using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Models
{
    [Table("NetProjects")]
    public class NetProjectsModel
    {
        [Key]
        public int ProjectID;

        public string ProjectName;

        public string ProjectDescription;

        public string GithubURL;

        public string ImageURL;
    }
}
