using AutoMapper;
using BusinessLayer.DTOs.GiftCard;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.GiftCard;

namespace WebMVC.Controllers;

[Route("gift-cards")]
public class GiftCardController : Controller
{
    private readonly IMapper _mapper;
    private readonly IGiftCardService _giftCardService;

    public GiftCardController(IMapper mapper, IGiftCardService giftCardService)
    {
        _mapper = mapper;
        _giftCardService = giftCardService;
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Index()
    {
        var giftCards = await _giftCardService.GetAllGiftCardsAsync();
        var mappedGiftCards = _mapper.Map<List<GiftCardViewModel>>(giftCards);
        return View(mappedGiftCards);
    }
    [HttpGet("create")]
    [Authorize(Roles = "Admin")]
    
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create(CreateGiftCardViewModel model)
    {
        if (ModelState.IsValid)
        {
            var dto = _mapper.Map<CreateGiftCardDto>(model);
            await _giftCardService.CreateGiftCardAsync(dto);
            TempData["Success"] = "Gift card created successfully!";
            return RedirectToAction("Index");
        }

        return View(model);
    }
    
}