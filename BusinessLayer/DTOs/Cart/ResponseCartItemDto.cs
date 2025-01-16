using BusinessLayer.DTOs.Book;

namespace BusinessLayer.DTOs.Cart;

public class ResponseCartItemDto
{
    public int Id { get; set; }
    public ResponseBookDto Book { get; set; }
    public int Quantity { get; set; }
}
