using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Data
{
    public static class DataInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Seed users
            var users = PrepairUserModels();
            modelBuilder.Entity<User>()
                .HasData(users);

            // Seed roles
            var roles = PrepareUserRoleModels();
            modelBuilder.Entity<UserRole>()
                .HasData(roles);
            
            // Give roles to users
            modelBuilder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int> { UserId = 1, RoleId = 1 }, 
                new IdentityUserRole<int> { UserId = 2, RoleId = 2 } 
            );
            
            
        }

        private static List<User> PrepairUserModels()
        {
            var passwordHasher = new PasswordHasher<User>();
            
            return new List<User>()
            {
                new User()
                {
                    Id = 1,
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
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
                new UserRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new UserRole { Id = 2, Name = "User", NormalizedName = "USER" },
            };
        }

    }
    
}