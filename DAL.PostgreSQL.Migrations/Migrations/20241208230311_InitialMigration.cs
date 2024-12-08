using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.PostgreSQL.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Street = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "integer", nullable: false),
                    BillingAddressId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PrimaryGenreId = table.Column<int>(type: "integer", nullable: false),
                    LastEditorId = table.Column<int>(type: "integer", nullable: true),
                    EditCount = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_AspNetUsers_LastEditorId",
                        column: x => x.LastEditorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_BookGenre_PrimaryGenreId",
                        column: x => x.PrimaryGenreId,
                        principalTable: "BookGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookGenreLink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenreLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenreLink_BookGenre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "BookGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenreLink_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Stars = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Country", "CreatedDate", "IsDeleted", "State", "Street", "UpdatedDate", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Maximilliaborough", "Moldova", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(6741), false, "Georgia", "78799 Jacobs River", null, "59096-7354" },
                    { 2, "Kittyhaven", "Holy See (Vatican City State)", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(7642), false, "Tennessee", "5395 Brennan Radial", null, "20515" },
                    { 3, "Lake Ulises", "Venezuela", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(7847), false, "New Jersey", "06899 Ruecker Greens", null, "33757-8022" },
                    { 4, "Odessamouth", "Liberia", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(7996), false, "New Hampshire", "641 Pedro Union", null, "53126-0082" },
                    { 5, "West Eudoramouth", "Moldova", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(8203), false, "North Dakota", "90038 Patrick Ways", null, "03186-8705" },
                    { 6, "Lake Mallieside", "Cambodia", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(8388), false, "Virginia", "6100 Paula Pike", null, "85719-8931" },
                    { 7, "New Generalbury", "Romania", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(8556), false, "Iowa", "07348 Helen Overpass", null, "74008" },
                    { 8, "Krajcikborough", "Kiribati", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(8730), false, "Florida", "94148 Florida Way", null, "28804-4677" },
                    { 9, "East Obiehaven", "Azerbaijan", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(8909), false, "Idaho", "733 Taurean Mills", null, "35261-8183" },
                    { 10, "Evangelineport", "Tuvalu", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(9067), false, "Hawaii", "4088 Michale Throughway", null, "36239" },
                    { 11, "West Cathryn", "Zambia", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(9233), false, "Louisiana", "43890 Alejandra Village", null, "46508-0626" },
                    { 12, "Port Ethylland", "Andorra", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(9384), false, "Arkansas", "68638 Jedidiah Junctions", null, "63658" },
                    { 13, "Cormierborough", "Zambia", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(9569), false, "Alabama", "20283 Bednar Divide", null, "27270-0958" },
                    { 14, "Dereckburgh", "Niue", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(9734), false, "Pennsylvania", "80769 Towne Branch", null, "46780-3177" },
                    { 15, "Lake Abigaylechester", "Tajikistan", new DateTime(2024, 12, 8, 23, 3, 10, 968, DateTimeKind.Utc).AddTicks(9894), false, "Rhode Island", "945 Wyman Camp", null, "76188-5984" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "d4604574-ef95-4f72-881a-0e5b50125e04", "admin@admin.com", true, false, null, "Admin User", null, "FAKE_ADMIN", null, "123-456-7890", false, "aa64dc62-94b2-4421-b62b-caa9d2b79a0f", false, "fake_admin" },
                    { 2, 0, "b4cb6511-4d34-4d99-ab3b-012c326318ca", "Jo.Wiza45@hotmail.com", true, false, null, "Elenor Koch", null, null, null, "773.664.4056", false, "2300b479-2c5c-4b04-94f2-226011c251fd", false, "Adriana_Hilpert" },
                    { 3, 0, "df89ded7-d86e-4214-8664-435dfc335a5f", "Jamie_Fay65@gmail.com", true, false, null, "Thora Sanford", null, null, null, "630.558.3000 x636", false, "e006b56e-b265-4684-98a3-3a92c0f9c6f8", false, "Marcellus_Rolfson" },
                    { 4, 0, "e6090e30-9f62-468b-815d-9fb6a32d4bda", "Jermaine5@yahoo.com", true, false, null, "Alessandro Powlowski", null, null, null, "392-972-6844 x10270", false, "12a7c96f-f585-45c4-83fb-510a7c670f11", false, "Trystan54" },
                    { 5, 0, "7abc583d-9fbb-4722-ad41-2eb94af894f1", "Jarvis.Crist@hotmail.com", true, false, null, "Lavina Marvin", null, null, null, "307-744-0789 x7135", false, "79536e90-4fcb-477c-aab9-28ff46f02532", false, "Addison_King84" },
                    { 6, 0, "54783ca3-c776-4e70-ae74-bbf5f01946af", "Coleman.Rowe58@yahoo.com", true, false, null, "Domingo Auer", null, null, null, "215.425.0769 x8526", false, "52be8ddc-3d74-45eb-8a7b-436cb831290c", false, "Candice72" },
                    { 7, 0, "b4173a25-bbab-4986-8b72-d4c26151a806", "Jaqueline54@gmail.com", true, false, null, "Davon O'Keefe", null, null, null, "1-284-708-1836 x08940", false, "84badeb8-cd18-4545-9d90-40e825aab0c1", false, "Cassandra_Brakus" },
                    { 8, 0, "6e8b8863-f18b-4288-8ebd-48d9a14b33a2", "Janis15@hotmail.com", true, false, null, "Lora Jerde", null, null, null, "1-870-472-3809", false, "2db79c85-da68-4cf6-a5fc-d8606b91e9e7", false, "Kaelyn21" },
                    { 9, 0, "66795a6a-b2e5-45a7-ad5c-24f9ebeb55b8", "Lynn_Kshlerin@hotmail.com", true, false, null, "Celia Buckridge", null, null, null, "1-640-727-9177", false, "351e6a3d-1ac8-4047-9234-dd3b437d832f", false, "Joanny51" },
                    { 10, 0, "4ec0fd4c-0d6b-49aa-8b9b-d45b0af30a91", "Eino_Little@hotmail.com", true, false, null, "Fannie O'Keefe", null, null, null, "422.867.5790 x996", false, "17b75bce-1ca2-4f31-9d98-27e9cbc877eb", false, "Flo_Mayer" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Reiciendis enim id. Et et ea. Expedita consequuntur sit voluptate provident cum.", new DateTime(2024, 12, 8, 23, 3, 10, 957, DateTimeKind.Utc).AddTicks(9745), false, "Hulda Schuppe", null },
                    { 2, "Et voluptatem porro vero eligendi quia asperiores voluptatum explicabo repellat. Adipisci occaecati saepe voluptates. Reiciendis dolorum harum ut rerum. Rerum pariatur cupiditate odio vitae quis eum occaecati quisquam occaecati. Rerum aut ut vitae.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(218), false, "Kim Trantow", null },
                    { 3, "Corporis facilis earum nihil. Quia similique iusto quo ut ut assumenda aut qui sed. Libero error consequuntur itaque et quidem. Nemo consequatur vel culpa earum. Non occaecati delectus non consectetur amet iusto necessitatibus sit.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(418), false, "Eliezer Schuppe", null },
                    { 4, "Veritatis pariatur optio. Voluptatem vero nihil vel. Consequatur at natus animi voluptas architecto et dignissimos ratione. Asperiores quidem deleniti ducimus. Nulla quisquam voluptatum delectus quis voluptatum possimus atque.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(624), false, "Antonina Christiansen", null },
                    { 5, "Labore iste voluptate odio sed praesentium omnis ducimus. Non ut aut quidem. Aliquid officiis impedit maiores beatae perferendis qui quam eligendi maiores. Voluptatibus eum necessitatibus optio quia mollitia architecto. Eum totam nihil eum voluptas doloribus voluptate.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(801), false, "Shanna Robel", null },
                    { 6, "Ea harum praesentium et sunt consequatur pariatur eligendi doloremque. Qui eveniet saepe in. Beatae id ipsum sint. Voluptas nulla omnis omnis.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(968), false, "Jedidiah Connelly", null },
                    { 7, "Rerum quo voluptates a qui corporis quidem voluptates veritatis dolores. Est aperiam ut. Enim corporis incidunt beatae cum nesciunt. Explicabo autem modi consequatur quae occaecati doloribus dolorem dolor odit. Sapiente aut quia et voluptas magni. Consequatur modi at rerum laboriosam consequuntur iusto.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(1101), false, "Hugh Ziemann", null },
                    { 8, "Saepe quod aut vero. Saepe possimus non fuga et ut. Doloribus hic minima velit neque.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(1327), false, "Hazel Krajcik", null },
                    { 9, "Dolore veniam quasi corporis ducimus. Earum neque sed animi quisquam voluptas quo in. Sed debitis nemo eum reprehenderit. Libero quas quia odio.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(1401), false, "Tevin Klein", null },
                    { 10, "Voluptatem sit ab voluptatem vel. Et ut vitae esse. Aspernatur exercitationem aut iste quis. Quo voluptatem nostrum deleniti molestiae laborum veniam pariatur. Non dicta quia recusandae.", new DateTime(2024, 12, 8, 23, 3, 10, 958, DateTimeKind.Utc).AddTicks(1494), false, "Mollie McCullough", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Voluptatum velit esse." },
                    { 2, "Distinctio et facilis." },
                    { 3, "A accusamus vero." },
                    { 4, "Eveniet et deleniti." },
                    { 5, "Modi corrupti praesentium." },
                    { 6, "Ex omnis officia." }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ut ipsum expedita esse qui doloribus. Saepe ullam quibusdam consequuntur quos est distinctio voluptas sint ratione. Ut velit molestiae libero sint. Est at esse.", new DateTime(2024, 12, 8, 23, 3, 10, 959, DateTimeKind.Utc).AddTicks(7088), false, "Monahan, Lindgren and Walsh", null },
                    { 2, "Rerum aut temporibus ea assumenda et. Possimus inventore in esse dolore ratione earum. Quia ex est doloribus accusamus. Aperiam totam ut.", new DateTime(2024, 12, 8, 23, 3, 10, 959, DateTimeKind.Utc).AddTicks(7900), false, "Kunde and Sons", null },
                    { 3, "Magnam dolore omnis voluptatibus est omnis tenetur. Ut quia aut quos magni nemo. Natus aut aut fugit fugit occaecati velit. Velit facilis reiciendis reiciendis velit et at iure animi hic. Quo temporibus itaque ut dolorum a necessitatibus et et voluptas. Magnam vero ab asperiores quasi id saepe.", new DateTime(2024, 12, 8, 23, 3, 10, 959, DateTimeKind.Utc).AddTicks(8235), false, "Raynor Group", null },
                    { 4, "In impedit corporis commodi aspernatur et repudiandae quo exercitationem. Suscipit et dolores. Officiis aut tenetur aut ducimus. Adipisci et quidem et fuga. Non similique voluptas quia error.", new DateTime(2024, 12, 8, 23, 3, 10, 959, DateTimeKind.Utc).AddTicks(8565), false, "Prohaska Group", null },
                    { 5, "Quo eligendi velit fuga quibusdam qui voluptatem omnis illum. Quis et nulla. Aspernatur quia et voluptatem expedita eos neque. Incidunt laboriosam adipisci debitis.", new DateTime(2024, 12, 8, 23, 3, 10, 959, DateTimeKind.Utc).AddTicks(8772), false, "Kiehn Inc", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "EditCount", "ImagePath", "IsDeleted", "LastEditorId", "Price", "PrimaryGenreId", "PublisherId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(2179), "Eaque velit illo laboriosam dolor saepe ab maxime recusandae eos. Assumenda expedita facere at id rerum autem velit. Tempore tempore quia magnam assumenda. Et aut quibusdam repellendus magnam consequatur. Omnis reiciendis aut. Officiis quas quidem consequatur aut nisi ut rem nemo.", 0, "https://picsum.photos/640/480/?image=482", false, null, 96.91m, 4, 1, "Expedita consequatur sunt.", null },
                    { 2, 4, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(4513), "Minima magnam non fuga. Occaecati autem iure aliquam. Soluta delectus explicabo nostrum repellat ratione. Deserunt aut numquam officia reiciendis ea autem odio quo et. Nisi ad impedit culpa et voluptatem aliquid quis consequatur libero.", 0, "https://picsum.photos/640/480/?image=248", false, null, 40.62m, 3, 5, "Cumque molestias magnam.", null },
                    { 3, 6, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(4739), "Voluptate quas veniam quia sit porro qui iusto. Sed consequuntur voluptatibus pariatur ex debitis id doloribus. Nesciunt dolore animi.", 0, "https://picsum.photos/640/480/?image=153", false, null, 33.83m, 6, 4, "Corporis est cum.", null },
                    { 4, 9, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(4867), "Nihil id recusandae ducimus. Sit id voluptas non ad rerum blanditiis consequuntur. Nobis quaerat nesciunt repudiandae quia iusto beatae consequatur reprehenderit.", 0, "https://picsum.photos/640/480/?image=711", false, null, 92.63m, 3, 1, "Distinctio dicta aut.", null },
                    { 5, 3, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(4962), "Amet dolor recusandae quis fugit. Tempora voluptatem aut dignissimos. Voluptatem aut provident qui veritatis unde.", 0, "https://picsum.photos/640/480/?image=666", false, null, 13.32m, 1, 3, "Quaerat placeat quia.", null },
                    { 6, 7, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5107), "Omnis quasi est debitis at vero ut. Adipisci consectetur laborum inventore enim qui laudantium illum impedit voluptatibus. Adipisci et qui animi natus. Atque odio atque iste at rem labore delectus quod.", 0, "https://picsum.photos/640/480/?image=51", false, null, 81.63m, 5, 3, "Aut quos consequuntur.", null },
                    { 7, 5, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5218), "Est qui nisi veritatis accusamus quia optio. Sed aperiam libero ducimus repudiandae eum amet quia omnis. Consequuntur natus eius alias magnam porro tenetur. Id et repellendus fugit id non impedit voluptatem nemo perspiciatis. Rerum et ullam explicabo incidunt hic et. Totam ea vel vel assumenda est.", 0, "https://picsum.photos/640/480/?image=775", false, null, 73.81m, 4, 4, "Autem id qui.", null },
                    { 8, 8, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5408), "Laudantium vel itaque accusantium aut et est et. Mollitia expedita laboriosam quia earum dolores. Possimus voluptatibus a.", 0, "https://picsum.photos/640/480/?image=699", false, null, 31.67m, 5, 5, "Corrupti officia minima.", null },
                    { 9, 9, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5526), "Sapiente ut saepe autem voluptas qui provident deserunt expedita. Quisquam saepe est debitis est. Ratione in nesciunt. Consequatur qui eum est quo ratione magnam exercitationem. Iure necessitatibus explicabo vero qui alias sapiente quam ipsum.", 0, "https://picsum.photos/640/480/?image=436", false, null, 51.72m, 2, 2, "Consequatur veritatis fugit.", null },
                    { 10, 1, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5679), "Temporibus reprehenderit voluptatum qui. Est est libero iusto qui dolor dicta expedita mollitia id. Reiciendis repellat error autem fuga est voluptate voluptas et nihil. Molestiae velit voluptas cum iste labore reprehenderit in aliquam hic. Eaque quos vero et in esse. Culpa aut culpa voluptatem.", 0, "https://picsum.photos/640/480/?image=522", false, null, 78.15m, 5, 1, "Ut et harum.", null },
                    { 11, 10, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5838), "Delectus veniam sequi quam ipsum sint voluptatem enim. Totam sint ut rem quo. Reiciendis modi quis libero. Pariatur necessitatibus eos officia. Aut veritatis repellat omnis doloremque consequatur delectus atque est. Qui qui accusamus corporis accusantium.", 0, "https://picsum.photos/640/480/?image=149", false, null, 85.82m, 6, 5, "Ipsum possimus est.", null },
                    { 12, 3, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(5961), "Repellendus asperiores vero. Officiis nihil expedita debitis molestias sit neque sint. Rerum dolor dolorum enim nulla.", 0, "https://picsum.photos/640/480/?image=400", false, null, 42.73m, 1, 1, "Asperiores ut cumque.", null },
                    { 13, 8, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6127), "Qui velit excepturi ipsam omnis omnis velit in error. Nisi ea excepturi autem debitis reprehenderit. A ea commodi porro iusto porro repudiandae quia voluptas minima.", 0, "https://picsum.photos/640/480/?image=519", false, null, 37.20m, 4, 3, "Rerum in ad.", null },
                    { 14, 7, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6218), "Sunt facere non blanditiis ratione aut aut et. Voluptas labore dolor quia saepe. Dolor qui ea ut ipsa culpa quibusdam. Repellendus et natus suscipit.", 0, "https://picsum.photos/640/480/?image=561", false, null, 34.75m, 6, 2, "Nesciunt tenetur quidem.", null },
                    { 15, 7, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6365), "Ab natus nobis tenetur occaecati quisquam cum quam impedit. Excepturi et ut nam quo sit voluptates enim est. Est rerum perspiciatis est ipsam et debitis debitis tempore nesciunt. Quidem eum perferendis. Reprehenderit omnis corrupti natus officia iure rerum eos quia. Odio autem cumque blanditiis libero expedita quibusdam ea ad tempora.", 0, "https://picsum.photos/640/480/?image=981", false, null, 52.11m, 5, 3, "In mollitia rerum.", null },
                    { 16, 7, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6560), "Omnis est natus vel qui. Temporibus aut quisquam et maiores necessitatibus aut corporis. Nulla asperiores eum hic assumenda et quibusdam. Enim dolores quibusdam voluptas voluptatem doloribus quas molestias sapiente.", 0, "https://picsum.photos/640/480/?image=357", false, null, 82.34m, 2, 1, "Eos ullam sint.", null },
                    { 17, 6, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6724), "Possimus laboriosam magni. Quam libero omnis sed sunt nulla nostrum sed. Et ut consequuntur deleniti consequuntur in assumenda. Perferendis odio non dolores neque architecto.", 0, "https://picsum.photos/640/480/?image=20", false, null, 62.73m, 3, 4, "Architecto cum illo.", null },
                    { 18, 10, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6814), "Ipsum voluptatem sapiente dolor ipsum nam corrupti. Repudiandae corrupti nesciunt eaque. Omnis voluptas voluptatum voluptatem blanditiis at eos ex. Qui ea iste deserunt culpa.", 0, "https://picsum.photos/640/480/?image=525", false, null, 23.59m, 6, 3, "Delectus alias quo.", null },
                    { 19, 7, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(6939), "In ea nihil aut sit placeat et nihil id. Iusto nostrum quae optio voluptate ut odio. Dolor ex tempora voluptate explicabo unde ex optio sit enim. Sapiente voluptas dolorem autem. Earum nam dignissimos.", 0, "https://picsum.photos/640/480/?image=753", false, null, 35.63m, 1, 5, "Delectus alias quibusdam.", null },
                    { 20, 7, new DateTime(2024, 12, 8, 23, 3, 10, 963, DateTimeKind.Utc).AddTicks(7085), "Porro id culpa. Sed et corrupti. Unde sit magni eaque labore odio quaerat rem minus. Qui et nobis. Id animi neque et sint occaecati et nam molestiae.", 0, "https://picsum.photos/640/480/?image=152", false, null, 10.15m, 2, 5, "Aut iusto est.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2203), false, null, 2 },
                    { 3, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2206), false, null, 3 },
                    { 4, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2207), false, null, 4 },
                    { 5, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2207), false, null, 5 },
                    { 6, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2207), false, null, 6 },
                    { 7, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2207), false, null, 7 },
                    { 8, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2208), false, null, 8 },
                    { 9, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2208), false, null, 9 },
                    { 10, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2208), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(2024, 12, 8, 23, 3, 10, 970, DateTimeKind.Utc).AddTicks(4884), "Beth.Pouros56@hotmail.com", "Beth Pouros", false, 12, 0m, null, 5 },
                    { 2, 15, new DateTime(2024, 12, 8, 23, 3, 10, 970, DateTimeKind.Utc).AddTicks(8020), "Nichole38@yahoo.com", "Nichole Hoeger", false, 5, 0m, null, 5 },
                    { 3, 3, new DateTime(2024, 12, 8, 23, 3, 10, 970, DateTimeKind.Utc).AddTicks(9198), "Abel80@gmail.com", "Abel Sipes", false, 10, 0m, null, 2 },
                    { 4, 12, new DateTime(2024, 12, 8, 23, 3, 10, 970, DateTimeKind.Utc).AddTicks(9932), "Delia_Frami29@gmail.com", "Delia Frami", false, 11, 0m, null, 3 },
                    { 5, 13, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(767), "Homer.Barton67@hotmail.com", "Homer Barton", false, 6, 0m, null, 5 },
                    { 6, 10, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(1489), "Cindy85@yahoo.com", "Cindy Walter", false, 5, 0m, null, 2 },
                    { 7, 1, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(2204), "Jamie_Hills@gmail.com", "Jamie Hills", false, 3, 0m, null, 4 },
                    { 8, 9, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(3120), "Sonja_Schultz84@gmail.com", "Sonja Schultz", false, 13, 0m, null, 10 },
                    { 9, 7, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(3834), "Lorenzo.Mosciski7@yahoo.com", "Lorenzo Mosciski", false, 13, 0m, null, 8 },
                    { 10, 4, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(4634), "Julie_Heidenreich@gmail.com", "Julie Heidenreich", false, 15, 0m, null, 10 },
                    { 11, 8, new DateTime(2024, 12, 8, 23, 3, 10, 971, DateTimeKind.Utc).AddTicks(5427), "Kristy_DAmore14@gmail.com", "Kristy D'Amore", false, 13, 0m, null, 4 },
                    { 12, 13, new DateTime(2024, 12, 8, 23, 3, 10, 973, DateTimeKind.Utc).AddTicks(1853), "Hubert_Schmitt@gmail.com", "Hubert Schmitt", false, 14, 0m, null, 6 },
                    { 13, 6, new DateTime(2024, 12, 8, 23, 3, 10, 973, DateTimeKind.Utc).AddTicks(2884), "Bethany.Erdman@yahoo.com", "Bethany Erdman", false, 15, 0m, null, 4 },
                    { 14, 10, new DateTime(2024, 12, 8, 23, 3, 10, 973, DateTimeKind.Utc).AddTicks(3750), "Stuart46@hotmail.com", "Stuart Brown", false, 5, 0m, null, 4 },
                    { 15, 6, new DateTime(2024, 12, 8, 23, 3, 10, 973, DateTimeKind.Utc).AddTicks(4497), "Nettie.Abernathy@hotmail.com", "Nettie Abernathy", false, 7, 0m, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 18, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(213), false, 1, 99.94m, 1, null },
                    { 2, 13, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1515), false, 12, 68.84m, 3, null },
                    { 3, 7, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1568), false, 7, 95.96m, 1, null },
                    { 4, 19, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1580), false, 12, 66.04m, 3, null },
                    { 5, 18, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1589), false, 1, 61.97m, 3, null },
                    { 6, 19, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1596), false, 7, 80.39m, 3, null },
                    { 7, 1, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1604), false, 11, 55.01m, 2, null },
                    { 8, 19, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1663), false, 2, 52.62m, 3, null },
                    { 9, 16, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1672), false, 9, 40.17m, 1, null },
                    { 10, 15, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1679), false, 15, 17.42m, 1, null },
                    { 11, 17, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1687), false, 7, 34.00m, 3, null },
                    { 12, 10, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1696), false, 14, 79.41m, 3, null },
                    { 13, 2, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1704), false, 15, 53.07m, 1, null },
                    { 14, 5, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1712), false, 12, 70.16m, 3, null },
                    { 15, 14, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1720), false, 5, 94.99m, 1, null },
                    { 16, 2, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1727), false, 5, 35.97m, 1, null },
                    { 17, 20, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1735), false, 5, 39.61m, 3, null },
                    { 18, 17, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1743), false, 9, 52.28m, 2, null },
                    { 19, 20, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1750), false, 15, 26.90m, 3, null },
                    { 20, 2, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1758), false, 2, 18.06m, 1, null },
                    { 21, 14, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1766), false, 5, 56.99m, 1, null },
                    { 22, 15, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1773), false, 12, 93.03m, 2, null },
                    { 23, 1, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1791), false, 9, 28.61m, 3, null },
                    { 24, 6, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1799), false, 9, 66.41m, 2, null },
                    { 25, 9, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1806), false, 12, 98.45m, 1, null },
                    { 26, 12, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1813), false, 2, 86.55m, 3, null },
                    { 27, 1, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1820), false, 7, 29.45m, 2, null },
                    { 28, 9, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1827), false, 11, 67.89m, 1, null },
                    { 29, 4, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1835), false, 3, 78.63m, 1, null },
                    { 30, 4, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1842), false, 7, 70.89m, 3, null },
                    { 31, 8, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1849), false, 2, 74.03m, 3, null },
                    { 32, 10, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1857), false, 10, 19.21m, 1, null },
                    { 33, 4, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1865), false, 12, 63.99m, 2, null },
                    { 34, 16, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1872), false, 6, 84.57m, 2, null },
                    { 35, 7, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1879), false, 9, 84.77m, 3, null },
                    { 36, 2, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1887), false, 10, 78.58m, 1, null },
                    { 37, 11, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1894), false, 1, 79.32m, 1, null },
                    { 38, 12, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1901), false, 3, 49.23m, 2, null },
                    { 39, 10, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1909), false, 4, 51.66m, 3, null },
                    { 40, 16, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1950), false, 6, 12.77m, 1, null },
                    { 41, 5, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1958), false, 11, 90.70m, 2, null },
                    { 42, 15, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1967), false, 3, 49.66m, 1, null },
                    { 43, 5, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1974), false, 5, 99.82m, 3, null },
                    { 44, 19, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1981), false, 4, 96.52m, 1, null },
                    { 45, 14, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1989), false, 15, 73.39m, 1, null },
                    { 46, 3, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(1997), false, 15, 18.94m, 2, null },
                    { 47, 13, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2004), false, 3, 31.17m, 1, null },
                    { 48, 8, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2012), false, 5, 15.73m, 3, null },
                    { 49, 10, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2019), false, 11, 56.97m, 3, null },
                    { 50, 11, new DateTime(2024, 12, 8, 23, 3, 10, 975, DateTimeKind.Utc).AddTicks(2026), false, 13, 28.76m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 18, "Sit est quia maiores quia et eum explicabo optio voluptatem.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(3438), false, 2, null, 5 },
                    { 2, 13, "Aut dolores corrupti tempora qui facere laboriosam.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4734), false, 2, null, 3 },
                    { 3, 10, "Magni at sapiente omnis blanditiis.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4818), false, 2, null, 9 },
                    { 4, 2, "Necessitatibus nesciunt nemo corrupti commodi quia sed.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4842), false, 4, null, 4 },
                    { 5, 18, "Est totam dolorem ullam neque fugit voluptas enim error eos.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4866), false, 4, null, 3 },
                    { 6, 18, "Assumenda deleniti laborum optio velit aut dolore.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4896), false, 4, null, 10 },
                    { 7, 16, "Debitis distinctio rerum et et ipsam amet architecto corrupti veritatis.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4917), false, 2, null, 5 },
                    { 8, 6, "Et voluptas ratione qui rerum sequi illo asperiores.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(4949), false, 1, null, 2 },
                    { 9, 4, "Odit est ipsa et doloremque cumque et.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5081), false, 1, null, 2 },
                    { 10, 15, "Eveniet voluptatum dicta est nam mollitia alias voluptatum voluptatem.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5106), false, 2, null, 4 },
                    { 11, 19, "Vitae sed suscipit minus aut at consequatur voluptates vel.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5134), false, 4, null, 2 },
                    { 12, 20, "Aspernatur reiciendis non et consequatur rerum facere dolorum dolores.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5161), false, 1, null, 7 },
                    { 13, 7, "Quos voluptatem est omnis perferendis molestiae velit assumenda iste voluptatibus.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5188), false, 2, null, 3 },
                    { 14, 2, "Et nisi laudantium.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5216), false, 4, null, 8 },
                    { 15, 14, "Veritatis nisi voluptas nam.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5232), false, 3, null, 3 },
                    { 16, 1, "A et et omnis.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5305), false, 4, null, 4 },
                    { 17, 16, "Reiciendis neque nihil.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5322), false, 2, null, 6 },
                    { 18, 13, "Ab voluptates facilis qui dignissimos dolor et dolor.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5337), false, 5, null, 6 },
                    { 19, 16, "Accusamus dolores sint nisi repellendus optio.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5361), false, 2, null, 9 },
                    { 20, 12, "Ut iure qui harum voluptates ipsa.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5380), false, 1, null, 8 },
                    { 21, 6, "Ut eligendi corrupti et magni molestias.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5401), false, 2, null, 6 },
                    { 22, 15, "Asperiores labore enim.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5421), false, 4, null, 2 },
                    { 23, 10, "Sed id molestias saepe officiis maxime quod.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5435), false, 5, null, 9 },
                    { 24, 7, "Quam hic molestiae ipsa nisi ab excepturi non eum.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5456), false, 1, null, 2 },
                    { 25, 1, "Expedita in magni in ea magni omnis.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5518), false, 2, null, 9 },
                    { 26, 3, "Impedit ut sint.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5541), false, 4, null, 2 },
                    { 27, 7, "Cumque accusantium maiores non occaecati aliquid ea rerum.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5554), false, 1, null, 3 },
                    { 28, 14, "Neque error natus alias et voluptatem.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5578), false, 4, null, 7 },
                    { 29, 20, "Quis non molestias molestiae.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5598), false, 2, null, 6 },
                    { 30, 7, "Quas consequuntur et dolore.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5614), false, 2, null, 7 },
                    { 31, 12, "Similique voluptas doloremque quo aspernatur voluptatem beatae.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5631), false, 3, null, 9 },
                    { 32, 15, "Aut omnis odit.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5654), false, 2, null, 5 },
                    { 33, 3, "Labore vitae debitis sint magnam sed.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5711), false, 2, null, 10 },
                    { 34, 20, "Perspiciatis quas iure itaque officiis molestias dolores.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5734), false, 1, null, 2 },
                    { 35, 4, "Porro consequatur dolore id aut pariatur sunt.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5755), false, 5, null, 3 },
                    { 36, 13, "Veniam quo aut dignissimos consequatur eum et modi.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5776), false, 4, null, 7 },
                    { 37, 14, "Dignissimos esse iure ut id reprehenderit.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5800), false, 1, null, 8 },
                    { 38, 16, "Accusantium cupiditate incidunt maiores et.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5820), false, 4, null, 9 },
                    { 39, 3, "Consequatur quos impedit nisi non ea aut molestias consectetur ut.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5838), false, 1, null, 3 },
                    { 40, 10, "Sint nisi est ullam numquam.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5865), false, 2, null, 3 },
                    { 41, 10, "Est quibusdam nam fuga.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5920), false, 3, null, 8 },
                    { 42, 4, "Ipsum culpa consequuntur molestiae inventore.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5939), false, 3, null, 2 },
                    { 43, 1, "Rerum corrupti ut.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5958), false, 4, null, 8 },
                    { 44, 9, "Nulla officiis iusto.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5973), false, 4, null, 5 },
                    { 45, 15, "Nisi aperiam id.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5986), false, 3, null, 5 },
                    { 46, 8, "Nihil in veritatis vel dolorem velit.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(5999), false, 5, null, 2 },
                    { 47, 3, "Voluptates consequatur minima et temporibus qui voluptas aut tempora autem.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(6019), false, 2, null, 4 },
                    { 48, 1, "Ipsam esse necessitatibus fuga dolore optio.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(6049), false, 5, null, 6 },
                    { 49, 14, "Incidunt doloribus eum.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(6068), false, 2, null, 3 },
                    { 50, 16, "Aperiam molestiae distinctio debitis nemo ullam.", new DateTime(2024, 12, 8, 23, 3, 10, 965, DateTimeKind.Utc).AddTicks(6116), false, 5, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 19, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1548), false, null, 5 },
                    { 2, 19, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1720), false, null, 5 },
                    { 3, 1, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1728), false, null, 4 },
                    { 4, 14, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1732), false, null, 4 },
                    { 5, 7, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1736), false, null, 5 },
                    { 6, 3, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1739), false, null, 10 },
                    { 7, 13, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1742), false, null, 8 },
                    { 8, 9, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1745), false, null, 4 },
                    { 9, 1, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1748), false, null, 5 },
                    { 10, 18, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1751), false, null, 2 },
                    { 11, 2, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1755), false, null, 9 },
                    { 12, 10, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1758), false, null, 10 },
                    { 13, 8, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1761), false, null, 6 },
                    { 14, 14, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1764), false, null, 8 },
                    { 15, 10, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1767), false, null, 4 },
                    { 16, 6, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1770), false, null, 6 },
                    { 17, 2, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1774), false, null, 8 },
                    { 18, 11, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1777), false, null, 8 },
                    { 19, 20, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1780), false, null, 2 },
                    { 20, 14, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1784), false, null, 10 },
                    { 21, 11, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1787), false, null, 4 },
                    { 22, 3, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1790), false, null, 6 },
                    { 23, 13, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1793), false, null, 10 },
                    { 24, 10, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1796), false, null, 3 },
                    { 25, 9, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1799), false, null, 10 },
                    { 26, 17, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1803), false, null, 3 },
                    { 27, 15, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1806), false, null, 3 },
                    { 28, 12, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1809), false, null, 2 },
                    { 29, 3, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1812), false, null, 8 },
                    { 30, 17, new DateTime(2024, 12, 8, 23, 3, 10, 967, DateTimeKind.Utc).AddTicks(1815), false, null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookGenreLink_BookId",
                table: "BookGenreLink",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenreLink_GenreId",
                table: "BookGenreLink",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LastEditorId",
                table: "Books",
                column: "LastEditorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PrimaryGenreId",
                table: "Books",
                column: "PrimaryGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookId",
                table: "CartItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BookId",
                table: "OrderItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressId",
                table: "Orders",
                column: "BillingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_BookId",
                table: "WishlistItems",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_UserId",
                table: "WishlistItems",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookGenreLink");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "WishlistItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
