using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;

namespace BusinessLayer.Services;

public class OrderService : IOrderService
{
    private IUnitOfWork _unitOfWork;
    private IMapper _mapper;

    public OrderService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseOrderDto> CreateOrderAsync(CreateOrderDto createOrderDto)
    {
        var cart = await _unitOfWork.CartRepository.GetByIdAsync(createOrderDto.CartId);
        if (cart is null)
            throw new NotFoundException("Cart", createOrderDto.CartId);
        var order = MapAddOrderDtoToOrder(createOrderDto, cart);
        await _unitOfWork.OrderRepository.AddAsync(order);
        _unitOfWork.CartItemRepository.DeleteRange(cart.CartItems);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseOrderDto>(order);
    }

    public async Task<ResponseOrderDto> GetOrderByIdAsync(int id)
    {
        var order = await _unitOfWork.OrderRepository.GetByIdAsync(id);
        if (order is null)
            throw new NotFoundException("Order", id);
        return _mapper.Map<ResponseOrderDto>(order);
    }

    public async Task<List<ResponseOrderDto>> GetAllOrdersAsync()
    {
        return _mapper.Map<List<ResponseOrderDto>>(await _unitOfWork.OrderRepository.GetAllAsync());
    }

    private Order MapAddOrderDtoToOrder(CreateOrderDto createOrderDto, Cart cart)
    {
        var order = new Order()
        {
            BillingAddress = createOrderDto.BillingAddress,
            ShippingAddress = createOrderDto.ShippingAddress,
            CustomerEmail = createOrderDto.CustomerEmail,
            CustomerName = createOrderDto.CustomerName,
            TotalAmount = cart.CartItems.Sum(i => i.Book.Price * i.Quantity),
            OrderItems = new List<OrderItem>(),
            UserId = cart.UserId,
        };
        foreach (var cartItem in cart.CartItems)
        {
            var orderItem = new OrderItem()
            {
                BookId = cartItem.BookId,
                OrderId = order.Id,
                Price = cartItem.Book.Price,
                Quantity = cartItem.Quantity,
            };
            order.OrderItems.Add(orderItem);
        }

        return order;
    }
}
