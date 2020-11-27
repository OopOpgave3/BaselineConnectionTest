using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace IntroduktionAspCore_MVC.Models
{
    public class MovieListViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Categories { get; set; }
        public string Genre { get; set; }
        public string SearchString { get; set; }
    }
}