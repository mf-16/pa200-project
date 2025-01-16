using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Book;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Services.Interfaces;

public interface IBookService
{
    Task<IEnumerable<ResponseBookDto>> GetAllBooksAsync();

    Task<ResponseBookDto> GetBookByIdAsync(int id);
    Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto, IFormFile? image = null);
    Task<ResponseBookDto> UpdateBookAsync(
        int id,
        UpdateBookDto updateBookDto,
        IFormFile? image = null,
        int? userId = null
    );
    Task DeleteBookAsync(int id);
    Task<PaginatedDto<ResponseBookDto>> GetFilteredBooksAsync(
        BookFilterDto? filter,
        int page = 1,
        int pageSize = 6
    );
}
