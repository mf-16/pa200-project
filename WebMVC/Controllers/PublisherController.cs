﻿using AutoMapper;
using BusinessLayer.DTOs.Publisher;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.Models.Publisher;

namespace WebMVC.Controllers;

[Route("publishers")]
public class PublisherController : Controller
{
    private readonly IPublisherService _publisherService;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _memoryCache;
    private readonly ILogger<PublisherController> _logger;

    public PublisherController(
        IPublisherService publisherService,
        IMapper mapper,
        IMemoryCache memoryCache,
        ILogger<PublisherController> logger
    )
    {
        _publisherService = publisherService;
        _mapper = mapper;
        _memoryCache = memoryCache;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var cacheKey = "Publishers";

        if (!_memoryCache.TryGetValue(cacheKey, out List<PublisherViewModel>? mappedPublishers))
        {
            _logger.LogInformation($"Cache miss for {cacheKey} at {DateTime.Now}");
            var publishers = await _publisherService.GetAllPublishersAsync();
            mappedPublishers = _mapper.Map<List<PublisherViewModel>>(publishers);

            _memoryCache.Set(
                cacheKey,
                mappedPublishers,
                new MemoryCacheEntryOptions { SlidingExpiration = TimeSpan.FromSeconds(30) }
            );
        }
        else
        {
            _logger.LogInformation($"Cache hit for {cacheKey} at {DateTime.Now}");
        }

        return View(mappedPublishers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var publisher = await _publisherService.GetPublisherByIdAsync(id);
        var mappedPublisher = _mapper.Map<PublisherViewModel>(publisher);
        return View(mappedPublisher);
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
            TempData["Success"] = "Publisher created successfully!";
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("edit/{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        var publisher = await _publisherService.GetPublisherByIdAsync(id);
        var model = _mapper.Map<UpdatePublisherViewModel>(publisher);
        return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("edit/{id}")]
    public async Task<IActionResult> Edit(int id, UpdatePublisherViewModel model)
    {
        if (ModelState.IsValid)
        {
            var dto = _mapper.Map<UpdatePublisherDto>(model);
            await _publisherService.UpdatePublisherAsync(id, dto);
            _memoryCache.Remove("Publishers");
            TempData["Success"] = "Publisher updated successfully!";
            return RedirectToAction("Index");
        }

        return View(model);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost("delete/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _publisherService.DeletePublisherAsync(id);
        _memoryCache.Remove("Publishers");
        TempData["Success"] = "Publisher deleted successfully!";
        return RedirectToAction("Index");
    }
}
