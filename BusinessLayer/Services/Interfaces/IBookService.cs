using BusinessLayer.DTOs.Book;
using DataAccessLayer.Model;

namespace BusinessLayer.Services.Interfaces;

public interface IBookService
{
    Task<IEnumerable<ResponseBookDto>> GetAllBooksAsync();
    Task<ResponseBookDto> GetBookByIdAsync(int id);
    Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto);
    Task<ResponseBookDto> UpdateBookAsync(int id, UpdateBookDto updateBookDto);
    Task DeleteBookAsync(int id);
    Task<IEnumerable<ResponseBookDto>> GetBooksAsync(string? name, string? description, decimal? price, BookGenre? genre, string? publisher);
}
