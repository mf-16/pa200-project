using AutoMapper;
using BusinessLayer.DTOs.Author;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;

namespace BusinessLayer.Services;

public class AuthorService : IAuthorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public AuthorService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseAuthorDto> AddAuthorAsync(AddAuthorDto addAuthorDto)
    {
        var author = _mapper.Map<Author>(addAuthorDto);
        await _unitOfWork.AuthorRepository.AddAsync(author);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseAuthorDto>(author);
        return response;
    }

    public async Task<ResponseAuthorDto> GetAuthorByIdAsync(int id)
    {
        var author = await _unitOfWork.AuthorRepository.GetByIdAsync(id);

        if (author == null)
        {
            throw new NotFoundException("Author", id);
        }
        var response = _mapper.Map<ResponseAuthorDto>(author);
        return response;
    }

    public async Task DeleteAuthorAsync(int id)
    {
        var author = await _unitOfWork.AuthorRepository.GetByIdAsync(id);
        if (author == null)
        {
            throw new NotFoundException("Author", id);
        }
        _unitOfWork.AuthorRepository.Delete(author);
        await _unitOfWork.CommitAsync();
    }

    public async Task<ResponseAuthorDto> UpdateAuthorAsync(int id, UpdateAuthorDto updateAuthorDto)
    {
        var author = await _unitOfWork.AuthorRepository.GetByIdAsync(id);

        if (author == null)
        {
            throw new NotFoundException("Author", id);
        }

        _mapper.Map(updateAuthorDto, author);
        _unitOfWork.AuthorRepository.Update(author);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseAuthorDto>(author);
        return response;
    }

    public async Task<IEnumerable<ResponseAuthorDto>> GetAllAuthorsAsync()
    {
        var authors = await _unitOfWork.AuthorRepository.GetAllAsync();
        var response = _mapper.Map<IEnumerable<ResponseAuthorDto>>(authors);
        return response;
    }
}
