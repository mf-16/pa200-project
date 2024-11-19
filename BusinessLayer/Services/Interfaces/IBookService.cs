using BusinessLayer.DTOs.Book;
using BusinessLayer.DTOs.User;
using DataAccessLayer.Enums;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Http;

namespace BusinessLayer.Services.Interfaces;

public interface IBookService
{
    Task<IEnumerable<ResponseBookDto>> GetAllBooksAsync();
    Task<ResponseBookDto> GetBookByIdAsync(int id);
    Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto, IFormFile image);
    Task<ResponseBookDto> UpdateBookAsync(int id, UpdateBookDto updateBookDto, IFormFile image);
    Task DeleteBookAsync(int id);
    Task<IEnumerable<ResponseBookDto>> GetFilteredBooksAsync(BookFilterDto filter);
}
