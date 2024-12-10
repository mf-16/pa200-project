using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BusinessLayer.DTOs.Order;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using NSubstitute;
using Xunit;

namespace BusinessLayer.Tests.Services
{
    public class OrderServiceTests
    {
        private readonly IOrderService _orderService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrderServiceTests()
        {
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _mapper = Substitute.For<IMapper>();
            _orderService = new OrderService(_unitOfWork, _mapper);
        }

        [Fact]
        public async Task GetAllOrdersAsync_ShouldReturnAllOrders()
        {
            // Arrange
            var orders = new List<Order>
            {
                new Order { Id = 1, CustomerName = "John Doe" },
                new Order { Id = 2, CustomerName = "Jane Doe" },
            };
            var responseOrders = new List<ResponseOrderDto>
            {
                new ResponseOrderDto { Id = 1, CustomerName = "John Doe" },
                new ResponseOrderDto { Id = 2, CustomerName = "Jane Doe" },
            };
            _unitOfWork.OrderRepository.GetAllAsync().Returns(orders);
            _mapper.Map<List<ResponseOrderDto>>(orders).Returns(responseOrders);

            // Act
            var result = await _orderService.GetAllOrdersAsync();

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("John Doe", result[0].CustomerName);
        }

        [Fact]
        public async Task GetOrderByIdAsync_ShouldReturnOrder_WhenOrderExists()
        {
            // Arrange
            var order = new Order
            {
                Id = 1,
                CustomerName = "John Doe",
                OrderItems = new List<OrderItem>(),
            };
            var responseOrder = new ResponseOrderDto
            {
                Id = 1,
                CustomerName = "John Doe",
                OrderItems = new List<ResponseOrderItemDto>(),
            };
            _unitOfWork.OrderRepository.GetByIdAsync(1).Returns(order);
            _mapper.Map<ResponseOrderDto>(order).Returns(responseOrder);

            // Act
            var result = await _orderService.GetOrderByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("John Doe", result.CustomerName);
            Assert.Empty(result.OrderItems);
        }

        [Fact]
        public async Task CreateOrderAsync_ShouldCreateOrder_WhenCartExists()
        {
            // Arrange
            var createOrderDto = new CreateOrderDto { CustomerName = "John Doe" };
            var cart = new Cart { Id = 1, CartItems = new List<CartItem>() };
            var user = new User { Id = 1, Cart = cart };
            var order = new Order { Id = 1, CustomerName = "John Doe" };
            var responseOrder = new ResponseOrderDto { Id = 1, CustomerName = "John Doe" };

            _unitOfWork.UserRepository.GetByIdAsync(1).Returns(user);
            _mapper.Map<(CreateOrderDto, Cart), Order>((createOrderDto, cart)).Returns(order);
            _mapper.Map<ResponseOrderDto>(order).Returns(responseOrder);

            // Act
            var result = await _orderService.CreateOrderAsync(user.Id, createOrderDto);

            // Assert
            _unitOfWork
                .OrderRepository.Received(1)
                .Add(Arg.Is<Order>(o => o.CustomerName == "John Doe"));
            await _unitOfWork.Received(1).CommitAsync();
            Assert.Equal("John Doe", result.CustomerName);
        }
    }
}
