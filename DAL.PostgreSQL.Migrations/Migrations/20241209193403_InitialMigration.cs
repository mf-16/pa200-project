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
                        "Port Jadonberg",
                        "Estonia",
                        new DateTime(2024, 12, 9, 19, 34, 2, 785, DateTimeKind.Utc).AddTicks(9901),
                        false,
                        "Washington",
                        "1661 Zieme Circle",
                        null,
                        "91152-7588",
                    },
                    {
                        2,
                        "South Natland",
                        "Turks and Caicos Islands",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(574),
                        false,
                        "Hawaii",
                        "78681 Cristian Rapids",
                        null,
                        "51009",
                    },
                    {
                        3,
                        "Pricetown",
                        "Svalbard & Jan Mayen Islands",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(768),
                        false,
                        "Delaware",
                        "2336 Beatrice Hill",
                        null,
                        "07625",
                    },
                    {
                        4,
                        "Richmondborough",
                        "Lesotho",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(878),
                        false,
                        "Mississippi",
                        "130 Cathrine Common",
                        null,
                        "00827-0901",
                    },
                    {
                        5,
                        "Lake Gaston",
                        "Jersey",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1017),
                        false,
                        "New Mexico",
                        "579 Abbott Falls",
                        null,
                        "28648-7736",
                    },
                    {
                        6,
                        "Mannview",
                        "Hong Kong",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1177),
                        false,
                        "Washington",
                        "49124 Destany Underpass",
                        null,
                        "92057",
                    },
                    {
                        7,
                        "Port Abdul",
                        "Saint Kitts and Nevis",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1312),
                        false,
                        "Massachusetts",
                        "14873 Mittie Mission",
                        null,
                        "85197",
                    },
                    {
                        8,
                        "East Gastonfort",
                        "Belgium",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1431),
                        false,
                        "Wyoming",
                        "72366 Anderson Lane",
                        null,
                        "46189",
                    },
                    {
                        9,
                        "Rogahnview",
                        "Iraq",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1605),
                        false,
                        "Nevada",
                        "1642 Rebeca Canyon",
                        null,
                        "90741-3009",
                    },
                    {
                        10,
                        "West Stephen",
                        "Somalia",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1741),
                        false,
                        "Vermont",
                        "61099 Wisozk Ways",
                        null,
                        "88019",
                    },
                    {
                        11,
                        "Orlohaven",
                        "Taiwan",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1866),
                        false,
                        "South Dakota",
                        "7104 Hand Dale",
                        null,
                        "08771",
                    },
                    {
                        12,
                        "West Miller",
                        "Andorra",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(1991),
                        false,
                        "Idaho",
                        "602 Chadrick Common",
                        null,
                        "37990-2364",
                    },
                    {
                        13,
                        "Orlandfort",
                        "Singapore",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(2120),
                        false,
                        "Wyoming",
                        "060 Marquardt Turnpike",
                        null,
                        "34797",
                    },
                    {
                        14,
                        "Reyside",
                        "Romania",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(2236),
                        false,
                        "Florida",
                        "56232 Darien Place",
                        null,
                        "79479",
                    },
                    {
                        15,
                        "New Myleneborough",
                        "French Guiana",
                        new DateTime(2024, 12, 9, 19, 34, 2, 786, DateTimeKind.Utc).AddTicks(2357),
                        false,
                        "Nebraska",
                        "4092 Ebert Hollow",
                        null,
                        "09121-4276",
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
                        "b4b4c4c2-ed15-4e3a-88da-1945ebbbac98",
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
                        "d51ccd4c-fb2b-4df4-90cc-b5d17cdb41e4",
                        false,
                        "fake_admin",
                    },
                    {
                        2,
                        0,
                        "b0613549-e898-49f5-bf4b-d71a1fba8882",
                        "Colleen.Monahan@yahoo.com",
                        true,
                        false,
                        null,
                        "Hazel Roob",
                        null,
                        null,
                        null,
                        "1-826-380-6806 x48727",
                        false,
                        "45429c3e-fe36-4921-93cb-532ca9845814",
                        false,
                        "Moises_Walker",
                    },
                    {
                        3,
                        0,
                        "91a4d95c-8ec1-4009-8648-2c9893aaf897",
                        "Mikayla39@hotmail.com",
                        true,
                        false,
                        null,
                        "Ubaldo Streich",
                        null,
                        null,
                        null,
                        "(706) 779-2981 x44590",
                        false,
                        "698ddaa5-09f6-4ad6-9225-1274610154fa",
                        false,
                        "Noemy91",
                    },
                    {
                        4,
                        0,
                        "2c37cbab-987f-42f0-b9aa-e357920a342c",
                        "Jeromy_Hammes20@gmail.com",
                        true,
                        false,
                        null,
                        "Mazie Pouros",
                        null,
                        null,
                        null,
                        "593-828-4432 x53957",
                        false,
                        "3943f29c-51aa-4de0-a871-7e69dc9a3f4f",
                        false,
                        "Curtis.Smith95",
                    },
                    {
                        5,
                        0,
                        "7f5298dd-8fd9-454c-802e-2b8aed7a9791",
                        "Cordelia22@yahoo.com",
                        true,
                        false,
                        null,
                        "Estefania Harvey",
                        null,
                        null,
                        null,
                        "(359) 560-1000 x8805",
                        false,
                        "061d5f59-9c38-4189-ba2e-b17f48ceb9c9",
                        false,
                        "Sigmund46",
                    },
                    {
                        6,
                        0,
                        "24b64f22-2f37-4964-a901-11f59132da5d",
                        "Brionna96@yahoo.com",
                        true,
                        false,
                        null,
                        "Clarabelle Durgan",
                        null,
                        null,
                        null,
                        "(924) 602-6871 x70313",
                        false,
                        "cee1ee88-a4b6-4285-ab53-ed7a4603a57c",
                        false,
                        "Erick.Legros58",
                    },
                    {
                        7,
                        0,
                        "364d2669-18e6-4a8c-bf1b-a1a5177eaf61",
                        "William8@yahoo.com",
                        true,
                        false,
                        null,
                        "Candido O'Kon",
                        null,
                        null,
                        null,
                        "808.350.5414 x25210",
                        false,
                        "20bdbdab-d06a-4dd3-af8d-f55d64e1dfe8",
                        false,
                        "Drew_Hand",
                    },
                    {
                        8,
                        0,
                        "80d57842-b230-4801-bfaa-b6edfa611fd7",
                        "Gladys_Graham@hotmail.com",
                        true,
                        false,
                        null,
                        "Felicia Grimes",
                        null,
                        null,
                        null,
                        "1-468-425-1771 x853",
                        false,
                        "f1418159-3cfc-425f-bbf6-d3706fac61a6",
                        false,
                        "Marquis81",
                    },
                    {
                        9,
                        0,
                        "da8e749f-e4d7-4159-a2ab-dfde3a383905",
                        "Pete_Lueilwitz36@hotmail.com",
                        true,
                        false,
                        null,
                        "Hosea Wintheiser",
                        null,
                        null,
                        null,
                        "411-307-2280 x4278",
                        false,
                        "5040b834-fdcc-4e18-ad7c-d1dd4665bd85",
                        false,
                        "Hudson_Botsford26",
                    },
                    {
                        10,
                        0,
                        "989d6b38-8178-4e20-8ef7-1a4b69ccebc2",
                        "Kayli16@gmail.com",
                        true,
                        false,
                        null,
                        "Bradly Flatley",
                        null,
                        null,
                        null,
                        "295-262-9317 x33214",
                        false,
                        "52f78318-b512-4a2e-af00-df48e603c916",
                        false,
                        "Kaleb.McDermott",
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
                        "Non sint ipsum incidunt commodi suscipit architecto aut. Ut modi nostrum sit aut distinctio quas. Iure quidem blanditiis voluptatem vel. Sapiente in totam rerum voluptatem. Cumque ullam asperiores.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(4062),
                        false,
                        "Celia Stamm",
                        null,
                    },
                    {
                        2,
                        "Id non accusamus aliquid officia enim exercitationem quam. Nihil illo rem a natus non illo asperiores officia. Vel qui in rem eos. Itaque corrupti ex commodi eos voluptatum consequatur enim nesciunt.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(4420),
                        false,
                        "Lonie Lemke",
                        null,
                    },
                    {
                        3,
                        "Inventore consequatur voluptatum esse recusandae sequi totam. Dolorem provident eum quia illo. Distinctio officiis adipisci id quas aut porro. Eum numquam dolor voluptates tempore et. Laboriosam ut nemo eligendi qui vitae animi. Consectetur ex non beatae mollitia magni dolorem et saepe.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(4575),
                        false,
                        "Gracie Gleichner",
                        null,
                    },
                    {
                        4,
                        "Consequatur suscipit dolore maiores sit ad ut adipisci omnis. Aliquid neque porro et voluptatem occaecati est. Reprehenderit quia illum. Est corporis magni minima quod. Error facere quisquam occaecati facere repellendus sequi nisi.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(4757),
                        false,
                        "Amir Jones",
                        null,
                    },
                    {
                        5,
                        "Rerum consequatur est facilis recusandae ut aut hic inventore delectus. Maiores possimus et voluptatem est quaerat atque. Distinctio aut quaerat ut fugit. Vitae porro et qui esse ipsum eveniet.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(4861),
                        false,
                        "Zechariah Hudson",
                        null,
                    },
                    {
                        6,
                        "Quod ut soluta. Numquam quia ex modi nemo similique dolorum et aut itaque. Voluptas quod eum et qui excepturi reiciendis.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(4983),
                        false,
                        "Aurelia O'Hara",
                        null,
                    },
                    {
                        7,
                        "Distinctio possimus tempore. Est esse tenetur mollitia quo. Qui tempora aliquid.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(5051),
                        false,
                        "Fanny Bauch",
                        null,
                    },
                    {
                        8,
                        "Ea alias qui dolorem quia ad inventore sint illo. Quae in dolores blanditiis sunt. Enim minus quas autem tempore ea velit sed non laudantium. Ab nisi repellendus in consequatur sapiente. Totam aut quae aut consequatur quam harum repellat. Sint est velit rerum est dolorum qui quo.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(5124),
                        false,
                        "Adella Daniel",
                        null,
                    },
                    {
                        9,
                        "Dolorem aut qui unde nam officia vero consequatur id cupiditate. Rerum totam et voluptates sint consectetur consequatur maxime. Accusamus voluptatum quasi laborum praesentium doloremque ut dolore repudiandae.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(5248),
                        false,
                        "Bradly Fahey",
                        null,
                    },
                    {
                        10,
                        "Eaque excepturi rerum sit harum atque numquam. Dolores distinctio omnis veniam quo iusto. Eum facilis rerum magni ut. Ut saepe beatae quia vero. Earum ea veritatis facilis est dolorum sed. Inventore laboriosam pariatur itaque vitae quod.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 775, DateTimeKind.Utc).AddTicks(5350),
                        false,
                        "Dora Cartwright",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Qui aperiam enim." },
                    { 2, "Rerum unde exercitationem." },
                    { 3, "Molestias quidem aspernatur." },
                    { 4, "Quo sequi in." },
                    { 5, "Aliquam dolor et." },
                    { 6, "Voluptas enim et." },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Porro voluptates esse nesciunt error et. Sint voluptatibus doloribus. Architecto soluta et aut. Et exercitationem molestias dolor dolores. Itaque consequatur in dolorem dolor suscipit et sit sed. Nemo occaecati sint ipsam asperiores odio.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 777, DateTimeKind.Utc).AddTicks(3300),
                        false,
                        "Ziemann Inc",
                        null,
                    },
                    {
                        2,
                        "Laborum eos ut fugiat quibusdam velit molestiae eum. Illo soluta est eos suscipit. Autem quos vel sit.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 777, DateTimeKind.Utc).AddTicks(4136),
                        false,
                        "Watsica, Murazik and Gislason",
                        null,
                    },
                    {
                        3,
                        "Qui voluptates accusamus ipsum eius rem odit. Quas ut est et ratione ducimus maiores exercitationem. Commodi id nihil et voluptas aliquam minima iure qui. Illum vitae inventore excepturi quae.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 777, DateTimeKind.Utc).AddTicks(4419),
                        false,
                        "Robel, Emmerich and Skiles",
                        null,
                    },
                    {
                        4,
                        "Quo velit a ut tenetur error nobis. Eos doloremque sapiente occaecati. Architecto corporis doloribus.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 777, DateTimeKind.Utc).AddTicks(4633),
                        false,
                        "Swift, Barton and Paucek",
                        null,
                    },
                    {
                        5,
                        "Rem doloribus placeat sint qui reiciendis provident omnis. Temporibus non dolores aliquam. Minus deserunt fugit quam quis. Voluptatem veritatis impedit unde cum aperiam itaque ea.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 777, DateTimeKind.Utc).AddTicks(4783),
                        false,
                        "Hilpert, Flatley and Stokes",
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
                        3,
                        new DateTime(2024, 12, 9, 19, 34, 2, 780, DateTimeKind.Utc).AddTicks(8134),
                        "Est molestias tempora. Voluptatum laudantium et. Veritatis et earum illo provident et doloremque. Accusamus eum voluptatum earum nulla dolor veniam et et perspiciatis. Ut voluptatem qui suscipit consequatur quae et.",
                        0,
                        "https://picsum.photos/640/480/?image=392",
                        false,
                        null,
                        31.66m,
                        5,
                        1,
                        "Qui sint sed.",
                        null,
                    },
                    {
                        2,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 780, DateTimeKind.Utc).AddTicks(9966),
                        "Dignissimos eos velit incidunt alias accusamus hic aspernatur sint totam. Eaque tempora perferendis velit architecto pariatur voluptates non dolor magnam. Non enim consequatur.",
                        0,
                        "https://picsum.photos/640/480/?image=809",
                        false,
                        null,
                        12.73m,
                        2,
                        2,
                        "Corrupti aliquam minima.",
                        null,
                    },
                    {
                        3,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(183),
                        "Quo est quidem ut sed. Suscipit alias velit maiores sit qui deserunt perferendis ea dolores. Sequi debitis magnam facilis ut quia placeat sed. Nulla et sunt. Velit fugit necessitatibus id debitis qui. Enim voluptas sapiente ut iusto cumque nostrum suscipit.",
                        0,
                        "https://picsum.photos/640/480/?image=298",
                        false,
                        null,
                        37.76m,
                        6,
                        1,
                        "Eaque facere voluptas.",
                        null,
                    },
                    {
                        4,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(421),
                        "Voluptatem eos voluptatum et recusandae rerum id eos aliquid voluptatibus. Qui nobis totam ad quasi provident doloremque. In possimus perspiciatis eligendi necessitatibus. Velit aut laudantium quod et qui in. Quia aliquam tempora laborum et autem exercitationem sed sit quas. Dolorem ex quibusdam omnis a consequatur.",
                        0,
                        "https://picsum.photos/640/480/?image=1043",
                        false,
                        null,
                        90.97m,
                        5,
                        2,
                        "Sed ab voluptatem.",
                        null,
                    },
                    {
                        5,
                        10,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(655),
                        "Rerum itaque repellat dolorem quia veniam id. Unde quas quia. Quae fuga ad sunt.",
                        0,
                        "https://picsum.photos/640/480/?image=725",
                        false,
                        null,
                        77.70m,
                        4,
                        1,
                        "Ut quas rem.",
                        null,
                    },
                    {
                        6,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(720),
                        "Qui doloremque autem repellat laboriosam perspiciatis quo quo ut tenetur. Natus libero dolor unde eius velit corporis odit rerum doloremque. Soluta veritatis ut quo eos. Nostrum nostrum doloribus quia. Molestiae aperiam ad rerum quia ipsum error dolorum. Quaerat incidunt assumenda voluptatibus quidem vel itaque qui officia eius.",
                        0,
                        "https://picsum.photos/640/480/?image=563",
                        false,
                        null,
                        52.42m,
                        1,
                        2,
                        "Totam quis facilis.",
                        null,
                    },
                    {
                        7,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(873),
                        "Recusandae soluta debitis vel sit quisquam nam dolor quos recusandae. Quia iste eveniet. Consequatur sunt ullam ex veniam id. Quibusdam dignissimos eum minus quaerat. Enim praesentium eligendi eum delectus quibusdam aliquam et.",
                        0,
                        "https://picsum.photos/640/480/?image=542",
                        false,
                        null,
                        14.24m,
                        6,
                        3,
                        "Assumenda excepturi et.",
                        null,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1073),
                        "Odit commodi aliquam soluta harum blanditiis aliquid numquam dolores. Qui quisquam quidem magni ea incidunt explicabo. Magnam sapiente non. Ut perspiciatis ut ea repellendus vero et eligendi. Est ut voluptatem ut.",
                        0,
                        "https://picsum.photos/640/480/?image=363",
                        false,
                        null,
                        79.16m,
                        6,
                        3,
                        "Deleniti est nihil.",
                        null,
                    },
                    {
                        9,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1284),
                        "Hic fuga debitis odit consectetur corrupti voluptatem. Provident repellendus ducimus optio non laborum ea cumque sed. Asperiores tempora voluptatum rerum.",
                        0,
                        "https://picsum.photos/640/480/?image=31",
                        false,
                        null,
                        24.89m,
                        1,
                        3,
                        "Quo ut explicabo.",
                        null,
                    },
                    {
                        10,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1353),
                        "Distinctio quisquam beatae tempora quod. Modi recusandae ab cum sed molestiae. Tenetur minima reiciendis reprehenderit animi.",
                        0,
                        "https://picsum.photos/640/480/?image=267",
                        false,
                        null,
                        17.72m,
                        3,
                        2,
                        "Et et consequuntur.",
                        null,
                    },
                    {
                        11,
                        3,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1448),
                        "Possimus veniam totam ipsa aut voluptas qui. Enim ullam at inventore aut ex et. Consequatur magnam iste aut porro consequatur ea fugiat. Qui ad vitae. Assumenda ut voluptas voluptate quod.",
                        0,
                        "https://picsum.photos/640/480/?image=862",
                        false,
                        null,
                        50.27m,
                        5,
                        2,
                        "Quis odit quaerat.",
                        null,
                    },
                    {
                        12,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1575),
                        "Ipsam voluptatum eum magnam dolores et. Repudiandae vel magnam quod dignissimos. Quidem quia cumque tempora asperiores. Ipsam voluptas ullam repudiandae commodi sit sed ad et iusto.",
                        0,
                        "https://picsum.photos/640/480/?image=589",
                        false,
                        null,
                        26.68m,
                        1,
                        3,
                        "Earum explicabo voluptas.",
                        null,
                    },
                    {
                        13,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1657),
                        "Voluptate aut esse necessitatibus. Ullam non voluptas temporibus tempore. Atque sit perspiciatis aut iure. Tempora excepturi suscipit aut.",
                        0,
                        "https://picsum.photos/640/480/?image=632",
                        false,
                        null,
                        41.80m,
                        2,
                        4,
                        "Tempore dolores qui.",
                        null,
                    },
                    {
                        14,
                        10,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1755),
                        "Nostrum ipsa aperiam dignissimos hic. A quia sed ut facilis tempora consectetur repudiandae officia. Fugiat consequuntur recusandae voluptatem. Debitis reiciendis quo et cupiditate est est ut fugit amet.",
                        0,
                        "https://picsum.photos/640/480/?image=753",
                        false,
                        null,
                        72.54m,
                        3,
                        5,
                        "Ipsam dolore dolores.",
                        null,
                    },
                    {
                        15,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(1868),
                        "Asperiores ea aspernatur sit fuga. Iste dolorem est blanditiis distinctio molestias dolores et voluptatem. Est enim quam architecto illo aperiam id non reprehenderit ut. Dolorem quo labore rerum magnam.",
                        0,
                        "https://picsum.photos/640/480/?image=899",
                        false,
                        null,
                        60.33m,
                        5,
                        1,
                        "Dolorem error modi.",
                        null,
                    },
                    {
                        16,
                        3,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(2047),
                        "Possimus voluptates facilis ex nihil et enim culpa enim. Minima perferendis odit aut iusto qui quia impedit sunt. Beatae aliquid aut nisi. Cupiditate necessitatibus est mollitia et sit rem itaque. Ducimus modi non perferendis voluptatibus.",
                        0,
                        "https://picsum.photos/640/480/?image=121",
                        false,
                        null,
                        27.95m,
                        3,
                        2,
                        "Architecto quisquam qui.",
                        null,
                    },
                    {
                        17,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(2171),
                        "Fuga consequatur consequatur ut quis veniam doloribus. Nemo quis ducimus iure laborum ullam. Rem eligendi cumque in. Placeat ipsum modi laborum laborum ullam ipsam ex omnis. Est hic voluptate impedit ad in quo qui sit ipsum. Dicta quia consectetur vitae laborum sit sed.",
                        0,
                        "https://picsum.photos/640/480/?image=91",
                        false,
                        null,
                        16.54m,
                        2,
                        3,
                        "Quibusdam perferendis velit.",
                        null,
                    },
                    {
                        18,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(2328),
                        "Sunt nihil vitae. Asperiores impedit unde veritatis. Voluptatem est occaecati. Ut aut perspiciatis dolorem. Voluptate tenetur nobis qui laudantium soluta dolores. Id fuga nobis impedit impedit ad praesentium dolores itaque.",
                        0,
                        "https://picsum.photos/640/480/?image=916",
                        false,
                        null,
                        31.58m,
                        3,
                        5,
                        "Ut consectetur exercitationem.",
                        null,
                    },
                    {
                        19,
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(2524),
                        "Nulla est iure alias et et atque aspernatur. Et tempora dicta eius quas sed non ut earum molestiae. Distinctio tempora nemo. Voluptatem et dignissimos incidunt veritatis dolorum consequatur dolores rerum ut. Necessitatibus iure laborum dolorem facilis sapiente dolores aut.",
                        0,
                        "https://picsum.photos/640/480/?image=1043",
                        false,
                        null,
                        13.69m,
                        5,
                        4,
                        "Ut est mollitia.",
                        null,
                    },
                    {
                        20,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 781, DateTimeKind.Utc).AddTicks(2629),
                        "Officia non ut. Quis ut hic id. Rerum in ut est dolorem dicta aut vel distinctio. Quidem velit dignissimos magni. Ducimus totam et qui voluptatem qui dolorem omnis quae debitis.",
                        0,
                        "https://picsum.photos/640/480/?image=606",
                        false,
                        null,
                        92.26m,
                        5,
                        1,
                        "Nostrum vel quae.",
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
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5330),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5332),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5332),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5332),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5333),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5333),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5333),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5334),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5334),
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
                        new DateTime(2024, 12, 9, 19, 34, 2, 787, DateTimeKind.Utc).AddTicks(6429),
                        "Maureen_Halvorson75@gmail.com",
                        "Maureen Halvorson",
                        false,
                        1,
                        0m,
                        null,
                        4,
                    },
                    {
                        2,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(31),
                        "Erica.Smith67@hotmail.com",
                        "Erica Smith",
                        false,
                        6,
                        0m,
                        null,
                        4,
                    },
                    {
                        3,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(1211),
                        "Jimmy.Tremblay8@yahoo.com",
                        "Jimmy Tremblay",
                        false,
                        4,
                        0m,
                        null,
                        2,
                    },
                    {
                        4,
                        12,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(1829),
                        "Dewey_Cummerata18@hotmail.com",
                        "Dewey Cummerata",
                        false,
                        1,
                        0m,
                        null,
                        4,
                    },
                    {
                        5,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(2446),
                        "Sandra_Walsh@hotmail.com",
                        "Sandra Walsh",
                        false,
                        1,
                        0m,
                        null,
                        7,
                    },
                    {
                        6,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(3020),
                        "Kay.MacGyver76@yahoo.com",
                        "Kay MacGyver",
                        false,
                        14,
                        0m,
                        null,
                        2,
                    },
                    {
                        7,
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(3545),
                        "Cynthia_Larkin@yahoo.com",
                        "Cynthia Larkin",
                        false,
                        9,
                        0m,
                        null,
                        2,
                    },
                    {
                        8,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(4124),
                        "Freda_Bradtke93@yahoo.com",
                        "Freda Bradtke",
                        false,
                        4,
                        0m,
                        null,
                        10,
                    },
                    {
                        9,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(4656),
                        "Frances_Hirthe29@yahoo.com",
                        "Frances Hirthe",
                        false,
                        15,
                        0m,
                        null,
                        6,
                    },
                    {
                        10,
                        3,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(5170),
                        "Randal_Bergnaum19@gmail.com",
                        "Randal Bergnaum",
                        false,
                        4,
                        0m,
                        null,
                        4,
                    },
                    {
                        11,
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(5909),
                        "Ed_Watsica@gmail.com",
                        "Ed Watsica",
                        false,
                        12,
                        0m,
                        null,
                        10,
                    },
                    {
                        12,
                        13,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(6423),
                        "Mark.Kunde45@yahoo.com",
                        "Mark Kunde",
                        false,
                        2,
                        0m,
                        null,
                        9,
                    },
                    {
                        13,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(6917),
                        "Matt_Hayes@hotmail.com",
                        "Matt Hayes",
                        false,
                        3,
                        0m,
                        null,
                        4,
                    },
                    {
                        14,
                        10,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(8025),
                        "Jonathan77@gmail.com",
                        "Jonathan Runte",
                        false,
                        11,
                        0m,
                        null,
                        8,
                    },
                    {
                        15,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 788, DateTimeKind.Utc).AddTicks(8511),
                        "Jennie.Morar50@yahoo.com",
                        "Jennie Morar",
                        false,
                        4,
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
                        19,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(3341),
                        false,
                        9,
                        36.55m,
                        3,
                        null,
                    },
                    {
                        2,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4683),
                        false,
                        14,
                        93.27m,
                        2,
                        null,
                    },
                    {
                        3,
                        14,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4730),
                        false,
                        9,
                        59.73m,
                        3,
                        null,
                    },
                    {
                        4,
                        20,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4741),
                        false,
                        1,
                        95.76m,
                        1,
                        null,
                    },
                    {
                        5,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4750),
                        false,
                        4,
                        56.24m,
                        3,
                        null,
                    },
                    {
                        6,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4759),
                        false,
                        13,
                        39.26m,
                        1,
                        null,
                    },
                    {
                        7,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4767),
                        false,
                        12,
                        30.06m,
                        3,
                        null,
                    },
                    {
                        8,
                        10,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4775),
                        false,
                        13,
                        97.71m,
                        3,
                        null,
                    },
                    {
                        9,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4784),
                        false,
                        3,
                        45.76m,
                        1,
                        null,
                    },
                    {
                        10,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4794),
                        false,
                        5,
                        94.02m,
                        1,
                        null,
                    },
                    {
                        11,
                        10,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4802),
                        false,
                        12,
                        17.86m,
                        1,
                        null,
                    },
                    {
                        12,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4810),
                        false,
                        10,
                        53.24m,
                        2,
                        null,
                    },
                    {
                        13,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4819),
                        false,
                        9,
                        29.63m,
                        1,
                        null,
                    },
                    {
                        14,
                        18,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4826),
                        false,
                        12,
                        70.39m,
                        1,
                        null,
                    },
                    {
                        15,
                        11,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4833),
                        false,
                        4,
                        59.60m,
                        1,
                        null,
                    },
                    {
                        16,
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4841),
                        false,
                        5,
                        64.80m,
                        2,
                        null,
                    },
                    {
                        17,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4849),
                        false,
                        11,
                        56.59m,
                        3,
                        null,
                    },
                    {
                        18,
                        15,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4857),
                        false,
                        2,
                        60.21m,
                        3,
                        null,
                    },
                    {
                        19,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4865),
                        false,
                        6,
                        13.36m,
                        1,
                        null,
                    },
                    {
                        20,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4873),
                        false,
                        11,
                        37.56m,
                        3,
                        null,
                    },
                    {
                        21,
                        14,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4880),
                        false,
                        10,
                        44.54m,
                        3,
                        null,
                    },
                    {
                        22,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4888),
                        false,
                        4,
                        53.04m,
                        1,
                        null,
                    },
                    {
                        23,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4896),
                        false,
                        13,
                        72.79m,
                        2,
                        null,
                    },
                    {
                        24,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4903),
                        false,
                        1,
                        39.66m,
                        1,
                        null,
                    },
                    {
                        25,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4911),
                        false,
                        8,
                        73.01m,
                        3,
                        null,
                    },
                    {
                        26,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4919),
                        false,
                        14,
                        58.84m,
                        1,
                        null,
                    },
                    {
                        27,
                        11,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4927),
                        false,
                        11,
                        78.98m,
                        3,
                        null,
                    },
                    {
                        28,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4935),
                        false,
                        15,
                        27.98m,
                        1,
                        null,
                    },
                    {
                        29,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4943),
                        false,
                        3,
                        26.92m,
                        2,
                        null,
                    },
                    {
                        30,
                        11,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4950),
                        false,
                        10,
                        32.70m,
                        1,
                        null,
                    },
                    {
                        31,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(4958),
                        false,
                        6,
                        37.42m,
                        2,
                        null,
                    },
                    {
                        32,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5024),
                        false,
                        15,
                        69.89m,
                        3,
                        null,
                    },
                    {
                        33,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5032),
                        false,
                        2,
                        67.28m,
                        2,
                        null,
                    },
                    {
                        34,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5040),
                        false,
                        2,
                        76.73m,
                        3,
                        null,
                    },
                    {
                        35,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5048),
                        false,
                        15,
                        53.12m,
                        3,
                        null,
                    },
                    {
                        36,
                        16,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5056),
                        false,
                        14,
                        99.20m,
                        3,
                        null,
                    },
                    {
                        37,
                        14,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5063),
                        false,
                        15,
                        59.98m,
                        3,
                        null,
                    },
                    {
                        38,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5071),
                        false,
                        15,
                        93.08m,
                        3,
                        null,
                    },
                    {
                        39,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5079),
                        false,
                        3,
                        75.61m,
                        2,
                        null,
                    },
                    {
                        40,
                        19,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5086),
                        false,
                        4,
                        54.86m,
                        1,
                        null,
                    },
                    {
                        41,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5094),
                        false,
                        1,
                        40.02m,
                        2,
                        null,
                    },
                    {
                        42,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5102),
                        false,
                        2,
                        40.32m,
                        3,
                        null,
                    },
                    {
                        43,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5110),
                        false,
                        6,
                        74.86m,
                        3,
                        null,
                    },
                    {
                        44,
                        19,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5117),
                        false,
                        6,
                        57.77m,
                        1,
                        null,
                    },
                    {
                        45,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5126),
                        false,
                        11,
                        87.57m,
                        2,
                        null,
                    },
                    {
                        46,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5133),
                        false,
                        1,
                        74.35m,
                        1,
                        null,
                    },
                    {
                        47,
                        16,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5141),
                        false,
                        12,
                        30.32m,
                        2,
                        null,
                    },
                    {
                        48,
                        13,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5148),
                        false,
                        4,
                        53.57m,
                        3,
                        null,
                    },
                    {
                        49,
                        15,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5156),
                        false,
                        4,
                        41.83m,
                        1,
                        null,
                    },
                    {
                        50,
                        19,
                        new DateTime(2024, 12, 9, 19, 34, 2, 790, DateTimeKind.Utc).AddTicks(5163),
                        false,
                        5,
                        96.35m,
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
                        20,
                        "Sunt nesciunt cum.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(7573),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        2,
                        4,
                        "Quo quam ipsam impedit laborum corporis.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(8710),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        3,
                        19,
                        "In laboriosam voluptatem maxime non facere iste aut autem.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(8782),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        4,
                        2,
                        "Doloribus laudantium dolorum nostrum.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(8820),
                        false,
                        5,
                        null,
                        2,
                    },
                    {
                        5,
                        9,
                        "Aliquid ipsum nisi soluta animi neque fuga vel eveniet.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(8966),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        6,
                        18,
                        "Quo quae aliquam modi eligendi.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(8996),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        7,
                        13,
                        "Quisquam quis nihil consequatur aut consectetur veniam expedita expedita saepe.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9018),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        8,
                        2,
                        "Optio dolor nulla illo unde voluptatem.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9053),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        9,
                        9,
                        "Tenetur dolores eius rerum neque.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9076),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        10,
                        19,
                        "Eum cumque perferendis voluptas ut quidem.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9094),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        11,
                        2,
                        "Fuga nihil odio natus hic ut sequi.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9116),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        12,
                        7,
                        "Aut nihil facere voluptas id qui nostrum molestias tempora.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9142),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        13,
                        6,
                        "Nemo quisquam repellat corporis alias veniam est illum.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9208),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        14,
                        3,
                        "Perferendis quia voluptates quis.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9234),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        15,
                        5,
                        "Libero vitae necessitatibus qui magnam iusto ut et sunt nobis.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9250),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        16,
                        2,
                        "Officiis vel voluptas dolorem et iure.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9279),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        17,
                        19,
                        "Labore eveniet ipsam et quos.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9298),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        18,
                        14,
                        "Vero voluptatem labore sit maiores qui commodi officia omnis voluptatem.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9317),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        19,
                        12,
                        "Corporis sint quam ea amet.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9344),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        20,
                        16,
                        "Ut error incidunt ab quia quo atque et odio.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9393),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        21,
                        13,
                        "Ut dolore et aut aliquid consequatur facilis.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9423),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        22,
                        6,
                        "Quidem maxime blanditiis vel cum quis et.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9445),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        23,
                        20,
                        "Atque voluptate voluptatum eos commodi.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9467),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        24,
                        11,
                        "Earum quam optio vero eaque nisi voluptatibus est sed qui.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9486),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        25,
                        13,
                        "Voluptates non iusto at expedita qui qui praesentium laudantium aut.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9513),
                        false,
                        5,
                        null,
                        5,
                    },
                    {
                        26,
                        13,
                        "Ratione voluptas odit.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9542),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        27,
                        12,
                        "Quibusdam eum autem nesciunt excepturi nam.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9556),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        28,
                        17,
                        "Tempora repudiandae vitae dolores veniam assumenda.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9606),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        29,
                        11,
                        "Ea animi earum accusantium cupiditate optio.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9626),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        30,
                        17,
                        "Ullam et aut error officiis dolor consequatur perspiciatis velit.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9646),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        31,
                        20,
                        "Temporibus totam hic repellat iusto cum.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9674),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        32,
                        15,
                        "Consectetur adipisci odit ut consequatur.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9692),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        33,
                        17,
                        "Architecto ducimus voluptas temporibus iure.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9711),
                        false,
                        5,
                        null,
                        4,
                    },
                    {
                        34,
                        15,
                        "Sed rerum rem saepe vel magni omnis blanditiis et.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9727),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        35,
                        6,
                        "Consequatur laborum suscipit assumenda sunt non iusto qui eligendi est.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9752),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        36,
                        14,
                        "Provident et cupiditate quod quod est nobis minima nihil.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9809),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        37,
                        7,
                        "Sed ut possimus beatae officia similique error.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9835),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        38,
                        13,
                        "Illo ut dolores animi ut quas quaerat laudantium rerum eum.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9857),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        39,
                        1,
                        "Iure blanditiis sit debitis unde dolor odio.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9883),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        40,
                        1,
                        "Non totam sed quibusdam autem alias accusamus praesentium repudiandae consequuntur.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9904),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        41,
                        16,
                        "Consequatur aut neque vitae doloribus.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 782, DateTimeKind.Utc).AddTicks(9928),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        42,
                        16,
                        "Quo non debitis ullam aut.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc),
                        false,
                        2,
                        null,
                        10,
                    },
                    {
                        43,
                        8,
                        "Nostrum quod hic molestias aut.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(17),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        44,
                        6,
                        "Sapiente et ut quia exercitationem eos dolor repellat quos.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(33),
                        false,
                        2,
                        null,
                        9,
                    },
                    {
                        45,
                        9,
                        "At ad nam architecto aut.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(58),
                        false,
                        2,
                        null,
                        10,
                    },
                    {
                        46,
                        1,
                        "Dolorem totam atque tenetur.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(74),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        47,
                        19,
                        "At magni rerum libero vel eaque.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(87),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        48,
                        1,
                        "Officiis commodi eligendi et commodi aut.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(104),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        49,
                        17,
                        "Fugit omnis quo consequatur eligendi ut neque dolore quis qui.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(121),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        50,
                        18,
                        "Ratione illo cum et culpa tempora recusandae quisquam.",
                        new DateTime(2024, 12, 9, 19, 34, 2, 783, DateTimeKind.Utc).AddTicks(144),
                        false,
                        5,
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
                        16,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4384),
                        false,
                        null,
                        2,
                    },
                    {
                        2,
                        12,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4544),
                        false,
                        null,
                        3,
                    },
                    {
                        3,
                        14,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4550),
                        false,
                        null,
                        9,
                    },
                    {
                        4,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4554),
                        false,
                        null,
                        7,
                    },
                    {
                        5,
                        14,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4557),
                        false,
                        null,
                        10,
                    },
                    {
                        6,
                        3,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4560),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4594),
                        false,
                        null,
                        2,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4599),
                        false,
                        null,
                        10,
                    },
                    {
                        9,
                        14,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4602),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4604),
                        false,
                        null,
                        6,
                    },
                    {
                        11,
                        13,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4607),
                        false,
                        null,
                        7,
                    },
                    {
                        12,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4610),
                        false,
                        null,
                        10,
                    },
                    {
                        13,
                        2,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4613),
                        false,
                        null,
                        2,
                    },
                    {
                        14,
                        13,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4616),
                        false,
                        null,
                        10,
                    },
                    {
                        15,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4619),
                        false,
                        null,
                        6,
                    },
                    {
                        16,
                        7,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4621),
                        false,
                        null,
                        10,
                    },
                    {
                        17,
                        8,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4624),
                        false,
                        null,
                        8,
                    },
                    {
                        18,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4627),
                        false,
                        null,
                        7,
                    },
                    {
                        19,
                        17,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4630),
                        false,
                        null,
                        10,
                    },
                    {
                        20,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4633),
                        false,
                        null,
                        3,
                    },
                    {
                        21,
                        4,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4636),
                        false,
                        null,
                        10,
                    },
                    {
                        22,
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4639),
                        false,
                        null,
                        3,
                    },
                    {
                        23,
                        18,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4642),
                        false,
                        null,
                        10,
                    },
                    {
                        24,
                        18,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4644),
                        false,
                        null,
                        10,
                    },
                    {
                        25,
                        5,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4647),
                        false,
                        null,
                        7,
                    },
                    {
                        26,
                        18,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4650),
                        false,
                        null,
                        10,
                    },
                    {
                        27,
                        11,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4653),
                        false,
                        null,
                        2,
                    },
                    {
                        28,
                        6,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4655),
                        false,
                        null,
                        10,
                    },
                    {
                        29,
                        9,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4658),
                        false,
                        null,
                        8,
                    },
                    {
                        30,
                        1,
                        new DateTime(2024, 12, 9, 19, 34, 2, 784, DateTimeKind.Utc).AddTicks(4661),
                        false,
                        null,
                        8,
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
