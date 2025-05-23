using AutoMapper;
using BusinessLayer.DTOs.Address;
using BusinessLayer.DTOs.Order;
using DataAccessLayer.Model;

namespace BusinessLayer.Mapper;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<(CreateOrderDto createOrderDto, Cart cart), Order>()
            .ForMember(
                dest => dest.BillingAddress,
                opt => opt.MapFrom(src => src.createOrderDto.BillingAddress)
            )
            .ForMember(
                dest => dest.ShippingAddress,
                opt => opt.MapFrom(src => src.createOrderDto.ShippingAddress)
            )
            .ForMember(
                dest => dest.CustomerEmail,
                opt => opt.MapFrom(src => src.createOrderDto.CustomerEmail)
            )
            .ForMember(
                dest => dest.CustomerName,
                opt => opt.MapFrom(src => src.createOrderDto.CustomerName)
            )
            .ForMember(dest => dest.Coupons, opt => opt.MapFrom(src => src.cart.Coupons))
            .ForMember(
                dest => dest.TotalAmount,
                opt =>
                    opt.MapFrom(src =>
                        Math.Max(
                            0,
                            src.cart.CartItems.Sum(i => i.Book.Price * i.Quantity)
                                - src.cart.Coupons.Sum(c => c.GiftCard.PriceReduction)
                        )
                    )
            )
            .ForMember(
                dest => dest.OrderItems,
                opt =>
                    opt.MapFrom(src =>
                        src.cart.CartItems.Select(cartItem => new OrderItem
                            {
                                BookId = cartItem.BookId,
                                Price = cartItem.Book.Price,
                                Quantity = cartItem.Quantity,
                            })
                            .ToList()
                    )
            )
            .ForMember(dest => dest.Coupons, opt => opt.MapFrom(src => src.cart.Coupons))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.cart.UserId));

        CreateMap<Order, ResponseOrderDto>();
        CreateMap<OrderItem, ResponseOrderItemDto>();

        CreateMap<AddressDto, Address>();
        CreateMap<Address, AddressDto>();
        CreateMap<OrderStateDto, OrderState>();
    }
}
