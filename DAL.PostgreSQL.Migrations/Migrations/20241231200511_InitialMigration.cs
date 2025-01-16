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
                        "Reillyville",
                        "Montenegro",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(1837),
                        false,
                        "Kentucky",
                        "3830 Altenwerth Cliffs",
                        null,
                        "48046-5234",
                    },
                    {
                        2,
                        "Port Fayville",
                        "Belize",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(2401),
                        false,
                        "Wyoming",
                        "551 Lehner Union",
                        null,
                        "51471-9200",
                    },
                    {
                        3,
                        "East Hulda",
                        "Cameroon",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(2538),
                        false,
                        "Minnesota",
                        "954 Keanu Extension",
                        null,
                        "44782-2772",
                    },
                    {
                        4,
                        "South Jazmyn",
                        "Guernsey",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(2720),
                        false,
                        "Wyoming",
                        "48554 Jeremy Ferry",
                        null,
                        "00882-5335",
                    },
                    {
                        5,
                        "Port Marjorie",
                        "Ukraine",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(2856),
                        false,
                        "Hawaii",
                        "199 Lisandro Shore",
                        null,
                        "94889-2246",
                    },
                    {
                        6,
                        "Adrainville",
                        "Philippines",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(2983),
                        false,
                        "Massachusetts",
                        "186 Helene Tunnel",
                        null,
                        "06021-1266",
                    },
                    {
                        7,
                        "West Lydiaton",
                        "Georgia",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3109),
                        false,
                        "New York",
                        "953 McCullough Gardens",
                        null,
                        "38250",
                    },
                    {
                        8,
                        "Port Kylaburgh",
                        "Samoa",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3289),
                        false,
                        "Louisiana",
                        "923 Weissnat Mission",
                        null,
                        "63772",
                    },
                    {
                        9,
                        "Terryview",
                        "Bosnia and Herzegovina",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3433),
                        false,
                        "North Dakota",
                        "5624 Shanelle Rapids",
                        null,
                        "52326-5940",
                    },
                    {
                        10,
                        "South Blairshire",
                        "Panama",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3555),
                        false,
                        "Hawaii",
                        "313 Torp Spurs",
                        null,
                        "47668",
                    },
                    {
                        11,
                        "Nolanchester",
                        "Oman",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3656),
                        false,
                        "Pennsylvania",
                        "12007 Judy Ferry",
                        null,
                        "35494",
                    },
                    {
                        12,
                        "Port Rosaliabury",
                        "Greenland",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3838),
                        false,
                        "Kansas",
                        "7144 Mayer Branch",
                        null,
                        "93709",
                    },
                    {
                        13,
                        "Lincolntown",
                        "Nicaragua",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(3991),
                        false,
                        "Nevada",
                        "60544 Dillan Shores",
                        null,
                        "22298",
                    },
                    {
                        14,
                        "Cristalville",
                        "Peru",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(4112),
                        false,
                        "Oregon",
                        "65327 Swift Way",
                        null,
                        "43062",
                    },
                    {
                        15,
                        "Lake Ernestinaland",
                        "Falkland Islands (Malvinas)",
                        new DateTime(2024, 12, 31, 20, 5, 10, 680, DateTimeKind.Utc).AddTicks(4244),
                        false,
                        "Florida",
                        "92384 Lauriane Branch",
                        null,
                        "99470",
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
                        "6db05e06-8981-4295-8ab8-170abc846259",
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
                        "1b25885b-b021-43e6-b82c-656d9edb3ed9",
                        false,
                        "admin@admin.com",
                    },
                    {
                        2,
                        0,
                        "5a28b120-68d1-4d5d-be1d-df523f0ab997",
                        "Isabel.King0@gmail.com",
                        true,
                        false,
                        null,
                        "Josefina Veum",
                        null,
                        null,
                        null,
                        "(873) 441-8515 x558",
                        false,
                        "4695dd78-a3ab-4d3e-a151-b78e8bb6ab87",
                        false,
                        "Isabel.King0@gmail.com",
                    },
                    {
                        3,
                        0,
                        "e8c3dec3-fd3a-4c97-8a5f-e63c322d4161",
                        "Elody.Renner82@yahoo.com",
                        true,
                        false,
                        null,
                        "Stephanie O'Hara",
                        null,
                        null,
                        null,
                        "556.941.1701 x72829",
                        false,
                        "78c6364f-84ff-47b3-9663-31db4b3c40f8",
                        false,
                        "Elody.Renner82@yahoo.com",
                    },
                    {
                        4,
                        0,
                        "31b6cdbf-80b7-4d84-8d63-b78e4fe3699e",
                        "Will_Tillman@gmail.com",
                        true,
                        false,
                        null,
                        "Monique Jenkins",
                        null,
                        null,
                        null,
                        "231.308.7043",
                        false,
                        "c35d7880-bfbf-4e16-86aa-a4ef2f0b497d",
                        false,
                        "Will_Tillman@gmail.com",
                    },
                    {
                        5,
                        0,
                        "17574df5-93af-4bfa-8b4a-fd7815617760",
                        "Lauriane.Brown@hotmail.com",
                        true,
                        false,
                        null,
                        "Janick Casper",
                        null,
                        null,
                        null,
                        "737.424.3836 x20800",
                        false,
                        "2b7d1c1e-1cfb-4141-b45d-59086027c96d",
                        false,
                        "Lauriane.Brown@hotmail.com",
                    },
                    {
                        6,
                        0,
                        "b2274625-a08d-421a-beeb-40d5020a5a38",
                        "Kamron.Kovacek50@gmail.com",
                        true,
                        false,
                        null,
                        "Nayeli Bartell",
                        null,
                        null,
                        null,
                        "665.394.5736 x230",
                        false,
                        "ac2cb385-3327-4710-a529-0a124f7da443",
                        false,
                        "Kamron.Kovacek50@gmail.com",
                    },
                    {
                        7,
                        0,
                        "3e9f5086-d84b-44f4-891e-c29f3b74a035",
                        "Sterling_Doyle@gmail.com",
                        true,
                        false,
                        null,
                        "Corine Hayes",
                        null,
                        null,
                        null,
                        "(270) 913-5443",
                        false,
                        "a82118ca-43ce-4d94-82b7-cf642aaf5415",
                        false,
                        "Sterling_Doyle@gmail.com",
                    },
                    {
                        8,
                        0,
                        "9c57ce3b-0f47-4841-8ef4-cf6577763997",
                        "Coleman4@gmail.com",
                        true,
                        false,
                        null,
                        "Ethyl Prohaska",
                        null,
                        null,
                        null,
                        "1-801-327-3367",
                        false,
                        "9872f8c3-4fad-4699-b2e5-12332d34b8de",
                        false,
                        "Coleman4@gmail.com",
                    },
                    {
                        9,
                        0,
                        "d117438a-a1d8-4c8b-a7e4-64a3103f5b07",
                        "Haven.Muller73@hotmail.com",
                        true,
                        false,
                        null,
                        "Elvis Rolfson",
                        null,
                        null,
                        null,
                        "444-648-9508 x7947",
                        false,
                        "d7575906-08b7-45bd-837d-e0a67cc30386",
                        false,
                        "Haven.Muller73@hotmail.com",
                    },
                    {
                        10,
                        0,
                        "cf5a25ab-7bb1-4ff5-a4b1-b23c0caf119d",
                        "Kaycee.Muller86@yahoo.com",
                        true,
                        false,
                        null,
                        "Camilla Mante",
                        null,
                        null,
                        null,
                        "688.514.6528 x91770",
                        false,
                        "d00268b4-d961-42a7-8ad6-ab8de76f2726",
                        false,
                        "Kaycee.Muller86@yahoo.com",
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
                        "Soluta quaerat ad. Maxime voluptates quasi deleniti. Rem iusto explicabo perferendis. Nihil maiores velit aspernatur voluptatum dignissimos vel non voluptates.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(4840),
                        false,
                        "Jovan Hermann",
                        null,
                    },
                    {
                        2,
                        "Voluptas ipsam omnis praesentium. Nam nihil quod sunt voluptatem ut eligendi voluptas enim. Beatae consectetur illo.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5189),
                        false,
                        "Leanna Mills",
                        null,
                    },
                    {
                        3,
                        "Sint impedit perspiciatis et qui molestiae et necessitatibus et. Qui saepe possimus deserunt dolor. Modi rerum iure iste et veniam.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5270),
                        false,
                        "Cory Glover",
                        null,
                    },
                    {
                        4,
                        "Saepe corrupti qui tenetur quia esse doloribus impedit aperiam. Consequatur eum magni laboriosam ea. Voluptas vitae voluptatem. Qui reiciendis incidunt minima harum expedita. Dolorum quis eum ut et rem.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5355),
                        false,
                        "Liliane Jones",
                        null,
                    },
                    {
                        5,
                        "Non quia repellat sit rerum exercitationem et. Est necessitatibus aliquam ullam dolor et. Rem est necessitatibus omnis sed in.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5548),
                        false,
                        "Dagmar Casper",
                        null,
                    },
                    {
                        6,
                        "Occaecati quo quis amet enim ex. Non earum mollitia eligendi esse. Adipisci veniam quo pariatur. Ratione et totam iure quia voluptatem ea. Enim blanditiis sapiente. Repudiandae eos eaque deleniti non.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5612),
                        false,
                        "Johnny Runte",
                        null,
                    },
                    {
                        7,
                        "Soluta sint et qui voluptatem possimus. Enim pariatur perferendis. Excepturi omnis sint illum sunt. Et doloremque dolorum nulla vel modi dolorem libero est. Temporibus et suscipit ad. Vitae alias et dignissimos.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5732),
                        false,
                        "Korbin Turner",
                        null,
                    },
                    {
                        8,
                        "Aliquam molestias neque architecto. Nesciunt commodi error qui dolores totam. Inventore id omnis culpa.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5846),
                        false,
                        "Rod Batz",
                        null,
                    },
                    {
                        9,
                        "Quasi omnis laboriosam et quia rerum nisi dolores dicta nemo. Nam ut placeat veritatis eius inventore omnis odit. Illum culpa quaerat non numquam nostrum beatae aliquam voluptatem nemo.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5898),
                        false,
                        "Samara O'Keefe",
                        null,
                    },
                    {
                        10,
                        "Ipsa itaque sit ratione ratione praesentium debitis. Nobis ut aliquam veniam quo animi voluptatum quisquam. Eos consequatur nobis dignissimos voluptatem voluptatem distinctio.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 673, DateTimeKind.Utc).AddTicks(5970),
                        false,
                        "Charley Reinger",
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
                        "Quam repudiandae porro ipsam. Error consectetur nesciunt odio et sed quia omnis debitis. Sequi sint tempora quia aspernatur quisquam omnis corporis error. Quia et doloremque in nihil illo. Nihil enim nisi dolorum quo. Facilis nesciunt quis debitis.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 674, DateTimeKind.Utc).AddTicks(7546),
                        false,
                        "Feest - Dickens",
                        null,
                    },
                    {
                        2,
                        "Et quas aut provident facilis eligendi aperiam. Mollitia ullam eius minus eum dolorem sunt commodi laboriosam rerum. Voluptatibus aut inventore aperiam est beatae cum sit nostrum ducimus. Expedita error minima qui et dolorum temporibus cum dolorum.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 674, DateTimeKind.Utc).AddTicks(8116),
                        false,
                        "Grady Inc",
                        null,
                    },
                    {
                        3,
                        "Qui non magnam qui iure voluptates. Dolores sed et debitis. Quod suscipit iusto molestiae.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 674, DateTimeKind.Utc).AddTicks(8336),
                        false,
                        "Dare - Schroeder",
                        null,
                    },
                    {
                        4,
                        "Et quibusdam non minus modi tenetur beatae. Quis non ut aut debitis atque explicabo et mollitia ad. Quo nesciunt delectus.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 674, DateTimeKind.Utc).AddTicks(8478),
                        false,
                        "Boyle and Sons",
                        null,
                    },
                    {
                        5,
                        "Aut accusantium laborum vero. Itaque aut voluptas est assumenda consequatur. Et eum totam eius nobis quam. Iure perspiciatis corporis cumque asperiores. Sequi voluptas et minima tenetur.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 674, DateTimeKind.Utc).AddTicks(8619),
                        false,
                        "Rogahn - Adams",
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
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(77),
                        "Tenetur ad et voluptas quia. Et asperiores laboriosam aperiam incidunt minima tempore ut. Debitis libero nulla quo sunt et. Nemo est iure necessitatibus consectetur culpa aut qui praesentium. Quia cumque mollitia dicta fuga qui. Eos adipisci exercitationem.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        44.94m,
                        7,
                        4,
                        "Totam vel dolorem.",
                        null,
                    },
                    {
                        2,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(1621),
                        "Aut eius natus amet qui enim voluptas maxime ullam totam. Quis a et aut inventore qui asperiores eum. Ducimus quae aut natus quae unde pariatur asperiores adipisci quas. Quia fugiat quo qui quisquam aut consequuntur aliquam labore ut. Qui tempora consectetur aut quisquam error sit pariatur.",
                        0,
                        "/images/cover-3.jpg",
                        false,
                        null,
                        42.65m,
                        2,
                        4,
                        "Voluptatem qui voluptates.",
                        null,
                    },
                    {
                        3,
                        3,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(1829),
                        "Dicta natus libero iure. Earum illo in consequatur temporibus. Deserunt ea minima est impedit.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        70.33m,
                        5,
                        1,
                        "Optio exercitationem voluptas.",
                        null,
                    },
                    {
                        4,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(1904),
                        "Voluptates rem quisquam vel voluptates non commodi ipsa. Quas maiores perferendis qui rerum rem maiores illo ipsa. In molestiae error. Autem voluptatem deleniti dolorum repellat velit quod. Accusamus aut perferendis neque sed. Dolore repudiandae ut.",
                        0,
                        "/images/cover-5.jpg",
                        false,
                        null,
                        57.51m,
                        5,
                        2,
                        "Ut dolorem veniam.",
                        null,
                    },
                    {
                        5,
                        7,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(2002),
                        "Sint sunt incidunt et vel autem corrupti. Ex eligendi error sint est omnis in rerum quisquam. Ipsam commodi recusandae aliquam minima excepturi maxime nulla sapiente doloremque. Et quisquam minima. Ut consequuntur veniam.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        23.81m,
                        1,
                        1,
                        "Laudantium est quia.",
                        null,
                    },
                    {
                        6,
                        3,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(2169),
                        "Dolore debitis excepturi quaerat exercitationem nemo officiis est rerum quia. Officia autem nesciunt autem maiores. Sed nihil enim quia et atque et molestias. Quos quia esse culpa aut quisquam natus. Voluptas asperiores doloribus. In officiis modi quia.",
                        0,
                        "/images/cover-3.jpg",
                        false,
                        null,
                        65.77m,
                        3,
                        4,
                        "At deleniti ullam.",
                        null,
                    },
                    {
                        7,
                        1,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(2310),
                        "Sed nisi at. Doloribus aut dolores sapiente. Optio sunt aspernatur laboriosam quos mollitia. Quaerat laborum enim ea explicabo culpa. At est doloribus.",
                        0,
                        "/images/cover-9.jpg",
                        false,
                        null,
                        17.52m,
                        7,
                        1,
                        "Voluptatem debitis cum.",
                        null,
                    },
                    {
                        8,
                        2,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(4834),
                        "Voluptas deleniti recusandae cupiditate rem et deserunt delectus et. Eius corporis libero eos eum cumque. Perferendis magnam sit ad ratione quis.",
                        0,
                        "/images/cover-2.jpg",
                        false,
                        null,
                        55.76m,
                        5,
                        4,
                        "Animi et sunt.",
                        null,
                    },
                    {
                        9,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(4902),
                        "Laboriosam quos velit reprehenderit inventore aut. Voluptates deleniti aut repudiandae qui impedit ea. Minima quas alias doloribus. Omnis minima sunt quisquam sed vel doloremque. Qui et enim. Aut pariatur quibusdam tempore.",
                        0,
                        "/images/cover-8.jpg",
                        false,
                        null,
                        25.20m,
                        3,
                        5,
                        "Repellat atque nobis.",
                        null,
                    },
                    {
                        10,
                        4,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5018),
                        "Deserunt et architecto recusandae in. Perferendis qui consequuntur voluptas atque. Et culpa cumque voluptas nemo.",
                        0,
                        "/images/cover-9.jpg",
                        false,
                        null,
                        39.12m,
                        4,
                        1,
                        "Blanditiis cum cum.",
                        null,
                    },
                    {
                        11,
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5068),
                        "Dicta et molestias perspiciatis non repellendus consequuntur reiciendis eum quia. Cum itaque qui deserunt sed ratione impedit eum. Omnis rerum et cum qui ut. Velit est dolores.",
                        0,
                        "/images/cover-8.jpg",
                        false,
                        null,
                        12.14m,
                        6,
                        4,
                        "Temporibus voluptas aliquam.",
                        null,
                    },
                    {
                        12,
                        2,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5167),
                        "Quaerat sequi dicta maiores reiciendis velit quis aut. Et non nobis enim officia distinctio optio. Modi ut est. Eaque vel ut non optio nisi autem hic rerum. Placeat eaque atque et ut animi. Sit omnis est autem eius eius.",
                        0,
                        "/images/cover-7.jpg",
                        false,
                        null,
                        79.53m,
                        6,
                        1,
                        "Ut ipsa ullam.",
                        null,
                    },
                    {
                        13,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5281),
                        "Qui pariatur voluptate minima velit. A ab consequuntur tempore ut animi. Maiores fugiat quo et saepe ducimus deserunt qui culpa quibusdam. Sapiente et sit placeat voluptatem ad ex sed culpa.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        24.69m,
                        4,
                        3,
                        "Aliquam repudiandae est.",
                        null,
                    },
                    {
                        14,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5364),
                        "Minus at sed tenetur accusamus. Velit assumenda dignissimos laboriosam. Impedit facere itaque.",
                        0,
                        "/images/cover-8.jpg",
                        false,
                        null,
                        17.88m,
                        6,
                        3,
                        "Est sit hic.",
                        null,
                    },
                    {
                        15,
                        2,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5492),
                        "Eius sapiente officia rerum. Dolore quis tenetur minus aut. Voluptatum iste in et voluptas et ipsam. Ullam voluptas fuga. Quis in neque sunt velit ullam ut.",
                        0,
                        "/images/cover-8.jpg",
                        false,
                        null,
                        54.86m,
                        1,
                        5,
                        "Natus alias est.",
                        null,
                    },
                    {
                        16,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5559),
                        "Hic possimus tempora cum sit consequatur numquam illo eligendi. Sint saepe ex. Doloremque aut excepturi quia voluptatem distinctio. Saepe quas voluptatibus perspiciatis est sit dignissimos aut veritatis incidunt.",
                        0,
                        "/images/cover-9.jpg",
                        false,
                        null,
                        55.23m,
                        1,
                        3,
                        "A ad excepturi.",
                        null,
                    },
                    {
                        17,
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5647),
                        "Provident corrupti nisi assumenda enim. Adipisci cumque sapiente dicta sed nobis. Dignissimos quia ut sunt delectus quo amet quod optio. Non velit quis non.",
                        0,
                        "/images/cover-10.jpg",
                        false,
                        null,
                        17.87m,
                        1,
                        2,
                        "Deserunt sunt aut.",
                        null,
                    },
                    {
                        18,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5708),
                        "Est ullam exercitationem illo voluptatem voluptatem vitae repellat. Officiis quibusdam optio est quia. Maxime consequatur voluptatum neque ut deserunt voluptatibus deserunt excepturi placeat.",
                        0,
                        "/images/cover-9.jpg",
                        false,
                        null,
                        11.15m,
                        3,
                        1,
                        "Est pariatur suscipit.",
                        null,
                    },
                    {
                        19,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5828),
                        "Est nam et odit. Nam nobis et. Qui temporibus in at maiores voluptatem sunt consequatur temporibus sed.",
                        0,
                        "/images/cover-6.jpg",
                        false,
                        null,
                        58.92m,
                        2,
                        4,
                        "Vero aliquid vel.",
                        null,
                    },
                    {
                        20,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 676, DateTimeKind.Utc).AddTicks(5880),
                        "Libero minima et necessitatibus harum facilis laudantium molestias. Quia ipsum dolores voluptatem non ut. Iusto incidunt adipisci recusandae hic autem laborum voluptas quia. Est quae et asperiores tempora accusamus enim enim. Quia eos dolor cupiditate autem. Suscipit repellendus magnam deleniti consequuntur corrupti.",
                        0,
                        "/images/cover-9.jpg",
                        false,
                        null,
                        25.08m,
                        2,
                        3,
                        "Repellat sequi qui.",
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
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1233),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1234),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1235),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1235),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1235),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1236),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1236),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1236),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1236),
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
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 681, DateTimeKind.Utc).AddTicks(6262),
                        "Edgar35@gmail.com",
                        "Edgar Goldner",
                        false,
                        3,
                        1,
                        0m,
                        null,
                        9,
                    },
                    {
                        2,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 681, DateTimeKind.Utc).AddTicks(9487),
                        "Lisa.Feil@hotmail.com",
                        "Lisa Feil",
                        false,
                        1,
                        11,
                        0m,
                        null,
                        3,
                    },
                    {
                        3,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(386),
                        "Beverly.Carroll@gmail.com",
                        "Beverly Carroll",
                        false,
                        0,
                        13,
                        0m,
                        null,
                        8,
                    },
                    {
                        4,
                        13,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(972),
                        "Elena_Beer42@hotmail.com",
                        "Elena Beer",
                        false,
                        4,
                        15,
                        0m,
                        null,
                        3,
                    },
                    {
                        5,
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(1494),
                        "Lola.Stiedemann26@hotmail.com",
                        "Lola Stiedemann",
                        false,
                        5,
                        14,
                        0m,
                        null,
                        5,
                    },
                    {
                        6,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(2111),
                        "Janie0@yahoo.com",
                        "Janie Pfeffer",
                        false,
                        1,
                        4,
                        0m,
                        null,
                        8,
                    },
                    {
                        7,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(2596),
                        "Kyle_Deckow81@yahoo.com",
                        "Kyle Deckow",
                        false,
                        2,
                        6,
                        0m,
                        null,
                        10,
                    },
                    {
                        8,
                        4,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(3046),
                        "Francis52@hotmail.com",
                        "Francis Bechtelar",
                        false,
                        4,
                        12,
                        0m,
                        null,
                        2,
                    },
                    {
                        9,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(3606),
                        "Bridget_Farrell61@yahoo.com",
                        "Bridget Farrell",
                        false,
                        2,
                        12,
                        0m,
                        null,
                        2,
                    },
                    {
                        10,
                        15,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(4149),
                        "Noel_Ruecker96@hotmail.com",
                        "Noel Ruecker",
                        false,
                        1,
                        5,
                        0m,
                        null,
                        8,
                    },
                    {
                        11,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(4663),
                        "Gilbert.Fay@gmail.com",
                        "Gilbert Fay",
                        false,
                        0,
                        4,
                        0m,
                        null,
                        10,
                    },
                    {
                        12,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(5172),
                        "Rodolfo.Hahn33@gmail.com",
                        "Rodolfo Hahn",
                        false,
                        4,
                        7,
                        0m,
                        null,
                        7,
                    },
                    {
                        13,
                        2,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(6099),
                        "Alexandra.Kulas36@gmail.com",
                        "Alexandra Kulas",
                        false,
                        4,
                        10,
                        0m,
                        null,
                        6,
                    },
                    {
                        14,
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(6649),
                        "Sophia68@hotmail.com",
                        "Sophia Swift",
                        false,
                        3,
                        13,
                        0m,
                        null,
                        7,
                    },
                    {
                        15,
                        13,
                        new DateTime(2024, 12, 31, 20, 5, 10, 682, DateTimeKind.Utc).AddTicks(7245),
                        "Lula.Gleichner@gmail.com",
                        "Lula Gleichner",
                        false,
                        3,
                        14,
                        0m,
                        null,
                        5,
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
                        2,
                        new DateTime(2024, 12, 31, 20, 5, 10, 683, DateTimeKind.Utc).AddTicks(9705),
                        false,
                        1,
                        43.20m,
                        1,
                        null,
                    },
                    {
                        2,
                        4,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(694),
                        false,
                        15,
                        88.73m,
                        2,
                        null,
                    },
                    {
                        3,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(732),
                        false,
                        14,
                        52.19m,
                        3,
                        null,
                    },
                    {
                        4,
                        20,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(743),
                        false,
                        9,
                        98.24m,
                        3,
                        null,
                    },
                    {
                        5,
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(751),
                        false,
                        3,
                        68.92m,
                        1,
                        null,
                    },
                    {
                        6,
                        19,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(759),
                        false,
                        3,
                        25.33m,
                        2,
                        null,
                    },
                    {
                        7,
                        13,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(765),
                        false,
                        12,
                        45.53m,
                        2,
                        null,
                    },
                    {
                        8,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(772),
                        false,
                        2,
                        65.16m,
                        3,
                        null,
                    },
                    {
                        9,
                        17,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(778),
                        false,
                        4,
                        48.46m,
                        1,
                        null,
                    },
                    {
                        10,
                        7,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(785),
                        false,
                        10,
                        56.93m,
                        1,
                        null,
                    },
                    {
                        11,
                        12,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(792),
                        false,
                        13,
                        17.11m,
                        1,
                        null,
                    },
                    {
                        12,
                        12,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(798),
                        false,
                        9,
                        51.88m,
                        3,
                        null,
                    },
                    {
                        13,
                        18,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(804),
                        false,
                        1,
                        81.19m,
                        2,
                        null,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(811),
                        false,
                        1,
                        88.22m,
                        2,
                        null,
                    },
                    {
                        15,
                        15,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(818),
                        false,
                        1,
                        30.39m,
                        3,
                        null,
                    },
                    {
                        16,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(826),
                        false,
                        9,
                        34.91m,
                        3,
                        null,
                    },
                    {
                        17,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(833),
                        false,
                        13,
                        76.29m,
                        3,
                        null,
                    },
                    {
                        18,
                        18,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(839),
                        false,
                        9,
                        59.11m,
                        2,
                        null,
                    },
                    {
                        19,
                        3,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(846),
                        false,
                        12,
                        69.81m,
                        1,
                        null,
                    },
                    {
                        20,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(852),
                        false,
                        8,
                        49.49m,
                        1,
                        null,
                    },
                    {
                        21,
                        3,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(859),
                        false,
                        7,
                        74.84m,
                        1,
                        null,
                    },
                    {
                        22,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(866),
                        false,
                        14,
                        28.61m,
                        2,
                        null,
                    },
                    {
                        23,
                        15,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(872),
                        false,
                        10,
                        28.35m,
                        2,
                        null,
                    },
                    {
                        24,
                        2,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(879),
                        false,
                        1,
                        73.00m,
                        3,
                        null,
                    },
                    {
                        25,
                        17,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(886),
                        false,
                        10,
                        70.22m,
                        3,
                        null,
                    },
                    {
                        26,
                        15,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(893),
                        false,
                        8,
                        98.98m,
                        3,
                        null,
                    },
                    {
                        27,
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(900),
                        false,
                        2,
                        97.30m,
                        3,
                        null,
                    },
                    {
                        28,
                        13,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(907),
                        false,
                        1,
                        82.26m,
                        3,
                        null,
                    },
                    {
                        29,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(913),
                        false,
                        6,
                        88.93m,
                        3,
                        null,
                    },
                    {
                        30,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(920),
                        false,
                        13,
                        74.80m,
                        2,
                        null,
                    },
                    {
                        31,
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(925),
                        false,
                        13,
                        48.60m,
                        1,
                        null,
                    },
                    {
                        32,
                        4,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(982),
                        false,
                        4,
                        71.51m,
                        2,
                        null,
                    },
                    {
                        33,
                        17,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(990),
                        false,
                        10,
                        91.65m,
                        3,
                        null,
                    },
                    {
                        34,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(996),
                        false,
                        11,
                        17.60m,
                        1,
                        null,
                    },
                    {
                        35,
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1003),
                        false,
                        12,
                        61.09m,
                        3,
                        null,
                    },
                    {
                        36,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1010),
                        false,
                        10,
                        19.83m,
                        3,
                        null,
                    },
                    {
                        37,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1016),
                        false,
                        7,
                        60.61m,
                        1,
                        null,
                    },
                    {
                        38,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1022),
                        false,
                        5,
                        42.25m,
                        1,
                        null,
                    },
                    {
                        39,
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1029),
                        false,
                        3,
                        44.83m,
                        1,
                        null,
                    },
                    {
                        40,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1035),
                        false,
                        3,
                        88.21m,
                        1,
                        null,
                    },
                    {
                        41,
                        16,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1042),
                        false,
                        14,
                        29.68m,
                        3,
                        null,
                    },
                    {
                        42,
                        17,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1048),
                        false,
                        6,
                        68.41m,
                        1,
                        null,
                    },
                    {
                        43,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1054),
                        false,
                        2,
                        60.95m,
                        1,
                        null,
                    },
                    {
                        44,
                        17,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1060),
                        false,
                        11,
                        90.16m,
                        2,
                        null,
                    },
                    {
                        45,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1067),
                        false,
                        14,
                        57.47m,
                        3,
                        null,
                    },
                    {
                        46,
                        18,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1073),
                        false,
                        10,
                        10.51m,
                        1,
                        null,
                    },
                    {
                        47,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1079),
                        false,
                        8,
                        65.87m,
                        2,
                        null,
                    },
                    {
                        48,
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1086),
                        false,
                        11,
                        84.42m,
                        1,
                        null,
                    },
                    {
                        49,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1092),
                        false,
                        4,
                        93.78m,
                        2,
                        null,
                    },
                    {
                        50,
                        14,
                        new DateTime(2024, 12, 31, 20, 5, 10, 684, DateTimeKind.Utc).AddTicks(1098),
                        false,
                        5,
                        18.33m,
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
                        12,
                        "Laborum culpa nostrum quo cumque necessitatibus est hic quo alias.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(7539),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        2,
                        16,
                        "Minus quaerat voluptatem a ut pariatur.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8465),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        3,
                        10,
                        "Praesentium ipsum consequatur distinctio quae et aut blanditiis.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8595),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        4,
                        4,
                        "Impedit voluptatem quae et et sit.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8620),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        5,
                        18,
                        "Velit ea natus enim eveniet dolor est.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8637),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        6,
                        5,
                        "Iste aut distinctio.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8663),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        7,
                        9,
                        "Iste est et dolorum rem ullam.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8674),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        8,
                        16,
                        "Id tempore quia voluptatem veritatis qui.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8690),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        9,
                        3,
                        "Repellat voluptatem vero et quia repudiandae maxime earum officiis.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8709),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        10,
                        1,
                        "Quia nihil tenetur suscipit nostrum sint.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8728),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        11,
                        2,
                        "Provident quia aliquid quia incidunt ut ab ut.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8771),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        12,
                        16,
                        "Sit voluptatem corporis cumque aliquam maxime ut rerum.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8791),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        13,
                        19,
                        "Doloribus explicabo ut.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8810),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        14,
                        8,
                        "Labore eos nisi sequi.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8823),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        15,
                        14,
                        "Eius et tenetur sit sed qui id maiores et quaerat.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8836),
                        false,
                        5,
                        null,
                        6,
                    },
                    {
                        16,
                        19,
                        "Maiores ipsam cupiditate.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8856),
                        false,
                        4,
                        null,
                        4,
                    },
                    {
                        17,
                        2,
                        "Voluptas rerum a vero tempore placeat qui dolores.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8868),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        18,
                        19,
                        "Aut quo occaecati.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8887),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        19,
                        12,
                        "Quaerat quos rerum ipsa culpa tenetur molestias voluptatibus.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8899),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        20,
                        8,
                        "Explicabo ipsa consequatur rem voluptate velit quia amet.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8944),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        21,
                        18,
                        "Quaerat ipsum ex et quo dolor ab natus possimus.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8962),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        22,
                        19,
                        "Consequatur voluptatem similique.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8981),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        23,
                        1,
                        "Totam quis aut accusamus alias iusto voluptas.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(8994),
                        false,
                        5,
                        null,
                        8,
                    },
                    {
                        24,
                        17,
                        "Ea voluptatem illo et quasi ipsum.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9013),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        25,
                        8,
                        "Perspiciatis eius voluptatem minus.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9030),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        26,
                        1,
                        "Sit eveniet enim dolorem et fuga sint excepturi iure.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9044),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        27,
                        3,
                        "Quia ut ipsa voluptatem quae dolorem maiores eos omnis.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9065),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        28,
                        8,
                        "Quo expedita ad consequatur.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9116),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        29,
                        8,
                        "Optio commodi et modi voluptatem.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9128),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        30,
                        10,
                        "Dolores deleniti praesentium nam hic vitae.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9143),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        31,
                        8,
                        "Dolore molestiae recusandae possimus a.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9158),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        32,
                        7,
                        "Quisquam eligendi velit culpa maxime.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9172),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        33,
                        18,
                        "Quos ab est.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9186),
                        false,
                        2,
                        null,
                        6,
                    },
                    {
                        34,
                        14,
                        "Laborum nihil voluptas itaque culpa.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9197),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        35,
                        11,
                        "Deserunt quod nulla cum natus iure at optio.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9211),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        36,
                        16,
                        "Eos numquam tenetur ut rerum et temporibus.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9256),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        37,
                        20,
                        "Omnis corrupti quas ut in qui dignissimos eos nisi excepturi.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9274),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        38,
                        15,
                        "Dolores consequatur quia.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9295),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        39,
                        8,
                        "Ut quia earum voluptate nostrum dignissimos corporis.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9306),
                        false,
                        2,
                        null,
                        8,
                    },
                    {
                        40,
                        8,
                        "At illum exercitationem quam quis commodi assumenda quae ratione.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9323),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        41,
                        18,
                        "Ducimus non nam consequuntur consectetur voluptas maiores ut velit sapiente.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9342),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        42,
                        17,
                        "Necessitatibus et unde fuga odit voluptas eos.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9365),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        43,
                        16,
                        "Qui voluptates ut nam explicabo.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9382),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        44,
                        4,
                        "Impedit ex dolore autem aperiam laborum occaecati officia.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9424),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        45,
                        12,
                        "Velit voluptatem fugit voluptate vel quidem vitae iusto et quo.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9442),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        46,
                        4,
                        "Maiores quisquam aut perspiciatis reprehenderit est beatae.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9465),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        47,
                        10,
                        "Id consequuntur distinctio rerum omnis.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9483),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        48,
                        5,
                        "Praesentium voluptatum quia ex.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9498),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        49,
                        11,
                        "Et adipisci deleniti molestias dolorem nesciunt dicta assumenda.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9512),
                        false,
                        1,
                        null,
                        2,
                    },
                    {
                        50,
                        1,
                        "Aut qui accusantium voluptas delectus ab harum harum dignissimos.",
                        new DateTime(2024, 12, 31, 20, 5, 10, 677, DateTimeKind.Utc).AddTicks(9532),
                        false,
                        3,
                        null,
                        10,
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
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(518),
                        false,
                        null,
                        8,
                    },
                    {
                        2,
                        16,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(647),
                        false,
                        null,
                        6,
                    },
                    {
                        3,
                        15,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(652),
                        false,
                        null,
                        4,
                    },
                    {
                        4,
                        1,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(655),
                        false,
                        null,
                        5,
                    },
                    {
                        5,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(658),
                        false,
                        null,
                        6,
                    },
                    {
                        6,
                        20,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(661),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        1,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(663),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        5,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(666),
                        false,
                        null,
                        4,
                    },
                    {
                        9,
                        6,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(669),
                        false,
                        null,
                        7,
                    },
                    {
                        10,
                        1,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(671),
                        false,
                        null,
                        3,
                    },
                    {
                        11,
                        18,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(674),
                        false,
                        null,
                        8,
                    },
                    {
                        12,
                        8,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(677),
                        false,
                        null,
                        2,
                    },
                    {
                        13,
                        16,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(679),
                        false,
                        null,
                        8,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(682),
                        false,
                        null,
                        9,
                    },
                    {
                        15,
                        15,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(684),
                        false,
                        null,
                        9,
                    },
                    {
                        16,
                        4,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(687),
                        false,
                        null,
                        8,
                    },
                    {
                        17,
                        7,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(689),
                        false,
                        null,
                        9,
                    },
                    {
                        18,
                        12,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(723),
                        false,
                        null,
                        5,
                    },
                    {
                        19,
                        3,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(727),
                        false,
                        null,
                        8,
                    },
                    {
                        20,
                        20,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(730),
                        false,
                        null,
                        3,
                    },
                    {
                        21,
                        20,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(732),
                        false,
                        null,
                        8,
                    },
                    {
                        22,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(735),
                        false,
                        null,
                        3,
                    },
                    {
                        23,
                        20,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(737),
                        false,
                        null,
                        2,
                    },
                    {
                        24,
                        13,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(740),
                        false,
                        null,
                        6,
                    },
                    {
                        25,
                        9,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(742),
                        false,
                        null,
                        9,
                    },
                    {
                        26,
                        12,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(745),
                        false,
                        null,
                        5,
                    },
                    {
                        27,
                        13,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(747),
                        false,
                        null,
                        8,
                    },
                    {
                        28,
                        16,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(749),
                        false,
                        null,
                        2,
                    },
                    {
                        29,
                        10,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(752),
                        false,
                        null,
                        4,
                    },
                    {
                        30,
                        11,
                        new DateTime(2024, 12, 31, 20, 5, 10, 679, DateTimeKind.Utc).AddTicks(755),
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
