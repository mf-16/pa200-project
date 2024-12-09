using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class BookHubDbContext : IdentityDbContext<User, UserRole, int>
{
    DbSet<Author> Authors { get; set; }
    DbSet<Book> Books { get; set; }
    DbSet<Cart> Carts { get; set; }
    DbSet<CartItem> CartItems { get; set; }
    DbSet<Order> Orders { get; set; }
    DbSet<OrderItem> OrderItems { get; set; }
    DbSet<Publisher> Publishers { get; set; }
    DbSet<Review> Reviews { get; set; }
    DbSet<User> Users { get; set; }
    DbSet<UserRole> UserRoles { get; set; }
    DbSet<WishlistItem> WishlistItems { get; set; }
    DbSet<Address> Addresses { get; set; }

    public BookHubDbContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Seed();
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }
}
