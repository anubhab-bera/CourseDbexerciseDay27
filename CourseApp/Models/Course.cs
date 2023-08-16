using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseApp.Models
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CId { get; set; }

        [Required]
        public string CName { get; set; }
        [Required]
        public decimal CFee { get; set; }
        public string Status { get; set; }
        public string Technology { get; set; }
    }
}
