using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreRazorPage.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Description { get; set; }

        [Range(0,20)]
        public decimal Price { get; set; }

        [Required]
        public GenreTyp Genre { get; set; }
        public enum GenreTyp { Action, Thriller, Drama, Romantic, Horror, Comedy, Animation, Documentary }
    }


    
}
