using Bogus;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public static class DataInitializer
{
    // Constants for number of entities
    private const int NumberOfUsers = 10;
    private const int NumberOfBooks = 20;
    private const int NumberOfAuthors = 10;
    private const int NumberOfPublishers = 5;
    private const int NumberOfReviews = 50;
    private const int NumberOfWishlistItems = 30;
    private const int NumberOfOrders = 15;
    private const int NumberOfOrderItems = 50;
    private const string UserRole = "User";
    private const string AdminRole = "Admin";

    public static void Seed(this ModelBuilder modelBuilder)
    {

        var users = PrepareUsers(NumberOfUsers);
        var roles = PrepareRoles();
        var userRoles = PrepareUserRoles();
        modelBuilder.Entity<User>().HasData(users);
        modelBuilder.Entity<UserRole>().HasData(roles);
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(userRoles);
            
        // Seed authors and publishers
        var authors = PrepareAuthors(NumberOfAuthors);
        var publishers = PreparePublishers(NumberOfPublishers);
        var books = PrepareBooks(NumberOfBooks);
            

        modelBuilder.Entity<Author>().HasData(authors);
        modelBuilder.Entity<Publisher>().HasData(publishers);
        modelBuilder.Entity<Book>().HasData(books);

        // Seed reviews
        var reviews = PrepareReviews(NumberOfReviews);
        modelBuilder.Entity<Review>().HasData(reviews);

        // Seed wishlist items
        var wishlists = PrepareWishlistItems(NumberOfWishlistItems);
        modelBuilder.Entity<WishlistItem>().HasData(wishlists);

        // Seed orders
        var orders = PrepareOrders(NumberOfOrders);
        modelBuilder.Entity<Order>().HasData(orders);

        // Seed order items for those orders
        var orderItems = PrepareOrderItems();
        modelBuilder.Entity<OrderItem>().HasData(orderItems);

        // Seed carts for users
        var carts = PrepareCarts();
        modelBuilder.Entity<Cart>().HasData(carts);
    }
        
    private static List<UserRole> PrepareRoles()
    {
        return new List<UserRole>
        {
            new UserRole { Id = 1, Name = AdminRole, NormalizedName = AdminRole.ToUpper() },
            new UserRole { Id = 2, Name = UserRole, NormalizedName = UserRole.ToUpper() }
        };
    }
    private static List<User> PrepareUsers(int count)
    {
        var users = new List<User>();

        var adminUser = new User
        {
            Id = 1,
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Name = "Admin User",
            Email = "admin@admin.com",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            PhoneNumber = "123-456-7890"
        };
        users.Add(adminUser);

        var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 2) 
            .RuleFor(u => u.UserName, f => f.Internet.UserName())
            .RuleFor(u => u.Name, f => f.Name.FullName())
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.EmailConfirmed, true)
            .RuleFor(u => u.SecurityStamp, f => Guid.NewGuid().ToString())
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber());

        users.AddRange(userFaker.Generate(count - 1)); 

        return users;
    }
        
    private static List<IdentityUserRole<int>> PrepareUserRoles()
    {
        var userRoles = new List<IdentityUserRole<int>>
        {
            new IdentityUserRole<int> { UserId = 1, RoleId = 1 } // Admin user
        };
        
        for (int i = 2; i <= NumberOfUsers; i++)
        {
            userRoles.Add(new IdentityUserRole<int> { UserId = i, RoleId = 2 }); // Regular users
        }
        
        return userRoles;
    }
    private static List<Author> PrepareAuthors(int count)
    {
        var authorFaker = new Faker<Author>()
            .RuleFor(a => a.Id, f => f.IndexFaker + 1)
            .RuleFor(a => a.Name, f => f.Name.FullName())
            .RuleFor(a => a.Bio, f => f.Lorem.Paragraph());

        return authorFaker.Generate(count);
    }

    private static List<Publisher> PreparePublishers(int count)
    {
        var publisherFaker = new Faker<Publisher>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.Name, f => f.Company.CompanyName())
            .RuleFor(p => p.Bio, f => f.Lorem.Paragraph());

        return publisherFaker.Generate(count);
    }

    private static List<Book> PrepareBooks(int count)
    {
        var bookFaker = new Faker<Book>()
            .RuleFor(b => b.Id, f => f.IndexFaker + 1)
            .RuleFor(b => b.Title, f => f.Lorem.Sentence(3))
            .RuleFor(b => b.AuthorId, f => f.Random.Number(1, NumberOfAuthors))
            .RuleFor(b => b.PublisherId, f => f.Random.Number(1, NumberOfPublishers))
            .RuleFor(b => b.Price, f => decimal.Parse(f.Commerce.Price(10, 100)))
            .RuleFor(b => b.ImagePath, f => f.Image.PicsumUrl())
            .RuleFor(b => b.Genre, f => f.PickRandom<BookGenre>());

        return bookFaker.Generate(count);
    }

    private static List<Review> PrepareReviews(int count)
    {
        var reviewFaker = new Faker<Review>()
            .RuleFor(r => r.Id, f => f.IndexFaker + 1)
            .RuleFor(r => r.BookId, f => f.Random.Number(1, NumberOfBooks))
            .RuleFor(r => r.UserId, f => f.Random.Number(2, NumberOfUsers))
            .RuleFor(r => r.Stars, f => f.Random.Number(1, 5))
            .RuleFor(r => r.Comment, f => f.Lorem.Sentence());

        return reviewFaker.Generate(count);
    }

    private static List<WishlistItem> PrepareWishlistItems(int count)
    {
        var wishlistFaker = new Faker<WishlistItem>()
            .RuleFor(w => w.Id, f => f.IndexFaker + 1)
            .RuleFor(w => w.BookId, f => f.Random.Number(1, NumberOfBooks))
            .RuleFor(w => w.UserId, f => f.Random.Number(2, NumberOfUsers));

        return wishlistFaker.Generate(count);
    }

    private static List<Order> PrepareOrders(int count)
    {
        var orderFaker = new Faker<Order>()
            .RuleFor(o => o.Id, f => f.IndexFaker + 1)
            .RuleFor(o => o.UserId, f => f.Random.Number(2, NumberOfUsers))
            .RuleFor(o => o.CustomerName, f => f.Person.FullName)
            .RuleFor(o => o.CustomerEmail, f => f.Person.Email)
            .RuleFor(o => o.ShippingAddress, f => f.Address.FullAddress())
            .RuleFor(o => o.BillingAddress, f => f.Address.FullAddress())
            .RuleFor(o => o.TotalAmount, f => 0); 

        return orderFaker.Generate(count);
    }

    private static List<OrderItem> PrepareOrderItems()
    {

        var orderItemFaker = new Faker<OrderItem>()
            .RuleFor(oi => oi.Id, f => f.IndexFaker + 1)
            .RuleFor(oi => oi.OrderId, f => f.Random.Number(1, NumberOfOrders))
            .RuleFor(oi => oi.BookId, f => f.Random.Number(1, NumberOfBooks))
            .RuleFor(oi => oi.Quantity, f => f.Random.Number(1, 3))
            .RuleFor(oi => oi.Price, f => decimal.Parse(f.Commerce.Price(10, 100)));


        return orderItemFaker.Generate(NumberOfOrderItems);
    }

    private static List<Cart> PrepareCarts()
    {
        var carts = Enumerable.Range(2, NumberOfUsers - 1) 
            .Select(userId => new Cart
            {
                Id = userId, 
                UserId = userId
            })
            .ToList();
        
        return carts;
    }
}