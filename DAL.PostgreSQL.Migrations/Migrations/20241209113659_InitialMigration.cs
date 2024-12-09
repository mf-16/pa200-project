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
                    { 1, "Davisshire", "Togo", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(8578), false, "New Jersey", "454 Lockman Walk", null, "93649" },
                    { 2, "Tristonberg", "Croatia", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(9168), false, "Iowa", "036 Frami Neck", null, "66869" },
                    { 3, "North Guillermoton", "Tajikistan", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(9301), false, "Idaho", "250 Kling Bypass", null, "08517-1469" },
                    { 4, "Antonetteview", "Benin", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(9429), false, "Georgia", "3599 Emmerich Vista", null, "07355-1783" },
                    { 5, "Port Tyra", "Faroe Islands", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(9573), false, "Kansas", "0010 Dock Station", null, "58464-7125" },
                    { 6, "East Hopechester", "Monaco", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(9705), false, "Hawaii", "82002 Lizeth Place", null, "91297-2358" },
                    { 7, "West Camdenfort", "Russian Federation", new DateTime(2024, 12, 9, 11, 36, 58, 753, DateTimeKind.Utc).AddTicks(9872), false, "Nebraska", "13297 Schiller Road", null, "36772-3120" },
                    { 8, "East Ellatown", "Bahrain", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(2), false, "Pennsylvania", "2849 Carter Glens", null, "62365" },
                    { 9, "Wilbertfurt", "Spain", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(125), false, "Missouri", "7204 Hane Parkways", null, "22781" },
                    { 10, "North Rickeytown", "Greece", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(239), false, "Washington", "65269 Leannon Valleys", null, "28737-6604" },
                    { 11, "Considineborough", "Armenia", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(515), false, "Alaska", "07575 Trace Circles", null, "34975-6853" },
                    { 12, "Lydachester", "Iran", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(644), false, "Idaho", "9009 Aufderhar Knolls", null, "93602" },
                    { 13, "Port Elroy", "Vanuatu", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(728), false, "Ohio", "753 Caleb Pike", null, "37160-1535" },
                    { 14, "South Lessiebury", "Thailand", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(844), false, "Colorado", "63878 Weldon Union", null, "31462" },
                    { 15, "South Devenborough", "Belgium", new DateTime(2024, 12, 9, 11, 36, 58, 754, DateTimeKind.Utc).AddTicks(964), false, "Colorado", "38663 Eulah Landing", null, "95298" }
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
                    { 1, 0, "eaefa2c2-bdc3-4dbc-a83c-63eee2b8172c", "admin@admin.com", true, false, null, "Admin User", null, "FAKE_ADMIN", null, "123-456-7890", false, "350b70da-4523-49f1-8805-6b540cbda726", false, "fake_admin" },
                    { 2, 0, "f5b86457-3125-47f4-92e1-701cb9b6ac90", "Jon_Reichel47@yahoo.com", true, false, null, "Una Jast", null, null, null, "(292) 359-4763 x6587", false, "0d6206a4-088e-4368-bcd4-d85830cb1e78", false, "Luz_Daniel77" },
                    { 3, 0, "830c892e-6b4b-4e65-b96d-6e73a2ff4aa4", "Tristian_Pagac40@gmail.com", true, false, null, "Kay Klein", null, null, null, "1-396-565-1068", false, "5994ca49-fd9c-403c-8710-28732c35ba14", false, "Melyssa_Mueller" },
                    { 4, 0, "5021924e-8ce5-487a-aa28-f13b775d5b70", "Kirsten35@yahoo.com", true, false, null, "Keyon Marvin", null, null, null, "925-537-1512 x382", false, "2ee5dc6d-2c4f-4c3f-a334-6fba7c8b85c2", false, "Adolfo.Littel" },
                    { 5, 0, "8df01c40-412e-4366-af8c-a7ea5b644cc3", "Maudie.Towne@yahoo.com", true, false, null, "Rosemary Daugherty", null, null, null, "1-760-336-3157 x7244", false, "10e83ce8-9834-4a73-8082-ff57ff80a05e", false, "Deion.Grant" },
                    { 6, 0, "e1289dcd-91c7-4184-acb9-b9eca3f44c68", "Misty.Braun@hotmail.com", true, false, null, "Anabelle Toy", null, null, null, "(409) 474-2308", false, "efcad919-b57e-4464-a024-40aee003fc0d", false, "Mercedes69" },
                    { 7, 0, "a3636fe4-a48b-4dbc-bae2-c07e3dfa6322", "Quinn.Smitham@gmail.com", true, false, null, "Savanah Auer", null, null, null, "1-636-251-5399 x9385", false, "02852434-4e3d-4965-96f6-6ae94fbd00a7", false, "Hadley.Stark44" },
                    { 8, 0, "613a208f-64a4-4e94-ae23-98e042dc70e2", "Justice_Berge68@yahoo.com", true, false, null, "Jacey Barton", null, null, null, "1-352-744-1580 x5021", false, "5e18b32b-dab1-4192-a796-cb650379bdee", false, "Alford.Tillman65" },
                    { 9, 0, "a5a3cf5e-4a54-4c9f-b0a9-bf281012a28e", "Laverna_Mohr@gmail.com", true, false, null, "Nyah Veum", null, null, null, "(960) 788-4625 x25111", false, "9148397e-3b40-44bf-afba-147d07ac49d7", false, "Santina_Buckridge" },
                    { 10, 0, "3bca37b8-4685-4e4f-b269-e396f0150422", "Jolie_Dare@gmail.com", true, false, null, "Clementine D'Amore", null, null, null, "(364) 688-1828", false, "3394b417-8183-486d-ae14-ac835823992e", false, "Paul_Durgan" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Ut veritatis doloremque dolores omnis consequuntur. Expedita soluta saepe et eum optio. Neque tempore aut non quam quaerat. Voluptatem et omnis qui est laudantium quo aut odit quam.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(2322), false, "Keegan Buckridge", null },
                    { 2, "Eos minima numquam id consequuntur in quasi quia. Ea eos blanditiis fugit eligendi non natus quia. Rerum libero alias. Ut facere aliquam incidunt aut laudantium ut.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(2736), false, "Uriah Erdman", null },
                    { 3, "Dolore voluptatem nemo. Dolor nobis natus est est necessitatibus excepturi velit deleniti. Quam consequatur aperiam accusantium. Aut perspiciatis quae rerum molestiae.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(2826), false, "Tyreek Rohan", null },
                    { 4, "Vero occaecati tempora voluptas aut aperiam. Sint voluptatem placeat numquam laboriosam tempora. Nisi est laborum minima non voluptas vel. Molestiae qui assumenda itaque non quidem eos ut porro molestiae. Esse quos veniam fugiat sit dolor fugiat.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(2934), false, "Alanna Smitham", null },
                    { 5, "Sapiente ex ad iure minus iusto nulla. Nobis sunt quaerat voluptas delectus. Quas voluptatem totam.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(3068), false, "Leopold Roberts", null },
                    { 6, "Vitae reprehenderit ut error expedita quia voluptates ut. Iure vero dicta et earum. Amet molestias autem est sint fugiat modi sint.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(3122), false, "Loyce Kassulke", null },
                    { 7, "In sit aut accusantium qui qui rerum accusamus nesciunt beatae. Reiciendis dolorem blanditiis maiores. Doloremque veniam quod est. Quam ut est ad voluptatum necessitatibus amet sit aperiam eveniet. Velit reprehenderit quidem odit saepe et nobis officia. Doloribus et doloremque beatae dolorem.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(3182), false, "Ashley Koepp", null },
                    { 8, "Excepturi quidem accusamus et odit dolorum incidunt voluptatem quis. Ducimus ipsa quo. Vero officia velit et temporibus et. Est repellendus quos. Perspiciatis possimus itaque ut commodi quasi ducimus eveniet architecto tempore.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(3312), false, "Alysson Auer", null },
                    { 9, "Repellat corporis commodi nisi. Quis eaque quaerat dolor et. Necessitatibus ullam nisi. Ipsam non earum consequatur unde dolorem ducimus tempore adipisci. Sequi dolorem nulla sunt expedita exercitationem.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(3424), false, "Modesto Gutmann", null },
                    { 10, "Quo tempora dignissimos eos magnam veniam. Sed fugit consequatur ut. Rem saepe autem veniam possimus. Voluptatem id natus est necessitatibus debitis repudiandae.", new DateTime(2024, 12, 9, 11, 36, 58, 745, DateTimeKind.Utc).AddTicks(3504), false, "Rosalind Mraz", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Debitis qui eius." },
                    { 2, "Qui libero sint." },
                    { 3, "Rerum saepe enim." },
                    { 4, "Eos omnis dolores." },
                    { 5, "Veniam cupiditate odio." },
                    { 6, "Est ipsa non." }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Illum odit qui cum quae. Autem exercitationem maxime error. Dignissimos rem vel nihil.", new DateTime(2024, 12, 9, 11, 36, 58, 746, DateTimeKind.Utc).AddTicks(7904), false, "Mayert - Brakus", null },
                    { 2, "Sapiente nisi vitae consequatur nemo suscipit quam. Et nemo sequi quam enim laborum quod rerum possimus et. Provident nihil deserunt doloribus necessitatibus commodi voluptatibus consectetur ea ullam.", new DateTime(2024, 12, 9, 11, 36, 58, 746, DateTimeKind.Utc).AddTicks(8475), false, "Schumm, Dare and Wintheiser", null },
                    { 3, "Esse dolor rem sit voluptatum aliquid aut magnam repudiandae. Consequatur enim minus illum numquam qui ea accusamus nostrum assumenda. Accusamus velit doloribus provident laboriosam accusantium. Ut et cupiditate ad.", new DateTime(2024, 12, 9, 11, 36, 58, 746, DateTimeKind.Utc).AddTicks(8756), false, "Greenholt LLC", null },
                    { 4, "Soluta rem voluptatem iusto illum sit id deleniti. Facilis id consequuntur repellendus ullam minus. Qui ut sunt ut.", new DateTime(2024, 12, 9, 11, 36, 58, 746, DateTimeKind.Utc).AddTicks(8990), false, "Halvorson, Prohaska and Sauer", null },
                    { 5, "Velit neque id aspernatur eius sit amet debitis aut delectus. Quibusdam illum officia enim. Ducimus eligendi tenetur error blanditiis nesciunt. Distinctio consequatur eaque cumque unde omnis deserunt assumenda dicta sint.", new DateTime(2024, 12, 9, 11, 36, 58, 746, DateTimeKind.Utc).AddTicks(9147), false, "Swaniawski - Brakus", null }
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
                    { 1, 7, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(6359), "Voluptas quis numquam. Officia unde explicabo. Enim quia architecto iusto non debitis. Eaque nostrum consequatur. Aliquid dolor id et recusandae consectetur exercitationem.", 0, "https://picsum.photos/640/480/?image=860", false, null, 98.24m, 3, 4, "Deleniti earum minus.", null },
                    { 2, 5, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(7688), "Doloremque minima animi et explicabo quis veniam. Laboriosam vel voluptatum sapiente nulla nulla a. Ea quia cumque amet.", 0, "https://picsum.photos/640/480/?image=149", false, null, 45.13m, 3, 4, "Molestias voluptates et.", null },
                    { 3, 6, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(7842), "Eligendi consequatur quo quam amet. Dolores voluptate vel. Id qui sed soluta perspiciatis. Voluptas occaecati culpa et repudiandae non eos.", 0, "https://picsum.photos/640/480/?image=643", false, null, 25.19m, 2, 5, "Ullam non asperiores.", null },
                    { 4, 2, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8013), "Ea ut laboriosam rerum eum sequi et deleniti at reiciendis. Deserunt quam placeat nobis cumque quam consequuntur omnis itaque officiis. Unde explicabo ea aut qui quia quidem necessitatibus. Omnis non inventore nihil corrupti. Et commodi ut amet sint totam earum incidunt. Nihil ducimus voluptatem id beatae voluptatem.", 0, "https://picsum.photos/640/480/?image=532", false, null, 20.12m, 2, 5, "Id magni commodi.", null },
                    { 5, 5, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8197), "Voluptate et quia consectetur excepturi sequi. Voluptatem ad dolore minima eveniet veritatis ab ipsam. Impedit molestias perferendis et possimus. Dolores deserunt voluptatem blanditiis sit est.", 0, "https://picsum.photos/640/480/?image=1036", false, null, 77.08m, 3, 5, "Ea iste eaque.", null },
                    { 6, 1, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8280), "Iste velit omnis veniam natus accusantium dolorum aut ipsam ipsam. Ut reiciendis cumque nesciunt tempore. Quidem et praesentium. Odit veniam aut unde corrupti sit earum inventore. Qui ea atque dolorem voluptatem atque nihil. Debitis pariatur neque.", 0, "https://picsum.photos/640/480/?image=1036", false, null, 73.36m, 5, 1, "Nobis vitae repudiandae.", null },
                    { 7, 8, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8410), "At rerum quia harum veritatis perspiciatis assumenda ut aut. Unde ut est perferendis ut esse. Earum architecto dolore omnis ratione vel corrupti tenetur rerum.", 0, "https://picsum.photos/640/480/?image=657", false, null, 85.94m, 6, 4, "Eligendi totam minima.", null },
                    { 8, 5, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8502), "Quisquam mollitia maxime veniam est quia ducimus aspernatur expedita dolor. Aut iure occaecati tempore odit iste non modi et quis. Enim facere voluptate molestias nemo exercitationem deleniti odit.", 0, "https://picsum.photos/640/480/?image=161", false, null, 54.46m, 5, 3, "Incidunt sit voluptates.", null },
                    { 9, 1, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8575), "Deleniti nesciunt dicta ut et sapiente repudiandae nulla. Maiores consequatur dolores omnis ipsum vel. Repellat eveniet consequatur aut facilis quod sed. Nihil accusantium autem molestias impedit. Optio aut sed dicta veniam. Ducimus placeat odio autem possimus doloremque quasi esse.", 0, "https://picsum.photos/640/480/?image=308", false, null, 63.64m, 5, 3, "Odit laborum accusamus.", null },
                    { 10, 6, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8783), "Omnis dolorem molestiae eaque illo voluptatibus aperiam beatae perspiciatis. Qui soluta eum alias quis ducimus repellendus velit culpa. Dicta facilis ut voluptas harum omnis sint. Voluptas et dolorum. Quia et minima non est esse. Dolorum voluptatum enim dolorum labore.", 0, "https://picsum.photos/640/480/?image=328", false, null, 18.43m, 1, 2, "Quam enim optio.", null },
                    { 11, 8, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(8945), "Odio doloribus sed et id iusto. Id ut ut nisi necessitatibus. Nisi enim earum odio incidunt culpa quasi. Dignissimos corporis omnis voluptas eum voluptatem quia veritatis. Qui sunt voluptatem et doloremque similique.", 0, "https://picsum.photos/640/480/?image=267", false, null, 29.11m, 3, 5, "Alias aspernatur repellendus.", null },
                    { 12, 1, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9068), "Minima cumque corporis repellat nemo. Enim quia quia voluptatem sed voluptates eos dolorem dolores. Autem animi deserunt. Voluptatem at modi blanditiis itaque voluptatem fugiat mollitia quibusdam voluptas. Et ut officiis quo ex corporis excepturi cupiditate dolorem.", 0, "https://picsum.photos/640/480/?image=967", false, null, 14.98m, 6, 1, "Est nisi aut.", null },
                    { 13, 9, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9208), "Tempore pariatur est et magni. Omnis quia ut laboriosam vel repellat sint. Ad explicabo neque.", 0, "https://picsum.photos/640/480/?image=550", false, null, 63.42m, 4, 1, "Alias maxime assumenda.", null },
                    { 14, 2, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9258), "Asperiores iusto aut vel aperiam voluptate. Facere similique corrupti sunt ut voluptatibus nostrum corrupti. Suscipit laboriosam mollitia culpa odit labore eum.", 0, "https://picsum.photos/640/480/?image=51", false, null, 72.49m, 4, 3, "Inventore fugiat occaecati.", null },
                    { 15, 6, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9342), "Pariatur architecto impedit. Nulla iure fugit corrupti odit nemo. Similique aliquam enim nobis non dolor quia minima quia et. Fuga tenetur ea natus unde minus unde possimus rem porro.", 0, "https://picsum.photos/640/480/?image=208", false, null, 65.44m, 2, 1, "Rem sequi eveniet.", null },
                    { 16, 4, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9419), "In sequi odio repellendus alias ea iusto tenetur. Placeat ut aut sit rerum ut voluptas. Quasi et ut veritatis labore nam placeat. Laudantium ipsa quidem qui et vel omnis qui.", 0, "https://picsum.photos/640/480/?image=80", false, null, 10.80m, 5, 1, "Omnis voluptatem soluta.", null },
                    { 17, 6, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9525), "Quis consectetur eum fuga officia quas quia alias recusandae. Quis atque fuga porro et neque assumenda recusandae doloribus. Quam eum esse ut. Voluptates excepturi officiis.", 0, "https://picsum.photos/640/480/?image=664", false, null, 66.73m, 5, 3, "Dolores blanditiis et.", null },
                    { 18, 5, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9592), "Ipsa eum eligendi in enim. Autem placeat earum quibusdam. Non blanditiis sequi provident quidem quasi. Minus quo dolorem vitae aspernatur minus. Placeat iusto temporibus illo. Consequatur deserunt soluta voluptatem.", 0, "https://picsum.photos/640/480/?image=576", false, null, 94.33m, 6, 5, "Maxime qui eveniet.", null },
                    { 19, 8, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9734), "Atque molestiae dolores. Vel qui corrupti unde maiores. Fuga doloremque molestias velit dolores doloribus nam. Molestias inventore veritatis vitae temporibus praesentium occaecati perferendis officia esse.", 0, "https://picsum.photos/640/480/?image=548", false, null, 77.78m, 6, 1, "Explicabo error cumque.", null },
                    { 20, 8, new DateTime(2024, 12, 9, 11, 36, 58, 749, DateTimeKind.Utc).AddTicks(9830), "Laboriosam sit autem aut et non sit voluptates mollitia. Nihil et consequatur ipsa. Harum tenetur consequatur quaerat ex deserunt adipisci. Velit dolor aliquid voluptatem ipsa corporis. Incidunt aliquam et quia est molestiae sed nihil voluptas voluptatum. Nisi numquam dolorem aut quia esse.", 0, "https://picsum.photos/640/480/?image=194", false, null, 52.98m, 1, 5, "Asperiores nulla deserunt.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2085), false, null, 2 },
                    { 3, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2087), false, null, 3 },
                    { 4, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2087), false, null, 4 },
                    { 5, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2087), false, null, 5 },
                    { 6, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2087), false, null, 6 },
                    { 7, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2088), false, null, 7 },
                    { 8, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2088), false, null, 8 },
                    { 9, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2088), false, null, 9 },
                    { 10, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(2088), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 10, new DateTime(2024, 12, 9, 11, 36, 58, 755, DateTimeKind.Utc).AddTicks(2515), "Melissa94@hotmail.com", "Melissa Kihn", false, 9, 0m, null, 2 },
                    { 2, 9, new DateTime(2024, 12, 9, 11, 36, 58, 755, DateTimeKind.Utc).AddTicks(4937), "Felipe29@yahoo.com", "Felipe Hartmann", false, 14, 0m, null, 2 },
                    { 3, 4, new DateTime(2024, 12, 9, 11, 36, 58, 755, DateTimeKind.Utc).AddTicks(5894), "Pablo.Goyette70@hotmail.com", "Pablo Goyette", false, 9, 0m, null, 10 },
                    { 4, 12, new DateTime(2024, 12, 9, 11, 36, 58, 755, DateTimeKind.Utc).AddTicks(6566), "Olive75@yahoo.com", "Olive Upton", false, 7, 0m, null, 2 },
                    { 5, 5, new DateTime(2024, 12, 9, 11, 36, 58, 755, DateTimeKind.Utc).AddTicks(7095), "Felicia.Lueilwitz@yahoo.com", "Felicia Lueilwitz", false, 2, 0m, null, 8 },
                    { 6, 14, new DateTime(2024, 12, 9, 11, 36, 58, 755, DateTimeKind.Utc).AddTicks(7587), "Annette_Hartmann@gmail.com", "Annette Hartmann", false, 6, 0m, null, 4 },
                    { 7, 14, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(757), "Ollie84@hotmail.com", "Ollie Ziemann", false, 8, 0m, null, 3 },
                    { 8, 8, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(1254), "Johnnie.Bergnaum39@yahoo.com", "Johnnie Bergnaum", false, 12, 0m, null, 3 },
                    { 9, 7, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(1702), "Sheila.Ullrich@yahoo.com", "Sheila Ullrich", false, 15, 0m, null, 10 },
                    { 10, 7, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(2292), "Raquel55@hotmail.com", "Raquel Kiehn", false, 2, 0m, null, 8 },
                    { 11, 1, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(2799), "Gabriel.Lubowitz5@yahoo.com", "Gabriel Lubowitz", false, 7, 0m, null, 3 },
                    { 12, 14, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(3223), "Candice_Rosenbaum69@gmail.com", "Candice Rosenbaum", false, 15, 0m, null, 8 },
                    { 13, 1, new DateTime(2024, 12, 9, 11, 36, 58, 756, DateTimeKind.Utc).AddTicks(3705), "Alan.OConnell@gmail.com", "Alan O'Connell", false, 12, 0m, null, 7 },
                    { 14, 1, new DateTime(2024, 12, 9, 11, 36, 58, 757, DateTimeKind.Utc).AddTicks(6941), "Marsha.Schmitt@yahoo.com", "Marsha Schmitt", false, 9, 0m, null, 2 },
                    { 15, 1, new DateTime(2024, 12, 9, 11, 36, 58, 757, DateTimeKind.Utc).AddTicks(7594), "Benjamin46@gmail.com", "Benjamin Kuvalis", false, 15, 0m, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 12, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(250), false, 6, 35.17m, 2, null },
                    { 2, 10, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1523), false, 5, 46.87m, 3, null },
                    { 3, 16, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1571), false, 2, 85.99m, 2, null },
                    { 4, 18, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1582), false, 8, 36.67m, 1, null },
                    { 5, 8, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1590), false, 4, 23.48m, 3, null },
                    { 6, 15, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1596), false, 7, 41.29m, 3, null },
                    { 7, 8, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1603), false, 6, 68.14m, 1, null },
                    { 8, 15, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1610), false, 6, 59.32m, 1, null },
                    { 9, 4, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1617), false, 15, 21.34m, 2, null },
                    { 10, 10, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1624), false, 3, 18.94m, 3, null },
                    { 11, 6, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1631), false, 11, 58.77m, 2, null },
                    { 12, 3, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1638), false, 11, 95.51m, 1, null },
                    { 13, 1, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1644), false, 11, 26.07m, 1, null },
                    { 14, 19, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1652), false, 10, 34.45m, 2, null },
                    { 15, 19, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1662), false, 8, 87.78m, 3, null },
                    { 16, 17, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1669), false, 12, 69.42m, 2, null },
                    { 17, 10, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1676), false, 10, 94.40m, 2, null },
                    { 18, 16, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1682), false, 13, 47.56m, 3, null },
                    { 19, 18, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1690), false, 8, 81.17m, 1, null },
                    { 20, 19, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1696), false, 2, 97.11m, 3, null },
                    { 21, 12, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1703), false, 15, 36.94m, 2, null },
                    { 22, 19, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1709), false, 15, 96.38m, 3, null },
                    { 23, 14, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1716), false, 9, 78.75m, 3, null },
                    { 24, 13, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1723), false, 6, 82.09m, 3, null },
                    { 25, 8, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1729), false, 1, 11.91m, 1, null },
                    { 26, 7, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1736), false, 3, 60.38m, 2, null },
                    { 27, 19, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1743), false, 7, 96.86m, 3, null },
                    { 28, 11, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1749), false, 5, 90.59m, 3, null },
                    { 29, 14, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1756), false, 3, 99.86m, 2, null },
                    { 30, 5, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1763), false, 2, 86.08m, 1, null },
                    { 31, 8, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1770), false, 6, 87.00m, 3, null },
                    { 32, 13, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1779), false, 2, 87.54m, 2, null },
                    { 33, 11, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1831), false, 13, 16.48m, 3, null },
                    { 34, 10, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1838), false, 13, 11.71m, 2, null },
                    { 35, 7, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1845), false, 7, 60.92m, 2, null },
                    { 36, 11, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1852), false, 7, 30.46m, 1, null },
                    { 37, 17, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1859), false, 8, 82.75m, 1, null },
                    { 38, 17, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1866), false, 10, 21.00m, 3, null },
                    { 39, 6, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1873), false, 1, 79.35m, 3, null },
                    { 40, 6, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1880), false, 6, 13.12m, 2, null },
                    { 41, 17, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1886), false, 12, 43.56m, 3, null },
                    { 42, 12, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1894), false, 10, 29.29m, 3, null },
                    { 43, 15, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1900), false, 14, 76.27m, 1, null },
                    { 44, 9, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1907), false, 11, 75.64m, 3, null },
                    { 45, 3, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1914), false, 14, 44.56m, 2, null },
                    { 46, 19, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1920), false, 14, 13.61m, 1, null },
                    { 47, 3, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1927), false, 14, 94.70m, 3, null },
                    { 48, 2, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1934), false, 5, 13.97m, 2, null },
                    { 49, 3, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1941), false, 4, 25.99m, 3, null },
                    { 50, 15, new DateTime(2024, 12, 9, 11, 36, 58, 759, DateTimeKind.Utc).AddTicks(1948), false, 1, 70.83m, 3, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 16, "Exercitationem sit quis deleniti ut est accusantium nobis non.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(2516), false, 5, null, 4 },
                    { 2, 5, "Error unde tempore perspiciatis laboriosam ipsam est.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3605), false, 4, null, 2 },
                    { 3, 10, "Vel aliquid soluta provident.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3674), false, 3, null, 6 },
                    { 4, 12, "Adipisci soluta et possimus maxime quas.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3693), false, 1, null, 2 },
                    { 5, 11, "Qui voluptatibus dolore tempora iste.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3716), false, 3, null, 5 },
                    { 6, 20, "Qui nesciunt doloremque corporis eligendi aliquam non.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3734), false, 1, null, 5 },
                    { 7, 19, "Repudiandae quo officiis corrupti perspiciatis enim repellendus exercitationem voluptate.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3757), false, 4, null, 3 },
                    { 8, 12, "Ducimus ex ut cum officia officiis et.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3782), false, 4, null, 9 },
                    { 9, 4, "Similique est ut unde sunt atque.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3911), false, 1, null, 6 },
                    { 10, 17, "Aspernatur cumque et quidem exercitationem itaque consectetur possimus voluptas iure.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3933), false, 2, null, 8 },
                    { 11, 15, "Corrupti ullam velit cumque consequatur.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3957), false, 1, null, 6 },
                    { 12, 2, "Dolorem qui beatae nam.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3971), false, 2, null, 8 },
                    { 13, 12, "Quia repellendus accusamus aperiam harum molestiae.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(3986), false, 4, null, 9 },
                    { 14, 15, "Vero non non.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4005), false, 2, null, 10 },
                    { 15, 12, "Possimus nostrum voluptatem ut est.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4019), false, 1, null, 3 },
                    { 16, 1, "Natus ut vero.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4034), false, 4, null, 6 },
                    { 17, 16, "Distinctio dolore maiores cupiditate.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4045), false, 1, null, 4 },
                    { 18, 18, "Dolores a aut dolore doloremque quae minus.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4103), false, 1, null, 2 },
                    { 19, 1, "Hic laboriosam laboriosam sed explicabo voluptatem ipsum adipisci maiores est.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4121), false, 3, null, 3 },
                    { 20, 5, "Excepturi debitis et ut.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4149), false, 5, null, 5 },
                    { 21, 7, "Assumenda velit doloribus eveniet.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4162), false, 5, null, 7 },
                    { 22, 14, "Eos in id.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4177), false, 5, null, 10 },
                    { 23, 9, "Sunt illum dolores quae adipisci perferendis debitis aliquid aut enim.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4191), false, 5, null, 10 },
                    { 24, 18, "Nihil accusamus quo sit voluptas illum repellendus nihil quam.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4218), false, 2, null, 2 },
                    { 25, 14, "Et aut illum ullam explicabo.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4264), false, 3, null, 10 },
                    { 26, 1, "Aut accusantium quis.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4280), false, 4, null, 10 },
                    { 27, 5, "Et eveniet recusandae tenetur eos adipisci vel ad rerum a.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4292), false, 3, null, 10 },
                    { 28, 10, "Explicabo sit qui cumque et voluptatem harum.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4316), false, 5, null, 7 },
                    { 29, 1, "Voluptas excepturi dolor.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4335), false, 3, null, 9 },
                    { 30, 14, "Asperiores et ad veritatis laborum sint quasi.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4345), false, 4, null, 9 },
                    { 31, 7, "Consectetur ab quisquam.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4366), false, 4, null, 6 },
                    { 32, 8, "Voluptatum quia nemo aut ad eum minima nihil quia.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4379), false, 4, null, 7 },
                    { 33, 2, "Harum aut ullam.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4405), false, 3, null, 7 },
                    { 34, 9, "Eius et vel ad voluptas ut.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4445), false, 5, null, 4 },
                    { 35, 20, "Dolore sint omnis.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4460), false, 2, null, 6 },
                    { 36, 2, "Molestiae asperiores expedita.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4471), false, 4, null, 4 },
                    { 37, 16, "Qui quos consequatur aut quo perferendis.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4483), false, 5, null, 8 },
                    { 38, 11, "Tempore eum quo sed.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4499), false, 5, null, 4 },
                    { 39, 7, "Sit exercitationem voluptatem placeat facilis ipsa cum.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4514), false, 1, null, 10 },
                    { 40, 13, "Eum doloremque omnis.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4532), false, 3, null, 3 },
                    { 41, 12, "Ut unde eum in debitis quia quae.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4543), false, 4, null, 10 },
                    { 42, 19, "Ex quia ipsam rem voluptas eligendi.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4560), false, 3, null, 5 },
                    { 43, 5, "Qui aspernatur et facilis possimus.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4576), false, 4, null, 3 },
                    { 44, 4, "Sit perferendis molestiae sunt ipsum quae earum ducimus.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4616), false, 2, null, 4 },
                    { 45, 17, "Quia inventore est aliquam repudiandae suscipit sed facere sint.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4635), false, 2, null, 8 },
                    { 46, 15, "Omnis ex voluptas qui est asperiores quasi.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4658), false, 2, null, 8 },
                    { 47, 2, "Voluptas voluptates aut ipsam sit quis aut est est.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4676), false, 5, null, 5 },
                    { 48, 8, "Nobis harum in inventore.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4695), false, 1, null, 7 },
                    { 49, 7, "Nobis sed voluptas blanditiis.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4708), false, 4, null, 5 },
                    { 50, 8, "Quia iste sapiente.", new DateTime(2024, 12, 9, 11, 36, 58, 751, DateTimeKind.Utc).AddTicks(4722), false, 2, null, 8 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 16, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(6852), false, null, 7 },
                    { 2, 9, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(6982), false, null, 5 },
                    { 3, 20, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(6988), false, null, 6 },
                    { 4, 9, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(6991), false, null, 3 },
                    { 5, 8, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(6994), false, null, 7 },
                    { 6, 12, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7079), false, null, 5 },
                    { 7, 1, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7084), false, null, 10 },
                    { 8, 13, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7087), false, null, 10 },
                    { 9, 5, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7089), false, null, 2 },
                    { 10, 17, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7092), false, null, 2 },
                    { 11, 9, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7095), false, null, 6 },
                    { 12, 3, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7097), false, null, 3 },
                    { 13, 14, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7100), false, null, 8 },
                    { 14, 3, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7102), false, null, 2 },
                    { 15, 12, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7105), false, null, 3 },
                    { 16, 10, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7107), false, null, 9 },
                    { 17, 13, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7110), false, null, 5 },
                    { 18, 4, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7112), false, null, 8 },
                    { 19, 7, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7115), false, null, 8 },
                    { 20, 17, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7118), false, null, 6 },
                    { 21, 8, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7120), false, null, 10 },
                    { 22, 2, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7123), false, null, 6 },
                    { 23, 16, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7125), false, null, 10 },
                    { 24, 6, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7127), false, null, 7 },
                    { 25, 19, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7129), false, null, 3 },
                    { 26, 18, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7132), false, null, 5 },
                    { 27, 19, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7135), false, null, 6 },
                    { 28, 20, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7137), false, null, 10 },
                    { 29, 1, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7139), false, null, 2 },
                    { 30, 12, new DateTime(2024, 12, 9, 11, 36, 58, 752, DateTimeKind.Utc).AddTicks(7142), false, null, 8 }
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
