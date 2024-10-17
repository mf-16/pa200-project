using AutoMapper;
using BusinessLayer.DTOs.Order;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, ResponseOrderDto>();
        CreateMap<OrderItem, ResponseOrderItemDto>();
    }
}
