using DataAccessLayer.Data;
using DataAccessLayer.Model;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly BookHubDbContext _context;
    public IRepository<Book> BookRepository { get; }
    public IRepository<User> UserRepository { get; }
    public IRepository<Author> AuthorRepository { get; }
    public IRepository<Publisher> PublisherRepository { get; }
    public IRepository<Order> OrderRepository { get; }
    public IRepository<OrderItem> OrderItemRepository { get; }
    public IRepository<WishlistItem> WishlistItemRepository { get; }
    public IRepository<Review> ReviewRepository { get; }
    public IRepository<Cart> CartRepository { get; }
    public IRepository<CartItem> CartItemRepository { get; }

    public UnitOfWork(BookHubDbContext context)
    {
        _context = context;
        BookRepository = new Repository<Book>(_context);
        UserRepository = new Repository<User>(_context);
        AuthorRepository = new Repository<Author>(_context);
        PublisherRepository = new Repository<Publisher>(_context);
        OrderRepository = new Repository<Order>(_context);
        OrderItemRepository = new Repository<OrderItem>(_context);
        WishlistItemRepository = new Repository<WishlistItem>(_context);
        ReviewRepository = new Repository<Review>(_context);
        CartRepository = new Repository<Cart>(_context);
        CartItemRepository = new Repository<CartItem>(_context);
    }

    public async void Commit()
    {
        await _context.SaveChangesAsync();
    }
}
