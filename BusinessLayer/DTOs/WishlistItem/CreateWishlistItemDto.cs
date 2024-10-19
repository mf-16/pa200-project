using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.DTOs.WishlistItem;

public class CreateWishlistItemDto
{
    [Required]
    public int BookId { get; set; }
}
