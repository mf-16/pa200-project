using DataAccessLayer.Model;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public interface IUnitOfWork
{
    IRepository<Book> BookRepository { get; }
    IRepository<User> UserRepository { get; }
    IRepository<Author> AuthorRepository { get; }
    IRepository<Publisher> PublisherRepository { get; }
    IRepository<Order> OrderRepository { get; }
    IRepository<OrderItem> OrderItemRepository { get; }
    IRepository<WishlistItem> WishlistItemRepository { get; }
    IRepository<Review> ReviewRepository { get; }
    IRepository<Cart> CartRepository { get; }
    IRepository<CartItem> CartItemRepository { get; }
    Task CommitAsync();
}
