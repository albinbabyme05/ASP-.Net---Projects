using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2_db.Models
{
    [Table("Products")]
    public class Products
    {

        [Key]
        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public string? Description { get; set; }

    
        public decimal Price { get; set; }

        public string? Color { get; set; }


    }
}
