using AutoMapper;
using BusinessLayer.DTOs.Genre;
using BusinessLayer.Services.Interfaces;
using Infrastructure.UnitOfWork;

namespace BusinessLayer.Services;

public class GenreService : IGenreService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public GenreService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GenreDto>> GetAllGenresAsync()
    {
        var genres = await _unitOfWork.GenreRepository.GetAllAsync();
        var genreDtos = _mapper.Map<IEnumerable<GenreDto>>(genres);
        return genreDtos;
    }
}