using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Exceptions;
using BusinessLayer.Mapper;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using NSubstitute;

namespace BusinessLayer.Tests.Services;

public class OrderServiceTests
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IOrderService _orderService;

    public OrderServiceTests()
    {
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new OrderProfile());
        });
        var mockMapper = configuration.CreateMapper();
        _unitOfWork = Substitute.For<IUnitOfWork>();
        _orderService = new OrderService(_unitOfWork, mockMapper);
    }

    [Fact]
    public async Task CreateOrderAsync_ShouldThrowNotFoundException_WhenCartNotFound()
    {
        // Arrange
        var createOrderDto = new CreateOrderDto { CartId = 1 };
        _unitOfWork.CartRepository.GetByIdAsync(Arg.Any<int>()).Returns((Cart)null);

        // Act & Assert
        await Assert.ThrowsAsync<NotFoundException>(
            () => _orderService.CreateOrderAsync(createOrderDto)
        );
    }

    [Fact]
    public async Task CreateOrderAsync_ShouldCreateOrder_WhenCartExists()
    {
        // Arrange
        var createOrderDto = new CreateOrderDto { CartId = 1 };
        var cart = new Cart { Id = 1, CartItems = new List<CartItem>() };
        var order = new Order();
        var responseOrderDto = new ResponseOrderDto();

        _unitOfWork.CartRepository.GetByIdAsync(Arg.Any<int>()).Returns(cart);
        _unitOfWork.OrderRepository.When(x => x.Add(Arg.Any<Order>())).Do(x => { });
        _unitOfWork
            .CartItemRepository.When(x => x.DeleteRange(Arg.Any<IEnumerable<CartItem>>()))
            .Do(x => { });
        _unitOfWork.CommitAsync().Returns(Task.CompletedTask);

        var mockMapper = Substitute.For<IMapper>();
        mockMapper.Map<(CreateOrderDto, Cart), Order>((createOrderDto, cart)).Returns(order);
        mockMapper.Map<ResponseOrderDto>(order).Returns(responseOrderDto);

        // Act
        var result = await _orderService.CreateOrderAsync(createOrderDto);

        // Assert
        await _unitOfWork.CartRepository.Received(1).GetByIdAsync(createOrderDto.CartId);
        _unitOfWork.OrderRepository.Received(1).Add(order);
        _unitOfWork.CartItemRepository.Received(1).DeleteRange(cart.CartItems);
        await _unitOfWork.Received(1).CommitAsync();
        Assert.Equal(responseOrderDto, result);
    }

    [Fact]
    public async Task GetOrderByIdAsync_ShouldThrowNotFoundException_WhenOrderNotFound()
    {
        // Arrange
        _unitOfWork.OrderRepository.GetByIdAsync(Arg.Any<int>()).Returns((Order)null);

        // Act & Assert
        await Assert.ThrowsAsync<NotFoundException>(() => _orderService.GetOrderByIdAsync(1));
    }

    [Fact]
    public async Task GetOrderByIdAsync_ShouldReturnOrder_WhenOrderExists()
    {
        // Arrange
        var order = new Order();
        var responseOrderDto = new ResponseOrderDto();

        _unitOfWork.OrderRepository.GetByIdAsync(Arg.Any<int>()).Returns(order);

        var mockMapper = Substitute.For<IMapper>();
        mockMapper.Map<ResponseOrderDto>(order).Returns(responseOrderDto);

        // Act
        var result = await _orderService.GetOrderByIdAsync(1);

        // Assert
        await _unitOfWork.OrderRepository.Received(1).GetByIdAsync(1);
        Assert.Equal(responseOrderDto, result);
    }

    [Fact]
    public async Task GetAllOrdersAsync_ShouldReturnAllOrders()
    {
        // Arrange
        var orders = new List<Order> { new Order(), new Order() };
        var responseOrderDtos = new List<ResponseOrderDto>
        {
            new ResponseOrderDto(),
            new ResponseOrderDto(),
        };

        _unitOfWork.OrderRepository.GetAllAsync().Returns(orders);

        var mockMapper = Substitute.For<IMapper>();
        mockMapper.Map<List<ResponseOrderDto>>(orders).Returns(responseOrderDtos);

        // Act
        var result = await _orderService.GetAllOrdersAsync();

        // Assert
        await _unitOfWork.OrderRepository.Received(1).GetAllAsync();
        Assert.Equal(responseOrderDtos, result);
    }
}
