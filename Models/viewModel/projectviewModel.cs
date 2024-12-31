using System.ComponentModel.DataAnnotations.Schema;

namespace Hadeelsamer.Models.viewModel
{
    public class projectviewModel
    {

        public int projectViewId { get; set; }
        public int projectID { get; set; }
        [ForeignKey("projectID")]
        public Project Project { get; set; }
        public int TaskId { get; set; }
        [ForeignKey("TaskId")]
        public Task task { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
        public IEnumerable<Project> Projects { get; set; }  
    }
}
