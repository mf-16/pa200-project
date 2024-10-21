using BusinessLayer.DTOs.Book;

namespace BusinessLayer.Services.Interfaces;

public interface IBookService
{
    Task<IEnumerable<ResponseBookDto>> GetAllBooksAsync();
    Task<ResponseBookDto> GetBookByIdAsync(int id);
    Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto);
    Task<ResponseBookDto> UpdateBookAsync(int id, AddBookDto updateBookDto);
    Task DeleteBookAsync(int id);
}
