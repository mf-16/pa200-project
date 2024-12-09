using AutoMapper;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.Exceptions;
using BusinessLayer.Mapper;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Data;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using NSubstitute;

namespace BusinessLayer.Tests.Services;

public class CartItemServiceTests
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICartItemService _cartItemService;

    public CartItemServiceTests()
    {
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new CartItemProfile());
        });
        var mockMapper = configuration.CreateMapper();
        _unitOfWork = Substitute.For<IUnitOfWork>();
        _cartItemService = new CartItemService(_unitOfWork, mockMapper);
    }

    [Fact]
    public async Task CreateCartItemAsync_ShouldCreateNewOrder()
    {
        // Arrange
        var cartItemDto = new CreateCartItemDto()
        {
            BookId = 1,
            Quantity = 5,
        };
        
        var mockCart = new Cart { Id = 1, UserId = 1 }; 
        var mockUser = new User { Id = 1, Cart = mockCart };

        _unitOfWork.BookRepository.GetByIdAsync(Arg.Any<int>()).Returns(new Book());
        _unitOfWork.UserRepository.GetByIdAsync(Arg.Any<int>()).Returns(mockUser);

        // Act
        var result = await _cartItemService.CreateCartItemAsync(mockUser.Id, cartItemDto);

        // Assert
        await _unitOfWork.BookRepository.Received(1).GetByIdAsync(cartItemDto.BookId);

        _unitOfWork
            .CartItemRepository.Received(1)
            .Add(
                Arg.Is<CartItem>(ci =>
                    ci.BookId == cartItemDto.BookId
                    && ci.CartId == mockCart.Id
                    && ci.Quantity == cartItemDto.Quantity
                )
            );

        await _unitOfWork.Received(1).CommitAsync();

        Assert.Equal(cartItemDto.Quantity, result.Quantity);
    }

    [Fact]
    public async Task CreateCartItemAsync_ShouldThrowException_WhenBookNotFound()
    {
        // Arrange
        var cartItemDto = new CreateCartItemDto()
        {
            BookId = 1,
            Quantity = 5,
        };

        _unitOfWork.UserRepository.GetByIdAsync(Arg.Any<int>()).Returns(new User()
        {
            Id = 1,
        });
        _unitOfWork.BookRepository.GetByIdAsync(Arg.Any<int>()).Returns((Book?)null);

        // Act
        // Assert
        await Assert.ThrowsAsync<NotFoundException>(
            async () => await _cartItemService.CreateCartItemAsync(1, cartItemDto)
        );
    }

    [Fact]
    public async Task UpdateCartItemAsync_ShouldUpdateCartItemQuantity()
    {
        // Arrange
        int cartItemId = 1;
        var updateCartItemDto = new UpdateCartItemDto { Quantity = 10 };

        var existingCartItem = new CartItem
        {
            Id = cartItemId,
            BookId = 1,
            CartId = 1,
            Quantity = 5,
        };

        _unitOfWork.CartItemRepository.GetByIdAsync(cartItemId).Returns(existingCartItem);

        // Act
        var result = await _cartItemService.UpdateCartItemAsync(cartItemId, updateCartItemDto);

        // Assert
        await _unitOfWork.CartItemRepository.Received(1).GetByIdAsync(cartItemId);

        Assert.Equal(updateCartItemDto.Quantity, existingCartItem.Quantity);

        _unitOfWork
            .CartItemRepository.Received(1)
            .Update(
                Arg.Is<CartItem>(ci =>
                    ci.Id == cartItemId && ci.Quantity == updateCartItemDto.Quantity
                )
            );

        await _unitOfWork.Received(1).CommitAsync();

        Assert.Equal(updateCartItemDto.Quantity, result.Quantity);
    }

    [Fact]
    public async Task UpdateCartItemAsync_ShouldThrowException_WhenBookNotFound()
    {
        var cartItemId = 1;
        // Arrange
        var cartItemDto = new UpdateCartItemDto() { Quantity = 5 };

        _unitOfWork.BookRepository.GetByIdAsync(Arg.Any<int>()).Returns((Book?)null);

        // Act
        // Assert
        await Assert.ThrowsAsync<NotFoundException>(
            async () => await _cartItemService.UpdateCartItemAsync(cartItemId, cartItemDto)
        );
    }

    [Fact]
    public async Task DeleteCartItemAsync_ShouldDeleteCartItem()
    {
        // Arrange
        int cartItemId = 1;
        var existingCartItem = new CartItem
        {
            Id = cartItemId,
            BookId = 1,
            CartId = 1,
            Quantity = 5,
        };

        _unitOfWork.CartItemRepository.GetByIdAsync(cartItemId).Returns(existingCartItem);

        // Act
        await _cartItemService.DeleteCartItemAsync(cartItemId);

        // Assert
        await _unitOfWork.CartItemRepository.Received(1).GetByIdAsync(cartItemId);
        _unitOfWork
            .CartItemRepository.Received(1)
            .Delete(Arg.Is<CartItem>(ci => ci.Id == cartItemId));
        await _unitOfWork.Received(1).CommitAsync();
    }

    [Fact]
    public async Task DeleteCartItemAsync_ShouldThrowException_WhenCartItemNotFound()
    {
        var cartItemId = 1;
        _unitOfWork.CartItemRepository.GetByIdAsync(Arg.Any<int>()).Returns((CartItem?)null);

        // Act
        // Assert
        await Assert.ThrowsAsync<NotFoundException>(
            async () => await _cartItemService.DeleteCartItemAsync(cartItemId)
        );
    }

    [Fact]
    public async Task GetCartItemAsync_ShouldReturnCartItem()
    {
        // Arrange
        int cartItemId = 1;
        var existingCartItem = new CartItem
        {
            Id = cartItemId,
            BookId = 1,
            CartId = 1,
            Quantity = 5,
        };

        _unitOfWork.CartItemRepository.GetByIdAsync(cartItemId).Returns(existingCartItem);

        // Act
        var result = await _cartItemService.GetCartItemAsync(cartItemId);

        // Assert
        await _unitOfWork.CartItemRepository.Received(1).GetByIdAsync(cartItemId);
        Assert.Equal(existingCartItem.Id, result.Id);
        Assert.Equal(existingCartItem.Quantity, result.Quantity);
    }

    [Fact]
    public async Task GetCartItemAsync_ShouldThrowException_WhenCartItemNotFound()
    {
        var cartItemId = 1;
        _unitOfWork.CartItemRepository.GetByIdAsync(Arg.Any<int>()).Returns((CartItem?)null);

        // Act
        // Assert
        await Assert.ThrowsAsync<NotFoundException>(
            async () => await _cartItemService.GetCartItemAsync(cartItemId)
        );
    }

    [Fact]
    public async Task GetAllCartItemsAsync_ShouldReturnAllCartItems()
    {
        // Arrange
        var cartItems = new List<CartItem>
        {
            new CartItem
            {
                Id = 1,
                BookId = 1,
                CartId = 1,
                Quantity = 5,
            },
            new CartItem
            {
                Id = 2,
                BookId = 2,
                CartId = 1,
                Quantity = 3,
            },
        };

        _unitOfWork.CartItemRepository.GetAllAsync().Returns(cartItems);

        // Act
        var result = await _cartItemService.GetAllCartItemsAsync();

        // Assert
        await _unitOfWork.CartItemRepository.Received(1).GetAllAsync();
        Assert.Equal(cartItems.Count, result.Count);
        Assert.Equal(cartItems[0].Id, result[0].Id);
        Assert.Equal(cartItems[0].Quantity, result[0].Quantity);
        Assert.Equal(cartItems[1].Id, result[1].Id);
        Assert.Equal(cartItems[1].Quantity, result[1].Quantity);
    }
}
