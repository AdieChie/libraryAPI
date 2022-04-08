using BookLibraryApi.data.Services;
using BookLibraryApi.data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public BookServices _bookServices;
        public BookController(BookServices bookServices)
        {
            _bookServices = bookServices;
        }
        [HttpPost("Add-Book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _bookServices.AddBook(book);
            return Ok();
        }

        [HttpGet("Get-All-Books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookServices.GetAllBooks();
            return Ok(allBooks);
        }

        [HttpGet("Get-Book-By-id/{id}")]
        public IActionResult GetAllBooks(Guid id)
        {
            var book = _bookServices.GetBookById(id);
            return Ok(book);
        }

        [HttpPut("Update- Book -By-Id/{id}")]
        public IActionResult UpdateBookById(Guid id,[FromBody]BookVM book)
        {
            var updatedBook = _bookServices.UpdateBookById(id, book);
            return Ok(updatedBook);
        }

        [HttpDelete("Delete-Book/{id}")]
        public IActionResult DeleteBook(Guid id)
        {
            _bookServices.DeleteBook(id);
                return Ok();
        }
    }
}
