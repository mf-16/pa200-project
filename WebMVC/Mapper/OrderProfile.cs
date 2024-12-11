using AutoMapper;
using BusinessLayer.DTOs.Address;
using BusinessLayer.DTOs.Order;
using WebMVC.Models.Address;
using WebMVC.Models.Order;

namespace WebMVC.Mapper;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<ResponseOrderDto, OrderDetailViewModel>();
        CreateMap<ResponseOrderItemDto, OrderItemViewModel>();
        CreateMap<AddressDto, AddressViewModel>();
        CreateMap<ResponseOrderDto, OrderViewModel>();
        CreateMap<CreateOrderViewModel, CreateOrderDto>();
        CreateMap<CreateAddressViewModel, AddressDto>().ReverseMap();
        CreateMap<OrderStateViewModel,OrderStateDto>().ReverseMap();
    }
}
