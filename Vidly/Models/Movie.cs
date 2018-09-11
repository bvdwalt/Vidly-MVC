using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        
        [Required, Display(Name = "Select Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Number in stock")]
        public byte NumberInStock { get; set; }
    }
}