namespace BusinessLayer.Exceptions;

public class CartItemNotFoundException : NotFoundException
{
    public CartItemNotFoundException(int id)
        : base("Cart Item", id) { }

    public CartItemNotFoundException(int id, string message)
        : base("Cart Item", id, message) { }

    public CartItemNotFoundException(int id, string message, Exception innerException)
        : base("Cart Item", id, message, innerException) { }
}
