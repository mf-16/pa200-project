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
                    { 1, "Gleichnerbury", "Cook Islands", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(582), false, "Nevada", "8203 Isabell Trail", null, "18617-3823" },
                    { 2, "Carolineport", "Norfolk Island", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(1416), false, "Alabama", "8867 Jones Orchard", null, "26912-0704" },
                    { 3, "Port Rossietown", "Vietnam", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(1654), false, "Rhode Island", "679 Volkman Skyway", null, "90525-5223" },
                    { 4, "Emardchester", "Isle of Man", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(1862), false, "New Jersey", "82911 Jacobs Square", null, "51371-9019" },
                    { 5, "South Carey", "Angola", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(2051), false, "New Hampshire", "302 Jena Ports", null, "06849" },
                    { 6, "Lake Florencio", "Maldives", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(2229), false, "Vermont", "653 Pouros Lodge", null, "20264" },
                    { 7, "Rogeliochester", "Yemen", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(2514), false, "New Jersey", "274 Eryn Spring", null, "86858-7132" },
                    { 8, "New Rubytown", "Colombia", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(2716), false, "Iowa", "52894 Pollich Underpass", null, "58248" },
                    { 9, "O'Haratown", "China", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(2926), false, "North Carolina", "8232 Rosella Villages", null, "49844" },
                    { 10, "North Lamont", "Brazil", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(3148), false, "Montana", "8041 Bauch Corners", null, "45588" },
                    { 11, "Bednarmouth", "Lesotho", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(3337), false, "South Carolina", "161 Joan Square", null, "27400-0500" },
                    { 12, "West Lillabury", "Sierra Leone", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(3504), false, "Pennsylvania", "4242 Bertha Skyway", null, "66828" },
                    { 13, "Lake Reneefurt", "Mayotte", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(3683), false, "Hawaii", "048 Arielle Burgs", null, "32712-4344" },
                    { 14, "East Margarettaburgh", "Dominican Republic", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(3865), false, "Wisconsin", "21019 Feeney Loaf", null, "72406" },
                    { 15, "Dooleybury", "Slovakia (Slovak Republic)", new DateTime(2024, 12, 9, 8, 56, 32, 336, DateTimeKind.Utc).AddTicks(4046), false, "Virginia", "797 Althea Lake", null, "02845" }
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
                    { 1, 0, "af4b7fec-064a-424d-b119-f5a345b4a689", "admin@admin.com", true, false, null, "Admin User", null, null, null, "123-456-7890", false, "cffa5f06-253b-4316-8764-f26fc8d4c236", false, "admin@admin.com" },
                    { 2, 0, "6ecef300-a6f7-443e-bea0-4306bedd0211", "Eve.Stracke@hotmail.com", true, false, null, "Annamarie Carroll", null, null, null, "492.746.4227 x168", false, "5865931f-9bd2-475e-89af-9539fb059449", false, "Eve.Stracke@hotmail.com" },
                    { 3, 0, "c6af40b1-a30a-4890-977d-0fc1f1a872f8", "Monte4@yahoo.com", true, false, null, "Aniya Graham", null, null, null, "462.533.1269", false, "cf6d424a-bcb5-45ff-be59-da5596f99b95", false, "Monte4@yahoo.com" },
                    { 4, 0, "ec21a751-ed33-42a8-ad39-02640132f09d", "Hayley15@hotmail.com", true, false, null, "Clarissa Dare", null, null, null, "1-896-686-2844 x261", false, "7f3f6a14-3dde-4fdb-b75f-1c193c3be1ee", false, "Hayley15@hotmail.com" },
                    { 5, 0, "dfde58e8-ce66-4b89-a34f-4fc748531375", "Salma_Kling@hotmail.com", true, false, null, "Vickie Kuhic", null, null, null, "240.712.9256 x770", false, "4dcd13b1-9def-4dd3-bd6a-9b87da76f72f", false, "Salma_Kling@hotmail.com" },
                    { 6, 0, "01e3f9ff-6dd4-473d-a2f9-51d70f5fffea", "Mozell.Schinner42@gmail.com", true, false, null, "Carmen Jast", null, null, null, "(893) 347-8042 x0076", false, "f2f262df-2239-4225-a19e-5c29794a627b", false, "Mozell.Schinner42@gmail.com" },
                    { 7, 0, "090e13cf-67ca-4f7d-8bd9-0cd17d0c764e", "Dereck_Crona34@hotmail.com", true, false, null, "Chance Cartwright", null, null, null, "(642) 876-2912", false, "7bc895e2-f8f1-45bb-b333-9397fef862d7", false, "Dereck_Crona34@hotmail.com" },
                    { 8, 0, "954f37b7-9294-47f8-8afc-3161d24d7794", "Delfina.Goodwin@hotmail.com", true, false, null, "Jacky Corwin", null, null, null, "1-700-618-6358", false, "98714ec9-b9df-4a5f-a62e-fbcf9e0ac879", false, "Delfina.Goodwin@hotmail.com" },
                    { 9, 0, "4406bfa4-7934-4054-897f-85359ea2b021", "Sherman.Will50@gmail.com", true, false, null, "Myrtis Frami", null, null, null, "(843) 698-2521 x91348", false, "5ded13d4-f230-4c17-990e-e5620c81796b", false, "Sherman.Will50@gmail.com" },
                    { 10, 0, "7c1b58d6-5c01-46ed-af55-fbdcfa189adc", "Deondre.Harber77@yahoo.com", true, false, null, "Mathias Littel", null, null, null, "760.420.5432 x097", false, "cee0fb00-2b4b-42f9-9c3e-bdbde316d6e0", false, "Deondre.Harber77@yahoo.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ut odio accusamus corrupti nisi. Consequuntur repudiandae consequatur ea quisquam voluptas ut quam quis. Rerum non cum quia nam. Perspiciatis asperiores voluptatibus. Et voluptas porro.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(929), false, "Jeremie Gislason", null },
                    { 2, "Culpa vero quia molestiae earum veniam est tenetur quia. Laboriosam saepe veritatis similique molestiae. Molestias qui repudiandae dolor iusto quia voluptas. Nam veniam qui aperiam asperiores veritatis enim molestias expedita.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(1433), false, "Mittie Pfannerstill", null },
                    { 3, "Fugiat dicta officiis ex dolores adipisci enim dolor fuga consequuntur. Sint ducimus possimus iure aliquam sit minus voluptatem eos eligendi. Animi ut dolor ratione est ad qui. Est illum vel. Eos accusamus et hic fugit eum impedit impedit vel unde. Quis vitae voluptatem quibusdam iure omnis eos esse dicta quos.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(1615), false, "Alex Waters", null },
                    { 4, "Ut incidunt labore sunt ducimus. Ea autem non provident aut et inventore. Sunt est qui qui quia.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(1845), false, "Kelton Hickle", null },
                    { 5, "Fuga porro neque. Odit rerum ea. Et omnis ea et deserunt itaque culpa aliquid. Iusto architecto deleniti quos eveniet fuga odit voluptate. Libero iure placeat saepe ipsum est beatae et.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(1966), false, "Hadley Deckow", null },
                    { 6, "Omnis hic sed blanditiis laboriosam eos est veritatis. Temporibus libero consectetur autem rerum illo est. Ut id numquam sunt quia qui ipsum minima aut. Voluptas est illum perferendis.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(2096), false, "Pattie Ruecker", null },
                    { 7, "Recusandae et et qui ut voluptas fugiat. Et sint tempore vel fugit quis totam. Suscipit quos quo ut est quibusdam.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(2229), false, "Bertram Kuhic", null },
                    { 8, "Explicabo minima doloribus fugit commodi sunt. Magnam itaque modi debitis nam eos. Nihil quia est magnam aut voluptas dolores reiciendis qui eum. Repudiandae maxime et maiores delectus.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(2316), false, "Margarita Graham", null },
                    { 9, "Ut ipsum earum. Rerum perspiciatis voluptatem non rem. Non aliquam velit id rerum ut sequi distinctio. Laborum nihil et qui molestias.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(2604), false, "Gordon Wiza", null },
                    { 10, "Ipsum vel perferendis. Quis hic similique non. Quam deleniti qui et neque ex et ut earum. Nostrum quam dolores maxime voluptatum eligendi excepturi. Quo veniam asperiores consequatur aut voluptates sit ut nostrum.", new DateTime(2024, 12, 9, 8, 56, 32, 324, DateTimeKind.Utc).AddTicks(2701), false, "Jason O'Reilly", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Aut quis dicta." },
                    { 2, "Sint reprehenderit consequatur." },
                    { 3, "At error eum." },
                    { 4, "Eaque aut itaque." },
                    { 5, "Perferendis ut beatae." },
                    { 6, "Voluptas deserunt deserunt." }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Dolores est facilis esse id facilis. Tenetur maiores nam veniam mollitia delectus quidem nisi. Ea quis provident expedita. Possimus quisquam neque repellendus ullam labore voluptas quo dolores. Commodi ipsam error necessitatibus vero alias explicabo exercitationem labore.", new DateTime(2024, 12, 9, 8, 56, 32, 325, DateTimeKind.Utc).AddTicks(9275), false, "Williamson - Bartoletti", null },
                    { 2, "Ut ex sed et doloremque omnis rem. Consectetur qui excepturi at provident reprehenderit id et iusto. Ratione earum suscipit voluptas quia natus officia. Facilis adipisci ut autem nobis maiores aut.", new DateTime(2024, 12, 9, 8, 56, 32, 326, DateTimeKind.Utc).AddTicks(66), false, "Anderson - Feest", null },
                    { 3, "Fugiat id esse aperiam aut. Error doloremque enim rem molestiae dicta maiores voluptatem. Aut voluptatum dolores facere quibusdam nihil cupiditate corporis consectetur magnam.", new DateTime(2024, 12, 9, 8, 56, 32, 326, DateTimeKind.Utc).AddTicks(323), false, "Kerluke, Halvorson and Lebsack", null },
                    { 4, "Ut laboriosam quis quas ut explicabo repellendus quo sed occaecati. At maiores sed aspernatur id iure consectetur. Corrupti dolores sit quis nostrum. Illo voluptate accusamus odio.", new DateTime(2024, 12, 9, 8, 56, 32, 326, DateTimeKind.Utc).AddTicks(629), false, "Little, Jenkins and Kuhn", null },
                    { 5, "Explicabo omnis et quas quia eius officiis. Aliquid provident perspiciatis accusantium quam repudiandae sint mollitia. Ut ut qui sed voluptas aut ea. Dignissimos aliquam aut sunt. Provident magnam aut odit corrupti voluptatum earum nulla voluptatem nulla. Eligendi et voluptas placeat nostrum maiores et at voluptas voluptas.", new DateTime(2024, 12, 9, 8, 56, 32, 326, DateTimeKind.Utc).AddTicks(907), false, "Daniel, Cruickshank and Schowalter", null }
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
                    { 1, 9, new DateTime(2024, 12, 9, 8, 56, 32, 329, DateTimeKind.Utc).AddTicks(7395), "Error iure vel explicabo nulla. Non reiciendis atque inventore sunt totam vero sed. Similique ex occaecati tempora est. Non consectetur beatae nemo neque. Pariatur repudiandae consequatur quos minima itaque voluptate dolores.", 0, "https://picsum.photos/640/480/?image=541", false, null, 19.74m, 6, 2, "Aut eos optio.", null },
                    { 2, 3, new DateTime(2024, 12, 9, 8, 56, 32, 329, DateTimeKind.Utc).AddTicks(9524), "Fugiat quae iste eveniet. Eos iure itaque accusantium quod amet aut. Error eligendi repellendus possimus nesciunt minima. Aspernatur ut harum mollitia reprehenderit vel qui nobis. Suscipit omnis magnam aut.", 0, "https://picsum.photos/640/480/?image=171", false, null, 85.92m, 3, 4, "Maiores iste itaque.", null },
                    { 3, 4, new DateTime(2024, 12, 9, 8, 56, 32, 329, DateTimeKind.Utc).AddTicks(9773), "Aut libero ea totam porro nemo est iusto nostrum. Iusto magnam eum. Veniam voluptas quae perspiciatis optio. Repudiandae iste autem omnis error quis. In rerum repellendus voluptatum fuga deserunt voluptates. Ea repudiandae reprehenderit omnis nihil reiciendis deserunt animi voluptatem maxime.", 0, "https://picsum.photos/640/480/?image=33", false, null, 95.64m, 4, 3, "Omnis ullam velit.", null },
                    { 4, 9, new DateTime(2024, 12, 9, 8, 56, 32, 329, DateTimeKind.Utc).AddTicks(9988), "Unde alias aut. Molestiae laborum totam iste. Ut voluptas ipsam molestias officia sit saepe qui. Iusto quibusdam vel nihil. Ut ea cumque voluptas nobis maxime.", 0, "https://picsum.photos/640/480/?image=642", false, null, 27.98m, 4, 1, "Est aut ipsam.", null },
                    { 5, 4, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(114), "Eveniet ab illo. Quisquam voluptatem ut enim. Dolorem inventore ducimus. Sit debitis vel temporibus. Ut vel non inventore.", 0, "https://picsum.photos/640/480/?image=219", false, null, 92.19m, 1, 3, "Aliquid quaerat natus.", null },
                    { 6, 1, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(259), "Eveniet quo nam voluptate totam. Sint iste reprehenderit sequi perspiciatis. Ex illo maiores aliquid. In ad id est in voluptatum.", 0, "https://picsum.photos/640/480/?image=958", false, null, 25.92m, 3, 1, "Nisi odio autem.", null },
                    { 7, 5, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(361), "Consequatur ipsa dolorum eligendi molestias consequatur similique. Fugit in earum in omnis. Accusamus omnis recusandae praesentium aut fuga. Fugiat facilis temporibus autem quidem provident illo libero. Debitis voluptas vero alias quo dolorem.", 0, "https://picsum.photos/640/480/?image=240", false, null, 33.40m, 1, 3, "Nihil expedita dolor.", null },
                    { 8, 6, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(534), "Hic cupiditate est non fugit fugit voluptatem sit quidem non. Iusto temporibus saepe voluptates fuga. Molestiae quia alias. Tempore fuga excepturi a quia enim ut saepe. Fuga a eligendi eum totam autem velit repellendus incidunt.", 0, "https://picsum.photos/640/480/?image=1032", false, null, 95.34m, 1, 4, "Qui quo voluptatem.", null },
                    { 9, 2, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(714), "Aut est et rerum a. Dolor enim veniam mollitia excepturi quis consectetur recusandae nam porro. Nihil accusantium aliquam aut adipisci quia blanditiis animi repellendus. Rerum harum vitae enim.", 0, "https://picsum.photos/640/480/?image=590", false, null, 82.42m, 4, 3, "Et excepturi similique.", null },
                    { 10, 10, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(837), "Laborum non dicta. Magnam quam voluptatem atque in rerum consequatur. Sint voluptatem sit cupiditate sed ut laboriosam recusandae.", 0, "https://picsum.photos/640/480/?image=648", false, null, 76.19m, 6, 3, "Non aut quia.", null },
                    { 11, 7, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(965), "Eligendi eos tempore velit vel iusto. Qui molestias placeat. Ex incidunt a beatae sapiente ducimus. Est aperiam dolores beatae expedita atque eligendi voluptas dolorem quas. Et deserunt consequuntur.", 0, "https://picsum.photos/640/480/?image=70", false, null, 76.46m, 1, 5, "Ipsam eos quia.", null },
                    { 12, 1, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(1101), "Rerum maxime non dolores. Ipsa dignissimos amet aut ut aperiam aut corporis maiores. Aut reiciendis animi voluptates ipsum non. Assumenda quia sed voluptatem dicta sed pariatur ut. Laboriosam voluptas et sed atque.", 0, "https://picsum.photos/640/480/?image=606", false, null, 67.15m, 1, 3, "Explicabo libero voluptatum.", null },
                    { 13, 9, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(1236), "Provident nostrum perspiciatis. Odit sit dolore. Quam ea iure accusamus aliquam ratione consequatur non. Nemo nemo alias unde voluptatem. Amet sunt omnis perferendis natus sit soluta non dolorem ab.", 0, "https://picsum.photos/640/480/?image=563", false, null, 97.13m, 2, 1, "Quam aliquid rem.", null },
                    { 14, 3, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(1427), "Ratione earum fugit. Dignissimos cum consectetur aspernatur sapiente dicta cum voluptates autem. Eum nisi assumenda consequatur amet inventore sunt. Animi fuga numquam qui velit sunt. Quas magni temporibus quia quis soluta. Et laboriosam doloremque.", 0, "https://picsum.photos/640/480/?image=160", false, null, 87.60m, 6, 4, "Enim et eaque.", null },
                    { 15, 2, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(1618), "Fuga autem iusto sunt porro quae sed. Quasi illo pariatur omnis est voluptates similique officiis eius illo. Vitae nemo dolore necessitatibus aut. Quia sit ex sunt. Consectetur eveniet ad ullam sed velit molestias quidem dolorem ex. Voluptatem incidunt qui non earum laboriosam.", 0, "https://picsum.photos/640/480/?image=758", false, null, 14.55m, 4, 5, "Molestias nemo illo.", null },
                    { 16, 3, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(1841), "Eius quia deserunt eos vel. Possimus error non. Sapiente sequi iusto labore qui ut. Possimus ipsam labore enim.", 0, "https://picsum.photos/640/480/?image=1069", false, null, 64.96m, 6, 1, "Doloremque et sapiente.", null },
                    { 17, 1, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(1936), "Exercitationem qui quos. Quia dolores at ipsam molestiae consequatur nobis. Consequatur voluptatem aspernatur quia sint sint dolore qui. Libero rerum aliquam quis ut sit.", 0, "https://picsum.photos/640/480/?image=584", false, null, 97.28m, 1, 5, "Nisi tempora nihil.", null },
                    { 18, 4, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(2075), "Dolor eaque voluptas temporibus impedit itaque consectetur. Ut possimus assumenda commodi et quisquam voluptas qui debitis. Tempora reprehenderit autem error quidem voluptatem in. Ut facere qui. Aspernatur dolorem nobis. Temporibus quo tenetur illo eos.", 0, "https://picsum.photos/640/480/?image=969", false, null, 87.69m, 3, 3, "Ipsam omnis excepturi.", null },
                    { 19, 9, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(2243), "Veritatis animi quod. Incidunt reiciendis vitae inventore. Ut et aut qui deserunt culpa molestiae a quisquam.", 0, "https://picsum.photos/640/480/?image=512", false, null, 12.23m, 1, 4, "Et architecto enim.", null },
                    { 20, 1, new DateTime(2024, 12, 9, 8, 56, 32, 330, DateTimeKind.Utc).AddTicks(2328), "Cupiditate et expedita quos magni. Architecto voluptas in architecto voluptatem vel. A est dicta quis iusto. Libero delectus pariatur perspiciatis maiores cumque quos omnis cumque.", 0, "https://picsum.photos/640/480/?image=85", false, null, 84.51m, 5, 5, "Itaque vel aut.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7785), false, null, 2 },
                    { 3, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7788), false, null, 3 },
                    { 4, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7788), false, null, 4 },
                    { 5, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7788), false, null, 5 },
                    { 6, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7789), false, null, 6 },
                    { 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7789), false, null, 7 },
                    { 8, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7789), false, null, 8 },
                    { 9, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7790), false, null, 9 },
                    { 10, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7790), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(1430), "Billy.Schiller82@yahoo.com", "Billy Schiller", false, 1, 0m, null, 7 },
                    { 2, 5, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(4673), "Doreen.Koepp50@hotmail.com", "Doreen Koepp", false, 1, 0m, null, 7 },
                    { 3, 6, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(6094), "Ana45@gmail.com", "Ana Monahan", false, 13, 0m, null, 3 },
                    { 4, 13, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(7064), "Vicki64@gmail.com", "Vicki Ankunding", false, 3, 0m, null, 2 },
                    { 5, 1, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(7979), "Janice92@hotmail.com", "Janice Howell", false, 9, 0m, null, 10 },
                    { 6, 4, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(8845), "Stephen.Stroman@hotmail.com", "Stephen Stroman", false, 2, 0m, null, 9 },
                    { 7, 7, new DateTime(2024, 12, 9, 8, 56, 32, 338, DateTimeKind.Utc).AddTicks(9785), "Delia.Smith@hotmail.com", "Delia Smith", false, 2, 0m, null, 2 },
                    { 8, 6, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(643), "Timmy.Gaylord29@gmail.com", "Timmy Gaylord", false, 13, 0m, null, 9 },
                    { 9, 1, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(1490), "Morris13@hotmail.com", "Morris Cassin", false, 4, 0m, null, 8 },
                    { 10, 4, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(2456), "Dixie.Moen24@yahoo.com", "Dixie Moen", false, 11, 0m, null, 3 },
                    { 11, 8, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(3361), "Saul86@hotmail.com", "Saul Kuhic", false, 3, 0m, null, 2 },
                    { 12, 12, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(4243), "Nina_Bins@hotmail.com", "Nina Bins", false, 13, 0m, null, 4 },
                    { 13, 14, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(5257), "Connie87@gmail.com", "Connie Green", false, 7, 0m, null, 2 },
                    { 14, 5, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(6068), "Edgar48@hotmail.com", "Edgar Boyer", false, 7, 0m, null, 8 },
                    { 15, 3, new DateTime(2024, 12, 9, 8, 56, 32, 339, DateTimeKind.Utc).AddTicks(6952), "Laverne.Swaniawski52@yahoo.com", "Laverne Swaniawski", false, 2, 0m, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(5328), false, 10, 21.90m, 2, null },
                    { 2, 2, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(6885), false, 10, 61.29m, 3, null },
                    { 3, 4, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(6954), false, 12, 92.97m, 1, null },
                    { 4, 3, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(6971), false, 15, 87.98m, 3, null },
                    { 5, 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(6984), false, 1, 98.11m, 2, null },
                    { 6, 11, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7101), false, 7, 66.39m, 3, null },
                    { 7, 14, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7111), false, 10, 48.92m, 3, null },
                    { 8, 1, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7121), false, 9, 69.23m, 3, null },
                    { 9, 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7131), false, 5, 44.88m, 3, null },
                    { 10, 2, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7141), false, 9, 94.46m, 2, null },
                    { 11, 15, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7151), false, 12, 33.53m, 1, null },
                    { 12, 20, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7161), false, 8, 57.61m, 3, null },
                    { 13, 3, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7171), false, 1, 38.64m, 1, null },
                    { 14, 18, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7181), false, 4, 40.64m, 3, null },
                    { 15, 19, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7191), false, 14, 60.90m, 1, null },
                    { 16, 6, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7202), false, 1, 90.39m, 3, null },
                    { 17, 5, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7212), false, 10, 24.89m, 3, null },
                    { 18, 2, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7222), false, 14, 57.42m, 3, null },
                    { 19, 6, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7232), false, 4, 95.78m, 2, null },
                    { 20, 17, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7242), false, 11, 66.21m, 3, null },
                    { 21, 3, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7251), false, 3, 99.70m, 2, null },
                    { 22, 16, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7261), false, 11, 13.00m, 1, null },
                    { 23, 6, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7271), false, 6, 74.35m, 1, null },
                    { 24, 13, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7281), false, 1, 66.21m, 2, null },
                    { 25, 3, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7291), false, 15, 42.02m, 2, null },
                    { 26, 19, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7301), false, 15, 30.99m, 2, null },
                    { 27, 17, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7311), false, 5, 44.98m, 2, null },
                    { 28, 2, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7320), false, 12, 13.54m, 1, null },
                    { 29, 19, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7330), false, 10, 22.41m, 2, null },
                    { 30, 9, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7339), false, 2, 29.60m, 3, null },
                    { 31, 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7349), false, 5, 64.34m, 1, null },
                    { 32, 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7358), false, 8, 10.01m, 3, null },
                    { 33, 5, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7368), false, 7, 60.92m, 2, null },
                    { 34, 18, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7378), false, 9, 12.56m, 1, null },
                    { 35, 16, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7387), false, 2, 30.75m, 1, null },
                    { 36, 16, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7397), false, 8, 55.83m, 3, null },
                    { 37, 19, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7407), false, 8, 90.83m, 3, null },
                    { 38, 11, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7463), false, 9, 49.71m, 1, null },
                    { 39, 19, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7474), false, 5, 23.33m, 2, null },
                    { 40, 17, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7483), false, 2, 19.06m, 2, null },
                    { 41, 9, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7494), false, 12, 92.40m, 3, null },
                    { 42, 9, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7505), false, 4, 28.06m, 3, null },
                    { 43, 4, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7515), false, 11, 62.21m, 3, null },
                    { 44, 20, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7525), false, 10, 76.34m, 3, null },
                    { 45, 16, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7535), false, 13, 16.70m, 3, null },
                    { 46, 19, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7545), false, 12, 21.31m, 1, null },
                    { 47, 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7554), false, 6, 32.54m, 3, null },
                    { 48, 10, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7564), false, 5, 52.24m, 2, null },
                    { 49, 8, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7573), false, 2, 57.77m, 3, null },
                    { 50, 7, new DateTime(2024, 12, 9, 8, 56, 32, 341, DateTimeKind.Utc).AddTicks(7583), false, 7, 65.74m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 11, "Saepe quia voluptatem temporibus voluptas tempore repudiandae natus rerum.", new DateTime(2024, 12, 9, 8, 56, 32, 331, DateTimeKind.Utc).AddTicks(9740), false, 1, null, 7 },
                    { 2, 14, "Fuga ad eos inventore ab et accusamus consequuntur natus.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1350), false, 4, null, 4 },
                    { 3, 6, "Consequatur architecto eveniet explicabo ducimus consequatur.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1456), false, 1, null, 7 },
                    { 4, 20, "Voluptatem autem ipsam amet.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1486), false, 5, null, 10 },
                    { 5, 18, "Similique sapiente hic dolores ut ea est earum.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1572), false, 5, null, 7 },
                    { 6, 14, "Minima qui aut.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1607), false, 1, null, 8 },
                    { 7, 20, "Quaerat tenetur numquam incidunt nihil eveniet omnis sit neque quaerat.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1625), false, 5, null, 5 },
                    { 8, 10, "Perspiciatis et repudiandae.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1660), false, 2, null, 10 },
                    { 9, 13, "Magnam nulla officiis architecto eligendi ducimus harum quasi et.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1680), false, 1, null, 2 },
                    { 10, 5, "Vitae ut culpa accusamus non.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1712), false, 4, null, 9 },
                    { 11, 5, "Et fugiat sunt in voluptas.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1735), false, 4, null, 6 },
                    { 12, 10, "Aut aut natus libero enim non qui velit qui molestias.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1758), false, 3, null, 8 },
                    { 13, 13, "Vel unde consequatur qui dignissimos ullam earum necessitatibus eius pariatur.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1827), false, 2, null, 3 },
                    { 14, 8, "Voluptatem alias similique nesciunt ea dignissimos quia qui.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1904), false, 1, null, 4 },
                    { 15, 14, "Fugiat aspernatur atque aut.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1950), false, 1, null, 4 },
                    { 16, 8, "Non commodi placeat architecto delectus vitae aperiam magni velit possimus.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(1973), false, 3, null, 8 },
                    { 17, 10, "Sed quidem ad nihil vel odio eum.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2007), false, 1, null, 10 },
                    { 18, 11, "A omnis quisquam praesentium voluptas molestiae iure sunt.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2033), false, 1, null, 4 },
                    { 19, 6, "Reprehenderit distinctio ratione voluptatum quo magni.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2063), false, 3, null, 6 },
                    { 20, 17, "Modi quisquam maxime in magnam.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2125), false, 2, null, 10 },
                    { 21, 14, "Sed nam sed culpa a sed totam.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2149), false, 2, null, 9 },
                    { 22, 9, "Et itaque totam nemo tempora est beatae quis nihil et.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2178), false, 2, null, 5 },
                    { 23, 3, "Cupiditate dolor omnis nulla quas maxime nihil delectus est officia.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2214), false, 1, null, 3 },
                    { 24, 12, "Consequatur sed cum fugit quibusdam perferendis voluptatem mollitia libero laudantium.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2247), false, 5, null, 2 },
                    { 25, 17, "Ad reprehenderit ex voluptas.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2283), false, 4, null, 8 },
                    { 26, 5, "Repellat ut quasi laudantium nostrum excepturi dolores.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2303), false, 3, null, 5 },
                    { 27, 2, "Repellat nostrum dolorum.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2332), false, 5, null, 5 },
                    { 28, 7, "Facere ea nulla consequuntur velit impedit dolorem laborum ducimus voluptatem.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2473), false, 4, null, 4 },
                    { 29, 2, "Et reprehenderit aperiam in sit quod et nam sed.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2511), false, 3, null, 3 },
                    { 30, 3, "Explicabo eaque quia quia.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2544), false, 2, null, 5 },
                    { 31, 4, "Quia delectus occaecati deserunt quasi.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2564), false, 1, null, 4 },
                    { 32, 20, "Distinctio labore atque totam veritatis ducimus aut in quos tenetur.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2586), false, 1, null, 5 },
                    { 33, 16, "Quam numquam sed nostrum dolorem sapiente autem natus ut.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2619), false, 4, null, 9 },
                    { 34, 4, "Ut ratione beatae ipsa dolore.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2650), false, 3, null, 10 },
                    { 35, 9, "Delectus commodi et qui laudantium voluptatem.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2672), false, 3, null, 9 },
                    { 36, 19, "Sunt excepturi tempora fuga.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2733), false, 2, null, 5 },
                    { 37, 13, "Ipsum deleniti et aut minima ab id vel reiciendis.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2754), false, 1, null, 6 },
                    { 38, 15, "Provident voluptatem et.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2788), false, 1, null, 9 },
                    { 39, 20, "Consequatur ut et eum qui tempora.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2806), false, 1, null, 5 },
                    { 40, 18, "Quam inventore tempora aut vero a.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2831), false, 1, null, 5 },
                    { 41, 5, "Ad minus reprehenderit voluptatem tempore vel excepturi quia.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2856), false, 4, null, 7 },
                    { 42, 9, "Deserunt quo et quia nisi inventore est.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2887), false, 2, null, 10 },
                    { 43, 11, "Suscipit odit non.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2914), false, 1, null, 8 },
                    { 44, 17, "Tempore qui laborum distinctio qui illum et animi omnis debitis.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(2969), false, 3, null, 8 },
                    { 45, 3, "Quasi at iste quas ea eaque labore.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(3005), false, 1, null, 3 },
                    { 46, 19, "Esse accusantium assumenda.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(3032), false, 5, null, 4 },
                    { 47, 8, "Eveniet quis praesentium est consectetur excepturi incidunt vel.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(3050), false, 4, null, 7 },
                    { 48, 18, "Quia sapiente consectetur maxime dolor rem eos quod nobis magnam.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(3079), false, 4, null, 6 },
                    { 49, 9, "Nihil optio qui aliquid aut.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(3113), false, 4, null, 8 },
                    { 50, 5, "Non ad velit iusto esse exercitationem et.", new DateTime(2024, 12, 9, 8, 56, 32, 332, DateTimeKind.Utc).AddTicks(3136), false, 4, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 18, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(454), false, null, 2 },
                    { 2, 4, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(650), false, null, 8 },
                    { 3, 13, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(660), false, null, 9 },
                    { 4, 1, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(665), false, null, 4 },
                    { 5, 4, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(670), false, null, 8 },
                    { 6, 19, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(674), false, null, 5 },
                    { 7, 20, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(678), false, null, 4 },
                    { 8, 1, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(682), false, null, 7 },
                    { 9, 7, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(686), false, null, 10 },
                    { 10, 7, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(690), false, null, 8 },
                    { 11, 20, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(694), false, null, 5 },
                    { 12, 14, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(698), false, null, 8 },
                    { 13, 8, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(703), false, null, 4 },
                    { 14, 2, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(707), false, null, 7 },
                    { 15, 2, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(711), false, null, 5 },
                    { 16, 7, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(715), false, null, 4 },
                    { 17, 7, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(719), false, null, 6 },
                    { 18, 12, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(723), false, null, 3 },
                    { 19, 8, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(727), false, null, 10 },
                    { 20, 16, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(731), false, null, 7 },
                    { 21, 11, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(735), false, null, 6 },
                    { 22, 6, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(739), false, null, 10 },
                    { 23, 5, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(743), false, null, 6 },
                    { 24, 10, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(747), false, null, 3 },
                    { 25, 16, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(752), false, null, 7 },
                    { 26, 16, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(756), false, null, 9 },
                    { 27, 7, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(760), false, null, 7 },
                    { 28, 19, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(764), false, null, 6 },
                    { 29, 1, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(768), false, null, 6 },
                    { 30, 20, new DateTime(2024, 12, 9, 8, 56, 32, 334, DateTimeKind.Utc).AddTicks(773), false, null, 10 }
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
