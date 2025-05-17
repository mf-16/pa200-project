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
    DbSet<GiftCard> GiftCards { get; set; }
    DbSet<Coupon> Coupons { get; set; }

    public BookHubDbContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Seed();
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<GiftCard>().HasIndex(g => g.Name).IsUnique();
        modelBuilder.Entity<Order>()
                    .HasOne(o => o.ShippingAddress)
                    .WithMany()
                    .HasForeignKey(o => o.ShippingAddressId)
                    .OnDelete(DeleteBehavior.NoAction); 
        
                modelBuilder.Entity<Order>()
                    .HasOne(o => o.BillingAddress)
                    .WithMany()
                    .HasForeignKey(o => o.BillingAddressId)
                    .OnDelete(DeleteBehavior.NoAction);
        
                modelBuilder.Entity<BookGenreLink>()
                    .HasOne(bgl => bgl.Book)
                    .WithMany(b => b.SecondaryGenres)
                    .HasForeignKey(bgl => bgl.BookId)
                    .OnDelete(DeleteBehavior.Restrict);
        
                modelBuilder.Entity<BookGenreLink>()
                    .HasOne(bgl => bgl.Genre)
                    .WithMany(g => g.SecondaryBooks)
                    .HasForeignKey(bgl => bgl.GenreId)
                    .OnDelete(DeleteBehavior.Restrict);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
    }
}
