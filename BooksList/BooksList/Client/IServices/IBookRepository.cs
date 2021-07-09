using BooksList.Shared.Models;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace BooksList.Client.IServices
{
    public interface IBookRepository
    {
        public List<Book> Books { get; set; }

        public Task GetBooksAsync();
        public Task<List<Book>> GetBooksByIdsAsync(int id);
        public Task<HttpStatusCode> AddBookAsync(Book book);

    }
}
