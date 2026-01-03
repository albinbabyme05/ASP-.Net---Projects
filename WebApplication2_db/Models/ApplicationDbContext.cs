using Microsoft.EntityFrameworkCore;

namespace WebApplication2_db.Models
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // create table as fields
        public DbSet<User> Users { get; set; }
        public DbSet<Products> Products { get; set; }

    }
}
