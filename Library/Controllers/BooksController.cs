using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Library.Models;
using System;

namespace Library.Controllers
{
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;

    public BooksController(LibraryContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Book> model = _db.Books.ToList();
      return View(model);
    }
    public ActionResult Create()
    {
      ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "Name");
      ViewBag.Authors = _db.Authors.ToList();
      return View();
    }

    [HttpPost]
    public ActionResult Create(Book book, int AuthorId)
    {
      if (AuthorId != 0)
      {
        _db.Books.Add(book);
        _db.SaveChanges();
      }

      Book newBook = _db.Books.FirstOrDefault(b => (b.Title == book.Title));
      _db.AuthorBook.Add(new AuthorBook() { AuthorId = AuthorId, BookId = newBook.BookId });
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisBook = _db.Books
      .Include(book => book.Authors)
      .ThenInclude(join => join.Author)
      .FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    public ActionResult CreateCopy(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(b => b.BookId == id);
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult CreateCopy(Copy copy, int BookId)
    {
      _db.Copies.Add(copy);
      _db.SaveChanges();
      var newCopy = _db.Copies.FirstOrDefault(c => c.BookId == copy.BookId);
      _db.BookCopies.Add(newCopy);

    }
  }
}