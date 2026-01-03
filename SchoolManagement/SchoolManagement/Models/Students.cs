using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [StringLength(40)]
        public string? Name { get; set; }

        [Required]
        [Range(5, 100)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(40)]
        public string? Department { get; set; }
    }
}
