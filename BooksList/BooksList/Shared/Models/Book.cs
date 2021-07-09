using System.ComponentModel.DataAnnotations;

namespace BooksList.Shared.Models
{
    public class Book
    {
        public Book()
        {

        }

        public Book(Book book)
        {
            IdBook = book.IdBook;
            Name = book.Name;
            Author = book.Author;
            Description = book.Description;
            State = book.State;
        }

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
