using AutoMapper;
using BusinessLayer.DTOs.Book;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Models.Book;

namespace WebMVC.Controllers;

[Route("books")]
public class BookController : Controller
{
    private readonly IBookService _bookService;
    private readonly IMapper _mapper;

    public BookController(IBookService bookService, IMapper mapper)
    {
        _bookService = bookService;
        _mapper = mapper;
    }

    public async Task<IActionResult> Index(
        BookFilterViewModel filter,
        int page = 1,
        int pageSize = 6
    )
    {
        var filterDto = _mapper.Map<BookFilterDto>(filter);
        var books = await _bookService.GetFilteredBooksAsync(filterDto, page, pageSize);
        var paginatedViewModel = _mapper.Map<PaginatedViewModel<BookViewModel>>(books);

        return View(
            new BookCompositeViewModel() { Pagination = paginatedViewModel, Filters = filter }
        );
    }

    [Route("detail/{id}")]
    public async Task<IActionResult> Detail(int id)
    {
        var bookDto = await _bookService.GetBookByIdAsync(id);
        var bookDetailViewModel = _mapper.Map<BookDetailViewModel>(bookDto);
        return View(bookDetailViewModel);
    }
}
