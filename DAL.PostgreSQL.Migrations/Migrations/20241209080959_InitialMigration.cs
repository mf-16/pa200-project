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
                    { 1, "North Magnolia", "Iraq", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(4167), false, "Wyoming", "262 Farrell Trace", null, "09555-9119" },
                    { 2, "Lake Michelletown", "Ethiopia", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(4881), false, "South Dakota", "3020 Senger Shore", null, "60261" },
                    { 3, "West Polly", "Equatorial Guinea", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5047), false, "Pennsylvania", "56486 Schmitt Trail", null, "61078-9731" },
                    { 4, "Camillaside", "Cyprus", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5187), false, "Montana", "48858 Darron Divide", null, "19308" },
                    { 5, "South Nola", "Congo", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5329), false, "Tennessee", "136 Yasmeen Park", null, "86133" },
                    { 6, "Port Johann", "Mali", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5457), false, "New Hampshire", "97929 Hansen Squares", null, "18281-5976" },
                    { 7, "West Maudie", "Montserrat", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5581), false, "Virginia", "832 Samantha Curve", null, "62112-3654" },
                    { 8, "West Ivoryport", "Swaziland", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5756), false, "Illinois", "81008 Moen Walks", null, "81986-8797" },
                    { 9, "New Orlandborough", "Congo", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(5901), false, "Maine", "058 Zemlak Street", null, "35054" },
                    { 10, "McKenzieberg", "Swaziland", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(6035), false, "Arizona", "45200 Archibald Court", null, "34064" },
                    { 11, "Colemanside", "Sudan", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(6159), false, "Oklahoma", "534 Schowalter Passage", null, "64300-1112" },
                    { 12, "New Zolachester", "Mali", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(6287), false, "Kentucky", "046 Emanuel Shoals", null, "95365" },
                    { 13, "Framiborough", "Hungary", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(6418), false, "Nebraska", "36664 Velma Pike", null, "62391-0301" },
                    { 14, "Electabury", "Norway", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(6540), false, "Ohio", "69027 Conroy Tunnel", null, "17447" },
                    { 15, "Crystalville", "Montenegro", new DateTime(2024, 12, 9, 8, 9, 58, 751, DateTimeKind.Utc).AddTicks(6654), false, "Mississippi", "5854 Luettgen Run", null, "96588" }
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
                    { 1, 0, "3c8b564b-6ad0-4053-ad2c-d53b507ca95e", "admin@admin.com", true, false, null, "Admin User", null, "FAKE_ADMIN", null, "123-456-7890", false, "6cece8eb-26c0-4192-bb62-6e86dc24cacc", false, "fake_admin" },
                    { 2, 0, "2142aacc-c0c7-47dd-88dc-809662cf3cba", "Seamus_Swaniawski12@gmail.com", true, false, null, "Jaron Strosin", null, null, null, "(838) 550-4289", false, "98e9cda6-4f6b-4a93-aec3-b7bc7b584280", false, "Teagan_OKeefe71" },
                    { 3, 0, "4a64cf5d-91aa-4536-9694-bbf985f7578d", "Agustina.Hirthe47@hotmail.com", true, false, null, "Alfred Schowalter", null, null, null, "952-779-3637 x10842", false, "6f4735f8-0c49-4103-a5d6-b94ef4f47a8e", false, "Winston14" },
                    { 4, 0, "5c8ec081-4a27-40e1-9a23-54902a114e73", "Garth97@hotmail.com", true, false, null, "Otho Lakin", null, null, null, "714-234-4353 x07216", false, "ac76689b-50fb-4cf8-adf8-50384078c31e", false, "Joshua.Herman" },
                    { 5, 0, "29e90a9e-d7cf-4a37-95c0-fa8d8baa3679", "Elaina.Mitchell@hotmail.com", true, false, null, "Jerad Koch", null, null, null, "630.964.5968 x52952", false, "c8adf002-a6fb-4fbc-be0e-acba5e495c19", false, "Marta.White" },
                    { 6, 0, "0388083c-940e-454f-be95-f1c787355ae9", "Valentine.Waelchi@yahoo.com", true, false, null, "Howard Borer", null, null, null, "1-215-303-1482", false, "ff030939-b022-4c36-9a79-ff570c9ad48e", false, "Kenny_Wilderman" },
                    { 7, 0, "0756063a-5f5b-4df3-b4d9-339e3d83cb0f", "Grady98@gmail.com", true, false, null, "Shyanne Heidenreich", null, null, null, "509-644-0640", false, "47ce5150-8c21-4281-bf56-add9643e1063", false, "Ashtyn.Kovacek70" },
                    { 8, 0, "6a420422-7396-45b8-a465-1c272aaaa130", "Emily19@hotmail.com", true, false, null, "Gladyce Kertzmann", null, null, null, "463-458-1491 x571", false, "c3437c55-7285-4f46-b3b9-5e1eb2c6710a", false, "Eusebio_Kuphal69" },
                    { 9, 0, "5a0e5ab6-61a0-418b-b01a-9230cf048955", "Juwan.Corwin38@gmail.com", true, false, null, "Patience Sanford", null, null, null, "546.354.8235", false, "8df1e375-58b3-487b-ab49-f46bd4b503df", false, "Clemmie41" },
                    { 10, 0, "6f08772e-a861-47e0-b13b-4011e676b26a", "Addie9@hotmail.com", true, false, null, "Cecil Casper", null, null, null, "(454) 343-1150 x00748", false, "c6765093-7c5c-4fec-804a-30b27670b3f4", false, "Martine27" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Id necessitatibus numquam. Iste fugiat ex molestias assumenda qui eum ea eveniet voluptatum. Sequi iste sint necessitatibus.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(715), false, "Hardy Jacobi", null },
                    { 2, "Unde rerum explicabo porro qui voluptatum nihil sequi ab sint. Sit qui ipsa ut libero. Nihil aut placeat voluptas dolorem itaque itaque. Porro quis iste omnis.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1025), false, "Earnest Smith", null },
                    { 3, "Impedit porro debitis occaecati fugit. Temporibus qui temporibus qui aut. Ex dolore aliquam inventore recusandae. Incidunt consequatur nisi doloremque voluptas eligendi dolores ducimus reprehenderit. Possimus aliquid architecto magni fugiat repellendus. Eaque consequatur ipsum id illum.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1161), false, "Keeley Streich", null },
                    { 4, "Incidunt ex et deleniti tenetur alias. Perspiciatis facilis eaque sed atque quia a temporibus sint dolores. Error necessitatibus itaque nostrum ut qui dolore iure iure quos.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1295), false, "Jude Lakin", null },
                    { 5, "Illo quaerat eligendi eum rem eligendi ad pariatur nemo. Et autem rerum. Eaque nostrum voluptatum velit incidunt non. Dolorem nihil ut. Magni qui qui occaecati libero quasi.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1408), false, "Ericka Krajcik", null },
                    { 6, "Recusandae ut incidunt. Repellat sint dolorem consequatur pariatur voluptate ut rerum. Voluptate mollitia dolorum accusamus praesentium.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1500), false, "Adrianna Langosh", null },
                    { 7, "Nulla similique dolores voluptatum minus velit tenetur nobis. Aut praesentium aspernatur inventore deserunt magnam vero non. Occaecati aspernatur voluptates nemo tenetur alias facilis cumque tempora. Nulla et possimus quae voluptas saepe natus.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1585), false, "Frida Kulas", null },
                    { 8, "Voluptas molestias repellendus voluptatem ipsum incidunt. Natus dolor nemo sit expedita aut. Doloremque nulla quisquam et et omnis et et. Illum architecto ea facere debitis perferendis occaecati ullam omnis rerum. Sit ullam dolor temporibus soluta. Eligendi aut aut sunt est.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1679), false, "Edgar Orn", null },
                    { 9, "Doloremque beatae quia odio eligendi repellat et vel. Alias et itaque quo. Nam itaque sint exercitationem nihil voluptas nobis dolor qui.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1821), false, "Jamey Schmitt", null },
                    { 10, "Perferendis perferendis nihil sed vitae in iusto. Dolor itaque tempore voluptas ipsam in quia doloribus libero. Laudantium sint dolores. Et id amet ut et et id. Minus iusto consequatur assumenda harum soluta placeat autem possimus.", new DateTime(2024, 12, 9, 8, 9, 58, 742, DateTimeKind.Utc).AddTicks(1886), false, "Tillman Gibson", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Necessitatibus possimus aliquam." },
                    { 2, "Harum soluta tenetur." },
                    { 3, "Aspernatur praesentium quaerat." },
                    { 4, "Autem laudantium perferendis." },
                    { 5, "Debitis sit possimus." },
                    { 6, "Voluptatibus amet non." }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Sit temporibus ipsum fugiat quam minima ipsam repellat et. Quas distinctio assumenda repellat voluptatibus aut earum rerum ullam. Amet veniam perferendis. Pariatur harum nemo sed. Unde fugiat deleniti mollitia corrupti consequatur reiciendis dolore atque.", new DateTime(2024, 12, 9, 8, 9, 58, 743, DateTimeKind.Utc).AddTicks(4299), false, "Kertzmann Inc", null },
                    { 2, "Rem qui vel corrupti architecto. Ea est nesciunt esse aspernatur molestiae. Veritatis quibusdam praesentium quaerat voluptates qui perferendis accusantium voluptatem. Voluptatem ipsa quo autem nihil cupiditate voluptates sit reiciendis quia. Dicta non illum vero natus veritatis aut.", new DateTime(2024, 12, 9, 8, 9, 58, 743, DateTimeKind.Utc).AddTicks(5009), false, "Kirlin - Armstrong", null },
                    { 3, "Sit deleniti et quia eaque esse inventore iure autem. Accusamus nihil dolor corrupti culpa. Qui neque dolores similique molestias reprehenderit qui nesciunt distinctio aut. Natus ducimus quis dignissimos quia aspernatur neque odit quam quia. Labore aut provident eos.", new DateTime(2024, 12, 9, 8, 9, 58, 743, DateTimeKind.Utc).AddTicks(5242), false, "Okuneva Group", null },
                    { 4, "Et vel aliquid reprehenderit asperiores quasi. Beatae laudantium id placeat sequi. Aut quae rerum assumenda. Soluta esse similique sequi totam quidem.", new DateTime(2024, 12, 9, 8, 9, 58, 743, DateTimeKind.Utc).AddTicks(5454), false, "Kuvalis, Bradtke and O'Reilly", null },
                    { 5, "Laborum quae dolorum totam est est totam. Beatae aut aperiam velit voluptates numquam rerum. Molestiae omnis aperiam et non perspiciatis non minus aut. Perspiciatis voluptatibus eum.", new DateTime(2024, 12, 9, 8, 9, 58, 743, DateTimeKind.Utc).AddTicks(5658), false, "Harvey, Rath and Murphy", null }
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
                    { 1, 1, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(4952), "Quasi iste facere maiores eaque qui. Eveniet rem cupiditate sunt omnis explicabo. Inventore possimus sunt est. Delectus libero temporibus ipsam eos facilis. Tenetur voluptatibus quos voluptates officiis necessitatibus in architecto vel fuga.", 0, "https://picsum.photos/640/480/?image=249", false, null, 97.98m, 3, 5, "Ducimus expedita eos.", null },
                    { 2, 7, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(6922), "Ea totam earum autem sapiente. Reprehenderit harum doloremque dolorum sequi voluptatem libero. Qui debitis omnis quae corrupti saepe eos labore voluptas. Vitae rerum voluptate tempore debitis aut. Consequuntur voluptate aspernatur ipsa delectus dolores eos. A optio non.", 0, "https://picsum.photos/640/480/?image=360", false, null, 76.75m, 6, 1, "Laborum ullam voluptatem.", null },
                    { 3, 1, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(7149), "Aliquid sint quam aperiam quod eum sunt eaque. Consequatur eum assumenda totam nulla. Cupiditate nihil nemo cum quisquam quae dolore quidem et. Blanditiis dolorem quidem nihil in. Ut error pariatur laboriosam laboriosam libero ipsam asperiores consequatur. Qui culpa totam enim vel voluptatibus voluptatum.", 0, "https://picsum.photos/640/480/?image=576", false, null, 13.78m, 5, 1, "Officia voluptatum voluptates.", null },
                    { 4, 8, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(7322), "Corporis temporibus consequatur repudiandae animi sapiente excepturi facilis. Dicta aut quidem ut illum dolores rerum quis sequi. Eaque consequatur officia recusandae. Officia quo autem amet. Facere iusto tempore molestiae numquam.", 0, "https://picsum.photos/640/480/?image=981", false, null, 90.92m, 3, 2, "Aut expedita enim.", null },
                    { 5, 4, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(7428), "Provident beatae id quia omnis in non neque. Nostrum sunt autem iste necessitatibus adipisci voluptatem dolores libero. Veniam et animi quod repellat. Unde quis ut sunt similique voluptas nihil laudantium qui. Recusandae repellat ducimus laboriosam ipsa ut a repellat officiis laborum. Voluptatem tenetur ea voluptatibus.", 0, "https://picsum.photos/640/480/?image=938", false, null, 34.18m, 6, 3, "Vel qui minus.", null },
                    { 6, 9, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(7589), "Vero rerum ducimus nemo doloribus aut. Ut sed at ipsum excepturi aliquid harum omnis. Non harum nulla sequi laudantium. Sint sit unde illo impedit dolor repellat. Repellendus quod dolor sed maxime voluptatem non esse repellendus. Sapiente corrupti nulla qui esse fugiat sit.", 0, "https://picsum.photos/640/480/?image=545", false, null, 46.64m, 2, 3, "Aliquam ad vel.", null },
                    { 7, 8, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(7744), "Ad id nesciunt explicabo dolorum tenetur aut dolorem culpa. Nobis repellat ipsam occaecati vel eos odio assumenda est. Quia veritatis et quisquam. Nesciunt rerum incidunt. Non debitis suscipit. Nulla animi tenetur aut ipsam expedita veniam dolores.", 0, "https://picsum.photos/640/480/?image=475", false, null, 46.02m, 6, 4, "Sed voluptate soluta.", null },
                    { 8, 9, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(7878), "Nihil minus autem. Qui voluptatem voluptas reprehenderit placeat consequatur. Qui aut et eos voluptas ut. Harum in magni. Officia explicabo non. Et repellendus qui et quae suscipit.", 0, "https://picsum.photos/640/480/?image=222", false, null, 52.56m, 6, 5, "Facilis eveniet iusto.", null },
                    { 9, 5, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8002), "Nihil alias dolor quisquam reprehenderit assumenda odit quis modi occaecati. Repellendus et exercitationem deserunt quo vero. Neque blanditiis culpa vel.", 0, "https://picsum.photos/640/480/?image=266", false, null, 39.28m, 6, 4, "Quaerat optio facilis.", null },
                    { 10, 8, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8072), "Aut optio voluptatum fugit. Accusamus ut dolorum quam consequuntur. Molestiae voluptate iusto asperiores debitis voluptas corporis doloremque.", 0, "https://picsum.photos/640/480/?image=79", false, null, 28.60m, 6, 1, "Quis aut omnis.", null },
                    { 11, 5, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8211), "Veniam harum suscipit. Labore laboriosam sed nam exercitationem omnis. Maiores qui sed neque voluptatum magnam. Veniam aliquam deleniti reiciendis est autem inventore. Et aperiam nostrum ad laudantium aliquid cum incidunt.", 0, "https://picsum.photos/640/480/?image=592", false, null, 52.06m, 1, 1, "Et totam odio.", null },
                    { 12, 6, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8300), "Impedit consequuntur consequuntur dolorem. Voluptate voluptatem quia excepturi sapiente consequatur est. Quia quis quae quibusdam excepturi sapiente. Aspernatur sunt eos sit est omnis ut vel fugit.", 0, "https://picsum.photos/640/480/?image=115", false, null, 47.34m, 1, 1, "Quod suscipit illum.", null },
                    { 13, 7, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8474), "Dolore ullam suscipit eos aliquam non et. Sequi nulla eos enim saepe vero delectus quia facilis. In ut non ipsam sit officia quia occaecati quis est. Nemo nobis deserunt voluptatem placeat facere.", 0, "https://picsum.photos/640/480/?image=113", false, null, 65.77m, 4, 1, "Vel quia fuga.", null },
                    { 14, 8, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8600), "Sint eos ea et cumque ut aut repellat. Est ut voluptatem excepturi asperiores voluptatem possimus et minima. Perferendis est itaque optio magni natus. Asperiores dolor aspernatur quos assumenda voluptate minus perspiciatis. Dignissimos quis perferendis ipsam et magni voluptas.", 0, "https://picsum.photos/640/480/?image=410", false, null, 55.08m, 1, 3, "Voluptate ut impedit.", null },
                    { 15, 10, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8722), "Quia perspiciatis corporis non velit accusamus. Fugiat corrupti ab aut voluptate aut beatae voluptatem. Qui voluptatem debitis sit hic autem tempore. Ab voluptatem repellendus maiores quibusdam consequuntur beatae.", 0, "https://picsum.photos/640/480/?image=664", false, null, 86.03m, 3, 1, "Est ut rerum.", null },
                    { 16, 8, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8805), "Nihil accusantium deserunt nihil voluptas. Dolores ducimus placeat quis. Illum eligendi cum autem ducimus dolore consequatur iusto repellendus. Optio voluptates quasi animi atque officia hic vitae enim praesentium. Est quis quae voluptatem sunt. Voluptate maxime asperiores.", 0, "https://picsum.photos/640/480/?image=1052", false, null, 43.81m, 5, 2, "Dolorum aut nihil.", null },
                    { 17, 9, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(8997), "Excepturi maxime quod vel eum necessitatibus maiores quaerat in est. Nostrum magnam qui similique sed placeat similique est asperiores est. Aut sit perspiciatis explicabo.", 0, "https://picsum.photos/640/480/?image=121", false, null, 38.35m, 6, 5, "Temporibus animi et.", null },
                    { 18, 9, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(9135), "Nobis doloribus quis consectetur exercitationem reiciendis voluptas ad. Qui odit iusto maxime omnis expedita. Cupiditate recusandae sit sed est numquam. Ut dicta culpa sint maxime cum.", 0, "https://picsum.photos/640/480/?image=825", false, null, 99.76m, 4, 2, "Et minima sequi.", null },
                    { 19, 2, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(9211), "Aut fuga eum natus eos aliquam. Est vel quia non. Magni laborum nemo saepe eum et cumque quasi.", 0, "https://picsum.photos/640/480/?image=86", false, null, 63.79m, 4, 5, "Dolorum aut iusto.", null },
                    { 20, 7, new DateTime(2024, 12, 9, 8, 9, 58, 746, DateTimeKind.Utc).AddTicks(9300), "Corporis veritatis ipsum facere ipsum consequatur nostrum. Voluptas animi molestias. Hic quod saepe in eos harum dolorum excepturi quam consequatur. Et optio voluptas sed similique consectetur sapiente culpa. Beatae beatae est dolores incidunt est nostrum nostrum et nostrum. Dicta nisi officia.", 0, "https://picsum.photos/640/480/?image=997", false, null, 72.35m, 6, 5, "Nobis quo molestiae.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9580), false, null, 2 },
                    { 3, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9581), false, null, 3 },
                    { 4, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9582), false, null, 4 },
                    { 5, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9582), false, null, 5 },
                    { 6, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9582), false, null, 6 },
                    { 7, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9583), false, null, 7 },
                    { 8, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9583), false, null, 8 },
                    { 9, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9583), false, null, 9 },
                    { 10, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9583), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(371), "Abraham.Mraz@yahoo.com", "Abraham Mraz", false, 15, 0m, null, 9 },
                    { 2, 5, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(3104), "Terri_Kuhic@hotmail.com", "Terri Kuhic", false, 6, 0m, null, 7 },
                    { 3, 5, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(4223), "Claudia.Nienow56@hotmail.com", "Claudia Nienow", false, 4, 0m, null, 6 },
                    { 4, 4, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(4819), "Rosalie.Osinski46@gmail.com", "Rosalie Osinski", false, 10, 0m, null, 5 },
                    { 5, 8, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(5330), "Jan37@yahoo.com", "Jan Kautzer", false, 5, 0m, null, 9 },
                    { 6, 4, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(5947), "Taylor_Pacocha19@hotmail.com", "Taylor Pacocha", false, 10, 0m, null, 6 },
                    { 7, 15, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(6486), "Naomi.Nienow31@yahoo.com", "Naomi Nienow", false, 5, 0m, null, 10 },
                    { 8, 11, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(6958), "Pauline39@yahoo.com", "Pauline Dicki", false, 1, 0m, null, 8 },
                    { 9, 1, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(7507), "Phil74@gmail.com", "Phil Harris", false, 8, 0m, null, 5 },
                    { 10, 15, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(7980), "Darren75@gmail.com", "Darren Bernhard", false, 9, 0m, null, 2 },
                    { 11, 3, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(8674), "Margaret.Pouros11@hotmail.com", "Margaret Pouros", false, 4, 0m, null, 2 },
                    { 12, 9, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(9323), "Clifton85@gmail.com", "Clifton Okuneva", false, 5, 0m, null, 8 },
                    { 13, 9, new DateTime(2024, 12, 9, 8, 9, 58, 753, DateTimeKind.Utc).AddTicks(9868), "Guadalupe.Legros@yahoo.com", "Guadalupe Legros", false, 3, 0m, null, 4 },
                    { 14, 13, new DateTime(2024, 12, 9, 8, 9, 58, 754, DateTimeKind.Utc).AddTicks(345), "Aubrey85@hotmail.com", "Aubrey Trantow", false, 8, 0m, null, 10 },
                    { 15, 8, new DateTime(2024, 12, 9, 8, 9, 58, 754, DateTimeKind.Utc).AddTicks(870), "Kerry.Bosco@gmail.com", "Kerry Bosco", false, 8, 0m, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(6996), false, 9, 22.37m, 3, null },
                    { 2, 5, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8880), false, 10, 10.94m, 2, null },
                    { 3, 4, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8933), false, 4, 49.91m, 2, null },
                    { 4, 14, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8944), false, 3, 84.69m, 2, null },
                    { 5, 16, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8955), false, 4, 55.78m, 2, null },
                    { 6, 8, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8962), false, 14, 71.39m, 2, null },
                    { 7, 6, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8970), false, 2, 77.32m, 1, null },
                    { 8, 15, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8977), false, 3, 98.04m, 3, null },
                    { 9, 9, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8985), false, 2, 43.57m, 2, null },
                    { 10, 5, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(8993), false, 1, 43.82m, 1, null },
                    { 11, 17, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9000), false, 12, 14.92m, 2, null },
                    { 12, 18, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9007), false, 7, 49.70m, 3, null },
                    { 13, 12, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9014), false, 5, 64.94m, 2, null },
                    { 14, 5, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9022), false, 8, 97.45m, 2, null },
                    { 15, 6, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9029), false, 8, 88.23m, 1, null },
                    { 16, 15, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9036), false, 13, 84.19m, 3, null },
                    { 17, 14, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9043), false, 14, 76.11m, 2, null },
                    { 18, 12, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9050), false, 1, 56.08m, 2, null },
                    { 19, 10, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9058), false, 8, 98.14m, 3, null },
                    { 20, 17, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9065), false, 11, 46.09m, 3, null },
                    { 21, 12, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9135), false, 15, 82.07m, 3, null },
                    { 22, 19, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9145), false, 14, 75.09m, 2, null },
                    { 23, 11, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9153), false, 14, 59.37m, 1, null },
                    { 24, 19, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9160), false, 7, 84.33m, 1, null },
                    { 25, 2, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9167), false, 9, 42.54m, 1, null },
                    { 26, 3, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9175), false, 5, 53.03m, 1, null },
                    { 27, 17, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9182), false, 11, 52.32m, 1, null },
                    { 28, 13, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9190), false, 3, 65.75m, 1, null },
                    { 29, 13, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9197), false, 9, 23.40m, 3, null },
                    { 30, 10, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9205), false, 14, 91.83m, 3, null },
                    { 31, 11, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9211), false, 12, 13.67m, 3, null },
                    { 32, 16, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9219), false, 4, 10.18m, 3, null },
                    { 33, 20, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9226), false, 4, 88.85m, 2, null },
                    { 34, 18, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9234), false, 4, 84.74m, 2, null },
                    { 35, 18, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9241), false, 13, 36.04m, 1, null },
                    { 36, 18, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9248), false, 14, 19.40m, 2, null },
                    { 37, 14, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9255), false, 6, 31.41m, 1, null },
                    { 38, 8, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9263), false, 1, 83.98m, 1, null },
                    { 39, 20, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9270), false, 1, 68.57m, 1, null },
                    { 40, 3, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9277), false, 15, 15.74m, 3, null },
                    { 41, 2, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9285), false, 7, 79.77m, 2, null },
                    { 42, 16, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9292), false, 10, 29.01m, 2, null },
                    { 43, 5, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9299), false, 11, 37.97m, 3, null },
                    { 44, 12, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9306), false, 13, 64.14m, 3, null },
                    { 45, 6, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9314), false, 9, 80.62m, 2, null },
                    { 46, 20, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9321), false, 15, 41.18m, 3, null },
                    { 47, 4, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9328), false, 5, 29.02m, 2, null },
                    { 48, 19, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9335), false, 10, 32.29m, 2, null },
                    { 49, 8, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9342), false, 9, 63.63m, 2, null },
                    { 50, 1, new DateTime(2024, 12, 9, 8, 9, 58, 755, DateTimeKind.Utc).AddTicks(9349), false, 8, 27.52m, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 2, "Dolor quae neque corporis eius facilis ea optio ipsum natus.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(4084), false, 5, null, 3 },
                    { 2, 15, "Distinctio et asperiores magni.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(5752), false, 4, null, 9 },
                    { 3, 13, "Dolor magni ea minus.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(5832), false, 3, null, 8 },
                    { 4, 2, "Qui nesciunt velit temporibus reprehenderit iure eum tenetur dolorum ab.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(5853), false, 2, null, 2 },
                    { 5, 14, "Nesciunt est temporibus voluptatem laudantium optio fugiat dolore voluptas.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(5889), false, 5, null, 8 },
                    { 6, 6, "Sit labore et modi saepe animi ut blanditiis.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(5959), false, 1, null, 10 },
                    { 7, 10, "Provident earum voluptatum quidem incidunt.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(5985), false, 5, null, 5 },
                    { 8, 14, "Mollitia rerum voluptas ut minima id suscipit voluptas vitae.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6004), false, 4, null, 2 },
                    { 9, 3, "Corporis ut quia in sed.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6029), false, 1, null, 4 },
                    { 10, 15, "Voluptate ut est ex molestiae.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6045), false, 1, null, 3 },
                    { 11, 6, "Neque accusantium quos error sunt nostrum.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6065), false, 5, null, 4 },
                    { 12, 4, "Magni repudiandae sunt quae veritatis non.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6083), false, 5, null, 3 },
                    { 13, 13, "Rerum ipsa qui nulla molestias nostrum alias.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6100), false, 4, null, 9 },
                    { 14, 6, "Voluptates dignissimos aut exercitationem voluptatem cum quam quas.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6153), false, 4, null, 4 },
                    { 15, 18, "Non id tempora voluptatem iste dolorem eos.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6178), false, 4, null, 5 },
                    { 16, 14, "Explicabo praesentium totam dolores fugit aut eligendi temporibus.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6203), false, 4, null, 7 },
                    { 17, 2, "Ex rerum ab culpa.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6224), false, 5, null, 6 },
                    { 18, 15, "Dignissimos dignissimos et corrupti dignissimos amet sint.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6243), false, 5, null, 2 },
                    { 19, 2, "Maxime deserunt voluptatem iste itaque.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6264), false, 2, null, 2 },
                    { 20, 8, "Est voluptates odio placeat.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6281), false, 2, null, 3 },
                    { 21, 18, "Ut nam sed aut harum nobis velit et quas.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6296), false, 2, null, 3 },
                    { 22, 3, "Odit laboriosam est quaerat vitae eligendi.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6350), false, 4, null, 9 },
                    { 23, 6, "Occaecati quis repellendus saepe accusantium et.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6371), false, 2, null, 4 },
                    { 24, 10, "Incidunt ex cupiditate magnam et autem incidunt qui.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6392), false, 4, null, 3 },
                    { 25, 6, "Voluptatum libero nisi omnis quo fuga id distinctio quia.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6416), false, 2, null, 6 },
                    { 26, 15, "Dolorem ullam cumque commodi minima nihil non.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6439), false, 5, null, 8 },
                    { 27, 9, "Impedit fuga error optio ducimus est commodi.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6462), false, 4, null, 5 },
                    { 28, 13, "Voluptas itaque modi.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6481), false, 2, null, 2 },
                    { 29, 7, "Unde facilis corporis laborum et.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6493), false, 1, null, 5 },
                    { 30, 1, "Deleniti repudiandae labore enim molestias omnis qui neque.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6539), false, 4, null, 6 },
                    { 31, 20, "Sunt consequatur ipsam repellendus et est eaque sed.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6562), false, 5, null, 9 },
                    { 32, 19, "Ut aspernatur suscipit ducimus voluptas debitis quis dolor repudiandae.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6582), false, 4, null, 2 },
                    { 33, 1, "Rerum ad nisi odit repudiandae ab fugiat dolorem.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6605), false, 1, null, 4 },
                    { 34, 10, "Quae labore qui et unde nihil.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6625), false, 4, null, 10 },
                    { 35, 19, "Non et inventore est molestiae laboriosam et aliquam fuga id.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6643), false, 2, null, 8 },
                    { 36, 11, "Ut velit veniam atque aut voluptatibus quis at quod.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6667), false, 5, null, 9 },
                    { 37, 9, "Hic a itaque sed.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6710), false, 3, null, 5 },
                    { 38, 5, "Et perspiciatis sequi ducimus non modi quos incidunt sit consectetur.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6726), false, 1, null, 9 },
                    { 39, 16, "Qui esse incidunt.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6748), false, 2, null, 4 },
                    { 40, 13, "Dolorum ut at excepturi.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6760), false, 3, null, 9 },
                    { 41, 20, "Vitae eum quod fugiat unde ut at et rerum.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6774), false, 4, null, 4 },
                    { 42, 13, "Eveniet rem incidunt totam sit aut exercitationem aliquam quis.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6797), false, 5, null, 6 },
                    { 43, 4, "Nemo ut et est explicabo vel sed.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6820), false, 3, null, 6 },
                    { 44, 7, "Commodi voluptatem excepturi ex sapiente quisquam.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6839), false, 1, null, 2 },
                    { 45, 10, "Eum voluptatibus eveniet blanditiis commodi.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6940), false, 2, null, 5 },
                    { 46, 15, "Nemo nam perferendis sint hic occaecati aperiam ut.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6958), false, 4, null, 8 },
                    { 47, 7, "Non distinctio repellendus neque laborum esse.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(6989), false, 4, null, 9 },
                    { 48, 4, "Officiis sint aut cupiditate.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(7007), false, 3, null, 6 },
                    { 49, 17, "Sit magnam nihil.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(7021), false, 2, null, 8 },
                    { 50, 8, "Enim dolor sit sed.", new DateTime(2024, 12, 9, 8, 9, 58, 748, DateTimeKind.Utc).AddTicks(7035), false, 5, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1530), false, null, 10 },
                    { 2, 7, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1698), false, null, 3 },
                    { 3, 6, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1739), false, null, 9 },
                    { 4, 2, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1743), false, null, 7 },
                    { 5, 1, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1746), false, null, 10 },
                    { 6, 11, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1749), false, null, 10 },
                    { 7, 2, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1752), false, null, 3 },
                    { 8, 16, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1755), false, null, 10 },
                    { 9, 19, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1758), false, null, 7 },
                    { 10, 11, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1761), false, null, 9 },
                    { 11, 4, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1764), false, null, 6 },
                    { 12, 8, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1767), false, null, 2 },
                    { 13, 3, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1770), false, null, 9 },
                    { 14, 18, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1773), false, null, 6 },
                    { 15, 10, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1776), false, null, 9 },
                    { 16, 15, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1779), false, null, 5 },
                    { 17, 15, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1782), false, null, 4 },
                    { 18, 5, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1786), false, null, 2 },
                    { 19, 4, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1789), false, null, 2 },
                    { 20, 7, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1792), false, null, 10 },
                    { 21, 5, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1795), false, null, 2 },
                    { 22, 12, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1798), false, null, 7 },
                    { 23, 15, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1801), false, null, 10 },
                    { 24, 15, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1804), false, null, 8 },
                    { 25, 11, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1806), false, null, 7 },
                    { 26, 20, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1810), false, null, 6 },
                    { 27, 1, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1813), false, null, 9 },
                    { 28, 15, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1816), false, null, 9 },
                    { 29, 7, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1819), false, null, 7 },
                    { 30, 3, new DateTime(2024, 12, 9, 8, 9, 58, 750, DateTimeKind.Utc).AddTicks(1822), false, null, 4 }
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
