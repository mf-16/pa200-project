using DataAccessLayer.Data;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BookHubDbContext>(options =>
    options
        .UseNpgsql(
            builder.Configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("DAL.PostgreSQL.Migrations")
        )
        .UseLazyLoadingProxies()
);

builder
    .Services.AddIdentity<User, UserRole>()
    .AddEntityFrameworkStores<BookHubDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
