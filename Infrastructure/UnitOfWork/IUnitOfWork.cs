using DataAccessLayer.Model;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public interface IUnitOfWork
{
    IRepository<Book> BookRepository { get; }
    IRepository<User> UserRepository { get; }
    IRepository<Author> AuthorRepository { get; }
    IRepository<BookGenre> GenreRepository { get; }
    IRepository<Publisher> PublisherRepository { get; }
    IRepository<Order> OrderRepository { get; }
    IRepository<OrderItem> OrderItemRepository { get; }
    IRepository<WishlistItem> WishlistItemRepository { get; }
    IRepository<Review> ReviewRepository { get; }
    IRepository<Cart> CartRepository { get; }
    IRepository<CartItem> CartItemRepository { get; }
    IRepository<GiftCard> GiftCardRepository { get; }
    IRepository<Coupon> CouponRepository { get; }
    Task CommitAsync();
}
