using Microsoft.EntityFrameworkCore;
using IntroduktionAspCore_MVC.Models;

namespace MvcMovie.Data
{
    public class IntroduktionAspCore_MVC : DbContext
    {
        public IntroduktionAspCore_MVC(DbContextOptions<IntroduktionAspCore_MVC> options) : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}