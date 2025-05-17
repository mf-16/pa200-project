using AutoMapper;
using Azure.Storage.Blobs;
using BusinessLayer.DTOs;
using BusinessLayer.DTOs.Book;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BusinessLayer.Services;

public class BookService : IBookService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;
    private readonly BlobServiceClient _blobServiceClient;

    public BookService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration config, BlobServiceClient blobServiceClient)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _config = config;
        _blobServiceClient = blobServiceClient;
    }

    public async Task<ResponseBookDto> AddBookAsync(AddBookDto addBookDto, IFormFile? image = null)
    {
        var book = _mapper.Map<Book>(addBookDto);
        var fileName = "default.jpg";
        if (image != null)
        {
            fileName = await UploadBookImageAsync(image);
        }

        book.ImagePath = fileName;

        _unitOfWork.BookRepository.Add(book);
        await _unitOfWork.CommitAsync();

        return _mapper.Map<ResponseBookDto>(book);
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
        IFormFile? image = null,
        int? userId = null
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
            if (await _unitOfWork.UserRepository.GetByIdAsync(userId.Value) != null)
            {
                book.LastEditorId = userId;
                book.EditCount += 1;
            }
            else
            {
                throw new NotFoundException("User", userId.Value);
            }
        }

        if (image != null)
        {
            var fileName = await UploadBookImageAsync(image);
            book.ImagePath = fileName;
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

    public async Task<PaginatedDto<ResponseBookDto>> GetFilteredBooksAsync(
        BookFilterDto? filter,
        int page = 1,
        int pageSize = 6
    )
    {
        var query = _unitOfWork.BookRepository.GetQueryable();

        if (!string.IsNullOrEmpty(filter.Name))
        {
            query = query.Where(b => b.Title.Contains(filter.Name));
        }

        if (filter.MinPrice.HasValue)
        {
            query = query.Where(b => b.Price >= filter.MinPrice.Value);
        }

        if (filter.MaxPrice.HasValue)
        {
            query = query.Where(b => b.Price <= filter.MaxPrice.Value);
        }

        if (filter.GenreId.HasValue)
        {
            query = query.Where(b => b.PrimaryGenreId == filter.GenreId);
        }

        if (filter.PublisherId.HasValue)
        {
            query = query.Where(b => b.Publisher.Id == filter.PublisherId);
        }
        if (filter.AuthorId.HasValue)
        {
            query = query.Where(b => b.Author.Id == filter.AuthorId);
        }

        var count = query.Count();
        var filteredBooks = await query.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
        var bookDtos = _mapper.Map<IEnumerable<ResponseBookDto>>(filteredBooks);
        return new PaginatedDto<ResponseBookDto>()
        {
            Items = bookDtos,
            CurrentPage = page,
            TotalPages = (int)Math.Ceiling((double)count / pageSize),
        };
    }

    private async Task<string> UploadBookImageAsync(IFormFile image)
    {
        var containerClient = _blobServiceClient.GetBlobContainerClient("$web");
        await containerClient.CreateIfNotExistsAsync();
        var fileName = $"wwwroot/images/{Guid.NewGuid()}_{Path.GetFileName(image.FileName)}";
        var blobClient = containerClient.GetBlobClient(fileName);
        
        using var stream = image.OpenReadStream();
        await blobClient.UploadAsync(stream, overwrite: true);
        
        return "https://pa200hw2storagemf.z1.web.core.windows.net/" + fileName;
    }
}
