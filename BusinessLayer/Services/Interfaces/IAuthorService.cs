using BusinessLayer.DTOs.Author;

namespace BusinessLayer.Services.Interfaces;

public interface IAuthorService
{
    Task<IEnumerable<ResponseAuthorDto>> GetAllAuthorsAsync();
    Task<ResponseAuthorDto> GetAuthorByIdAsync(int id);
    Task<ResponseAuthorDto> AddAuthorAsync(AddAuthorDto addAuthorDto);
    Task<ResponseAuthorDto> UpdateAuthorAsync(int id, AddAuthorDto updateAuthorDto);
    Task DeleteAuthorAsync(int id);
}
