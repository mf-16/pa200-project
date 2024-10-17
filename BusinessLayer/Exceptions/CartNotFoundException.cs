namespace BusinessLayer.Exceptions;

public class CartNotFoundException : NotFoundException
{
    public CartNotFoundException(int id)
        : base("Cart", id) { }

    public CartNotFoundException(int id, string message)
        : base("Cart", id, message) { }

    public CartNotFoundException(int id, string message, Exception innerException)
        : base("Cart", id, message, innerException) { }
}
