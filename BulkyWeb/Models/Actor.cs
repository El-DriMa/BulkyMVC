using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BulkyWeb.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Surname { get; set; }
        [Required]
        [MaxLength(15)]
        [DisplayName("Name")]
        public string StageName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Biography { get; set; }
    }
}
