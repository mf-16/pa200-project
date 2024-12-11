using BusinessLayer.DTOs.Genre;

namespace BusinessLayer.Services.Interfaces;

public interface IGenreService
{
    public Task<IEnumerable<GenreDto>> GetAllGenresAsync();
}
