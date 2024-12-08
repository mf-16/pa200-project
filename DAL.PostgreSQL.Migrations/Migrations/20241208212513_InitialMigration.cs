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
                    Genre = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
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
                        "Lennyland",
                        "Maldives",
                        new DateTime(2024, 12, 8, 21, 25, 12, 860, DateTimeKind.Utc).AddTicks(9450),
                        false,
                        "Florida",
                        "5599 Winfield Well",
                        null,
                        "94680-3022",
                    },
                    {
                        2,
                        "New Angus",
                        "San Marino",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(184),
                        false,
                        "West Virginia",
                        "293 Maximo Via",
                        null,
                        "67237-9720",
                    },
                    {
                        3,
                        "West Candidabury",
                        "Zimbabwe",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(347),
                        false,
                        "Louisiana",
                        "117 Maude Camp",
                        null,
                        "42647-3783",
                    },
                    {
                        4,
                        "Cronaside",
                        "Lebanon",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(489),
                        false,
                        "West Virginia",
                        "59757 Weimann Haven",
                        null,
                        "95891-7942",
                    },
                    {
                        5,
                        "Josiahshire",
                        "Mongolia",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(635),
                        false,
                        "North Dakota",
                        "5935 Bettie Heights",
                        null,
                        "20497",
                    },
                    {
                        6,
                        "South Chad",
                        "Kuwait",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(784),
                        false,
                        "North Carolina",
                        "7997 Michale Center",
                        null,
                        "93049-7315",
                    },
                    {
                        7,
                        "Itzelside",
                        "Ghana",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(919),
                        false,
                        "West Virginia",
                        "576 Mante Manor",
                        null,
                        "12801",
                    },
                    {
                        8,
                        "Reichertside",
                        "Virgin Islands, British",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1032),
                        false,
                        "California",
                        "089 Hansen Orchard",
                        null,
                        "68123",
                    },
                    {
                        9,
                        "East Ariannaview",
                        "French Guiana",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1189),
                        false,
                        "Nevada",
                        "95527 Nader Mountains",
                        null,
                        "86682",
                    },
                    {
                        10,
                        "New Marcellus",
                        "Ethiopia",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1360),
                        false,
                        "Iowa",
                        "11455 Blanda Crossroad",
                        null,
                        "11228-3021",
                    },
                    {
                        11,
                        "Santamouth",
                        "Bosnia and Herzegovina",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1496),
                        false,
                        "Delaware",
                        "986 Schmeler Light",
                        null,
                        "57052-2476",
                    },
                    {
                        12,
                        "East Enrique",
                        "Togo",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1626),
                        false,
                        "Tennessee",
                        "104 Brakus Drives",
                        null,
                        "88859-8322",
                    },
                    {
                        13,
                        "Volkmanmouth",
                        "Yemen",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1759),
                        false,
                        "Virginia",
                        "17473 Cary Ports",
                        null,
                        "17946-0779",
                    },
                    {
                        14,
                        "Wilkinsonbury",
                        "Iceland",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(1885),
                        false,
                        "New Jersey",
                        "40080 Murray Dale",
                        null,
                        "45000",
                    },
                    {
                        15,
                        "Vallieland",
                        "Netherlands Antilles",
                        new DateTime(2024, 12, 8, 21, 25, 12, 861, DateTimeKind.Utc).AddTicks(2005),
                        false,
                        "Pennsylvania",
                        "303 Powlowski Corners",
                        null,
                        "07156",
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
                        "e79767d7-96ec-4d96-9b10-6dcdae11f166",
                        "admin@admin.com",
                        true,
                        false,
                        null,
                        "Admin User",
                        null,
                        "FAKE_ADMIN",
                        null,
                        "123-456-7890",
                        false,
                        "49d5c992-22a9-4a3e-9877-c9c0c8f1f2f5",
                        false,
                        "fake_admin",
                    },
                    {
                        2,
                        0,
                        "ced44f21-2bb3-4433-a036-a8c8ff116d8c",
                        "Darrel.Kirlin@gmail.com",
                        true,
                        false,
                        null,
                        "Gretchen Koepp",
                        null,
                        null,
                        null,
                        "943.283.4695 x2133",
                        false,
                        "e54b81ac-f1ae-42af-b912-7ec57711e30f",
                        false,
                        "Ora.Jaskolski69",
                    },
                    {
                        3,
                        0,
                        "d9dc68b9-f48c-4259-8a77-b78ec4451f5e",
                        "Adolph_Streich64@hotmail.com",
                        true,
                        false,
                        null,
                        "Yadira Hickle",
                        null,
                        null,
                        null,
                        "(854) 485-1783",
                        false,
                        "8977b747-55ee-4f2a-9ffa-7b17ac62359e",
                        false,
                        "Humberto.Bruen24",
                    },
                    {
                        4,
                        0,
                        "bfaceaab-46a9-4d24-8e32-63ec0927b105",
                        "Leone.Toy38@hotmail.com",
                        true,
                        false,
                        null,
                        "Elwyn Nienow",
                        null,
                        null,
                        null,
                        "602-810-5653 x15780",
                        false,
                        "1d5417d4-73a8-4624-95b8-607bd71d2770",
                        false,
                        "Andre18",
                    },
                    {
                        5,
                        0,
                        "7de4fcd0-ba15-4e32-bc09-b97b007fa933",
                        "Celia.Schowalter@gmail.com",
                        true,
                        false,
                        null,
                        "Lauryn Senger",
                        null,
                        null,
                        null,
                        "438.765.9933 x11258",
                        false,
                        "dd4afa05-e6e2-407c-be58-a3510b029611",
                        false,
                        "Friedrich_Goyette",
                    },
                    {
                        6,
                        0,
                        "f2223eb1-d881-4d4b-9b7b-0989152727ac",
                        "Alexis_Dicki12@gmail.com",
                        true,
                        false,
                        null,
                        "Vicenta Botsford",
                        null,
                        null,
                        null,
                        "1-743-238-7715 x5646",
                        false,
                        "7d0923f5-6b6b-4a04-a0ee-1ec6db2bc9c1",
                        false,
                        "Leopoldo.Turcotte90",
                    },
                    {
                        7,
                        0,
                        "7c4f565c-e6ca-4236-b57f-2d1f2c682785",
                        "Green_Runolfsson32@yahoo.com",
                        true,
                        false,
                        null,
                        "Karine Murazik",
                        null,
                        null,
                        null,
                        "917-895-4144",
                        false,
                        "36493247-20b2-45de-96c4-d983800d83d4",
                        false,
                        "Amiya_Gutkowski",
                    },
                    {
                        8,
                        0,
                        "c2b52738-0389-4b51-a7d0-4113fceb4a3f",
                        "Louie.Lindgren@gmail.com",
                        true,
                        false,
                        null,
                        "Taylor Witting",
                        null,
                        null,
                        null,
                        "602.320.5495",
                        false,
                        "d939f100-208c-40b8-b13a-1419cf015d97",
                        false,
                        "Vella.Hoppe9",
                    },
                    {
                        9,
                        0,
                        "f6e3259b-7689-4634-b467-26017916d8c9",
                        "Kyle17@gmail.com",
                        true,
                        false,
                        null,
                        "Ferne Rohan",
                        null,
                        null,
                        null,
                        "1-824-851-7265",
                        false,
                        "86899656-e4d6-444d-a8bb-53b6f38cc97f",
                        false,
                        "Lupe12",
                    },
                    {
                        10,
                        0,
                        "db830b6d-02bb-4b41-800e-46fef1994b80",
                        "Nicole.Deckow@yahoo.com",
                        true,
                        false,
                        null,
                        "Rae Schiller",
                        null,
                        null,
                        null,
                        "(236) 442-5940 x8940",
                        false,
                        "85f7fcf3-4a34-41fe-a2e2-c4e441552c49",
                        false,
                        "Napoleon3",
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
                        "Numquam qui voluptatem consequuntur neque esse aut deleniti. Reprehenderit veniam dolor ut illum ex. Vitae iste deserunt voluptatibus ut doloribus quidem. Adipisci vero quod voluptas cupiditate tempora nobis cum dolorem dolores. Quo explicabo aut at aut et et repudiandae aspernatur.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(6264),
                        false,
                        "Donna Leannon",
                        null,
                    },
                    {
                        2,
                        "Sapiente aut soluta. Ut soluta est omnis rerum et ipsum id reprehenderit eius. Est quibusdam dolorem. Et commodi voluptas perferendis amet aut rem exercitationem labore. Numquam magni suscipit quod ut. Omnis quam veniam aliquam perspiciatis suscipit non modi error.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(6806),
                        false,
                        "Nia Hills",
                        null,
                    },
                    {
                        3,
                        "Mollitia ipsa aspernatur est corrupti debitis. Laboriosam ut aut ut dolores. Ducimus eligendi esse. Consequatur officiis quas fugiat deserunt et accusamus et maiores et. Sed quidem odit sed aliquam cupiditate facilis deleniti. Libero incidunt dolor velit et temporibus aut.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(6979),
                        false,
                        "Caterina Morar",
                        null,
                    },
                    {
                        4,
                        "Et repudiandae ut ipsam atque consequatur quibusdam. Nemo aliquam rerum voluptatibus est quis dolor porro. Dolores officiis aut sed beatae. Distinctio dolores odit voluptas deleniti est nesciunt. Et natus debitis qui. Ut numquam doloribus labore mollitia.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7164),
                        false,
                        "Newell Daniel",
                        null,
                    },
                    {
                        5,
                        "Pariatur autem molestias dicta vel. Iste blanditiis ut rem dolorum labore cum assumenda consequuntur. Doloremque sed alias qui distinctio non quia soluta et.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7306),
                        false,
                        "Stan Satterfield",
                        null,
                    },
                    {
                        6,
                        "Dolore nostrum consequuntur soluta ratione. Distinctio magnam expedita facere corrupti et qui maiores et est. Sed numquam unde ipsam qui reiciendis aperiam dignissimos. Vero delectus illo atque facilis rem enim voluptatem. Explicabo perspiciatis molestias doloremque possimus est qui aut fuga.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7385),
                        false,
                        "Nakia Feest",
                        null,
                    },
                    {
                        7,
                        "Quia nostrum unde reiciendis facere autem doloremque voluptates. Aliquam pariatur commodi. Consectetur quia sint fugiat rerum.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7541),
                        false,
                        "Marcel Turner",
                        null,
                    },
                    {
                        8,
                        "Dolorum quia et ad et cumque aliquam necessitatibus delectus nesciunt. Nihil corrupti omnis impedit aut enim hic pariatur omnis tempora. Blanditiis ut consequatur. Dolorum tempora qui ea molestias veniam quisquam omnis rerum ut.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7602),
                        false,
                        "Devante Gulgowski",
                        null,
                    },
                    {
                        9,
                        "Eum est provident fuga laborum ut quod pariatur libero nisi. Molestiae aut quo qui totam quod. Consequatur laudantium fugiat iste numquam mollitia dolores. Voluptatum ullam assumenda possimus magni magnam non quibusdam atque. Eius ex vitae blanditiis.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7744),
                        false,
                        "Micah Williamson",
                        null,
                    },
                    {
                        10,
                        "Voluptas molestiae et voluptates non hic consequuntur. Officiis dolor delectus. Dicta facere in velit repudiandae voluptas aspernatur ex.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 852, DateTimeKind.Utc).AddTicks(7892),
                        false,
                        "Rylee Erdman",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Ut laborum iure et sint. Quasi aspernatur sapiente repudiandae quis voluptate. Eaque iste id nihil amet ex sit. Ut rerum non aliquam.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 853, DateTimeKind.Utc).AddTicks(9690),
                        false,
                        "Dach Group",
                        null,
                    },
                    {
                        2,
                        "Eaque repudiandae corporis. Ad laboriosam qui eaque vero nemo magni sit molestiae. Commodi repellat dolorum laudantium dolorum ad nihil inventore est. Sit laboriosam omnis esse eum quia. Fugit impedit minus perspiciatis nesciunt quasi vitae earum. Quo dignissimos aliquid.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 854, DateTimeKind.Utc).AddTicks(416),
                        false,
                        "MacGyver - Crona",
                        null,
                    },
                    {
                        3,
                        "Accusantium harum ad consequatur et voluptatem esse vero unde quidem. Dolorum enim aut non omnis. Distinctio qui impedit. Repudiandae illo itaque repellat. Repellat et aliquid.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 854, DateTimeKind.Utc).AddTicks(639),
                        false,
                        "Carter, Goodwin and Toy",
                        null,
                    },
                    {
                        4,
                        "Culpa dolorem animi et sint ea. Vero suscipit unde. Asperiores voluptas rerum voluptatem aut nam.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 854, DateTimeKind.Utc).AddTicks(846),
                        false,
                        "Jacobi, Fadel and Beatty",
                        null,
                    },
                    {
                        5,
                        "Qui et harum provident. Voluptatem perferendis quia ea eligendi nam. Ut eum et debitis nam eos.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 854, DateTimeKind.Utc).AddTicks(1034),
                        false,
                        "Murray Group",
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
                    "Genre",
                    "ImagePath",
                    "IsDeleted",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                    "UpdatedDate",
                },
                values: new object[,]
                {
                    {
                        1,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(4427),
                        "Quis excepturi debitis soluta voluptatem aut. Nemo voluptate in ut exercitationem. Velit et et ducimus iste cupiditate quo. Et alias dignissimos laborum saepe voluptatem voluptatem qui laudantium.",
                        0,
                        0,
                        "https://picsum.photos/640/480/?image=178",
                        false,
                        null,
                        29.92m,
                        2,
                        "Nihil aliquam quis.",
                        null,
                    },
                    {
                        2,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(7348),
                        "Cupiditate maxime sit consequatur saepe quas vitae omnis quia. Fugit cumque fugit omnis deserunt voluptatibus excepturi quas doloribus minima. Quis natus optio et cupiditate aut sunt quaerat dolor aliquid. Molestias magni voluptas quia at labore.",
                        0,
                        1,
                        "https://picsum.photos/640/480/?image=53",
                        false,
                        null,
                        59.59m,
                        2,
                        "Et possimus vero.",
                        null,
                    },
                    {
                        3,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(7601),
                        "Aliquam optio voluptatum eum. Labore saepe perspiciatis nesciunt praesentium ullam incidunt possimus. Voluptatum a doloribus. Recusandae voluptate est. Ut et placeat animi officiis et. Quae a consectetur.",
                        0,
                        3,
                        "https://picsum.photos/640/480/?image=630",
                        false,
                        null,
                        16.63m,
                        5,
                        "Provident inventore repellat.",
                        null,
                    },
                    {
                        4,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(7736),
                        "Atque repellendus voluptas cupiditate quos iste id architecto molestiae pariatur. Eos at explicabo nihil et. Voluptatibus officia provident molestias sunt nemo nihil. Quae numquam provident porro voluptatum. Aspernatur ad pariatur doloribus iste sequi qui.",
                        0,
                        7,
                        "https://picsum.photos/640/480/?image=1041",
                        false,
                        null,
                        26.02m,
                        5,
                        "Libero et atque.",
                        null,
                    },
                    {
                        5,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(7870),
                        "Eius omnis nihil cupiditate porro harum sint expedita deleniti. Laudantium id voluptas. Facere voluptate assumenda doloremque et et molestiae. Perferendis dolores optio et aut in aut. Et voluptas eos non nisi eum occaecati quasi possimus accusamus. Repudiandae ducimus esse officiis in.",
                        0,
                        1,
                        "https://picsum.photos/640/480/?image=281",
                        false,
                        null,
                        14.59m,
                        3,
                        "Provident dignissimos ea.",
                        null,
                    },
                    {
                        6,
                        6,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8006),
                        "Ad ex dolores est et mollitia aut eum. Sed possimus sunt placeat. Explicabo laboriosam dolores laborum minus quasi qui qui est quia.",
                        0,
                        5,
                        "https://picsum.photos/640/480/?image=895",
                        false,
                        null,
                        13.51m,
                        2,
                        "Dolore quia quidem.",
                        null,
                    },
                    {
                        7,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8074),
                        "Ex non est asperiores dolorum nihil. Qui possimus dignissimos amet. Perferendis distinctio voluptate unde ea architecto. Amet inventore rerum temporibus beatae ut sit occaecati et voluptas.",
                        0,
                        6,
                        "https://picsum.photos/640/480/?image=462",
                        false,
                        null,
                        17.63m,
                        5,
                        "Odio distinctio dolorem.",
                        null,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8179),
                        "Provident ea nesciunt libero porro autem dolores. Ea qui distinctio. Neque voluptate nihil et dolore similique impedit. Laboriosam architecto est voluptas modi nisi minima totam voluptate.",
                        0,
                        8,
                        "https://picsum.photos/640/480/?image=668",
                        false,
                        null,
                        26.15m,
                        3,
                        "Pariatur distinctio officiis.",
                        null,
                    },
                    {
                        9,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8274),
                        "Iure explicabo ea aliquid cumque. Exercitationem quibusdam beatae est alias. Culpa voluptate vel aut ex. Voluptatem dolorem nihil quia nemo assumenda adipisci. Quia quis itaque minima temporibus ut labore officiis qui voluptates. Consequuntur facere velit perferendis voluptates.",
                        0,
                        7,
                        "https://picsum.photos/640/480/?image=526",
                        false,
                        null,
                        80.74m,
                        4,
                        "Maxime cum esse.",
                        null,
                    },
                    {
                        10,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8371),
                        "Accusantium eos id eos voluptatem sint. Suscipit voluptatum in quo sit incidunt inventore saepe quo. Sit pariatur totam consequuntur voluptas sunt.",
                        0,
                        3,
                        "https://picsum.photos/640/480/?image=953",
                        false,
                        null,
                        71.34m,
                        4,
                        "Vel ipsum nostrum.",
                        null,
                    },
                    {
                        11,
                        6,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8562),
                        "Recusandae omnis illum minus ducimus. Non et eum. Maxime error unde sed assumenda architecto quisquam voluptatum quia libero. Iure voluptatem assumenda molestias eum. Et adipisci nostrum sed ut dolor numquam rerum reiciendis atque. Animi quis et.",
                        0,
                        6,
                        "https://picsum.photos/640/480/?image=636",
                        false,
                        null,
                        55.29m,
                        4,
                        "Saepe molestiae molestiae.",
                        null,
                    },
                    {
                        12,
                        5,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8697),
                        "Non reiciendis in dolores totam molestias. Sapiente modi omnis explicabo ut facere. Nihil harum consequuntur nulla. Ut sapiente eligendi ab aliquam voluptatem provident blanditiis assumenda consequatur. Quis ipsam tenetur.",
                        0,
                        4,
                        "https://picsum.photos/640/480/?image=797",
                        false,
                        null,
                        69.27m,
                        4,
                        "Accusantium sit quasi.",
                        null,
                    },
                    {
                        13,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8810),
                        "Nobis autem nam molestiae hic. Aut similique cum ea. Hic expedita voluptatem voluptas voluptatem. Repellendus atque mollitia eaque dolores quia.",
                        0,
                        8,
                        "https://picsum.photos/640/480/?image=895",
                        false,
                        null,
                        94.72m,
                        5,
                        "Et nihil ea.",
                        null,
                    },
                    {
                        14,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(8875),
                        "Laboriosam corrupti nihil voluptate. Accusantium laborum necessitatibus quis blanditiis unde ullam. Et dolorem non non. Voluptatibus quo ratione atque aut architecto dolor. Rerum voluptas qui rerum blanditiis. Ex voluptates animi sapiente dolore ratione et atque quia eius.",
                        0,
                        0,
                        "https://picsum.photos/640/480/?image=922",
                        false,
                        null,
                        89.83m,
                        4,
                        "Praesentium veritatis aliquam.",
                        null,
                    },
                    {
                        15,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(9003),
                        "Temporibus maiores blanditiis asperiores. Unde rerum vel quis delectus aut consequatur velit. Aut voluptas ut sunt. Accusantium earum adipisci sequi. Ut labore ea incidunt.",
                        0,
                        1,
                        "https://picsum.photos/640/480/?image=503",
                        false,
                        null,
                        59.16m,
                        4,
                        "Eum laboriosam soluta.",
                        null,
                    },
                    {
                        16,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(9105),
                        "Autem aut consequatur molestias quo. Ex cum voluptatem non officia. Distinctio veritatis aut commodi dolorem similique. Delectus tenetur omnis.",
                        0,
                        7,
                        "https://picsum.photos/640/480/?image=3",
                        false,
                        null,
                        17.54m,
                        2,
                        "Id temporibus qui.",
                        null,
                    },
                    {
                        17,
                        10,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(9171),
                        "Maiores veniam iste nobis illum. Qui tempore ut deserunt adipisci. Provident soluta officiis. Aut incidunt odit accusamus ipsam qui neque. Rerum voluptas enim tempora illum ut cupiditate labore natus dolores. Eaque soluta hic.",
                        0,
                        6,
                        "https://picsum.photos/640/480/?image=408",
                        false,
                        null,
                        41.97m,
                        2,
                        "Molestias ullam minus.",
                        null,
                    },
                    {
                        18,
                        5,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(9285),
                        "Reiciendis quo quod pariatur facere. Dolor fuga mollitia culpa accusamus laudantium similique. Atque praesentium aut quae sed rerum hic cupiditate iusto aut.",
                        0,
                        6,
                        "https://picsum.photos/640/480/?image=44",
                        false,
                        null,
                        20.39m,
                        5,
                        "Voluptatibus eveniet in.",
                        null,
                    },
                    {
                        19,
                        10,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(9397),
                        "Sunt non id et. Quia maiores eaque non deserunt. Ut nisi non perferendis consectetur harum quisquam quod aspernatur. Nam vitae laboriosam dolorum expedita debitis aspernatur dignissimos laboriosam. Minima exercitationem officia velit incidunt illo et et voluptas. Numquam corrupti voluptatem possimus et autem corporis aut.",
                        0,
                        0,
                        "https://picsum.photos/640/480/?image=1000",
                        false,
                        null,
                        51.76m,
                        5,
                        "Ipsam saepe ab.",
                        null,
                    },
                    {
                        20,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 855, DateTimeKind.Utc).AddTicks(9517),
                        "Possimus consequatur laudantium tempora tempore inventore. Aperiam voluptate repudiandae nostrum rerum eos consequatur inventore. Qui veniam animi harum. Sed maiores omnis voluptate.",
                        0,
                        8,
                        "https://picsum.photos/640/480/?image=49",
                        false,
                        null,
                        46.33m,
                        5,
                        "Amet voluptatem reiciendis.",
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
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(60),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(63),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(63),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(63),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(64),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(64),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(64),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(64),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 8, 21, 25, 12, 865, DateTimeKind.Utc).AddTicks(64),
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
                        new DateTime(2024, 12, 8, 21, 25, 12, 862, DateTimeKind.Utc).AddTicks(4423),
                        "Carroll_Jast@yahoo.com",
                        "Carroll Jast",
                        false,
                        4,
                        0m,
                        null,
                        3,
                    },
                    {
                        2,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 862, DateTimeKind.Utc).AddTicks(7123),
                        "Lyle.Fritsch68@gmail.com",
                        "Lyle Fritsch",
                        false,
                        1,
                        0m,
                        null,
                        8,
                    },
                    {
                        3,
                        5,
                        new DateTime(2024, 12, 8, 21, 25, 12, 862, DateTimeKind.Utc).AddTicks(8072),
                        "Jimmy40@gmail.com",
                        "Jimmy Fay",
                        false,
                        10,
                        0m,
                        null,
                        6,
                    },
                    {
                        4,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 862, DateTimeKind.Utc).AddTicks(8787),
                        "Jack.Hagenes@hotmail.com",
                        "Jack Hagenes",
                        false,
                        15,
                        0m,
                        null,
                        9,
                    },
                    {
                        5,
                        11,
                        new DateTime(2024, 12, 8, 21, 25, 12, 862, DateTimeKind.Utc).AddTicks(9402),
                        "Marta_Schuster29@yahoo.com",
                        "Marta Schuster",
                        false,
                        14,
                        0m,
                        null,
                        9,
                    },
                    {
                        6,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(32),
                        "Marianne9@hotmail.com",
                        "Marianne Powlowski",
                        false,
                        13,
                        0m,
                        null,
                        6,
                    },
                    {
                        7,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(661),
                        "Danielle.Okuneva@yahoo.com",
                        "Danielle Okuneva",
                        false,
                        10,
                        0m,
                        null,
                        2,
                    },
                    {
                        8,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(1232),
                        "Della50@gmail.com",
                        "Della Altenwerth",
                        false,
                        7,
                        0m,
                        null,
                        4,
                    },
                    {
                        9,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(1826),
                        "Wilfred9@hotmail.com",
                        "Wilfred Wiza",
                        false,
                        9,
                        0m,
                        null,
                        5,
                    },
                    {
                        10,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(2526),
                        "Camille48@gmail.com",
                        "Camille Schaden",
                        false,
                        13,
                        0m,
                        null,
                        2,
                    },
                    {
                        11,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(3095),
                        "Roman_Olson@hotmail.com",
                        "Roman Olson",
                        false,
                        4,
                        0m,
                        null,
                        2,
                    },
                    {
                        12,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(3726),
                        "Pete.Williamson@hotmail.com",
                        "Pete Williamson",
                        false,
                        8,
                        0m,
                        null,
                        5,
                    },
                    {
                        13,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(4411),
                        "Lester82@hotmail.com",
                        "Lester Hudson",
                        false,
                        2,
                        0m,
                        null,
                        7,
                    },
                    {
                        14,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(4981),
                        "Kim_Anderson@hotmail.com",
                        "Kim Anderson",
                        false,
                        13,
                        0m,
                        null,
                        8,
                    },
                    {
                        15,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 863, DateTimeKind.Utc).AddTicks(5565),
                        "Luther.Wisozk34@gmail.com",
                        "Luther Wisozk",
                        false,
                        4,
                        0m,
                        null,
                        2,
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
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(8328),
                        false,
                        15,
                        65.69m,
                        3,
                        null,
                    },
                    {
                        2,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9492),
                        false,
                        12,
                        26.11m,
                        3,
                        null,
                    },
                    {
                        3,
                        18,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9535),
                        false,
                        4,
                        82.64m,
                        1,
                        null,
                    },
                    {
                        4,
                        12,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9544),
                        false,
                        7,
                        50.67m,
                        2,
                        null,
                    },
                    {
                        5,
                        12,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9551),
                        false,
                        7,
                        93.37m,
                        2,
                        null,
                    },
                    {
                        6,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9557),
                        false,
                        6,
                        15.80m,
                        2,
                        null,
                    },
                    {
                        7,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9564),
                        false,
                        15,
                        35.23m,
                        3,
                        null,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9571),
                        false,
                        6,
                        68.74m,
                        3,
                        null,
                    },
                    {
                        9,
                        17,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9577),
                        false,
                        13,
                        97.22m,
                        3,
                        null,
                    },
                    {
                        10,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9583),
                        false,
                        9,
                        16.06m,
                        2,
                        null,
                    },
                    {
                        11,
                        5,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9589),
                        false,
                        1,
                        23.12m,
                        3,
                        null,
                    },
                    {
                        12,
                        14,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9595),
                        false,
                        13,
                        25.40m,
                        2,
                        null,
                    },
                    {
                        13,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9601),
                        false,
                        3,
                        80.07m,
                        1,
                        null,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9607),
                        false,
                        12,
                        20.64m,
                        1,
                        null,
                    },
                    {
                        15,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9613),
                        false,
                        7,
                        86.45m,
                        3,
                        null,
                    },
                    {
                        16,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9619),
                        false,
                        6,
                        91.76m,
                        1,
                        null,
                    },
                    {
                        17,
                        19,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9625),
                        false,
                        12,
                        88.06m,
                        3,
                        null,
                    },
                    {
                        18,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9631),
                        false,
                        1,
                        90.36m,
                        1,
                        null,
                    },
                    {
                        19,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9636),
                        false,
                        14,
                        86.14m,
                        3,
                        null,
                    },
                    {
                        20,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9702),
                        false,
                        1,
                        65.78m,
                        1,
                        null,
                    },
                    {
                        21,
                        17,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9709),
                        false,
                        7,
                        74.69m,
                        2,
                        null,
                    },
                    {
                        22,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9715),
                        false,
                        9,
                        18.93m,
                        2,
                        null,
                    },
                    {
                        23,
                        20,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9721),
                        false,
                        1,
                        80.65m,
                        2,
                        null,
                    },
                    {
                        24,
                        19,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9727),
                        false,
                        5,
                        60.80m,
                        3,
                        null,
                    },
                    {
                        25,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9733),
                        false,
                        10,
                        24.53m,
                        1,
                        null,
                    },
                    {
                        26,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9740),
                        false,
                        13,
                        59.48m,
                        1,
                        null,
                    },
                    {
                        27,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9746),
                        false,
                        11,
                        97.57m,
                        1,
                        null,
                    },
                    {
                        28,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9752),
                        false,
                        8,
                        97.28m,
                        1,
                        null,
                    },
                    {
                        29,
                        10,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9758),
                        false,
                        14,
                        44.40m,
                        2,
                        null,
                    },
                    {
                        30,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9764),
                        false,
                        7,
                        93.20m,
                        3,
                        null,
                    },
                    {
                        31,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9770),
                        false,
                        14,
                        41.43m,
                        3,
                        null,
                    },
                    {
                        32,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9777),
                        false,
                        14,
                        64.34m,
                        1,
                        null,
                    },
                    {
                        33,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9782),
                        false,
                        8,
                        43.94m,
                        3,
                        null,
                    },
                    {
                        34,
                        14,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9788),
                        false,
                        10,
                        77.38m,
                        1,
                        null,
                    },
                    {
                        35,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9794),
                        false,
                        10,
                        45.67m,
                        2,
                        null,
                    },
                    {
                        36,
                        20,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9800),
                        false,
                        4,
                        20.16m,
                        2,
                        null,
                    },
                    {
                        37,
                        11,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9806),
                        false,
                        3,
                        78.25m,
                        1,
                        null,
                    },
                    {
                        38,
                        19,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9812),
                        false,
                        2,
                        60.38m,
                        3,
                        null,
                    },
                    {
                        39,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9818),
                        false,
                        12,
                        62.50m,
                        1,
                        null,
                    },
                    {
                        40,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9825),
                        false,
                        13,
                        80.97m,
                        1,
                        null,
                    },
                    {
                        41,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9831),
                        false,
                        15,
                        43.69m,
                        2,
                        null,
                    },
                    {
                        42,
                        3,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9837),
                        false,
                        11,
                        79.39m,
                        1,
                        null,
                    },
                    {
                        43,
                        12,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9843),
                        false,
                        12,
                        94.23m,
                        1,
                        null,
                    },
                    {
                        44,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9849),
                        false,
                        1,
                        80.08m,
                        3,
                        null,
                    },
                    {
                        45,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9855),
                        false,
                        8,
                        59.08m,
                        1,
                        null,
                    },
                    {
                        46,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9861),
                        false,
                        9,
                        72.79m,
                        2,
                        null,
                    },
                    {
                        47,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9867),
                        false,
                        9,
                        47.74m,
                        2,
                        null,
                    },
                    {
                        48,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9873),
                        false,
                        12,
                        98.30m,
                        1,
                        null,
                    },
                    {
                        49,
                        5,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9879),
                        false,
                        3,
                        18.53m,
                        1,
                        null,
                    },
                    {
                        50,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 864, DateTimeKind.Utc).AddTicks(9885),
                        false,
                        3,
                        16.56m,
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
                        8,
                        "Sequi et ut quia.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(558),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        2,
                        15,
                        "Porro incidunt pariatur mollitia doloribus est blanditiis fugit modi.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1582),
                        false,
                        2,
                        null,
                        8,
                    },
                    {
                        3,
                        12,
                        "Temporibus qui placeat molestiae.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1647),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        4,
                        20,
                        "Dolores laborum sequi.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1711),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        5,
                        20,
                        "Repellat eius saepe consequatur vero perferendis quae ducimus dolores qui.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1724),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        6,
                        17,
                        "Nam animi laudantium dolore optio.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1747),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        7,
                        2,
                        "Excepturi ipsum suscipit id distinctio sint dolor.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1761),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        8,
                        6,
                        "Nisi in fuga assumenda praesentium.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1778),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        9,
                        16,
                        "Qui id dicta dolores delectus molestiae consequatur doloribus.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1792),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        10,
                        10,
                        "Quis eveniet ad aut quo.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1810),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        11,
                        18,
                        "Eos molestiae nostrum voluptatibus provident occaecati incidunt.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1823),
                        false,
                        3,
                        null,
                        2,
                    },
                    {
                        12,
                        6,
                        "Ad voluptates aut facilis molestias aut aut.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1873),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        13,
                        18,
                        "Neque aut est et ab fugiat.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1892),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        14,
                        8,
                        "Recusandae quae asperiores soluta autem beatae asperiores dolores minus.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1908),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        15,
                        1,
                        "Itaque numquam aperiam ratione.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1926),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        16,
                        6,
                        "Totam blanditiis voluptas reiciendis fuga consequatur.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1938),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        17,
                        5,
                        "Harum illo velit.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1953),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        18,
                        10,
                        "Pariatur illo vero.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1963),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        19,
                        19,
                        "Et iure et.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1973),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        20,
                        18,
                        "Placeat consectetur laboriosam rerum illum.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(1983),
                        false,
                        5,
                        null,
                        6,
                    },
                    {
                        21,
                        10,
                        "Aut accusamus dolores.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2012),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        22,
                        13,
                        "Illo eum qui modi aperiam sunt praesentium ut mollitia.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2024),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        23,
                        16,
                        "Aut aut harum earum.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2045),
                        false,
                        5,
                        null,
                        8,
                    },
                    {
                        24,
                        9,
                        "Accusamus culpa repellendus assumenda et et facere sed.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2057),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        25,
                        1,
                        "Nobis soluta quidem recusandae.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2074),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        26,
                        19,
                        "Quia distinctio et praesentium voluptas error vel ipsum qui iusto.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2086),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        27,
                        4,
                        "Iure ea optio quam debitis laboriosam facere omnis voluptatem.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2107),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        28,
                        8,
                        "Aut error fugiat harum vel doloribus ipsa quia velit.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2126),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        29,
                        10,
                        "Omnis aut omnis quidem pariatur neque.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2222),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        30,
                        3,
                        "Eum sed eos.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2236),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        31,
                        6,
                        "Quis aut quis ipsam vel dolor facilis.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2247),
                        false,
                        5,
                        null,
                        6,
                    },
                    {
                        32,
                        13,
                        "Delectus ut aut omnis pariatur consequuntur consequatur.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2263),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        33,
                        17,
                        "Modi in sit nisi.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2279),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        34,
                        7,
                        "Non animi architecto sed culpa.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2292),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        35,
                        10,
                        "Aut accusantium quas voluptatum vitae.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2306),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        36,
                        14,
                        "Nobis aliquid illum et.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2319),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        37,
                        6,
                        "Perferendis porro quia ut harum et non aut velit.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2333),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        38,
                        15,
                        "Nostrum aut sapiente aliquam enim et quaerat.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2447),
                        false,
                        5,
                        null,
                        5,
                    },
                    {
                        39,
                        20,
                        "Et esse saepe consequatur aut perspiciatis maiores.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2464),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        40,
                        9,
                        "Cumque tempora nostrum minus est voluptatem eveniet.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2481),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        41,
                        4,
                        "Et iste culpa sint voluptatibus nam saepe optio rem consequatur.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2497),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        42,
                        18,
                        "Quia voluptas perspiciatis molestiae rerum error eos error.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2517),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        43,
                        18,
                        "Quam eum maiores repudiandae unde sint sit.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2534),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        44,
                        9,
                        "Atque mollitia alias odit et modi.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2551),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        45,
                        6,
                        "Consequatur dolores consequuntur itaque ipsa molestias dolore.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2594),
                        false,
                        5,
                        null,
                        2,
                    },
                    {
                        46,
                        17,
                        "Nobis perferendis dolores a.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2613),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        47,
                        13,
                        "Non sed nulla consequuntur.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2625),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        48,
                        5,
                        "Quia at modi fuga molestiae ut.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2637),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        49,
                        3,
                        "Nisi laudantium est facilis similique rerum.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2652),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        50,
                        2,
                        "Totam commodi tempore est ut provident et corrupti.",
                        new DateTime(2024, 12, 8, 21, 25, 12, 858, DateTimeKind.Utc).AddTicks(2667),
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
                        20,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6589),
                        false,
                        null,
                        8,
                    },
                    {
                        2,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6805),
                        false,
                        null,
                        6,
                    },
                    {
                        3,
                        11,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6811),
                        false,
                        null,
                        2,
                    },
                    {
                        4,
                        12,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6814),
                        false,
                        null,
                        7,
                    },
                    {
                        5,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6817),
                        false,
                        null,
                        10,
                    },
                    {
                        6,
                        12,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6819),
                        false,
                        null,
                        8,
                    },
                    {
                        7,
                        13,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6822),
                        false,
                        null,
                        5,
                    },
                    {
                        8,
                        19,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6824),
                        false,
                        null,
                        3,
                    },
                    {
                        9,
                        17,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6827),
                        false,
                        null,
                        3,
                    },
                    {
                        10,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6829),
                        false,
                        null,
                        10,
                    },
                    {
                        11,
                        20,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6832),
                        false,
                        null,
                        10,
                    },
                    {
                        12,
                        14,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6834),
                        false,
                        null,
                        8,
                    },
                    {
                        13,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6837),
                        false,
                        null,
                        6,
                    },
                    {
                        14,
                        17,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6839),
                        false,
                        null,
                        7,
                    },
                    {
                        15,
                        2,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6842),
                        false,
                        null,
                        7,
                    },
                    {
                        16,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6844),
                        false,
                        null,
                        4,
                    },
                    {
                        17,
                        6,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6847),
                        false,
                        null,
                        5,
                    },
                    {
                        18,
                        4,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6849),
                        false,
                        null,
                        5,
                    },
                    {
                        19,
                        15,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6852),
                        false,
                        null,
                        6,
                    },
                    {
                        20,
                        17,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6854),
                        false,
                        null,
                        6,
                    },
                    {
                        21,
                        15,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6857),
                        false,
                        null,
                        10,
                    },
                    {
                        22,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6859),
                        false,
                        null,
                        2,
                    },
                    {
                        23,
                        7,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6861),
                        false,
                        null,
                        2,
                    },
                    {
                        24,
                        15,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6864),
                        false,
                        null,
                        6,
                    },
                    {
                        25,
                        17,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6866),
                        false,
                        null,
                        7,
                    },
                    {
                        26,
                        9,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6868),
                        false,
                        null,
                        2,
                    },
                    {
                        27,
                        1,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6871),
                        false,
                        null,
                        2,
                    },
                    {
                        28,
                        12,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6873),
                        false,
                        null,
                        7,
                    },
                    {
                        29,
                        15,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6876),
                        false,
                        null,
                        3,
                    },
                    {
                        30,
                        8,
                        new DateTime(2024, 12, 8, 21, 25, 12, 859, DateTimeKind.Utc).AddTicks(6878),
                        false,
                        null,
                        3,
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

            migrationBuilder.DropTable(name: "Publishers");
        }
    }
}
