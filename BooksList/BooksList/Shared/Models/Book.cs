using System.ComponentModel.DataAnnotations;

namespace BooksList.Shared.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
    }
}
