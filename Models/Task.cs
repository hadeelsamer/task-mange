using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hadeelsamer.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }
         public string Title { get; set; }
        [MaxLength(100)]
        public DateTime Deadline { get; set; }
        public string status { get; set; }
        public string Description { get; set; }
        [MaxLength (500)]
        public string Priority { get; set; }    
        public int projectID { get; set; }
        [ForeignKey("projectID")]
       public Project Project { get; set; } 
        public int TeamMemberId {  get; set; }
        [ForeignKey("TeamMemberId")]
        public TeamMamber TeamMamber { get; set; }


    }
}
