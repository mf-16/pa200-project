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
                    { 1, "Ankundinghaven", "Tuvalu", new DateTime(2024, 12, 11, 21, 23, 10, 19, DateTimeKind.Utc).AddTicks(8789), false, "Arizona", "61180 Stoltenberg Village", null, "77457" },
                    { 2, "Samarafort", "Niue", new DateTime(2024, 12, 11, 21, 23, 10, 19, DateTimeKind.Utc).AddTicks(9512), false, "Florida", "241 Ignatius Loaf", null, "30326" },
                    { 3, "New Luisview", "Netherlands", new DateTime(2024, 12, 11, 21, 23, 10, 19, DateTimeKind.Utc).AddTicks(9680), false, "South Dakota", "05620 Claire Rapid", null, "98086-8475" },
                    { 4, "Lednerbury", "Macao", new DateTime(2024, 12, 11, 21, 23, 10, 19, DateTimeKind.Utc).AddTicks(9835), false, "Minnesota", "5758 Kohler Brook", null, "73499-9693" },
                    { 5, "Nolanhaven", "French Southern Territories", new DateTime(2024, 12, 11, 21, 23, 10, 19, DateTimeKind.Utc).AddTicks(9978), false, "Ohio", "5003 Muller Land", null, "15046-4546" },
                    { 6, "Feeneytown", "Jersey", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(103), false, "Connecticut", "7433 Bailey Mews", null, "81727-4257" },
                    { 7, "South Kacie", "Puerto Rico", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(235), false, "Minnesota", "71986 Doyle Forks", null, "83038" },
                    { 8, "Port Othafort", "Germany", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(366), false, "Rhode Island", "62771 Reanna Fords", null, "99280" },
                    { 9, "Port Crawford", "Democratic People's Republic of Korea", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(502), false, "Alaska", "130 Heller Flats", null, "06102-6524" },
                    { 10, "South Othohaven", "Antarctica (the territory South of 60 deg S)", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(616), false, "Vermont", "827 Salvatore Vista", null, "39001" },
                    { 11, "South Minnieview", "Macao", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(862), false, "Oregon", "134 Antoinette Spring", null, "17855" },
                    { 12, "Donnellhaven", "Gibraltar", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(1008), false, "Kentucky", "4578 Aletha Ranch", null, "84505" },
                    { 13, "Eleanoraville", "Albania", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(1137), false, "Mississippi", "5958 Russel Turnpike", null, "26581" },
                    { 14, "Kaylinstad", "Brazil", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(1283), false, "Ohio", "306 Ron Ramp", null, "38734" },
                    { 15, "Schinnerview", "Bermuda", new DateTime(2024, 12, 11, 21, 23, 10, 20, DateTimeKind.Utc).AddTicks(1410), false, "Alabama", "699 Steuber Views", null, "11020-9576" }
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
                    { 1, 0, "e9b447d2-9e8a-44f4-80f8-14af2b2e8842", "admin@admin.com", true, false, null, "Admin User", null, null, null, "123-456-7890", false, "94ddc470-fef6-4f66-be37-d9c347b3a64f", false, "admin@admin.com" },
                    { 2, 0, "463955d5-16bd-40c1-8752-53c079c66ab0", "Pedro_Cormier@yahoo.com", true, false, null, "Rubye Beahan", null, null, null, "580-429-7747 x9652", false, "fb4fd27a-4938-48ec-8662-baa1525da6bf", false, "Pedro_Cormier@yahoo.com" },
                    { 3, 0, "7ac9f3e3-8890-4028-ad36-fc3487e3471a", "Danny45@yahoo.com", true, false, null, "Dakota Labadie", null, null, null, "(541) 410-2233", false, "03ecdf23-0757-4a40-a6db-6356f2a2a9c4", false, "Danny45@yahoo.com" },
                    { 4, 0, "60dd0db5-2afe-4681-8364-5353864da10b", "Yazmin46@gmail.com", true, false, null, "Shad Olson", null, null, null, "713.789.4728", false, "50161bbe-dab9-42ff-97f5-502d6864606e", false, "Yazmin46@gmail.com" },
                    { 5, 0, "44785fbc-0582-44a3-a3b6-3ec35f6fbbc9", "Maximillian99@gmail.com", true, false, null, "Mckenna Deckow", null, null, null, "1-579-918-4544", false, "3f5afec1-07f4-45e5-92e4-d5af545e3c03", false, "Maximillian99@gmail.com" },
                    { 6, 0, "06f0b3a0-72ba-4538-9a61-1549de6fa42d", "Hardy.Stokes11@yahoo.com", true, false, null, "Ivory Lubowitz", null, null, null, "(234) 991-0259", false, "dd0968db-ce23-451e-aded-37a0579da65f", false, "Hardy.Stokes11@yahoo.com" },
                    { 7, 0, "9f638214-d9ad-4b0e-a10f-524334094f8c", "Elton93@gmail.com", true, false, null, "Kelvin Gleason", null, null, null, "1-376-700-8356 x5102", false, "7c3ad21c-dff8-421e-97c7-a013dde30d3d", false, "Elton93@gmail.com" },
                    { 8, 0, "afc64c07-f7eb-45be-9c61-5ff8e2001dd5", "Lorna49@gmail.com", true, false, null, "Maximus Schmitt", null, null, null, "572.950.1862", false, "0d313d69-0263-4225-9bc4-d6bbd4e49412", false, "Lorna49@gmail.com" },
                    { 9, 0, "5a02e4e6-3023-4721-a6d0-e26440252c5e", "Garett_Zulauf@gmail.com", true, false, null, "Daphnee Jenkins", null, null, null, "1-317-759-8928 x525", false, "4971fd0a-786f-4386-9f9b-3857485b8c94", false, "Garett_Zulauf@gmail.com" },
                    { 10, 0, "09faf3bf-ce0c-43ff-a996-ca6e74530633", "Kianna.Muller44@gmail.com", true, false, null, "Susana Armstrong", null, null, null, "804.276.8095", false, "ec6f4c0f-940b-49fe-85a0-54cf76ddae8d", false, "Kianna.Muller44@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Labore commodi itaque ut. Dolores temporibus voluptates. Et error libero doloremque autem et. Voluptatum quo natus ut nobis.", new DateTime(2024, 12, 11, 21, 23, 10, 12, DateTimeKind.Utc).AddTicks(8863), false, "Brody Crist", null },
                    { 2, "Id quam est distinctio dolor aspernatur quia quia iure. Necessitatibus illum consequatur cum doloremque quasi excepturi. Voluptatem rerum ut est dolorem ipsum in rerum aspernatur. Ex eum autem magnam sit architecto accusantium. Eius soluta voluptatum illo. Ducimus sunt sapiente non.", new DateTime(2024, 12, 11, 21, 23, 10, 12, DateTimeKind.Utc).AddTicks(9272), false, "Frederique Dickens", null },
                    { 3, "Molestiae consequatur esse. Dolores amet maiores quia ullam quam quia ullam. Nostrum et corrupti ipsa aut doloremque totam. Cumque ipsa recusandae exercitationem ut inventore aut maiores odio voluptas.", new DateTime(2024, 12, 11, 21, 23, 10, 12, DateTimeKind.Utc).AddTicks(9514), false, "Deron Franecki", null },
                    { 4, "Eligendi ea nihil doloribus. Veritatis similique consequatur ducimus eum repudiandae nemo. At quos ea. Repellat praesentium dolor tenetur ut sunt dolor. Quaerat sit voluptate officia expedita aut.", new DateTime(2024, 12, 11, 21, 23, 10, 12, DateTimeKind.Utc).AddTicks(9636), false, "Darion Lueilwitz", null },
                    { 5, "Aut aliquam fuga dolorem. Doloribus animi qui aliquam. Qui non enim saepe. Officia aliquam voluptatem molestias odit sapiente. Adipisci eius eos cum et placeat aut nihil.", new DateTime(2024, 12, 11, 21, 23, 10, 12, DateTimeKind.Utc).AddTicks(9779), false, "Eunice Ritchie", null },
                    { 6, "Magnam commodi dicta suscipit et voluptates quod commodi cumque. Voluptatem voluptas ut. Voluptas earum consequuntur nisi accusantium voluptatem. Perferendis voluptate et esse. Et incidunt amet voluptatem eligendi placeat adipisci mollitia. Eius voluptatum quam animi animi sit.", new DateTime(2024, 12, 11, 21, 23, 10, 12, DateTimeKind.Utc).AddTicks(9878), false, "Consuelo Kohler", null },
                    { 7, "Nihil vel dolor quis porro. Sit aspernatur aut quam debitis nemo numquam voluptates necessitatibus dolor. Facilis sit perferendis atque cumque. Incidunt molestiae numquam corrupti. Enim ut omnis officia ipsa et hic sit aut.", new DateTime(2024, 12, 11, 21, 23, 10, 13, DateTimeKind.Utc).AddTicks(57), false, "Johanna Christiansen", null },
                    { 8, "Dicta voluptate molestiae sequi iusto et. Et quis ex voluptatem. Consequatur maiores totam minima veritatis. Autem aut repellat sequi. Distinctio ipsam accusantium maiores et quidem. Quidem quia magni itaque.", new DateTime(2024, 12, 11, 21, 23, 10, 13, DateTimeKind.Utc).AddTicks(198), false, "Lorenz Rowe", null },
                    { 9, "Est aperiam porro iusto et ut vel. Modi nihil repellendus perspiciatis quo asperiores. Exercitationem quo aliquam non laborum. Libero facilis at nihil cupiditate aut inventore quia reprehenderit. Nihil rem sapiente est dolor et reiciendis dolorem. Asperiores qui dolorem natus fugit odit ut maxime.", new DateTime(2024, 12, 11, 21, 23, 10, 13, DateTimeKind.Utc).AddTicks(294), false, "Otis Hermann", null },
                    { 10, "Suscipit eos natus quidem. Sed excepturi quia minus earum nam aut quibusdam. Aut maiores similique a omnis consequatur molestiae et est. Sint hic sapiente repellendus. Distinctio nemo cumque non qui aspernatur nihil natus.", new DateTime(2024, 12, 11, 21, 23, 10, 13, DateTimeKind.Utc).AddTicks(451), false, "Martina Kreiger", null }
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
                    { 1, "Asperiores delectus voluptas. Ut earum voluptas pariatur ut est maxime optio nisi perspiciatis. Eos perspiciatis numquam a quis.", new DateTime(2024, 12, 11, 21, 23, 10, 14, DateTimeKind.Utc).AddTicks(2905), false, "Kuphal, Bartoletti and Morissette", null },
                    { 2, "Illum repellendus similique delectus ea reprehenderit ex eos. Exercitationem consequuntur necessitatibus sed. Consectetur debitis ea. Quis eaque deserunt incidunt debitis. Quae repellendus qui consequatur quidem ex quasi.", new DateTime(2024, 12, 11, 21, 23, 10, 14, DateTimeKind.Utc).AddTicks(3617), false, "Hills, Franecki and Ferry", null },
                    { 3, "Ex perferendis ullam qui autem quos. Voluptatum assumenda facere. Expedita tempora incidunt iste. Eligendi modi deleniti est sed inventore autem molestias aut dolorem. Accusamus dolore aliquam totam atque qui.", new DateTime(2024, 12, 11, 21, 23, 10, 14, DateTimeKind.Utc).AddTicks(3809), false, "Robel, Witting and Cummings", null },
                    { 4, "Tempora qui ut quaerat voluptas assumenda. Voluptatem rerum velit et. Voluptates aut magni qui cumque molestias.", new DateTime(2024, 12, 11, 21, 23, 10, 14, DateTimeKind.Utc).AddTicks(4039), false, "Spencer - Conroy", null },
                    { 5, "Minima nihil rerum voluptas voluptatibus et. Quaerat sint quis suscipit pariatur molestiae dolorum ipsum aspernatur. Cum repudiandae quod ex tempora enim atque consequuntur.", new DateTime(2024, 12, 11, 21, 23, 10, 14, DateTimeKind.Utc).AddTicks(4151), false, "Lindgren, Boyle and Predovic", null }
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
                    { 1, 10, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(6680), "Sit enim doloribus. Harum corrupti temporibus soluta perspiciatis doloribus accusantium tempora nihil. Voluptate accusamus dolores qui quia id amet et. Dolorem voluptates quas culpa quisquam unde aut sunt dolor. Incidunt commodi voluptatibus eius.", 0, "/images/cover-7.jpg", false, null, 57.87m, 6, 2, "Ab et et.", null },
                    { 2, 7, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8276), "Natus officiis provident nulla sint provident et voluptatibus nihil earum. At reprehenderit officia eveniet fugit quia necessitatibus dolor. Et rem molestias consequatur aut omnis consequatur eum.", 0, "/images/cover-10.jpg", false, null, 26.83m, 6, 3, "Et omnis iusto.", null },
                    { 3, 9, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8431), "Officia impedit consequatur incidunt quasi eum laborum. Eius mollitia repellendus. Deleniti voluptatem voluptatem eum ex et beatae sed. Aut voluptatem quia ducimus. Aspernatur ipsam et id voluptatum omnis amet. Laborum vel earum.", 0, "/images/cover-10.jpg", false, null, 76.78m, 2, 3, "Et repellat velit.", null },
                    { 4, 6, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8528), "Libero quia animi. Beatae odio dolor ad ea qui. Ex accusantium quam excepturi. Nostrum id aliquam assumenda. Quia deserunt facere ut enim quia.", 0, "/images/cover-5.jpg", false, null, 74.18m, 3, 2, "Qui consequatur omnis.", null },
                    { 5, 3, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8638), "Veniam nisi vero cumque qui veritatis laborum laudantium. Consequuntur quasi quae dolorum necessitatibus nam repellat aut. Quasi rem rem repudiandae officia ex consectetur totam corrupti. Provident est ut doloremque nemo sit numquam iure non adipisci.", 0, "/images/cover-3.jpg", false, null, 61.15m, 2, 4, "Consectetur occaecati recusandae.", null },
                    { 6, 4, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8765), "Magnam voluptas nobis iusto harum ducimus vel. Itaque rerum illo voluptas. Nemo qui voluptas aut consequatur et omnis blanditiis laboriosam.", 0, "/images/cover-1.jpg", false, null, 49.18m, 7, 1, "Doloribus ad qui.", null },
                    { 7, 10, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8835), "Molestiae dolorem blanditiis est. Quas provident rerum ea. Ut ut libero et sequi ex ut. Maiores cumque perferendis blanditiis aut modi id.", 0, "/images/cover-5.jpg", false, null, 53.19m, 6, 4, "Delectus nisi repellendus.", null },
                    { 8, 3, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(8933), "Ut quis consequatur omnis velit repudiandae. Enim dignissimos unde architecto. Similique quo in quaerat aut et quidem debitis accusantium. Quibusdam odit est iusto molestiae.", 0, "/images/cover-4.jpg", false, null, 25.07m, 1, 1, "Provident sequi illum.", null },
                    { 9, 10, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9006), "Quae quis est. Ea et perferendis atque est quia sit blanditiis ipsam ratione. Velit sit assumenda maiores fugit. Dolores ea architecto.", 0, "/images/cover-7.jpg", false, null, 47.80m, 4, 5, "Laudantium ipsum explicabo.", null },
                    { 10, 7, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9111), "Eaque laboriosam libero non error quos sit repellat. Aut perferendis possimus pariatur ex sunt eum quae debitis dignissimos. Et natus tenetur sit quia ipsum. Ut vel aspernatur quod. Libero ut eos numquam quia occaecati saepe tempora reiciendis.", 0, "/images/cover-5.jpg", false, null, 21.94m, 1, 3, "Et commodi ratione.", null },
                    { 11, 1, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9219), "Magni non consequuntur et molestias. Dolores excepturi voluptate et quia pariatur. Qui omnis sed incidunt.", 0, "/images/cover-10.jpg", false, null, 98.14m, 3, 1, "Eaque eum debitis.", null },
                    { 12, 2, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9273), "Minima qui similique ratione deserunt et dolorum cum ducimus et. Nisi qui et nesciunt commodi hic. Voluptates numquam dolores non molestiae repellendus distinctio fuga neque qui. Occaecati voluptas consequatur illum debitis. Est praesentium dolores suscipit perferendis sint vel ut vitae.", 0, "/images/cover-10.jpg", false, null, 99.77m, 1, 1, "Eos quia ut.", null },
                    { 13, 9, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9439), "Hic aliquid optio dolorem aperiam. Incidunt architecto quia et. Facere distinctio adipisci maxime repellat at labore. Incidunt error ad nemo.", 0, "/images/cover-2.jpg", false, null, 59.03m, 5, 2, "Dolores dolores ad.", null },
                    { 14, 2, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9507), "Distinctio similique id minima velit quod. Similique odit earum quam minima ut voluptatem dicta doloribus. Aliquam cumque consequuntur voluptatem alias. Qui aliquam recusandae eligendi enim magnam et animi.", 0, "/images/cover-8.jpg", false, null, 27.40m, 7, 2, "Id ratione enim.", null },
                    { 15, 10, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9619), "Unde fuga consequatur aliquam ratione atque doloremque. Incidunt molestiae et dolor tempora. Atque earum occaecati dignissimos in molestiae corporis voluptas quia repellat.", 0, "/images/cover-6.jpg", false, null, 28.65m, 2, 4, "Omnis doloremque voluptas.", null },
                    { 16, 1, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9709), "Qui hic reiciendis maxime earum qui. Quam cupiditate voluptatem blanditiis ex totam aliquam aut. Ut laborum quia pariatur. Et omnis eum aut. Ratione delectus vero molestiae quas non molestias.", 0, "/images/cover-6.jpg", false, null, 47.67m, 5, 1, "Natus iusto nemo.", null },
                    { 17, 2, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9784), "Illo fuga odio quia magni delectus et provident fugiat repellendus. Sed voluptatum et quo. Est corporis quibusdam perferendis est deleniti reprehenderit. Porro ipsum ratione molestias sed aut minima eos architecto.", 0, "/images/cover-1.jpg", false, null, 95.49m, 3, 5, "Hic deserunt maxime.", null },
                    { 18, 10, new DateTime(2024, 12, 11, 21, 23, 10, 15, DateTimeKind.Utc).AddTicks(9890), "Ex molestiae eius adipisci molestiae est praesentium accusantium aut. Et nesciunt qui eveniet beatae. Nihil ipsum facilis voluptates quia cum quam repellat et qui. Sunt adipisci similique modi laboriosam tenetur. Accusantium cupiditate ea optio eveniet reprehenderit a. Eum fugiat esse iure sit nostrum dolor.", 0, "/images/cover-10.jpg", false, null, 82.56m, 1, 4, "Officiis corporis voluptatem.", null },
                    { 19, 10, new DateTime(2024, 12, 11, 21, 23, 10, 16, DateTimeKind.Utc).AddTicks(23), "Voluptatem sed id est veniam beatae molestiae reiciendis quibusdam distinctio. Et quia quos rerum. Voluptatibus soluta dolore suscipit facere magni. Ut beatae dolore ipsa sit expedita quod sunt alias non. Aut repellat dolorum ratione veniam non saepe nihil veritatis.", 0, "/images/cover-3.jpg", false, null, 29.96m, 2, 5, "Rerum itaque fugiat.", null },
                    { 20, 6, new DateTime(2024, 12, 11, 21, 23, 10, 16, DateTimeKind.Utc).AddTicks(146), "Odio vel quas maiores rerum qui. Quasi hic corrupti. Distinctio cumque laboriosam nisi qui dolorem eos voluptatem. Harum earum modi maiores ratione. Et ea placeat odio vel amet qui ullam iste.", 0, "/images/cover-3.jpg", false, null, 30.44m, 6, 2, "Voluptatem debitis autem.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3832), false, null, 2 },
                    { 3, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3835), false, null, 3 },
                    { 4, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3836), false, null, 4 },
                    { 5, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3836), false, null, 5 },
                    { 6, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3836), false, null, 6 },
                    { 7, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3836), false, null, 7 },
                    { 8, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3836), false, null, 8 },
                    { 9, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3837), false, null, 9 },
                    { 10, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3837), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "OrderState", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 15, new DateTime(2024, 12, 11, 21, 23, 10, 21, DateTimeKind.Utc).AddTicks(3741), "Colin.Marks92@hotmail.com", "Colin Marks", false, 4, 5, 0m, null, 9 },
                    { 2, 12, new DateTime(2024, 12, 11, 21, 23, 10, 21, DateTimeKind.Utc).AddTicks(7013), "Allan_Ziemann30@gmail.com", "Allan Ziemann", false, 2, 10, 0m, null, 8 },
                    { 3, 6, new DateTime(2024, 12, 11, 21, 23, 10, 21, DateTimeKind.Utc).AddTicks(8015), "Terrance99@yahoo.com", "Terrance Ebert", false, 2, 4, 0m, null, 9 },
                    { 4, 14, new DateTime(2024, 12, 11, 21, 23, 10, 21, DateTimeKind.Utc).AddTicks(8839), "Wilfred0@hotmail.com", "Wilfred Spencer", false, 2, 8, 0m, null, 2 },
                    { 5, 8, new DateTime(2024, 12, 11, 21, 23, 10, 21, DateTimeKind.Utc).AddTicks(9572), "Calvin_Davis@hotmail.com", "Calvin Davis", false, 3, 10, 0m, null, 2 },
                    { 6, 9, new DateTime(2024, 12, 11, 21, 23, 10, 22, DateTimeKind.Utc).AddTicks(197), "Lionel_OKeefe50@yahoo.com", "Lionel O'Keefe", false, 4, 9, 0m, null, 7 },
                    { 7, 15, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(3061), "Tim_Grady@yahoo.com", "Tim Grady", false, 2, 11, 0m, null, 10 },
                    { 8, 4, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(3927), "Irvin_Hayes78@gmail.com", "Irvin Hayes", false, 3, 5, 0m, null, 2 },
                    { 9, 14, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(4561), "Angelica96@yahoo.com", "Angelica Johnston", false, 1, 1, 0m, null, 9 },
                    { 10, 2, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(5255), "Dana84@yahoo.com", "Dana Watsica", false, 1, 9, 0m, null, 3 },
                    { 11, 12, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(5968), "Roberta.Hickle47@yahoo.com", "Roberta Hickle", false, 4, 12, 0m, null, 5 },
                    { 12, 4, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(6550), "Jenna.Murray10@hotmail.com", "Jenna Murray", false, 2, 9, 0m, null, 5 },
                    { 13, 8, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(7171), "Marc.Kovacek52@gmail.com", "Marc Kovacek", false, 0, 15, 0m, null, 6 },
                    { 14, 13, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(7809), "Emily_Gutkowski78@gmail.com", "Emily Gutkowski", false, 5, 11, 0m, null, 9 },
                    { 15, 8, new DateTime(2024, 12, 11, 21, 23, 10, 23, DateTimeKind.Utc).AddTicks(8373), "Cora88@gmail.com", "Cora Pouros", false, 4, 12, 0m, null, 9 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(2136), false, 8, 38.59m, 3, null },
                    { 2, 10, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3246), false, 14, 86.27m, 3, null },
                    { 3, 6, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3289), false, 13, 96.50m, 1, null },
                    { 4, 9, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3298), false, 7, 24.13m, 2, null },
                    { 5, 11, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3305), false, 13, 85.50m, 3, null },
                    { 6, 18, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3311), false, 12, 35.43m, 3, null },
                    { 7, 12, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3318), false, 6, 85.08m, 2, null },
                    { 8, 13, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3324), false, 10, 17.54m, 2, null },
                    { 9, 3, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3330), false, 13, 52.97m, 1, null },
                    { 10, 14, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3336), false, 13, 41.16m, 3, null },
                    { 11, 18, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3414), false, 5, 59.46m, 1, null },
                    { 12, 20, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3421), false, 13, 67.86m, 1, null },
                    { 13, 4, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3428), false, 12, 17.73m, 1, null },
                    { 14, 18, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3434), false, 3, 68.50m, 1, null },
                    { 15, 2, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3440), false, 9, 31.66m, 3, null },
                    { 16, 3, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3446), false, 13, 61.07m, 3, null },
                    { 17, 9, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3452), false, 3, 16.50m, 3, null },
                    { 18, 20, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3458), false, 1, 67.71m, 1, null },
                    { 19, 17, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3463), false, 12, 48.15m, 3, null },
                    { 20, 13, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3469), false, 14, 43.76m, 2, null },
                    { 21, 13, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3475), false, 6, 79.84m, 1, null },
                    { 22, 18, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3480), false, 3, 69.64m, 2, null },
                    { 23, 1, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3486), false, 13, 48.56m, 2, null },
                    { 24, 9, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3493), false, 8, 60.50m, 2, null },
                    { 25, 12, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3499), false, 2, 43.58m, 2, null },
                    { 26, 12, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3505), false, 13, 77.34m, 1, null },
                    { 27, 3, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3510), false, 10, 37.04m, 2, null },
                    { 28, 18, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3516), false, 3, 26.04m, 1, null },
                    { 29, 6, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3523), false, 6, 87.05m, 1, null },
                    { 30, 18, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3528), false, 5, 98.52m, 3, null },
                    { 31, 11, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3534), false, 4, 90.21m, 1, null },
                    { 32, 5, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3541), false, 9, 78.47m, 3, null },
                    { 33, 9, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3547), false, 2, 92.35m, 3, null },
                    { 34, 12, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3553), false, 14, 11.88m, 1, null },
                    { 35, 1, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3559), false, 13, 67.08m, 1, null },
                    { 36, 17, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3565), false, 15, 33.38m, 2, null },
                    { 37, 3, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3571), false, 12, 76.55m, 2, null },
                    { 38, 15, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3577), false, 12, 95.57m, 2, null },
                    { 39, 10, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3583), false, 9, 23.87m, 2, null },
                    { 40, 15, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3588), false, 4, 33.78m, 1, null },
                    { 41, 4, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3595), false, 10, 73.01m, 2, null },
                    { 42, 15, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3600), false, 8, 96.36m, 1, null },
                    { 43, 9, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3637), false, 13, 27.77m, 2, null },
                    { 44, 17, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3644), false, 5, 32.07m, 3, null },
                    { 45, 3, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3650), false, 15, 13.60m, 2, null },
                    { 46, 19, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3656), false, 14, 16.28m, 3, null },
                    { 47, 16, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3662), false, 5, 26.44m, 2, null },
                    { 48, 14, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3668), false, 6, 68.04m, 2, null },
                    { 49, 12, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3674), false, 4, 64.10m, 2, null },
                    { 50, 12, new DateTime(2024, 12, 11, 21, 23, 10, 25, DateTimeKind.Utc).AddTicks(3680), false, 11, 90.50m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 14, "Consequuntur molestias molestiae accusamus.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(2318), false, 3, null, 10 },
                    { 2, 20, "Magnam alias eius minima ipsum iusto.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3324), false, 1, null, 9 },
                    { 3, 17, "Saepe provident est occaecati.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3384), false, 4, null, 3 },
                    { 4, 1, "Culpa aut nobis quae illum quibusdam molestiae ex.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3450), false, 5, null, 4 },
                    { 5, 14, "Omnis omnis qui aperiam necessitatibus natus inventore est.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3474), false, 1, null, 4 },
                    { 6, 11, "Minima eum quia.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3493), false, 3, null, 7 },
                    { 7, 14, "Et fuga rem ullam neque ad ex voluptatem eum.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3505), false, 1, null, 2 },
                    { 8, 13, "Fugit cum quia possimus asperiores laudantium atque odio veniam.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3526), false, 2, null, 7 },
                    { 9, 16, "Aliquid mollitia aspernatur illo porro quae blanditiis nihil qui.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3548), false, 2, null, 2 },
                    { 10, 11, "Provident fugit repellendus debitis quia ratione ut nisi consectetur consequatur.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3568), false, 1, null, 3 },
                    { 11, 14, "Iure error voluptatum cumque perspiciatis molestiae qui.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3606), false, 3, null, 9 },
                    { 12, 2, "Possimus voluptas cumque sed facilis libero et ea.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3624), false, 3, null, 8 },
                    { 13, 10, "Ducimus earum placeat maxime.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3643), false, 2, null, 7 },
                    { 14, 10, "Voluptatum quo odit laboriosam non aliquid quia facere in blanditiis.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3656), false, 5, null, 7 },
                    { 15, 2, "Ratione assumenda molestias quia et.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3677), false, 3, null, 9 },
                    { 16, 19, "Dignissimos maiores rem mollitia iusto.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3692), false, 5, null, 4 },
                    { 17, 10, "Aut amet repellat non sed minus quo debitis rerum culpa.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3706), false, 5, null, 8 },
                    { 18, 4, "Architecto consequatur ratione minus corrupti ea voluptas.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3729), false, 5, null, 3 },
                    { 19, 10, "Et illo et illo id ad dolore cumque facere eos.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3820), false, 2, null, 6 },
                    { 20, 17, "Suscipit animi cum et necessitatibus sequi.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3842), false, 4, null, 8 },
                    { 21, 19, "Blanditiis qui aut.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3857), false, 2, null, 9 },
                    { 22, 19, "Ea architecto sed.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3868), false, 5, null, 2 },
                    { 23, 15, "Quasi architecto et.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3879), false, 1, null, 4 },
                    { 24, 10, "Error eveniet est vel sint.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3891), false, 3, null, 8 },
                    { 25, 15, "Molestiae voluptatibus aliquid eos numquam aliquid alias optio aut explicabo.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3905), false, 2, null, 7 },
                    { 26, 5, "Culpa aut placeat in sint omnis.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3926), false, 3, null, 10 },
                    { 27, 1, "Omnis quia laudantium laborum a illo harum itaque nesciunt mollitia.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(3985), false, 1, null, 9 },
                    { 28, 2, "Fugiat tempore vero sequi omnis perferendis eaque.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4007), false, 3, null, 3 },
                    { 29, 9, "Exercitationem dolore omnis quo ex.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4026), false, 5, null, 10 },
                    { 30, 1, "Ducimus dolores voluptatibus eos laborum sapiente consequatur sit.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4041), false, 5, null, 6 },
                    { 31, 13, "Est pariatur pariatur voluptatem ut.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4058), false, 5, null, 7 },
                    { 32, 6, "Sequi ut ipsa eius deserunt eos quia.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4073), false, 2, null, 5 },
                    { 33, 6, "Aliquam quas minus sapiente ducimus molestiae pariatur eum dolorem.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4089), false, 4, null, 10 },
                    { 34, 18, "Neque voluptatem dolores magnam ut sed eos quidem.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4134), false, 5, null, 4 },
                    { 35, 11, "Nobis beatae quam voluptatibus fuga sint aut.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4155), false, 3, null, 4 },
                    { 36, 6, "Consequatur ut ipsum eos cumque tempore.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4171), false, 2, null, 9 },
                    { 37, 16, "Explicabo rerum incidunt voluptas.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4186), false, 3, null, 5 },
                    { 38, 8, "Similique minima laborum voluptatibus quibusdam explicabo.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4199), false, 1, null, 4 },
                    { 39, 1, "Vitae delectus totam voluptatibus iste ipsum nam.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4214), false, 5, null, 10 },
                    { 40, 13, "Sed repellendus officia sit nulla earum et.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4230), false, 5, null, 7 },
                    { 41, 5, "Eveniet modi vel.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4247), false, 1, null, 6 },
                    { 42, 6, "Nisi molestias eveniet molestias.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4258), false, 2, null, 7 },
                    { 43, 3, "Itaque placeat possimus mollitia consectetur asperiores molestias sed consequatur.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4301), false, 1, null, 5 },
                    { 44, 3, "Earum voluptatem fuga omnis quibusdam quam.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4322), false, 3, null, 8 },
                    { 45, 9, "Deserunt facilis tempora aliquam et.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4337), false, 2, null, 10 },
                    { 46, 16, "Quo molestiae aut ipsum explicabo deserunt.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4350), false, 4, null, 8 },
                    { 47, 17, "Cumque velit iste aut maxime in omnis vel inventore similique.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4365), false, 5, null, 9 },
                    { 48, 5, "Praesentium nam porro vitae quia et.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4385), false, 1, null, 9 },
                    { 49, 7, "Inventore ut voluptatem ex dolores dolorum dolores ut.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4400), false, 4, null, 8 },
                    { 50, 11, "Earum doloremque fugiat voluptas sint eveniet quia voluptatibus iusto ut.", new DateTime(2024, 12, 11, 21, 23, 10, 17, DateTimeKind.Utc).AddTicks(4450), false, 4, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6425), false, null, 4 },
                    { 2, 7, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6574), false, null, 7 },
                    { 3, 20, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6579), false, null, 5 },
                    { 4, 5, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6648), false, null, 10 },
                    { 5, 4, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6653), false, null, 5 },
                    { 6, 20, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6655), false, null, 8 },
                    { 7, 11, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6658), false, null, 3 },
                    { 8, 16, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6660), false, null, 3 },
                    { 9, 8, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6663), false, null, 4 },
                    { 10, 4, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6665), false, null, 7 },
                    { 11, 17, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6668), false, null, 5 },
                    { 12, 5, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6670), false, null, 6 },
                    { 13, 11, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6673), false, null, 9 },
                    { 14, 10, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6675), false, null, 5 },
                    { 15, 18, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6678), false, null, 5 },
                    { 16, 16, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6680), false, null, 9 },
                    { 17, 14, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6683), false, null, 6 },
                    { 18, 9, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6685), false, null, 9 },
                    { 19, 15, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6687), false, null, 2 },
                    { 20, 6, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6690), false, null, 2 },
                    { 21, 7, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6692), false, null, 4 },
                    { 22, 4, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6695), false, null, 9 },
                    { 23, 15, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6697), false, null, 4 },
                    { 24, 14, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6700), false, null, 3 },
                    { 25, 16, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6702), false, null, 7 },
                    { 26, 20, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6704), false, null, 9 },
                    { 27, 18, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6707), false, null, 6 },
                    { 28, 18, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6709), false, null, 3 },
                    { 29, 19, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6711), false, null, 7 },
                    { 30, 7, new DateTime(2024, 12, 11, 21, 23, 10, 18, DateTimeKind.Utc).AddTicks(6714), false, null, 6 }
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
