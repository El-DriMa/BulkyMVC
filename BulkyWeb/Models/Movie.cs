using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Title")]
        public string Title { get; set; }
        [Required]
        [DisplayName("Category")]
        public Category Category { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public List<Actor> Actors { get; set; }
        public int Duration { get; set; } 
        public string Language { get; set; }

    }
}
