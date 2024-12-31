using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hadeelsamer.Models
{
    public class TeamMamber
    {
        [Key]
        public int TeamMamberId { get; set; }
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(100)]
        
        public string Role { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public IEnumerable<Task> Tasks { get; set; }    
    }
}
