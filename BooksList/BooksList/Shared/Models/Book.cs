using System.ComponentModel.DataAnnotations;

namespace BooksList.Shared.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public State State { get; set; }
    }
}
