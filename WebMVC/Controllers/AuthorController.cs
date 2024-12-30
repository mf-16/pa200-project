using AutoMapper;
using BusinessLayer.DTOs.Author;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Author;

namespace WebMVC.Controllers;

[Route("authors")]
public class AuthorController : Controller
{
    private readonly IAuthorService _authorService;
    private readonly IMapper _mapper;

    public AuthorController(IAuthorService authorService, IMapper mapper)
    {
        _authorService = authorService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var authors = await _authorService.GetAllAuthorsAsync();
        var mappedAuthors = _mapper.Map<List<AuthorViewModel>>(authors);

        return View(mappedAuthors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var author = await _authorService.GetAuthorByIdAsync(id);
        var mappedAuthor = _mapper.Map<AuthorViewModel>(author);
        return View(mappedAuthor);
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
        TempData["Success"] = "Author deleted successfully!";
        return RedirectToAction("Index");
    }
}
