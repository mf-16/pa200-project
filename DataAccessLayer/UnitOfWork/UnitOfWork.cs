using BusinessLayer.Repositories;
using BusinessLayer.UnitOfWork;
using DataAccessLayer.Data;
using DataAccessLayer.Model;
using DataAccessLayer.Repositories;

namespace DataAccessLayer.UnitOfWork;

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
        BookRepository = new GenericRepository<Book>(_context);
        UserRepository = new GenericRepository<User>(_context);
        AuthorRepository = new GenericRepository<Author>(_context);
        PublisherRepository = new GenericRepository<Publisher>(_context);
        OrderRepository = new GenericRepository<Order>(_context);
        OrderItemRepository = new GenericRepository<OrderItem>(_context);
        WishlistItemRepository = new GenericRepository<WishlistItem>(_context);
        ReviewRepository = new GenericRepository<Review>(_context);
        CartRepository = new GenericRepository<Cart>(_context);
        CartItemRepository = new GenericRepository<CartItem>(_context);
    }

    public async void Commit()
    {
        await _context.SaveChangesAsync();
    }
}
