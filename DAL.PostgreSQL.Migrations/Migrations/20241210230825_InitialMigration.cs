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
                    { 1, "Klockomouth", "Belize", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(8448), false, "Maryland", "296 Josie Dam", null, "99864-7658" },
                    { 2, "West Florineport", "Palestinian Territory", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(9076), false, "Washington", "48076 Florence Roads", null, "38272-2665" },
                    { 3, "South Augusta", "Samoa", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(9244), false, "New Jersey", "446 Wolf Roads", null, "98114" },
                    { 4, "East Alfordchester", "Heard Island and McDonald Islands", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(9419), false, "Louisiana", "526 Fritsch Mission", null, "53955-9286" },
                    { 5, "North Marieton", "Lithuania", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(9587), false, "Maryland", "57673 Schultz Cliffs", null, "98011" },
                    { 6, "East Shayneshire", "Bulgaria", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(9728), false, "New Hampshire", "98172 Tad Fords", null, "53788-0449" },
                    { 7, "West Terrillside", "Hong Kong", new DateTime(2024, 12, 10, 23, 8, 25, 144, DateTimeKind.Utc).AddTicks(9867), false, "Delaware", "1647 Jazmyn Forge", null, "15908-2884" },
                    { 8, "Sipesport", "Swaziland", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(23), false, "Arizona", "705 Felton Brook", null, "94111" },
                    { 9, "Maurineton", "Netherlands", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(160), false, "Michigan", "4833 May Flat", null, "95101" },
                    { 10, "Shanaland", "Czech Republic", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(286), false, "Maryland", "5009 Obie Bridge", null, "62066" },
                    { 11, "Tyraport", "Angola", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(397), false, "Rhode Island", "15796 Osinski Cliffs", null, "87146-2615" },
                    { 12, "Delfinahaven", "Hungary", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(542), false, "Iowa", "44349 Holden Squares", null, "36478-5624" },
                    { 13, "East Elyssa", "Myanmar", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(686), false, "Ohio", "0729 Macy Station", null, "83762" },
                    { 14, "South Macyside", "Tanzania", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(813), false, "Indiana", "0491 Sipes Gardens", null, "05577-0602" },
                    { 15, "West Willowstad", "Algeria", new DateTime(2024, 12, 10, 23, 8, 25, 145, DateTimeKind.Utc).AddTicks(942), false, "New Jersey", "189 Francesca Squares", null, "13397-2115" }
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
                    { 1, 0, "1fd2e83d-23ff-48b8-9cb9-5ef846433015", "admin@admin.com", true, false, null, "Admin User", null, null, null, "123-456-7890", false, "0d5804d1-84f2-4eb5-a3e5-086520191274", false, "admin@admin.com" },
                    { 2, 0, "ea02d39e-17cf-450d-8f8b-8f01006b4f99", "Irving_Jaskolski66@yahoo.com", true, false, null, "Keith Maggio", null, null, null, "697.438.5201 x7993", false, "5c5ad60f-9525-4328-a079-fb23294c3c94", false, "Irving_Jaskolski66@yahoo.com" },
                    { 3, 0, "8e04d160-b6a6-44ab-a10d-b9331f6e1a35", "Morgan_Hoppe@yahoo.com", true, false, null, "Felicity Moore", null, null, null, "552.923.1433", false, "01b4fad9-c6fa-42a0-adde-b04abcfb9b5e", false, "Morgan_Hoppe@yahoo.com" },
                    { 4, 0, "bf557e58-ca4a-4a8a-9831-b9fc7d337f4d", "Raymundo_Von@hotmail.com", true, false, null, "Alda Yundt", null, null, null, "298.831.4187", false, "b882013a-ec0d-4001-b87b-d49a23fff5f7", false, "Raymundo_Von@hotmail.com" },
                    { 5, 0, "5ed4fdeb-b96d-4436-bda1-5787d80a6fe3", "Vivienne.Reynolds@yahoo.com", true, false, null, "Lincoln Schamberger", null, null, null, "(397) 905-1534 x9404", false, "841ed844-c94d-49f7-a613-3cc51c6142db", false, "Vivienne.Reynolds@yahoo.com" },
                    { 6, 0, "b7c1cb4c-7cba-4488-85c7-217e202b6e8f", "Green_Windler@yahoo.com", true, false, null, "Emmanuel Kunze", null, null, null, "(925) 688-7090 x47168", false, "434bd146-135f-416e-90c8-3087a3b3913b", false, "Green_Windler@yahoo.com" },
                    { 7, 0, "7919fd14-978b-4f56-b025-abdb7d111dba", "Karianne.Goldner@yahoo.com", true, false, null, "Retha Funk", null, null, null, "618-377-2302 x52496", false, "1e801f2f-76fd-4957-b155-94dfaa19f3b1", false, "Karianne.Goldner@yahoo.com" },
                    { 8, 0, "ca1ad28a-731f-4dd3-9830-b9b623c1ed93", "Lorine.Fisher94@yahoo.com", true, false, null, "Stephan Lynch", null, null, null, "910-316-7357 x631", false, "46a62ab1-b180-4e7e-818e-34b2a31d36bb", false, "Lorine.Fisher94@yahoo.com" },
                    { 9, 0, "863bee0d-c78f-4d5b-a160-1813afc50645", "Cassie47@gmail.com", true, false, null, "Tabitha Koch", null, null, null, "1-238-987-9828 x803", false, "e8cc8f1d-5c48-49e3-be95-530786c078ed", false, "Cassie47@gmail.com" },
                    { 10, 0, "2b9520b5-a6e9-4a01-af56-3943a3b9ab91", "Tyler_Becker@gmail.com", true, false, null, "Fiona Hartmann", null, null, null, "1-686-330-8695 x781", false, "8c3f1738-6083-4ec4-ad1c-05e31aee1aac", false, "Tyler_Becker@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Quo provident ducimus sunt molestiae laborum velit eaque et. Fugiat qui ut. Eius et et quod et totam. Ea deserunt et nihil expedita ut voluptas et id.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(3777), false, "Arnulfo Cremin", null },
                    { 2, "Voluptatibus deleniti asperiores quibusdam. Odit quis perferendis minima. Veniam earum exercitationem nesciunt veniam commodi doloribus natus. Modi quidem cum minus. Sit rem consectetur dolores provident tempore debitis.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4135), false, "Sabrina Hoppe", null },
                    { 3, "Modi dolores at deserunt et sit voluptas dolorum. Explicabo natus et. Ut magnam rem nam temporibus dicta.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4284), false, "Jeffry Koepp", null },
                    { 4, "Possimus ex vitae repellendus incidunt. Et ut est qui et. Nihil ipsum aut repudiandae fuga et provident accusantium rem. Aut error veritatis quaerat facere nobis facilis. Numquam ducimus sint dolorem asperiores reprehenderit sit non impedit. Non voluptatem eos qui sit voluptatibus quod quidem.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4355), false, "Laurine Adams", null },
                    { 5, "Hic corporis odit soluta ipsum occaecati consequatur aut impedit aut. Ut et ullam provident tempore illum nemo et itaque eos. Error quidem ab sequi fuga alias eaque minima sapiente.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4531), false, "Chelsea Jones", null },
                    { 6, "Voluptatem beatae veritatis inventore voluptatem et molestias repudiandae aperiam. In ut ea delectus et. Et rerum sit voluptate magnam ea dolor ipsa nihil. Ea repudiandae beatae laborum eum. Ipsa inventore reiciendis nisi repellendus natus officiis velit laudantium. Est sint aut ex consequatur cumque et ullam quasi.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4616), false, "Virginia Funk", null },
                    { 7, "Asperiores at debitis eius debitis possimus tempore. Voluptatem tenetur a autem dolor libero officia ut. Voluptatum eum tempore corporis rerum qui. Enim rerum porro. Et nemo pariatur quae molestias rerum sit nihil officia.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4781), false, "Freda Homenick", null },
                    { 8, "Eaque voluptatum est omnis quo consequatur vel voluptatem et aliquid. Enim et laboriosam. Autem labore aut ipsam.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4891), false, "Kyra Walsh", null },
                    { 9, "Veniam dolorem magnam est dignissimos. Ipsum omnis consectetur sunt tempora reprehenderit voluptatem aspernatur doloribus quaerat. Consequatur officiis recusandae soluta veritatis et inventore neque. Esse dolores asperiores et est aspernatur ipsum.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(4949), false, "Cortney Pfeffer", null },
                    { 10, "Error omnis ut excepturi alias. Corporis nesciunt sint aliquam enim ut. Porro sint reprehenderit. Corrupti quia eaque natus optio est quia omnis consectetur voluptas.", new DateTime(2024, 12, 10, 23, 8, 25, 135, DateTimeKind.Utc).AddTicks(5109), false, "Kris Rippin", null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Minima quam sit." },
                    { 2, "Itaque vitae sed." },
                    { 3, "Iusto suscipit dignissimos." },
                    { 4, "Autem a vel." },
                    { 5, "Laboriosam est perspiciatis." },
                    { 6, "Illum pariatur aliquid." }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Eveniet dolores voluptas et. Quo tempore ipsum enim voluptatibus molestiae accusantium. Vel et incidunt quis aut ut omnis. Quia quia cupiditate quia. Incidunt quibusdam est.", new DateTime(2024, 12, 10, 23, 8, 25, 136, DateTimeKind.Utc).AddTicks(9969), false, "Wiza LLC", null },
                    { 2, "Rerum quo sit. Architecto doloribus voluptatem. Atque velit sed voluptatem. Voluptatum delectus est rem alias culpa.", new DateTime(2024, 12, 10, 23, 8, 25, 137, DateTimeKind.Utc).AddTicks(590), false, "Kris - Wilkinson", null },
                    { 3, "Fugit aliquam sunt dolorem possimus aut hic nam. Aliquam placeat et sapiente possimus et recusandae. Esse et ipsa mollitia autem voluptatem nesciunt optio. Vel eius consequatur voluptatibus aut alias quis. Iste voluptate consequatur consectetur iusto rem aut facere. Omnis non quas nihil ipsa aut.", new DateTime(2024, 12, 10, 23, 8, 25, 137, DateTimeKind.Utc).AddTicks(783), false, "Kovacek - Lebsack", null },
                    { 4, "Fugiat totam consequatur velit iusto. Iusto vel tenetur velit ullam qui suscipit est. Itaque qui voluptatem est nemo aut ex vero. Et qui cumque non officia fugiat at non dolore.", new DateTime(2024, 12, 10, 23, 8, 25, 137, DateTimeKind.Utc).AddTicks(1004), false, "Effertz Group", null },
                    { 5, "Autem tempore necessitatibus nobis facilis. Dolores suscipit et sequi ut. Corrupti est est. Qui officiis voluptas non voluptatibus porro dolores. Quas veniam hic qui consequatur laborum qui.", new DateTime(2024, 12, 10, 23, 8, 25, 137, DateTimeKind.Utc).AddTicks(1185), false, "Green LLC", null }
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
                    { 1, 2, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(1919), "Consectetur tempore aliquam et iusto sint et qui. Et ut ullam. Autem laborum sequi temporibus ad tempore. Commodi debitis dicta voluptatibus laborum libero odit quia accusamus optio. Et qui incidunt pariatur repellendus illum harum. Nobis ducimus enim.", 0, "https://picsum.photos/640/480/?image=308", false, null, 96.32m, 3, 3, "Tempora repellat tenetur.", null },
                    { 2, 1, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(3493), "Et dolorem ipsum explicabo rerum odio autem. Recusandae aut quae est aut accusamus quisquam ea adipisci. Voluptatibus omnis voluptas illum pariatur magnam inventore eum animi sunt. Et maxime inventore fugit.", 0, "https://picsum.photos/640/480/?image=139", false, null, 11.58m, 6, 5, "Provident porro id.", null },
                    { 3, 10, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(3738), "Velit aut voluptatem quasi at sint velit rerum et. Quidem autem hic consequatur at autem. Ratione aliquam amet architecto excepturi voluptas non. Aut voluptatum aut impedit vel eius id sunt. Odio sit et explicabo.", 0, "https://picsum.photos/640/480/?image=461", false, null, 52.33m, 4, 1, "In voluptatem quas.", null },
                    { 4, 8, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(3864), "Et dicta non fugiat laborum est sed voluptatem ea. Voluptas eius nulla sed et. Doloremque inventore quis veritatis maxime corporis est debitis. Ab voluptas amet hic saepe dolores ea et. Veritatis eveniet labore dolor quas est aut. Veritatis fugit nisi sit.", 0, "https://picsum.photos/640/480/?image=94", false, null, 84.05m, 6, 1, "Non in et.", null },
                    { 5, 4, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4031), "Culpa blanditiis nobis quia consequatur distinctio harum. Quo quidem blanditiis omnis ut omnis eveniet quisquam ad. Enim id neque qui eius labore temporibus accusamus et qui. Voluptas iure unde fugit perferendis reiciendis rerum.", 0, "https://picsum.photos/640/480/?image=538", false, null, 20.18m, 2, 1, "Quaerat magnam vel.", null },
                    { 6, 5, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4165), "Et rerum explicabo amet velit voluptatem officia sequi excepturi praesentium. Nulla doloribus officia ex deserunt iste. Ab ut adipisci quisquam quam magnam eligendi vel repellat.", 0, "https://picsum.photos/640/480/?image=782", false, null, 73.81m, 3, 1, "Tempora odit nobis.", null },
                    { 7, 3, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4246), "Repellat repellendus eligendi voluptatem ea iusto qui ullam amet ab. Iste qui quaerat omnis error. Et nam deleniti laudantium et eos quos vel qui perferendis. Non ex voluptate ut molestiae. Consequatur quis iste iusto. Commodi aut assumenda.", 0, "https://picsum.photos/640/480/?image=239", false, null, 96.41m, 6, 1, "Voluptas accusamus alias.", null },
                    { 8, 3, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4392), "Quia quo natus doloremque et et rerum adipisci et. Laboriosam quae corporis. Dolorem odio culpa cum voluptatem. Minus id corporis quia quia perspiciatis voluptas eveniet ut. Eos esse cupiditate ducimus impedit delectus modi aut consequatur.", 0, "https://picsum.photos/640/480/?image=746", false, null, 77.49m, 5, 2, "Cum architecto distinctio.", null },
                    { 9, 4, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4526), "Magni voluptatem veniam ratione. Sint adipisci natus sed quos. Impedit minus labore modi consequuntur voluptatem rerum veritatis voluptatibus.", 0, "https://picsum.photos/640/480/?image=400", false, null, 68.35m, 6, 5, "Soluta dicta aut.", null },
                    { 10, 8, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4617), "Ut eos libero recusandae quasi a sunt unde dolorem praesentium. Corrupti laborum sint alias nostrum. Rerum officia eligendi quasi voluptate quae eaque. Et ullam consequatur culpa. Sit sequi sint. Debitis et voluptas.", 0, "https://picsum.photos/640/480/?image=616", false, null, 53.15m, 2, 2, "Impedit quae placeat.", null },
                    { 11, 7, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4717), "Necessitatibus facilis voluptatibus aut. Veniam iusto rerum. Omnis omnis et qui sapiente quaerat. Atque dolorem aut aut omnis vel sed nihil. Magnam rerum repudiandae debitis molestiae odio ex impedit non aspernatur.", 0, "https://picsum.photos/640/480/?image=750", false, null, 65.46m, 6, 1, "Quia voluptate non.", null },
                    { 12, 5, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4835), "Blanditiis repudiandae voluptatem qui id. Tempore voluptatum ut. Veniam vero inventore modi aut suscipit sed provident. Sint temporibus voluptate quas. Dolorem accusantium voluptatem. Rerum quo est.", 0, "https://picsum.photos/640/480/?image=207", false, null, 10.07m, 4, 4, "Eum in voluptatibus.", null },
                    { 13, 6, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(4939), "Voluptatibus rerum odit velit quasi harum libero. Dolor tempore quaerat laboriosam quas voluptatem delectus molestiae sunt voluptate. Debitis rerum tempora vitae laboriosam et ut. Magnam optio atque quia.", 0, "https://picsum.photos/640/480/?image=101", false, null, 14.74m, 5, 1, "Cumque sed molestiae.", null },
                    { 14, 3, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5073), "Corporis et blanditiis eos. Quia placeat quo nesciunt esse accusantium nulla nisi. Ut quasi eum. Est hic qui tenetur non.", 0, "https://picsum.photos/640/480/?image=250", false, null, 88.44m, 6, 2, "Nulla non eligendi.", null },
                    { 15, 2, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5146), "Aspernatur nihil cupiditate sequi perspiciatis voluptatibus neque tempora sed. In non sunt odit qui qui mollitia est. Molestias aut excepturi vel.", 0, "https://picsum.photos/640/480/?image=906", false, null, 51.08m, 2, 4, "Minus veritatis voluptas.", null },
                    { 16, 10, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5248), "Voluptatem quia fuga ipsa velit dignissimos. Dignissimos tenetur sequi est. Nulla voluptate adipisci. Recusandae quas quaerat est itaque quae id sapiente voluptatem esse. Doloribus et repellendus.", 0, "https://picsum.photos/640/480/?image=773", false, null, 56.92m, 3, 5, "Ut rerum blanditiis.", null },
                    { 17, 3, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5331), "Labore temporibus reprehenderit provident quas sit totam repellat. Quia facere autem dolor doloremque iste. Voluptatibus saepe numquam expedita rerum repellendus rerum cum. Animi ducimus sequi. Tenetur cupiditate omnis accusamus. Dolore sit doloribus rerum ea et rerum.", 0, "https://picsum.photos/640/480/?image=704", false, null, 18.36m, 3, 1, "Quasi cumque labore.", null },
                    { 18, 7, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5478), "Minus quia ut et temporibus qui sed possimus quidem. Amet ut et in. Blanditiis deleniti nesciunt est qui aut officiis consequatur numquam quam. Minus necessitatibus nam.", 0, "https://picsum.photos/640/480/?image=1012", false, null, 85.57m, 3, 3, "Fugiat illo qui.", null },
                    { 19, 6, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5586), "Dolorem accusantium blanditiis nihil ipsam vitae temporibus eius aut beatae. Et consequatur magnam vitae ut nisi temporibus. Enim commodi dolore.", 0, "https://picsum.photos/640/480/?image=513", false, null, 96.35m, 5, 2, "Iusto dolorem quisquam.", null },
                    { 20, 7, new DateTime(2024, 12, 10, 23, 8, 25, 140, DateTimeKind.Utc).AddTicks(5693), "Ea odio occaecati consectetur ducimus velit ut eos accusamus quia. Alias non et eum et dolor id beatae. Aut minima corporis. Quos repellendus ullam enim. Sed qui et qui fugit ut. Vitae quasi autem similique vel.", 0, "https://picsum.photos/640/480/?image=944", false, null, 94.87m, 4, 5, "Earum expedita delectus.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2632), false, null, 2 },
                    { 3, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2633), false, null, 3 },
                    { 4, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2633), false, null, 4 },
                    { 5, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2633), false, null, 5 },
                    { 6, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2633), false, null, 6 },
                    { 7, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2633), false, null, 7 },
                    { 8, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2634), false, null, 8 },
                    { 9, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2634), false, null, 9 },
                    { 10, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2634), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "OrderState", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 12, new DateTime(2024, 12, 10, 23, 8, 25, 146, DateTimeKind.Utc).AddTicks(4295), "Loren_Bode18@gmail.com", "Loren Bode", false, 2, 12, 0m, null, 2 },
                    { 2, 7, new DateTime(2024, 12, 10, 23, 8, 25, 146, DateTimeKind.Utc).AddTicks(7699), "Lois.Lindgren@gmail.com", "Lois Lindgren", false, 1, 1, 0m, null, 5 },
                    { 3, 14, new DateTime(2024, 12, 10, 23, 8, 25, 146, DateTimeKind.Utc).AddTicks(8848), "Connie16@gmail.com", "Connie Kovacek", false, 5, 1, 0m, null, 7 },
                    { 4, 5, new DateTime(2024, 12, 10, 23, 8, 25, 146, DateTimeKind.Utc).AddTicks(9627), "Emily18@gmail.com", "Emily Fisher", false, 3, 9, 0m, null, 2 },
                    { 5, 5, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(326), "Jane_Wunsch41@yahoo.com", "Jane Wunsch", false, 3, 7, 0m, null, 9 },
                    { 6, 15, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(944), "Joseph83@yahoo.com", "Joseph Swift", false, 4, 4, 0m, null, 2 },
                    { 7, 9, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(1608), "Stella.Hickle@hotmail.com", "Stella Hickle", false, 0, 4, 0m, null, 3 },
                    { 8, 8, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(2265), "Audrey94@gmail.com", "Audrey Reinger", false, 3, 12, 0m, null, 3 },
                    { 9, 12, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(2906), "Dale28@hotmail.com", "Dale Thompson", false, 1, 11, 0m, null, 3 },
                    { 10, 9, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(3527), "Cornelius_Kunde@hotmail.com", "Cornelius Kunde", false, 0, 8, 0m, null, 4 },
                    { 11, 13, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(4147), "Randolph34@hotmail.com", "Randolph Hermann", false, 4, 13, 0m, null, 4 },
                    { 12, 2, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(4741), "Ernestine37@gmail.com", "Ernestine Kutch", false, 4, 14, 0m, null, 9 },
                    { 13, 14, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(5442), "Sheldon.Kuhic59@gmail.com", "Sheldon Kuhic", false, 2, 4, 0m, null, 3 },
                    { 14, 4, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(6066), "Oliver.Williamson@yahoo.com", "Oliver Williamson", false, 1, 7, 0m, null, 9 },
                    { 15, 2, new DateTime(2024, 12, 10, 23, 8, 25, 147, DateTimeKind.Utc).AddTicks(6639), "Della65@yahoo.com", "Della Blick", false, 0, 8, 0m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 12, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(644), false, 4, 19.08m, 2, null },
                    { 2, 18, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(1931), false, 7, 55.31m, 1, null },
                    { 3, 20, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(1982), false, 8, 48.32m, 3, null },
                    { 4, 12, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(1992), false, 14, 21.75m, 2, null },
                    { 5, 1, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2000), false, 15, 97.50m, 1, null },
                    { 6, 18, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2008), false, 6, 38.47m, 3, null },
                    { 7, 4, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2015), false, 13, 42.43m, 2, null },
                    { 8, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2023), false, 1, 42.45m, 3, null },
                    { 9, 19, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2030), false, 9, 81.27m, 1, null },
                    { 10, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2038), false, 8, 59.72m, 2, null },
                    { 11, 12, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2045), false, 13, 20.47m, 1, null },
                    { 12, 5, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2052), false, 7, 78.21m, 1, null },
                    { 13, 14, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2059), false, 15, 90.63m, 1, null },
                    { 14, 12, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2066), false, 15, 91.50m, 1, null },
                    { 15, 3, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2074), false, 14, 22.57m, 3, null },
                    { 16, 16, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2080), false, 9, 48.24m, 3, null },
                    { 17, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2087), false, 10, 40.03m, 2, null },
                    { 18, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2094), false, 13, 98.65m, 1, null },
                    { 19, 5, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2129), false, 7, 85.03m, 1, null },
                    { 20, 19, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2142), false, 12, 46.68m, 3, null },
                    { 21, 5, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2153), false, 9, 55.39m, 1, null },
                    { 22, 10, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2164), false, 14, 75.63m, 2, null },
                    { 23, 15, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2213), false, 9, 32.78m, 3, null },
                    { 24, 1, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2225), false, 11, 45.85m, 1, null },
                    { 25, 2, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2233), false, 11, 24.81m, 1, null },
                    { 26, 2, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2240), false, 8, 68.69m, 1, null },
                    { 27, 20, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2247), false, 7, 87.34m, 2, null },
                    { 28, 4, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2255), false, 13, 96.79m, 2, null },
                    { 29, 10, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2262), false, 15, 59.10m, 2, null },
                    { 30, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2269), false, 6, 32.62m, 3, null },
                    { 31, 6, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2276), false, 15, 54.46m, 3, null },
                    { 32, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2283), false, 12, 36.71m, 2, null },
                    { 33, 11, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2290), false, 2, 23.96m, 2, null },
                    { 34, 17, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2297), false, 10, 85.22m, 2, null },
                    { 35, 15, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2304), false, 14, 29.51m, 3, null },
                    { 36, 7, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2311), false, 8, 13.72m, 2, null },
                    { 37, 7, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2317), false, 5, 75.83m, 2, null },
                    { 38, 2, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2325), false, 5, 93.70m, 3, null },
                    { 39, 3, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2332), false, 9, 10.18m, 2, null },
                    { 40, 3, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2341), false, 13, 48.49m, 1, null },
                    { 41, 20, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2347), false, 15, 64.68m, 3, null },
                    { 42, 9, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2354), false, 13, 15.32m, 1, null },
                    { 43, 12, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2362), false, 4, 17.79m, 1, null },
                    { 44, 14, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2368), false, 14, 56.87m, 2, null },
                    { 45, 11, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2377), false, 9, 76.76m, 1, null },
                    { 46, 19, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2389), false, 9, 65.44m, 2, null },
                    { 47, 15, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2396), false, 7, 31.61m, 1, null },
                    { 48, 9, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2408), false, 8, 75.76m, 1, null },
                    { 49, 11, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2415), false, 13, 87.94m, 1, null },
                    { 50, 19, new DateTime(2024, 12, 10, 23, 8, 25, 149, DateTimeKind.Utc).AddTicks(2425), false, 12, 49.48m, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 18, "Incidunt voluptate distinctio culpa iusto.", new DateTime(2024, 12, 10, 23, 8, 25, 141, DateTimeKind.Utc).AddTicks(9671), false, 5, null, 3 },
                    { 2, 1, "Nulla voluptates eum cupiditate quos tempora dolor.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(797), false, 1, null, 8 },
                    { 3, 12, "Quasi reiciendis quia quo repellat omnis et impedit est quo.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(871), false, 4, null, 8 },
                    { 4, 19, "Quis animi doloribus.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(903), false, 3, null, 5 },
                    { 5, 3, "Numquam fuga voluptas.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(915), false, 4, null, 2 },
                    { 6, 7, "Dolor porro nam ducimus cumque qui.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(927), false, 3, null, 5 },
                    { 7, 1, "Quibusdam laudantium vel aliquam nisi.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(945), false, 1, null, 4 },
                    { 8, 17, "Ipsa sed non.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(967), false, 3, null, 5 },
                    { 9, 18, "Debitis ratione quam sed eveniet ullam earum dolores nobis impedit.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1061), false, 5, null, 8 },
                    { 10, 19, "Quia aut dolor aliquam sed tenetur aut molestias.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1091), false, 1, null, 4 },
                    { 11, 17, "Dolorum voluptatem rerum ut eius voluptatem.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1115), false, 2, null, 3 },
                    { 12, 20, "Sit quam perferendis sit nesciunt.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1135), false, 4, null, 6 },
                    { 13, 10, "Ut eaque aut.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1152), false, 4, null, 9 },
                    { 14, 14, "Mollitia quia tenetur saepe harum sint culpa veniam in.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1165), false, 2, null, 8 },
                    { 15, 3, "Fugiat accusamus quia blanditiis saepe atque quis.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1190), false, 4, null, 9 },
                    { 16, 9, "Iste autem aspernatur accusantium et sunt eum veritatis autem.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1209), false, 5, null, 7 },
                    { 17, 19, "Vel aut soluta blanditiis cumque nam qui quia.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1266), false, 2, null, 4 },
                    { 18, 17, "Qui quia dolorem beatae saepe dolores commodi aliquid molestiae.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1289), false, 5, null, 2 },
                    { 19, 10, "Amet quos et qui minima reiciendis maxime sequi.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1313), false, 2, null, 9 },
                    { 20, 16, "Temporibus quis consequatur sapiente quia ipsa voluptas.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1334), false, 2, null, 10 },
                    { 21, 3, "Omnis aliquam illo impedit.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1352), false, 3, null, 7 },
                    { 22, 12, "Consequatur et fugit autem similique.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1368), false, 3, null, 10 },
                    { 23, 1, "Non aut voluptas nihil enim pariatur tempore quas.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1386), false, 5, null, 7 },
                    { 24, 12, "Odit vitae enim velit eaque rem sint optio molestias.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1410), false, 4, null, 3 },
                    { 25, 13, "Molestiae cum vel ab.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1459), false, 3, null, 6 },
                    { 26, 13, "Qui ab impedit molestias error iste placeat cum ut qui.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1475), false, 4, null, 3 },
                    { 27, 13, "Harum eos sunt consequatur excepturi sunt natus voluptas corporis.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1499), false, 3, null, 8 },
                    { 28, 18, "In odio odio fuga quibusdam et eaque quo veritatis.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1521), false, 3, null, 3 },
                    { 29, 4, "Vel at laborum quas unde qui doloremque.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1542), false, 5, null, 8 },
                    { 30, 5, "Iusto sit provident.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1562), false, 3, null, 5 },
                    { 31, 18, "Quaerat ea dolore saepe delectus ea itaque temporibus sint illo.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1574), false, 2, null, 2 },
                    { 32, 13, "Aut voluptatem soluta necessitatibus ea impedit.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1622), false, 4, null, 5 },
                    { 33, 8, "Quia itaque provident voluptatem ducimus sit sunt at itaque.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1644), false, 2, null, 8 },
                    { 34, 6, "Placeat aut eos blanditiis.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1668), false, 4, null, 7 },
                    { 35, 10, "Autem tempora possimus rerum ipsam possimus molestiae possimus sed.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1683), false, 1, null, 7 },
                    { 36, 3, "Fugit sapiente et.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1706), false, 1, null, 9 },
                    { 37, 13, "Rerum laudantium repellat vel ut nihil omnis culpa animi vel.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1719), false, 1, null, 2 },
                    { 38, 5, "Nam hic aut omnis voluptas voluptates.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1742), false, 2, null, 5 },
                    { 39, 14, "Voluptates rerum ex rerum et.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1759), false, 5, null, 4 },
                    { 40, 18, "Aut rerum omnis eos asperiores.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1799), false, 5, null, 7 },
                    { 41, 4, "Id sed excepturi esse asperiores repudiandae placeat ut.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1817), false, 3, null, 2 },
                    { 42, 2, "Dolorem nisi et ut.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1840), false, 2, null, 10 },
                    { 43, 3, "Ipsum ut recusandae magni ea et officia et.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1855), false, 5, null, 8 },
                    { 44, 9, "Consequatur tempora aut sapiente rerum eos autem iusto.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1876), false, 3, null, 5 },
                    { 45, 5, "Dignissimos velit nostrum error ea velit.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1896), false, 1, null, 3 },
                    { 46, 8, "Aut nesciunt autem odit consectetur voluptates.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1914), false, 2, null, 10 },
                    { 47, 17, "Sit ut maxime veniam accusamus numquam velit.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1931), false, 2, null, 4 },
                    { 48, 19, "Sed animi mollitia omnis.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1974), false, 5, null, 2 },
                    { 49, 4, "Odit sit sunt ut non.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(1989), false, 5, null, 5 },
                    { 50, 17, "Magnam numquam delectus qui vitae assumenda ducimus libero.", new DateTime(2024, 12, 10, 23, 8, 25, 142, DateTimeKind.Utc).AddTicks(2005), false, 5, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 9, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5200), false, null, 5 },
                    { 2, 1, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5347), false, null, 8 },
                    { 3, 6, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5354), false, null, 8 },
                    { 4, 14, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5357), false, null, 8 },
                    { 5, 13, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5360), false, null, 2 },
                    { 6, 13, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5362), false, null, 7 },
                    { 7, 14, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5365), false, null, 10 },
                    { 8, 20, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5368), false, null, 5 },
                    { 9, 6, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5371), false, null, 6 },
                    { 10, 7, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5374), false, null, 9 },
                    { 11, 16, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5376), false, null, 8 },
                    { 12, 3, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5379), false, null, 6 },
                    { 13, 13, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5382), false, null, 10 },
                    { 14, 8, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5384), false, null, 5 },
                    { 15, 7, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5416), false, null, 9 },
                    { 16, 13, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5421), false, null, 2 },
                    { 17, 10, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5424), false, null, 10 },
                    { 18, 20, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5427), false, null, 2 },
                    { 19, 3, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5429), false, null, 7 },
                    { 20, 3, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5432), false, null, 5 },
                    { 21, 3, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5435), false, null, 4 },
                    { 22, 8, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5438), false, null, 8 },
                    { 23, 20, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5441), false, null, 10 },
                    { 24, 5, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5444), false, null, 10 },
                    { 25, 4, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5447), false, null, 4 },
                    { 26, 12, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5449), false, null, 4 },
                    { 27, 5, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5453), false, null, 7 },
                    { 28, 8, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5455), false, null, 7 },
                    { 29, 10, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5458), false, null, 4 },
                    { 30, 11, new DateTime(2024, 12, 10, 23, 8, 25, 143, DateTimeKind.Utc).AddTicks(5461), false, null, 5 }
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
