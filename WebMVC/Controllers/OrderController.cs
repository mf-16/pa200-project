using System.Security.Claims;
using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebMVC.Models.Order;

namespace WebMVC.Controllers;

[Authorize]
[Route("orders")]
public class OrderController : Controller
{
    private readonly IOrderService _orderService;
    private readonly IMapper _mapper;

    public OrderController(IOrderService orderService, IMapper mapper)
    {
        _orderService = orderService;
        _mapper = mapper;
    }
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Index()
    {
        var orders = await _orderService.GetAllOrdersAsync();
        var mappedOrders = _mapper.Map<List<OrderViewModel>>(orders);
        
        return View(new OrderCompositeViewModel()
        {
            Orders = mappedOrders
        });
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
    [Route("detail/{id:int}")]
    public async Task<IActionResult> OrderDetail(int id)
    {
        var order = await _orderService.GetOrderByIdAsync(id);
        var mappedOrder = _mapper.Map<OrderDetailViewModel>(order);
        return View(mappedOrder);
    }
    

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("edit/{id:int}")]
    public async Task<IActionResult> Edit(int id, EditOrderViewModel editOrderViewModel)
    {
        var orderStateDto = _mapper.Map<OrderStateDto>(editOrderViewModel.OrderState);
        var order = await _orderService.UpdateOrderAsync(id, orderStateDto);
        TempData["Success"] = "Order updated successfully!";
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    [Route("delete/{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _orderService.DeleteOrderAsync(id);
        TempData["Success"] = "Order deleted successfully!";
        return RedirectToAction(nameof(Index));
    }
}

