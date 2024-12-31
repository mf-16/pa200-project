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
                    { 1, "Lylaside", "Pitcairn Islands", new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(8734), false, "Delaware", "573 Reilly Fort", null, "49227" },
                    { 2, "Lake Monserratchester", "Guadeloupe", new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9380), false, "Delaware", "118 Cindy Circles", null, "10359" },
                    { 3, "Yesseniabury", "Jordan", new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9559), false, "Pennsylvania", "9347 Stacy Dam", null, "08927" },
                    { 4, "Lake Rae", "Myanmar", new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9703), false, "South Carolina", "48713 Kertzmann Junctions", null, "82126" },
                    { 5, "Port Lenore", "Aruba", new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9851), false, "Pennsylvania", "225 Predovic Motorway", null, "57087" },
                    { 6, "West Jerrod", "Ethiopia", new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9991), false, "North Dakota", "3836 Morar Street", null, "35400-2307" },
                    { 7, "West Wilfridfort", "Zambia", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(143), false, "North Dakota", "50919 Dietrich Point", null, "13721" },
                    { 8, "Madisentown", "Peru", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(287), false, "Pennsylvania", "6982 Johanna Throughway", null, "63055-9443" },
                    { 9, "Dachview", "Afghanistan", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(427), false, "Delaware", "876 Wolff Court", null, "26442" },
                    { 10, "West Brennan", "Mali", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(557), false, "Massachusetts", "74751 Dorthy Rest", null, "56869-7537" },
                    { 11, "Carolineborough", "Indonesia", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(697), false, "Indiana", "08696 Marquardt Groves", null, "82408" },
                    { 12, "New Mortimer", "Ghana", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(839), false, "Illinois", "5964 Conn Plains", null, "60565" },
                    { 13, "Wildermanstad", "Taiwan", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(971), false, "Tennessee", "7137 Gaylord Creek", null, "52697" },
                    { 14, "South Rudymouth", "Myanmar", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(1140), false, "Ohio", "2949 Tracey Stream", null, "22073" },
                    { 15, "New Rowan", "Saint Vincent and the Grenadines", new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(1311), false, "Arizona", "21642 Volkman Hills", null, "28988-7958" }
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
                    { 1, 0, "b9c3be38-82d1-488e-b809-94116487359b", "admin@admin.com", true, false, null, "Admin User", null, null, null, "123-456-7890", false, "279f6bf1-473a-4bb9-a299-1d42ed17aab3", false, "admin@admin.com" },
                    { 2, 0, "e26b9886-3a64-4ae4-9537-62556e874c37", "Price_Leannon26@hotmail.com", true, false, null, "Orion Marks", null, null, null, "(943) 237-3763 x6647", false, "0962ea58-f8b5-43f1-9c72-76e7dd30f18c", false, "Price_Leannon26@hotmail.com" },
                    { 3, 0, "62549ae6-6e00-4944-a66c-7cff204cec45", "Amie57@yahoo.com", true, false, null, "Richie Rice", null, null, null, "637.421.0048", false, "de290619-08b5-4d08-9096-ae333b6ab060", false, "Amie57@yahoo.com" },
                    { 4, 0, "55d7046e-6d76-4275-b0c4-88c3651bdf65", "Samanta.Bruen61@gmail.com", true, false, null, "Emmy Wintheiser", null, null, null, "782-255-1625 x539", false, "0faba5f1-0bd6-4cd8-9b97-1ef714e739b1", false, "Samanta.Bruen61@gmail.com" },
                    { 5, 0, "daed7a6b-972e-4b16-9e2c-2e1296ba0cf4", "Friedrich_Robel@yahoo.com", true, false, null, "Wanda Ledner", null, null, null, "409-766-6109", false, "a75b9401-8e02-48c5-b4d5-d61c05c4bc3c", false, "Friedrich_Robel@yahoo.com" },
                    { 6, 0, "1b5a1f37-ed0e-4c73-9aa3-16ae5a2e31f2", "Stephon55@hotmail.com", true, false, null, "Mina MacGyver", null, null, null, "850-733-1704 x451", false, "e5f9f044-a69a-4fa4-b555-3bf31fb7dafd", false, "Stephon55@hotmail.com" },
                    { 7, 0, "767c930b-3d73-414c-a31b-d7700cfb1e5a", "Rylan14@yahoo.com", true, false, null, "Golden Lind", null, null, null, "436.963.4479 x9238", false, "5a3d4d19-0812-4c13-a412-d2a1e8b0156c", false, "Rylan14@yahoo.com" },
                    { 8, 0, "e9c585f7-ca1b-443e-b1ff-0c66ba8b1699", "Jacky65@hotmail.com", true, false, null, "Jackson Hyatt", null, null, null, "1-601-719-5364", false, "63d42e57-91a4-4aeb-b478-1ededbe525ca", false, "Jacky65@hotmail.com" },
                    { 9, 0, "4d4825e9-530f-4624-84ba-db9b120a57f4", "Janick.Wiegand@gmail.com", true, false, null, "Jody Predovic", null, null, null, "(362) 321-7035 x49347", false, "7fb966f1-c8c8-4547-9233-0b2cd2613fad", false, "Janick.Wiegand@gmail.com" },
                    { 10, 0, "2b28b1c3-b0e1-43b5-9c44-ddf77328b21a", "Arely.Johnson21@gmail.com", true, false, null, "Skyla White", null, null, null, "1-632-741-3487", false, "02ef7adb-1f9f-48a6-aa35-8e705fc19c8f", false, "Arely.Johnson21@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Et pariatur possimus ut. Mollitia nihil tenetur totam labore aut et iure illo. Et in optio nam voluptas.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(1735), false, "Jonathan Murray", null },
                    { 2, "Ipsam deleniti officiis asperiores ad. Hic ut aut quasi recusandae dolorum ipsa molestiae laboriosam et. Numquam sint ea deleniti est voluptatem at voluptates aut. Et minima autem voluptatem sequi animi quo quae. Voluptas distinctio qui repellendus.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2174), false, "Jeramie Bruen", null },
                    { 3, "Explicabo molestiae sapiente temporibus. Non quis quia quia ducimus exercitationem consequatur atque unde. Nemo dolores et reprehenderit non et inventore voluptas.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2334), false, "Kayley Roberts", null },
                    { 4, "Praesentium consequatur odit praesentium necessitatibus dicta molestiae. Ut vel dolorum dolorum consequatur repudiandae et minus ratione aut. Consectetur voluptatem rerum sit perspiciatis quia vitae ut vel.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2460), false, "Valerie Heathcote", null },
                    { 5, "Consequuntur qui omnis. Minus animi fugiat. Ullam aspernatur veritatis aut neque ipsum dignissimos dolores sint. Ut facilis placeat.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2621), false, "Alycia Rosenbaum", null },
                    { 6, "Eaque cupiditate qui voluptatem quis aut illum delectus cupiditate. Sed temporibus sint. Numquam voluptate quidem id illum dolorum ut sed dicta totam. Inventore provident ad. Ea voluptas autem iste. Fuga eaque suscipit.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2731), false, "Christopher Abernathy", null },
                    { 7, "Minus iste autem. At sapiente nisi. Nemo aspernatur qui fugiat nihil doloremque recusandae quia. Voluptates pariatur ut. Eos consequatur eos ut aut voluptate non.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2851), false, "Samantha Swaniawski", null },
                    { 8, "Facilis molestiae adipisci porro neque cupiditate omnis. Doloremque ut delectus quis ut quasi quisquam repellendus ea. Temporibus nobis est delectus. Aut unde ut perspiciatis possimus nihil eum praesentium. Dolore eligendi mollitia iure molestiae et dolor.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2952), false, "Lonie Ortiz", null },
                    { 9, "Et blanditiis ullam dolorum iure voluptates. Et quaerat distinctio repellendus. Quos iusto autem consequuntur. Repudiandae iusto numquam repudiandae asperiores voluptate tenetur rerum amet eum. Iste porro nisi. Praesentium eveniet ut accusamus delectus veniam quas sint.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(3128), false, "Amina Cummings", null },
                    { 10, "Dolores consequuntur est sequi repudiandae optio laborum officia quia quo. Assumenda totam ipsam deleniti neque eveniet. Cum est non atque voluptatum. Similique quae commodi necessitatibus optio in voluptate dolorem ut.", new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(3247), false, "Orie Weber", null }
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
                    { 1, "Hic ipsa accusamus fuga corporis minus et minus. Explicabo voluptatibus et. Ea qui amet. Consequatur ea et nemo.", new DateTime(2024, 12, 31, 10, 21, 12, 309, DateTimeKind.Utc).AddTicks(9605), false, "Wilderman, Reichert and O'Connell", null },
                    { 2, "Reprehenderit ratione omnis tempore doloremque cumque dicta at facilis. Cumque alias odit et sed amet architecto odit eum dicta. Natus aut et sed perspiciatis modi labore placeat quam fugiat. Dolor iste nulla ratione non iste deserunt aspernatur ab. Facere reprehenderit ad ipsum voluptatum sint provident aut repudiandae. Consequuntur dignissimos eos tempore omnis temporibus aut fugit.", new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(349), false, "Schumm and Sons", null },
                    { 3, "Esse eius fugit earum. Occaecati iure aut dignissimos quaerat sed et commodi et. Tempora saepe quis animi qui et omnis error in. Eum perferendis sit accusantium et harum nesciunt.", new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(743), false, "Windler - Zieme", null },
                    { 4, "Aliquid et aut veniam ullam omnis. Rerum voluptas dolores tempora sint consequatur ab laboriosam. Natus ex labore quia repellendus. Id corporis veritatis.", new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(957), false, "Zemlak Group", null },
                    { 5, "Neque in odit repellendus dicta maiores. Doloremque ad dolor quia sapiente fugit minima aliquid quo. Ullam adipisci odit amet culpa asperiores nostrum. Suscipit qui eum est aut cum officiis iste doloremque. Est enim commodi quia nihil eaque similique laboriosam. A voluptate dolorem perspiciatis.", new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(1138), false, "Wisozk - Jenkins", null }
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
                    { 1, 1, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(6201), "Omnis reprehenderit eius doloribus unde inventore. Sint maxime nihil quam molestias. Et doloribus fuga similique. Sunt ullam neque.", 0, "/images/cover-7.jpg", false, null, 27.14m, 4, 1, "Nulla est enim.", null },
                    { 2, 10, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8297), "Non velit nam libero fugiat ut incidunt inventore quos. Debitis earum provident nesciunt velit. Veritatis qui nemo id provident perspiciatis vitae earum.", 0, "/images/cover-5.jpg", false, null, 39.84m, 1, 1, "Fuga adipisci voluptatem.", null },
                    { 3, 1, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8449), "Corrupti qui porro laboriosam et optio ad aspernatur ea. Libero totam aliquam eos quia nam esse sed excepturi quaerat. Quibusdam ut quibusdam maxime quam cupiditate ut officia.", 0, "/images/cover-1.jpg", false, null, 87.21m, 3, 3, "Eum voluptatem nemo.", null },
                    { 4, 8, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8623), "Ratione ab ipsum placeat doloribus. Ut unde voluptates. Libero sint et.", 0, "/images/cover-10.jpg", false, null, 23.29m, 6, 1, "Repellat occaecati aspernatur.", null },
                    { 5, 9, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8715), "Aut ratione quidem eveniet. Nihil voluptas cupiditate vitae nemo facere. Dolor culpa illo aut voluptas autem et eos. Dicta incidunt sunt ut enim veritatis. Omnis doloremque voluptas rem provident dicta repellat praesentium magnam odio. Et dicta vitae illo dicta laborum reiciendis.", 0, "/images/cover-4.jpg", false, null, 14.72m, 2, 4, "Rerum et excepturi.", null },
                    { 6, 1, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8989), "Accusantium accusamus in architecto. Enim eos sint nobis at beatae impedit. Nesciunt et sit corporis temporibus nam accusamus ipsum ullam. Ducimus magnam est sunt. Et qui architecto accusamus voluptatem maiores dolorem architecto perspiciatis. Aut voluptate rerum quidem voluptates quasi facere adipisci hic aut.", 0, "/images/cover-7.jpg", false, null, 27.79m, 3, 4, "Praesentium laudantium officia.", null },
                    { 7, 2, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9245), "Sint est animi repellendus ipsum mollitia voluptatem. Cumque nostrum consequuntur vero quidem facilis dolorem omnis dolor. In consequuntur earum esse odio eum ut sit et. Laboriosam quod eum at. Qui ea doloribus iusto voluptas.", 0, "/images/cover-5.jpg", false, null, 95.51m, 7, 5, "Deleniti nostrum a.", null },
                    { 8, 6, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9466), "Ut ad quis occaecati et quos. Culpa voluptatem voluptas atque sit. Dignissimos debitis a nam non earum quis libero est optio. Quaerat sunt veritatis quis repellat voluptas. Doloribus cupiditate excepturi nam. Alias accusamus dignissimos et.", 0, "/images/cover-1.jpg", false, null, 49.86m, 2, 4, "Autem quae et.", null },
                    { 9, 1, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9675), "Sequi vel delectus beatae. Expedita deserunt quos quos aspernatur. Similique fuga culpa sit eum illo. Expedita qui accusantium dolores. Maiores harum doloribus aliquam maiores ratione in expedita sint.", 0, "/images/cover-6.jpg", false, null, 20.92m, 6, 5, "Culpa id illum.", null },
                    { 10, 3, new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9833), "Aspernatur sit aspernatur rem est cumque porro omnis. Fuga autem aut deserunt velit sint reprehenderit soluta cumque. Velit et quis sit quia est corrupti in quibusdam. Itaque quis corporis quasi. Quisquam sunt autem recusandae maxime. Dolorem harum quasi.", 0, "/images/cover-3.jpg", false, null, 83.95m, 1, 3, "Nisi accusamus blanditiis.", null },
                    { 11, 5, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(9), "Aut iste error impedit tenetur non deserunt est velit. At vitae cum est. Quasi et eos. Maxime quisquam eligendi consectetur quo ab. Autem debitis consectetur cumque adipisci voluptas aperiam accusamus nulla. Alias sit itaque quia quibusdam quaerat iure quo.", 0, "/images/cover-1.jpg", false, null, 54.02m, 3, 4, "Qui in suscipit.", null },
                    { 12, 5, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(205), "Illo magnam dicta et esse amet necessitatibus aut alias. Officiis ex rem cum optio quia vel est. Officia nisi aliquid provident accusamus recusandae vel incidunt dicta. Ut suscipit cumque veritatis deserunt non ullam sint hic. Est saepe nesciunt molestiae est qui mollitia perspiciatis. Quis quo aliquam quas molestias aut magnam quisquam nesciunt.", 0, "/images/cover-2.jpg", false, null, 50.08m, 3, 2, "Molestiae iste totam.", null },
                    { 13, 10, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(426), "Voluptas veniam odio dolorem. Eius soluta aut fuga temporibus. Doloremque quis et aut. Quos nihil enim quis nemo tempora aut et qui et. Fugiat sint sit possimus quia et mollitia doloribus rerum.", 0, "/images/cover-7.jpg", false, null, 89.33m, 4, 4, "Architecto quod qui.", null },
                    { 14, 7, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(540), "Accusamus sunt numquam et possimus nihil deserunt est. Minima ea quo nemo dignissimos praesentium. Sed suscipit et ea exercitationem vero nemo ipsa. Dolorem non veritatis ratione occaecati non omnis quas quisquam voluptates. Non excepturi id cupiditate sunt. Magni nesciunt perspiciatis.", 0, "/images/cover-1.jpg", false, null, 12.94m, 3, 4, "Exercitationem esse molestiae.", null },
                    { 15, 1, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(719), "Neque amet odit dolorem ut aut. Labore perspiciatis occaecati in est rerum ex. Quia sint et. Consequatur eaque ea non voluptatem dolores rerum dolores qui. Dolorem vel animi occaecati magnam sit fuga quisquam. Et iste possimus.", 0, "/images/cover-4.jpg", false, null, 13.03m, 1, 5, "Et animi molestiae.", null },
                    { 16, 2, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(862), "Eligendi expedita odit quis recusandae doloribus est quia voluptatem rerum. Optio fugit incidunt qui. Ex rerum quasi consequatur quod facere.", 0, "/images/cover-5.jpg", false, null, 13.90m, 7, 5, "Autem ut commodi.", null },
                    { 17, 5, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(938), "Odit placeat beatae occaecati. Quis delectus et laboriosam et sint. Esse quia nihil dolorem. Velit sequi ut minima aspernatur.", 0, "/images/cover-8.jpg", false, null, 84.82m, 7, 4, "Delectus nemo asperiores.", null },
                    { 18, 10, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(1050), "Qui architecto explicabo illum est aut voluptas. Cumque perferendis atque. Incidunt sit at ducimus quidem quos delectus aperiam. Sapiente maxime ipsa perferendis facilis est repudiandae. Quaerat natus ea ut a. Deleniti eos asperiores.", 0, "/images/cover-5.jpg", false, null, 42.26m, 3, 3, "Quia sed quis.", null },
                    { 19, 10, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(1188), "Vel odio repellendus tempora recusandae velit. Ut voluptas eum soluta qui. Ut ducimus eius omnis sed mollitia optio. Ut consequatur rerum est amet minus aut necessitatibus.", 0, "/images/cover-10.jpg", false, null, 16.60m, 1, 5, "Explicabo dolore ut.", null },
                    { 20, 10, new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(1277), "Ea aut quo sit. Consequatur qui non et ex et delectus nostrum. Impedit dolores aut. Molestiae et ipsa aperiam. Corrupti hic nostrum dolore in itaque inventore quia ut dolores.", 0, "/images/cover-3.jpg", false, null, 97.32m, 1, 2, "Pariatur delectus consequatur.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7919), false, null, 2 },
                    { 3, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7922), false, null, 3 },
                    { 4, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7922), false, null, 4 },
                    { 5, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7922), false, null, 5 },
                    { 6, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923), false, null, 6 },
                    { 7, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923), false, null, 7 },
                    { 8, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923), false, null, 8 },
                    { 9, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923), false, null, 9 },
                    { 10, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7924), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "OrderState", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 11, new DateTime(2024, 12, 31, 10, 21, 12, 318, DateTimeKind.Utc).AddTicks(5899), "Audrey_Kessler@gmail.com", "Audrey Kessler", false, 1, 13, 0m, null, 9 },
                    { 2, 6, new DateTime(2024, 12, 31, 10, 21, 12, 318, DateTimeKind.Utc).AddTicks(9645), "Vanessa6@hotmail.com", "Vanessa Vandervort", false, 0, 15, 0m, null, 9 },
                    { 3, 9, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(984), "Teresa_Torp@gmail.com", "Teresa Torp", false, 1, 13, 0m, null, 2 },
                    { 4, 7, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(1859), "Susie_Denesik@hotmail.com", "Susie Denesik", false, 4, 1, 0m, null, 8 },
                    { 5, 11, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(2665), "Jeffrey_Monahan@hotmail.com", "Jeffrey Monahan", false, 1, 10, 0m, null, 5 },
                    { 6, 7, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(3383), "Felix_McGlynn@gmail.com", "Felix McGlynn", false, 1, 4, 0m, null, 9 },
                    { 7, 7, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(4194), "Elmer46@gmail.com", "Elmer Lindgren", false, 4, 1, 0m, null, 3 },
                    { 8, 4, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(4928), "Wanda.Langworth@gmail.com", "Wanda Langworth", false, 2, 14, 0m, null, 10 },
                    { 9, 3, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(5616), "Margarita64@yahoo.com", "Margarita Schuppe", false, 2, 5, 0m, null, 8 },
                    { 10, 2, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(6396), "Bernice.Schultz7@gmail.com", "Bernice Schultz", false, 2, 2, 0m, null, 5 },
                    { 11, 10, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(7080), "Darla_Durgan75@hotmail.com", "Darla Durgan", false, 2, 10, 0m, null, 3 },
                    { 12, 2, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(7761), "Gregg.McClure49@gmail.com", "Gregg McClure", false, 5, 15, 0m, null, 6 },
                    { 13, 2, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(8475), "Sandra58@hotmail.com", "Sandra Pfeffer", false, 1, 3, 0m, null, 7 },
                    { 14, 11, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(9171), "Stuart_Dickinson@gmail.com", "Stuart Dickinson", false, 3, 7, 0m, null, 3 },
                    { 15, 10, new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(9875), "Michael.Kerluke61@gmail.com", "Michael Kerluke", false, 1, 12, 0m, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 14, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(5955), false, 11, 70.45m, 1, null },
                    { 2, 17, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7233), false, 11, 46.12m, 1, null },
                    { 3, 18, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7293), false, 3, 69.26m, 1, null },
                    { 4, 14, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7307), false, 9, 89.57m, 1, null },
                    { 5, 5, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7317), false, 7, 65.90m, 2, null },
                    { 6, 13, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7325), false, 3, 98.35m, 1, null },
                    { 7, 8, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7334), false, 2, 84.08m, 1, null },
                    { 8, 13, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7343), false, 12, 21.10m, 2, null },
                    { 9, 8, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7350), false, 11, 73.39m, 2, null },
                    { 10, 1, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7358), false, 6, 71.79m, 2, null },
                    { 11, 6, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7366), false, 11, 57.36m, 1, null },
                    { 12, 3, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7373), false, 2, 16.06m, 2, null },
                    { 13, 5, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7380), false, 10, 17.20m, 2, null },
                    { 14, 6, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7438), false, 8, 59.29m, 1, null },
                    { 15, 13, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7446), false, 12, 38.30m, 1, null },
                    { 16, 14, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7454), false, 10, 55.66m, 2, null },
                    { 17, 4, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7462), false, 7, 78.33m, 1, null },
                    { 18, 17, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7470), false, 6, 99.79m, 1, null },
                    { 19, 4, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7477), false, 2, 29.47m, 2, null },
                    { 20, 7, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7486), false, 3, 45.72m, 1, null },
                    { 21, 15, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7493), false, 13, 74.85m, 1, null },
                    { 22, 6, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7501), false, 10, 70.16m, 3, null },
                    { 23, 12, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7508), false, 10, 28.83m, 3, null },
                    { 24, 19, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7516), false, 14, 25.04m, 3, null },
                    { 25, 8, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7524), false, 14, 26.04m, 2, null },
                    { 26, 4, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7531), false, 8, 11.03m, 1, null },
                    { 27, 12, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7539), false, 8, 30.51m, 1, null },
                    { 28, 18, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7547), false, 2, 44.54m, 1, null },
                    { 29, 16, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7555), false, 12, 52.90m, 3, null },
                    { 30, 15, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7562), false, 2, 55.92m, 1, null },
                    { 31, 17, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7569), false, 12, 37.16m, 1, null },
                    { 32, 18, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7577), false, 7, 25.90m, 3, null },
                    { 33, 14, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7585), false, 7, 12.20m, 2, null },
                    { 34, 15, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7592), false, 11, 51.34m, 1, null },
                    { 35, 3, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7600), false, 11, 27.43m, 2, null },
                    { 36, 11, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7607), false, 2, 85.03m, 3, null },
                    { 37, 12, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7615), false, 9, 15.42m, 2, null },
                    { 38, 8, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7623), false, 5, 83.38m, 2, null },
                    { 39, 11, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7631), false, 12, 48.98m, 3, null },
                    { 40, 12, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7638), false, 14, 58.84m, 2, null },
                    { 41, 13, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7646), false, 10, 63.75m, 2, null },
                    { 42, 19, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7654), false, 3, 24.06m, 2, null },
                    { 43, 9, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7662), false, 8, 70.10m, 3, null },
                    { 44, 16, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7670), false, 15, 58.26m, 1, null },
                    { 45, 18, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7677), false, 7, 38.60m, 3, null },
                    { 46, 9, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7719), false, 11, 48.38m, 2, null },
                    { 47, 16, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7727), false, 14, 36.25m, 1, null },
                    { 48, 17, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7734), false, 2, 62.57m, 3, null },
                    { 49, 11, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7742), false, 8, 64.30m, 2, null },
                    { 50, 7, new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7750), false, 6, 77.37m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 5, "Ipsam dignissimos dolorem et delectus.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(7301), false, 1, null, 8 },
                    { 2, 1, "Rem et id officiis.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(8766), false, 2, null, 9 },
                    { 3, 9, "Culpa ducimus nostrum sapiente quisquam adipisci consequuntur.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(8858), false, 2, null, 6 },
                    { 4, 9, "Quaerat debitis omnis voluptatem delectus ut.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(8971), false, 3, null, 2 },
                    { 5, 4, "Ut ea tempora eos assumenda qui quas dolorem praesentium.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9018), false, 3, null, 10 },
                    { 6, 15, "Sapiente quis voluptatem.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9077), false, 2, null, 9 },
                    { 7, 16, "Quo aliquam omnis quia.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9107), false, 2, null, 6 },
                    { 8, 19, "Assumenda ratione sequi aut.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9131), false, 1, null, 7 },
                    { 9, 12, "Cumque aut aliquid qui error eum aut asperiores sit inventore.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9147), false, 1, null, 7 },
                    { 10, 3, "Ut recusandae impedit sint sunt et odit et consequatur.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9179), false, 3, null, 5 },
                    { 11, 14, "Et eligendi harum eum quibusdam saepe cumque doloremque.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9212), false, 2, null, 9 },
                    { 12, 3, "Reiciendis natus est qui sunt qui rerum qui omnis.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9269), false, 5, null, 10 },
                    { 13, 2, "Consequatur eos possimus sed dicta odit maiores explicabo ducimus praesentium.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9298), false, 4, null, 6 },
                    { 14, 16, "Laborum magnam enim quo nulla aperiam et dicta sed voluptatibus.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9327), false, 3, null, 7 },
                    { 15, 11, "Officia quidem officiis molestiae quae.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9358), false, 4, null, 7 },
                    { 16, 4, "Aut doloremque ut ducimus aut non quasi et eaque cumque.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9376), false, 3, null, 4 },
                    { 17, 17, "Aut neque maxime voluptas sint unde et.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9409), false, 3, null, 9 },
                    { 18, 15, "Maiores sunt quibusdam ab autem voluptas nulla.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9433), false, 5, null, 3 },
                    { 19, 7, "Id maxime qui autem dolore.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9488), false, 2, null, 10 },
                    { 20, 1, "Quis aliquam aspernatur blanditiis dolor voluptas optio et odit.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9509), false, 1, null, 9 },
                    { 21, 5, "Nemo voluptates odit cupiditate vel nihil.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9536), false, 1, null, 8 },
                    { 22, 9, "Provident eligendi quo quis aut eligendi voluptas.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9558), false, 5, null, 9 },
                    { 23, 5, "Commodi illum ducimus eligendi optio distinctio qui.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9579), false, 3, null, 5 },
                    { 24, 3, "Consequatur incidunt tenetur totam.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9602), false, 4, null, 3 },
                    { 25, 11, "Omnis temporibus non corporis cum sit fuga architecto.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9618), false, 3, null, 7 },
                    { 26, 3, "Doloribus ratione eaque.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9642), false, 3, null, 8 },
                    { 27, 3, "Quis veritatis soluta tempora rerum soluta rerum et suscipit.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9658), false, 2, null, 9 },
                    { 28, 7, "Eum corrupti aut quia ut perspiciatis dicta deserunt.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9701), false, 2, null, 2 },
                    { 29, 9, "Distinctio a et omnis officia culpa error.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9726), false, 1, null, 7 },
                    { 30, 18, "Deleniti quo non vel ea sint tempora.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9749), false, 3, null, 8 },
                    { 31, 9, "Consequatur odio dolor autem optio corporis omnis autem.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9772), false, 4, null, 7 },
                    { 32, 8, "Quaerat sapiente ipsum saepe id sed ad non in.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9795), false, 1, null, 3 },
                    { 33, 3, "Ab nesciunt perferendis recusandae.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9822), false, 2, null, 3 },
                    { 34, 10, "Voluptatibus voluptatem voluptatem qui cupiditate voluptas delectus dolor.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9837), false, 5, null, 6 },
                    { 35, 1, "Consequuntur asperiores minus fugit.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9946), false, 3, null, 3 },
                    { 36, 12, "Velit accusantium et et.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9963), false, 5, null, 8 },
                    { 37, 16, "Cumque autem consequatur molestias esse.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9979), false, 1, null, 4 },
                    { 38, 12, "Voluptates odit odio enim aut et et sit.", new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9998), false, 1, null, 3 },
                    { 39, 20, "Ipsam velit aut voluptas qui repellat rerum atque soluta.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(21), false, 3, null, 7 },
                    { 40, 9, "Quibusdam dolores autem itaque aut qui.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(47), false, 3, null, 10 },
                    { 41, 12, "Delectus vel dignissimos.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(67), false, 2, null, 7 },
                    { 42, 8, "Vel dolores maxime aut.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(80), false, 4, null, 6 },
                    { 43, 6, "Molestias libero eaque voluptatem.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(136), false, 1, null, 4 },
                    { 44, 11, "Aperiam eveniet nam illo nulla autem.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(154), false, 4, null, 6 },
                    { 45, 3, "Illum ut ab ipsam deserunt necessitatibus sed consequuntur.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(175), false, 4, null, 3 },
                    { 46, 13, "Ipsam error voluptatibus.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(202), false, 5, null, 4 },
                    { 47, 17, "Error ea vel dignissimos porro est harum velit.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(214), false, 5, null, 5 },
                    { 48, 11, "Quia laboriosam officiis fugiat animi assumenda suscipit similique placeat dolorem.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(237), false, 3, null, 7 },
                    { 49, 1, "Debitis enim ea adipisci repellendus voluptate vel aut esse consequatur.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(263), false, 1, null, 3 },
                    { 50, 8, "Ea natus sit et.", new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(290), false, 5, null, 9 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4337), false, null, 8 },
                    { 2, 16, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4525), false, null, 3 },
                    { 3, 18, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4533), false, null, 9 },
                    { 4, 12, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4536), false, null, 8 },
                    { 5, 1, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4540), false, null, 5 },
                    { 6, 6, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4543), false, null, 6 },
                    { 7, 7, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4546), false, null, 9 },
                    { 8, 10, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4549), false, null, 7 },
                    { 9, 3, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4552), false, null, 3 },
                    { 10, 19, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4555), false, null, 2 },
                    { 11, 1, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4558), false, null, 4 },
                    { 12, 14, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4562), false, null, 9 },
                    { 13, 5, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4565), false, null, 5 },
                    { 14, 14, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4568), false, null, 9 },
                    { 15, 15, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4570), false, null, 5 },
                    { 16, 8, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4573), false, null, 2 },
                    { 17, 14, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4576), false, null, 5 },
                    { 18, 15, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4579), false, null, 6 },
                    { 19, 20, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4582), false, null, 5 },
                    { 20, 13, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4585), false, null, 7 },
                    { 21, 12, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4588), false, null, 5 },
                    { 22, 5, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4591), false, null, 3 },
                    { 23, 8, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4594), false, null, 6 },
                    { 24, 7, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4597), false, null, 7 },
                    { 25, 5, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4643), false, null, 7 },
                    { 26, 4, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4646), false, null, 3 },
                    { 27, 12, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4650), false, null, 3 },
                    { 28, 19, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4653), false, null, 8 },
                    { 29, 15, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4656), false, null, 7 },
                    { 30, 19, new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4659), false, null, 7 }
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
