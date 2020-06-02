using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Library.Models
{
  public class LibraryContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<AuthorBook> AuthorBook { get; set; }
    public virtual DbSet<Copy> Copies { get; set; }
    public virtual DbSet<BookCopy> BookCopies { get; set; }
    public LibraryContext(DbContextOptions options) : base(options) { }
  }
}