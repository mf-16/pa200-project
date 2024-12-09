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
                        "South Bettie",
                        "Chad",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(1168),
                        false,
                        "Washington",
                        "0067 Sydni Mountain",
                        null,
                        "16362-4558",
                    },
                    {
                        2,
                        "Lake Henryhaven",
                        "Ecuador",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(1711),
                        false,
                        "West Virginia",
                        "1455 Rath Summit",
                        null,
                        "76054-8998",
                    },
                    {
                        3,
                        "Hintzfurt",
                        "Aruba",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(1861),
                        false,
                        "Pennsylvania",
                        "9186 Erick Views",
                        null,
                        "72496-3574",
                    },
                    {
                        4,
                        "South Darrelfurt",
                        "Papua New Guinea",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(1977),
                        false,
                        "South Dakota",
                        "42447 Ratke Coves",
                        null,
                        "11615-6950",
                    },
                    {
                        5,
                        "Zulaufmouth",
                        "Tuvalu",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2127),
                        false,
                        "Alaska",
                        "636 Sauer Tunnel",
                        null,
                        "03121-6700",
                    },
                    {
                        6,
                        "West Louport",
                        "Bermuda",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2246),
                        false,
                        "Delaware",
                        "68461 Humberto Parkway",
                        null,
                        "27144",
                    },
                    {
                        7,
                        "Loweport",
                        "Saudi Arabia",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2378),
                        false,
                        "Washington",
                        "086 Tad Skyway",
                        null,
                        "04853-9029",
                    },
                    {
                        8,
                        "New Veronicastad",
                        "Cyprus",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2480),
                        false,
                        "Michigan",
                        "4844 Bradford Flats",
                        null,
                        "39773",
                    },
                    {
                        9,
                        "East Bailee",
                        "Cameroon",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2637),
                        false,
                        "Nevada",
                        "4567 Gusikowski Corner",
                        null,
                        "23126",
                    },
                    {
                        10,
                        "Durganstad",
                        "Senegal",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2763),
                        false,
                        "South Dakota",
                        "9304 Aiden Station",
                        null,
                        "57906-9882",
                    },
                    {
                        11,
                        "Port Margarettaport",
                        "Austria",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2876),
                        false,
                        "Alaska",
                        "0143 Noemy Glens",
                        null,
                        "30317",
                    },
                    {
                        12,
                        "Blandaside",
                        "Kazakhstan",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(2990),
                        false,
                        "New Hampshire",
                        "99264 Lavern Mount",
                        null,
                        "41688",
                    },
                    {
                        13,
                        "Eldorafurt",
                        "China",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(3104),
                        false,
                        "Wisconsin",
                        "9818 Kihn Points",
                        null,
                        "22769",
                    },
                    {
                        14,
                        "New Rebamouth",
                        "Suriname",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(3213),
                        false,
                        "Kansas",
                        "77396 Smith Lane",
                        null,
                        "87241",
                    },
                    {
                        15,
                        "North Charityhaven",
                        "South Africa",
                        new DateTime(2024, 12, 8, 21, 40, 34, 344, DateTimeKind.Utc).AddTicks(3327),
                        false,
                        "Texas",
                        "231 Cary Stream",
                        null,
                        "25678-9824",
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
                        "8136b68d-b615-4ea5-a49b-b7b981767d49",
                        "admin@admin.com",
                        true,
                        false,
                        null,
                        "Admin User",
                        null,
                        "ADMIN",
                        null,
                        "123-456-7890",
                        false,
                        "42ec9f8d-657a-4b4a-87e8-6c05bf3bf5e1",
                        false,
                        "admin",
                    },
                    {
                        2,
                        0,
                        "ca890266-ad46-4b49-a7f0-6141e158a810",
                        "Nikki7@hotmail.com",
                        true,
                        false,
                        null,
                        "Isadore Haley",
                        null,
                        null,
                        null,
                        "301-883-4171 x696",
                        false,
                        "4fb5ae20-54f4-4244-9a4a-a4f382666e02",
                        false,
                        "Verla_Larson98",
                    },
                    {
                        3,
                        0,
                        "89991cfd-c698-4ad0-a750-ddb3cacdbe42",
                        "Hayley96@yahoo.com",
                        true,
                        false,
                        null,
                        "Bertram Connelly",
                        null,
                        null,
                        null,
                        "587.935.2263",
                        false,
                        "74068ae3-0ff3-4f56-b219-f73b81e82d56",
                        false,
                        "Ollie48",
                    },
                    {
                        4,
                        0,
                        "c7e08ddd-3a5b-4071-9ad8-6140503bfa2e",
                        "Trystan_Spinka80@hotmail.com",
                        true,
                        false,
                        null,
                        "Brandi Rosenbaum",
                        null,
                        null,
                        null,
                        "1-705-308-9412 x735",
                        false,
                        "16c2cae8-f5c4-4677-b509-1211460d1870",
                        false,
                        "Ethelyn79",
                    },
                    {
                        5,
                        0,
                        "38fa33d7-fc8d-4e0d-95c6-55eb5e31a686",
                        "Elena44@hotmail.com",
                        true,
                        false,
                        null,
                        "Nia Hudson",
                        null,
                        null,
                        null,
                        "1-773-306-6629 x1733",
                        false,
                        "10409526-136d-4c82-bd6d-e10f3f1463f8",
                        false,
                        "Alisha.Barton59",
                    },
                    {
                        6,
                        0,
                        "f1096435-535c-4799-b588-923ed54734c7",
                        "Zola_Bosco69@gmail.com",
                        true,
                        false,
                        null,
                        "Helene Schinner",
                        null,
                        null,
                        null,
                        "548.599.7776 x6720",
                        false,
                        "61da8645-0e69-451a-a631-fff8ed646727",
                        false,
                        "Ashton.Dickens",
                    },
                    {
                        7,
                        0,
                        "fdf5a781-e094-4034-95d5-6d8791254b1d",
                        "Veda40@gmail.com",
                        true,
                        false,
                        null,
                        "Kaylah Dooley",
                        null,
                        null,
                        null,
                        "756-667-7297",
                        false,
                        "e608eae7-fb4f-4c2a-8363-e98e9451b6da",
                        false,
                        "Sienna_Ebert",
                    },
                    {
                        8,
                        0,
                        "98fc8ac2-1002-4c1c-85ea-6c22574d4d0b",
                        "Jena_Bergnaum@yahoo.com",
                        true,
                        false,
                        null,
                        "Toy Gibson",
                        null,
                        null,
                        null,
                        "590-973-9453 x348",
                        false,
                        "759f477b-b157-496c-ab90-39f28235b0f9",
                        false,
                        "Osbaldo.Harris",
                    },
                    {
                        9,
                        0,
                        "3ca7ee78-2b25-4785-8156-fed92a9b2cee",
                        "Berneice.Schultz@yahoo.com",
                        true,
                        false,
                        null,
                        "Hobart Douglas",
                        null,
                        null,
                        null,
                        "(644) 717-9375",
                        false,
                        "20f6288f-b8f5-4fed-b37c-d82916e1b2f2",
                        false,
                        "Mabelle64",
                    },
                    {
                        10,
                        0,
                        "deb64e6a-649e-46a7-90eb-2640c460ac95",
                        "Zoe96@gmail.com",
                        true,
                        false,
                        null,
                        "Jovanny Price",
                        null,
                        null,
                        null,
                        "1-472-655-5756",
                        false,
                        "de3134c6-0df2-4134-bc39-7ec13e644b0c",
                        false,
                        "Zoila_Jones70",
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
                        "Maiores nostrum nobis soluta. Mollitia nihil laudantium voluptates ullam quam corrupti consequatur rerum. Voluptas officia reiciendis atque. Distinctio nostrum illo et optio commodi qui.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(4084),
                        false,
                        "Esteban Murphy",
                        null,
                    },
                    {
                        2,
                        "Ut quae doloremque laborum vel autem voluptate. Libero neque velit consectetur adipisci at. Molestiae dolore quia ipsum nesciunt velit. Amet perferendis voluptas ab.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(4449),
                        false,
                        "Kali Hoeger",
                        null,
                    },
                    {
                        3,
                        "Dolore optio odio sequi laborum rerum excepturi. Doloremque dicta provident adipisci voluptatum sunt est ipsam hic et. Ad animi sed animi aut. Molestiae tempore vero inventore rerum ut sed. Cum sit consequatur. Quo deserunt facilis.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(4623),
                        false,
                        "Angeline Turner",
                        null,
                    },
                    {
                        4,
                        "Vel sed saepe. Excepturi enim quia similique beatae magni facilis modi vitae sit. Pariatur et officia voluptates dolorum. Qui dolore id.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(4749),
                        false,
                        "Verla Huels",
                        null,
                    },
                    {
                        5,
                        "Et quo suscipit. Soluta fugit consequuntur totam fuga suscipit soluta adipisci. Sit labore expedita aspernatur laborum ab veritatis sequi ex sed. Fuga nemo accusamus animi id voluptas exercitationem tempore consequuntur. Ratione aut ut qui. Ea magnam et ea consequatur et natus saepe.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(4868),
                        false,
                        "Esperanza Tromp",
                        null,
                    },
                    {
                        6,
                        "Dolorem molestiae quia adipisci ab vero harum animi. Placeat eos pariatur cum molestias pariatur ducimus. Rerum voluptate iusto itaque omnis commodi amet impedit. Mollitia sed ipsum sequi non facere possimus.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(5003),
                        false,
                        "Barney Lockman",
                        null,
                    },
                    {
                        7,
                        "Numquam sunt quasi laboriosam dolores error voluptates consequatur. Totam rem aut aut eaque incidunt in voluptatibus. Sit distinctio minima velit et labore.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(5090),
                        false,
                        "Rozella Adams",
                        null,
                    },
                    {
                        8,
                        "Repellendus sint tempore quasi in vel qui odit corporis qui. Porro laboriosam pariatur iure non cupiditate. Id soluta in animi. Eius eum et totam enim voluptas quae quia quibusdam consectetur. Quasi eos quod tenetur ipsum.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(5235),
                        false,
                        "Aaliyah Jast",
                        null,
                    },
                    {
                        9,
                        "Molestias esse quas consequatur maxime non eos. Velit velit veniam est alias rerum corporis ut. Et sequi placeat aliquam aspernatur voluptas deleniti quia. Deleniti quisquam velit distinctio ducimus provident eos qui aut.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(5325),
                        false,
                        "Manley Schmidt",
                        null,
                    },
                    {
                        10,
                        "Ipsa rerum cupiditate deserunt delectus aliquid doloremque dolorum eveniet. Non dolor sed aut voluptates et. Deserunt et et saepe nesciunt in veritatis. Rerum culpa cupiditate non unde. Autem commodi enim dignissimos.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 336, DateTimeKind.Utc).AddTicks(5482),
                        false,
                        "Moises Weimann",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Qui ullam placeat." },
                    { 2, "Cupiditate illo id." },
                    { 3, "Illum sint voluptas." },
                    { 4, "Debitis perferendis hic." },
                    { 5, "Esse iste maxime." },
                    { 6, "Neque aperiam vitae." },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Assumenda iste voluptatem. Laboriosam exercitationem ab deleniti voluptates inventore facilis est hic. Et consectetur quod occaecati eius occaecati. Laudantium totam ratione provident recusandae enim vero minus dolorum ut. Illum laudantium rerum quo pariatur vero aperiam dolorem perferendis.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 337, DateTimeKind.Utc).AddTicks(8024),
                        false,
                        "Beatty - Gibson",
                        null,
                    },
                    {
                        2,
                        "Earum est ut et. Ipsa vitae nihil. Quidem eum quia tempora voluptatum. Ut adipisci aut. Possimus excepturi nostrum ab aut dolore saepe laudantium expedita. Incidunt voluptate sit ut.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 337, DateTimeKind.Utc).AddTicks(8581),
                        false,
                        "Steuber, Hermann and Hand",
                        null,
                    },
                    {
                        3,
                        "Eius voluptatem voluptas ad atque labore ullam. Sit accusamus et voluptas iure et. Labore est laborum distinctio autem ut totam velit quia excepturi.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 337, DateTimeKind.Utc).AddTicks(8756),
                        false,
                        "Dietrich and Sons",
                        null,
                    },
                    {
                        4,
                        "Est maiores voluptate mollitia sit et sit. Est eos eos voluptas. Saepe laborum recusandae sequi. Non est qui numquam minus est vel et. Qui unde sit aliquid quae nesciunt excepturi molestiae amet totam.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 337, DateTimeKind.Utc).AddTicks(9006),
                        false,
                        "Cole, Sanford and Rolfson",
                        null,
                    },
                    {
                        5,
                        "Vitae fugit est expedita earum deleniti nam temporibus. Ullam necessitatibus eum. Quibusdam harum voluptatem fuga nihil tempora quam.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 337, DateTimeKind.Utc).AddTicks(9186),
                        false,
                        "Mueller, Littel and Larkin",
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
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(3134),
                        "Omnis reprehenderit ut et. Assumenda ut sit a impedit sint culpa repellendus numquam. Suscipit voluptatem magni nam nisi et totam. Possimus maiores saepe voluptate inventore quidem ut. Maiores tempore rerum qui odio magni similique ad dolorem. Nulla ut vitae aliquid quia minus nam omnis.",
                        0,
                        "https://picsum.photos/640/480/?image=975",
                        false,
                        null,
                        71.17m,
                        2,
                        3,
                        "Explicabo aut corrupti.",
                        null,
                    },
                    {
                        2,
                        9,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(4612),
                        "Delectus dignissimos nam dolorum. Ea assumenda magnam sit a blanditiis possimus. Facilis ipsa deserunt nihil voluptatibus doloremque. Aliquid qui eligendi incidunt ullam nesciunt sint.",
                        0,
                        "https://picsum.photos/640/480/?image=764",
                        false,
                        null,
                        85.69m,
                        2,
                        4,
                        "Qui exercitationem rerum.",
                        null,
                    },
                    {
                        3,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(4722),
                        "Impedit laboriosam cumque voluptates mollitia iste et quo. Dolorem mollitia vel. Quia nihil quidem et culpa.",
                        0,
                        "https://picsum.photos/640/480/?image=481",
                        false,
                        null,
                        19.83m,
                        5,
                        4,
                        "Aut non quo.",
                        null,
                    },
                    {
                        4,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(4809),
                        "Enim ut enim. Soluta et dolor earum ratione eos occaecati sapiente. Quos tempora enim quia consequatur.",
                        0,
                        "https://picsum.photos/640/480/?image=924",
                        false,
                        null,
                        89.05m,
                        3,
                        5,
                        "Autem sed voluptas.",
                        null,
                    },
                    {
                        5,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(4871),
                        "Odio et quae rerum nesciunt eius cupiditate quam. Assumenda et sapiente iusto a. Eligendi quibusdam quibusdam repellat in. Fuga vel consectetur aut. Laborum sed officia qui veniam ab. Ratione voluptatem placeat ducimus.",
                        0,
                        "https://picsum.photos/640/480/?image=245",
                        false,
                        null,
                        96.70m,
                        2,
                        1,
                        "Beatae sit nihil.",
                        null,
                    },
                    {
                        6,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(4990),
                        "Debitis excepturi quis quis natus temporibus eligendi totam exercitationem. Sed vel vel enim sequi culpa facere saepe molestias ducimus. Quia voluptatem est quidem quis explicabo. Non labore eum. Voluptatem magni et qui ab. Rerum culpa dolores explicabo.",
                        0,
                        "https://picsum.photos/640/480/?image=712",
                        false,
                        null,
                        75.41m,
                        5,
                        1,
                        "Ducimus sit ipsam.",
                        null,
                    },
                    {
                        7,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5117),
                        "Architecto qui molestias ipsum voluptatem repellendus rerum repellat. Et maiores nulla voluptatibus harum non error consequatur. Quae quae et. Id quia perspiciatis non alias et. Voluptatem nostrum quia qui odit. Dicta tempora officiis aperiam quo.",
                        0,
                        "https://picsum.photos/640/480/?image=595",
                        false,
                        null,
                        25.57m,
                        4,
                        5,
                        "Ut architecto neque.",
                        null,
                    },
                    {
                        8,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5239),
                        "Omnis aut facilis recusandae et necessitatibus illum. Eveniet voluptas ex natus ipsam numquam. Voluptas rerum dignissimos assumenda iste et aut explicabo.",
                        0,
                        "https://picsum.photos/640/480/?image=784",
                        false,
                        null,
                        59.94m,
                        5,
                        3,
                        "Aut ipsa commodi.",
                        null,
                    },
                    {
                        9,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5303),
                        "Ipsa eos vero harum libero molestiae rerum. Voluptas minima est. Non necessitatibus iusto.",
                        0,
                        "https://picsum.photos/640/480/?image=781",
                        false,
                        null,
                        44.65m,
                        3,
                        1,
                        "Ut qui vel.",
                        null,
                    },
                    {
                        10,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5392),
                        "Iusto fugit qui fugit natus explicabo amet. Consectetur ut iure nemo atque tenetur vitae voluptas quia quia. Accusantium qui quia ut similique consequatur ex. Cum officia libero cum ex.",
                        0,
                        "https://picsum.photos/640/480/?image=874",
                        false,
                        null,
                        73.42m,
                        5,
                        4,
                        "Quibusdam et et.",
                        null,
                    },
                    {
                        11,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5537),
                        "Velit deserunt nulla sint dignissimos vero rerum soluta aliquam. Praesentium consequuntur praesentium tempora temporibus iure officiis totam illum laudantium. Quam dolor reiciendis sequi corrupti dignissimos porro voluptate. Earum eum est iure voluptatem. Asperiores et odio illum odio.",
                        0,
                        "https://picsum.photos/640/480/?image=24",
                        false,
                        null,
                        43.97m,
                        4,
                        5,
                        "Optio quae dignissimos.",
                        null,
                    },
                    {
                        12,
                        6,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5645),
                        "Omnis illum vitae atque voluptas fugiat. Dolorem id sunt. Quasi molestias ipsum omnis. Optio est aut id quaerat vel ut vitae vel. In sed sint. Sunt similique id ad ex sit labore facilis soluta.",
                        0,
                        "https://picsum.photos/640/480/?image=393",
                        false,
                        null,
                        95.05m,
                        1,
                        2,
                        "Qui fuga dolores.",
                        null,
                    },
                    {
                        13,
                        3,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5810),
                        "Nesciunt consequatur ea quia. Ad adipisci ipsum harum soluta exercitationem. Officiis quaerat necessitatibus qui temporibus placeat reprehenderit.",
                        0,
                        "https://picsum.photos/640/480/?image=109",
                        false,
                        null,
                        36.69m,
                        5,
                        5,
                        "Inventore debitis labore.",
                        null,
                    },
                    {
                        14,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5862),
                        "Libero quia nam aut mollitia. Rerum odio aliquam error sed. Sed cum officia corporis iure.",
                        0,
                        "https://picsum.photos/640/480/?image=852",
                        false,
                        null,
                        46.04m,
                        5,
                        1,
                        "Nulla porro animi.",
                        null,
                    },
                    {
                        15,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(5967),
                        "Consequatur quo et blanditiis sequi distinctio recusandae. Et voluptas ut nihil quibusdam vel occaecati. Exercitationem dolores reprehenderit velit qui soluta harum. Voluptas ex saepe iure. Sit rem quibusdam odit saepe. At hic tempora impedit quis rerum.",
                        0,
                        "https://picsum.photos/640/480/?image=588",
                        false,
                        null,
                        48.65m,
                        3,
                        3,
                        "Tempore sed fugit.",
                        null,
                    },
                    {
                        16,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(6084),
                        "Pariatur quo dolore itaque ut reiciendis omnis voluptatum sit. Sit dolores atque quo maiores quia asperiores. Vel architecto debitis sit praesentium et excepturi veniam omnis ea. Magnam autem repellendus nostrum. Repellendus ducimus dignissimos id facere ut dolores distinctio explicabo sit.",
                        0,
                        "https://picsum.photos/640/480/?image=895",
                        false,
                        null,
                        96.29m,
                        5,
                        4,
                        "Nihil quo cumque.",
                        null,
                    },
                    {
                        17,
                        9,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(6200),
                        "Fuga maxime dolorum numquam. Maxime debitis aliquid id exercitationem et doloribus. Quas velit dolorum laboriosam perspiciatis.",
                        0,
                        "https://picsum.photos/640/480/?image=314",
                        false,
                        null,
                        27.67m,
                        6,
                        2,
                        "Aut eum magnam.",
                        null,
                    },
                    {
                        18,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(6250),
                        "Corrupti tempore nulla numquam. Vel in et temporibus. Dolor excepturi incidunt magni accusamus quia. Perferendis voluptas dignissimos tenetur eos error placeat nemo temporibus quis.",
                        0,
                        "https://picsum.photos/640/480/?image=204",
                        false,
                        null,
                        58.33m,
                        4,
                        2,
                        "Culpa quibusdam soluta.",
                        null,
                    },
                    {
                        19,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(6338),
                        "Non praesentium sunt repellendus nihil. Rerum adipisci dolorem accusamus. Aut modi reprehenderit dignissimos doloremque est molestiae quae. Aut quae est. Aut quia ut aliquid debitis distinctio dolores.",
                        0,
                        "https://picsum.photos/640/480/?image=585",
                        false,
                        null,
                        84.40m,
                        6,
                        2,
                        "Ducimus cupiditate omnis.",
                        null,
                    },
                    {
                        20,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 340, DateTimeKind.Utc).AddTicks(6407),
                        "Magnam assumenda aspernatur numquam. Quos dolorum et veniam ipsum perspiciatis. Voluptatem recusandae enim dicta accusamus.",
                        0,
                        "https://picsum.photos/640/480/?image=451",
                        false,
                        null,
                        79.54m,
                        4,
                        2,
                        "Ratione explicabo autem.",
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
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8488),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8489),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8490),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8490),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8490),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8491),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8491),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8491),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8491),
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
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 345, DateTimeKind.Utc).AddTicks(5879),
                        "Debra.Hamill@yahoo.com",
                        "Debra Hamill",
                        false,
                        8,
                        0m,
                        null,
                        6,
                    },
                    {
                        2,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 345, DateTimeKind.Utc).AddTicks(8483),
                        "Estelle95@gmail.com",
                        "Estelle Rutherford",
                        false,
                        9,
                        0m,
                        null,
                        4,
                    },
                    {
                        3,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 345, DateTimeKind.Utc).AddTicks(9327),
                        "Natalie_Bruen@hotmail.com",
                        "Natalie Bruen",
                        false,
                        2,
                        0m,
                        null,
                        2,
                    },
                    {
                        4,
                        13,
                        new DateTime(2024, 12, 8, 21, 40, 34, 345, DateTimeKind.Utc).AddTicks(9863),
                        "Nettie98@hotmail.com",
                        "Nettie Sporer",
                        false,
                        11,
                        0m,
                        null,
                        4,
                    },
                    {
                        5,
                        14,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(348),
                        "Jenny.Buckridge@hotmail.com",
                        "Jenny Buckridge",
                        false,
                        14,
                        0m,
                        null,
                        7,
                    },
                    {
                        6,
                        13,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(926),
                        "Alan_Flatley27@hotmail.com",
                        "Alan Flatley",
                        false,
                        8,
                        0m,
                        null,
                        4,
                    },
                    {
                        7,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(1658),
                        "Earl11@gmail.com",
                        "Earl Hilll",
                        false,
                        9,
                        0m,
                        null,
                        7,
                    },
                    {
                        8,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(2133),
                        "Tim_Miller53@gmail.com",
                        "Tim Miller",
                        false,
                        7,
                        0m,
                        null,
                        5,
                    },
                    {
                        9,
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(2597),
                        "Arthur.Kilback37@yahoo.com",
                        "Arthur Kilback",
                        false,
                        14,
                        0m,
                        null,
                        5,
                    },
                    {
                        10,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(3079),
                        "Kristina83@hotmail.com",
                        "Kristina Yundt",
                        false,
                        7,
                        0m,
                        null,
                        7,
                    },
                    {
                        11,
                        15,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(3490),
                        "Estelle31@yahoo.com",
                        "Estelle Hermiston",
                        false,
                        1,
                        0m,
                        null,
                        6,
                    },
                    {
                        12,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(4032),
                        "Fernando18@hotmail.com",
                        "Fernando Douglas",
                        false,
                        10,
                        0m,
                        null,
                        2,
                    },
                    {
                        13,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(4543),
                        "Cornelius72@hotmail.com",
                        "Cornelius Barton",
                        false,
                        6,
                        0m,
                        null,
                        4,
                    },
                    {
                        14,
                        6,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(4984),
                        "Pat_Botsford@gmail.com",
                        "Pat Botsford",
                        false,
                        2,
                        0m,
                        null,
                        10,
                    },
                    {
                        15,
                        1,
                        new DateTime(2024, 12, 8, 21, 40, 34, 346, DateTimeKind.Utc).AddTicks(5420),
                        "Joan.Heidenreich6@gmail.com",
                        "Joan Heidenreich",
                        false,
                        7,
                        0m,
                        null,
                        9,
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
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(6840),
                        false,
                        2,
                        99.11m,
                        2,
                        null,
                    },
                    {
                        2,
                        12,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7919),
                        false,
                        3,
                        42.68m,
                        1,
                        null,
                    },
                    {
                        3,
                        16,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7957),
                        false,
                        2,
                        29.55m,
                        2,
                        null,
                    },
                    {
                        4,
                        14,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7967),
                        false,
                        8,
                        96.97m,
                        1,
                        null,
                    },
                    {
                        5,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7975),
                        false,
                        7,
                        95.19m,
                        1,
                        null,
                    },
                    {
                        6,
                        19,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7982),
                        false,
                        15,
                        38.44m,
                        1,
                        null,
                    },
                    {
                        7,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7988),
                        false,
                        10,
                        79.96m,
                        3,
                        null,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(7995),
                        false,
                        13,
                        14.78m,
                        2,
                        null,
                    },
                    {
                        9,
                        15,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8001),
                        false,
                        10,
                        82.66m,
                        1,
                        null,
                    },
                    {
                        10,
                        9,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8007),
                        false,
                        9,
                        77.00m,
                        3,
                        null,
                    },
                    {
                        11,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8014),
                        false,
                        4,
                        67.33m,
                        2,
                        null,
                    },
                    {
                        12,
                        6,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8020),
                        false,
                        13,
                        36.74m,
                        1,
                        null,
                    },
                    {
                        13,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8027),
                        false,
                        12,
                        20.20m,
                        3,
                        null,
                    },
                    {
                        14,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8034),
                        false,
                        2,
                        37.17m,
                        3,
                        null,
                    },
                    {
                        15,
                        15,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8040),
                        false,
                        4,
                        69.03m,
                        2,
                        null,
                    },
                    {
                        16,
                        6,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8047),
                        false,
                        8,
                        82.51m,
                        1,
                        null,
                    },
                    {
                        17,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8054),
                        false,
                        6,
                        65.41m,
                        1,
                        null,
                    },
                    {
                        18,
                        12,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8061),
                        false,
                        1,
                        31.74m,
                        3,
                        null,
                    },
                    {
                        19,
                        3,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8067),
                        false,
                        5,
                        22.55m,
                        2,
                        null,
                    },
                    {
                        20,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8074),
                        false,
                        5,
                        36.40m,
                        2,
                        null,
                    },
                    {
                        21,
                        11,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8080),
                        false,
                        10,
                        99.61m,
                        2,
                        null,
                    },
                    {
                        22,
                        9,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8087),
                        false,
                        8,
                        34.15m,
                        2,
                        null,
                    },
                    {
                        23,
                        1,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8153),
                        false,
                        4,
                        54.34m,
                        3,
                        null,
                    },
                    {
                        24,
                        20,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8161),
                        false,
                        5,
                        19.46m,
                        2,
                        null,
                    },
                    {
                        25,
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8168),
                        false,
                        1,
                        64.55m,
                        1,
                        null,
                    },
                    {
                        26,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8175),
                        false,
                        8,
                        42.70m,
                        1,
                        null,
                    },
                    {
                        27,
                        1,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8182),
                        false,
                        6,
                        99.13m,
                        3,
                        null,
                    },
                    {
                        28,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8188),
                        false,
                        14,
                        58.68m,
                        2,
                        null,
                    },
                    {
                        29,
                        13,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8195),
                        false,
                        12,
                        95.69m,
                        3,
                        null,
                    },
                    {
                        30,
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8201),
                        false,
                        11,
                        30.38m,
                        3,
                        null,
                    },
                    {
                        31,
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8208),
                        false,
                        1,
                        14.67m,
                        1,
                        null,
                    },
                    {
                        32,
                        17,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8215),
                        false,
                        7,
                        83.54m,
                        1,
                        null,
                    },
                    {
                        33,
                        13,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8221),
                        false,
                        10,
                        33.94m,
                        3,
                        null,
                    },
                    {
                        34,
                        13,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8227),
                        false,
                        3,
                        61.25m,
                        2,
                        null,
                    },
                    {
                        35,
                        11,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8234),
                        false,
                        12,
                        28.04m,
                        3,
                        null,
                    },
                    {
                        36,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8241),
                        false,
                        12,
                        78.73m,
                        1,
                        null,
                    },
                    {
                        37,
                        11,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8248),
                        false,
                        1,
                        80.96m,
                        2,
                        null,
                    },
                    {
                        38,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8254),
                        false,
                        8,
                        85.07m,
                        2,
                        null,
                    },
                    {
                        39,
                        16,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8261),
                        false,
                        4,
                        80.94m,
                        2,
                        null,
                    },
                    {
                        40,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8267),
                        false,
                        12,
                        98.37m,
                        2,
                        null,
                    },
                    {
                        41,
                        14,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8274),
                        false,
                        11,
                        59.93m,
                        3,
                        null,
                    },
                    {
                        42,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8281),
                        false,
                        9,
                        76.93m,
                        2,
                        null,
                    },
                    {
                        43,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8287),
                        false,
                        11,
                        56.21m,
                        1,
                        null,
                    },
                    {
                        44,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8293),
                        false,
                        3,
                        56.71m,
                        2,
                        null,
                    },
                    {
                        45,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8299),
                        false,
                        3,
                        30.18m,
                        1,
                        null,
                    },
                    {
                        46,
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8306),
                        false,
                        14,
                        54.34m,
                        3,
                        null,
                    },
                    {
                        47,
                        3,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8312),
                        false,
                        7,
                        42.29m,
                        2,
                        null,
                    },
                    {
                        48,
                        11,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8319),
                        false,
                        7,
                        24.86m,
                        2,
                        null,
                    },
                    {
                        49,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8326),
                        false,
                        7,
                        27.43m,
                        3,
                        null,
                    },
                    {
                        50,
                        15,
                        new DateTime(2024, 12, 8, 21, 40, 34, 347, DateTimeKind.Utc).AddTicks(8332),
                        false,
                        8,
                        74.14m,
                        1,
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
                        6,
                        "Dicta nisi a nemo quod neque eos.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(7298),
                        false,
                        2,
                        null,
                        8,
                    },
                    {
                        2,
                        14,
                        "Minus culpa ab voluptatem animi eius quo ratione.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8261),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        3,
                        12,
                        "Assumenda veritatis veritatis architecto commodi modi excepturi et.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8323),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        4,
                        18,
                        "Voluptatem facilis nulla aliquam eveniet.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8353),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        5,
                        9,
                        "Fugit quis fugiat sunt dolorem quia autem dolorum.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8417),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        6,
                        13,
                        "Omnis non et et.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8439),
                        false,
                        5,
                        null,
                        4,
                    },
                    {
                        7,
                        3,
                        "Placeat qui tempora omnis hic sapiente exercitationem sed labore.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8452),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        8,
                        17,
                        "Voluptatem ipsum et culpa.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8472),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        9,
                        4,
                        "Fugiat deleniti qui aut atque laboriosam accusantium est.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8485),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        10,
                        18,
                        "Culpa assumenda libero sunt ex culpa sed eaque culpa.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8505),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        11,
                        11,
                        "Consequatur perferendis atque quam omnis qui quia porro aut.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8525),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        12,
                        17,
                        "Impedit ratione neque.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8546),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        13,
                        15,
                        "Aut omnis quo odit nulla et reiciendis veritatis quos.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8582),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        14,
                        17,
                        "Illum laborum sed ea laudantium ex et fuga hic.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8603),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        15,
                        4,
                        "Sit enim quod quia qui nemo.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8623),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        16,
                        19,
                        "Nam nostrum odit.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8640),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        17,
                        10,
                        "Necessitatibus maxime dolorem consequuntur impedit voluptatem velit eius rerum nihil.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8651),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        18,
                        14,
                        "Quidem magni atque quod id eos.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8672),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        19,
                        14,
                        "Natus dolorem minus qui tenetur est.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8687),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        20,
                        17,
                        "Quasi dolorem similique laboriosam magnam rerum.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8702),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        21,
                        7,
                        "Mollitia et eveniet.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8734),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        22,
                        15,
                        "Labore labore enim fuga adipisci rem quae veritatis.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8745),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        23,
                        19,
                        "Aut sequi veritatis corporis deleniti odit adipisci ducimus.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8762),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        24,
                        16,
                        "Ut est non.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8781),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        25,
                        4,
                        "Consequatur voluptatum eos animi deserunt corrupti.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8792),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        26,
                        3,
                        "Quos quasi voluptatibus corrupti quaerat odit dicta laborum suscipit non.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8807),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        27,
                        13,
                        "Ipsum non doloribus sint ut odit.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8827),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        28,
                        16,
                        "Qui occaecati aut nemo.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8842),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        29,
                        14,
                        "Minus sint et sit nihil quos velit maiores suscipit sit.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8939),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        30,
                        20,
                        "Sed molestias earum rerum.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8966),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        31,
                        14,
                        "Necessitatibus distinctio voluptatum assumenda id suscipit esse.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8980),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        32,
                        9,
                        "Enim ipsam non.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(8997),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        33,
                        16,
                        "Id eos et consequuntur perspiciatis dignissimos voluptates adipisci.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9008),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        34,
                        13,
                        "Tenetur earum aspernatur nisi minima repudiandae nesciunt.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9027),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        35,
                        4,
                        "Dignissimos reiciendis blanditiis consequatur magnam et ipsam laboriosam nisi.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9052),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        36,
                        20,
                        "Quo ut eius qui aut nemo suscipit vel explicabo quae.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9070),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        37,
                        15,
                        "Quaerat illo facere iure rem aliquid ratione.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9143),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        38,
                        17,
                        "Maxime et modi necessitatibus ullam asperiores.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9164),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        39,
                        8,
                        "Iste suscipit itaque expedita laboriosam possimus soluta repudiandae.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9192),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        40,
                        8,
                        "Quam ab dicta culpa et delectus.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9214),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        41,
                        4,
                        "Dolor omnis ad molestias modi modi aperiam magnam dolorum.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9229),
                        false,
                        5,
                        null,
                        8,
                    },
                    {
                        42,
                        6,
                        "Error dolore est iure architecto explicabo vel rerum.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9249),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        43,
                        11,
                        "Qui non quidem ipsa qui aperiam et dolores officiis necessitatibus.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9267),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        44,
                        3,
                        "Ducimus dignissimos aspernatur temporibus est adipisci magni iusto nisi.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9340),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        45,
                        20,
                        "Rem eum vero dolorem aliquam quis quasi aspernatur ipsa.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9358),
                        false,
                        5,
                        null,
                        4,
                    },
                    {
                        46,
                        6,
                        "Sed molestias a fuga.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9378),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        47,
                        4,
                        "Exercitationem veniam odio quia.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9391),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        48,
                        9,
                        "Ut nihil ullam vero ut voluptates laborum reprehenderit amet aperiam.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9402),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        49,
                        8,
                        "Omnis aut quos excepturi eius hic soluta nihil quasi.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9422),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        50,
                        9,
                        "Error est ea error sequi facere officia eos vel non.",
                        new DateTime(2024, 12, 8, 21, 40, 34, 341, DateTimeKind.Utc).AddTicks(9441),
                        false,
                        1,
                        null,
                        3,
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
                        3,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(381),
                        false,
                        null,
                        3,
                    },
                    {
                        2,
                        7,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(508),
                        false,
                        null,
                        5,
                    },
                    {
                        3,
                        19,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(513),
                        false,
                        null,
                        8,
                    },
                    {
                        4,
                        17,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(516),
                        false,
                        null,
                        2,
                    },
                    {
                        5,
                        5,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(519),
                        false,
                        null,
                        7,
                    },
                    {
                        6,
                        1,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(521),
                        false,
                        null,
                        7,
                    },
                    {
                        7,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(524),
                        false,
                        null,
                        6,
                    },
                    {
                        8,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(526),
                        false,
                        null,
                        6,
                    },
                    {
                        9,
                        19,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(529),
                        false,
                        null,
                        3,
                    },
                    {
                        10,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(531),
                        false,
                        null,
                        7,
                    },
                    {
                        11,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(533),
                        false,
                        null,
                        8,
                    },
                    {
                        12,
                        11,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(536),
                        false,
                        null,
                        6,
                    },
                    {
                        13,
                        6,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(539),
                        false,
                        null,
                        6,
                    },
                    {
                        14,
                        2,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(541),
                        false,
                        null,
                        2,
                    },
                    {
                        15,
                        10,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(543),
                        false,
                        null,
                        6,
                    },
                    {
                        16,
                        17,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(545),
                        false,
                        null,
                        3,
                    },
                    {
                        17,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(548),
                        false,
                        null,
                        7,
                    },
                    {
                        18,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(550),
                        false,
                        null,
                        5,
                    },
                    {
                        19,
                        15,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(552),
                        false,
                        null,
                        5,
                    },
                    {
                        20,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(555),
                        false,
                        null,
                        2,
                    },
                    {
                        21,
                        8,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(558),
                        false,
                        null,
                        4,
                    },
                    {
                        22,
                        3,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(560),
                        false,
                        null,
                        3,
                    },
                    {
                        23,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(563),
                        false,
                        null,
                        6,
                    },
                    {
                        24,
                        13,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(565),
                        false,
                        null,
                        7,
                    },
                    {
                        25,
                        15,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(568),
                        false,
                        null,
                        10,
                    },
                    {
                        26,
                        18,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(570),
                        false,
                        null,
                        4,
                    },
                    {
                        27,
                        20,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(573),
                        false,
                        null,
                        8,
                    },
                    {
                        28,
                        4,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(575),
                        false,
                        null,
                        7,
                    },
                    {
                        29,
                        11,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(578),
                        false,
                        null,
                        6,
                    },
                    {
                        30,
                        9,
                        new DateTime(2024, 12, 8, 21, 40, 34, 343, DateTimeKind.Utc).AddTicks(581),
                        false,
                        null,
                        4,
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
