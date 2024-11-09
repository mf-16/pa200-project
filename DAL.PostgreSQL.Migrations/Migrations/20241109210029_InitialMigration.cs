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
                    Genre = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
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
                    { 1, "Lefflerborough", "Fiji", new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(8783), false, "Wisconsin", "5695 Marjorie Burgs", null, "41271-2994" },
                    { 2, "South Marianna", "Cocos (Keeling) Islands", new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(9522), false, "Minnesota", "15584 Keeling Junction", null, "13512" },
                    { 3, "Eliseoshire", "Zimbabwe", new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(9699), false, "New Jersey", "146 Reichel Terrace", null, "51676-7184" },
                    { 4, "Darioside", "Netherlands Antilles", new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(9838), false, "Utah", "5426 Murray Underpass", null, "14371-3426" },
                    { 5, "Port Margaretteburgh", "Zimbabwe", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(28), false, "Louisiana", "34748 Tremayne Forest", null, "36249-6315" },
                    { 6, "North Vernie", "Western Sahara", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(201), false, "New Mexico", "66654 Smith Ridge", null, "44021-1608" },
                    { 7, "Rahsaanbury", "Burkina Faso", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(333), false, "Colorado", "17979 Hand Knoll", null, "84392" },
                    { 8, "East Jewelland", "Libyan Arab Jamahiriya", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(465), false, "Indiana", "3536 Rogelio Locks", null, "86806-6886" },
                    { 9, "Hintzchester", "Finland", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(614), false, "Rhode Island", "86993 Golda Circles", null, "88887-9100" },
                    { 10, "South Sylvesterbury", "Spain", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(754), false, "Indiana", "16645 Ritchie Passage", null, "45352-0359" },
                    { 11, "North Leopold", "Marshall Islands", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1268), false, "Kentucky", "13928 Ari Walks", null, "61538" },
                    { 12, "North Ayden", "Panama", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1392), false, "Kentucky", "3303 Denesik Shore", null, "14970" },
                    { 13, "Wilfridmouth", "South Africa", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1546), false, "Massachusetts", "8681 Stracke Gardens", null, "63326-0045" },
                    { 14, "Feeneyside", "Haiti", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1708), false, "Rhode Island", "642 Jerel Ford", null, "27394-0928" },
                    { 15, "North Tiffany", "Cambodia", new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1835), false, "Ohio", "8748 Monique Islands", null, "75886-4496" }
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
                    { 1, 0, "1d7aa11f-1e47-4d15-9139-a3202e16e5e0", "admin@admin.com", true, false, null, "Admin User", null, "ADMIN", null, "123-456-7890", false, "6315ff0e-b974-49ec-9c75-67dc803278e7", false, "admin" },
                    { 2, 0, "838e0d2c-77bf-4b37-a1f6-3b67411cbb60", "Hiram.Adams@yahoo.com", true, false, null, "Juliana Hand", null, null, null, "1-289-832-6441 x008", false, "c0c3db00-12f7-4657-b979-385113e80f0c", false, "Mustafa.Larkin33" },
                    { 3, 0, "71c64bb0-6663-4813-9999-abb334e10fa6", "Cordelia.Hessel93@gmail.com", true, false, null, "Braulio Morar", null, null, null, "221.534.0977 x60962", false, "721d421c-cac0-4820-aaee-2b76da733a0a", false, "Cole_Huel" },
                    { 4, 0, "c3244163-d105-4b87-b211-4e88b13e7134", "Oma68@yahoo.com", true, false, null, "Fletcher Davis", null, null, null, "203.880.8063 x22710", false, "e06299a9-7677-4c21-aac4-d5ed4a0e457e", false, "Emmett.Moore" },
                    { 5, 0, "26b7ccb2-3699-48a1-a1bf-fbc7e0117ecb", "Herman_Veum63@gmail.com", true, false, null, "Willy Jacobi", null, null, null, "1-373-441-8199", false, "78d22e37-db7b-4924-8323-51234faa3f86", false, "Zoey_Greenfelder" },
                    { 6, 0, "734cf6d0-2b13-421c-88ff-57dd9e1dcfee", "Amina_King@yahoo.com", true, false, null, "Melba Hansen", null, null, null, "(218) 395-4438", false, "adba5717-10f9-40fd-bf22-a776d68e1f86", false, "Frances15" },
                    { 7, 0, "00c52566-d4d1-4390-b13b-922776ad4ad1", "Kendra.McClure96@yahoo.com", true, false, null, "Dalton Wiegand", null, null, null, "688.813.3612 x6438", false, "b3b08d53-02bc-4e7d-bc7e-1443b48a55c9", false, "Jordy64" },
                    { 8, 0, "a6f5180c-51ba-4709-b568-a85e46ff174d", "Nasir_Feest@hotmail.com", true, false, null, "Lazaro Dibbert", null, null, null, "588-982-6895", false, "89a316ec-9746-4b4f-9239-d01b2aa436ac", false, "Annetta64" },
                    { 9, 0, "9a58c1af-dfbe-45ec-ba64-0d84165af791", "Arch.Orn89@gmail.com", true, false, null, "Mariano Farrell", null, null, null, "937-349-0078 x48080", false, "5c72bcc5-f25f-42dc-993d-badb0a56f702", false, "Cale93" },
                    { 10, 0, "d8dc519b-7d90-45f8-8a97-615da2529e92", "Ines.Miller@hotmail.com", true, false, null, "Layla Rice", null, null, null, "1-282-435-2580", false, "30fb67c8-0a43-45f0-8f49-f312f7b59e48", false, "Ida37" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Nesciunt fuga nemo reiciendis quia ut. Placeat fugiat pariatur eius distinctio qui sit veritatis. Et asperiores doloremque temporibus exercitationem. Omnis voluptate magni ab qui.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(6801), false, "Tanner Reinger", null },
                    { 2, "Eos et consequatur id ea et sed tempore. Commodi cupiditate voluptatem quasi consectetur est repellat omnis voluptatem eaque. Doloremque ut et sapiente voluptatem. Adipisci veniam ratione voluptates at debitis reprehenderit. Perferendis omnis distinctio. Dignissimos maiores illo aut aliquid voluptatibus quis voluptatum.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7193), false, "Kenny Botsford", null },
                    { 3, "Fuga nesciunt reiciendis qui iste omnis facere earum vel. Culpa architecto eligendi iusto illo dolorem. Ut illo et est enim officia inventore similique velit voluptas. Molestiae at aliquam iusto.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7434), false, "Michaela Deckow", null },
                    { 4, "Ad asperiores occaecati sed dignissimos autem. Eaque perspiciatis rerum modi. Temporibus aliquam atque sint tenetur aperiam itaque et eius. Quia modi quae neque rerum quod hic. Quas occaecati explicabo ipsam aut consequatur eos. Asperiores nihil ullam facere.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7589), false, "Marian Veum", null },
                    { 5, "Veniam odio exercitationem officiis. Quibusdam quam cum voluptas et consequuntur veniam. Molestiae corrupti officia aut quia qui. Quisquam at consequatur soluta assumenda facilis. Deserunt vel placeat dicta.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7747), false, "Nia Rohan", null },
                    { 6, "Aperiam numquam quia occaecati alias fugiat blanditiis sed voluptatem. Tempore nisi voluptatibus eum amet excepturi. Repudiandae quo voluptate ea est nihil dolorem doloribus. Qui quod sapiente.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7878), false, "Arno Goodwin", null },
                    { 7, "Iste ipsum voluptatem dolores. Voluptatum quisquam facilis. Architecto a autem rem modi sit. Distinctio qui consequatur.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7989), false, "Ophelia Senger", null },
                    { 8, "Itaque ut a consequuntur et cum beatae sed quisquam. Tempora libero aut porro voluptatem minus ut dolorem. Ut vel dicta ratione accusamus id non qui quia. Nostrum ratione nemo qui sed optio. Nobis amet ut dolore dicta aliquid qui eum error.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(8128), false, "Kobe Kuhic", null },
                    { 9, "Molestiae omnis illum enim eum neque soluta inventore. Illo enim repellendus sint eveniet. Et eius eos quae repellendus.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(8257), false, "Kristina Kemmer", null },
                    { 10, "Iste consectetur eveniet mollitia et laudantium porro aut. Molestias porro aut exercitationem rerum. Qui explicabo beatae quia quia. Laborum vitae consequatur sit maxime qui praesentium ut.", new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(8369), false, "Neal Wunsch", null }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Facilis et at iusto. Quae id quaerat magni veritatis voluptatem voluptas enim sint est. Amet voluptas quo sunt nulla nihil. Saepe ut laudantium est suscipit libero corrupti voluptatem nostrum vel. Natus voluptatem ipsa.", new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(366), false, "Waelchi, Cartwright and Rippin", null },
                    { 2, "Quia facere mollitia maxime a exercitationem praesentium totam voluptatem aut. Voluptatem recusandae quam et. Dolorem vel placeat reprehenderit ut ut.", new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1210), false, "Funk Inc", null },
                    { 3, "Laboriosam culpa sed quaerat voluptas rerum doloribus velit. Quis explicabo et. In maxime est quia nam cumque quas. Nam quia nesciunt velit tenetur. Aperiam culpa sapiente. Vero distinctio deleniti dicta aliquam in et aliquam.", new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1468), false, "Haley Group", null },
                    { 4, "Neque molestiae qui molestiae et repudiandae ab. Fugiat numquam ipsam. Asperiores rem consequatur voluptatem aut minus maiores. Aspernatur expedita laborum nihil earum quo non est qui id. Sit aut est natus nisi ipsum culpa.", new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1693), false, "Kertzmann, Mante and Satterfield", null },
                    { 5, "Odio cumque velit eum vel ut optio magnam numquam. Harum eum et alias vel voluptatem nesciunt maiores est nihil. Temporibus quos ipsam vero minus nisi vel et sit ad. Inventore temporibus reprehenderit omnis sed et minima eligendi. Sit aliquam unde excepturi esse est nam.", new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1931), false, "Stanton - Johns", null }
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
                columns: new[] { "Id", "AuthorId", "CreatedDate", "Description", "Genre", "ImagePath", "IsDeleted", "Price", "PublisherId", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(4602), "Rem quasi similique dolorem est ad cum. Magni vero cupiditate dicta nobis sint adipisci. Magnam aut magnam. Asperiores quo eaque dolor.", 3, "https://picsum.photos/640/480/?image=56", false, 43.97m, 2, "Consequatur minus molestiae.", null },
                    { 2, 1, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7035), "Odio provident vel dolores quo quia voluptate non. Nesciunt nam expedita maxime dolorem asperiores officiis recusandae. In qui dolore. Cumque nam veniam. Sequi omnis aliquid aut accusantium sed enim dolores tempore. Voluptatibus numquam aperiam.", 7, "https://picsum.photos/640/480/?image=208", false, 44.85m, 3, "Eius rerum debitis.", null },
                    { 3, 7, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7242), "Totam tempora rerum. Dolorem id occaecati laboriosam assumenda consequatur maiores dignissimos eaque. Non et adipisci. Optio aut qui commodi.", 1, "https://picsum.photos/640/480/?image=429", false, 54.75m, 5, "Natus sequi et.", null },
                    { 4, 9, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7365), "Ad pariatur qui quae voluptatem. Porro autem ea illo modi natus. Earum alias ut accusantium voluptas hic est. Possimus veritatis et sint. Laboriosam occaecati non molestias omnis.", 7, "https://picsum.photos/640/480/?image=1045", false, 28.62m, 5, "Quia alias sed.", null },
                    { 5, 9, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7494), "In doloremque omnis atque nemo aliquid enim. Eius nihil eius atque dolor facere et qui. Voluptatem est sed inventore quibusdam maiores vel.", 7, "https://picsum.photos/640/480/?image=453", false, 34.61m, 2, "Voluptate qui facere.", null },
                    { 6, 8, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7568), "Tenetur dolores dignissimos ipsam eos delectus. Corporis deserunt nam eligendi consequatur. Et non maiores.", 1, "https://picsum.photos/640/480/?image=928", false, 75.38m, 1, "Commodi sunt velit.", null },
                    { 7, 3, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7652), "Culpa vel a aspernatur mollitia eum dolores suscipit. Officiis alias quaerat dolorem. Sed voluptatibus sit distinctio sequi eligendi tenetur est labore pariatur. Deleniti hic doloribus molestiae dolore qui. Ea vero qui ut laudantium consectetur expedita aut. Dolores dignissimos quia voluptate odit suscipit.", 3, "https://picsum.photos/640/480/?image=802", false, 21.91m, 3, "Saepe natus nihil.", null },
                    { 8, 7, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7851), "Iure ut et et omnis ullam amet ut dolorem ratione. Ea eveniet eos qui nemo sed totam nihil aut. Voluptatem dignissimos facere voluptatem vero. Et aspernatur aperiam ipsam voluptates et. Quia officiis delectus.", 2, "https://picsum.photos/640/480/?image=1067", false, 15.12m, 1, "Aspernatur perspiciatis sapiente.", null },
                    { 9, 10, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7960), "Eaque amet voluptas dolore ratione. Voluptas nesciunt voluptatibus possimus officiis alias. Aut doloribus tempore repellat.", 8, "https://picsum.photos/640/480/?image=181", false, 46.27m, 3, "Voluptatem quasi laborum.", null },
                    { 10, 9, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8060), "Sunt ut cum veritatis dolorem quaerat recusandae quidem. Ut quo qui nihil et ullam eum. Id ex consequatur non nam sint qui ad velit dolore. Et reiciendis distinctio reiciendis assumenda.", 1, "https://picsum.photos/640/480/?image=603", false, 61.93m, 4, "Perspiciatis facere ipsam.", null },
                    { 11, 2, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8178), "Et architecto libero qui placeat ab repellendus. Iure eius enim. Pariatur pariatur veniam ut natus architecto atque aut laudantium.", 6, "https://picsum.photos/640/480/?image=348", false, 97.25m, 3, "Sint ut nisi.", null },
                    { 12, 9, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8243), "Aliquid accusamus quasi laboriosam itaque ut perferendis. Tenetur exercitationem iste sint. Quisquam vel accusamus maiores quia veniam optio nam. Pariatur deleniti laboriosam ipsam earum pariatur ducimus aspernatur rerum minus.", 8, "https://picsum.photos/640/480/?image=694", false, 43.39m, 3, "Voluptates repellendus voluptates.", null },
                    { 13, 4, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8353), "Itaque possimus qui saepe consectetur iure id atque hic necessitatibus. Qui nihil in nihil exercitationem voluptatibus distinctio iusto molestiae. Est quis ratione est exercitationem. Voluptatem expedita accusantium ea.", 6, "https://picsum.photos/640/480/?image=667", false, 28.92m, 2, "Deserunt dolore et.", null },
                    { 14, 6, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8464), "Sint aspernatur qui voluptatem. Et asperiores ratione autem sapiente. Ea illum ut vero. Veniam officia rerum et voluptatibus eveniet. Vel doloribus enim inventore illo qui.", 8, "https://picsum.photos/640/480/?image=335", false, 21.30m, 4, "Adipisci ut soluta.", null },
                    { 15, 2, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8547), "Autem voluptatem consequatur et rerum rerum minus. Et consequatur mollitia expedita deserunt quo. Perferendis exercitationem facere adipisci qui aut ab qui harum eum.", 3, "https://picsum.photos/640/480/?image=964", false, 63.11m, 3, "Numquam non ut.", null },
                    { 16, 6, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8644), "Ipsum est tenetur. Nesciunt ut omnis. Eligendi a nam est aut atque et.", 6, "https://picsum.photos/640/480/?image=261", false, 41.41m, 2, "Reprehenderit inventore illo.", null },
                    { 17, 8, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8700), "Voluptatem non ut facilis. Hic provident sed voluptas laboriosam. Expedita pariatur odio quam et facere illum error.", 4, "https://picsum.photos/640/480/?image=604", false, 41.33m, 2, "Ut dolores mollitia.", null },
                    { 18, 4, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8790), "Sed dicta laborum quia magnam velit sit. Ut quis eos quae dolores alias sit. Veniam molestiae voluptate quisquam molestias. Laudantium reprehenderit aspernatur consequatur esse. Ullam et eum dolores et ducimus dolores ut perspiciatis.", 0, "https://picsum.photos/640/480/?image=794", false, 93.90m, 1, "Sunt explicabo velit.", null },
                    { 19, 8, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8880), "Quo consequuntur hic voluptatem provident voluptatem voluptatem aut. Esse non quasi odit veritatis quia doloribus culpa modi et. Sit itaque est voluptatum autem temporibus quod error adipisci quis. Quidem labore quos ut dolor a architecto et. Earum non illo.", 7, "https://picsum.photos/640/480/?image=413", false, 26.59m, 3, "Voluptates corrupti est.", null },
                    { 20, 8, new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(9040), "Aut asperiores doloremque qui voluptatum officiis modi temporibus. Fugit numquam ad sed quo repellendus praesentium velit eum. Aut quidem consequatur id laudantium fugit qui. Laudantium tempore ipsam quis.", 1, "https://picsum.photos/640/480/?image=1051", false, 25.57m, 4, "Molestiae laboriosam quae.", null }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9618), false, null, 2 },
                    { 3, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621), false, null, 3 },
                    { 4, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621), false, null, 4 },
                    { 5, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621), false, null, 5 },
                    { 6, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621), false, null, 6 },
                    { 7, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622), false, null, 7 },
                    { 8, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622), false, null, 8 },
                    { 9, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622), false, null, 9 },
                    { 10, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622), false, null, 10 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "IsDeleted", "ShippingAddressId", "TotalAmount", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(4324), "Irving.Hyatt@gmail.com", "Irving Hyatt", false, 12, 0m, null, 8 },
                    { 2, 13, new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(6859), "Stella_Predovic71@gmail.com", "Stella Predovic", false, 7, 0m, null, 10 },
                    { 3, 1, new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(7842), "Candice6@hotmail.com", "Candice Feil", false, 14, 0m, null, 2 },
                    { 4, 14, new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(8491), "Lorena44@hotmail.com", "Lorena Flatley", false, 11, 0m, null, 8 },
                    { 5, 2, new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(9123), "Jeffery.Jacobson97@hotmail.com", "Jeffery Jacobson", false, 13, 0m, null, 2 },
                    { 6, 1, new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(9746), "Esther43@gmail.com", "Esther Bayer", false, 9, 0m, null, 7 },
                    { 7, 11, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(291), "Nettie.Feest76@gmail.com", "Nettie Feest", false, 8, 0m, null, 2 },
                    { 8, 8, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(1022), "Vivian68@yahoo.com", "Vivian McLaughlin", false, 12, 0m, null, 6 },
                    { 9, 14, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(1633), "Dorothy_Berge97@hotmail.com", "Dorothy Berge", false, 11, 0m, null, 2 },
                    { 10, 3, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(2169), "Grant.Lemke@gmail.com", "Grant Lemke", false, 1, 0m, null, 4 },
                    { 11, 11, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(2832), "Gail.Wolff30@gmail.com", "Gail Wolff", false, 2, 0m, null, 5 },
                    { 12, 3, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(3419), "Kristina_Klocko10@yahoo.com", "Kristina Klocko", false, 2, 0m, null, 7 },
                    { 13, 13, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(4049), "Billy93@gmail.com", "Billy Corkery", false, 12, 0m, null, 5 },
                    { 14, 15, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(4610), "Grace_Metz10@yahoo.com", "Grace Metz", false, 14, 0m, null, 6 },
                    { 15, 3, new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(5180), "Colin84@hotmail.com", "Colin Murazik", false, 2, 0m, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "OrderId", "Price", "Quantity", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(7996), false, 5, 57.52m, 1, null },
                    { 2, 20, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9052), false, 1, 65.16m, 3, null },
                    { 3, 15, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9095), false, 1, 70.12m, 2, null },
                    { 4, 3, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9150), false, 13, 95.62m, 1, null },
                    { 5, 9, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9158), false, 7, 16.25m, 1, null },
                    { 6, 9, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9164), false, 14, 24.21m, 2, null },
                    { 7, 2, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9171), false, 8, 96.98m, 2, null },
                    { 8, 3, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9177), false, 7, 71.23m, 3, null },
                    { 9, 4, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9184), false, 13, 93.35m, 1, null },
                    { 10, 7, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9190), false, 10, 75.42m, 2, null },
                    { 11, 5, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9196), false, 5, 21.03m, 2, null },
                    { 12, 12, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9202), false, 5, 61.08m, 1, null },
                    { 13, 11, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9208), false, 8, 55.99m, 3, null },
                    { 14, 5, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9214), false, 6, 96.41m, 3, null },
                    { 15, 14, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9220), false, 10, 55.08m, 2, null },
                    { 16, 19, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9227), false, 6, 58.54m, 3, null },
                    { 17, 16, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9233), false, 2, 89.81m, 2, null },
                    { 18, 16, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9239), false, 8, 79.59m, 2, null },
                    { 19, 2, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9245), false, 3, 47.79m, 3, null },
                    { 20, 2, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9251), false, 8, 78.71m, 3, null },
                    { 21, 18, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9257), false, 1, 42.98m, 2, null },
                    { 22, 4, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9263), false, 13, 79.72m, 3, null },
                    { 23, 4, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9269), false, 9, 89.35m, 1, null },
                    { 24, 16, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9275), false, 12, 13.11m, 2, null },
                    { 25, 10, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9281), false, 1, 17.42m, 2, null },
                    { 26, 12, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9287), false, 11, 63.03m, 3, null },
                    { 27, 12, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9293), false, 10, 70.98m, 1, null },
                    { 28, 3, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9299), false, 5, 80.11m, 1, null },
                    { 29, 10, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9305), false, 12, 72.87m, 3, null },
                    { 30, 6, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9311), false, 15, 51.68m, 1, null },
                    { 31, 2, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9317), false, 8, 87.75m, 1, null },
                    { 32, 20, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9323), false, 15, 87.25m, 1, null },
                    { 33, 16, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9329), false, 3, 91.72m, 1, null },
                    { 34, 15, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9335), false, 11, 97.67m, 3, null },
                    { 35, 1, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9340), false, 14, 89.20m, 2, null },
                    { 36, 4, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9379), false, 13, 15.71m, 3, null },
                    { 37, 12, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9386), false, 3, 74.60m, 3, null },
                    { 38, 18, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9393), false, 8, 34.11m, 1, null },
                    { 39, 2, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9400), false, 11, 43.41m, 2, null },
                    { 40, 20, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9406), false, 15, 97.42m, 2, null },
                    { 41, 4, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9412), false, 12, 34.15m, 3, null },
                    { 42, 17, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9418), false, 1, 15.26m, 3, null },
                    { 43, 6, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9424), false, 15, 52.46m, 2, null },
                    { 44, 17, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9430), false, 2, 17.49m, 3, null },
                    { 45, 7, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9436), false, 15, 58.11m, 1, null },
                    { 46, 18, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9441), false, 13, 12.65m, 2, null },
                    { 47, 7, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9447), false, 13, 38.44m, 2, null },
                    { 48, 20, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9453), false, 10, 44.46m, 2, null },
                    { 49, 15, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9459), false, 13, 91.13m, 3, null },
                    { 50, 16, new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9465), false, 7, 61.85m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BookId", "Comment", "CreatedDate", "IsDeleted", "Stars", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 4, "Sed est aliquam esse rerum voluptatem aspernatur.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(1727), false, 5, null, 10 },
                    { 2, 9, "Fuga qui aut.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2786), false, 5, null, 9 },
                    { 3, 19, "Commodi facere aliquam non quia facere officiis aspernatur voluptatibus dolorum.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2843), false, 5, null, 10 },
                    { 4, 11, "Omnis omnis non maxime repellendus suscipit quaerat esse aliquam.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2914), false, 5, null, 7 },
                    { 5, 3, "A consequatur repudiandae minima necessitatibus sit id deleniti perspiciatis.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2940), false, 1, null, 8 },
                    { 6, 7, "Et ipsa hic molestiae voluptas voluptates qui soluta sit eligendi.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2967), false, 3, null, 2 },
                    { 7, 20, "Et quaerat dolores neque libero aliquid quia.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2991), false, 2, null, 8 },
                    { 8, 3, "Dolore ab sit veritatis.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3009), false, 3, null, 3 },
                    { 9, 13, "Necessitatibus voluptatem ipsam praesentium fugiat officiis.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3023), false, 1, null, 6 },
                    { 10, 14, "Dolor possimus sit et ratione et aut.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3040), false, 5, null, 9 },
                    { 11, 5, "Dolorem dolorum praesentium voluptatibus aut autem excepturi at occaecati molestias.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3061), false, 3, null, 5 },
                    { 12, 11, "Eius et in nemo debitis neque.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3122), false, 1, null, 4 },
                    { 13, 8, "Ad illum quae.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3139), false, 1, null, 6 },
                    { 14, 18, "Dolore sit similique delectus non asperiores ipsam eos perspiciatis.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3151), false, 4, null, 3 },
                    { 15, 9, "Ut sunt eius praesentium.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3173), false, 2, null, 3 },
                    { 16, 11, "Veniam illum aut repellendus nemo cum magnam cumque.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3186), false, 1, null, 6 },
                    { 17, 2, "Tempora dolorum voluptatem in adipisci voluptatum.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3206), false, 4, null, 5 },
                    { 18, 3, "Id aut facilis ullam sint amet adipisci.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3222), false, 2, null, 8 },
                    { 19, 1, "Quibusdam est doloribus.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3241), false, 3, null, 7 },
                    { 20, 5, "Accusamus similique accusantium eius dolores consequatur tempora.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3289), false, 5, null, 9 },
                    { 21, 12, "Et et quidem.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3308), false, 2, null, 3 },
                    { 22, 1, "Inventore consequatur minima odit magni voluptas quod nihil quas nisi.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3320), false, 5, null, 5 },
                    { 23, 18, "Et soluta temporibus consequatur soluta fugit laudantium sunt.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3343), false, 4, null, 4 },
                    { 24, 17, "Quis quod sapiente iusto odit aspernatur et.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3362), false, 2, null, 10 },
                    { 25, 15, "Atque atque exercitationem est dolores est.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3380), false, 1, null, 6 },
                    { 26, 12, "Natus vel repellat eos amet qui.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3396), false, 4, null, 9 },
                    { 27, 6, "Dolores laudantium aut.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3413), false, 2, null, 4 },
                    { 28, 1, "Repudiandae minus ipsa deleniti voluptates.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3444), false, 1, null, 5 },
                    { 29, 10, "Repellendus voluptatem tempore praesentium ea.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3459), false, 4, null, 3 },
                    { 30, 13, "Aperiam dignissimos aperiam.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3475), false, 3, null, 3 },
                    { 31, 3, "Expedita voluptatibus quis.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3486), false, 5, null, 9 },
                    { 32, 3, "Deleniti nemo tenetur sit explicabo.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3498), false, 1, null, 9 },
                    { 33, 6, "Esse temporibus molestiae quia et non.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3512), false, 1, null, 2 },
                    { 34, 4, "Qui magnam molestiae aliquid fuga quae.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3529), false, 2, null, 10 },
                    { 35, 18, "Voluptatem ipsam qui tempore quos.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3546), false, 1, null, 3 },
                    { 36, 11, "Enim libero a debitis odit.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3629), false, 5, null, 2 },
                    { 37, 8, "Consectetur expedita ab accusamus id mollitia quo voluptatum animi et.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3648), false, 2, null, 4 },
                    { 38, 1, "Cumque eos ut quos nemo aut voluptatibus ratione.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3672), false, 1, null, 5 },
                    { 39, 4, "Aspernatur est maiores enim harum dolorem ut voluptatem sint rerum.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3693), false, 3, null, 8 },
                    { 40, 9, "Numquam deserunt distinctio.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3715), false, 1, null, 2 },
                    { 41, 11, "Id est rerum et nesciunt tenetur optio voluptatibus qui.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3727), false, 5, null, 7 },
                    { 42, 7, "Quae culpa cupiditate deserunt.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3748), false, 1, null, 8 },
                    { 43, 13, "Quo veritatis repellendus velit.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3761), false, 4, null, 3 },
                    { 44, 19, "Magnam eligendi quia.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3818), false, 4, null, 9 },
                    { 45, 10, "Qui laboriosam accusantium deserunt voluptatem architecto.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3831), false, 5, null, 9 },
                    { 46, 13, "Aut itaque ipsum magni nisi consectetur.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3849), false, 2, null, 6 },
                    { 47, 17, "Culpa nemo fuga at aut.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3865), false, 2, null, 8 },
                    { 48, 2, "Culpa eos laborum corporis amet eveniet voluptatem magni consectetur.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3879), false, 3, null, 10 },
                    { 49, 4, "Consectetur ad cum ipsa cumque.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3899), false, 3, null, 7 },
                    { 50, 2, "Sit tenetur harum totam ducimus praesentium voluptas exercitationem.", new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3913), false, 2, null, 9 }
                });

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[] { "Id", "BookId", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    { 1, 13, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6063), false, null, 6 },
                    { 2, 2, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6221), false, null, 2 },
                    { 3, 18, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6227), false, null, 4 },
                    { 4, 19, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6250), false, null, 9 },
                    { 5, 7, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6254), false, null, 4 },
                    { 6, 15, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6257), false, null, 4 },
                    { 7, 12, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6260), false, null, 10 },
                    { 8, 1, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6262), false, null, 5 },
                    { 9, 7, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6265), false, null, 7 },
                    { 10, 10, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6267), false, null, 8 },
                    { 11, 19, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6270), false, null, 6 },
                    { 12, 6, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6272), false, null, 4 },
                    { 13, 1, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6275), false, null, 3 },
                    { 14, 11, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6277), false, null, 8 },
                    { 15, 8, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6280), false, null, 7 },
                    { 16, 19, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6282), false, null, 5 },
                    { 17, 13, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6285), false, null, 5 },
                    { 18, 3, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6287), false, null, 5 },
                    { 19, 6, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6290), false, null, 10 },
                    { 20, 6, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6292), false, null, 3 },
                    { 21, 15, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6294), false, null, 4 },
                    { 22, 18, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6297), false, null, 7 },
                    { 23, 5, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6299), false, null, 10 },
                    { 24, 19, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6302), false, null, 2 },
                    { 25, 6, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6304), false, null, 10 },
                    { 26, 1, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6306), false, null, 10 },
                    { 27, 2, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6309), false, null, 8 },
                    { 28, 7, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6311), false, null, 6 },
                    { 29, 4, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6314), false, null, 4 },
                    { 30, 5, new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6316), false, null, 2 }
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
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

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
                name: "Publishers");
        }
    }
}
