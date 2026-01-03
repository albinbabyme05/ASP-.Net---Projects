using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2_db.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        [MaxLength(40)]
        public string? Name  { get; set; }

        [MaxLength(40)]
        public string?  Email { get; set; }

        [MaxLength(20)]
        public string? Role { get; set; }

        [MaxLength(40)]
        public string? Passwordss { get; set; }

    }
}
