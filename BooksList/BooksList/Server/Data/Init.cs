using BooksList.Shared.Models;
using System.Linq;
using System.Threading.Tasks;

namespace BooksList.Server.Data
{
    public class Init
    {
        public static async Task InitDatabaseAsync(BooksListContext booksListContext)
        {
            await booksListContext.Database.EnsureCreatedAsync();

            if (booksListContext.States.Any() == false)
            {
                var states = new State[]
                {
                    new State{ StateName = "I want to read"},
                    new State{ StateName = "In progress"},
                    new State{ StateName = "I read"}
                };

                foreach (var state in states)
                {
                    booksListContext.States.Add(state);
                }
                booksListContext.SaveChanges();
            }

        }
    }
}
