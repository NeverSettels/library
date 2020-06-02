using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.Authors = new HashSet<AuthorBook>();
      // this.Copies = new HashSet<BookCopy>();
    }
    public int BookId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public ICollection<AuthorBook> Authors { get; set; }
    //   public ICollection<BookCopy> Copies { get; set; }
  }
}
