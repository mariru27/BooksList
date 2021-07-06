using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BooksList.Shared.Models
{
    /// <summary>
    ///  A book can have three states
    ///  1 - I want to read
    ///  2 - In progress
    ///  3 - I read
    /// </summary>
    public class State
    {
        [Key]
        public int IdState { get; set; }
        [Required]
        public string StateName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
