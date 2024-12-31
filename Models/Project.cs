using System.ComponentModel.DataAnnotations;

namespace Hadeelsamer.Models
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public IEnumerable<Task> tasks { get; set; }
    }

}
