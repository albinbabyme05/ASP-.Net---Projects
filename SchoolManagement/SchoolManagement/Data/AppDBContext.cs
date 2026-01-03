using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SchoolManagement.Models;


namespace SchoolManagement.Data
{
    public class AppDBContext : DbContext
    {

        //ctor
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        //create table as  fields
        public DbSet<Students> StudentsDB { get; set; }
    }
}
