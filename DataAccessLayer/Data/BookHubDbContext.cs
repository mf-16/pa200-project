using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Data;

public class BookHubDbContext : DbContext
{
    public BookHubDbContext(DbContextOptions options) : base(options)
    {
    }
}
