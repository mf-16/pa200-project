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
                    { 1, "East Sabrynaberg", "Russian Federation", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(8309), false, "North Dakota", "552 Cronin Terrace", null, "77651-7231" },
                    { 2, "New Veldabury", "Swaziland", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(8954), false, "Hawaii", "230 Wintheiser Field", null, "25088-2285" },
                    { 3, "Dejamouth", "Cocos (Keeling) Islands", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9106), false, "Wisconsin", "400 Janae Gardens", null, "13432" },
                    { 4, "Jenkinstown", "Guinea", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9276), false, "Nebraska", "204 Laverne Dale", null, "60631" },
                    { 5, "Vicentachester", "Turkey", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9418), false, "Michigan", "5002 Jocelyn Spurs", null, "45589" },
                    { 6, "Opheliafurt", "Syrian Arab Republic", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9546), false, "Massachusetts", "509 Barton Shoal", null, "80916" },
                    { 7, "Port Jeramie", "Maldives", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9646), false, "Wyoming", "50059 Bayer Walk", null, "69471-4285" },
                    { 8, "Predovicmouth", "Qatar", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9774), false, "Hawaii", "65472 Predovic Square", null, "78724" },
                    { 9, "North Hortensebury", "Barbados", new DateTime(2024, 12, 31, 14, 26, 51, 614, DateTimeKind.Utc).AddTicks(9893), false, "Washington", "41303 Albertha Club", null, "34373-2161" },
                    { 10, "North Alaina", "Greece", new DateTime(2024, 12, 31, 14, 26, 51, 615, DateTimeKind.Utc).AddTicks(27), false, "Kentucky", "855 McClure Course", null, "80747-8066" },
                    { 11, "Nicolasview", "Bosnia and Herzegovina", new DateTime(2024, 12, 31, 14, 26, 51, 615, DateTimeKind.Utc).AddTicks(154), false, "Delaware", "45178 Brandy Union", null, "58762" },
                    { 12, "Gaylordhaven", "Nigeria", new DateTime(2024, 12, 31, 14, 26, 51, 615, DateTimeKind.Utc).AddTicks(295), false, "Indiana", "623 Gus Islands", null, "55766-5127" },
                    { 13, "Lake Rosemarie", "Pitcairn Islands", new DateTime(2024, 12, 31, 14, 26, 51, 615, DateTimeKind.Utc).AddTicks(421), false, "Missouri", "8375 Brakus Estate", null, "27945-9397" },
                    { 14, "Lake Kieran", "Bangladesh", new DateTime(2024, 12, 31, 14, 26, 51, 615, DateTimeKind.Utc).AddTicks(566), false, "North Carolina", "1170 Citlalli Point", null, "77345" },
                    { 15, "Anissamouth", "United States Minor Outlying Islands", new DateTime(2024, 12, 31, 14, 26, 51, 615, DateTimeKind.Utc).AddTicks(689), false, "Vermont", "811 Smith Stravenue", null, "12763" }
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
                    { 1, 0, "adaf94f6-ce98-48eb-8bf9-cffcc4420e14", "admin@admin.com", true, false, null, "Admin User", null, null, null, "123-456-7890", false, "5c25938f-e0c2-4811-beac-331eae0d59de", false, "admin@admin.com" },
                    { 2, 0, "fc7d6702-fe83-4cc7-b016-bd819c6fdba1", "Aryanna63@gmail.com", true, false, null, "Noemy Will", null, null, null, "281.271.8964 x50312", false, "87c99c2b-33c0-46d4-94ff-cbb7eff0c5bc", false, "Aryanna63@gmail.com" },
                    { 3, 0, "7940706a-bf8c-425a-981a-d799050c4e2e", "Cordelia.Schmeler84@gmail.com", true, false, null, "Neil Denesik", null, null, null, "(274) 358-6652 x41642", false, "add65ee3-524e-4469-ba4c-87d40e367dd1", false, "Cordelia.Schmeler84@gmail.com" },
                    { 4, 0, "8ac89007-8dea-441f-92c8-0561cd5e31cc", "Millie9@hotmail.com", true, false, null, "Annalise Gottlieb", null, null, null, "1-986-791-5750", false, "c2ce2e47-3c87-4689-9449-4045616483d5", false, "Millie9@hotmail.com" },
                    { 5, 0, "31efec93-af72-466b-86e3-f4d19538da53", "Eleanora_Gibson40@hotmail.com", true, false, null, "Tatum Lehner", null, null, null, "1-455-766-6903 x69541", false, "8905e375-6bd9-4028-b606-055b543eac23", false, "Eleanora_Gibson40@hotmail.com" },
                    { 6, 0, "3d5079e3-40ab-487a-a5ca-1fc5a1b59df2", "Randi.Altenwerth@gmail.com", true, false, null, "Molly Lubowitz", null, null, null, "894-256-0018 x351", false, "442c46f2-40e5-40e4-87ee-e4b701d7171f", false, "Randi.Altenwerth@gmail.com" },
                    { 7, 0, "f3accbd3-793e-42b0-b983-c7c0905f580d", "Anika.Kunde48@hotmail.com", true, false, null, "Rigoberto Cummerata", null, null, null, "902.628.6565", false, "02d01b84-a997-446e-94bd-15c06d8b46ad", false, "Anika.Kunde48@hotmail.com" },
                    { 8, 0, "510a335a-51ba-4cea-a6aa-fa40069f3c55", "Zelda_Dibbert33@hotmail.com", true, false, null, "Aurelia McDermott", null, null, null, "1-435-796-4079", false, "f75b1b8e-a16e-4c7e-8b77-11e9fd392f23", false, "Zelda_Dibbert33@hotmail.com" },
                    { 9, 0, "afd0ab1d-8ae7-4475-8ff8-6a8816c351d1", "Clare.Fisher16@yahoo.com", true, false, null, "River Waelchi", null, null, null, "275.441.4100 x708", false, "dce4fd55-5d1d-454b-95bd-572411d021f0", false, "Clare.Fisher16@yahoo.com" },
                    { 10, 0, "6b55348a-26a2-487d-b4ac-ba0d08ae0ddf", "Eileen.Thompson6@gmail.com", true, false, null, "Zetta Klein", null, null, null, "(963) 985-0831", false, "53583bfb-5d88-4f07-94ed-f2789057a659", false, "Eileen.Thompson6@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Tempore aliquam ratione quibusdam consequatur corporis est eveniet cum. Sunt eligendi animi minus necessitatibus modi deserunt distinctio distinctio. Doloremque delectus fugit reprehenderit nulla explicabo ut atque. Doloribus dolorem vel autem necessitatibus tenetur omnis eveniet. Ipsam accusamus quos aut dolor natus soluta odio.", new DateTime(2024, 12, 31, 14, 26, 51, 606, DateTimeKind.Utc).AddTicks(8535), false, "Aracely O'Hara", null },
                    { 2, "Quod nesciunt impedit earum doloremque voluptatem. Repudiandae voluptatem odit. Autem deleniti omnis qui adipisci eligendi. Adipisci quidem voluptatem ut ad eligendi dolore. Error ducimus error nihil est aliquid ex doloremque enim.", new DateTime(2024, 12, 31, 14, 26, 51, 606, DateTimeKind.Utc).AddTicks(9358), false, "Betty Zulauf", null },
                    { 3, "Facere dolor voluptatem aliquid nisi quia quis. Eos animi recusandae ipsam ad deleniti et possimus non. Voluptatem ipsa a recusandae. Tempora quia non. Debitis voluptatem unde est odio. Aut maiores et vero et.", new DateTime(2024, 12, 31, 14, 26, 51, 606, DateTimeKind.Utc).AddTicks(9656), false, "Emil Howell", null },
                    { 4, "Reprehenderit sint impedit et et reiciendis ea debitis et. Praesentium facilis iure dolore sit suscipit magnam. Dolor corporis dolores et sed adipisci aliquam ullam nemo sed. Quia accusamus adipisci aliquid. Possimus qui aut sint et sit vel dolorum qui doloribus.", new DateTime(2024, 12, 31, 14, 26, 51, 606, DateTimeKind.Utc).AddTicks(9901), false, "Rogers Kuhn", null },
                    { 5, "Autem maxime itaque voluptatem. Aliquid quam sequi occaecati dignissimos magni eveniet. Aut id praesentium. Reiciendis et atque sapiente temporibus ut a doloribus. Aliquam mollitia laborum deserunt aut ut.", new DateTime(2024, 12, 31, 14, 26, 51, 607, DateTimeKind.Utc).AddTicks(223), false, "Alanis Buckridge", null },
                    { 6, "Id sunt aut mollitia suscipit nemo asperiores. Ipsam et sed doloribus iusto ab ipsa voluptates maiores. Est qui vel molestiae. At nobis magnam quis quas reiciendis asperiores itaque. Aspernatur eum quia vitae deleniti qui.", new DateTime(2024, 12, 31, 14, 26, 51, 607, DateTimeKind.Utc).AddTicks(420), false, "Brayan Metz", null },
                    { 7, "Commodi cumque dolores. Aspernatur a natus est doloremque occaecati mollitia mollitia ipsum pariatur. Exercitationem quae nisi unde sequi natus dignissimos atque voluptas. Quos eligendi dolor qui veritatis ipsum minus hic at.", new DateTime(2024, 12, 31, 14, 26, 51, 607, DateTimeKind.Utc).AddTicks(667), false, "Richard Thiel", null },
                    { 8, "Ad necessitatibus voluptas libero tempora. Voluptas et sequi. Et quis voluptate debitis ut dolores a.", new DateTime(2024, 12, 31, 14, 26, 51, 607, DateTimeKind.Utc).AddTicks(996), false, "Janiya Bruen", null },
                    { 9, "Eos ex natus officia et nihil. Laborum accusamus molestiae beatae velit ea eos in aspernatur rerum. Doloribus non est excepturi qui.", new DateTime(2024, 12, 31, 14, 26, 51, 607, DateTimeKind.Utc).AddTicks(1115), false, "Enrique Keeling", null },
                    { 10, "Aliquam doloribus quis maiores et. Unde qui voluptatum. In aliquid dolor consequatur velit. Animi deleniti beatae rerum et magni atque perferendis voluptatem hic.", new DateTime(2024, 12, 31, 14, 26, 51, 607, DateTimeKind.Utc).AddTicks(1258), false, "Lizeth McDermott", null }
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
                    { 1, "Assumenda maiores asperiores est. Totam repellat porro dolor ipsam. Velit reprehenderit debitis consequatur accusantium alias. Id saepe possimus voluptatibus voluptatem nostrum adipisci ipsam. Alias enim labore eum minima rerum voluptas sunt assumenda.", new DateTime(2024, 12, 31, 14, 26, 51, 608, DateTimeKind.Utc).AddTicks(7260), false, "Conroy, Lesch and Fritsch", null },
                    { 2, "Quae eveniet qui aut earum quis laboriosam quo quisquam ipsa. Cum saepe velit animi vel nobis molestiae quaerat. Aliquam reiciendis dolor autem at ducimus cum dolorem et nobis. Sunt officia non deleniti qui aut sed voluptas. Dolore aperiam voluptas expedita deserunt.", new DateTime(2024, 12, 31, 14, 26, 51, 608, DateTimeKind.Utc).AddTicks(7962), false, "Gerlach LLC", null },
                    { 3, "Aut eum id exercitationem dolorem qui nihil in facilis sit. Cupiditate vel necessitatibus. Commodi quas suscipit magnam repellat tempore. Saepe repellendus nulla soluta consequatur eum nam. Rerum quisquam atque velit. Dolor ab laboriosam perspiciatis.", new DateTime(2024, 12, 31, 14, 26, 51, 608, DateTimeKind.Utc).AddTicks(8249), false, "Brekke LLC", null },
                    { 4, "Eligendi quo ut delectus quis non est et id. Iste id doloremque explicabo quas et. Eos veritatis consequuntur voluptas quam ea saepe at quo sunt. Quo corporis praesentium. Exercitationem dolorem repellat ea. Voluptatem ut necessitatibus unde id expedita esse suscipit.", new DateTime(2024, 12, 31, 14, 26, 51, 608, DateTimeKind.Utc).AddTicks(8472), false, "Beahan Group", null },
                    { 5, "Ea corporis quibusdam architecto ea dolore. Ab perspiciatis et minus cupiditate dicta voluptatem necessitatibus. Et esse facilis corrupti tenetur consequatur velit. Ipsum cupiditate eos tempora harum velit aperiam quis eaque qui. Vero rem odit autem impedit sed illum numquam culpa unde.", new DateTime(2024, 12, 31, 14, 26, 51, 608, DateTimeKind.Utc).AddTicks(8667), false, "Kertzmann Group", null }
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
                    { 1, 7, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(2331), "Et dicta tempora voluptatem. Omnis architecto nesciunt ut nihil culpa ratione. Quos in corporis quos dolorum cupiditate nobis facilis maxime. Velit consequatur mollitia corporis.", 0, "/images/cover-5.jpg", false, null, 70.63m, 4, 1, "Qui possimus aut.", null },
                    { 2, 3, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4146), "Rem et nulla dolorem maxime et laboriosam inventore odio minus. Necessitatibus id iure voluptas ex pariatur et et quo. Soluta voluptatum dignissimos quos nostrum reprehenderit.", 0, "/images/cover-1.jpg", false, null, 26.11m, 2, 4, "Facilis veniam aut.", null },
                    { 3, 10, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4274), "Repellendus natus ut dolorem cumque ipsum. Omnis ut ipsam et dolorem. Facere fuga ipsa et id. Ratione eum assumenda doloribus aut enim cumque. Quo atque repellat ipsum sit dolorem est.", 0, "/images/cover-8.jpg", false, null, 39.76m, 3, 5, "Cumque debitis doloribus.", null },
                    { 4, 10, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4389), "Debitis nobis assumenda corrupti delectus eaque dolor tenetur saepe. Doloribus vel velit veniam doloremque est dolores sit sit nulla. Qui qui nostrum.", 0, "/images/cover-4.jpg", false, null, 87.58m, 1, 1, "Quasi temporibus minus.", null },
                    { 5, 6, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4533), "Sit et et voluptatem qui quia aut est. Nobis qui temporibus. Perferendis aspernatur aut suscipit qui porro. Quas recusandae officiis beatae nobis ducimus. Id voluptatibus pariatur sequi nulla alias dignissimos debitis qui.", 0, "/images/cover-1.jpg", false, null, 19.96m, 2, 4, "Veniam facere qui.", null },
                    { 6, 6, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4635), "Veritatis voluptatem eligendi. Animi itaque omnis corporis placeat. Ipsa omnis ipsam sit vel laboriosam.", 0, "/images/cover-10.jpg", false, null, 96.76m, 5, 1, "Voluptatem ex sed.", null },
                    { 7, 6, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4782), "Impedit nihil neque ipsa voluptate temporibus explicabo. Impedit impedit accusantium placeat. Non neque sed et voluptas velit fugiat impedit laudantium quia. Fugiat et voluptates.", 0, "/images/cover-3.jpg", false, null, 43.32m, 6, 5, "Suscipit quidem voluptatem.", null },
                    { 8, 6, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(4866), "Nesciunt esse tempore aliquam. Ab voluptates non ratione labore tempora nostrum nesciunt molestias voluptas. Rem voluptatibus minima asperiores voluptates veniam odio aspernatur ex nesciunt. Dicta quidem distinctio error quaerat sint. Minus consequatur voluptatem deserunt aperiam sequi.", 0, "/images/cover-8.jpg", false, null, 87.09m, 3, 2, "Odit dignissimos esse.", null },
                    { 9, 5, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5003), "Dolorum veritatis vero. Velit sit autem ad eos corrupti. Voluptas voluptatum eum non. Praesentium ut quos eligendi rerum accusantium voluptatem dicta et harum. Aut fugit voluptatibus qui animi id est mollitia.", 0, "/images/cover-3.jpg", false, null, 58.71m, 5, 1, "Perferendis debitis culpa.", null },
                    { 10, 5, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5122), "Ipsum vitae natus voluptatem incidunt alias dicta possimus atque. Nesciunt quae magni quis hic asperiores blanditiis sint. Distinctio enim molestiae aperiam omnis nam asperiores omnis vitae. Sunt molestiae dolore expedita. Et quia consectetur in velit eos possimus officiis omnis. Laborum qui voluptatem aspernatur.", 0, "/images/cover-5.jpg", false, null, 58.55m, 7, 1, "Eveniet repellat soluta.", null },
                    { 11, 10, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5265), "Non saepe voluptas debitis fugiat eveniet occaecati non. Beatae deserunt eum ea sapiente mollitia quod et. Ut deserunt nesciunt aut.", 0, "/images/cover-3.jpg", false, null, 74.97m, 1, 2, "Error voluptatem dolores.", null },
                    { 12, 8, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5332), "Id eos quia sequi nulla quis tenetur ea. Totam qui ut expedita. Quisquam et inventore eveniet temporibus nobis officia velit. Consequuntur molestiae excepturi. Voluptas ut impedit porro nesciunt reiciendis.", 0, "/images/cover-10.jpg", false, null, 52.56m, 1, 3, "Repellendus molestias hic.", null },
                    { 13, 6, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5443), "Quia sunt eos quo nam suscipit eos. Aut ab et amet. Voluptatem illum dignissimos. Omnis aut est ut autem et culpa eos explicabo. Ipsum qui id et porro quos non nisi molestiae eos.", 0, "/images/cover-10.jpg", false, null, 88.85m, 5, 4, "Nesciunt vitae odio.", null },
                    { 14, 1, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5535), "Consectetur voluptas perspiciatis et ipsum nemo commodi aspernatur quis. Optio et non ratione laudantium. Et et qui iure magni consequatur et laboriosam. Aspernatur quaerat aut rerum. Esse voluptatem dolorum.", 0, "/images/cover-4.jpg", false, null, 71.20m, 2, 5, "Nihil totam autem.", null },
                    { 15, 4, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5653), "Fugit expedita fuga non a autem. Asperiores iusto ipsum aliquid ex quis expedita sunt hic. Porro illo sint voluptatem vero quia dignissimos.", 0, "/images/cover-3.jpg", false, null, 95.78m, 7, 3, "Iure placeat rerum.", null },
                    { 16, 3, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5734), "Blanditiis voluptatum eos. Provident voluptatem deleniti nisi distinctio. Labore ut et quod expedita sit et magnam dolorem. Qui perspiciatis ducimus perferendis atque dolorem et dolor quis. Illo odio cum cupiditate. Quam fugiat et adipisci architecto quo sunt mollitia.", 0, "/images/cover-4.jpg", false, null, 50.08m, 2, 3, "Est quo tempore.", null },
                    { 17, 1, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5838), "Quia et voluptatem. Voluptatum veritatis consequuntur voluptas reprehenderit sit et molestiae deserunt dolor. Suscipit saepe eos illum ea perferendis velit consequatur.", 0, "/images/cover-2.jpg", false, null, 67.91m, 3, 5, "Dolores et libero.", null },
                    { 18, 7, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(5962), "Ab dicta est est ex consequuntur. Aut soluta aspernatur ipsum odio explicabo sed doloribus neque ut. Earum sequi itaque vero provident ipsam repudiandae ut. Eum hic blanditiis eum voluptas. At qui recusandae tenetur voluptatum rerum facilis earum aut.", 0, "/images/cover-4.jpg", false, null, 48.29m, 6, 4, "Velit et ut.", null },
                    { 19, 4, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(6100), "Quis aut doloribus porro voluptatem tenetur quia qui. Maiores quidem eos ullam cum laborum omnis blanditiis distinctio. Esse maiores tempora voluptatem. Provident molestiae occaecati esse.", 0, "/images/cover-2.jpg", false, null, 62.77m, 2, 3, "Dolorem quis consectetur.", null },
                    { 20, 5, new DateTime(2024, 12, 31, 14, 26, 51, 610, DateTimeKind.Utc).AddTicks(6175), "Ad quod distinctio quisquam id porro ut dicta. Et repudiandae expedita magnam nulla saepe odit. Id dolorem ut voluptatem quia a enim repudiandae et dolor. Voluptates qui commodi et voluptatum est unde dolorem. Consequatur ipsum sit aperiam ex ut accusantium. Est cumque consequatur iste libero.", 0, "/images/cover-4.jpg", false, null, 64.40m, 1, 1, "Nihil a optio.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2056), false, null, 2 },
                    { 3, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2058), false, null, 3 },
                    { 4, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2058), false, null, 4 },
                    { 5, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2058), false, null, 5 },
                    { 6, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2059), false, null, 6 },
                    { 7, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2059), false, null, 7 },
                    { 8, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2059), false, null, 8 },
                    { 9, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2059), false, null, 9 },
                    { 10, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(2060), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "OrderState", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 12, 31, 14, 26, 51, 616, DateTimeKind.Utc).AddTicks(3744), "Robin37@hotmail.com", "Robin Collins", false, 1, 7, 0m, null, 3 },
                    { 2, 3, new DateTime(2024, 12, 31, 14, 26, 51, 616, DateTimeKind.Utc).AddTicks(7152), "Calvin_Nader@yahoo.com", "Calvin Nader", false, 4, 9, 0m, null, 10 },
                    { 3, 5, new DateTime(2024, 12, 31, 14, 26, 51, 616, DateTimeKind.Utc).AddTicks(8267), "Terri.McClure@yahoo.com", "Terri McClure", false, 0, 6, 0m, null, 4 },
                    { 4, 15, new DateTime(2024, 12, 31, 14, 26, 51, 616, DateTimeKind.Utc).AddTicks(8969), "Martin_Hahn@yahoo.com", "Martin Hahn", false, 1, 1, 0m, null, 9 },
                    { 5, 15, new DateTime(2024, 12, 31, 14, 26, 51, 616, DateTimeKind.Utc).AddTicks(9698), "Cecelia.Hilll@yahoo.com", "Cecelia Hilll", false, 0, 4, 0m, null, 6 },
                    { 6, 4, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(319), "Lyle.Kreiger81@hotmail.com", "Lyle Kreiger", false, 5, 6, 0m, null, 10 },
                    { 7, 10, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(963), "Bryant85@gmail.com", "Bryant Yundt", false, 5, 10, 0m, null, 5 },
                    { 8, 11, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(1650), "Archie_Kihn90@hotmail.com", "Archie Kihn", false, 1, 14, 0m, null, 4 },
                    { 9, 2, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(2278), "Nicolas_Maggio@yahoo.com", "Nicolas Maggio", false, 4, 8, 0m, null, 8 },
                    { 10, 13, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(2923), "Gary.Donnelly@yahoo.com", "Gary Donnelly", false, 3, 10, 0m, null, 10 },
                    { 11, 9, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(3595), "Tommie61@hotmail.com", "Tommie Morissette", false, 5, 8, 0m, null, 9 },
                    { 12, 1, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(4250), "Paul36@yahoo.com", "Paul Cassin", false, 5, 8, 0m, null, 8 },
                    { 13, 6, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(4956), "Deanna10@yahoo.com", "Deanna Dicki", false, 3, 5, 0m, null, 4 },
                    { 14, 4, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(5601), "Fred78@gmail.com", "Fred Barton", false, 4, 12, 0m, null, 2 },
                    { 15, 2, new DateTime(2024, 12, 31, 14, 26, 51, 617, DateTimeKind.Utc).AddTicks(6237), "Anita_Pfannerstill89@hotmail.com", "Anita Pfannerstill", false, 3, 6, 0m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(243), false, 4, 25.61m, 2, null },
                    { 2, 1, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1419), false, 8, 31.87m, 3, null },
                    { 3, 5, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1467), false, 1, 17.42m, 3, null },
                    { 4, 19, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1478), false, 10, 89.18m, 2, null },
                    { 5, 11, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1485), false, 15, 45.05m, 3, null },
                    { 6, 16, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1493), false, 1, 63.01m, 1, null },
                    { 7, 17, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1499), false, 12, 60.73m, 2, null },
                    { 8, 1, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1507), false, 7, 17.04m, 3, null },
                    { 9, 15, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1513), false, 8, 52.26m, 3, null },
                    { 10, 11, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1520), false, 2, 61.87m, 1, null },
                    { 11, 3, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1527), false, 13, 56.56m, 2, null },
                    { 12, 2, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1533), false, 1, 72.63m, 2, null },
                    { 13, 2, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1540), false, 4, 71.05m, 3, null },
                    { 14, 18, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1546), false, 8, 44.84m, 2, null },
                    { 15, 18, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1553), false, 1, 38.16m, 2, null },
                    { 16, 6, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1559), false, 14, 31.58m, 3, null },
                    { 17, 4, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1565), false, 8, 67.38m, 1, null },
                    { 18, 10, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1658), false, 11, 88.56m, 1, null },
                    { 19, 19, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1666), false, 8, 69.64m, 1, null },
                    { 20, 16, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1674), false, 2, 79.92m, 1, null },
                    { 21, 16, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1681), false, 11, 84.15m, 2, null },
                    { 22, 6, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1688), false, 6, 13.99m, 3, null },
                    { 23, 5, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1694), false, 10, 45.32m, 2, null },
                    { 24, 2, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1702), false, 13, 52.16m, 1, null },
                    { 25, 6, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1708), false, 11, 52.75m, 1, null },
                    { 26, 2, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1715), false, 7, 12.62m, 3, null },
                    { 27, 5, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1721), false, 12, 56.07m, 2, null },
                    { 28, 15, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1727), false, 11, 26.74m, 2, null },
                    { 29, 1, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1734), false, 10, 97.37m, 1, null },
                    { 30, 8, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1740), false, 2, 88.53m, 3, null },
                    { 31, 9, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1747), false, 9, 64.86m, 3, null },
                    { 32, 1, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1753), false, 4, 19.46m, 2, null },
                    { 33, 11, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1759), false, 7, 65.79m, 3, null },
                    { 34, 20, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1765), false, 10, 47.94m, 1, null },
                    { 35, 11, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1772), false, 1, 58.61m, 1, null },
                    { 36, 17, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1778), false, 3, 40.48m, 2, null },
                    { 37, 5, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1785), false, 2, 42.86m, 1, null },
                    { 38, 12, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1791), false, 12, 83.11m, 3, null },
                    { 39, 17, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1797), false, 2, 26.13m, 1, null },
                    { 40, 15, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1804), false, 15, 29.12m, 3, null },
                    { 41, 10, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1810), false, 11, 23.02m, 3, null },
                    { 42, 20, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1817), false, 14, 24.79m, 2, null },
                    { 43, 15, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1823), false, 4, 17.18m, 3, null },
                    { 44, 18, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1830), false, 11, 76.76m, 3, null },
                    { 45, 6, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1836), false, 13, 57.30m, 3, null },
                    { 46, 13, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1843), false, 7, 13.14m, 1, null },
                    { 47, 13, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1849), false, 2, 63.97m, 2, null },
                    { 48, 3, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1855), false, 4, 45.84m, 2, null },
                    { 49, 18, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1861), false, 2, 91.43m, 2, null },
                    { 50, 18, new DateTime(2024, 12, 31, 14, 26, 51, 619, DateTimeKind.Utc).AddTicks(1903), false, 12, 28.62m, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 4, "Adipisci sed recusandae fugiat dolor sunt.", new DateTime(2024, 12, 31, 14, 26, 51, 611, DateTimeKind.Utc).AddTicks(9725), false, 5, null, 5 },
                    { 2, 10, "Ullam porro autem dolor quis sint.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(887), false, 2, null, 7 },
                    { 3, 13, "Aut ipsa perferendis facere ut recusandae quaerat voluptatem id quaerat.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(956), false, 5, null, 3 },
                    { 4, 11, "Magni ullam iure enim nisi tenetur et ut.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(986), false, 4, null, 9 },
                    { 5, 16, "Ab tenetur facilis quo.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1009), false, 4, null, 3 },
                    { 6, 10, "Hic voluptatem minus odio voluptatem ut laboriosam alias.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1024), false, 1, null, 5 },
                    { 7, 17, "Pariatur et officiis consequuntur necessitatibus cupiditate autem quia minus.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1088), false, 5, null, 10 },
                    { 8, 11, "Voluptas fugit odio porro amet fuga et at.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1112), false, 3, null, 3 },
                    { 9, 20, "Et qui at ipsa.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1132), false, 4, null, 9 },
                    { 10, 5, "Veritatis iste reiciendis fuga voluptatum ut.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1146), false, 2, null, 9 },
                    { 11, 17, "Eaque eveniet enim amet voluptas fuga quam atque et odio.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1163), false, 4, null, 3 },
                    { 12, 15, "Dicta nostrum quo aut fuga et laboriosam assumenda ut.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1187), false, 5, null, 6 },
                    { 13, 13, "Voluptas molestias rem expedita rerum quia non suscipit quod.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1210), false, 2, null, 6 },
                    { 14, 8, "Ipsam ex excepturi facere esse.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1251), false, 5, null, 6 },
                    { 15, 4, "Magni omnis veritatis veniam magni in suscipit perspiciatis.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1269), false, 1, null, 2 },
                    { 16, 4, "Aut quo excepturi et quos cumque sit dolores molestiae.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1290), false, 1, null, 9 },
                    { 17, 7, "Accusamus officiis eaque quia maxime voluptate modi sit.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1314), false, 4, null, 9 },
                    { 18, 13, "Expedita est est quibusdam saepe dicta non veritatis.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1334), false, 3, null, 10 },
                    { 19, 16, "Odit ducimus tenetur enim ipsum aut velit.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1355), false, 2, null, 2 },
                    { 20, 9, "Sunt eligendi non qui aut nisi minima ut voluptas.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1374), false, 5, null, 10 },
                    { 21, 1, "Facere voluptatem et omnis quod.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1466), false, 2, null, 9 },
                    { 22, 12, "Maxime commodi aut facere magnam voluptate vel voluptas nostrum aspernatur.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1486), false, 4, null, 6 },
                    { 23, 14, "Dolor quia sequi et eius nihil enim necessitatibus repellat commodi.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1510), false, 3, null, 10 },
                    { 24, 19, "Reprehenderit voluptatibus est repellat fugit voluptatem at natus illum.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1535), false, 4, null, 10 },
                    { 25, 14, "Doloribus quam quo.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1557), false, 1, null, 10 },
                    { 26, 6, "Ex quia fugiat soluta ex.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1570), false, 1, null, 2 },
                    { 27, 2, "Non pariatur sit aut repellendus ut ipsum dolorem voluptatem fuga.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1586), false, 5, null, 3 },
                    { 28, 10, "Numquam asperiores inventore a molestiae aut eaque error.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1610), false, 3, null, 6 },
                    { 29, 14, "Corrupti voluptas rerum omnis sapiente aut et velit.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1672), false, 4, null, 7 },
                    { 30, 8, "Et doloribus quidem.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1693), false, 1, null, 7 },
                    { 31, 15, "Aut voluptates sit dolor rerum.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1705), false, 4, null, 10 },
                    { 32, 8, "Consequatur non deserunt nesciunt rerum assumenda ex vero.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1721), false, 1, null, 8 },
                    { 33, 11, "Et sit sint id enim at aperiam suscipit.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1741), false, 2, null, 6 },
                    { 34, 7, "Labore laudantium veritatis ipsam aut quibusdam id.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1762), false, 2, null, 2 },
                    { 35, 12, "Minus eveniet est tenetur quam quo maxime.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1782), false, 5, null, 2 },
                    { 36, 14, "Neque culpa harum ut sit ut.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1801), false, 4, null, 9 },
                    { 37, 14, "Doloremque nostrum vel tempore unde.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1896), false, 5, null, 3 },
                    { 38, 10, "Architecto dolor quia.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1913), false, 2, null, 7 },
                    { 39, 5, "Ut qui et non.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1926), false, 1, null, 6 },
                    { 40, 11, "Explicabo laborum illum eum ut ad maxime deleniti ducimus doloremque.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1940), false, 5, null, 8 },
                    { 41, 3, "Animi adipisci ullam.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1964), false, 2, null, 7 },
                    { 42, 14, "Laudantium eligendi iure fugiat consequatur sed voluptate quia ut.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1977), false, 1, null, 9 },
                    { 43, 3, "Adipisci eos sit qui.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(1999), false, 2, null, 9 },
                    { 44, 18, "Distinctio magni provident expedita temporibus.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2013), false, 3, null, 10 },
                    { 45, 19, "Sunt ipsa aspernatur et illum iure doloremque aut alias.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2064), false, 3, null, 6 },
                    { 46, 6, "Tenetur quibusdam reprehenderit sapiente ipsum porro eum saepe esse.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2087), false, 3, null, 2 },
                    { 47, 18, "Voluptate explicabo veniam quos a.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2111), false, 4, null, 8 },
                    { 48, 13, "Aliquam quia autem hic iusto consectetur non necessitatibus.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2127), false, 2, null, 8 },
                    { 49, 3, "Doloribus pariatur soluta eos voluptate iure nulla quibusdam voluptas voluptatem.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2148), false, 1, null, 8 },
                    { 50, 15, "Quos expedita dolores et atque.", new DateTime(2024, 12, 31, 14, 26, 51, 612, DateTimeKind.Utc).AddTicks(2172), false, 5, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 6, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5165), false, null, 8 },
                    { 2, 8, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5341), false, null, 3 },
                    { 3, 8, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5347), false, null, 3 },
                    { 4, 5, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5350), false, null, 2 },
                    { 5, 6, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5353), false, null, 3 },
                    { 6, 13, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5356), false, null, 8 },
                    { 7, 4, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5359), false, null, 8 },
                    { 8, 5, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5362), false, null, 3 },
                    { 9, 2, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5365), false, null, 6 },
                    { 10, 11, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5367), false, null, 8 },
                    { 11, 1, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5370), false, null, 6 },
                    { 12, 3, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5373), false, null, 5 },
                    { 13, 6, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5375), false, null, 9 },
                    { 14, 20, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5378), false, null, 10 },
                    { 15, 3, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5381), false, null, 3 },
                    { 16, 1, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5384), false, null, 10 },
                    { 17, 2, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5387), false, null, 7 },
                    { 18, 8, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5390), false, null, 8 },
                    { 19, 16, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5392), false, null, 10 },
                    { 20, 3, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5395), false, null, 7 },
                    { 21, 14, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5398), false, null, 5 },
                    { 22, 5, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5400), false, null, 6 },
                    { 23, 19, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5403), false, null, 10 },
                    { 24, 7, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5406), false, null, 10 },
                    { 25, 13, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5409), false, null, 3 },
                    { 26, 16, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5411), false, null, 2 },
                    { 27, 5, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5414), false, null, 4 },
                    { 28, 6, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5417), false, null, 7 },
                    { 29, 19, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5420), false, null, 3 },
                    { 30, 1, new DateTime(2024, 12, 31, 14, 26, 51, 613, DateTimeKind.Utc).AddTicks(5423), false, null, 3 }
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
                name: "IX_GiftCards_Name",
                table: "GiftCards",
                column: "Name",
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
