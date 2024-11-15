using BusinessLayer.DTOs.Book;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Enums;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BooksController(IBookService bookService, IWebHostEnvironment webHostEnvironment)
        {
            _bookService = bookService;
            _webHostEnvironment = webHostEnvironment;
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
        public async Task<IActionResult> AddBookAsync(
            [FromForm] AddBookDto addBookDto,
            IFormFile image
        )
        {
            if (image != null)
            {
                var imagePath = Path.Combine(
                    _webHostEnvironment.WebRootPath,
                    "images",
                    image.FileName
                );
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                addBookDto.ImagePath = Path.Combine("images", image.FileName);
            }

            var book = await _bookService.AddBookAsync(addBookDto);
            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookAsync(
            int id,
            [FromForm] UpdateBookDto updateBookDto,
            IFormFile image
        )
        {
            if (image != null)
            {
                var imagePath = Path.Combine(
                    _webHostEnvironment.WebRootPath,
                    "images",
                    image.FileName
                );
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                updateBookDto.ImagePath = Path.Combine("images", image.FileName);
            }

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
