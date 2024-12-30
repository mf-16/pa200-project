using AutoMapper;
using BusinessLayer.DTOs.Author;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.Models.Author;

namespace WebMVC.Controllers;

[Authorize]
[Route("authors")]
public class AuthorController : Controller
{
    private readonly IAuthorService _authorService;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _memoryCache;
    private readonly ILogger<AuthorController> _logger;

    public AuthorController(
        IAuthorService authorService,
        IMapper mapper,
        IMemoryCache memoryCache,
        ILogger<AuthorController> logger
    )
    {
        _authorService = authorService;
        _mapper = mapper;
        _memoryCache = memoryCache;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var cacheKey = "Authors";

        if (!_memoryCache.TryGetValue(cacheKey, out List<AuthorViewModel>? mappedAuthors))
        {
            _logger.LogInformation($"Cache miss for {cacheKey} at {DateTime.Now}");
            var authors = await _authorService.GetAllAuthorsAsync();
            mappedAuthors = _mapper.Map<List<AuthorViewModel>>(authors);

            _memoryCache.Set(
                cacheKey,
                mappedAuthors,
                new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromSeconds(30) }
            );
        }
        else
        {
            _logger.LogInformation($"Cache hit for {cacheKey} at {DateTime.Now}");
        }

        return View(mappedAuthors);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("create")]
    public async Task<IActionResult> Create(CreateAuthorViewModel model)
    {
        if (ModelState.IsValid)
        {
            var dto = _mapper.Map<AddAuthorDto>(model);
            await _authorService.AddAuthorAsync(dto);
            _memoryCache.Remove("Authors");
            TempData["Success"] = "Author created successfully!";
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("edit/{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        var author = await _authorService.GetAuthorByIdAsync(id);
        var model = _mapper.Map<UpdateAuthorViewModel>(author);
        return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("edit/{id}")]
    public async Task<IActionResult> Edit(int id, UpdateAuthorViewModel model)
    {
        if (ModelState.IsValid)
        {
            var dto = _mapper.Map<UpdateAuthorDto>(model);
            await _authorService.UpdateAuthorAsync(id, dto);
            _memoryCache.Remove("Authors");
            TempData["Success"] = "Author updated successfully!";
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _authorService.DeleteAuthorAsync(id);
        _memoryCache.Remove("Authors");
        TempData["Success"] = "Author deleted successfully!";
        return RedirectToAction("Index");
    }
}
