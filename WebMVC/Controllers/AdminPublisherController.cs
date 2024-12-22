using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Publisher;

namespace WebMVC.Controllers;

[Route("admin/publishers")]
[Authorize(Roles = "Admin")]
public class AdminPublisherController : Controller
{
    private readonly IPublisherService _publisherService;
    private readonly IMapper _mapper;

    public AdminPublisherController(IPublisherService publisherService, IMapper mapper)
    {
        _publisherService = publisherService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var publishers = await _publisherService.GetAllPublishersAsync();
        var mappedPublishers = _mapper.Map<List<PublisherViewModel>>(publishers);

        return View(mappedPublishers);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public async Task<IActionResult> Create(CreatePublisherViewModel model)
    {
        if (ModelState.IsValid)
        {
            var dto = _mapper.Map<AddPublisherDto>(model);
            await _publisherService.AddPublisherAsync(dto);
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [HttpGet("edit/{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        var publisher = await _publisherService.GetPublisherByIdAsync(id);
        if (publisher == null)
        {
            return NotFound();
        }

        var model = _mapper.Map<EditPublisherViewModel>(publisher);
        return View(model);
    }

    [HttpPost("edit/{id}")]
    public async Task<IActionResult> Edit(int id, EditPublisherViewModel model)
    {
        if (ModelState.IsValid)
        {
            var dto = _mapper.Map<UpdatePublisherDto>(model);
            await _publisherService.UpdatePublisherAsync(id, dto);
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [HttpPost("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _publisherService.DeletePublisherAsync(id);
        return RedirectToAction("Index");
    }
}
