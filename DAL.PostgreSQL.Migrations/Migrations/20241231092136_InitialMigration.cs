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
                name: "GiftCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PriceReduction = table.Column<decimal>(type: "numeric", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiftCards", x => x.Id);
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
                    OrderState = table.Column<int>(type: "integer", nullable: false),
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
                name: "Coupons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: false),
                    GiftCardId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_GiftCards_GiftCardId",
                        column: x => x.GiftCardId,
                        principalTable: "GiftCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Coupons_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
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
                    { 1, "New Jamar", "Canada", new DateTime(2024, 12, 31, 9, 21, 36, 328, DateTimeKind.Utc).AddTicks(8910), false, "Kentucky", "3056 Rebekah Village", null, "29845-4086" },
                    { 2, "Isadorefort", "Puerto Rico", new DateTime(2024, 12, 31, 9, 21, 36, 328, DateTimeKind.Utc).AddTicks(9523), false, "Michigan", "583 Schmidt Mill", null, "36528" },
                    { 3, "Angelmouth", "New Caledonia", new DateTime(2024, 12, 31, 9, 21, 36, 328, DateTimeKind.Utc).AddTicks(9733), false, "Kansas", "576 Erdman Islands", null, "36181" },
                    { 4, "Elmerton", "Sierra Leone", new DateTime(2024, 12, 31, 9, 21, 36, 328, DateTimeKind.Utc).AddTicks(9879), false, "Mississippi", "15808 Barbara Camp", null, "33210-9336" },
                    { 5, "Port Magali", "Puerto Rico", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(15), false, "Rhode Island", "91770 Konopelski Locks", null, "55705-4571" },
                    { 6, "Olaport", "Mayotte", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(151), false, "Rhode Island", "700 Bessie Junctions", null, "77845-2773" },
                    { 7, "West Kamilleview", "Luxembourg", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(280), false, "Alabama", "9631 Hickle Station", null, "31812" },
                    { 8, "Boehmtown", "Armenia", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(423), false, "Hawaii", "37967 Delores Court", null, "41290-5621" },
                    { 9, "New Linwood", "Bahrain", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(572), false, "Mississippi", "77885 Sydni Cape", null, "61144-4711" },
                    { 10, "West Bella", "Norfolk Island", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(671), false, "Kentucky", "7870 Eleonore Inlet", null, "79721-6837" },
                    { 11, "Prestonmouth", "Panama", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(784), false, "South Carolina", "1813 Farrell Trail", null, "59671" },
                    { 12, "North Chelsie", "Azerbaijan", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(940), false, "Indiana", "0365 King Tunnel", null, "96087-7173" },
                    { 13, "Port Moisesshire", "Belize", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(1073), false, "Rhode Island", "1607 Samson Walk", null, "44786-3159" },
                    { 14, "Port Giuseppebury", "Norfolk Island", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(1203), false, "Rhode Island", "897 Myra Ferry", null, "42368" },
                    { 15, "Majorstad", "Japan", new DateTime(2024, 12, 31, 9, 21, 36, 329, DateTimeKind.Utc).AddTicks(1357), false, "Massachusetts", "7680 Zoe Plains", null, "31405-2167" }
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
                    { 1, 0, "4674faa2-a6bf-4729-b826-405dd07557e9", "admin@admin.com", true, false, null, "Admin User", null, null, null, "123-456-7890", false, "a1e24f02-dab7-4d54-8814-8ae1991e503b", false, "admin@admin.com" },
                    { 2, 0, "fe9aad00-ab55-4f3f-9498-d5892aa75fe6", "Jordan.Kshlerin81@yahoo.com", true, false, null, "Kristofer Jones", null, null, null, "(651) 242-2896 x51689", false, "f3d8fb9e-44aa-4902-82cd-b7f5d0993517", false, "Jordan.Kshlerin81@yahoo.com" },
                    { 3, 0, "d4179361-2190-4ae5-b93d-aedca48983cf", "Gabe93@yahoo.com", true, false, null, "Hanna Langworth", null, null, null, "1-658-594-4575 x584", false, "634ef4d7-461c-41a5-8872-fd25fbfe69f9", false, "Gabe93@yahoo.com" },
                    { 4, 0, "0bd07aa9-ac37-4a79-a6ec-9c9fe97565d6", "Iva.Raynor63@yahoo.com", true, false, null, "Herminio Dietrich", null, null, null, "(878) 743-3537", false, "80b16d4d-b439-43bc-95ac-cfd373f30334", false, "Iva.Raynor63@yahoo.com" },
                    { 5, 0, "38c211e1-c1ef-4f98-8c40-92f61ff16a54", "Zoie_Schmidt58@yahoo.com", true, false, null, "Rosalia Renner", null, null, null, "269-574-2258 x67373", false, "b5e90367-70ed-4817-a806-0bbd07a206e3", false, "Zoie_Schmidt58@yahoo.com" },
                    { 6, 0, "6e50c9a4-139d-4cd5-8a73-979e08953718", "Rebekah_Dickens55@yahoo.com", true, false, null, "Madeline Hessel", null, null, null, "401.930.4676", false, "c70bdc86-07c9-4330-ab30-d030adba447d", false, "Rebekah_Dickens55@yahoo.com" },
                    { 7, 0, "607b87f2-e6ea-419a-bcd4-7216b6666ba9", "Daniela24@yahoo.com", true, false, null, "Keyshawn Frami", null, null, null, "(262) 594-6482 x62295", false, "a6ab941b-e0be-4e4e-baf0-ce6837b8224c", false, "Daniela24@yahoo.com" },
                    { 8, 0, "ccf5d6ec-583d-4e05-8efa-e4fdd5b618cc", "Dawson.Ankunding20@gmail.com", true, false, null, "Darrick Wuckert", null, null, null, "923.481.6881 x43390", false, "a312ddf4-056b-4e57-aad7-795b7ea26337", false, "Dawson.Ankunding20@gmail.com" },
                    { 9, 0, "ef288d27-f173-4224-8fb2-2d5c7d1a6043", "Joshua.Kunze67@yahoo.com", true, false, null, "Felipa Dooley", null, null, null, "(614) 887-3019 x2869", false, "2a400862-8c64-4e05-bdc0-01364c77f140", false, "Joshua.Kunze67@yahoo.com" },
                    { 10, 0, "e9ea78e5-f5e1-4a5d-9b1e-b4cbeceeff9b", "Everette_Marquardt@hotmail.com", true, false, null, "Chaim Howe", null, null, null, "910.691.9185 x16414", false, "316be3f8-434d-4b2d-b099-73d2a4730870", false, "Everette_Marquardt@hotmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ipsa qui non in asperiores. Illo sed neque sit. Nemo quam non voluptatibus dolorem animi. Ab voluptatem aut earum sed eum cum. Qui quo debitis maxime quis accusamus optio. Ullam reprehenderit qui et consequatur illum voluptas ullam.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(7968), false, "Braulio Kerluke", null },
                    { 2, "Aut occaecati laboriosam culpa. Inventore accusantium iure eum. Aut minus ea unde eius numquam. Asperiores aut in tenetur aut non sint. Eum esse iure.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8378), false, "Darrin Schuppe", null },
                    { 3, "Consequuntur ut excepturi alias nobis sed sit. Quo voluptas fugiat expedita animi beatae molestiae accusamus hic quis. Exercitationem quis qui adipisci.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8480), false, "Erna Parker", null },
                    { 4, "Id laboriosam ea. Repellat a adipisci molestias. Ad numquam eum aperiam quia quisquam expedita. Amet sed quasi neque ut iusto omnis. Accusantium quibusdam voluptatem quisquam dignissimos sunt fuga eveniet labore itaque.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8594), false, "Ceasar Homenick", null },
                    { 5, "Repellat inventore expedita. Qui et inventore sed repudiandae inventore eos commodi delectus nam. Praesentium facilis qui numquam fugit incidunt quam. Distinctio odit delectus atque nihil.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8697), false, "Laverne Miller", null },
                    { 6, "Et qui magnam repellat sunt laboriosam quos et. Iste laboriosam neque odit amet explicabo ut. In nobis quia impedit natus accusantium.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8806), false, "Gayle Cummerata", null },
                    { 7, "Nemo qui eius est. Ut tenetur beatae et doloribus voluptas sunt. Deleniti magni iure aut voluptatem. Ut perspiciatis in doloremque. Hic rem sapiente ea voluptas.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8868), false, "Leatha Gulgowski", null },
                    { 8, "Esse sint illo tenetur delectus voluptatem officiis modi illum voluptatem. Sit quaerat officia. Vel id velit soluta molestiae libero sint sint. Animi sint cupiditate et omnis. Modi quos soluta est omnis ea consequuntur aut. Eaque molestiae libero optio perferendis corrupti sit aut iusto.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(8976), false, "Francisca Heathcote", null },
                    { 9, "Accusantium dolore ad cupiditate blanditiis impedit. Ipsam quo id dolorum sint accusamus. Sit ducimus praesentium quia fugiat expedita est quos dolorum dolor. Quibusdam nostrum rem ut earum doloremque repellat qui.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(9104), false, "Candelario Tremblay", null },
                    { 10, "Voluptatum ducimus nostrum unde tenetur illo doloribus. Voluptatem repellendus quia nihil illum enim ad harum. Reprehenderit facere voluptas nihil. Est placeat explicabo sunt in. Aut sed dicta ut ipsa sed numquam qui.", new DateTime(2024, 12, 31, 9, 21, 36, 320, DateTimeKind.Utc).AddTicks(9186), false, "Arden Keebler", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fantasy" },
                    { 2, "Horror" },
                    { 3, "Science Fiction" },
                    { 4, "Mystery" },
                    { 5, "Romance" },
                    { 6, "Thriller" },
                    { 7, "Historical Fiction" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Eum esse debitis aspernatur eos nihil facilis. Eum laudantium quam. Ab sit nam aut suscipit nam et porro est. Autem rem error ut voluptas.", new DateTime(2024, 12, 31, 9, 21, 36, 322, DateTimeKind.Utc).AddTicks(4471), false, "Borer and Sons", null },
                    { 2, "Quam rerum doloribus facilis in nulla quod unde qui aut. Eum debitis laudantium ipsa doloremque. Consequatur maiores quo est eius est delectus itaque excepturi ab. Aut voluptate rerum facere et omnis maxime qui animi.", new DateTime(2024, 12, 31, 9, 21, 36, 322, DateTimeKind.Utc).AddTicks(5091), false, "Dickens - Langworth", null },
                    { 3, "Molestias adipisci est magnam voluptatem. Ut provident cumque molestiae omnis dolore veniam et deleniti. Nisi voluptatem est vero inventore.", new DateTime(2024, 12, 31, 9, 21, 36, 322, DateTimeKind.Utc).AddTicks(5290), false, "Fadel, Thiel and Ebert", null },
                    { 4, "Soluta doloribus omnis quibusdam non enim dolores. Fugiat optio itaque velit nulla ea voluptatibus voluptatem sunt eum. Harum ex et tempore explicabo deserunt debitis. Ipsam quia quidem voluptatem. Nihil fugiat velit est sint aut autem aut. Fuga aperiam animi aspernatur eveniet eos nihil dolores.", new DateTime(2024, 12, 31, 9, 21, 36, 322, DateTimeKind.Utc).AddTicks(5488), false, "Schowalter, Rath and Hoppe", null },
                    { 5, "Assumenda et illum. Occaecati dolorum architecto qui est numquam. Cum molestiae itaque saepe maxime.", new DateTime(2024, 12, 31, 9, 21, 36, 322, DateTimeKind.Utc).AddTicks(5751), false, "Schoen - Botsford", null }
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
                    { 1, 9, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(871), "Enim quis et voluptas non laudantium eos. Iure aut sint doloribus tenetur aut. Nobis qui autem illum optio dicta quia blanditiis earum sed. Voluptas modi delectus rerum. Natus possimus eveniet libero ipsa facere iusto labore. Inventore earum sit blanditiis numquam.", 0, "/images/cover-9.jpg", false, null, 88.94m, 4, 5, "Perferendis nemo sit.", null },
                    { 2, 7, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(2814), "Rem non quaerat voluptatum aut consequuntur aut error. Qui voluptas autem sit ad non possimus labore tempore. Facere id porro. Laudantium sunt dolor rem explicabo aut asperiores dolores. Quisquam ea est facilis. Sit et eum quia ad.", 0, "/images/cover-3.jpg", false, null, 77.36m, 5, 4, "Praesentium alias eum.", null },
                    { 3, 3, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3009), "Deserunt exercitationem et minima possimus repellat deleniti quam et. Numquam ut delectus sed aliquam. Quaerat suscipit debitis. Non laboriosam omnis libero exercitationem.", 0, "/images/cover-5.jpg", false, null, 49.54m, 6, 5, "Officia sit optio.", null },
                    { 4, 7, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3097), "Recusandae voluptatem exercitationem sit blanditiis eaque cumque fuga. Non voluptates soluta perspiciatis earum aspernatur quam. Ad vel dolor facere reprehenderit quia quis quam dolorum temporibus. Enim repellat ducimus rem harum sint illo. Qui doloremque ut et quasi similique nisi ipsum earum.", 0, "/images/cover-9.jpg", false, null, 41.63m, 6, 4, "Eum corrupti libero.", null },
                    { 5, 8, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3249), "Commodi laboriosam qui. Ut non quaerat voluptas. Nemo nihil accusamus temporibus qui consequatur qui aut exercitationem.", 0, "/images/cover-9.jpg", false, null, 24.11m, 7, 5, "Accusantium et sit.", null },
                    { 6, 8, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3311), "Commodi similique ut quia id et. Soluta illo unde ut. Omnis tempore mollitia eos et ea voluptatem sed aut est. Ducimus et qui in quam unde. Debitis sequi accusamus quod et corrupti beatae voluptatem consequuntur.", 0, "/images/cover-4.jpg", false, null, 16.75m, 3, 3, "Quam qui ut.", null },
                    { 7, 2, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3424), "Nisi alias quibusdam in labore blanditiis quam doloremque. Dolore soluta est tempora qui aut dicta. Sint praesentium odio maxime quae libero praesentium ea. Vitae expedita quod omnis laudantium maiores eaque. Nisi est tempora. Ea id odit sed facere natus illo modi.", 0, "/images/cover-5.jpg", false, null, 50.45m, 5, 4, "Sed rerum sunt.", null },
                    { 8, 8, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3605), "Quo consectetur aut quia molestiae aperiam quo dicta qui id. Voluptates similique nam accusantium impedit libero optio consequatur nobis fugit. Ad soluta illum enim est earum. Dolores aut et voluptas aspernatur.", 0, "/images/cover-8.jpg", false, null, 24.16m, 2, 1, "Et eum est.", null },
                    { 9, 1, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3771), "Et cum pariatur optio voluptates ipsa. Quisquam aliquam maxime ducimus neque vel accusantium. Et ut quis nam reprehenderit nostrum ipsum odit qui dolorem. Quis necessitatibus voluptatibus ducimus aspernatur est at sit deleniti. Consequatur perferendis dolorem. Nesciunt architecto quia sed.", 0, "/images/cover-9.jpg", false, null, 33.89m, 1, 2, "Sed molestias velit.", null },
                    { 10, 10, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(3885), "Laborum sed cum ut voluptatem hic quis sapiente harum. Consequatur officia et qui earum mollitia ea expedita ut voluptatem. Autem voluptas nesciunt officia eum vel culpa odio. Velit quas rem ea eveniet quam qui sint omnis. Et magnam aut dolorem.", 0, "/images/cover-10.jpg", false, null, 93.67m, 2, 3, "Consectetur velit voluptatem.", null },
                    { 11, 7, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4015), "Pariatur aliquid id dicta iste vel sed accusamus. Eos maxime magnam dolores provident et consectetur accusantium deleniti. Voluptas excepturi id molestiae impedit dignissimos modi officia ducimus.", 0, "/images/cover-6.jpg", false, null, 35.89m, 2, 3, "Ad vel cumque.", null },
                    { 12, 5, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4113), "Rerum facilis et beatae ut sunt facilis nemo a. Ea ducimus quod placeat consequatur aperiam nisi. Possimus aut aperiam modi voluptas ab nostrum consequatur. Corrupti enim labore vel itaque modi eveniet neque rerum omnis. Totam placeat et nam.", 0, "/images/cover-3.jpg", false, null, 94.76m, 3, 2, "Nam ipsam et.", null },
                    { 13, 6, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4212), "Et blanditiis voluptas voluptatibus est provident quod praesentium id dolore. Eius corrupti magnam autem ea ea. Nostrum quasi deleniti eos possimus. Modi enim labore id sit. Provident impedit rem earum.", 0, "/images/cover-10.jpg", false, null, 52.47m, 7, 5, "Recusandae at architecto.", null },
                    { 14, 3, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4322), "A delectus eos fugiat distinctio veritatis placeat eveniet. Tempora odio quae mollitia a soluta praesentium. Nemo eos ea eligendi molestias odit excepturi accusamus natus.", 0, "/images/cover-5.jpg", false, null, 57.60m, 3, 4, "Eligendi sit animi.", null },
                    { 15, 4, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4418), "Recusandae exercitationem laborum quo est. Saepe sapiente et cumque. Illum excepturi distinctio debitis nisi.", 0, "/images/cover-2.jpg", false, null, 31.22m, 4, 2, "Qui incidunt quis.", null },
                    { 16, 8, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4469), "Molestiae laborum qui. Quis neque qui in et nostrum eum odit non. Corporis accusamus tenetur non commodi eveniet delectus. Labore inventore esse ea ea perspiciatis est. Natus vel eveniet repellendus.", 0, "/images/cover-6.jpg", false, null, 66.35m, 1, 4, "Ea et aut.", null },
                    { 17, 5, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4578), "Esse vitae qui sit et. A minima quibusdam reprehenderit culpa. Quibusdam ipsum pariatur placeat maiores. Corrupti repudiandae non. Reiciendis est neque vel aliquam ut.", 0, "/images/cover-1.jpg", false, null, 39.94m, 6, 1, "Aut aut explicabo.", null },
                    { 18, 7, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4650), "Libero est est a et eos quod sed. Eaque cumque dolor non in ut vitae voluptas doloremque. Quia alias debitis blanditiis autem sed modi.", 0, "/images/cover-10.jpg", false, null, 95.99m, 4, 4, "Dolor voluptas praesentium.", null },
                    { 19, 2, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4729), "At sint totam perspiciatis. Nobis sapiente repudiandae occaecati atque sit tempore. Eos eveniet vel similique nesciunt consequatur est sunt eum ut. Quia dicta qui iusto quod. Neque perferendis voluptatem.", 0, "/images/cover-10.jpg", false, null, 13.29m, 1, 4, "In rem et.", null },
                    { 20, 6, new DateTime(2024, 12, 31, 9, 21, 36, 324, DateTimeKind.Utc).AddTicks(4860), "Dignissimos explicabo dignissimos maiores. Temporibus eum ea rem et voluptatem doloremque. Et perferendis eaque laborum nam quibusdam sint facere vitae et. Optio sapiente ut eum neque.", 0, "/images/cover-7.jpg", false, null, 32.26m, 2, 1, "Consequatur eos minus.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2964), false, null, 2 },
                    { 3, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2966), false, null, 3 },
                    { 4, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2966), false, null, 4 },
                    { 5, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2966), false, null, 5 },
                    { 6, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2967), false, null, 6 },
                    { 7, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2967), false, null, 7 },
                    { 8, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2967), false, null, 8 },
                    { 9, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2967), false, null, 9 },
                    { 10, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2968), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "OrderState", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 12, 31, 9, 21, 36, 330, DateTimeKind.Utc).AddTicks(4985), "Darlene97@yahoo.com", "Darlene O'Connell", false, 1, 6, 0m, null, 8 },
                    { 2, 6, new DateTime(2024, 12, 31, 9, 21, 36, 330, DateTimeKind.Utc).AddTicks(8343), "Cristina.Hayes@hotmail.com", "Cristina Hayes", false, 0, 15, 0m, null, 3 },
                    { 3, 5, new DateTime(2024, 12, 31, 9, 21, 36, 330, DateTimeKind.Utc).AddTicks(9579), "Archie.Mills@hotmail.com", "Archie Mills", false, 3, 15, 0m, null, 6 },
                    { 4, 14, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(199), "Caroline29@hotmail.com", "Caroline Johns", false, 2, 3, 0m, null, 4 },
                    { 5, 10, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(806), "Rex92@hotmail.com", "Rex Bahringer", false, 1, 15, 0m, null, 8 },
                    { 6, 8, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(1498), "Loretta_Bogisich37@yahoo.com", "Loretta Bogisich", false, 5, 7, 0m, null, 5 },
                    { 7, 2, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(2150), "Carlos_Kuhic84@hotmail.com", "Carlos Kuhic", false, 4, 11, 0m, null, 2 },
                    { 8, 11, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(2807), "Jose69@hotmail.com", "Jose Howell", false, 3, 1, 0m, null, 8 },
                    { 9, 15, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(3454), "Clayton18@hotmail.com", "Clayton Gorczany", false, 1, 5, 0m, null, 2 },
                    { 10, 1, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(4068), "Latoya30@yahoo.com", "Latoya Wilkinson", false, 1, 3, 0m, null, 5 },
                    { 11, 7, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(4632), "Nicholas.Hackett@gmail.com", "Nicholas Hackett", false, 5, 3, 0m, null, 9 },
                    { 12, 15, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(5302), "Earnest.Ebert57@gmail.com", "Earnest Ebert", false, 1, 7, 0m, null, 2 },
                    { 13, 8, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(5910), "Jack24@gmail.com", "Jack Emmerich", false, 0, 4, 0m, null, 2 },
                    { 14, 13, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(6467), "Edith_Johns@gmail.com", "Edith Johns", false, 4, 7, 0m, null, 3 },
                    { 15, 2, new DateTime(2024, 12, 31, 9, 21, 36, 331, DateTimeKind.Utc).AddTicks(7106), "Timothy27@gmail.com", "Timothy Becker", false, 2, 13, 0m, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 18, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(1082), false, 3, 31.42m, 3, null },
                    { 2, 16, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2279), false, 14, 36.95m, 1, null },
                    { 3, 7, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2333), false, 3, 77.28m, 1, null },
                    { 4, 10, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2345), false, 9, 37.20m, 1, null },
                    { 5, 2, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2354), false, 12, 69.23m, 3, null },
                    { 6, 15, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2361), false, 10, 85.44m, 3, null },
                    { 7, 18, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2369), false, 15, 58.86m, 1, null },
                    { 8, 18, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2376), false, 2, 91.85m, 3, null },
                    { 9, 2, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2426), false, 13, 47.90m, 3, null },
                    { 10, 19, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2435), false, 6, 19.28m, 2, null },
                    { 11, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2442), false, 9, 38.09m, 1, null },
                    { 12, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2450), false, 1, 44.32m, 2, null },
                    { 13, 15, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2457), false, 3, 79.65m, 2, null },
                    { 14, 3, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2464), false, 3, 94.12m, 2, null },
                    { 15, 3, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2471), false, 15, 17.87m, 3, null },
                    { 16, 15, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2478), false, 8, 18.16m, 2, null },
                    { 17, 15, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2485), false, 9, 40.13m, 2, null },
                    { 18, 5, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2492), false, 15, 21.66m, 2, null },
                    { 19, 14, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2554), false, 1, 12.75m, 3, null },
                    { 20, 13, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2562), false, 14, 72.15m, 1, null },
                    { 21, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2569), false, 9, 20.98m, 3, null },
                    { 22, 7, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2576), false, 4, 24.49m, 2, null },
                    { 23, 10, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2583), false, 2, 16.56m, 2, null },
                    { 24, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2590), false, 14, 29.07m, 3, null },
                    { 25, 14, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2597), false, 13, 69.02m, 3, null },
                    { 26, 15, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2605), false, 15, 38.51m, 2, null },
                    { 27, 6, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2611), false, 1, 85.12m, 1, null },
                    { 28, 2, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2618), false, 3, 96.91m, 3, null },
                    { 29, 2, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2625), false, 3, 58.81m, 1, null },
                    { 30, 20, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2633), false, 15, 17.97m, 2, null },
                    { 31, 13, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2639), false, 6, 48.77m, 1, null },
                    { 32, 3, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2646), false, 5, 64.35m, 2, null },
                    { 33, 20, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2653), false, 15, 63.15m, 2, null },
                    { 34, 14, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2660), false, 10, 57.14m, 1, null },
                    { 35, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2666), false, 12, 20.58m, 3, null },
                    { 36, 16, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2673), false, 6, 63.48m, 2, null },
                    { 37, 4, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2680), false, 5, 50.57m, 2, null },
                    { 38, 17, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2688), false, 4, 14.66m, 1, null },
                    { 39, 11, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2694), false, 2, 67.90m, 2, null },
                    { 40, 7, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2701), false, 15, 73.43m, 1, null },
                    { 41, 16, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2738), false, 15, 85.73m, 2, null },
                    { 42, 7, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2746), false, 11, 65.56m, 2, null },
                    { 43, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2754), false, 12, 95.97m, 1, null },
                    { 44, 2, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2761), false, 13, 26.21m, 2, null },
                    { 45, 10, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2768), false, 14, 57.46m, 2, null },
                    { 46, 16, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2774), false, 11, 24.66m, 1, null },
                    { 47, 5, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2782), false, 6, 42.04m, 1, null },
                    { 48, 19, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2789), false, 13, 42.96m, 2, null },
                    { 49, 14, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2796), false, 9, 51.90m, 2, null },
                    { 50, 12, new DateTime(2024, 12, 31, 9, 21, 36, 333, DateTimeKind.Utc).AddTicks(2803), false, 8, 38.79m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Ut in voluptates sequi.", new DateTime(2024, 12, 31, 9, 21, 36, 325, DateTimeKind.Utc).AddTicks(8943), false, 1, null, 3 },
                    { 2, 5, "Et nobis nulla placeat est porro sunt accusamus aliquam ullam.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(128), false, 2, null, 4 },
                    { 3, 11, "Et accusantium ut sed quia temporibus dicta omnis.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(245), false, 5, null, 6 },
                    { 4, 12, "Odit dolore quidem reiciendis ut qui nam suscipit illum sint.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(272), false, 5, null, 8 },
                    { 5, 5, "Illo voluptatem molestiae sunt quia iure.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(301), false, 3, null, 2 },
                    { 6, 4, "Cumque dolores est quibusdam aperiam.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(320), false, 1, null, 7 },
                    { 7, 2, "Est laboriosam officia.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(334), false, 5, null, 9 },
                    { 8, 13, "Aut enim ut.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(348), false, 3, null, 10 },
                    { 9, 11, "Laudantium laborum hic occaecati similique exercitationem saepe ea.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(360), false, 4, null, 6 },
                    { 10, 16, "Officiis vel in velit.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(385), false, 3, null, 3 },
                    { 11, 16, "Ut veniam at quod.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(399), false, 1, null, 8 },
                    { 12, 6, "Eligendi officiis nisi et maiores nihil expedita.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(441), false, 3, null, 5 },
                    { 13, 7, "Minus similique rerum ullam.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(461), false, 2, null, 10 },
                    { 14, 15, "Quibusdam harum commodi.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(475), false, 4, null, 10 },
                    { 15, 9, "Asperiores consequatur corrupti odio.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(486), false, 1, null, 6 },
                    { 16, 18, "Aut in saepe id adipisci ea quod aliquam voluptatem ipsa.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(499), false, 1, null, 4 },
                    { 17, 6, "Adipisci ab quisquam illo.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(523), false, 2, null, 3 },
                    { 18, 4, "Quia ipsa consequuntur labore non nesciunt rem quam sint.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(536), false, 4, null, 7 },
                    { 19, 17, "Magnam ex rerum non.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(557), false, 1, null, 2 },
                    { 20, 17, "Officiis debitis esse eum quo enim.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(598), false, 1, null, 5 },
                    { 21, 6, "Minus ut alias nobis.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(616), false, 3, null, 9 },
                    { 22, 18, "Nihil consequatur aperiam recusandae porro magni quibusdam eius in hic.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(630), false, 2, null, 7 },
                    { 23, 15, "Saepe odio voluptatibus hic atque maxime officiis blanditiis omnis.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(654), false, 4, null, 7 },
                    { 24, 20, "Aut non delectus.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(676), false, 1, null, 6 },
                    { 25, 3, "Consectetur necessitatibus corporis voluptates qui eligendi et qui.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(687), false, 5, null, 10 },
                    { 26, 16, "Et expedita sequi libero.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(708), false, 5, null, 10 },
                    { 27, 18, "Molestiae eos non ea fugit commodi rem.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(721), false, 4, null, 4 },
                    { 28, 10, "Molestiae quas optio temporibus officiis minus numquam veritatis quidem inventore.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(756), false, 3, null, 4 },
                    { 29, 11, "Possimus nihil sint libero nobis ipsum nisi.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(782), false, 3, null, 9 },
                    { 30, 18, "Itaque possimus voluptatibus ut est dolor quae.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(800), false, 5, null, 8 },
                    { 31, 3, "Exercitationem repudiandae dolores molestiae et repellat quos dolore et est.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(817), false, 2, null, 5 },
                    { 32, 9, "Culpa ex fuga debitis dolorum rerum nemo eos beatae.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(841), false, 3, null, 9 },
                    { 33, 16, "Rerum ut molestiae.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(864), false, 4, null, 5 },
                    { 34, 15, "Similique saepe nesciunt modi voluptates nihil tempore quaerat quia.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(876), false, 1, null, 6 },
                    { 35, 18, "Accusamus fugit sunt quisquam.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(963), false, 1, null, 9 },
                    { 36, 18, "Facere molestias magni hic.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(978), false, 2, null, 10 },
                    { 37, 8, "Quia iusto ullam sapiente vero iste magni possimus.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(991), false, 1, null, 10 },
                    { 38, 5, "Et molestiae quod quos repellat.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1011), false, 1, null, 5 },
                    { 39, 6, "Natus fuga vitae voluptatibus.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1025), false, 5, null, 10 },
                    { 40, 12, "Inventore omnis deleniti perferendis nesciunt et commodi nesciunt.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1037), false, 3, null, 5 },
                    { 41, 1, "Dolorem blanditiis vel maxime.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1055), false, 4, null, 6 },
                    { 42, 18, "Asperiores consequuntur dolores aliquid ut.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1069), false, 4, null, 3 },
                    { 43, 6, "Ad culpa pariatur deleniti inventore non hic nihil consequatur.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1085), false, 5, null, 8 },
                    { 44, 9, "Debitis corporis deserunt id.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1151), false, 1, null, 9 },
                    { 45, 13, "Occaecati aperiam voluptatum error est magnam culpa minima temporibus.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1165), false, 2, null, 9 },
                    { 46, 1, "Quis libero voluptatibus tempora quia numquam reprehenderit quasi.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1187), false, 1, null, 6 },
                    { 47, 12, "Quas iusto dolorum ab nobis occaecati.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1207), false, 5, null, 2 },
                    { 48, 4, "Perspiciatis ut sed dolorem.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1222), false, 4, null, 7 },
                    { 49, 16, "Saepe similique sint mollitia et aut dolores ut.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1235), false, 3, null, 5 },
                    { 50, 18, "Maiores unde voluptatem ipsum velit incidunt molestiae deserunt.", new DateTime(2024, 12, 31, 9, 21, 36, 326, DateTimeKind.Utc).AddTicks(1254), false, 1, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5225), false, null, 8 },
                    { 2, 12, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5406), false, null, 4 },
                    { 3, 18, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5413), false, null, 8 },
                    { 4, 4, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5416), false, null, 10 },
                    { 5, 5, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5419), false, null, 7 },
                    { 6, 1, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5422), false, null, 5 },
                    { 7, 1, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5425), false, null, 7 },
                    { 8, 14, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5428), false, null, 2 },
                    { 9, 8, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5431), false, null, 7 },
                    { 10, 10, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5433), false, null, 10 },
                    { 11, 2, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5436), false, null, 3 },
                    { 12, 5, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5439), false, null, 10 },
                    { 13, 16, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5441), false, null, 9 },
                    { 14, 7, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5444), false, null, 4 },
                    { 15, 8, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5446), false, null, 4 },
                    { 16, 6, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5449), false, null, 6 },
                    { 17, 17, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5451), false, null, 3 },
                    { 18, 10, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5454), false, null, 6 },
                    { 19, 14, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5457), false, null, 7 },
                    { 20, 17, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5460), false, null, 3 },
                    { 21, 18, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5462), false, null, 4 },
                    { 22, 11, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5465), false, null, 4 },
                    { 23, 20, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5467), false, null, 8 },
                    { 24, 19, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5470), false, null, 9 },
                    { 25, 14, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5473), false, null, 8 },
                    { 26, 20, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5476), false, null, 7 },
                    { 27, 15, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5478), false, null, 8 },
                    { 28, 2, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5481), false, null, 9 },
                    { 29, 11, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5484), false, null, 5 },
                    { 30, 1, new DateTime(2024, 12, 31, 9, 21, 36, 327, DateTimeKind.Utc).AddTicks(5486), false, null, 7 }
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
                name: "IX_Coupons_GiftCardId",
                table: "Coupons",
                column: "GiftCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_OrderId",
                table: "Coupons",
                column: "OrderId");

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
                name: "Coupons");

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
                name: "GiftCards");

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
