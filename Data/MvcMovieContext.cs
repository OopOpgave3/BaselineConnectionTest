using Microsoft.EntityFrameworkCore;
using IntroduktionAspCore_MVC.Models;

namespace IntroduktionAspCore_MVC.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}