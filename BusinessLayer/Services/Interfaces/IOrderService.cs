using BusinessLayer.DTOs.Order;

namespace BusinessLayer.Services.Interfaces;

public interface IOrderService
{
    Task<ResponseOrderDto> CreateOrderAsync(int userId, CreateOrderDto createOrderDto);
    Task<ResponseOrderDto> GetOrderByIdAsync(int id);
    Task<List<ResponseOrderDto>> GetAllOrdersAsync();
    Task<List<ResponseOrderDto>> GetAllOrdersByUserIdAsync(int userId);
}
