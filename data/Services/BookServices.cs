using BookLibraryApi.data.models;
using BookLibraryApi.data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.data.Services
{
    public class BookServices
    {
        private AppDbContext _context;
        public BookServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Authour = book.Authour,
                ReleaseDate = book.ReleaseDate,
                Category = book.Category,

            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks() => _context.Books.ToList();

        public Book GetBookById(Guid bookId) => _context.Books.FirstOrDefault(n => n.BookId == bookId);

        public Book UpdateBookById(Guid bookId, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.BookId == bookId);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Authour = book.Authour;
                _book.ReleaseDate = book.ReleaseDate;
                _book.Category = book.Category;

                _context.SaveChanges();
            }
            return _book;

        }
        public void DeleteBook(Guid bookId)
        {
            var _book = _context.Books.FirstOrDefault(n => n.BookId == bookId);
            if (_book != null)
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }

        }

    }

    
}
