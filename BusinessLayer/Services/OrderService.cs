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

    public async Task<ResponseOrderDto> CreateOrderAsync(int userId, CreateOrderDto createOrderDto)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user is null)
        {
            throw new NotFoundException("User", userId);
        }

        var order = _mapper.Map<(CreateOrderDto, Cart), Order>((createOrderDto, user.Cart));
        _unitOfWork.OrderRepository.Add(order);
        _unitOfWork.CartItemRepository.DeleteRange(user.Cart.CartItems);
        _unitOfWork.CouponRepository.DeleteRange(user.Cart.Coupons);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseOrderDto>(order);
    }

    public async Task<ResponseOrderDto> GetOrderByIdAsync(int id)
    {
        var order = await _unitOfWork.OrderRepository.GetByIdAsync(id);
        if (order is null)
        {
            throw new NotFoundException("Order", id);
        }
        return _mapper.Map<ResponseOrderDto>(order);
    }

    public async Task<List<ResponseOrderDto>> GetAllOrdersAsync()
    {
        return _mapper.Map<List<ResponseOrderDto>>(await _unitOfWork.OrderRepository.GetAllAsync());
    }

    public async Task<ResponseOrderDto> UpdateOrderAsync(int id, OrderStateDto newStateDto)
    {
        var order = await _unitOfWork.OrderRepository.GetByIdAsync(id);
        if (order is null)
        {
            throw new NotFoundException("Order", id);
        }
        var newState = _mapper.Map<OrderState>(newStateDto);
        order.OrderState = newState;
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseOrderDto>(order);
    }

    public async Task DeleteOrderAsync(int id)
    {
        var order = await _unitOfWork.OrderRepository.GetByIdAsync(id);
        if (order is null)
        {
            throw new NotFoundException("Order", id);
        }
        _unitOfWork.OrderRepository.Delete(order);

        await _unitOfWork.CommitAsync();
    }

    public async Task<List<ResponseOrderDto>> GetAllOrdersByUserIdAsync(int userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException("User", userId);
        }
        return _mapper.Map<List<ResponseOrderDto>>(user.Orders);
    }
}
