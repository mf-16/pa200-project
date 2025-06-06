using AutoMapper;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Services;

public class CartItemService : ICartItemService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CartItemService(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<ResponseCartItemDto> CreateCartItemAsync(
        int userId,
        CreateCartItemDto createCartItemDto
    )
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException("User", userId);
        }
        if (await _unitOfWork.BookRepository.GetByIdAsync(createCartItemDto.BookId) == null)
        {
            throw new NotFoundException("Book", createCartItemDto.BookId);
        }

        var cartItem = _mapper.Map<CartItem>(createCartItemDto);
        cartItem.CartId = user.Cart.Id;
        _unitOfWork.CartItemRepository.Add(cartItem);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseCartItemDto>(cartItem);
        return response;
    }

    public async Task<ResponseCartItemDto> GetCartItemAsync(int id)
    {
        var cartItem = await _unitOfWork.CartItemRepository.GetByIdAsync(id);

        if (cartItem == null)
        {
            throw new NotFoundException("CartItem", id);
        }
        var response = _mapper.Map<ResponseCartItemDto>(cartItem);
        return response;
    }

    public async Task DeleteCartItemAsync(int id)
    {
        var carItem = await _unitOfWork.CartItemRepository.GetByIdAsync(id);
        if (carItem == null)
        {
            throw new NotFoundException("CartItem", id);
        }
        _unitOfWork.CartItemRepository.Delete(carItem);
        await _unitOfWork.CommitAsync();
    }

    public async Task<ResponseCartItemDto> UpdateCartItemAsync(
        int id,
        UpdateCartItemDto updateCartItemDto
    )
    {
        var cartItem = await _unitOfWork.CartItemRepository.GetByIdAsync(id);

        if (cartItem == null)
        {
            throw new NotFoundException("CartItem", id);
        }

        cartItem.Quantity = updateCartItemDto.Quantity;
        _unitOfWork.CartItemRepository.Update(cartItem);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseCartItemDto>(cartItem);
        return response;
    }

    public async Task<List<ResponseCartItemDto>> GetAllCartItemsAsync()
    {
        var response = _mapper.Map<List<ResponseCartItemDto>>(
            await _unitOfWork.CartItemRepository.GetAllAsync()
        );
        return response;
    }

    public async Task<List<ResponseCartItemDto>> GetAllCartItemsByUserAsync(int userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException("User", userId);
        }
        return _mapper.Map<List<ResponseCartItemDto>>(user.Cart.CartItems);
    }
}
