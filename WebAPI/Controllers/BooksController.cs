using BusinessLayer.DTOs.Book;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Enums;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllBooks()
        {
            var books = await _bookService.GetAllBooksAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetBookById(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult> AddBook([FromBody] AddBookDto addBookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = await _bookService.AddBookAsync(addBookDto);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBook(int id, [FromBody] UpdateBookDto updateBookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = await _bookService.UpdateBookAsync(id, updateBookDto);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _bookService.DeleteBookAsync(id);
            return Ok(new { message = "Book successfully deleted" });
        }

        [HttpGet("search")]
        public async Task<IActionResult> GetBooks([FromQuery] BookFilterDto request)
        {
            var filter = new BookFilterDto
            {
                Name = request.Name,
                Description = request.Description,
                MinPrice = request.MinPrice,
                MaxPrice = request.MaxPrice,
                Genre = request.Genre,
                Publisher = request.Publisher,
            };

            var books = await _bookService.GetFilteredBooksAsync(filter);
            return Ok(books);
        }
    }
}
