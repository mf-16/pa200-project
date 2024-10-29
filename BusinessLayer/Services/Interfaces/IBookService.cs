using BusinessLayer.DTOs.Book;
using DataAccessLayer.Enums;
using DataAccessLayer.Model;

namespace BusinessLayer.Services.Interfaces;

public interface IBookService
{
    Task<IEnumerable<ResponseBookDto>> GetAllBooksAsync();
    Task<ResponseBookDto> GetBookByIdAsync(int id);
    Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto);
    Task<ResponseBookDto> UpdateBookAsync(int id, UpdateBookDto updateBookDto);
    Task DeleteBookAsync(int id);
    Task<IEnumerable<ResponseBookDto>> GetBooksAsync(
        string? name,
        string? description,
        decimal? minPrice,
        decimal? maxPrice,
        BookGenre? genre,
        string? publisher
    );
}
