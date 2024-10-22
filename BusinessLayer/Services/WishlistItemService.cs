using AutoMapper;
using BusinessLayer.DTOs.WishlistItem;
using BusinessLayer.Exceptions;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;

namespace BusinessLayer.Services;

public class WishlistItemService : IWishlistItemService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public WishlistItemService(IMapper mapper, IUnitOfWork unitOfWork)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<ResponseWishlistItemDto> CreateWishlistItemAsync(
        int userId,
        CreateWishlistItemDto createWishlistItemDto
    )
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), userId);
        }
        var book = await _unitOfWork.BookRepository.GetByIdAsync(createWishlistItemDto.BookId);
        if (book == null)
        {
            throw new NotFoundException(nameof(Book), createWishlistItemDto.BookId);
        }

        var wishlistItemExists = user.Wishlist.Any(wishlistItem =>
            wishlistItem.BookId == createWishlistItemDto.BookId
        );
        if (wishlistItemExists)
        {
            throw new EntityAlreadyExistsException(nameof(WishlistItem));
        }
        var wishlistItem = _mapper.Map<WishlistItem>(createWishlistItemDto);
        wishlistItem.UserId = userId;
        user.Wishlist.Add(wishlistItem);
        await _unitOfWork.CommitAsync();
        return _mapper.Map<ResponseWishlistItemDto>(wishlistItem);
    }

    public async Task<List<ResponseWishlistItemDto>> GetAllWishlistItemsAsync(int userId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), userId);
        }
        return _mapper.Map<List<ResponseWishlistItemDto>>(user.Wishlist);
    }

    public async Task DeleteWishlistItemAsync(int userId, int wishlistItemId)
    {
        var user = await _unitOfWork.UserRepository.GetByIdAsync(userId);
        if (user == null)
        {
            throw new NotFoundException(nameof(User), userId);
        }
        var wishlistItem = await _unitOfWork.WishlistItemRepository.GetByIdAsync(wishlistItemId);
        if (wishlistItem == null)
        {
            throw new NotFoundException(nameof(WishlistItem), wishlistItemId);
        }

        if (wishlistItem.UserId != userId)
        {
            throw new UnauthorizedAccessException(
                "This wishlist item does not belong to this user."
            );
        }
        user.Wishlist.Remove(wishlistItem);
        await _unitOfWork.CommitAsync();
    }
}
