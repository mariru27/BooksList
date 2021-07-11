using BooksList.Server.Data;
using BooksList.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BooksList.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        BooksListContext _context;
        public BooksController(BooksListContext context)
        {
            _context = context;
        }

        // GET: api/<BooksController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var books = await _context.Books.ToListAsync();
            return Ok(books);
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var book = await _context.Books.FirstOrDefaultAsync(a => a.IdBook == id);
            return Ok(book);
        }

        // POST api/<BooksController>
        [HttpPost]
        public async Task<IActionResult> Post(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return Ok(book.IdBook);
        }

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public async Task PutAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            var book = _context.Books.Where(a => a.IdBook == id).FirstOrDefault();
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}
