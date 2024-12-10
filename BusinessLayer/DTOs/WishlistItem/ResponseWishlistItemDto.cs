using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.WishlistItem;

public class ResponseWishlistItemDto
{
    public int Id { get; set; }
    public ResponseBookDto Book { get; set; }
    public int UserId { get; set; }
}
