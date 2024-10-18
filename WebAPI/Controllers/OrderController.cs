using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost]
    public async Task<ActionResult<ResponseOrderDto>> AddOrder(
        [FromBody] CreateOrderDto createOrderDto
    )
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);
        var response = await _orderService.CreateOrderAsync(createOrderDto);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Order>>> GetAll()
    {
        return Ok(await _orderService.GetAllOrdersAsync());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Order>> GetById(int id)
    {
        return Ok(await _orderService.GetOrderByIdAsync(id));
    }
}
