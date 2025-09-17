using System.ComponentModel.DataAnnotations;

namespace db.Models
{
    public class TaskList
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Task")]
        public string task { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}
