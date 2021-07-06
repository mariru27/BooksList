using BooksList.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksList.Server.Data
{
    public class BooksListContext : DbContext
    {
        public BooksListContext(DbContextOptions<BooksListContext> options) : base(options)
        {

        }

        public DbSet<Book> Books;
        public DbSet<State> States;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasOne(e => e.State).WithMany(e => e.Books).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
