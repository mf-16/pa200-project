using AutoMapper;
using BusinessLayer.DTOs.Cart;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;

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

    public async Task<ResponseCartItemDto> AddCartItemAsync(AddCartItemDto addCartItemDto)
    {
        if (await _unitOfWork.BookRepository.GetByIdAsync(addCartItemDto.BookId) == null)
        {
            throw new NotFoundException("Book", addCartItemDto.BookId);
        }

        var cartItem = _mapper.Map<CartItem>(addCartItemDto);
        await _unitOfWork.CartItemRepository.AddAsync(cartItem);
        await _unitOfWork.CommitAsync();
        var response = _mapper.Map<ResponseCartItemDto>(cartItem);
        return response;
    }

    public async Task<ResponseCartItemDto> GetCartItemAsync(int id)
    {
        var response = _mapper.Map<ResponseCartItemDto>(
            await _unitOfWork.CartItemRepository.GetByIdAsync(id)
        );
        if (response == null)
        {
            throw new NotFoundException("CartItem", id);
        }
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

    public async Task<ResponseCartItemDto> UpdateCartItemAsync(UpdateCartItemDto updateCartItemDto)
    {
        var cartItem = await _unitOfWork.CartItemRepository.GetByIdAsync(
            updateCartItemDto.CartItemId
        );

        if (cartItem == null)
        {
            throw new NotFoundException("CartItem", updateCartItemDto.CartItemId);
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
}
