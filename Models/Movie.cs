using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntroduktionAspCore_MVC.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string MovieTitle { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime MovieReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(1, 2)")]
        public decimal Rating { get; set; }

        [StringLength(30)]
        public string Genre { get; set; }
    }
}
