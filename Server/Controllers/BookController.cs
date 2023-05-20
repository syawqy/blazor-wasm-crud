using BlazorWebCRUD.Server.Interfaces;
using BlazorWebCRUD.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebCRUD.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBook _IBook;
        public BookController(IBook iBook)
        {
            _IBook = iBook;
        }
        [HttpGet]
        public async Task<List<Book>> Get()
        {
            return await Task.FromResult(_IBook.GetBookDetails());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Book book = _IBook.GetBookData(id);
            if (book != null)
            {
                return Ok(book);
            }
            return NotFound();
        }
        [HttpPost]
        public void Post(Book book)
        {
            _IBook.AddBook(book);
        }
        [HttpPut]
        public void Put(Book book)
        {
            _IBook.UpdateBookDetails(book);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _IBook.DeleteBook(id);
            return Ok();
        }
    }
}
