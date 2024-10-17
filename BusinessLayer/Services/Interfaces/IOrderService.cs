using BusinessLayer.DTOs.Order;

namespace BusinessLayer.Services.Interfaces;

public interface IOrderService
{
    Task<ResponseOrderDto> AddOrderAsync(AddOrderDto addOrderDto);
    Task<ResponseOrderDto> GetOrderByIdAsync(int id);
    Task<List<ResponseOrderDto>> GetAllOrdersAsync();
}
