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
                name: "GiftCards",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PriceReduction = table.Column<decimal>(type: "numeric", nullable: false),
                    ValidFrom = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
                    ValidTo = table.Column<DateTime>(
                        type: "timestamp with time zone",
                        nullable: false
                    ),
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
                    table.PrimaryKey("PK_GiftCards", x => x.Id);
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
                    OrderState = table.Column<int>(type: "integer", nullable: false),
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
                name: "Coupons",
                columns: table => new
                {
                    Id = table
                        .Column<int>(type: "integer", nullable: false)
                        .Annotation(
                            "Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
                        ),
                    Code = table.Column<string>(type: "text", nullable: false),
                    GiftCardId = table.Column<int>(type: "integer", nullable: false),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    CartId = table.Column<int>(type: "integer", nullable: true),
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
                    table.PrimaryKey("PK_Coupons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coupons_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_Coupons_GiftCards_GiftCardId",
                        column: x => x.GiftCardId,
                        principalTable: "GiftCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_Coupons_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id"
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
                        "Kochburgh",
                        "Sierra Leone",
                        new DateTime(2024, 12, 31, 18, 51, 29, 735, DateTimeKind.Utc).AddTicks(
                            9506
                        ),
                        false,
                        "Arizona",
                        "74656 Gulgowski Valley",
                        null,
                        "64928",
                    },
                    {
                        2,
                        "Port Drakeland",
                        "Saint Vincent and the Grenadines",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(186),
                        false,
                        "Colorado",
                        "79954 Jayda Shoal",
                        null,
                        "97892",
                    },
                    {
                        3,
                        "East Stevieport",
                        "Palau",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(418),
                        false,
                        "Pennsylvania",
                        "6640 Ebony Springs",
                        null,
                        "50349",
                    },
                    {
                        4,
                        "Lindgrenside",
                        "Uganda",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(582),
                        false,
                        "Colorado",
                        "4329 Lebsack Ridges",
                        null,
                        "27557",
                    },
                    {
                        5,
                        "North Iciechester",
                        "Latvia",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(718),
                        false,
                        "Nebraska",
                        "42097 Greenholt Field",
                        null,
                        "84187",
                    },
                    {
                        6,
                        "East Royceland",
                        "Myanmar",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(868),
                        false,
                        "Washington",
                        "248 Isidro Courts",
                        null,
                        "51768",
                    },
                    {
                        7,
                        "Vladimirbury",
                        "Haiti",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1014
                        ),
                        false,
                        "New Hampshire",
                        "56838 Baron Port",
                        null,
                        "29814-2530",
                    },
                    {
                        8,
                        "West Jacques",
                        "Bahamas",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1184
                        ),
                        false,
                        "West Virginia",
                        "60633 West Highway",
                        null,
                        "07389",
                    },
                    {
                        9,
                        "East Bailey",
                        "Mozambique",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1336
                        ),
                        false,
                        "Pennsylvania",
                        "69304 Ruecker Island",
                        null,
                        "90139-0329",
                    },
                    {
                        10,
                        "Carleefort",
                        "Malaysia",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1452
                        ),
                        false,
                        "West Virginia",
                        "4052 Cassin Square",
                        null,
                        "02472",
                    },
                    {
                        11,
                        "West Zena",
                        "French Guiana",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1618
                        ),
                        false,
                        "Alabama",
                        "604 Jones Terrace",
                        null,
                        "17965",
                    },
                    {
                        12,
                        "Gutmannhaven",
                        "Guyana",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1769
                        ),
                        false,
                        "Wisconsin",
                        "030 Salvatore Curve",
                        null,
                        "18267-2160",
                    },
                    {
                        13,
                        "Mohrhaven",
                        "Dominica",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            1940
                        ),
                        false,
                        "Alabama",
                        "43056 Balistreri Ports",
                        null,
                        "14541-7161",
                    },
                    {
                        14,
                        "Wilberttown",
                        "Guinea",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            2073
                        ),
                        false,
                        "Washington",
                        "6834 Leopoldo Harbor",
                        null,
                        "70816-0795",
                    },
                    {
                        15,
                        "West Brisa",
                        "Papua New Guinea",
                        new DateTime(2024, 12, 31, 18, 51, 29, 736, DateTimeKind.Utc).AddTicks(
                            2204
                        ),
                        false,
                        "Oregon",
                        "78418 Regan Curve",
                        null,
                        "05741-1652",
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
                        "b54b442d-7000-449e-a4b8-9ba099564965",
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
                        "15c5d64b-d583-4c4e-ada9-030a6e3b762a",
                        false,
                        "admin@admin.com",
                    },
                    {
                        2,
                        0,
                        "a9c1f07b-ebcc-414f-8ffd-045400cd3f8b",
                        "Emelie.Feeney89@hotmail.com",
                        true,
                        false,
                        null,
                        "Austen Nader",
                        null,
                        null,
                        null,
                        "1-201-649-7323 x78071",
                        false,
                        "666ce78e-403c-4d26-97e1-cd4259bbce74",
                        false,
                        "Emelie.Feeney89@hotmail.com",
                    },
                    {
                        3,
                        0,
                        "2e3429b7-9905-4aba-a69f-65b8103f76c5",
                        "Norene.Greenholt@gmail.com",
                        true,
                        false,
                        null,
                        "Eveline Hickle",
                        null,
                        null,
                        null,
                        "(824) 657-5699",
                        false,
                        "fedbce84-b434-41ec-8933-286821843c93",
                        false,
                        "Norene.Greenholt@gmail.com",
                    },
                    {
                        4,
                        0,
                        "29b3dca6-3937-4fac-8578-be6eac803703",
                        "Opal12@yahoo.com",
                        true,
                        false,
                        null,
                        "Buck Runolfsson",
                        null,
                        null,
                        null,
                        "(899) 704-1635 x459",
                        false,
                        "4825c2c4-ce17-45aa-9dc9-1fa82d7b8e7e",
                        false,
                        "Opal12@yahoo.com",
                    },
                    {
                        5,
                        0,
                        "4f8416cc-778d-4fdf-834b-3a1fc4e864aa",
                        "Aniya15@gmail.com",
                        true,
                        false,
                        null,
                        "Eulah Beahan",
                        null,
                        null,
                        null,
                        "1-966-395-7825 x266",
                        false,
                        "62da3b64-b355-4c35-8ca2-57242cb13022",
                        false,
                        "Aniya15@gmail.com",
                    },
                    {
                        6,
                        0,
                        "b983229b-6d29-42a4-a984-bcbcce08539c",
                        "Kris74@gmail.com",
                        true,
                        false,
                        null,
                        "Alisa Mohr",
                        null,
                        null,
                        null,
                        "875.989.6538 x6187",
                        false,
                        "4b06c2fe-a14f-43b9-838f-db9a8416df8a",
                        false,
                        "Kris74@gmail.com",
                    },
                    {
                        7,
                        0,
                        "112691a3-d64a-41fd-92ec-c5d558e102de",
                        "Brennan.Cremin77@yahoo.com",
                        true,
                        false,
                        null,
                        "Eda Keebler",
                        null,
                        null,
                        null,
                        "321-741-9566 x928",
                        false,
                        "c10f1d71-40c5-4708-89c9-b5142b8926ae",
                        false,
                        "Brennan.Cremin77@yahoo.com",
                    },
                    {
                        8,
                        0,
                        "aca34e37-fabe-4d17-bb90-76bf208140b5",
                        "Brannon87@gmail.com",
                        true,
                        false,
                        null,
                        "Ava Stanton",
                        null,
                        null,
                        null,
                        "1-255-340-2201",
                        false,
                        "a5e6eb29-4d13-4696-ac5d-f84de7339f22",
                        false,
                        "Brannon87@gmail.com",
                    },
                    {
                        9,
                        0,
                        "6ac06bba-9986-4c1e-87ac-2041ce351c73",
                        "Jaylan_Nitzsche29@hotmail.com",
                        true,
                        false,
                        null,
                        "Gussie McKenzie",
                        null,
                        null,
                        null,
                        "210.877.4402 x802",
                        false,
                        "3356b421-e8f3-4503-a20a-22474b1abd9a",
                        false,
                        "Jaylan_Nitzsche29@hotmail.com",
                    },
                    {
                        10,
                        0,
                        "3faca217-e0c5-4cd0-b885-2dc9940f410a",
                        "Martine10@gmail.com",
                        true,
                        false,
                        null,
                        "Velva Hand",
                        null,
                        null,
                        null,
                        "(961) 476-3459 x0753",
                        false,
                        "819c97cb-f719-4298-ba65-ab51ffd23363",
                        false,
                        "Martine10@gmail.com",
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
                        "Magnam error magnam distinctio quae est repudiandae. Est distinctio ut id aliquam sit necessitatibus fugiat quia ipsum. Dolorem neque error est voluptas et.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            8496
                        ),
                        false,
                        "Athena Breitenberg",
                        null,
                    },
                    {
                        2,
                        "Aut quibusdam quo tempore et dolorum omnis est voluptatem vitae. Exercitationem veritatis voluptatem unde inventore. Unde dolorum fuga qui et labore fuga mollitia adipisci excepturi.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            8867
                        ),
                        false,
                        "Glennie Terry",
                        null,
                    },
                    {
                        3,
                        "Facilis in similique quasi perspiciatis officia et possimus. Consequuntur voluptas ea et. Amet autem voluptates doloremque voluptates. Facere nostrum neque minus asperiores velit dolor laboriosam ducimus explicabo.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9011
                        ),
                        false,
                        "Kali Herzog",
                        null,
                    },
                    {
                        4,
                        "Ut at temporibus. Eum maxime facere. Et molestias eveniet incidunt nisi esse aut ut ab. Qui ea voluptas nihil incidunt perferendis saepe dolor labore.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9130
                        ),
                        false,
                        "Colton Durgan",
                        null,
                    },
                    {
                        5,
                        "Atque architecto aut voluptatem neque aut. Sint quaerat aspernatur omnis explicabo. Ea id nesciunt debitis. Dolorem cumque qui atque dolores. Harum doloremque dolores voluptatum eligendi tempora amet.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9254
                        ),
                        false,
                        "Shana Bode",
                        null,
                    },
                    {
                        6,
                        "Culpa et non maxime vel eum. Qui repellendus non dolores eligendi tenetur laborum et. Odio natus dolorem enim numquam ex aut.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9350
                        ),
                        false,
                        "Kiley Paucek",
                        null,
                    },
                    {
                        7,
                        "Earum libero omnis animi repudiandae. Id mollitia alias rerum ad ratione dicta. Nostrum consequuntur non rerum consequatur aut ut.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9457
                        ),
                        false,
                        "Boris Schaden",
                        null,
                    },
                    {
                        8,
                        "Voluptatum quia quaerat error voluptatem deserunt quia sed. Corrupti quia excepturi necessitatibus quis reiciendis culpa. Voluptatem optio illo sint. Libero pariatur aut dolorem nemo excepturi. Sunt id aut ut doloremque necessitatibus.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9523
                        ),
                        false,
                        "Murl Lind",
                        null,
                    },
                    {
                        9,
                        "Minus repudiandae unde ad magni sunt corporis earum ratione rerum. Quos culpa magnam minima dolor. Cum aut et quo iste inventore. Voluptas explicabo voluptas. Velit sint repellendus. Repellat fugit in quia.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9636
                        ),
                        false,
                        "Jovani Lynch",
                        null,
                    },
                    {
                        10,
                        "Neque illo non quibusdam vel quidem. Cum rem molestias ut blanditiis temporibus deleniti sunt. Voluptatibus voluptatem unde nemo odio distinctio totam error odit. Magni non accusantium provident et aut hic totam. Et est deleniti.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 726, DateTimeKind.Utc).AddTicks(
                            9739
                        ),
                        false,
                        "Nolan Heidenreich",
                        null,
                    },
                }
            );

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
                    { 7, "Historical Fiction" },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Bio", "CreatedDate", "IsDeleted", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    {
                        1,
                        "Neque ut ad exercitationem consectetur. Quidem ea quaerat velit perferendis sed voluptates. Rerum ut eveniet. Earum eum rem enim. Earum ipsam eos consectetur. Sequi natus id aut eum fuga sed consequatur.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 728, DateTimeKind.Utc).AddTicks(
                            7545
                        ),
                        false,
                        "Leannon, Walker and McKenzie",
                        null,
                    },
                    {
                        2,
                        "Quasi tempora iusto rerum suscipit iste dolores nisi. Nihil qui nisi eveniet illum. Est nam non ab. Est est voluptatem qui odit. Et sunt explicabo id quia perspiciatis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 728, DateTimeKind.Utc).AddTicks(
                            8469
                        ),
                        false,
                        "Berge - Streich",
                        null,
                    },
                    {
                        3,
                        "Magni nemo veritatis corporis voluptatem consequatur est animi eveniet alias. Ipsa exercitationem aliquam ea vero alias quas culpa eum vel. Cum consequatur qui.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 728, DateTimeKind.Utc).AddTicks(
                            8753
                        ),
                        false,
                        "Bernhard and Sons",
                        null,
                    },
                    {
                        4,
                        "Saepe ea numquam. Quo aut dolorum. Reiciendis quod alias non qui et earum. Quisquam iure beatae. Dolorum dolores et eligendi. Voluptas cum dolorem debitis architecto quia corrupti.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 728, DateTimeKind.Utc).AddTicks(
                            9018
                        ),
                        false,
                        "Hills Inc",
                        null,
                    },
                    {
                        5,
                        "Eos ipsum est dolorem qui voluptates dolores veniam id. Ut dolorum dolores. Voluptates est dignissimos nulla. Assumenda excepturi vero expedita cumque perferendis dolore hic dolorum. Iure aspernatur rem ea.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 728, DateTimeKind.Utc).AddTicks(
                            9191
                        ),
                        false,
                        "Bode - Beahan",
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
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            6202
                        ),
                        "Vitae porro consequatur. Officiis veniam excepturi dolor. Similique iste consequatur tempora. Facilis eaque enim libero consequatur ut.",
                        0,
                        "/images/cover-7.jpg",
                        false,
                        null,
                        84.31m,
                        4,
                        5,
                        "Hic molestias fugiat.",
                        null,
                    },
                    {
                        2,
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            8475
                        ),
                        "Porro quos ab aut est fuga assumenda. Fuga eaque nisi nihil ut ipsum et quia architecto facilis. In adipisci eaque aut exercitationem et pariatur autem quae voluptate. Delectus distinctio sit expedita possimus officiis necessitatibus molestias dolorem et.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        81.50m,
                        4,
                        5,
                        "Quo sequi saepe.",
                        null,
                    },
                    {
                        3,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            8741
                        ),
                        "Impedit corporis vel dolor nemo iure numquam sunt reiciendis. Aliquid eos qui voluptas recusandae. Possimus optio aut ut quam libero dolores atque. Vero tempore quo qui qui aliquam. Praesentium vel sequi numquam hic corporis illo beatae. Vero non ut commodi impedit expedita officiis sapiente.",
                        0,
                        "/images/cover-3.jpg",
                        false,
                        null,
                        87.92m,
                        1,
                        5,
                        "Non aut dolore.",
                        null,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            8935
                        ),
                        "Officiis qui eius. Aperiam ducimus perspiciatis ea corrupti neque veritatis aut aperiam. Fugiat voluptatem veniam aut eum ut. Dolorem cum consequuntur laudantium reiciendis soluta iure.",
                        0,
                        "/images/cover-1.jpg",
                        false,
                        null,
                        36.88m,
                        2,
                        3,
                        "Aut quod quasi.",
                        null,
                    },
                    {
                        5,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9037
                        ),
                        "Id explicabo est magni numquam sed id eius. In ut et reprehenderit exercitationem cum et perferendis. Consequatur dolor cupiditate et deleniti.",
                        0,
                        "/images/cover-4.jpg",
                        false,
                        null,
                        74.73m,
                        2,
                        3,
                        "Omnis harum maxime.",
                        null,
                    },
                    {
                        6,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9149
                        ),
                        "Velit fuga vel voluptate doloremque. Modi ut non harum consequatur omnis. Nisi ut eos voluptatum nihil quam vitae. Quia quia est amet doloremque dolore quia ut.",
                        0,
                        "/images/cover-8.jpg",
                        false,
                        null,
                        75.46m,
                        7,
                        4,
                        "Saepe modi ab.",
                        null,
                    },
                    {
                        7,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9237
                        ),
                        "Eos quos accusantium et. Ab quidem modi animi quia voluptates eligendi. Adipisci voluptatem sit sed. Pariatur dolorem natus fuga.",
                        0,
                        "/images/cover-4.jpg",
                        false,
                        null,
                        67.10m,
                        5,
                        5,
                        "Enim id voluptas.",
                        null,
                    },
                    {
                        8,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9344
                        ),
                        "Sapiente quia est reprehenderit nostrum maxime esse dolores. Aliquam accusantium quia ipsam recusandae. Nostrum ratione est sed eum. Beatae eaque aperiam aut non et hic qui nesciunt incidunt. Molestias numquam ut velit accusantium aliquam.",
                        0,
                        "/images/cover-4.jpg",
                        false,
                        null,
                        51.27m,
                        5,
                        3,
                        "Nisi aut temporibus.",
                        null,
                    },
                    {
                        9,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9451
                        ),
                        "Incidunt ea aliquid commodi et est doloremque. Qui sit suscipit minus rerum totam dolore enim non doloremque. Ipsa dolores facere aliquam non minima sit dolor. Enim sit modi delectus. Asperiores et veniam velit reiciendis exercitationem sed.",
                        0,
                        "/images/cover-3.jpg",
                        false,
                        null,
                        24.44m,
                        6,
                        2,
                        "Saepe saepe provident.",
                        null,
                    },
                    {
                        10,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9595
                        ),
                        "Natus ut natus recusandae similique excepturi dolor non itaque ullam. Suscipit qui in. Necessitatibus et quia. Laboriosam dolor et repellendus ratione enim eaque libero et et.",
                        0,
                        "/images/cover-4.jpg",
                        false,
                        null,
                        17.64m,
                        7,
                        2,
                        "Dicta dolorem et.",
                        null,
                    },
                    {
                        11,
                        3,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9707
                        ),
                        "Voluptatem et adipisci deleniti. Et a ratione molestias. Est dolorem qui quaerat animi autem dolores laborum.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        20.28m,
                        6,
                        2,
                        "Voluptatibus quisquam minima.",
                        null,
                    },
                    {
                        12,
                        7,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9773
                        ),
                        "Ullam ea et quam dignissimos tempore. Iusto nihil non est corporis cum minima ut velit aliquid. Numquam distinctio debitis.",
                        0,
                        "/images/cover-8.jpg",
                        false,
                        null,
                        98.40m,
                        5,
                        3,
                        "Velit quaerat architecto.",
                        null,
                    },
                    {
                        13,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9861
                        ),
                        "Ab reprehenderit mollitia et sed. Id ipsa aspernatur consectetur voluptate laborum voluptate omnis. Ratione sint eos. Sapiente atque rem cupiditate officiis voluptatem consequatur dolor iure dignissimos.",
                        0,
                        "/images/cover-9.jpg",
                        false,
                        null,
                        42.25m,
                        5,
                        4,
                        "Magni non dolor.",
                        null,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 730, DateTimeKind.Utc).AddTicks(
                            9945
                        ),
                        "Molestiae aspernatur assumenda voluptas ipsum iusto molestiae. Ut illo unde ut sapiente id. Qui ad vel id corporis in. Quaerat magni ab quia cum explicabo doloribus ut et.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        44.85m,
                        6,
                        2,
                        "Excepturi sunt delectus.",
                        null,
                    },
                    {
                        15,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 731, DateTimeKind.Utc).AddTicks(109),
                        "Et et et rem atque. Eum et minus ut quia quia officiis molestiae suscipit eum. Rerum ea eum aut alias delectus quia.",
                        0,
                        "/images/cover-1.jpg",
                        false,
                        null,
                        48.12m,
                        5,
                        4,
                        "Voluptatem ipsum et.",
                        null,
                    },
                    {
                        16,
                        10,
                        new DateTime(2024, 12, 31, 18, 51, 29, 731, DateTimeKind.Utc).AddTicks(176),
                        "Blanditiis aut ab aut minima velit perspiciatis reiciendis. Amet quo ut. Nihil eum tempore dolorum cupiditate placeat ad nostrum.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        12.48m,
                        5,
                        5,
                        "Consequuntur placeat minus.",
                        null,
                    },
                    {
                        17,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 731, DateTimeKind.Utc).AddTicks(281),
                        "Rem neque nesciunt qui sunt ducimus error dolorem consectetur. Unde voluptates in ipsam vel. Rerum eos quisquam. Ipsum nihil molestiae reiciendis.",
                        0,
                        "/images/cover-5.jpg",
                        false,
                        null,
                        85.40m,
                        5,
                        3,
                        "Quae inventore quod.",
                        null,
                    },
                    {
                        18,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 731, DateTimeKind.Utc).AddTicks(351),
                        "Quo nihil temporibus quis aut velit animi. Dolorem et soluta ipsa. Blanditiis totam sequi est sint. Aut cum totam quibusdam. Rem officia debitis provident repudiandae a at. Quos sequi labore animi at consectetur eius.",
                        0,
                        "/images/cover-5.jpg",
                        false,
                        null,
                        21.27m,
                        3,
                        5,
                        "Commodi dolorum fugit.",
                        null,
                    },
                    {
                        19,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 731, DateTimeKind.Utc).AddTicks(484),
                        "Provident voluptatem sit ab enim neque occaecati facere possimus repudiandae. Fugiat explicabo sint alias odio inventore. Dolores ea sunt atque quaerat ea veniam ut reiciendis perferendis. Aut pariatur molestiae.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        71.38m,
                        1,
                        3,
                        "Temporibus dolorem accusamus.",
                        null,
                    },
                    {
                        20,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 731, DateTimeKind.Utc).AddTicks(594),
                        "Quibusdam ratione reiciendis. Vero omnis ad suscipit in odio numquam fuga omnis nostrum. Repellat qui quae ipsam totam ut. Quae quas rem culpa ad ea perferendis et. Perspiciatis laborum inventore aut dolorum maiores rem nostrum corrupti.",
                        0,
                        "/images/cover-2.jpg",
                        false,
                        null,
                        40.28m,
                        6,
                        1,
                        "Consequatur qui illum.",
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
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7406
                        ),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7408
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7409
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7409
                        ),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7409
                        ),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7410
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7410
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7410
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7411
                        ),
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
                    "OrderState",
                    "ShippingAddressId",
                    "TotalAmount",
                    "UpdatedDate",
                    "UserId",
                },
                values: new object[,]
                {
                    {
                        1,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 737, DateTimeKind.Utc).AddTicks(
                            7587
                        ),
                        "Jordan.Grant@yahoo.com",
                        "Jordan Grant",
                        false,
                        1,
                        5,
                        0m,
                        null,
                        7,
                    },
                    {
                        2,
                        7,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            1244
                        ),
                        "Diana_Halvorson@gmail.com",
                        "Diana Halvorson",
                        false,
                        0,
                        15,
                        0m,
                        null,
                        10,
                    },
                    {
                        3,
                        14,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            2476
                        ),
                        "Ruben.Paucek@hotmail.com",
                        "Ruben Paucek",
                        false,
                        3,
                        3,
                        0m,
                        null,
                        7,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            3029
                        ),
                        "Lynda32@yahoo.com",
                        "Lynda Ryan",
                        false,
                        4,
                        11,
                        0m,
                        null,
                        5,
                    },
                    {
                        5,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            3709
                        ),
                        "Darrin_Stokes@gmail.com",
                        "Darrin Stokes",
                        false,
                        2,
                        5,
                        0m,
                        null,
                        6,
                    },
                    {
                        6,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            4244
                        ),
                        "Josephine_Hirthe5@yahoo.com",
                        "Josephine Hirthe",
                        false,
                        5,
                        13,
                        0m,
                        null,
                        3,
                    },
                    {
                        7,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            4746
                        ),
                        "Jaime.Steuber@hotmail.com",
                        "Jaime Steuber",
                        false,
                        2,
                        5,
                        0m,
                        null,
                        10,
                    },
                    {
                        8,
                        13,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            5437
                        ),
                        "Ginger_Mayer@gmail.com",
                        "Ginger Mayer",
                        false,
                        3,
                        1,
                        0m,
                        null,
                        6,
                    },
                    {
                        9,
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            6080
                        ),
                        "Julian41@yahoo.com",
                        "Julian Bahringer",
                        false,
                        0,
                        8,
                        0m,
                        null,
                        8,
                    },
                    {
                        10,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            6723
                        ),
                        "Walter97@gmail.com",
                        "Walter Pouros",
                        false,
                        0,
                        12,
                        0m,
                        null,
                        2,
                    },
                    {
                        11,
                        8,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            7249
                        ),
                        "Latoya.Ondricka@yahoo.com",
                        "Latoya Ondricka",
                        false,
                        0,
                        10,
                        0m,
                        null,
                        7,
                    },
                    {
                        12,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            7736
                        ),
                        "Ignacio_Kautzer@gmail.com",
                        "Ignacio Kautzer",
                        false,
                        0,
                        7,
                        0m,
                        null,
                        10,
                    },
                    {
                        13,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            8287
                        ),
                        "Eula8@gmail.com",
                        "Eula Fritsch",
                        false,
                        5,
                        9,
                        0m,
                        null,
                        10,
                    },
                    {
                        14,
                        10,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            8814
                        ),
                        "Fredrick_McLaughlin71@hotmail.com",
                        "Fredrick McLaughlin",
                        false,
                        1,
                        5,
                        0m,
                        null,
                        3,
                    },
                    {
                        15,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 738, DateTimeKind.Utc).AddTicks(
                            9354
                        ),
                        "Sammy_Barton30@yahoo.com",
                        "Sammy Barton",
                        false,
                        3,
                        6,
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
                        13,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            4952
                        ),
                        false,
                        13,
                        84.95m,
                        2,
                        null,
                    },
                    {
                        2,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6665
                        ),
                        false,
                        2,
                        90.15m,
                        1,
                        null,
                    },
                    {
                        3,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6718
                        ),
                        false,
                        3,
                        17.82m,
                        3,
                        null,
                    },
                    {
                        4,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6731
                        ),
                        false,
                        12,
                        28.70m,
                        1,
                        null,
                    },
                    {
                        5,
                        18,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6740
                        ),
                        false,
                        2,
                        79.42m,
                        2,
                        null,
                    },
                    {
                        6,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6749
                        ),
                        false,
                        8,
                        54.61m,
                        1,
                        null,
                    },
                    {
                        7,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6757
                        ),
                        false,
                        15,
                        52.64m,
                        3,
                        null,
                    },
                    {
                        8,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6764
                        ),
                        false,
                        15,
                        50.72m,
                        1,
                        null,
                    },
                    {
                        9,
                        12,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6772
                        ),
                        false,
                        1,
                        30.47m,
                        1,
                        null,
                    },
                    {
                        10,
                        14,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6849
                        ),
                        false,
                        5,
                        24.43m,
                        2,
                        null,
                    },
                    {
                        11,
                        13,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6858
                        ),
                        false,
                        9,
                        20.20m,
                        1,
                        null,
                    },
                    {
                        12,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6867
                        ),
                        false,
                        4,
                        71.51m,
                        2,
                        null,
                    },
                    {
                        13,
                        20,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6875
                        ),
                        false,
                        11,
                        29.20m,
                        1,
                        null,
                    },
                    {
                        14,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6883
                        ),
                        false,
                        7,
                        21.35m,
                        3,
                        null,
                    },
                    {
                        15,
                        18,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6890
                        ),
                        false,
                        7,
                        87.45m,
                        2,
                        null,
                    },
                    {
                        16,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6897
                        ),
                        false,
                        3,
                        99.76m,
                        1,
                        null,
                    },
                    {
                        17,
                        19,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6905
                        ),
                        false,
                        11,
                        23.05m,
                        3,
                        null,
                    },
                    {
                        18,
                        16,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6914
                        ),
                        false,
                        8,
                        90.28m,
                        3,
                        null,
                    },
                    {
                        19,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6921
                        ),
                        false,
                        3,
                        26.38m,
                        3,
                        null,
                    },
                    {
                        20,
                        3,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6929
                        ),
                        false,
                        1,
                        53.20m,
                        3,
                        null,
                    },
                    {
                        21,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6937
                        ),
                        false,
                        4,
                        89.96m,
                        2,
                        null,
                    },
                    {
                        22,
                        12,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6945
                        ),
                        false,
                        12,
                        25.17m,
                        3,
                        null,
                    },
                    {
                        23,
                        13,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6952
                        ),
                        false,
                        10,
                        90.15m,
                        3,
                        null,
                    },
                    {
                        24,
                        7,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6961
                        ),
                        false,
                        13,
                        83.76m,
                        2,
                        null,
                    },
                    {
                        25,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6968
                        ),
                        false,
                        7,
                        76.37m,
                        3,
                        null,
                    },
                    {
                        26,
                        12,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6976
                        ),
                        false,
                        9,
                        36.32m,
                        3,
                        null,
                    },
                    {
                        27,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6983
                        ),
                        false,
                        13,
                        11.62m,
                        2,
                        null,
                    },
                    {
                        28,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6991
                        ),
                        false,
                        5,
                        73.04m,
                        3,
                        null,
                    },
                    {
                        29,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            6999
                        ),
                        false,
                        14,
                        37.58m,
                        2,
                        null,
                    },
                    {
                        30,
                        19,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7006
                        ),
                        false,
                        2,
                        11.39m,
                        1,
                        null,
                    },
                    {
                        31,
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7014
                        ),
                        false,
                        4,
                        10.18m,
                        1,
                        null,
                    },
                    {
                        32,
                        3,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7022
                        ),
                        false,
                        14,
                        40.49m,
                        1,
                        null,
                    },
                    {
                        33,
                        8,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7030
                        ),
                        false,
                        14,
                        76.11m,
                        3,
                        null,
                    },
                    {
                        34,
                        19,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7037
                        ),
                        false,
                        9,
                        15.95m,
                        2,
                        null,
                    },
                    {
                        35,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7045
                        ),
                        false,
                        9,
                        17.88m,
                        2,
                        null,
                    },
                    {
                        36,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7052
                        ),
                        false,
                        8,
                        30.21m,
                        3,
                        null,
                    },
                    {
                        37,
                        17,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7060
                        ),
                        false,
                        1,
                        27.37m,
                        2,
                        null,
                    },
                    {
                        38,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7068
                        ),
                        false,
                        8,
                        19.08m,
                        1,
                        null,
                    },
                    {
                        39,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7076
                        ),
                        false,
                        7,
                        14.37m,
                        3,
                        null,
                    },
                    {
                        40,
                        16,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7083
                        ),
                        false,
                        11,
                        34.33m,
                        1,
                        null,
                    },
                    {
                        41,
                        2,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7091
                        ),
                        false,
                        14,
                        53.26m,
                        3,
                        null,
                    },
                    {
                        42,
                        10,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7144
                        ),
                        false,
                        12,
                        11.65m,
                        3,
                        null,
                    },
                    {
                        43,
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7153
                        ),
                        false,
                        6,
                        91.58m,
                        1,
                        null,
                    },
                    {
                        44,
                        12,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7160
                        ),
                        false,
                        10,
                        11.62m,
                        3,
                        null,
                    },
                    {
                        45,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7168
                        ),
                        false,
                        2,
                        78.69m,
                        2,
                        null,
                    },
                    {
                        46,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7175
                        ),
                        false,
                        13,
                        47.39m,
                        3,
                        null,
                    },
                    {
                        47,
                        5,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7183
                        ),
                        false,
                        1,
                        14.04m,
                        3,
                        null,
                    },
                    {
                        48,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7190
                        ),
                        false,
                        9,
                        96.86m,
                        1,
                        null,
                    },
                    {
                        49,
                        14,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7198
                        ),
                        false,
                        5,
                        83.60m,
                        1,
                        null,
                    },
                    {
                        50,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 740, DateTimeKind.Utc).AddTicks(
                            7206
                        ),
                        false,
                        14,
                        42.61m,
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
                        14,
                        "Aperiam voluptatem odit error quas exercitationem.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            6139
                        ),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        2,
                        1,
                        "Ratione qui quidem asperiores rerum et officiis dolorum eveniet asperiores.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            7690
                        ),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        3,
                        20,
                        "Facilis dolores inventore placeat in qui asperiores ipsum at.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            7777
                        ),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        4,
                        9,
                        "Ad vel veniam quasi.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            7816
                        ),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        5,
                        10,
                        "Magni non esse veritatis id sed earum itaque est qui.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            7968
                        ),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        6,
                        11,
                        "Quidem minus ea quasi animi voluptatum iste.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8005
                        ),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        7,
                        7,
                        "Quo commodi quis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8032
                        ),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        8,
                        20,
                        "Laborum atque quaerat omnis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8049
                        ),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        9,
                        10,
                        "Accusamus unde rerum nesciunt impedit.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8068
                        ),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        10,
                        4,
                        "Aut quidem eos nostrum ea.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8091
                        ),
                        false,
                        2,
                        null,
                        10,
                    },
                    {
                        11,
                        4,
                        "Hic ex qui alias repudiandae molestias optio sit recusandae labore.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8112
                        ),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        12,
                        14,
                        "Error quia perferendis laborum distinctio officia inventore voluptatem.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8146
                        ),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        13,
                        18,
                        "Omnis corrupti neque tenetur aspernatur.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8221
                        ),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        14,
                        18,
                        "Vero id molestias officiis quia voluptatem pariatur in modi.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8242
                        ),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        15,
                        7,
                        "Quia in vero dolorem dolorem qui.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8273
                        ),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        16,
                        3,
                        "Et voluptates quae unde minima iusto quo.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8294
                        ),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        17,
                        9,
                        "Nobis omnis quasi quidem ipsam est quaerat.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8320
                        ),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        18,
                        12,
                        "Est quia vel et officia eos magni aspernatur perspiciatis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8345
                        ),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        19,
                        17,
                        "Voluptatibus quia dicta pariatur dolore sit.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8374
                        ),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        20,
                        3,
                        "Non nostrum distinctio.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8396
                        ),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        21,
                        9,
                        "Placeat alias cumque eum perferendis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8442
                        ),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        22,
                        18,
                        "Soluta sed eius aut qui ab nihil.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8462
                        ),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        23,
                        11,
                        "Hic ut laborum maxime impedit non.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8487
                        ),
                        false,
                        5,
                        null,
                        4,
                    },
                    {
                        24,
                        5,
                        "Rerum esse modi pariatur est et numquam perspiciatis ut excepturi.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8506
                        ),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        25,
                        1,
                        "Consectetur consectetur quidem ea voluptas officiis molestias porro.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8533
                        ),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        26,
                        8,
                        "Velit porro fugiat voluptatem ut rerum.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8557
                        ),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        27,
                        3,
                        "Atque sapiente ullam totam et.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8577
                        ),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        28,
                        6,
                        "Sint tenetur fuga non omnis sequi hic eum excepturi deleniti.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8596
                        ),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        29,
                        3,
                        "Aliquam possimus dignissimos animi nisi.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8655
                        ),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        30,
                        6,
                        "Officiis doloribus dolore.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8679
                        ),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        31,
                        7,
                        "Amet voluptatem quia optio alias enim.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8695
                        ),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        32,
                        4,
                        "Aut ut expedita ut mollitia cumque accusantium dolores nihil.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8714
                        ),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        33,
                        15,
                        "Officia voluptas at blanditiis sint corporis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8740
                        ),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        34,
                        11,
                        "Aut impedit velit.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8762
                        ),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        35,
                        20,
                        "Quod laboriosam molestiae.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8776
                        ),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        36,
                        9,
                        "Vel accusantium et dolores aut.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8794
                        ),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        37,
                        10,
                        "Quidem ut quis voluptatum aut recusandae aut maiores.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8811
                        ),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        38,
                        11,
                        "Accusamus dignissimos explicabo.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8866
                        ),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        39,
                        2,
                        "Reiciendis aut amet saepe laboriosam sint.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8879
                        ),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        40,
                        8,
                        "Enim iure dolorem fugiat eveniet doloribus maxime voluptatem illo.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8901
                        ),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        41,
                        17,
                        "Eligendi ut quia necessitatibus inventore impedit quis blanditiis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8924
                        ),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        42,
                        17,
                        "Cumque maxime voluptatibus minus error ipsam voluptatem et sequi aut.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8950
                        ),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        43,
                        17,
                        "Numquam nihil rerum officiis.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8972
                        ),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        44,
                        15,
                        "Culpa similique dolore ex eius veniam iure.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            8990
                        ),
                        false,
                        3,
                        null,
                        2,
                    },
                    {
                        45,
                        10,
                        "Mollitia asperiores fuga.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            9043
                        ),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        46,
                        18,
                        "Consequatur rerum veniam deleniti qui enim.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            9057
                        ),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        47,
                        7,
                        "Rem eum nihil ut.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            9077
                        ),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        48,
                        9,
                        "Consequatur est iste aut ex aliquam.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            9090
                        ),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        49,
                        3,
                        "Necessitatibus autem atque.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            9109
                        ),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        50,
                        4,
                        "Odio veritatis eaque porro officia architecto.",
                        new DateTime(2024, 12, 31, 18, 51, 29, 732, DateTimeKind.Utc).AddTicks(
                            9123
                        ),
                        false,
                        1,
                        null,
                        7,
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
                        10,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3630
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        2,
                        12,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3781
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        3,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3786
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        14,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3790
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        5,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3793
                        ),
                        false,
                        null,
                        2,
                    },
                    {
                        6,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3796
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        7,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3799
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3802
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        9,
                        9,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3805
                        ),
                        false,
                        null,
                        2,
                    },
                    {
                        10,
                        3,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3808
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        11,
                        14,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3811
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        12,
                        20,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3835
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        13,
                        19,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3839
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        14,
                        10,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3841
                        ),
                        false,
                        null,
                        6,
                    },
                    {
                        15,
                        18,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3844
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        16,
                        13,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3847
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        17,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3850
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        18,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3853
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        19,
                        18,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3856
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        20,
                        20,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3859
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        21,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3861
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        22,
                        1,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3864
                        ),
                        false,
                        null,
                        6,
                    },
                    {
                        23,
                        6,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3867
                        ),
                        false,
                        null,
                        5,
                    },
                    {
                        24,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3870
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        25,
                        11,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3873
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        26,
                        16,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3876
                        ),
                        false,
                        null,
                        6,
                    },
                    {
                        27,
                        18,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3879
                        ),
                        false,
                        null,
                        5,
                    },
                    {
                        28,
                        15,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3881
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        29,
                        17,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3884
                        ),
                        false,
                        null,
                        6,
                    },
                    {
                        30,
                        3,
                        new DateTime(2024, 12, 31, 18, 51, 29, 734, DateTimeKind.Utc).AddTicks(
                            3887
                        ),
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
                name: "IX_Coupons_CartId",
                table: "Coupons",
                column: "CartId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_GiftCardId",
                table: "Coupons",
                column: "GiftCardId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_OrderId",
                table: "Coupons",
                column: "OrderId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_GiftCards_Name",
                table: "GiftCards",
                column: "Name",
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

            migrationBuilder.DropTable(name: "Coupons");

            migrationBuilder.DropTable(name: "OrderItems");

            migrationBuilder.DropTable(name: "Reviews");

            migrationBuilder.DropTable(name: "WishlistItems");

            migrationBuilder.DropTable(name: "AspNetRoles");

            migrationBuilder.DropTable(name: "Carts");

            migrationBuilder.DropTable(name: "GiftCards");

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
