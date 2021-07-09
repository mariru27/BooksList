using BooksList.Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BooksList.Client.ViewModel
{
    public class BookViewModel
    {
        public BookViewModel()
        {

        }

        public BookViewModel(Book book)
        {
            IdBook = book.IdBook;
            Name = book.Name;
            Author = book.Author;
            Description = book.Description;
        }
        [Key]
        public int IdBook { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Author { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public List<State> States { get; set; }
    }
}
