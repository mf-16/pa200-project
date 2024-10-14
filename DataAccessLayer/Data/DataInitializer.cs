using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data
{
    public static class DataInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed users
            var users = PrepareUserModels();
            modelBuilder.Entity<User>().HasData(users);

            // Seed roles
            var roles = PrepareUserRoleModels();
            modelBuilder.Entity<UserRole>().HasData(roles);

            // Give roles to users
            modelBuilder
                .Entity<IdentityUserRole<int>>()
                .HasData(
                    new IdentityUserRole<int> { UserId = 1, RoleId = 1 },
                    new IdentityUserRole<int> { UserId = 2, RoleId = 2 }
                );
            //Seed books
            var books = PrepareBooks();
            modelBuilder.Entity<Book>().HasData(books);

            //Seed orders
            var orders = PrepareOrders(users[1]);
            modelBuilder.Entity<Order>().HasData(orders);

            //Seed order items
            var orderItems = PrepareOrderItems(orders);
            modelBuilder.Entity<OrderItem>().HasData(orderItems);
        }

        private static List<Book> PrepareBooks()
        {
            var books = new List<Book>();
            for (int i = 1; i < 20; i++)
            {
                books.Add(new Book() { Id = i });
            }
            return books;
        }

        private static List<OrderItem> PrepareOrderItems(List<Order> orders)
        {
            var random = new Random();
            var orderItems = new List<OrderItem>();

            foreach (var order in orders)
            {
                for (int j = 1; j <= 5; j++)
                {
                    var orderItem = new OrderItem()
                    {
                        Id = (order.Id - 1) * 5 + j,
                        OrderId = order.Id,
                        BookId = random.Next(1, 21),
                        Quantity = random.Next(1, 4),
                        Price = random.Next(50, 100),
                    };

                    orderItems.Add(orderItem);
                    order.TotalAmount += orderItem.Quantity * orderItem.Price;
                }
            }

            return orderItems;
        }

        private static List<Order> PrepareOrders(User user, int numberOfOrders = 3)
        {
            var random = new Random();
            var orders = new List<Order>();

            for (int i = 1; i <= numberOfOrders; i++)
            {
                var order = new Order
                {
                    Id = i,
                    UserId = user.Id,
                    CustomerName = user.Name,
                    CustomerEmail = user.Email ?? "user@email.com",
                    ShippingAddress = "123 Main St, City, Country",
                    BillingAddress = "123 Main St, City, Country",
                    TotalAmount = 0,
                };

                orders.Add(order);
            }

            return orders;
        }

        private static List<User> PrepareUserModels()
        {
            var passwordHasher = new PasswordHasher<User>();

            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Name = "Admin",
                    Email = "admin@admin.com",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "admin"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "0123456987",
                },
                new User()
                {
                    Id = 2,
                    UserName = "user",
                    NormalizedUserName = "USER",
                    Name = "Jonh Doe",
                    Email = "user@user.com",
                    EmailConfirmed = true,
                    PasswordHash = passwordHasher.HashPassword(null, "user"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = "0123456789",
                },
            };
        }

        private static List<UserRole> PrepareUserRoleModels()
        {
            return new List<UserRole>()
            {
                new UserRole
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                new UserRole
                {
                    Id = 2,
                    Name = "User",
                    NormalizedName = "USER",
                },
            };
        }
    }
}
