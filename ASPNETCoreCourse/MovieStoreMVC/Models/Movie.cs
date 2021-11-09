using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.Models
{
    public class Movie
    {

        public int Id { get; set; }

        //Muss-Feld mit höchstens 50 Charakters
        [Required(ErrorMessage = "Bitte gebe einen Tilen für deinen Film ein")]
        [MaxLength(50)]
        public string Title { get; set; }

        //Muss-Feld? mit höchstens 200 Charakters und mindestens 10 Zeichen
        [MaxLength(200)]
        [MinLength(10)]
        public string Description { get; set; }

        [Range(0,20, ErrorMessage = "Der Preis muss zwischen 0 bis 20 Euro liegen")]
        public decimal Price { get; set; }
        


        public GenreTyp Genre { get; set; }
        public enum GenreTyp { Action, Thriller, Drama, Romantic, Horror, Comedy, Animation, Documentary }

    }
}
