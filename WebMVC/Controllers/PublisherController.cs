using AutoMapper;
using BusinessLayer.Services.Interfaces;
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
        var publisher = await _publisherService.GetPublisherByIdAsync(id);
        if (publisher == null)
        {
            return NotFound();
        }

        var mappedPublisher = _mapper.Map<PublisherViewModel>(publisher);
        return View(mappedPublisher);
    }
}
