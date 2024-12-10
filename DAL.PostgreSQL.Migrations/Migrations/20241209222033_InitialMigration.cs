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
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Street = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    ZipCode = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(
                        type: "character varying(256)",
                        maxLength: 256,
                        nullable: true
                    ),
                    NormalizedName = table.Column<string>(
                        type: "character varying(256)",
                        maxLength: 256,
                        nullable: true
                    ),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(
                        type: "character varying(256)",
                        maxLength: 256,
                        nullable: true
                    ),
                    NormalizedUserName = table.Column<string>(
                        type: "character varying(256)",
                        maxLength: 256,
                        nullable: true
                    ),
                    Email = table.Column<string>(
                        type: "character varying(256)",
                        maxLength: 256,
                        nullable: true
                    ),
                    NormalizedEmail = table.Column<string>(
                        type: "character varying(256)",
                        maxLength: 256,
                        nullable: true
                    ),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(type: "text", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_AspNetUserLogins",
                        x => new { x.LoginProvider, x.ProviderKey }
                    );
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey(
                        "PK_AspNetUserTokens",
                        x => new
                        {
                            x.UserId,
                            x.LoginProvider,
                            x.Name,
                        }
                    );
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "numeric", nullable: false),
                    CustomerName = table.Column<string>(type: "text", nullable: false),
                    CustomerEmail = table.Column<string>(type: "text", nullable: false),
                    ShippingAddressId = table.Column<int>(type: "integer", nullable: false),
                    BillingAddressId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_BillingAddressId",
                        column: x => x.BillingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Title = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<int>(type: "integer", nullable: false),
                    PublisherId = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    PrimaryGenreId = table.Column<int>(type: "integer", nullable: false),
                    LastEditorId = table.Column<int>(type: "integer", nullable: true),
                    EditCount = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_AspNetUsers_LastEditorId",
                        column: x => x.LastEditorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Books_BookGenre_PrimaryGenreId",
                        column: x => x.PrimaryGenreId,
                        principalTable: "BookGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "BookGenreLink",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenreLink", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookGenreLink_BookGenre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "BookGenre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_BookGenreLink_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    CartId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Stars = table.Column<int>(type: "integer", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateTable(
                name: "WishlistItems",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    UpdatedDate = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: true
                    ),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_WishlistItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[]
                {
                    "Id",
                    "City",
                    "Country",
                    "CreatedDate",
                    "IsDeleted",
                    "State",
                    "Street",
                    "UpdatedDate",
                    "ZipCode",
                },
                values: new object[,]
                {
                    {
                        1,
                        "East Euna",
                        "Christmas Island",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(780),
                        false,
                        "Illinois",
                        "29543 Treutel Trafficway",
                        null,
                        "03034",
                    },
                    {
                        2,
                        "Lake Penelope",
                        "Aruba",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(1563),
                        false,
                        "Ohio",
                        "4897 Rempel Vista",
                        null,
                        "23040-4792",
                    },
                    {
                        3,
                        "Magnoliachester",
                        "Armenia",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(1731),
                        false,
                        "Arkansas",
                        "4395 Haag Court",
                        null,
                        "52788",
                    },
                    {
                        4,
                        "Sonnyberg",
                        "Syrian Arab Republic",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(1883),
                        false,
                        "South Dakota",
                        "0524 Abdiel Stream",
                        null,
                        "69510-1994",
                    },
                    {
                        5,
                        "Pietroview",
                        "French Guiana",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2031),
                        false,
                        "Texas",
                        "90318 Schowalter Corners",
                        null,
                        "65379",
                    },
                    {
                        6,
                        "Vandervortfort",
                        "Guatemala",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2170),
                        false,
                        "Florida",
                        "4648 Crawford Union",
                        null,
                        "58378",
                    },
                    {
                        7,
                        "Oberbrunnermouth",
                        "Cameroon",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2301),
                        false,
                        "Pennsylvania",
                        "22733 Geo Creek",
                        null,
                        "40694",
                    },
                    {
                        8,
                        "South Curt",
                        "United Kingdom",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2459),
                        false,
                        "Alabama",
                        "5013 Mekhi Crescent",
                        null,
                        "25777-6946",
                    },
                    {
                        9,
                        "Trompfort",
                        "Antigua and Barbuda",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2617),
                        false,
                        "Alaska",
                        "54230 Crona Plains",
                        null,
                        "06052-9403",
                    },
                    {
                        10,
                        "Madgeborough",
                        "China",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2743),
                        false,
                        "Colorado",
                        "32171 Rocio Court",
                        null,
                        "00631-4029",
                    },
                    {
                        11,
                        "New Abbey",
                        "Burundi",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2873),
                        false,
                        "Arkansas",
                        "47521 Tyshawn Parkways",
                        null,
                        "35210",
                    },
                    {
                        12,
                        "Marisolstad",
                        "Barbados",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3003),
                        false,
                        "Florida",
                        "4106 Bogisich Glens",
                        null,
                        "65280",
                    },
                    {
                        13,
                        "West Wandafort",
                        "Maldives",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3131),
                        false,
                        "New Jersey",
                        "86561 Myrtie Ports",
                        null,
                        "24574",
                    },
                    {
                        14,
                        "Octaviamouth",
                        "Tonga",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3271),
                        false,
                        "Wyoming",
                        "2912 Kub Village",
                        null,
                        "06411",
                    },
                    {
                        15,
                        "Lake Macy",
                        "Wallis and Futuna",
                        new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3387),
                        false,
                        "Wisconsin",
                        "2675 Ritchie Walk",
                        null,
                        "88006-5759",
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "Admin", "ADMIN" },
                    { 2, null, "User", "USER" },
                }
            );

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[]
                {
                    "Id",
                    "AccessFailedCount",
                    "ConcurrencyStamp",
                    "Email",
                    "EmailConfirmed",
                    "LockoutEnabled",
                    "LockoutEnd",
                    "Name",
                    "NormalizedEmail",
                    "NormalizedUserName",
                    "PasswordHash",
                    "PhoneNumber",
                    "PhoneNumberConfirmed",
                    "SecurityStamp",
                    "TwoFactorEnabled",
                    "UserName",
                },
                values: new object[,]
                {
                    {
                        1,
                        0,
                        "7d3f3d4c-e3af-4979-8f41-21fe962ed7a3",
                        "admin@admin.com",
                        true,
                        false,
                        null,
                        "Admin User",
                        null,
                        null,
                        null,
                        "123-456-7890",
                        false,
                        "096465a3-e925-40a4-a08d-71d592e347c5",
                        false,
                        "admin@admin.com",
                    },
                    {
                        2,
                        0,
                        "f87dfe8e-bbe1-4260-8135-5cc0127997a7",
                        "Jewel.Haag39@yahoo.com",
                        true,
                        false,
                        null,
                        "Scot Kuhn",
                        null,
                        null,
                        null,
                        "204-579-4186 x041",
                        false,
                        "359e810f-6b58-4c65-8d1c-fa54ed235085",
                        false,
                        "Jewel.Haag39@yahoo.com",
                    },
                    {
                        3,
                        0,
                        "dfc926a1-b7cb-40f1-a1fa-1ce5f97a4b72",
                        "Diana_Altenwerth@yahoo.com",
                        true,
                        false,
                        null,
                        "Odell Heaney",
                        null,
                        null,
                        null,
                        "775-575-0909 x88931",
                        false,
                        "0e7c77ea-4417-4aa4-9082-e5de9bd1d1bd",
                        false,
                        "Diana_Altenwerth@yahoo.com",
                    },
                    {
                        4,
                        0,
                        "c23d3ae3-7848-42b7-9503-75cbd23aae9c",
                        "Georgiana69@gmail.com",
                        true,
                        false,
                        null,
                        "Bennett Howell",
                        null,
                        null,
                        null,
                        "1-378-374-0247 x40962",
                        false,
                        "aa8d56be-7208-4f1e-9ec4-2f07385e6261",
                        false,
                        "Georgiana69@gmail.com",
                    },
                    {
                        5,
                        0,
                        "afd7acfa-5224-4f38-8800-b68217cdb723",
                        "Marjorie.Brakus1@hotmail.com",
                        true,
                        false,
                        null,
                        "Riley Schuster",
                        null,
                        null,
                        null,
                        "455-350-6677",
                        false,
                        "9a76a42f-0964-4432-ab2f-2272bd54be12",
                        false,
                        "Marjorie.Brakus1@hotmail.com",
                    },
                    {
                        6,
                        0,
                        "d27d2d8f-2de4-4ea2-b4cb-1f980d767ea6",
                        "Tristin_Smitham30@yahoo.com",
                        true,
                        false,
                        null,
                        "Bryon Koepp",
                        null,
                        null,
                        null,
                        "207-243-1087 x06484",
                        false,
                        "94c922f2-65d8-4b70-9691-b26a6ef0849c",
                        false,
                        "Tristin_Smitham30@yahoo.com",
                    },
                    {
                        7,
                        0,
                        "307a044e-63f4-4108-914b-490aeb34cb67",
                        "Florida3@hotmail.com",
                        true,
                        false,
                        null,
                        "Lia Homenick",
                        null,
                        null,
                        null,
                        "(470) 694-2517 x67915",
                        false,
                        "2d1ba4d9-a888-4a33-b647-584a49de3769",
                        false,
                        "Florida3@hotmail.com",
                    },
                    {
                        8,
                        0,
                        "124c2baa-7a3d-423d-9116-0ea790d2967a",
                        "Jailyn11@hotmail.com",
                        true,
                        false,
                        null,
                        "Lemuel Schumm",
                        null,
                        null,
                        null,
                        "1-683-740-5638 x12823",
                        false,
                        "96534116-7a75-419c-94fc-26ad3a28b1e9",
                        false,
                        "Jailyn11@hotmail.com",
                    },
                    {
                        9,
                        0,
                        "2ab0d7e7-286b-400f-aa86-aa92bb1fb320",
                        "Marquis20@hotmail.com",
                        true,
                        false,
                        null,
                        "Tyreek McDermott",
                        null,
                        null,
                        null,
                        "319-732-0313",
                        false,
                        "58c3bf84-541b-47ad-9de4-d889c24d7db1",
                        false,
                        "Marquis20@hotmail.com",
                    },
                    {
                        10,
                        0,
                        "a69dc809-85c7-4c95-87c5-3c4694158d07",
                        "Louisa.Kozey@hotmail.com",
                        true,
                        false,
                        null,
                        "Shanelle Wiza",
                        null,
                        null,
                        null,
                        "969.742.0386 x529",
                        false,
                        "cddff05d-4e1b-406c-96dc-6a8b8ee670d2",
                        false,
                        "Louisa.Kozey@hotmail.com",
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Ut magnam at molestiae sed a corrupti impedit. Cupiditate quae ex nostrum voluptates qui doloremque aut fuga. Et architecto omnis soluta non. Autem quam laborum harum et quibusdam. Veritatis qui provident dolorem eligendi saepe tempore commodi et. Et sapiente quasi placeat reiciendis.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(3878),
                        false,
                        "Hunter Runte",
                        null,
                    },
                    {
                        2,
                        "Voluptatibus fuga illo temporibus qui ut illo autem. Omnis eligendi quia et. Optio maxime magni sed cupiditate velit assumenda illum.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4488),
                        false,
                        "Adelle Ullrich",
                        null,
                    },
                    {
                        3,
                        "Magni in ut dolores ad veniam veritatis. Harum nisi provident corrupti consequatur consequatur id consequatur et. Eaque qui est iure nesciunt non.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4635),
                        false,
                        "Nico Kemmer",
                        null,
                    },
                    {
                        4,
                        "Quas dolorem tempore fuga dolorem. Adipisci voluptas laudantium dolorum recusandae praesentium pariatur aliquam. Sed rerum excepturi corporis animi quas recusandae perferendis. Asperiores sunt enim. Ratione id placeat commodi consequatur ipsam quia aut nobis dolor.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4743),
                        false,
                        "Carlos Labadie",
                        null,
                    },
                    {
                        5,
                        "Libero et et illo. Ipsum earum sunt cupiditate recusandae itaque. Omnis tempora nesciunt. Nihil voluptatum magnam. Eum molestiae inventore. Officiis omnis quia officia nemo.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4937),
                        false,
                        "Nicholas Marvin",
                        null,
                    },
                    {
                        6,
                        "Quos quas fuga placeat tempora rem est aut. In qui voluptate maxime aperiam dolorem minus. Dolor inventore facilis qui sed. Harum et sed sed. Natus velit ipsa. Et vel et dignissimos eum consequatur nesciunt.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5046),
                        false,
                        "Hugh Pouros",
                        null,
                    },
                    {
                        7,
                        "Eaque debitis sint velit sed enim alias id. Aut dolorem atque perferendis tempore sapiente alias harum. Libero dolor cupiditate in non ut natus itaque fugit ea.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5195),
                        false,
                        "Janae Nader",
                        null,
                    },
                    {
                        8,
                        "Culpa corrupti est omnis culpa sapiente. Molestiae suscipit officia id reiciendis tempore. Non et repellat non. Consequatur provident quam.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5271),
                        false,
                        "Aric Casper",
                        null,
                    },
                    {
                        9,
                        "Modi ab ex provident dolores beatae. Totam sequi nihil repellat placeat fugiat perferendis officia. Magnam debitis rerum.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5362),
                        false,
                        "Luz Moore",
                        null,
                    },
                    {
                        10,
                        "Nostrum provident provident. Ullam est ad. Incidunt qui officiis labore porro quas. Ullam qui quia.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5429),
                        false,
                        "Rubie Kris",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Iusto sunt et." },
                    { 2, "Aut nam non." },
                    { 3, "Qui ipsam facere." },
                    { 4, "Est iusto mollitia." },
                    { 5, "Ea tempora perferendis." },
                    { 6, "Nulla mollitia voluptas." },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Ratione eligendi omnis ut ad. Eius est mollitia eum est dolorum quia nobis id sit. Accusantium officia ut maxime tenetur iste et officiis nihil. Esse fuga qui esse ut veritatis corporis quisquam ex sint. Aut distinctio natus voluptatem eveniet quod aut doloremque autem.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(8144),
                        false,
                        "Wolff, Turcotte and Welch",
                        null,
                    },
                    {
                        2,
                        "Asperiores quasi veniam veritatis laboriosam hic quae corporis. Ut eius perferendis omnis consectetur sed nisi aut et. Facilis facilis voluptatum incidunt aliquam minus unde porro impedit nihil.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9012),
                        false,
                        "Heathcote and Sons",
                        null,
                    },
                    {
                        3,
                        "Aperiam aliquid omnis dolores voluptas et vero aliquam quod assumenda. Dolor iure rerum voluptas sunt quisquam similique. Incidunt neque ut totam minima accusamus cum ullam. Exercitationem officiis eum non vel delectus.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9292),
                        false,
                        "Cremin - Bartell",
                        null,
                    },
                    {
                        4,
                        "Voluptatem non ut eos molestiae quis et. Sed ut et fugiat veritatis est dolorum in. Eveniet animi autem molestias tempore quia ea.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9487),
                        false,
                        "Medhurst Inc",
                        null,
                    },
                    {
                        5,
                        "Qui magni quia enim consequuntur commodi qui ipsum. Voluptatem modi magni quo architecto asperiores quis veniam. Totam repudiandae fugiat consequatur maiores doloremque aut. Ipsa nobis illo dignissimos repellendus mollitia qui nobis perferendis. Consequuntur aliquam qui vel sed accusantium dolores maxime architecto. Est magnam dignissimos quis ad laudantium fuga.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9640),
                        false,
                        "Monahan LLC",
                        null,
                    },
                }
            );

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
                    { 2, 10 },
                }
            );

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[]
                {
                    "Id",
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "EditCount",
                    "ImagePath",
                    "IsDeleted",
                    "LastEditorId",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                    "UpdatedDate",
                },
                values: new object[,]
                {
                    {
                        1,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(6808),
                        "Voluptates fugit et aperiam sint vitae et in vel aut. Molestiae officia non vero atque est adipisci. Quo non eos.",
                        0,
                        "https://picsum.photos/640/480/?image=558",
                        false,
                        null,
                        60.69m,
                        2,
                        4,
                        "Culpa rem non.",
                        null,
                    },
                    {
                        2,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8421),
                        "Tempore enim commodi tempora ad est. Asperiores dolor sed. Aperiam praesentium maiores excepturi voluptatem ut. Aut voluptatibus eos quia minima incidunt id. Perspiciatis porro cupiditate necessitatibus commodi iste voluptas aspernatur quam.",
                        0,
                        "https://picsum.photos/640/480/?image=928",
                        false,
                        null,
                        13.30m,
                        3,
                        4,
                        "Voluptatem sint hic.",
                        null,
                    },
                    {
                        3,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8608),
                        "Non voluptas vel ducimus soluta enim ipsum unde quis non. Autem est ex sit tempore. Itaque ipsum rerum omnis ut eligendi eligendi velit. Doloribus officiis nostrum est. Dolores eaque libero eum voluptatum modi.",
                        0,
                        "https://picsum.photos/640/480/?image=568",
                        false,
                        null,
                        16.42m,
                        1,
                        4,
                        "Distinctio alias et.",
                        null,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8750),
                        "Esse fugiat quia ut modi aut quis. Vero iusto ut error. Consequatur iure eligendi consequuntur dolore et.",
                        0,
                        "https://picsum.photos/640/480/?image=715",
                        false,
                        null,
                        41.26m,
                        6,
                        1,
                        "Eveniet occaecati quas.",
                        null,
                    },
                    {
                        5,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8821),
                        "Autem quas mollitia quibusdam molestias aut dolor id minima molestias. Natus sint voluptatem facilis ut recusandae labore aliquam eos voluptatibus. Ut soluta est numquam illo vitae ipsum nihil. Recusandae sed quo reprehenderit ad adipisci. Accusantium ullam dolores aliquam corrupti corporis.",
                        0,
                        "https://picsum.photos/640/480/?image=452",
                        false,
                        null,
                        76.19m,
                        6,
                        3,
                        "Rerum ex ut.",
                        null,
                    },
                    {
                        6,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8977),
                        "Asperiores et doloremque quia laborum quia eos. Commodi illo vitae ut temporibus similique eius quia. Numquam expedita magnam neque cum nihil sint quod. Et delectus est. Minima quae ut corporis aliquid in minima.",
                        0,
                        "https://picsum.photos/640/480/?image=798",
                        false,
                        null,
                        78.99m,
                        3,
                        3,
                        "Ullam aliquam nihil.",
                        null,
                    },
                    {
                        7,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9092),
                        "Optio ex et est nihil voluptatem laudantium nam. Expedita impedit velit sit ab quae voluptates. Doloremque quia libero sequi quasi. Deleniti qui est laudantium deserunt possimus tenetur. Eaque dolorum harum a aut et non sunt deserunt. Officia nulla reprehenderit.",
                        0,
                        "https://picsum.photos/640/480/?image=216",
                        false,
                        null,
                        75.64m,
                        1,
                        2,
                        "Rem qui eaque.",
                        null,
                    },
                    {
                        8,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9279),
                        "Et mollitia ab iure recusandae similique dolor vel aliquam. Quis qui excepturi. Vero sunt nihil praesentium minus sed. Qui voluptas dignissimos amet sunt. Blanditiis ex commodi totam repudiandae sunt quia dicta minus sapiente. Voluptatem architecto iure.",
                        0,
                        "https://picsum.photos/640/480/?image=382",
                        false,
                        null,
                        94.26m,
                        3,
                        2,
                        "Est deleniti distinctio.",
                        null,
                    },
                    {
                        9,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9433),
                        "Cupiditate velit et minus eos iste voluptates in. Pariatur non voluptas voluptatem et. Pariatur nihil dolor recusandae ipsam ducimus ipsum et. Distinctio facere perferendis aliquid recusandae qui aut quam.",
                        0,
                        "https://picsum.photos/640/480/?image=834",
                        false,
                        null,
                        99.12m,
                        4,
                        3,
                        "Dolores ducimus aut.",
                        null,
                    },
                    {
                        10,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9516),
                        "Omnis labore reprehenderit ut veniam veritatis quibusdam dolorem atque libero. Quo sed explicabo repudiandae perspiciatis. Occaecati deleniti molestiae et et quis omnis. Earum reiciendis voluptatibus voluptatem omnis. Deleniti quasi vitae et reprehenderit laborum ab iusto. Ipsam id pariatur animi nobis dignissimos.",
                        0,
                        "https://picsum.photos/640/480/?image=390",
                        false,
                        null,
                        12.52m,
                        4,
                        2,
                        "Sequi est earum.",
                        null,
                    },
                    {
                        11,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9657),
                        "Doloribus explicabo repudiandae veritatis quia. Quis et incidunt perspiciatis distinctio illo. Voluptas repellat voluptatibus impedit asperiores ea officiis tempore sint blanditiis. Quidem ut occaecati velit magni beatae aliquam aut eius voluptatem. Ut quibusdam quo ipsa qui non dolor. Maiores ullam modi.",
                        0,
                        "https://picsum.photos/640/480/?image=208",
                        false,
                        null,
                        36.62m,
                        1,
                        5,
                        "Perferendis accusantium sit.",
                        null,
                    },
                    {
                        12,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9800),
                        "Quas explicabo id quos qui necessitatibus nihil. Excepturi id quo est et a pariatur in aut est. Aut excepturi sapiente magni sit odio quaerat nesciunt. Eveniet quo voluptatum. Consequatur exercitationem maxime soluta velit delectus sed.",
                        0,
                        "https://picsum.photos/640/480/?image=710",
                        false,
                        null,
                        48.07m,
                        6,
                        4,
                        "Numquam explicabo quo.",
                        null,
                    },
                    {
                        13,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9990),
                        "Ducimus alias et dolore porro omnis. Assumenda ipsum consequatur molestiae in officiis ullam natus quos. Ut blanditiis est.",
                        0,
                        "https://picsum.photos/640/480/?image=478",
                        false,
                        null,
                        54.56m,
                        5,
                        1,
                        "Rem fuga cumque.",
                        null,
                    },
                    {
                        14,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(54),
                        "Sit beatae quos. Laudantium ullam aut molestiae eveniet dolorum. Possimus accusamus provident aspernatur quos dolores molestiae. Officia ullam eos eum cum ipsam quo quis. Vel saepe velit consequatur. Et optio reiciendis accusantium repellendus consequatur aut omnis.",
                        0,
                        "https://picsum.photos/640/480/?image=156",
                        false,
                        null,
                        79.82m,
                        1,
                        4,
                        "Fugit ipsa molestias.",
                        null,
                    },
                    {
                        15,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(181),
                        "Et sit in fuga eaque nihil id sit qui corporis. Dolorem et necessitatibus animi recusandae dolorum quia nihil. Ex dicta in deserunt accusamus quas odit voluptatem similique aut. Minima tempore dolor non autem velit blanditiis consequatur. Aperiam qui dicta et et ut aliquid consequatur illum cum.",
                        0,
                        "https://picsum.photos/640/480/?image=253",
                        false,
                        null,
                        52.25m,
                        2,
                        1,
                        "Ut labore nihil.",
                        null,
                    },
                    {
                        16,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(340),
                        "Velit est ut et sunt eum sunt. Minima sed et adipisci repudiandae dolor totam. Ab sunt qui consequatur aspernatur. Repellat voluptatem ex laboriosam. Quos reprehenderit aspernatur fuga.",
                        0,
                        "https://picsum.photos/640/480/?image=104",
                        false,
                        null,
                        68.83m,
                        1,
                        4,
                        "Et id quibusdam.",
                        null,
                    },
                    {
                        17,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(454),
                        "Vero reiciendis atque nihil possimus dolorem sunt. Laboriosam voluptatem earum eos non distinctio amet. Blanditiis aut libero. At cupiditate autem impedit illo amet sed sed nemo. Quis voluptatem ea sequi velit voluptate. Sunt autem ducimus quia voluptate et et occaecati.",
                        0,
                        "https://picsum.photos/640/480/?image=253",
                        false,
                        null,
                        90.28m,
                        1,
                        5,
                        "Iste sit maxime.",
                        null,
                    },
                    {
                        18,
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(611),
                        "Expedita laborum laboriosam aspernatur voluptas ut nulla rerum dolorem. Ipsum porro ex eligendi quas ex occaecati consequatur aut quo. Maiores doloribus laboriosam esse aut sit iste ut odit. Aspernatur nobis inventore qui sapiente aliquid.",
                        0,
                        "https://picsum.photos/640/480/?image=962",
                        false,
                        null,
                        14.09m,
                        2,
                        1,
                        "Delectus temporibus omnis.",
                        null,
                    },
                    {
                        19,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(698),
                        "Sed voluptatem perferendis eum incidunt eaque quis fuga odit optio. Unde voluptas quia ullam et. Hic quis quisquam et tenetur dolor labore animi est. Velit possimus eos inventore et debitis alias sequi.",
                        0,
                        "https://picsum.photos/640/480/?image=521",
                        false,
                        null,
                        62.99m,
                        1,
                        2,
                        "Nesciunt amet et.",
                        null,
                    },
                    {
                        20,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(820),
                        "Non eligendi tempore sed rerum amet qui pariatur beatae voluptatem. Sit voluptatibus itaque molestiae quaerat perferendis ducimus dolor. Iure omnis inventore ut velit veritatis dignissimos nulla.",
                        0,
                        "https://picsum.photos/640/480/?image=1084",
                        false,
                        null,
                        16.20m,
                        3,
                        3,
                        "Culpa fugit voluptas.",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "UpdatedDate", "UserId" },
                values: new object[,]
                {
                    {
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4443),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4446),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4446),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4446),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447),
                        false,
                        null,
                        10,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[]
                {
                    "Id",
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "IsDeleted",
                    "ShippingAddressId",
                    "TotalAmount",
                    "UpdatedDate",
                    "UserId",
                },
                values: new object[,]
                {
                    {
                        1,
                        8,
                        new DateTime(2024, 12, 9, 22, 20, 33, 302, DateTimeKind.Utc).AddTicks(5925),
                        "Maria.Mante@hotmail.com",
                        "Maria Mante",
                        false,
                        8,
                        0m,
                        null,
                        2,
                    },
                    {
                        2,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 302, DateTimeKind.Utc).AddTicks(8625),
                        "Jerry.Considine@gmail.com",
                        "Jerry Considine",
                        false,
                        8,
                        0m,
                        null,
                        9,
                    },
                    {
                        3,
                        13,
                        new DateTime(2024, 12, 9, 22, 20, 33, 302, DateTimeKind.Utc).AddTicks(9672),
                        "Chester_Hintz85@yahoo.com",
                        "Chester Hintz",
                        false,
                        6,
                        0m,
                        null,
                        6,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(415),
                        "Susan.Jaskolski@hotmail.com",
                        "Susan Jaskolski",
                        false,
                        7,
                        0m,
                        null,
                        3,
                    },
                    {
                        5,
                        8,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(1083),
                        "Lora.Boyle@yahoo.com",
                        "Lora Boyle",
                        false,
                        12,
                        0m,
                        null,
                        4,
                    },
                    {
                        6,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(1642),
                        "Elizabeth_Ortiz@gmail.com",
                        "Elizabeth Ortiz",
                        false,
                        9,
                        0m,
                        null,
                        10,
                    },
                    {
                        7,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(2346),
                        "Melody.Tremblay18@gmail.com",
                        "Melody Tremblay",
                        false,
                        15,
                        0m,
                        null,
                        5,
                    },
                    {
                        8,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(2984),
                        "Gilberto_Waelchi62@yahoo.com",
                        "Gilberto Waelchi",
                        false,
                        14,
                        0m,
                        null,
                        7,
                    },
                    {
                        9,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(3639),
                        "Archie58@gmail.com",
                        "Archie Zemlak",
                        false,
                        4,
                        0m,
                        null,
                        10,
                    },
                    {
                        10,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(4237),
                        "Janet_Goodwin@yahoo.com",
                        "Janet Goodwin",
                        false,
                        1,
                        0m,
                        null,
                        3,
                    },
                    {
                        11,
                        13,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(4848),
                        "Kristopher_Kihn@hotmail.com",
                        "Kristopher Kihn",
                        false,
                        12,
                        0m,
                        null,
                        5,
                    },
                    {
                        12,
                        11,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(5519),
                        "Dixie.Daniel@gmail.com",
                        "Dixie Daniel",
                        false,
                        7,
                        0m,
                        null,
                        7,
                    },
                    {
                        13,
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(6220),
                        "Alexandra_Nitzsche@hotmail.com",
                        "Alexandra Nitzsche",
                        false,
                        2,
                        0m,
                        null,
                        9,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(6868),
                        "Alejandro29@gmail.com",
                        "Alejandro O'Kon",
                        false,
                        3,
                        0m,
                        null,
                        4,
                    },
                    {
                        15,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 304, DateTimeKind.Utc).AddTicks(8030),
                        "Jean92@yahoo.com",
                        "Jean Monahan",
                        false,
                        1,
                        0m,
                        null,
                        4,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[]
                {
                    "Id",
                    "BookId",
                    "CreatedDate",
                    "IsDeleted",
                    "OrderId",
                    "Price",
                    "Quantity",
                    "UpdatedDate",
                },
                values: new object[,]
                {
                    {
                        1,
                        17,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(2442),
                        false,
                        15,
                        19.98m,
                        1,
                        null,
                    },
                    {
                        2,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3822),
                        false,
                        3,
                        21.14m,
                        2,
                        null,
                    },
                    {
                        3,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3870),
                        false,
                        3,
                        36.96m,
                        3,
                        null,
                    },
                    {
                        4,
                        18,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3881),
                        false,
                        13,
                        41.15m,
                        2,
                        null,
                    },
                    {
                        5,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3888),
                        false,
                        9,
                        69.55m,
                        3,
                        null,
                    },
                    {
                        6,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3894),
                        false,
                        12,
                        61.73m,
                        3,
                        null,
                    },
                    {
                        7,
                        20,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3901),
                        false,
                        6,
                        61.74m,
                        1,
                        null,
                    },
                    {
                        8,
                        15,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3946),
                        false,
                        3,
                        37.22m,
                        3,
                        null,
                    },
                    {
                        9,
                        16,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3953),
                        false,
                        5,
                        22.48m,
                        3,
                        null,
                    },
                    {
                        10,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3960),
                        false,
                        12,
                        66.76m,
                        1,
                        null,
                    },
                    {
                        11,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3967),
                        false,
                        13,
                        55.16m,
                        1,
                        null,
                    },
                    {
                        12,
                        1,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3973),
                        false,
                        8,
                        28.88m,
                        1,
                        null,
                    },
                    {
                        13,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3979),
                        false,
                        7,
                        93.31m,
                        2,
                        null,
                    },
                    {
                        14,
                        8,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3985),
                        false,
                        4,
                        61.63m,
                        1,
                        null,
                    },
                    {
                        15,
                        16,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3991),
                        false,
                        2,
                        32.25m,
                        3,
                        null,
                    },
                    {
                        16,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3997),
                        false,
                        7,
                        63.52m,
                        3,
                        null,
                    },
                    {
                        17,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4004),
                        false,
                        1,
                        39.49m,
                        1,
                        null,
                    },
                    {
                        18,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4010),
                        false,
                        7,
                        54.59m,
                        2,
                        null,
                    },
                    {
                        19,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4016),
                        false,
                        9,
                        49.51m,
                        3,
                        null,
                    },
                    {
                        20,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4022),
                        false,
                        11,
                        69.28m,
                        1,
                        null,
                    },
                    {
                        21,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4028),
                        false,
                        9,
                        62.37m,
                        1,
                        null,
                    },
                    {
                        22,
                        20,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4035),
                        false,
                        9,
                        40.04m,
                        3,
                        null,
                    },
                    {
                        23,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4043),
                        false,
                        10,
                        91.64m,
                        3,
                        null,
                    },
                    {
                        24,
                        13,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4050),
                        false,
                        3,
                        19.40m,
                        1,
                        null,
                    },
                    {
                        25,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4062),
                        false,
                        3,
                        26.94m,
                        3,
                        null,
                    },
                    {
                        26,
                        13,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4068),
                        false,
                        13,
                        42.72m,
                        3,
                        null,
                    },
                    {
                        27,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4079),
                        false,
                        7,
                        13.07m,
                        1,
                        null,
                    },
                    {
                        28,
                        8,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4085),
                        false,
                        15,
                        18.14m,
                        2,
                        null,
                    },
                    {
                        29,
                        18,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4102),
                        false,
                        8,
                        86.67m,
                        2,
                        null,
                    },
                    {
                        30,
                        12,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4110),
                        false,
                        2,
                        18.24m,
                        1,
                        null,
                    },
                    {
                        31,
                        16,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4117),
                        false,
                        9,
                        64.06m,
                        2,
                        null,
                    },
                    {
                        32,
                        20,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4128),
                        false,
                        11,
                        61.69m,
                        2,
                        null,
                    },
                    {
                        33,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4135),
                        false,
                        1,
                        18.03m,
                        1,
                        null,
                    },
                    {
                        34,
                        20,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4141),
                        false,
                        2,
                        35.63m,
                        2,
                        null,
                    },
                    {
                        35,
                        1,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4147),
                        false,
                        10,
                        48.01m,
                        3,
                        null,
                    },
                    {
                        36,
                        16,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4153),
                        false,
                        5,
                        67.05m,
                        3,
                        null,
                    },
                    {
                        37,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4160),
                        false,
                        10,
                        66.32m,
                        2,
                        null,
                    },
                    {
                        38,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4166),
                        false,
                        2,
                        21.64m,
                        1,
                        null,
                    },
                    {
                        39,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4172),
                        false,
                        1,
                        74.84m,
                        2,
                        null,
                    },
                    {
                        40,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4210),
                        false,
                        4,
                        94.79m,
                        1,
                        null,
                    },
                    {
                        41,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4217),
                        false,
                        5,
                        21.54m,
                        2,
                        null,
                    },
                    {
                        42,
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4223),
                        false,
                        7,
                        97.89m,
                        3,
                        null,
                    },
                    {
                        43,
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4230),
                        false,
                        15,
                        79.86m,
                        2,
                        null,
                    },
                    {
                        44,
                        5,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4237),
                        false,
                        10,
                        66.25m,
                        2,
                        null,
                    },
                    {
                        45,
                        11,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4243),
                        false,
                        9,
                        42.56m,
                        3,
                        null,
                    },
                    {
                        46,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4249),
                        false,
                        7,
                        73.57m,
                        2,
                        null,
                    },
                    {
                        47,
                        20,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4255),
                        false,
                        13,
                        29.41m,
                        2,
                        null,
                    },
                    {
                        48,
                        6,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4261),
                        false,
                        13,
                        51.05m,
                        3,
                        null,
                    },
                    {
                        49,
                        1,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4268),
                        false,
                        9,
                        95.06m,
                        1,
                        null,
                    },
                    {
                        50,
                        20,
                        new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4274),
                        false,
                        5,
                        96.78m,
                        3,
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[]
                {
                    "Id",
                    "BookId",
                    "Comment",
                    "CreatedDate",
                    "IsDeleted",
                    "Stars",
                    "UpdatedDate",
                    "UserId",
                },
                values: new object[,]
                {
                    {
                        1,
                        10,
                        "Labore fugit quia dolorem.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(3535),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        2,
                        9,
                        "Eaque ut quae.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4636),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        3,
                        3,
                        "Necessitatibus atque consequatur qui.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4695),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        4,
                        10,
                        "Est exercitationem aut earum nulla quisquam dolores id vel.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4713),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        5,
                        20,
                        "Voluptas nulla est.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4735),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        6,
                        5,
                        "Dolor quasi aliquid sint laboriosam.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4746),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        7,
                        4,
                        "Nihil error quas.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4762),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        8,
                        15,
                        "Nobis assumenda praesentium omnis recusandae.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4773),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        9,
                        15,
                        "Delectus unde suscipit omnis dolorum ipsam qui eaque sed vero.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4789),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        10,
                        6,
                        "Non enim quidem tenetur a odit reiciendis id.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4913),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        11,
                        10,
                        "Nostrum laudantium illum et illo quam.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4933),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        12,
                        1,
                        "Tempore dolorem voluptatem voluptates temporibus fuga voluptatem et accusantium.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4949),
                        false,
                        5,
                        null,
                        2,
                    },
                    {
                        13,
                        10,
                        "Ipsa ipsum beatae qui quibusdam ab.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4973),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        14,
                        4,
                        "Quibusdam qui omnis ut sit vero est odio.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4989),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        15,
                        2,
                        "Voluptates eaque quam vel dicta saepe enim quo in.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5008),
                        false,
                        2,
                        null,
                        10,
                    },
                    {
                        16,
                        20,
                        "Accusantium sint repellat unde enim hic aperiam suscipit voluptates.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5029),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        17,
                        16,
                        "Quia rerum blanditiis deleniti quos nobis ducimus ea nobis nihil.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5091),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        18,
                        11,
                        "Corporis dolor vero exercitationem vitae non.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5114),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        19,
                        17,
                        "Quo officia consequatur est sed error id corrupti ullam at.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5128),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        20,
                        19,
                        "Maxime laboriosam officia vitae quis.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5152),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        21,
                        19,
                        "Ullam eos placeat enim ut.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5165),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        22,
                        20,
                        "Voluptatem odit enim facilis officia mollitia eum.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5179),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        23,
                        10,
                        "Et reprehenderit quo minus dolores error dicta accusantium.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5196),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        24,
                        19,
                        "Optio qui molestias consequatur consequatur voluptatem ut officiis culpa vel.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5243),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        25,
                        20,
                        "Suscipit beatae hic qui ea reiciendis voluptatem.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5267),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        26,
                        2,
                        "Ab pariatur iure aliquam et.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5285),
                        false,
                        5,
                        null,
                        4,
                    },
                    {
                        27,
                        7,
                        "Quis exercitationem vitae ad et ex adipisci voluptas doloremque.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5301),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        28,
                        13,
                        "Impedit omnis laboriosam nobis saepe error molestias quia qui.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5322),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        29,
                        16,
                        "Delectus aut est expedita.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5342),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        30,
                        16,
                        "Ipsa et rerum et veritatis delectus velit.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5357),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        31,
                        12,
                        "Hic impedit cum autem tempore.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5376),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        32,
                        17,
                        "Non ipsa cumque recusandae qui.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5419),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        33,
                        16,
                        "Beatae iste illum qui distinctio sunt.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5433),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        34,
                        8,
                        "Illo ut expedita vel asperiores repellat minus ipsum.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5452),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        35,
                        17,
                        "Est sit aspernatur commodi sed qui maxime et magni architecto.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5471),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        36,
                        14,
                        "Id quo et temporibus animi sequi.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5493),
                        false,
                        2,
                        null,
                        10,
                    },
                    {
                        37,
                        10,
                        "Dolorem autem aut accusantium ut dignissimos.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5509),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        38,
                        2,
                        "Nihil totam aperiam.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5524),
                        false,
                        5,
                        null,
                        6,
                    },
                    {
                        39,
                        4,
                        "Maxime maxime rerum tempora earum expedita illo.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5535),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        40,
                        11,
                        "Voluptatem cumque autem molestias eum et atque quasi doloribus.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5584),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        41,
                        11,
                        "Et vitae iure sequi modi doloribus officia quis illum eaque.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5606),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        42,
                        2,
                        "Est vitae est molestias labore qui fuga doloribus nihil assumenda.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5628),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        43,
                        19,
                        "Autem voluptate maxime harum eum quia debitis natus.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5650),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        44,
                        9,
                        "Quis id et quo dignissimos suscipit.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5668),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        45,
                        18,
                        "Esse nihil odio ipsum cum molestiae.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5684),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        46,
                        11,
                        "Repudiandae consequatur expedita sapiente.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5700),
                        false,
                        5,
                        null,
                        5,
                    },
                    {
                        47,
                        19,
                        "Sed quia enim iste quis iure ducimus sint.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5742),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        48,
                        18,
                        "Ut eum quas sit reprehenderit delectus.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5763),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        49,
                        2,
                        "Repudiandae et nemo magnam consequatur.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5778),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        50,
                        6,
                        "Eum voluptatem consequatur quo aspernatur in laboriosam illum fugit optio.",
                        new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5792),
                        false,
                        3,
                        null,
                        4,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "WishlistItems",
                columns: new[]
                {
                    "Id",
                    "BookId",
                    "CreatedDate",
                    "IsDeleted",
                    "UpdatedDate",
                    "UserId",
                },
                values: new object[,]
                {
                    {
                        1,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8413),
                        false,
                        null,
                        5,
                    },
                    {
                        2,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8597),
                        false,
                        null,
                        8,
                    },
                    {
                        3,
                        2,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8604),
                        false,
                        null,
                        7,
                    },
                    {
                        4,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8607),
                        false,
                        null,
                        3,
                    },
                    {
                        5,
                        12,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8610),
                        false,
                        null,
                        3,
                    },
                    {
                        6,
                        14,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8612),
                        false,
                        null,
                        9,
                    },
                    {
                        7,
                        14,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8615),
                        false,
                        null,
                        2,
                    },
                    {
                        8,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8618),
                        false,
                        null,
                        2,
                    },
                    {
                        9,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8620),
                        false,
                        null,
                        4,
                    },
                    {
                        10,
                        1,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8623),
                        false,
                        null,
                        9,
                    },
                    {
                        11,
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8625),
                        false,
                        null,
                        5,
                    },
                    {
                        12,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8628),
                        false,
                        null,
                        8,
                    },
                    {
                        13,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8630),
                        false,
                        null,
                        5,
                    },
                    {
                        14,
                        8,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8633),
                        false,
                        null,
                        7,
                    },
                    {
                        15,
                        10,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8635),
                        false,
                        null,
                        10,
                    },
                    {
                        16,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8638),
                        false,
                        null,
                        6,
                    },
                    {
                        17,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8641),
                        false,
                        null,
                        7,
                    },
                    {
                        18,
                        13,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8644),
                        false,
                        null,
                        6,
                    },
                    {
                        19,
                        19,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8646),
                        false,
                        null,
                        5,
                    },
                    {
                        20,
                        4,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8649),
                        false,
                        null,
                        5,
                    },
                    {
                        21,
                        18,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8651),
                        false,
                        null,
                        4,
                    },
                    {
                        22,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8654),
                        false,
                        null,
                        8,
                    },
                    {
                        23,
                        11,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8656),
                        false,
                        null,
                        10,
                    },
                    {
                        24,
                        7,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8659),
                        false,
                        null,
                        4,
                    },
                    {
                        25,
                        13,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8661),
                        false,
                        null,
                        9,
                    },
                    {
                        26,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8664),
                        false,
                        null,
                        3,
                    },
                    {
                        27,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8667),
                        false,
                        null,
                        6,
                    },
                    {
                        28,
                        1,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8669),
                        false,
                        null,
                        5,
                    },
                    {
                        29,
                        9,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8672),
                        false,
                        null,
                        5,
                    },
                    {
                        30,
                        3,
                        new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8674),
                        false,
                        null,
                        10,
                    },
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId"
            );

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId"
            );

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail"
            );

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_BookGenreLink_BookId",
                table: "BookGenreLink",
                column: "BookId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_BookGenreLink_GenreId",
                table: "BookGenreLink",
                column: "GenreId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Books_LastEditorId",
                table: "Books",
                column: "LastEditorId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Books_PrimaryGenreId",
                table: "Books",
                column: "PrimaryGenreId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookId",
                table: "CartItems",
                column: "BookId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true
            );

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_BookId",
                table: "OrderItems",
                column: "BookId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BillingAddressId",
                table: "Orders",
                column: "BillingAddressId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShippingAddressId",
                table: "Orders",
                column: "ShippingAddressId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookId",
                table: "Reviews",
                column: "BookId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_BookId",
                table: "WishlistItems",
                column: "BookId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItems_UserId",
                table: "WishlistItems",
                column: "UserId"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "AspNetRoleClaims");

            migrationBuilder.DropTable(name: "AspNetUserClaims");

            migrationBuilder.DropTable(name: "AspNetUserLogins");

            migrationBuilder.DropTable(name: "AspNetUserRoles");

            migrationBuilder.DropTable(name: "AspNetUserTokens");

            migrationBuilder.DropTable(name: "BookGenreLink");

            migrationBuilder.DropTable(name: "CartItems");

            migrationBuilder.DropTable(name: "OrderItems");

            migrationBuilder.DropTable(name: "Reviews");

            migrationBuilder.DropTable(name: "WishlistItems");

            migrationBuilder.DropTable(name: "AspNetRoles");

            migrationBuilder.DropTable(name: "Carts");

            migrationBuilder.DropTable(name: "Orders");

            migrationBuilder.DropTable(name: "Books");

            migrationBuilder.DropTable(name: "Addresses");

            migrationBuilder.DropTable(name: "AspNetUsers");

            migrationBuilder.DropTable(name: "Authors");

            migrationBuilder.DropTable(name: "BookGenre");

            migrationBuilder.DropTable(name: "Publishers");
        }
    }
}
