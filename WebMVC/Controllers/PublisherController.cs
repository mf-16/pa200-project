using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Publisher;

namespace WebMVC.Controllers;

[Route("publishers")]
public class PublisherController : Controller
{
    private readonly IPublisherService _publisherService;
    private readonly IMapper _mapper;

    public PublisherController(IPublisherService publisherService, IMapper mapper)
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

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var publisher = await _publisherService.GetPublisherByIdAsync(id);
            var mappedPublisher = _mapper.Map<PublisherViewModel>(publisher);
            return View(mappedPublisher);
        }
        catch (Exception ex)
        {
            // Log the exception (ex) if necessary
            return NotFound();
        }
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [Authorize(Roles = "Admin")]
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

    [Authorize(Roles = "Admin")]
    [HttpGet("edit/{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        try
        {
            var publisher = await _publisherService.GetPublisherByIdAsync(id);
            var model = _mapper.Map<EditPublisherViewModel>(publisher);
            return View(model);
        }
        catch (Exception ex)
        {
            // Log the exception (ex) if necessary
            return NotFound();
        }
    }

    [Authorize(Roles = "Admin")]
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

    [Authorize(Roles = "Admin")]
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _publisherService.DeletePublisherAsync(id);
        return RedirectToAction("Index");
    }
}
