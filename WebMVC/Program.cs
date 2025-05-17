using Azure.Identity;
using Azure.Messaging.ServiceBus;
using Azure.Storage.Blobs;
using BusinessLayer.Services;
using BusinessLayer.Services.Interfaces;
using DataAccessLayer.Data;
using DataAccessLayer.Model;
using Infrastructure.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Middleware;

var builder = WebApplication.CreateBuilder(args);
var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
builder.Services.AddDbContext<BookHubDbContext>(options =>
    options
        .UseSqlServer(
            builder.Configuration.GetConnectionString(connectionString!),
            b => b.MigrationsAssembly("DAL.SqlServer.Migrations")
        )
        .UseLazyLoadingProxies()
);


builder.Services.AddSingleton(_ =>
{
    var accountUrl = Environment.GetEnvironmentVariable("STORAGE_ACCOUNT_URL");

    if (string.IsNullOrEmpty(accountUrl))
        throw new InvalidOperationException("STORAGE_ACCOUNT_URL environment variable is not set.");
    return new BlobServiceClient(new Uri(accountUrl), new ManagedIdentityCredential());
}
    
);

builder.Services.AddSingleton(serviceProvider =>
{
    var busConnectionString = Environment.GetEnvironmentVariable("SERVICE_BUS_CONNECTION");
    return new ServiceBusClient(busConnectionString);
});

// Add services to the container.
builder.Services.AddControllersWithViews();

// This line adds the default identity system configuration for the specified user and role types to the services container.
builder
    .Services.AddIdentity<User, UserRole>()
    // This method call specifies that the identity system will use Entity Framework to store and manage user information,
    // with 'SeminarDBContext' as the database context class that handles the connection to the database.
    .AddEntityFrameworkStores<BookHubDbContext>()
    // This adds the default token providers used to generate tokens for account confirmation, password resets, etc.
    .AddDefaultTokenProviders();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IGiftCardService, GiftCardService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IGenreService, GenreService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ICartItemService, CartItemService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IWishlistItemService, WishlistItemService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddScoped<IPublisherService, PublisherService>();

// Configure Identity options for password policies
builder.Services.Configure<IdentityOptions>(options =>
{
    // Password settings.
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 1;
    options.Password.RequiredUniqueChars = 1;
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedEmail = false;
    options.Lockout.AllowedForNewUsers = false;
});

// Configure the application cookie settings.
builder.Services.ConfigureApplicationCookie(options =>
{
    // Sets the path for the login page.
    // If a user attempts to access a resource that requires authentication and they are not authenticated,
    // they will be redirected to this path.
    options.LoginPath = "/Account/Login";
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BookHubDbContext>();
    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();
app.UseMiddleware<LoggingMiddleware>("mvc");
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
