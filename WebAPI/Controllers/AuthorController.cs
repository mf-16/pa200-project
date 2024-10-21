using System.Threading.Tasks;
using BusinessLayer.DTOs.Author;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllAuthors()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetAuthorById(int id)
        {
            var author = await _authorService.GetAuthorByIdAsync(id);
            if (author == null)
                return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult> AddAuthor([FromBody] AddAuthorDto addAuthorDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var author = await _authorService.AddAuthorAsync(addAuthorDto);
            return CreatedAtAction(nameof(GetAuthorById), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAuthor(int id, [FromBody] AddAuthorDto updateAuthorDto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var author = await _authorService.UpdateAuthorAsync(id, updateAuthorDto);
            if (author == null) return NotFound();
            return Ok(author);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ResponseAuthorDto>> DeleteCartItem(int id)
        {
            await _authorService.DeleteAuthorAsync(id);
            return Ok(new { message = "Author successfully deleted" });
        }
    }
}
