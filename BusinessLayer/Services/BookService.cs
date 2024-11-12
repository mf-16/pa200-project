using AutoMapper;
using BusinessLayer.DTOs.Book;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Enums;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services;

public class BookService : IBookService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public BookService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto)
    {
        var book = _mapper.Map<Book>(addBookDto);
        _unitOfWork.BookRepository.Add(book);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseBookDto>(book);
        return response;
    }

    public async Task<ResponseBookDto> GetBookByIdAsync(int id)
    {
        var book = await _unitOfWork.BookRepository.GetByIdAsync(id);

        if (book == null)
        {
            throw new NotFoundException("Book", id);
        }
        var response = _mapper.Map<ResponseBookDto>(book);
        return response;
    }

    public async Task DeleteBookAsync(int id)
    {
        var book = await _unitOfWork.BookRepository.GetByIdAsync(id);
        if (book == null)
        {
            throw new NotFoundException("Book", id);
        }
        _unitOfWork.BookRepository.Delete(book);
        await _unitOfWork.CommitAsync();
    }

    public async Task<ResponseBookDto> UpdateBookAsync(
        int id,
        UpdateBookDto updateBookDto,
        int? userId
    )
    {
        var book = await _unitOfWork.BookRepository.GetByIdAsync(id);

        if (book == null)
        {
            throw new NotFoundException("Book", id);
        }
        _mapper.Map(updateBookDto, book);

        if (userId != null)
        {
            book.LastEditorId = userId;
            book.EditCount += 1;
        }

        _unitOfWork.BookRepository.Update(book);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseBookDto>(book);
        return response;
    }

    public async Task<IEnumerable<ResponseBookDto>> GetAllBooksAsync()
    {
        var books = await _unitOfWork.BookRepository.GetAllAsync();
        var response = _mapper.Map<IEnumerable<ResponseBookDto>>(books);
        return response;
    }

    public async Task<IEnumerable<ResponseBookDto>> GetFilteredBooksAsync(BookFilterDto filter)
    {
        return await GetBooksAsync(filter);
    }

    private async Task<IEnumerable<ResponseBookDto>> GetBooksAsync(BookFilterDto filter)
    {
        var books = await _unitOfWork.BookRepository.GetAllAsync();
        var query = books.AsQueryable();

        if (!string.IsNullOrEmpty(filter.Name))
        {
            query = query.Where(b => b.Title.Contains(filter.Name));
        }

        if (!string.IsNullOrEmpty(filter.Description))
        {
            query = query.Where(b => b.Description.Contains(filter.Description));
        }

        if (filter.MinPrice.HasValue)
        {
            query = query.Where(b => b.Price >= filter.MinPrice.Value);
        }

        if (filter.MaxPrice.HasValue)
        {
            query = query.Where(b => b.Price <= filter.MaxPrice.Value);
        }

        if (filter.Genre.HasValue)
        {
            query = query.Where(b => b.Genre == filter.Genre.Value);
        }

        if (!string.IsNullOrEmpty(filter.Publisher))
        {
            query = query.Where(b => b.Publisher.Name.Contains(filter.Publisher));
        }

        var filteredBooks = query.ToList();
        return _mapper.Map<IEnumerable<ResponseBookDto>>(filteredBooks);
    }
}
