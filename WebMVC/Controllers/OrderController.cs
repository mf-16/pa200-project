using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using WebMVC.Models.Order;

namespace WebMVC.Controllers;

[Authorize]
[Route("orders")]
public class OrderController : Controller
{
    private readonly IOrderService _orderService;
    private readonly IMapper _mapper;
    private readonly IMemoryCache _memoryCache;
    private readonly ILogger<OrderController> _logger;

    public OrderController(
        IOrderService orderService,
        IMapper mapper,
        IMemoryCache memoryCache,
        ILogger<OrderController> logger
    )
    {
        _orderService = orderService;
        _mapper = mapper;
        _memoryCache = memoryCache;
        _logger = logger;
    }

    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Index()
    {
        var cacheKey = "Orders";

        if (!_memoryCache.TryGetValue(cacheKey, out List<OrderViewModel>? orders))
        {
            _logger.LogInformation($"Cache miss for {cacheKey} at {DateTime.Now}");
            var ordersDto = await _orderService.GetAllOrdersAsync();
            orders = _mapper.Map<List<OrderViewModel>>(ordersDto);

            _memoryCache.Set(cacheKey, orders, TimeSpan.FromMinutes(10));
        }
        else
        {
            _logger.LogInformation($"Cache hit for {cacheKey} at {DateTime.Now}");
        }

        return View(new OrderCompositeViewModel() { Orders = orders! });
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

            _memoryCache.Remove("Orders");

            TempData["Success"] = "Order created successfully!";
            return RedirectToAction("Orders", "Profile", new { id = orderViewModel.Id });
        }

        TempData["Error"] = "An error occurred while creating the order.";
        return View(order);
    }

    [Route("detail/{id:int}")]
    public async Task<IActionResult> OrderDetail(int id)
    {
        var cacheKey = $"OrderDetail_{id}";
        if (!_memoryCache.TryGetValue(cacheKey, out OrderDetailViewModel? order))
        {
            _logger.LogInformation($"Cache miss for {cacheKey} at {DateTime.Now}");
            var orderDto = await _orderService.GetOrderByIdAsync(id);
            order = _mapper.Map<OrderDetailViewModel>(orderDto);
            _memoryCache.Set(cacheKey, order, TimeSpan.FromMinutes(10));
        }
        else
        {
            _logger.LogInformation($"Cache hit for {cacheKey} at {DateTime.Now}");
        }
        return View(order);
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("edit/{id:int}")]
    public async Task<IActionResult> Edit(int id, EditOrderViewModel editOrderViewModel)
    {
        var orderStateDto = _mapper.Map<OrderStateDto>(editOrderViewModel.OrderState);
        var order = await _orderService.UpdateOrderAsync(id, orderStateDto);

        _memoryCache.Remove($"Orders");
        _memoryCache.Remove($"OrderDetail_{id}");

        TempData["Success"] = "Order updated successfully!";
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("delete/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _orderService.DeleteOrderAsync(id);

        _memoryCache.Remove($"Orders");
        _memoryCache.Remove($"OrderDetail_{id}");

        TempData["Success"] = "Order deleted successfully!";
        return RedirectToAction(nameof(Index));
    }
}
