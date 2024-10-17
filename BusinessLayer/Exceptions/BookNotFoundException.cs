namespace BusinessLayer.Exceptions;

public class BookNotFoundException : NotFoundException
{
    public BookNotFoundException(int id)
        : base("Book", id) { }

    public BookNotFoundException(int id, string message)
        : base("Book", id, message) { }

    public BookNotFoundException(int id, string message, Exception innerException)
        : base("Book", id, message, innerException) { }
}
