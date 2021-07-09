using BooksList.Server.Data;
using BooksList.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BooksList.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        BooksListContext _context;
        public StatesController(BooksListContext booksListContext)
        {
            _context = booksListContext;
        }

        // GET: api/<StatusController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var states = await _context.States.ToListAsync();
            return Ok(states);
        }

        // GET api/<StatusController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var books = await _context.States.Where(a => a.IdState == id).Join(_context.Books,
                a => a.IdState,
                b => b.State.IdState,
                (a, b) => new Book(b)).ToListAsync();
            return Ok(books);
        }
        // POST api/<StatusController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StatusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StatusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
