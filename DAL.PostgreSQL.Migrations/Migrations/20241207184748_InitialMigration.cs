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
                        "Hansenview",
                        "Indonesia",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(1715),
                        false,
                        "Missouri",
                        "83490 Friedrich Drive",
                        null,
                        "48412",
                    },
                    {
                        2,
                        "Andersonberg",
                        "Cambodia",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(2229),
                        false,
                        "Mississippi",
                        "21638 Ziemann Club",
                        null,
                        "95346-7406",
                    },
                    {
                        3,
                        "Aidenbury",
                        "Zambia",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(2362),
                        false,
                        "Washington",
                        "787 Shields Knolls",
                        null,
                        "87545-4657",
                    },
                    {
                        4,
                        "Lake Griffinstad",
                        "Madagascar",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(2481),
                        false,
                        "Wyoming",
                        "69343 Luisa Centers",
                        null,
                        "89670",
                    },
                    {
                        5,
                        "Lamontbury",
                        "Niue",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(2610),
                        false,
                        "Rhode Island",
                        "0979 Sarah Pass",
                        null,
                        "05045-9274",
                    },
                    {
                        6,
                        "South Bulahbury",
                        "Bolivia",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(2719),
                        false,
                        "Nevada",
                        "47708 Cristina Islands",
                        null,
                        "32227",
                    },
                    {
                        7,
                        "Gavinfort",
                        "Pitcairn Islands",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(2921),
                        false,
                        "South Carolina",
                        "702 Elmo Crest",
                        null,
                        "24060-4189",
                    },
                    {
                        8,
                        "East Danberg",
                        "Reunion",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3064),
                        false,
                        "Oregon",
                        "67851 Kozey Square",
                        null,
                        "42257",
                    },
                    {
                        9,
                        "South Jarretborough",
                        "Guatemala",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3190),
                        false,
                        "Florida",
                        "3846 Prohaska Ports",
                        null,
                        "37252",
                    },
                    {
                        10,
                        "Rosietown",
                        "Germany",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3310),
                        false,
                        "Pennsylvania",
                        "40472 Eleanora Mountain",
                        null,
                        "24104",
                    },
                    {
                        11,
                        "South Roman",
                        "Guadeloupe",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3426),
                        false,
                        "Connecticut",
                        "2787 Murazik Manor",
                        null,
                        "39700",
                    },
                    {
                        12,
                        "East Genestad",
                        "Ethiopia",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3529),
                        false,
                        "Georgia",
                        "31376 DuBuque Expressway",
                        null,
                        "09743-5724",
                    },
                    {
                        13,
                        "South Wernerburgh",
                        "Burkina Faso",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3674),
                        false,
                        "New York",
                        "1585 Rowe Ville",
                        null,
                        "04129",
                    },
                    {
                        14,
                        "Port Adrain",
                        "Yemen",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3804),
                        false,
                        "Tennessee",
                        "48918 Chyna Villages",
                        null,
                        "76351",
                    },
                    {
                        15,
                        "East Destiny",
                        "Austria",
                        new DateTime(2024, 12, 7, 18, 47, 48, 614, DateTimeKind.Utc).AddTicks(3916),
                        false,
                        "Georgia",
                        "097 Baby Park",
                        null,
                        "55520-6041",
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
                        "cd2582a5-d26a-4f78-90f2-229934d361fc",
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
                        "05e4d0bf-b011-4ec8-bee2-2596399bd3b9",
                        false,
                        "admin",
                    },
                    {
                        2,
                        0,
                        "04524d2f-e507-4eb7-9456-c5ab8633fde6",
                        "Garnet98@yahoo.com",
                        true,
                        false,
                        null,
                        "Devon Kuhlman",
                        null,
                        null,
                        null,
                        "452-431-6377",
                        false,
                        "cee76dd1-02e7-485f-9a63-9a9173b4bb33",
                        false,
                        "Jeanie61",
                    },
                    {
                        3,
                        0,
                        "366d23ae-0bfd-46ac-898e-060a9517be27",
                        "Anne.Beatty@hotmail.com",
                        true,
                        false,
                        null,
                        "Jamison Schuppe",
                        null,
                        null,
                        null,
                        "370-277-9813",
                        false,
                        "e8be758d-08b0-4720-bdf1-71e6488a6056",
                        false,
                        "Karlie.OConner1",
                    },
                    {
                        4,
                        0,
                        "ae39c8e0-c0c5-404d-bd8b-e8e6e0830488",
                        "Jadon.Brakus@yahoo.com",
                        true,
                        false,
                        null,
                        "Kitty Anderson",
                        null,
                        null,
                        null,
                        "962.930.3877 x60531",
                        false,
                        "08a2c292-c18b-49c4-900a-42da690f035d",
                        false,
                        "Jody.Torphy",
                    },
                    {
                        5,
                        0,
                        "55478d2b-ee67-4fa3-a597-ec3434f8c922",
                        "Norma.Bogisich94@yahoo.com",
                        true,
                        false,
                        null,
                        "Jack Schaden",
                        null,
                        null,
                        null,
                        "201-896-6042 x6637",
                        false,
                        "64157985-84b7-4574-8944-9e69971dfb1c",
                        false,
                        "Aliyah_Brown9",
                    },
                    {
                        6,
                        0,
                        "4b8e4e36-9c00-447a-8bba-8538bf6e4ce1",
                        "Hertha_Krajcik85@yahoo.com",
                        true,
                        false,
                        null,
                        "Hilton Johnson",
                        null,
                        null,
                        null,
                        "989.345.1531 x723",
                        false,
                        "725ab4a2-12cf-423d-8ef1-36d8298a298c",
                        false,
                        "Kolby.Schneider",
                    },
                    {
                        7,
                        0,
                        "9270cb67-c4dd-4a26-909c-e8fb415ef432",
                        "Cody.Schaden77@yahoo.com",
                        true,
                        false,
                        null,
                        "Darien Runte",
                        null,
                        null,
                        null,
                        "1-853-930-3353 x01360",
                        false,
                        "b02acf9f-67c2-46d4-b6d6-e61e9076596d",
                        false,
                        "Lexus83",
                    },
                    {
                        8,
                        0,
                        "0b150d4d-ca1d-4a55-a96b-77ba1cb5e80f",
                        "Raleigh76@gmail.com",
                        true,
                        false,
                        null,
                        "Lessie Labadie",
                        null,
                        null,
                        null,
                        "750-788-0317",
                        false,
                        "6b2fef93-825e-40fc-af98-1aaa3857a557",
                        false,
                        "Johnnie.Sauer42",
                    },
                    {
                        9,
                        0,
                        "9aaa6f0b-4021-4eae-ac2a-a55c9b95511f",
                        "Matteo_Hickle69@yahoo.com",
                        true,
                        false,
                        null,
                        "Alexandrea Roob",
                        null,
                        null,
                        null,
                        "1-622-560-7229",
                        false,
                        "f6200688-d023-44b6-8d56-92d1a7b788af",
                        false,
                        "Katlyn26",
                    },
                    {
                        10,
                        0,
                        "4b4a3f92-a475-4b19-a2db-263aca25de63",
                        "Schuyler66@yahoo.com",
                        true,
                        false,
                        null,
                        "Frederic Gottlieb",
                        null,
                        null,
                        null,
                        "(943) 724-6917 x87401",
                        false,
                        "53c69d60-0a9f-460e-8df7-f230243e68bf",
                        false,
                        "Harry32",
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
                        "Eaque sint rerum maxime non. Dolore est provident cum at earum ipsa reprehenderit. Autem voluptate nam molestias saepe omnis. Accusantium ut dolorum. Quia necessitatibus architecto et et sunt nemo.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6001),
                        false,
                        "Ivory Hermann",
                        null,
                    },
                    {
                        2,
                        "Explicabo ullam adipisci non sapiente doloremque praesentium ratione. Corporis odit in quisquam corrupti eveniet quis quaerat cupiditate dolorem. Ut vitae eaque occaecati omnis at soluta qui sed ex.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6344),
                        false,
                        "Kailyn Hamill",
                        null,
                    },
                    {
                        3,
                        "Soluta molestias nihil accusantium provident voluptatibus eos reprehenderit accusantium sunt. In sit recusandae facilis minima voluptates ut. Aut omnis ad quod iusto quia. Explicabo culpa doloremque et maiores porro vel. Itaque dolores perferendis facere. Voluptatem consequatur quos quod.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6522),
                        false,
                        "Trinity Quitzon",
                        null,
                    },
                    {
                        4,
                        "Est enim aut reprehenderit. Eos minus laborum ut a numquam cum beatae quibusdam ea. Nesciunt ullam sequi. Quam voluptatem nihil. Explicabo consequatur placeat commodi vitae eos voluptatem. Ullam iusto eaque incidunt distinctio.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6648),
                        false,
                        "Joaquin Ullrich",
                        null,
                    },
                    {
                        5,
                        "Sequi et modi nulla voluptas. Repellat exercitationem laboriosam eligendi. Numquam nam error culpa totam commodi.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6786),
                        false,
                        "Bernie Sanford",
                        null,
                    },
                    {
                        6,
                        "Maxime rerum sapiente est qui. Quia incidunt voluptatum. Et officia quae quasi. Ut eius alias in nam eum aperiam. Et iste dolor et praesentium quis ratione sint.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6839),
                        false,
                        "Alisha Mohr",
                        null,
                    },
                    {
                        7,
                        "Architecto blanditiis asperiores consectetur voluptatum sunt illum quasi dolores. Ea sit nisi ullam tempore reiciendis tempore ut neque. Tempore maxime quia ratione minima. Officiis nostrum necessitatibus eaque et.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(6951),
                        false,
                        "Adelia Dietrich",
                        null,
                    },
                    {
                        8,
                        "Exercitationem nulla nobis qui quia. Voluptatem dolorem neque illum non porro eum aperiam. Magnam in et voluptas aut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(7030),
                        false,
                        "Regan Olson",
                        null,
                    },
                    {
                        9,
                        "Est molestias perferendis voluptas. Vel incidunt consectetur veritatis nobis aut eos assumenda corrupti. Quia totam unde. Quibusdam ut eligendi voluptatem dolores incidunt perferendis.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(7108),
                        false,
                        "Garrison Braun",
                        null,
                    },
                    {
                        10,
                        "Commodi iure cum esse quis ut fugit consequatur incidunt sit. Consectetur doloribus fuga earum aut quod ut. Provident rerum quas exercitationem et sed reprehenderit fuga. Est qui facilis ab consequatur doloremque. Temporibus ut unde voluptatem voluptatibus possimus ratione nulla architecto. Omnis ut mollitia et aspernatur iusto perferendis deserunt mollitia ut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 606, DateTimeKind.Utc).AddTicks(7165),
                        false,
                        "Gunnar Schultz",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ut quis odio." },
                    { 2, "Modi ducimus optio." },
                    { 3, "Et repudiandae eveniet." },
                    { 4, "Nemo quibusdam sint." },
                    { 5, "Ut quo nihil." },
                    { 6, "Excepturi veniam omnis." },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Fugit et commodi ex natus omnis saepe. Aliquam repellat harum velit amet dolor ut asperiores aut aut. Quis dicta ut. Recusandae vel perferendis illo magni est velit asperiores officia.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 607, DateTimeKind.Utc).AddTicks(8318),
                        false,
                        "Batz - Cassin",
                        null,
                    },
                    {
                        2,
                        "Architecto perspiciatis modi illum quibusdam excepturi dolorem vel quasi omnis. Itaque assumenda voluptatem laboriosam itaque quia vel provident soluta. Corporis optio vel molestias maiores ipsum qui.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 607, DateTimeKind.Utc).AddTicks(8827),
                        false,
                        "Erdman LLC",
                        null,
                    },
                    {
                        3,
                        "Nihil explicabo quae sunt optio quo saepe cupiditate. Perferendis incidunt error molestiae excepturi dolores necessitatibus ratione ullam. Ea et exercitationem maiores assumenda rerum commodi libero. Maiores molestiae nihil neque accusantium. Eius qui molestias odit ea sed. A sed vero officia et.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 607, DateTimeKind.Utc).AddTicks(9034),
                        false,
                        "Grant, Cormier and Torp",
                        null,
                    },
                    {
                        4,
                        "Eos quibusdam sed id unde. Facilis sed eaque voluptatem ex. Omnis in autem. Error at excepturi quam perferendis. Error et accusantium fugit quas laborum rem earum. Aut facere placeat et esse nihil.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 607, DateTimeKind.Utc).AddTicks(9253),
                        false,
                        "Gerhold, Schiller and Hoppe",
                        null,
                    },
                    {
                        5,
                        "Perferendis et quaerat enim vel accusantium. Nihil placeat ut dolor enim impedit facilis ea dignissimos. Accusantium culpa iusto sapiente repellendus eos non consequuntur ullam. Animi eos quam a et. Eum optio dolor odio laudantium aut omnis voluptas aut ullam.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 607, DateTimeKind.Utc).AddTicks(9410),
                        false,
                        "Murphy - Blick",
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
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(2786),
                        "Dolorem et dolores eos cum iure. Ipsam sapiente aspernatur ut officiis molestiae nisi nihil ut. Et vel consequuntur nobis et at. Et ut ut corporis.",
                        0,
                        "https://picsum.photos/640/480/?image=172",
                        false,
                        null,
                        53.73m,
                        1,
                        4,
                        "Asperiores illo provident.",
                        null,
                    },
                    {
                        2,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4110),
                        "Corporis nobis praesentium quo aperiam et qui iusto libero. At cumque aperiam ipsam iste laborum ducimus. Accusamus impedit id fugiat vero voluptas et mollitia. Error debitis ullam enim et et corporis.",
                        0,
                        "https://picsum.photos/640/480/?image=257",
                        false,
                        null,
                        58.64m,
                        5,
                        3,
                        "Et molestiae consectetur.",
                        null,
                    },
                    {
                        3,
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4251),
                        "Veritatis quia ipsam eos. Amet et excepturi iure. Placeat voluptates perspiciatis suscipit deleniti asperiores saepe facere assumenda. Rerum laboriosam eos occaecati fugit accusamus voluptatibus eos magnam quae.",
                        0,
                        "https://picsum.photos/640/480/?image=716",
                        false,
                        null,
                        11.60m,
                        5,
                        5,
                        "Error accusamus autem.",
                        null,
                    },
                    {
                        4,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4340),
                        "Impedit blanditiis sint eaque et cumque est accusamus. Nemo iste nihil omnis possimus non minima ullam nostrum ut. Minima veniam incidunt voluptatem aut vitae sint velit aliquam.",
                        0,
                        "https://picsum.photos/640/480/?image=592",
                        false,
                        null,
                        78.00m,
                        3,
                        4,
                        "Veritatis est numquam.",
                        null,
                    },
                    {
                        5,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4443),
                        "Nisi consequatur aut. Aut fugiat nisi ea ut atque. Natus incidunt et aut voluptas ipsum quis. Non qui ea reiciendis eaque.",
                        0,
                        "https://picsum.photos/640/480/?image=909",
                        false,
                        null,
                        72.10m,
                        1,
                        3,
                        "Asperiores ipsum ab.",
                        null,
                    },
                    {
                        6,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4507),
                        "Voluptatem libero quia sed. Nostrum est est. Quam ullam sapiente voluptatibus. Omnis cumque laudantium accusantium est. Consequatur molestiae inventore adipisci non repellendus tempore cumque. Dolorem omnis voluptas ullam autem libero et possimus.",
                        0,
                        "https://picsum.photos/640/480/?image=400",
                        false,
                        null,
                        11.00m,
                        5,
                        1,
                        "Dolore aliquam et.",
                        null,
                    },
                    {
                        7,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4612),
                        "Velit reprehenderit rerum officia illo voluptates ea eveniet. Exercitationem unde non est reprehenderit saepe enim. Dolorem iste suscipit laudantium eum amet.",
                        0,
                        "https://picsum.photos/640/480/?image=687",
                        false,
                        null,
                        74.04m,
                        2,
                        2,
                        "Voluptas provident voluptatum.",
                        null,
                    },
                    {
                        8,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4748),
                        "Dignissimos earum dolor qui. Sit dolor expedita quam dolores quasi. Aut molestiae est blanditiis autem deserunt. Doloremque accusamus voluptas enim mollitia impedit est.",
                        0,
                        "https://picsum.photos/640/480/?image=566",
                        false,
                        null,
                        53.31m,
                        5,
                        3,
                        "Quo et voluptas.",
                        null,
                    },
                    {
                        9,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4816),
                        "Sunt explicabo possimus. Quisquam sit dolor mollitia a est ducimus omnis nobis. Ea omnis fugit tempora. Aut accusamus totam. Quibusdam dolores ea facilis quo eius velit magnam cumque. Reprehenderit itaque ullam ullam ipsum rerum iste animi rerum quisquam.",
                        0,
                        "https://picsum.photos/640/480/?image=596",
                        false,
                        null,
                        27.66m,
                        2,
                        2,
                        "Nobis necessitatibus hic.",
                        null,
                    },
                    {
                        10,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(4933),
                        "Ut excepturi consectetur. Ea soluta veniam voluptatem perferendis debitis. Ut nostrum sit. Voluptate ratione repellat temporibus ad quia hic.",
                        0,
                        "https://picsum.photos/640/480/?image=1039",
                        false,
                        null,
                        96.36m,
                        3,
                        4,
                        "Sit quis magnam.",
                        null,
                    },
                    {
                        11,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5021),
                        "Hic dolore sit qui porro minus. Iste non in architecto soluta eius animi harum. Dolores ut harum omnis. Ab quia mollitia amet rem perferendis voluptatem ut. Dolore incidunt nam velit ducimus et et qui dolores. Fuga dolores ipsam eius voluptates maxime eligendi.",
                        0,
                        "https://picsum.photos/640/480/?image=484",
                        false,
                        null,
                        50.73m,
                        5,
                        2,
                        "Nobis amet dolor.",
                        null,
                    },
                    {
                        12,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5147),
                        "Deleniti commodi quia ut ea ab voluptatem quia. Expedita mollitia et facere hic non. Qui nulla odio. Temporibus voluptates nesciunt et ut reiciendis. Veritatis rem aut distinctio est itaque ad eaque voluptas.",
                        0,
                        "https://picsum.photos/640/480/?image=101",
                        false,
                        null,
                        14.24m,
                        5,
                        1,
                        "Voluptate voluptas voluptates.",
                        null,
                    },
                    {
                        13,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5223),
                        "Et suscipit error sit sit in velit. Culpa tempora velit et dolor in labore. Est sint rerum. Molestiae recusandae atque nobis quam reprehenderit consequatur voluptatem alias reprehenderit.",
                        0,
                        "https://picsum.photos/640/480/?image=1065",
                        false,
                        null,
                        27.60m,
                        5,
                        2,
                        "Enim corrupti et.",
                        null,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5344),
                        "Expedita ab repudiandae. Ut sunt consequatur laudantium neque vitae adipisci assumenda hic. Omnis voluptas explicabo quia qui saepe. Harum omnis dicta est veniam et.",
                        0,
                        "https://picsum.photos/640/480/?image=332",
                        false,
                        null,
                        22.25m,
                        6,
                        4,
                        "Et qui quidem.",
                        null,
                    },
                    {
                        15,
                        3,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5437),
                        "Provident consequuntur temporibus ut nisi mollitia saepe facere occaecati. Tempora quisquam quas voluptas occaecati aspernatur. Corrupti fugiat quia. Necessitatibus magni in dicta aut. Eaque facere sunt.",
                        0,
                        "https://picsum.photos/640/480/?image=417",
                        false,
                        null,
                        30.48m,
                        5,
                        5,
                        "Explicabo et omnis.",
                        null,
                    },
                    {
                        16,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5505),
                        "Vero unde sint. Sequi sed maiores libero ut blanditiis. Praesentium enim inventore quia quos a maxime. Maxime soluta voluptatibus beatae consequatur. Porro voluptate molestias.",
                        0,
                        "https://picsum.photos/640/480/?image=924",
                        false,
                        null,
                        68.00m,
                        3,
                        3,
                        "Voluptate vel sint.",
                        null,
                    },
                    {
                        17,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5595),
                        "Vel et rem ratione nihil et dolor molestiae culpa voluptas. Laudantium ratione sunt minus quam dolorem. Qui eligendi esse quibusdam veniam officia delectus sit quidem hic. Facere atque officiis saepe velit vitae inventore doloremque odit dolorem.",
                        0,
                        "https://picsum.photos/640/480/?image=138",
                        false,
                        null,
                        73.04m,
                        4,
                        2,
                        "Doloribus non corporis.",
                        null,
                    },
                    {
                        18,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5686),
                        "Ut pariatur voluptatem et tenetur sed nostrum sequi. Quibusdam est aut ut numquam et aut sint. Tempora quo soluta. Consectetur a quasi provident.",
                        0,
                        "https://picsum.photos/640/480/?image=58",
                        false,
                        null,
                        96.04m,
                        2,
                        5,
                        "Commodi voluptas voluptatem.",
                        null,
                    },
                    {
                        19,
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5748),
                        "Eius esse iusto inventore veritatis veniam quo suscipit. Eaque voluptas corrupti voluptas facilis. Illo excepturi et dolorum sint dolorum maxime dolorem in omnis.",
                        0,
                        "https://picsum.photos/640/480/?image=362",
                        false,
                        null,
                        76.89m,
                        4,
                        2,
                        "Ipsam qui quos.",
                        null,
                    },
                    {
                        20,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 610, DateTimeKind.Utc).AddTicks(5867),
                        "Nemo qui sint tempore accusamus in iure eligendi. Odio aut porro dolores voluptatem rerum. Ut velit qui. Optio qui voluptas temporibus. Sapiente voluptatem illum odit nemo.",
                        0,
                        "https://picsum.photos/640/480/?image=716",
                        false,
                        null,
                        13.35m,
                        2,
                        4,
                        "Tempora qui aut.",
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
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7905),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7907),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7907),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7907),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7907),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7908),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7908),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7908),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7908),
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
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 615, DateTimeKind.Utc).AddTicks(4605),
                        "Viola43@hotmail.com",
                        "Viola Gaylord",
                        false,
                        13,
                        0m,
                        null,
                        10,
                    },
                    {
                        2,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 615, DateTimeKind.Utc).AddTicks(7256),
                        "Clarence_Morar37@gmail.com",
                        "Clarence Morar",
                        false,
                        7,
                        0m,
                        null,
                        7,
                    },
                    {
                        3,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 615, DateTimeKind.Utc).AddTicks(8193),
                        "Bob76@gmail.com",
                        "Bob Simonis",
                        false,
                        4,
                        0m,
                        null,
                        4,
                    },
                    {
                        4,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 615, DateTimeKind.Utc).AddTicks(8708),
                        "Noah.Parker@yahoo.com",
                        "Noah Parker",
                        false,
                        2,
                        0m,
                        null,
                        3,
                    },
                    {
                        5,
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 615, DateTimeKind.Utc).AddTicks(9168),
                        "Jeanette80@gmail.com",
                        "Jeanette Gleason",
                        false,
                        3,
                        0m,
                        null,
                        2,
                    },
                    {
                        6,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 615, DateTimeKind.Utc).AddTicks(9663),
                        "Curtis_Lubowitz55@hotmail.com",
                        "Curtis Lubowitz",
                        false,
                        5,
                        0m,
                        null,
                        9,
                    },
                    {
                        7,
                        14,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(137),
                        "Pete37@hotmail.com",
                        "Pete Walsh",
                        false,
                        8,
                        0m,
                        null,
                        5,
                    },
                    {
                        8,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(572),
                        "Jeannie_Johns8@hotmail.com",
                        "Jeannie Johns",
                        false,
                        5,
                        0m,
                        null,
                        3,
                    },
                    {
                        9,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(1114),
                        "Deborah_Stark78@yahoo.com",
                        "Deborah Stark",
                        false,
                        10,
                        0m,
                        null,
                        3,
                    },
                    {
                        10,
                        13,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(1585),
                        "Antonio85@yahoo.com",
                        "Antonio Bogisich",
                        false,
                        12,
                        0m,
                        null,
                        2,
                    },
                    {
                        11,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(2014),
                        "Sabrina.Schimmel@yahoo.com",
                        "Sabrina Schimmel",
                        false,
                        12,
                        0m,
                        null,
                        7,
                    },
                    {
                        12,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(2451),
                        "Vicki_Schoen@gmail.com",
                        "Vicki Schoen",
                        false,
                        15,
                        0m,
                        null,
                        9,
                    },
                    {
                        13,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(3008),
                        "Kristy27@yahoo.com",
                        "Kristy Abshire",
                        false,
                        1,
                        0m,
                        null,
                        5,
                    },
                    {
                        14,
                        14,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(3484),
                        "Ruben.Friesen43@hotmail.com",
                        "Ruben Friesen",
                        false,
                        10,
                        0m,
                        null,
                        6,
                    },
                    {
                        15,
                        13,
                        new DateTime(2024, 12, 7, 18, 47, 48, 616, DateTimeKind.Utc).AddTicks(3891),
                        "Beulah_Batz@gmail.com",
                        "Beulah Batz",
                        false,
                        6,
                        0m,
                        null,
                        7,
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
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(6255),
                        false,
                        2,
                        24.78m,
                        1,
                        null,
                    },
                    {
                        2,
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7367),
                        false,
                        2,
                        61.38m,
                        1,
                        null,
                    },
                    {
                        3,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7408),
                        false,
                        5,
                        67.13m,
                        3,
                        null,
                    },
                    {
                        4,
                        20,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7418),
                        false,
                        11,
                        44.81m,
                        1,
                        null,
                    },
                    {
                        5,
                        5,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7426),
                        false,
                        3,
                        24.08m,
                        3,
                        null,
                    },
                    {
                        6,
                        13,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7434),
                        false,
                        2,
                        86.16m,
                        2,
                        null,
                    },
                    {
                        7,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7441),
                        false,
                        6,
                        72.11m,
                        3,
                        null,
                    },
                    {
                        8,
                        5,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7447),
                        false,
                        11,
                        93.54m,
                        2,
                        null,
                    },
                    {
                        9,
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7454),
                        false,
                        3,
                        90.34m,
                        3,
                        null,
                    },
                    {
                        10,
                        18,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7461),
                        false,
                        3,
                        86.66m,
                        2,
                        null,
                    },
                    {
                        11,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7468),
                        false,
                        5,
                        55.74m,
                        2,
                        null,
                    },
                    {
                        12,
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7475),
                        false,
                        1,
                        70.76m,
                        3,
                        null,
                    },
                    {
                        13,
                        17,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7482),
                        false,
                        4,
                        32.75m,
                        1,
                        null,
                    },
                    {
                        14,
                        13,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7489),
                        false,
                        13,
                        12.63m,
                        2,
                        null,
                    },
                    {
                        15,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7495),
                        false,
                        11,
                        73.51m,
                        1,
                        null,
                    },
                    {
                        16,
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7502),
                        false,
                        9,
                        51.44m,
                        3,
                        null,
                    },
                    {
                        17,
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7509),
                        false,
                        6,
                        18.39m,
                        2,
                        null,
                    },
                    {
                        18,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7515),
                        false,
                        2,
                        78.91m,
                        1,
                        null,
                    },
                    {
                        19,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7521),
                        false,
                        11,
                        68.94m,
                        1,
                        null,
                    },
                    {
                        20,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7528),
                        false,
                        13,
                        97.29m,
                        2,
                        null,
                    },
                    {
                        21,
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7534),
                        false,
                        5,
                        10.45m,
                        1,
                        null,
                    },
                    {
                        22,
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7541),
                        false,
                        5,
                        30.14m,
                        1,
                        null,
                    },
                    {
                        23,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7548),
                        false,
                        12,
                        19.24m,
                        1,
                        null,
                    },
                    {
                        24,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7554),
                        false,
                        14,
                        33.28m,
                        1,
                        null,
                    },
                    {
                        25,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7561),
                        false,
                        12,
                        81.50m,
                        1,
                        null,
                    },
                    {
                        26,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7567),
                        false,
                        4,
                        88.91m,
                        3,
                        null,
                    },
                    {
                        27,
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7574),
                        false,
                        3,
                        51.12m,
                        2,
                        null,
                    },
                    {
                        28,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7581),
                        false,
                        2,
                        68.85m,
                        2,
                        null,
                    },
                    {
                        29,
                        13,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7637),
                        false,
                        12,
                        16.63m,
                        1,
                        null,
                    },
                    {
                        30,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7646),
                        false,
                        9,
                        83.25m,
                        3,
                        null,
                    },
                    {
                        31,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7653),
                        false,
                        5,
                        96.34m,
                        1,
                        null,
                    },
                    {
                        32,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7660),
                        false,
                        15,
                        60.44m,
                        3,
                        null,
                    },
                    {
                        33,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7666),
                        false,
                        14,
                        28.06m,
                        3,
                        null,
                    },
                    {
                        34,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7673),
                        false,
                        3,
                        46.65m,
                        3,
                        null,
                    },
                    {
                        35,
                        3,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7680),
                        false,
                        8,
                        35.67m,
                        3,
                        null,
                    },
                    {
                        36,
                        15,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7687),
                        false,
                        12,
                        71.17m,
                        3,
                        null,
                    },
                    {
                        37,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7693),
                        false,
                        15,
                        62.31m,
                        2,
                        null,
                    },
                    {
                        38,
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7700),
                        false,
                        13,
                        48.50m,
                        2,
                        null,
                    },
                    {
                        39,
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7706),
                        false,
                        13,
                        30.83m,
                        3,
                        null,
                    },
                    {
                        40,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7713),
                        false,
                        12,
                        87.79m,
                        3,
                        null,
                    },
                    {
                        41,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7719),
                        false,
                        13,
                        92.82m,
                        3,
                        null,
                    },
                    {
                        42,
                        13,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7726),
                        false,
                        14,
                        21.73m,
                        1,
                        null,
                    },
                    {
                        43,
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7733),
                        false,
                        4,
                        93.23m,
                        1,
                        null,
                    },
                    {
                        44,
                        18,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7740),
                        false,
                        5,
                        55.57m,
                        3,
                        null,
                    },
                    {
                        45,
                        14,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7747),
                        false,
                        5,
                        56.25m,
                        1,
                        null,
                    },
                    {
                        46,
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7753),
                        false,
                        2,
                        61.70m,
                        3,
                        null,
                    },
                    {
                        47,
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7759),
                        false,
                        2,
                        32.16m,
                        2,
                        null,
                    },
                    {
                        48,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7766),
                        false,
                        7,
                        76.53m,
                        1,
                        null,
                    },
                    {
                        49,
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7772),
                        false,
                        9,
                        95.79m,
                        1,
                        null,
                    },
                    {
                        50,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 617, DateTimeKind.Utc).AddTicks(7778),
                        false,
                        13,
                        24.23m,
                        2,
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
                        4,
                        "Rerum dolorem aut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(6611),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        2,
                        20,
                        "Laudantium odit consequatur qui iure natus.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7627),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        3,
                        9,
                        "Ut ut culpa sed consequatur fugiat dicta.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7688),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        4,
                        3,
                        "Modi quo facere voluptatibus ut voluptatem.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7822),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        5,
                        2,
                        "Quae est provident libero sit iure nihil quas.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7841),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        6,
                        3,
                        "Temporibus earum qui beatae.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7860),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        7,
                        16,
                        "Sed repudiandae aut perspiciatis distinctio et provident voluptate.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7873),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        8,
                        20,
                        "Corrupti error quisquam itaque dolor.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7892),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        9,
                        18,
                        "Velit nobis vitae fuga iste.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7908),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        10,
                        3,
                        "Perferendis dicta dolor dolor modi.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7923),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        11,
                        4,
                        "Quasi illum eveniet quis numquam nam cumque.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7937),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        12,
                        11,
                        "Repellat eum ipsam provident omnis porro nesciunt.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(7955),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        13,
                        16,
                        "Deserunt dolores cupiditate accusantium aut quasi.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8010),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        14,
                        15,
                        "Porro laborum facere.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8027),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        15,
                        18,
                        "Blanditiis nisi sunt consequatur dolor quod.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8038),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        16,
                        6,
                        "Deserunt laborum eum fugiat nostrum illo.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8059),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        17,
                        18,
                        "Autem eos atque fugiat possimus voluptates earum iure voluptatum.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8080),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        18,
                        3,
                        "Dolorem vel cumque ab repellat aut facere ut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8112),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        19,
                        8,
                        "Dignissimos facere praesentium.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8145),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        20,
                        1,
                        "Deserunt aut corporis et est vel eum.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8156),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        21,
                        16,
                        "Quo officia veniam quo aliquid mollitia aliquid sint quaerat.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8202),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        22,
                        17,
                        "Placeat id mollitia voluptatem similique asperiores.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8222),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        23,
                        2,
                        "Soluta sunt et molestiae dolor.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8240),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        24,
                        18,
                        "Tempora consequatur cum quia optio incidunt quam accusantium eveniet.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8253),
                        false,
                        5,
                        null,
                        8,
                    },
                    {
                        25,
                        15,
                        "Omnis quisquam tenetur soluta.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8273),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        26,
                        20,
                        "Eligendi nobis expedita deleniti atque.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8285),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        27,
                        10,
                        "Rerum error voluptatem temporibus necessitatibus.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8304),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        28,
                        17,
                        "Et sunt a consequatur pariatur ab praesentium iste et.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8322),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        29,
                        15,
                        "Et est pariatur.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8377),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        30,
                        12,
                        "Deleniti nisi nihil sint adipisci sapiente voluptatem occaecati.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8388),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        31,
                        20,
                        "Sit ipsa voluptatem.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8420),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        32,
                        2,
                        "Assumenda quo reprehenderit debitis ut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8432),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        33,
                        1,
                        "Ullam quia quaerat vel tenetur aut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8449),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        34,
                        7,
                        "Ut libero quia dolore blanditiis dolor.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8467),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        35,
                        14,
                        "Aliquid incidunt voluptatum sapiente inventore sint placeat autem.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8484),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        36,
                        10,
                        "Repellendus consequatur ut ut architecto.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8503),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        37,
                        20,
                        "Dolorem facilis quasi itaque totam nulla ut nobis ea.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8562),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        38,
                        13,
                        "Rem sit ipsam voluptatibus assumenda quas a perferendis et.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8586),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        39,
                        9,
                        "Quis voluptates possimus ducimus eos sunt occaecati ut quidem exercitationem.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8605),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        40,
                        5,
                        "Necessitatibus autem mollitia voluptas qui nostrum accusamus quisquam.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8626),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        41,
                        6,
                        "Distinctio velit quas in.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8644),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        42,
                        1,
                        "Iste eos ducimus non excepturi.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8657),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        43,
                        17,
                        "Molestias sint quis voluptatem adipisci quae dolorem.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8671),
                        false,
                        5,
                        null,
                        6,
                    },
                    {
                        44,
                        4,
                        "Cumque neque commodi harum facere.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8737),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        45,
                        19,
                        "Harum rerum harum.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8751),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        46,
                        19,
                        "Et cupiditate velit.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8762),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        47,
                        6,
                        "Minima eaque omnis in ut.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8773),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        48,
                        19,
                        "Mollitia tempore blanditiis.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8787),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        49,
                        5,
                        "Delectus numquam sunt est quia molestiae rem.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8798),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        50,
                        10,
                        "Aliquam quas quae.",
                        new DateTime(2024, 12, 7, 18, 47, 48, 611, DateTimeKind.Utc).AddTicks(8814),
                        false,
                        4,
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
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(40),
                        false,
                        null,
                        3,
                    },
                    {
                        2,
                        11,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(154),
                        false,
                        null,
                        4,
                    },
                    {
                        3,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(159),
                        false,
                        null,
                        7,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(162),
                        false,
                        null,
                        2,
                    },
                    {
                        5,
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(165),
                        false,
                        null,
                        3,
                    },
                    {
                        6,
                        17,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(167),
                        false,
                        null,
                        5,
                    },
                    {
                        7,
                        4,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(170),
                        false,
                        null,
                        5,
                    },
                    {
                        8,
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(173),
                        false,
                        null,
                        4,
                    },
                    {
                        9,
                        14,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(175),
                        false,
                        null,
                        3,
                    },
                    {
                        10,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(214),
                        false,
                        null,
                        4,
                    },
                    {
                        11,
                        14,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(216),
                        false,
                        null,
                        8,
                    },
                    {
                        12,
                        15,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(219),
                        false,
                        null,
                        10,
                    },
                    {
                        13,
                        17,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(222),
                        false,
                        null,
                        7,
                    },
                    {
                        14,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(224),
                        false,
                        null,
                        6,
                    },
                    {
                        15,
                        15,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(227),
                        false,
                        null,
                        10,
                    },
                    {
                        16,
                        18,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(229),
                        false,
                        null,
                        2,
                    },
                    {
                        17,
                        14,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(232),
                        false,
                        null,
                        7,
                    },
                    {
                        18,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(234),
                        false,
                        null,
                        3,
                    },
                    {
                        19,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(236),
                        false,
                        null,
                        8,
                    },
                    {
                        20,
                        10,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(239),
                        false,
                        null,
                        6,
                    },
                    {
                        21,
                        9,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(241),
                        false,
                        null,
                        5,
                    },
                    {
                        22,
                        12,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(244),
                        false,
                        null,
                        3,
                    },
                    {
                        23,
                        6,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(246),
                        false,
                        null,
                        8,
                    },
                    {
                        24,
                        20,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(248),
                        false,
                        null,
                        9,
                    },
                    {
                        25,
                        20,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(251),
                        false,
                        null,
                        5,
                    },
                    {
                        26,
                        1,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(253),
                        false,
                        null,
                        3,
                    },
                    {
                        27,
                        16,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(256),
                        false,
                        null,
                        2,
                    },
                    {
                        28,
                        7,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(258),
                        false,
                        null,
                        4,
                    },
                    {
                        29,
                        8,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(261),
                        false,
                        null,
                        10,
                    },
                    {
                        30,
                        20,
                        new DateTime(2024, 12, 7, 18, 47, 48, 613, DateTimeKind.Utc).AddTicks(263),
                        false,
                        null,
                        5,
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
