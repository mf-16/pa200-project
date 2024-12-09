using BusinessLayer.DTOs.Order;

namespace BusinessLayer.Services.Interfaces;

public interface IOrderService
{
    Task<ResponseOrderDto> CreateOrderAsync(CreateOrderDto createOrderDto);
    Task<ResponseOrderDto> GetOrderByIdAsync(int id);
    Task<List<ResponseOrderDto>> GetAllOrdersAsync();
    Task<List<ResponseOrderDto>> GetAllOrdersByUserIdAsync(int userId);
}
