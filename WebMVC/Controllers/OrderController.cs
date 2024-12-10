using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models.Order;

namespace WebMVC.Controllers;

[Authorize]
[Route("order")]
public class OrderController : Controller
{
    private readonly IOrderService _orderService;
    private readonly IMapper _mapper;

    public OrderController(IOrderService orderService, IMapper mapper)
    {
        _orderService = orderService;
        _mapper = mapper;
    }

    [HttpGet]
    [Route("create")]
    public IActionResult Create()
    {
        return View(new CreateOrderViewModel());
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> Create(CreateOrderViewModel order)
    {
        if (!ModelState.IsValid)
        {
            return View(order);
        }

        var userIdClaim = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (int.TryParse(userIdClaim, out int userId))
        {
            var createOrderDto = _mapper.Map<CreateOrderDto>(order);
            var orderDto = await _orderService.CreateOrderAsync(userId, createOrderDto);
            var orderViewModel = _mapper.Map<OrderDetailViewModel>(orderDto);
            TempData["Success"] = "Order created successfully!";
            return RedirectToAction("Orders", "Profile", new { id = orderViewModel.Id });
        }

        TempData["Error"] = "An error occurred while creating the order.";
        return View(order);
    }
}
