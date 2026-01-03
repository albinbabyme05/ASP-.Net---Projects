using System.Collections.Generic;
using WebApplication2_db.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2_db.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
