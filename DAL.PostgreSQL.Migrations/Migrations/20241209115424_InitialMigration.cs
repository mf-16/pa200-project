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
                    { 1, "South Donniemouth", "Italy", new DateTime(2024, 12, 9, 11, 54, 24, 341, DateTimeKind.Utc).AddTicks(9314), false, "Utah", "4331 Schuppe Club", null, "79172" },
                    { 2, "O'Keefeport", "Guam", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(406), false, "Arizona", "2228 Lubowitz Orchard", null, "76077" },
                    { 3, "Lake Lukashaven", "Bolivia", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(581), false, "Vermont", "559 Holden Lakes", null, "87927" },
                    { 4, "Floriantown", "Ukraine", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(744), false, "Wisconsin", "16743 Graham Station", null, "59771" },
                    { 5, "Hagenesshire", "Cyprus", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(896), false, "Kentucky", "79969 Laron Mountains", null, "17207" },
                    { 6, "East Ayden", "Vanuatu", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(1052), false, "South Carolina", "4816 Maddison Rest", null, "39191-3132" },
                    { 7, "Meaganberg", "Turkey", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(1245), false, "Washington", "14677 Rosa Burgs", null, "46618-0490" },
                    { 8, "Nikkoburgh", "Bosnia and Herzegovina", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(1464), false, "Louisiana", "39831 Kassulke Rue", null, "44724-3990" },
                    { 9, "New Anastacioshire", "Christmas Island", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(1627), false, "Arkansas", "089 Cormier Underpass", null, "82493" },
                    { 10, "Lindgrenshire", "Algeria", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(1791), false, "Georgia", "539 Lueilwitz Wall", null, "33928-0834" },
                    { 11, "Lake Hassietown", "Malta", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(1938), false, "Idaho", "030 Trey Walks", null, "10846-0924" },
                    { 12, "New Saigeburgh", "Turkey", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(2094), false, "Ohio", "232 Hunter Way", null, "31341" },
                    { 13, "East Hailieville", "Mongolia", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(2237), false, "Vermont", "8528 Taylor Forges", null, "30618" },
                    { 14, "Wisozkburgh", "Tonga", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(2388), false, "Michigan", "19032 Kub Meadows", null, "56031-9351" },
                    { 15, "West Marian", "Aruba", new DateTime(2024, 12, 9, 11, 54, 24, 342, DateTimeKind.Utc).AddTicks(2527), false, "Washington", "930 Mueller Valley", null, "00450" }
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
                    { 1, 0, "a36c1909-c05c-4250-9f66-5293644748e1", "admin@admin.com", true, false, null, "Admin User", null, "FAKE_ADMIN", null, "123-456-7890", false, "64be447e-dfde-426c-891b-dee1178efe8b", false, "fake_admin" },
                    { 2, 0, "1bf44308-7099-4bbe-96ab-ec8824f9202d", "Ruby.Becker32@hotmail.com", true, false, null, "Laverna Kohler", null, null, null, "(253) 566-6346 x5328", false, "f2837ea6-2fe5-4470-8584-cad5334f8c4a", false, "Maryse_Hodkiewicz43" },
                    { 3, 0, "df651aeb-5f5e-4d01-86a1-908e9e627087", "Kimberly.Nolan91@hotmail.com", true, false, null, "Judge Franecki", null, null, null, "373.913.2696 x626", false, "ca75ac3b-8c7e-4c93-822e-de9a5992ec00", false, "Gage.Hand" },
                    { 4, 0, "16161495-d012-47ed-a880-726151a16e74", "Joe4@yahoo.com", true, false, null, "Francisco Hodkiewicz", null, null, null, "938.800.7772", false, "8c3bdfc6-31d0-44c8-97c0-bc36fc71180c", false, "Julie.Reichel93" },
                    { 5, 0, "89679f97-3db7-4e69-8c19-4aa87278f03f", "Assunta.Kuhlman80@hotmail.com", true, false, null, "Mitchel Bahringer", null, null, null, "961.701.1780", false, "e86dc9c6-5050-4c16-ae4c-71ea96e7acec", false, "Monroe_Pacocha" },
                    { 6, 0, "4bc91c19-1866-4e56-a0fc-f3d24508d46d", "Lennie_Adams@yahoo.com", true, false, null, "Charles Ebert", null, null, null, "1-308-456-8438 x6820", false, "92759244-26f6-4bc4-a064-815809129401", false, "Jedediah_Corkery" },
                    { 7, 0, "e70bb79f-8cb4-44f6-b320-7e961c41d100", "Taylor92@gmail.com", true, false, null, "Neva McClure", null, null, null, "617.709.9745 x783", false, "64f241df-13ed-48f3-b0a2-e1c76e59aa23", false, "Maurice_Cassin" },
                    { 8, 0, "13045834-a7a1-44e0-8da7-13aad6219895", "Gwendolyn.Ortiz54@yahoo.com", true, false, null, "Gideon Frami", null, null, null, "1-578-813-0838 x6254", false, "3797b4ee-54d7-4bdb-80f8-5f953df8d976", false, "Claire_Williamson70" },
                    { 9, 0, "5e42255d-3828-4d5e-bfab-15e18e482901", "Marley39@yahoo.com", true, false, null, "Colleen Cartwright", null, null, null, "1-471-756-3587", false, "91870525-7015-4592-b941-dad0812468f2", false, "Daisha73" },
                    { 10, 0, "8d34b07a-d4f7-4579-978a-e4acfbff2ec8", "Yasmin_Denesik3@gmail.com", true, false, null, "Vernie Yundt", null, null, null, "(435) 688-1640", false, "03c0d665-8bb0-4022-b0fe-7bf7334bcdd1", false, "Bernhard_Crooks" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Et et rem qui. Quos et voluptates reiciendis eum eum. Nam error autem pariatur quibusdam ab.", new DateTime(2024, 12, 9, 11, 54, 24, 328, DateTimeKind.Utc).AddTicks(9188), false, "Bernardo Cartwright", null },
                    { 2, "Consequuntur ullam et rerum sit et voluptatem saepe accusamus quos. Numquam ipsam omnis. Reiciendis ullam facilis sit voluptas. Inventore porro dolores non voluptatem aut quos.", new DateTime(2024, 12, 9, 11, 54, 24, 328, DateTimeKind.Utc).AddTicks(9688), false, "Monroe Doyle", null },
                    { 3, "Illum quia odit est pariatur ut consequatur quod nihil quos. Molestias consequatur sequi suscipit nihil maiores deserunt dicta est minima. Ducimus unde odit eaque.", new DateTime(2024, 12, 9, 11, 54, 24, 328, DateTimeKind.Utc).AddTicks(9852), false, "Jaqueline Gerhold", null },
                    { 4, "Rerum id quaerat placeat in beatae corporis consequatur dolor tempore. Ut totam non quidem illum velit consequatur debitis. Placeat aperiam pariatur. Nesciunt maxime enim quod.", new DateTime(2024, 12, 9, 11, 54, 24, 328, DateTimeKind.Utc).AddTicks(9962), false, "Carlotta Hirthe", null },
                    { 5, "Nihil voluptatem corrupti vero. Ipsum et iure rerum neque et. Laborum laboriosam explicabo quae veniam expedita doloremque consequatur. Est eligendi doloremque enim.", new DateTime(2024, 12, 9, 11, 54, 24, 329, DateTimeKind.Utc).AddTicks(122), false, "Rosie Goodwin", null },
                    { 6, "Provident veritatis commodi consequatur delectus repudiandae et eos commodi sed. Odit illum excepturi repellendus ea sed ipsam. Cupiditate et sit quisquam rerum voluptas reiciendis aut.", new DateTime(2024, 12, 9, 11, 54, 24, 329, DateTimeKind.Utc).AddTicks(219), false, "Eve Pollich", null },
                    { 7, "Officiis perspiciatis est vero et tempore qui harum. Atque dicta sint quia veniam itaque. Est molestiae iure eligendi deleniti consequatur. At molestias dolor sint. Natus voluptatem exercitationem. Voluptatem magnam natus rem.", new DateTime(2024, 12, 9, 11, 54, 24, 329, DateTimeKind.Utc).AddTicks(385), false, "Zachery Gislason", null },
                    { 8, "Voluptatem voluptatem accusamus. Ut consequatur ab expedita voluptatum adipisci dolore qui sunt. Tempore perspiciatis non. Nulla et maiores eos aut. Exercitationem dolores voluptas et rem doloremque et hic quis dolore. Qui qui in eius est consectetur alias et hic.", new DateTime(2024, 12, 9, 11, 54, 24, 329, DateTimeKind.Utc).AddTicks(509), false, "Imani Veum", null },
                    { 9, "Maiores est accusantium maiores. Quo quisquam earum voluptatem eius quia. Unde sed atque commodi necessitatibus ut est et. Nobis asperiores quis doloremque. Explicabo quo ipsam ea maiores est aliquam perspiciatis.", new DateTime(2024, 12, 9, 11, 54, 24, 329, DateTimeKind.Utc).AddTicks(693), false, "Garrick Kovacek", null },
                    { 10, "Culpa voluptate consectetur magni eius et. Numquam et et et ad non qui veritatis. Assumenda alias exercitationem architecto consequuntur et quis et. Sequi nihil fugiat sit aliquid qui consectetur assumenda. Sit qui atque accusantium nemo.", new DateTime(2024, 12, 9, 11, 54, 24, 329, DateTimeKind.Utc).AddTicks(818), false, "Naomie Stamm", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Consectetur fugiat labore." },
                    { 2, "Mollitia quas eaque." },
                    { 3, "Sit aut enim." },
                    { 4, "Sint eveniet rem." },
                    { 5, "Tempora tenetur architecto." },
                    { 6, "Eum dolorum soluta." }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Culpa quia ipsam quo velit eius fugit nostrum minus optio. Corrupti nisi temporibus et alias omnis aperiam. Ipsum voluptate tempore velit dolorem deserunt natus optio sint eius. Unde quis facilis ipsum illo.", new DateTime(2024, 12, 9, 11, 54, 24, 331, DateTimeKind.Utc).AddTicks(2968), false, "DuBuque, Smith and Lubowitz", null },
                    { 2, "Consequuntur et enim amet dolore ut molestias quia. Nobis qui eos dolores rerum aliquid libero minima sunt. Distinctio et ea et facilis rerum commodi facilis eius. Maxime perferendis ab ea qui officiis quaerat qui. Sequi et expedita.", new DateTime(2024, 12, 9, 11, 54, 24, 331, DateTimeKind.Utc).AddTicks(3946), false, "Jones Inc", null },
                    { 3, "Ut sed alias laborum atque consequatur vel fugit aut asperiores. Voluptatum illum repellat qui atque provident possimus. Unde consequatur illo quis. Facilis nesciunt nam architecto.", new DateTime(2024, 12, 9, 11, 54, 24, 331, DateTimeKind.Utc).AddTicks(4358), false, "Grant - Farrell", null },
                    { 4, "Sit aut possimus doloribus tenetur. Est et consequatur ratione molestiae perspiciatis. Officia aut aspernatur. Saepe aliquam cupiditate commodi libero possimus dolores et odio velit.", new DateTime(2024, 12, 9, 11, 54, 24, 331, DateTimeKind.Utc).AddTicks(4566), false, "Becker, Herzog and Nader", null },
                    { 5, "Molestias ratione rem ducimus et praesentium libero quo quis. Ab repellendus est nostrum est. Eveniet at quia nisi adipisci sit repudiandae at pariatur quis. Occaecati iste quidem et qui occaecati. Odio cumque reprehenderit temporibus cum beatae. Debitis architecto quis molestiae architecto voluptatibus neque.", new DateTime(2024, 12, 9, 11, 54, 24, 331, DateTimeKind.Utc).AddTicks(4774), false, "Raynor, Sanford and Simonis", null }
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
                    { 1, 8, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(2869), "Voluptatum fugiat quaerat omnis id nostrum. Omnis quia blanditiis aut qui. Alias suscipit modi dolorem accusamus non excepturi aut facilis. Distinctio similique quos voluptates. Dolorem est ut ut ut delectus impedit.", 0, "https://picsum.photos/640/480/?image=974", false, null, 75.45m, 5, 1, "Dolores porro provident.", null },
                    { 2, 10, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(4772), "Possimus modi laborum dolore qui laboriosam suscipit aut perferendis. Quidem harum maxime soluta ut ut non aut in deserunt. Possimus omnis qui quia reiciendis. Dignissimos et eum eum consectetur. Praesentium dolore ipsum similique dolores totam non. Vel vero quod iusto eos vel accusamus.", 0, "https://picsum.photos/640/480/?image=1062", false, null, 24.24m, 2, 2, "Rem voluptatem qui.", null },
                    { 3, 4, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5011), "Qui quasi non corporis iure eveniet. Quia reprehenderit dolorem perferendis error. Distinctio hic incidunt neque quo.", 0, "https://picsum.photos/640/480/?image=396", false, null, 10.89m, 3, 2, "Ducimus repellendus aspernatur.", null },
                    { 4, 6, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5134), "Dolor est placeat qui et. Omnis magni voluptatibus ipsam consequatur voluptatem et eos consequatur nostrum. Voluptatem hic sed. Omnis et commodi hic quo. Inventore qui dolorem maiores neque voluptas.", 0, "https://picsum.photos/640/480/?image=295", false, null, 61.53m, 4, 4, "Vitae nam consequatur.", null },
                    { 5, 6, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5296), "Laudantium et et sunt ut ratione fugiat atque. Est inventore omnis esse. Sint doloribus magni iusto et et nam non. Id suscipit sit quia mollitia. Facere reprehenderit reiciendis fugit natus modi.", 0, "https://picsum.photos/640/480/?image=364", false, null, 52.54m, 2, 5, "Voluptatem asperiores voluptatum.", null },
                    { 6, 1, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5419), "Esse deleniti laudantium nemo unde sint et qui deleniti et. Alias id veritatis natus ad saepe saepe. Ad perferendis enim quasi fugiat in. Perspiciatis sequi rerum. Quam quis sunt eveniet deleniti iste adipisci molestiae atque.", 0, "https://picsum.photos/640/480/?image=396", false, null, 32.70m, 4, 3, "Facere explicabo dolore.", null },
                    { 7, 2, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5589), "Aut iusto recusandae dolore omnis atque et nisi nostrum. Beatae incidunt beatae voluptatem fuga. Rerum qui inventore incidunt alias. Et sunt quae possimus repudiandae consectetur excepturi. Aperiam ullam unde qui sapiente atque.", 0, "https://picsum.photos/640/480/?image=493", false, null, 52.21m, 6, 5, "Ad qui et.", null },
                    { 8, 9, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5733), "Ex nulla consequatur enim minus in nihil aut consequatur. Dolorem quia dolor omnis at qui velit quo quia vero. Nihil similique quasi et atque commodi dolor voluptates. Rerum autem ut debitis et incidunt perspiciatis quo. Consequatur asperiores commodi hic.", 0, "https://picsum.photos/640/480/?image=734", false, null, 31.75m, 2, 5, "Mollitia ut animi.", null },
                    { 9, 4, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(5973), "Voluptatem tempore nesciunt aut est facilis reiciendis voluptate. Voluptas eum quia velit beatae voluptatibus saepe. Quae qui unde beatae saepe quidem. Voluptatibus dolores et.", 0, "https://picsum.photos/640/480/?image=999", false, null, 39.67m, 6, 5, "Non sed consequuntur.", null },
                    { 10, 6, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6070), "Cumque optio deserunt ut et repudiandae. Autem dolores quasi quia error sequi eos. Enim quo tempore facere enim quia ad dolor quidem. Voluptatem quo consectetur molestias consequatur quibusdam eveniet. Eum eius at voluptate voluptas fugiat. Perspiciatis ut qui temporibus tempore ipsam non autem.", 0, "https://picsum.photos/640/480/?image=172", false, null, 43.00m, 6, 3, "Rerum deserunt error.", null },
                    { 11, 3, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6264), "Consequatur quis quas commodi ad ut. Vel et nulla ut nobis et. Impedit fugiat eius ipsa et sed. Sunt debitis laboriosam reiciendis praesentium. Asperiores aut explicabo tempore odit ut. Quam qui nam dolores.", 0, "https://picsum.photos/640/480/?image=285", false, null, 89.96m, 1, 5, "Ea itaque aspernatur.", null },
                    { 12, 8, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6416), "Maxime totam corrupti commodi voluptas incidunt sed voluptas. Laboriosam ratione et voluptatibus. Esse ipsum deserunt debitis. Voluptates consequatur molestias ea aliquam quas et quas saepe fugit. Deleniti consequuntur eaque provident cupiditate nesciunt repudiandae.", 0, "https://picsum.photos/640/480/?image=341", false, null, 53.44m, 6, 3, "Repellat non et.", null },
                    { 13, 4, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6560), "Deleniti nesciunt et. Iusto vel perspiciatis. Et aut error voluptas iure cumque perspiciatis est. Optio et ut dolorem architecto aliquid voluptas. Harum commodi voluptatem inventore voluptates omnis cum.", 0, "https://picsum.photos/640/480/?image=201", false, null, 87.46m, 1, 1, "Quia corporis fugit.", null },
                    { 14, 5, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6694), "Veniam molestiae doloribus et ratione modi eveniet. Sed placeat necessitatibus quos rerum. Quam alias repellendus. Aliquam et distinctio iste et. Facilis autem quia ut enim dicta qui.", 0, "https://picsum.photos/640/480/?image=553", false, null, 31.15m, 5, 5, "Debitis aut a.", null },
                    { 15, 2, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6799), "Quod sapiente quo pariatur illo praesentium amet dicta sit ipsam. Qui ut quo voluptatem aliquid provident necessitatibus. Modi voluptas unde fugit.", 0, "https://picsum.photos/640/480/?image=488", false, null, 90.80m, 2, 2, "Et occaecati pariatur.", null },
                    { 16, 5, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(6942), "Aliquam omnis autem voluptates perspiciatis pariatur ab consequatur. Nesciunt ratione cumque aut vero provident enim non. Ea voluptates nulla amet quibusdam vel.", 0, "https://picsum.photos/640/480/?image=709", false, null, 33.04m, 6, 2, "Distinctio eius quo.", null },
                    { 17, 9, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(7024), "Nihil repellat id quisquam atque voluptatibus accusamus minima. Consectetur iusto et odit expedita. Culpa officiis aperiam sequi odit et ut dolorem at sit.", 0, "https://picsum.photos/640/480/?image=460", false, null, 56.80m, 5, 2, "Laborum aliquid in.", null },
                    { 18, 8, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(7177), "Perspiciatis sequi qui aliquam velit aut deleniti consequatur. Est veniam magni incidunt odit. Et reiciendis laboriosam sed tenetur harum et non maiores quibusdam. Ut harum modi neque natus in dicta libero pariatur blanditiis.", 0, "https://picsum.photos/640/480/?image=580", false, null, 23.71m, 4, 1, "Soluta quam repellendus.", null },
                    { 19, 4, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(7310), "Numquam et et distinctio provident. Quia molestias aut molestiae. Et doloribus suscipit harum animi cum iusto ducimus.", 0, "https://picsum.photos/640/480/?image=285", false, null, 35.11m, 1, 2, "Amet blanditiis sit.", null },
                    { 20, 5, new DateTime(2024, 12, 9, 11, 54, 24, 335, DateTimeKind.Utc).AddTicks(7427), "Enim enim modi quasi facere sit. Animi aut qui quia explicabo. Molestiae ut ab qui eligendi necessitatibus ab. Consequatur optio alias rerum cumque quos quaerat sit. Voluptatem soluta sed id.", 0, "https://picsum.photos/640/480/?image=882", false, null, 30.46m, 1, 5, "Esse aut sed.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7734), false, null, 2 },
                    { 3, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7736), false, null, 3 },
                    { 4, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7736), false, null, 4 },
                    { 5, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7737), false, null, 5 },
                    { 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7737), false, null, 6 },
                    { 7, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7737), false, null, 7 },
                    { 8, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7738), false, null, 8 },
                    { 9, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7738), false, null, 9 },
                    { 10, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7738), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 12, 9, 11, 54, 24, 343, DateTimeKind.Utc).AddTicks(9957), "Gwen.Batz@gmail.com", "Gwen Batz", false, 13, 0m, null, 6 },
                    { 2, 14, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(3484), "Kelli.Balistreri@hotmail.com", "Kelli Balistreri", false, 13, 0m, null, 4 },
                    { 3, 14, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(5112), "Grady_Reichert@yahoo.com", "Grady Reichert", false, 13, 0m, null, 7 },
                    { 4, 5, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(5981), "Harriet_OKon@yahoo.com", "Harriet O'Kon", false, 15, 0m, null, 3 },
                    { 5, 1, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(7299), "Rufus23@yahoo.com", "Rufus Moore", false, 15, 0m, null, 9 },
                    { 6, 5, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(8195), "Jo.Bartoletti49@hotmail.com", "Jo Bartoletti", false, 9, 0m, null, 6 },
                    { 7, 4, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(8976), "Santos36@yahoo.com", "Santos Fisher", false, 4, 0m, null, 3 },
                    { 8, 5, new DateTime(2024, 12, 9, 11, 54, 24, 344, DateTimeKind.Utc).AddTicks(9910), "Lucy82@hotmail.com", "Lucy Kulas", false, 8, 0m, null, 4 },
                    { 9, 14, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(644), "Nick_Sanford@hotmail.com", "Nick Sanford", false, 13, 0m, null, 6 },
                    { 10, 2, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(1284), "Becky.OConnell@yahoo.com", "Becky O'Connell", false, 13, 0m, null, 10 },
                    { 11, 4, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(4696), "Cecelia44@yahoo.com", "Cecelia Steuber", false, 14, 0m, null, 8 },
                    { 12, 2, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(5503), "Maurice.Koelpin48@yahoo.com", "Maurice Koelpin", false, 12, 0m, null, 5 },
                    { 13, 14, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(6294), "Terrance11@gmail.com", "Terrance Ortiz", false, 8, 0m, null, 5 },
                    { 14, 11, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(7025), "Wm46@gmail.com", "Wm Kutch", false, 14, 0m, null, 3 },
                    { 15, 11, new DateTime(2024, 12, 9, 11, 54, 24, 345, DateTimeKind.Utc).AddTicks(7650), "Lena.Wiza57@yahoo.com", "Lena Wiza", false, 5, 0m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(5431), false, 9, 23.67m, 3, null },
                    { 2, 20, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(6863), false, 14, 18.02m, 3, null },
                    { 3, 9, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(6922), false, 14, 65.05m, 1, null },
                    { 4, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(6935), false, 4, 84.30m, 1, null },
                    { 5, 20, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(6946), false, 10, 62.18m, 1, null },
                    { 6, 1, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7023), false, 8, 37.35m, 3, null },
                    { 7, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7033), false, 12, 27.85m, 3, null },
                    { 8, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7042), false, 11, 26.92m, 1, null },
                    { 9, 7, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7050), false, 7, 58.19m, 3, null },
                    { 10, 4, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7059), false, 13, 61.14m, 2, null },
                    { 11, 3, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7067), false, 10, 17.43m, 1, null },
                    { 12, 20, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7076), false, 2, 24.40m, 2, null },
                    { 13, 8, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7085), false, 4, 90.62m, 1, null },
                    { 14, 19, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7094), false, 9, 95.74m, 3, null },
                    { 15, 4, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7101), false, 4, 53.44m, 3, null },
                    { 16, 5, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7110), false, 4, 45.07m, 1, null },
                    { 17, 1, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7119), false, 3, 33.84m, 3, null },
                    { 18, 15, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7127), false, 14, 88.69m, 2, null },
                    { 19, 4, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7135), false, 10, 82.61m, 3, null },
                    { 20, 5, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7143), false, 3, 79.03m, 3, null },
                    { 21, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7151), false, 1, 73.70m, 2, null },
                    { 22, 18, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7160), false, 7, 21.31m, 3, null },
                    { 23, 10, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7169), false, 4, 36.64m, 3, null },
                    { 24, 2, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7177), false, 3, 10.18m, 1, null },
                    { 25, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7186), false, 10, 48.65m, 1, null },
                    { 26, 20, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7194), false, 11, 17.49m, 2, null },
                    { 27, 5, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7203), false, 13, 89.86m, 3, null },
                    { 28, 4, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7212), false, 2, 82.03m, 1, null },
                    { 29, 3, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7221), false, 14, 53.90m, 1, null },
                    { 30, 11, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7229), false, 4, 38.34m, 3, null },
                    { 31, 15, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7238), false, 10, 49.43m, 2, null },
                    { 32, 8, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7246), false, 14, 53.16m, 3, null },
                    { 33, 9, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7254), false, 14, 75.00m, 3, null },
                    { 34, 20, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7262), false, 12, 68.23m, 2, null },
                    { 35, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7271), false, 11, 57.25m, 2, null },
                    { 36, 7, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7279), false, 5, 15.30m, 3, null },
                    { 37, 16, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7288), false, 15, 40.42m, 1, null },
                    { 38, 19, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7361), false, 11, 41.05m, 3, null },
                    { 39, 6, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7369), false, 11, 93.47m, 2, null },
                    { 40, 5, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7378), false, 14, 55.64m, 3, null },
                    { 41, 7, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7386), false, 11, 41.20m, 3, null },
                    { 42, 19, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7395), false, 8, 45.74m, 1, null },
                    { 43, 18, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7403), false, 2, 87.58m, 2, null },
                    { 44, 17, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7412), false, 4, 73.31m, 3, null },
                    { 45, 18, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7420), false, 2, 41.95m, 2, null },
                    { 46, 5, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7429), false, 10, 69.75m, 1, null },
                    { 47, 12, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7438), false, 11, 35.20m, 1, null },
                    { 48, 15, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7446), false, 9, 22.54m, 1, null },
                    { 49, 11, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7455), false, 11, 90.99m, 3, null },
                    { 50, 1, new DateTime(2024, 12, 9, 11, 54, 24, 348, DateTimeKind.Utc).AddTicks(7464), false, 3, 60.48m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 10, "Debitis velit tempore aut amet qui a distinctio.", new DateTime(2024, 12, 9, 11, 54, 24, 337, DateTimeKind.Utc).AddTicks(7756), false, 3, null, 9 },
                    { 2, 13, "Error aut nobis aut officia consequatur rerum sapiente.", new DateTime(2024, 12, 9, 11, 54, 24, 337, DateTimeKind.Utc).AddTicks(9792), false, 1, null, 4 },
                    { 3, 11, "A et velit.", new DateTime(2024, 12, 9, 11, 54, 24, 337, DateTimeKind.Utc).AddTicks(9936), false, 3, null, 10 },
                    { 4, 9, "Cumque dolor nihil beatae dolorem recusandae ducimus.", new DateTime(2024, 12, 9, 11, 54, 24, 337, DateTimeKind.Utc).AddTicks(9959), false, 1, null, 7 },
                    { 5, 5, "Libero dicta dolorum.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(3), false, 5, null, 9 },
                    { 6, 1, "Consectetur excepturi sed odit aut quia eius ut vitae.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(147), false, 5, null, 8 },
                    { 7, 12, "Suscipit consequuntur sunt neque sed cum quod.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(191), false, 5, null, 7 },
                    { 8, 3, "Non consequatur rerum consequatur facere molestias iusto dolor.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(225), false, 4, null, 9 },
                    { 9, 14, "Eveniet sit minima debitis et sunt et mollitia.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(261), false, 3, null, 9 },
                    { 10, 6, "Atque itaque dolores porro ex rem eum.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(293), false, 3, null, 7 },
                    { 11, 8, "Error nostrum voluptatem voluptatem.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(326), false, 2, null, 2 },
                    { 12, 14, "Corrupti saepe maxime minima voluptate sit.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(350), false, 3, null, 4 },
                    { 13, 6, "Vel quas consequatur possimus nesciunt ab dolores.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(375), false, 2, null, 4 },
                    { 14, 14, "Quos officia repudiandae ut nihil ratione.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(435), false, 5, null, 5 },
                    { 15, 17, "Rem accusamus tempora debitis.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(462), false, 4, null, 8 },
                    { 16, 19, "Qui reprehenderit libero illum molestias.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(483), false, 5, null, 6 },
                    { 17, 13, "Eaque blanditiis ut.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(511), false, 4, null, 9 },
                    { 18, 11, "Fuga accusamus ipsum libero.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(536), false, 3, null, 8 },
                    { 19, 10, "Est et ad qui est dicta officiis qui quis.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(556), false, 2, null, 3 },
                    { 20, 8, "Quia omnis assumenda necessitatibus qui ut commodi voluptas veniam.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(596), false, 5, null, 9 },
                    { 21, 17, "Nihil tempora dolor praesentium architecto corporis omnis atque aut.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(630), false, 1, null, 5 },
                    { 22, 8, "Maiores rerum non voluptatem soluta magnam consectetur.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(699), false, 2, null, 10 },
                    { 23, 12, "Sit unde asperiores sequi est occaecati ullam ratione voluptas.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(735), false, 4, null, 2 },
                    { 24, 13, "In sit doloremque sunt aperiam quos optio facilis.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(789), false, 3, null, 8 },
                    { 25, 16, "Repellendus maiores minima.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(843), false, 4, null, 10 },
                    { 26, 18, "Vel sed fugiat eaque pariatur sit.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(861), false, 1, null, 10 },
                    { 27, 14, "Et aperiam facilis est consectetur est aut et fuga ad.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(894), false, 4, null, 8 },
                    { 28, 7, "Delectus aut animi.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(923), false, 3, null, 3 },
                    { 29, 17, "Velit qui molestias libero aut quis.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(939), false, 4, null, 9 },
                    { 30, 13, "Nobis hic ut qui in.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(993), false, 1, null, 5 },
                    { 31, 14, "Qui ut et repellat similique autem magni vitae et ea.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1017), false, 3, null, 2 },
                    { 32, 16, "Aliquam aut impedit amet officiis et.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1054), false, 3, null, 3 },
                    { 33, 7, "Molestiae dignissimos voluptates.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1076), false, 4, null, 5 },
                    { 34, 13, "Vel aut consectetur recusandae fugiat sed optio.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1094), false, 1, null, 6 },
                    { 35, 1, "Beatae cupiditate molestiae voluptas fugiat voluptatem deserunt voluptatibus rerum.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1116), false, 2, null, 3 },
                    { 36, 12, "Et sapiente excepturi magnam laborum sed non omnis vitae.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1150), false, 4, null, 10 },
                    { 37, 18, "Et dolore ipsum aspernatur.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1206), false, 5, null, 3 },
                    { 38, 1, "Nulla culpa voluptas.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1229), false, 3, null, 10 },
                    { 39, 15, "Aut est voluptate qui id sunt aut numquam inventore.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1249), false, 3, null, 3 },
                    { 40, 1, "Velit earum accusamus unde.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1281), false, 2, null, 6 },
                    { 41, 6, "Amet voluptatem aut blanditiis corrupti voluptatibus adipisci non nulla quasi.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1299), false, 1, null, 8 },
                    { 42, 18, "Fugit similique dolores aliquam est necessitatibus.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1328), false, 2, null, 9 },
                    { 43, 4, "Sed ea rerum quis quaerat consequatur et quia accusamus quos.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1348), false, 2, null, 9 },
                    { 44, 12, "Ullam nam est ducimus iste fugiat.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1377), false, 3, null, 9 },
                    { 45, 19, "Blanditiis quas temporibus id a earum dolores.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1437), false, 3, null, 9 },
                    { 46, 4, "Ab et dolor sit eos quaerat laborum ipsam ut ratione.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1466), false, 2, null, 9 },
                    { 47, 13, "Velit est unde nulla tenetur rem quia.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1503), false, 3, null, 6 },
                    { 48, 12, "Occaecati est qui autem quibusdam vel nihil et.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1528), false, 2, null, 10 },
                    { 49, 6, "Quas est aut placeat ipsum delectus eligendi.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1556), false, 1, null, 6 },
                    { 50, 14, "Eos placeat magni voluptates recusandae autem non enim unde.", new DateTime(2024, 12, 9, 11, 54, 24, 338, DateTimeKind.Utc).AddTicks(1581), false, 4, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 17, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1087), false, null, 3 },
                    { 2, 3, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1298), false, null, 2 },
                    { 3, 4, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1305), false, null, 10 },
                    { 4, 11, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1309), false, null, 6 },
                    { 5, 12, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1313), false, null, 10 },
                    { 6, 16, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1317), false, null, 9 },
                    { 7, 4, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1320), false, null, 10 },
                    { 8, 8, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1324), false, null, 6 },
                    { 9, 8, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1328), false, null, 10 },
                    { 10, 12, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1331), false, null, 9 },
                    { 11, 13, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1335), false, null, 6 },
                    { 12, 13, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1338), false, null, 4 },
                    { 13, 13, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1342), false, null, 6 },
                    { 14, 6, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1345), false, null, 10 },
                    { 15, 10, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1349), false, null, 10 },
                    { 16, 5, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1352), false, null, 3 },
                    { 17, 10, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1356), false, null, 8 },
                    { 18, 15, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1359), false, null, 9 },
                    { 19, 1, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1363), false, null, 10 },
                    { 20, 11, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1366), false, null, 3 },
                    { 21, 7, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1370), false, null, 6 },
                    { 22, 11, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1373), false, null, 8 },
                    { 23, 14, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1377), false, null, 9 },
                    { 24, 4, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1380), false, null, 3 },
                    { 25, 9, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1384), false, null, 3 },
                    { 26, 8, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1387), false, null, 3 },
                    { 27, 20, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1391), false, null, 6 },
                    { 28, 9, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1395), false, null, 4 },
                    { 29, 14, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1398), false, null, 7 },
                    { 30, 4, new DateTime(2024, 12, 9, 11, 54, 24, 340, DateTimeKind.Utc).AddTicks(1402), false, null, 2 }
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
