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
                    ShippingAddress = table.Column<string>(type: "text", nullable: false),
                    BillingAddress = table.Column<string>(type: "text", nullable: false),
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
                        "36a677f0-58ee-4444-b0ff-666dd0d149ca",
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
                        "d92ff90a-5828-4e9a-871c-980ac25e55ef",
                        false,
                        "admin",
                    },
                    {
                        2,
                        0,
                        "97b66029-ea23-4c24-a09b-6bc5d1a2c518",
                        "Brandon.Brakus14@yahoo.com",
                        true,
                        false,
                        null,
                        "Anjali Bergnaum",
                        null,
                        null,
                        null,
                        "(612) 299-3727",
                        false,
                        "2d451c98-00df-46f7-8950-5a43fd2dbe2c",
                        false,
                        "Prudence.Aufderhar92",
                    },
                    {
                        3,
                        0,
                        "490d2fbe-aa57-4437-874c-d7d6f30991b5",
                        "Reyes.Nitzsche@gmail.com",
                        true,
                        false,
                        null,
                        "Elton Kuhic",
                        null,
                        null,
                        null,
                        "(977) 418-7375",
                        false,
                        "f82f5ed8-c70e-4617-ad45-b0bc1fa95323",
                        false,
                        "Laury.VonRueden91",
                    },
                    {
                        4,
                        0,
                        "b9902072-4a84-4a99-a542-5899d130f3ac",
                        "Silas15@hotmail.com",
                        true,
                        false,
                        null,
                        "Libby O'Keefe",
                        null,
                        null,
                        null,
                        "(374) 582-7900 x1940",
                        false,
                        "c662ace6-b62b-48f6-8f4a-4d619fc08454",
                        false,
                        "Deonte_Ondricka51",
                    },
                    {
                        5,
                        0,
                        "d78fb146-fbdb-42f8-8e17-f50e6e435936",
                        "Llewellyn76@yahoo.com",
                        true,
                        false,
                        null,
                        "Gillian Ledner",
                        null,
                        null,
                        null,
                        "1-254-971-8695",
                        false,
                        "58003bf2-c08b-403a-a938-a3c43af0a97e",
                        false,
                        "Suzanne43",
                    },
                    {
                        6,
                        0,
                        "1d2268cb-576c-4a18-b921-8c5d8b60d276",
                        "Delfina.Volkman3@yahoo.com",
                        true,
                        false,
                        null,
                        "Floy Sawayn",
                        null,
                        null,
                        null,
                        "949-842-8369",
                        false,
                        "fe126989-736d-4bf9-a260-10204358c806",
                        false,
                        "Colten21",
                    },
                    {
                        7,
                        0,
                        "80693d3a-6753-4fde-a7cb-db365cbfab00",
                        "Gerda_Mayer@hotmail.com",
                        true,
                        false,
                        null,
                        "Gunnar Treutel",
                        null,
                        null,
                        null,
                        "(313) 957-5498",
                        false,
                        "dae450a5-495c-4fe9-9801-c2ec1c00c441",
                        false,
                        "Abe_Hoeger42",
                    },
                    {
                        8,
                        0,
                        "5b5af17d-c6f9-436f-a1e1-183c59d1bdcd",
                        "Libbie_Anderson7@gmail.com",
                        true,
                        false,
                        null,
                        "Everett Murazik",
                        null,
                        null,
                        null,
                        "698-486-0248",
                        false,
                        "5a4659b5-e4f0-4c9c-8573-3260f28173ec",
                        false,
                        "Carlos.Champlin",
                    },
                    {
                        9,
                        0,
                        "6877290a-5a79-4e46-a5e3-3d6d23e1a208",
                        "Frederique_Pouros15@gmail.com",
                        true,
                        false,
                        null,
                        "Stuart Buckridge",
                        null,
                        null,
                        null,
                        "1-957-596-1894 x7143",
                        false,
                        "a7d6541a-da69-4a3e-89a6-f4bda278e605",
                        false,
                        "Idella.Maggio",
                    },
                    {
                        10,
                        0,
                        "d20165ff-a873-45ac-9c8f-1427c1c53cda",
                        "Wilbert23@yahoo.com",
                        true,
                        false,
                        null,
                        "Winifred Mayer",
                        null,
                        null,
                        null,
                        "756.760.5606 x3380",
                        false,
                        "be713917-18a6-4b44-aad9-c95176bc0c39",
                        false,
                        "Odie22",
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
                        "Occaecati asperiores iure maiores est minus velit et. Iste odio amet distinctio. Impedit voluptatem optio repudiandae rem cum repudiandae accusantium a. Tempore cumque asperiores aut doloremque est enim velit. Natus praesentium ex. Ipsa veritatis eos totam est dolor.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            6719
                        ),
                        false,
                        "Joseph Bosco",
                        null,
                    },
                    {
                        2,
                        "Vitae amet dicta et nihil et accusantium. Voluptatem ipsam velit quia est. Qui consectetur quidem sit optio quo.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7138
                        ),
                        false,
                        "Bertram Ruecker",
                        null,
                    },
                    {
                        3,
                        "Qui cupiditate ad. Earum culpa vero repellendus officiis. Aliquam praesentium aspernatur impedit magni. Dolores accusamus eveniet hic. Aperiam consequuntur ad repellendus tempore. Quaerat minima est voluptas.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7249
                        ),
                        false,
                        "Erick Ratke",
                        null,
                    },
                    {
                        4,
                        "Voluptatem qui non rerum voluptatum ut harum facere. Sit voluptas dicta architecto eligendi vel. Dolorem veritatis perferendis dolore eveniet harum voluptate facere.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7350
                        ),
                        false,
                        "Sigrid Gusikowski",
                        null,
                    },
                    {
                        5,
                        "Consequatur quo officia voluptatem est voluptatibus quo reprehenderit provident ut. Tenetur iste nulla nobis enim beatae. Ea ducimus qui reiciendis. Corrupti temporibus inventore temporibus ipsam. Dolor dolorem vitae sint occaecati.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7455
                        ),
                        false,
                        "Brandyn Volkman",
                        null,
                    },
                    {
                        6,
                        "Quisquam veritatis autem perferendis et omnis pariatur perspiciatis. Molestias ea labore itaque corrupti. Adipisci magnam pariatur quia voluptatem sint ad perspiciatis. Iste consequuntur saepe quam ad voluptatem quis eius excepturi molestias. Consequuntur est quas quod. Sed temporibus ut.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7557
                        ),
                        false,
                        "Stuart Huel",
                        null,
                    },
                    {
                        7,
                        "Earum quis natus consequatur quis modi sunt tempora dolores aliquam. Doloremque doloremque quisquam dolorem. A nobis sapiente minima.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7736
                        ),
                        false,
                        "Sandrine Leuschke",
                        null,
                    },
                    {
                        8,
                        "Beatae est nulla voluptatibus sit aut soluta sapiente accusamus. Sed hic et laudantium voluptas magnam atque. Saepe dolorum aspernatur rerum at nobis. In ut sed dolor.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7794
                        ),
                        false,
                        "Aida Jast",
                        null,
                    },
                    {
                        9,
                        "Vero ut provident vitae rerum non ea qui nihil alias. Et veniam aut. Delectus cum quas.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7900
                        ),
                        false,
                        "Norwood Vandervort",
                        null,
                    },
                    {
                        10,
                        "Recusandae dolor accusantium omnis. Architecto quae illo. Consequatur ducimus unde.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 306, DateTimeKind.Utc).AddTicks(
                            7955
                        ),
                        false,
                        "Kian Rath",
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
                        "Est in consequatur quia magnam rerum. Sint quo minima sint quaerat quia doloremque rem ea asperiores. Enim vel molestias.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 308, DateTimeKind.Utc).AddTicks(
                            4584
                        ),
                        false,
                        "Cartwright - Keebler",
                        null,
                    },
                    {
                        2,
                        "Magni maxime hic iure optio enim dolor veniam minus. Et et aut. Sit velit et sed et consequatur assumenda neque similique. Quisquam vitae est repellat ea laudantium et vitae et nesciunt. Unde soluta iure.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 308, DateTimeKind.Utc).AddTicks(
                            5392
                        ),
                        false,
                        "Zulauf LLC",
                        null,
                    },
                    {
                        3,
                        "Ut aut eum accusantium inventore sit unde incidunt sunt ducimus. Aut et quia sint exercitationem repellat laborum reprehenderit voluptatibus. Et similique animi adipisci placeat. Rem enim at.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 308, DateTimeKind.Utc).AddTicks(
                            5664
                        ),
                        false,
                        "Von, Kautzer and Ondricka",
                        null,
                    },
                    {
                        4,
                        "Nobis praesentium labore molestias vel. Necessitatibus dolore iste sunt vel ipsum soluta quam dolorum. Ut odio asperiores consectetur. Eos mollitia aperiam facilis ullam occaecati illo iure.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 308, DateTimeKind.Utc).AddTicks(
                            5841
                        ),
                        false,
                        "Runolfsdottir, Wisozk and Bins",
                        null,
                    },
                    {
                        5,
                        "Expedita voluptatem est eum exercitationem et sapiente. Aut rem et recusandae nam occaecati doloremque. Soluta quasi dolores velit soluta voluptatem. Fugit magnam voluptatem et molestias earum sequi. Ratione ut ratione laudantium maxime est ut. Perspiciatis facere ipsa.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 308, DateTimeKind.Utc).AddTicks(
                            6111
                        ),
                        false,
                        "Gutmann - Miller",
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
                    "Genre",
                    "ImagePath",
                    "IsDeleted",
                    "Price",
                    "PublisherId",
                    "Title",
                    "UpdatedDate",
                },
                values: new object[,]
                {
                    {
                        1,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(648),
                        "Vel asperiores aut beatae natus modi officia quia odio. Voluptatum corrupti dolores qui culpa molestiae magni. Consequatur sit eum quae consequuntur. Et enim vitae in quis beatae corporis commodi. Nihil non dolores quos.",
                        7,
                        "https://picsum.photos/640/480/?image=994",
                        false,
                        98.23m,
                        2,
                        "Explicabo et provident.",
                        null,
                    },
                    {
                        2,
                        3,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            3552
                        ),
                        "Nihil ducimus ut dignissimos placeat reprehenderit voluptas quas. Qui ipsam distinctio ipsum laboriosam. Tenetur alias harum autem quia eaque nostrum sed nesciunt quasi. Harum possimus cupiditate exercitationem nobis consequatur rerum. Modi voluptatem ut rerum inventore ut repellendus sit. Velit iste asperiores et pariatur similique.",
                        0,
                        "https://picsum.photos/640/480/?image=869",
                        false,
                        61.03m,
                        4,
                        "Similique fuga laudantium.",
                        null,
                    },
                    {
                        3,
                        4,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            3901
                        ),
                        "Laudantium omnis commodi iste quia consequatur esse. Quisquam sint perferendis similique occaecati numquam asperiores animi tenetur. Debitis qui ut sint expedita ullam ut enim. Ut necessitatibus nesciunt. Quia repellendus cumque quia dolor culpa non consequuntur.",
                        3,
                        "https://picsum.photos/640/480/?image=383",
                        false,
                        61.62m,
                        3,
                        "Aspernatur optio corrupti.",
                        null,
                    },
                    {
                        4,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4057
                        ),
                        "Sit voluptatibus ea doloribus voluptas nihil vero. Iure et numquam et ratione ex est. Non asperiores consequuntur nostrum soluta reprehenderit molestias et.",
                        1,
                        "https://picsum.photos/640/480/?image=5",
                        false,
                        30.73m,
                        2,
                        "Harum numquam illum.",
                        null,
                    },
                    {
                        5,
                        7,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4145
                        ),
                        "Repudiandae suscipit animi. Quibusdam aut in sed velit distinctio in voluptatem omnis. Officiis corporis repellat voluptas consequatur. In sunt rerum maiores. Odit veritatis aspernatur ipsum eligendi a. Omnis atque voluptatum necessitatibus fuga error quia autem et.",
                        2,
                        "https://picsum.photos/640/480/?image=213",
                        false,
                        81.33m,
                        1,
                        "Molestiae quod deleniti.",
                        null,
                    },
                    {
                        6,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4303
                        ),
                        "Qui ipsa commodi qui accusantium nihil. Sunt in quia voluptatum in harum saepe doloribus doloremque aliquid. Debitis aut illo quos voluptatibus possimus ipsa. Earum praesentium possimus voluptas autem dolorum accusamus ipsum odit. Nobis alias iusto explicabo ut quos quo iste.",
                        3,
                        "https://picsum.photos/640/480/?image=473",
                        false,
                        77.01m,
                        2,
                        "Veritatis eum iure.",
                        null,
                    },
                    {
                        7,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4437
                        ),
                        "Velit recusandae est eos ut repellendus ipsam sequi ea et. Laborum fugit sapiente pariatur asperiores explicabo vitae temporibus consequatur. Rem commodi quia ut quia molestiae voluptatem. Recusandae vitae asperiores consequatur eligendi ducimus quidem dolor. Qui quo ad doloribus unde voluptate sapiente et quas. Temporibus aliquid facilis recusandae nisi delectus blanditiis qui reiciendis.",
                        7,
                        "https://picsum.photos/640/480/?image=79",
                        false,
                        13.55m,
                        2,
                        "Est possimus doloremque.",
                        null,
                    },
                    {
                        8,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4671
                        ),
                        "Repudiandae officiis et at ut ex. Voluptatem rerum doloremque inventore quidem odit et rerum. Dolorum nisi repellat eos voluptas.",
                        4,
                        "https://picsum.photos/640/480/?image=664",
                        false,
                        20.29m,
                        2,
                        "Et sapiente amet.",
                        null,
                    },
                    {
                        9,
                        5,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4736
                        ),
                        "Numquam aut dignissimos id reiciendis sunt aut. Sit doloremque eligendi excepturi et veritatis facere autem ea est. Corporis pariatur dolorem et libero. Ex voluptatem sit consectetur aliquam ut. Exercitationem in laboriosam quas sint consequatur sed sed totam deleniti.",
                        2,
                        "https://picsum.photos/640/480/?image=597",
                        false,
                        86.15m,
                        4,
                        "Necessitatibus sapiente culpa.",
                        null,
                    },
                    {
                        10,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            4883
                        ),
                        "Autem consequuntur ullam explicabo ipsa sequi eos eius at sed. Facilis est amet aspernatur. Impedit aut ea a ut at animi reiciendis ullam. Ut cum quasi et similique officia possimus autem soluta. Labore voluptatem rerum omnis ut rerum architecto fugiat.",
                        7,
                        "https://picsum.photos/640/480/?image=900",
                        false,
                        74.48m,
                        4,
                        "Itaque sed autem.",
                        null,
                    },
                    {
                        11,
                        6,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5019
                        ),
                        "Est vitae ipsam esse debitis temporibus amet error unde. Odio sed molestiae. Officiis doloribus eveniet aut sint temporibus quo explicabo.",
                        0,
                        "https://picsum.photos/640/480/?image=883",
                        false,
                        19.96m,
                        3,
                        "Iusto vel suscipit.",
                        null,
                    },
                    {
                        12,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5114
                        ),
                        "Commodi cupiditate ea tempore dicta excepturi suscipit. At ex numquam modi. Ad sed et ratione et asperiores et libero ab.",
                        5,
                        "https://picsum.photos/640/480/?image=600",
                        false,
                        69.14m,
                        3,
                        "Voluptates ex quia.",
                        null,
                    },
                    {
                        13,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5181
                        ),
                        "Adipisci libero sit minus accusamus excepturi. Quo quo qui. Nesciunt laudantium autem rerum facilis et illum.",
                        7,
                        "https://picsum.photos/640/480/?image=943",
                        false,
                        35.22m,
                        5,
                        "Dolores et incidunt.",
                        null,
                    },
                    {
                        14,
                        7,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5272
                        ),
                        "Atque facilis molestiae rerum. Et ullam sed perferendis saepe eaque consequatur architecto. Et illo molestiae nesciunt sit saepe amet eius non.",
                        1,
                        "https://picsum.photos/640/480/?image=274",
                        false,
                        24.82m,
                        5,
                        "Illum eius nostrum.",
                        null,
                    },
                    {
                        15,
                        4,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5338
                        ),
                        "Similique voluptatem consequatur veritatis ullam illo nesciunt fugit quo. Autem dicta ipsa ut consectetur. Illum et unde natus sint ratione. Numquam odio omnis quis eveniet nostrum harum voluptatem aspernatur sunt. Numquam dolores qui voluptatem illo qui.",
                        3,
                        "https://picsum.photos/640/480/?image=87",
                        false,
                        13.56m,
                        2,
                        "Repellendus aut est.",
                        null,
                    },
                    {
                        16,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5469
                        ),
                        "Quasi et repellendus aut similique et incidunt saepe. Provident et delectus dolores eum in dignissimos et ratione. Et provident sed reprehenderit esse voluptas. Provident dolores est harum rerum ipsa aut.",
                        0,
                        "https://picsum.photos/640/480/?image=144",
                        false,
                        41.71m,
                        1,
                        "Sint ducimus eos.",
                        null,
                    },
                    {
                        17,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5605
                        ),
                        "Repellat vel et. Eum porro atque ut laudantium. Eos asperiores ullam laboriosam facere. Magni quidem eveniet nihil eveniet iure itaque magni. Quo eius quae ipsum officiis vero autem exercitationem eveniet.",
                        5,
                        "https://picsum.photos/640/480/?image=882",
                        false,
                        91.81m,
                        5,
                        "Occaecati magnam dolorum.",
                        null,
                    },
                    {
                        18,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5690
                        ),
                        "Fugiat et qui placeat eius quidem cupiditate. Sed non qui soluta eum veritatis natus. Animi et et rerum hic nemo tempore at et ea. Id est dolorum dolorem atque rerum. Expedita velit tempora ex.",
                        2,
                        "https://picsum.photos/640/480/?image=944",
                        false,
                        94.17m,
                        1,
                        "Officia numquam laudantium.",
                        null,
                    },
                    {
                        19,
                        7,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5802
                        ),
                        "Dolor praesentium vitae quam aliquam consectetur veniam ipsum perferendis. Quia animi nobis nihil temporibus aspernatur nulla necessitatibus veniam. Ab ut et.",
                        8,
                        "https://picsum.photos/640/480/?image=879",
                        false,
                        89.70m,
                        3,
                        "Omnis et voluptatem.",
                        null,
                    },
                    {
                        20,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 310, DateTimeKind.Utc).AddTicks(
                            5932
                        ),
                        "Ut consectetur dolores ipsam. Quas suscipit qui totam eius. Consequatur cupiditate tempora sint optio minima voluptas qui repellat sequi.",
                        3,
                        "https://picsum.photos/640/480/?image=406",
                        false,
                        67.01m,
                        2,
                        "Occaecati quo ea.",
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
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3793
                        ),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3794
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3795
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3795
                        ),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3795
                        ),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3796
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3796
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3796
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3797
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
                    "BillingAddress",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "IsDeleted",
                    "ShippingAddress",
                    "TotalAmount",
                    "UpdatedDate",
                    "UserId",
                },
                values: new object[,]
                {
                    {
                        1,
                        "2245 Wehner Rest, West Scot, Heard Island and McDonald Islands",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(782),
                        "Frank90@yahoo.com",
                        "Frank Bashirian",
                        false,
                        "157 Lempi Loop, South Olen, Nepal",
                        0m,
                        null,
                        5,
                    },
                    {
                        2,
                        "58928 Margarete Crossing, West Lourdesbury, Czech Republic",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(
                            4703
                        ),
                        "Sheila.Hegmann25@yahoo.com",
                        "Sheila Hegmann",
                        false,
                        "70624 Lauren Drives, Erdmantown, Tokelau",
                        0m,
                        null,
                        8,
                    },
                    {
                        3,
                        "68306 Aleen Alley, North Kitty, Cambodia",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(
                            6121
                        ),
                        "Jodi.Pfannerstill37@hotmail.com",
                        "Jodi Pfannerstill",
                        false,
                        "803 Sydnie Ports, New Ahmed, Albania",
                        0m,
                        null,
                        3,
                    },
                    {
                        4,
                        "3295 Queenie Orchard, Lake Chelsieton, Cameroon",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(
                            7013
                        ),
                        "Lauren.Watsica@hotmail.com",
                        "Lauren Watsica",
                        false,
                        "43968 Steuber Flat, West Monroe, Saint Pierre and Miquelon",
                        0m,
                        null,
                        5,
                    },
                    {
                        5,
                        "4083 Hansen Mills, West Brandt, Solomon Islands",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(
                            7847
                        ),
                        "Darin.Roberts@yahoo.com",
                        "Darin Roberts",
                        false,
                        "02280 Kub Ports, East Wilson, Uganda",
                        0m,
                        null,
                        5,
                    },
                    {
                        6,
                        "93501 Syble Cliffs, Ravenbury, Costa Rica",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(
                            8641
                        ),
                        "Philip18@hotmail.com",
                        "Philip Gibson",
                        false,
                        "519 Ferry Mews, Lake Itzelburgh, Monaco",
                        0m,
                        null,
                        4,
                    },
                    {
                        7,
                        "9848 Keeley Meadow, Andyside, South Georgia and the South Sandwich Islands",
                        new DateTime(2024, 10, 22, 20, 33, 31, 315, DateTimeKind.Utc).AddTicks(
                            9350
                        ),
                        "Tony25@hotmail.com",
                        "Tony DuBuque",
                        false,
                        "1086 Hahn Inlet, Lake Tryciaville, Heard Island and McDonald Islands",
                        0m,
                        null,
                        8,
                    },
                    {
                        8,
                        "362 Altenwerth Mall, Loganmouth, Malaysia",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(105),
                        "Lydia.Douglas@gmail.com",
                        "Lydia Douglas",
                        false,
                        "9951 Josefa Unions, Traceside, Paraguay",
                        0m,
                        null,
                        2,
                    },
                    {
                        9,
                        "7981 Ledner Knolls, East Brooklynfurt, Palau",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(854),
                        "Micheal6@yahoo.com",
                        "Micheal Corwin",
                        false,
                        "046 Gleichner Dam, North Reyna, Holy See (Vatican City State)",
                        0m,
                        null,
                        4,
                    },
                    {
                        10,
                        "788 Aimee Way, Greenberg, Hong Kong",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(
                            1964
                        ),
                        "Cassandra.Jacobs@hotmail.com",
                        "Cassandra Jacobs",
                        false,
                        "1012 Kaleigh Stream, Clotildehaven, South Georgia and the South Sandwich Islands",
                        0m,
                        null,
                        10,
                    },
                    {
                        11,
                        "9928 Stephanie Mission, South Sanford, Congo",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(
                            2746
                        ),
                        "Neal_Hegmann54@yahoo.com",
                        "Neal Hegmann",
                        false,
                        "59509 Schaefer Crest, Marisoltown, United Kingdom",
                        0m,
                        null,
                        3,
                    },
                    {
                        12,
                        "05653 Koepp Landing, East Augustberg, China",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(
                            3510
                        ),
                        "Gloria31@gmail.com",
                        "Gloria Pfannerstill",
                        false,
                        "7109 Hickle Loaf, Port Felicita, Heard Island and McDonald Islands",
                        0m,
                        null,
                        4,
                    },
                    {
                        13,
                        "1576 Farrell Summit, Lake Cleo, Guernsey",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(
                            4350
                        ),
                        "Luz.Gaylord@gmail.com",
                        "Luz Gaylord",
                        false,
                        "044 Karl Valley, Rafaelview, Senegal",
                        0m,
                        null,
                        5,
                    },
                    {
                        14,
                        "48602 Colby Shore, Kaitlinton, Tanzania",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(
                            5218
                        ),
                        "Melody_Veum@hotmail.com",
                        "Melody Veum",
                        false,
                        "406 Leannon Pines, South Kennyview, India",
                        0m,
                        null,
                        7,
                    },
                    {
                        15,
                        "4109 Prosacco Spring, Runolfsdottirton, Ethiopia",
                        new DateTime(2024, 10, 22, 20, 33, 31, 316, DateTimeKind.Utc).AddTicks(
                            5926
                        ),
                        "Randall95@hotmail.com",
                        "Randall Kuhic",
                        false,
                        "255 Adam Green, Brekkehaven, Zimbabwe",
                        0m,
                        null,
                        10,
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
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            1887
                        ),
                        false,
                        5,
                        62.78m,
                        2,
                        null,
                    },
                    {
                        2,
                        5,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3061
                        ),
                        false,
                        1,
                        75.95m,
                        2,
                        null,
                    },
                    {
                        3,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3106
                        ),
                        false,
                        6,
                        50.16m,
                        2,
                        null,
                    },
                    {
                        4,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3117
                        ),
                        false,
                        14,
                        15.66m,
                        2,
                        null,
                    },
                    {
                        5,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3126
                        ),
                        false,
                        5,
                        60.40m,
                        3,
                        null,
                    },
                    {
                        6,
                        17,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3134
                        ),
                        false,
                        3,
                        14.58m,
                        3,
                        null,
                    },
                    {
                        7,
                        6,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3142
                        ),
                        false,
                        3,
                        94.97m,
                        1,
                        null,
                    },
                    {
                        8,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3151
                        ),
                        false,
                        8,
                        89.22m,
                        3,
                        null,
                    },
                    {
                        9,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3159
                        ),
                        false,
                        13,
                        49.85m,
                        1,
                        null,
                    },
                    {
                        10,
                        5,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3167
                        ),
                        false,
                        1,
                        57.23m,
                        3,
                        null,
                    },
                    {
                        11,
                        13,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3175
                        ),
                        false,
                        10,
                        98.07m,
                        3,
                        null,
                    },
                    {
                        12,
                        3,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3229
                        ),
                        false,
                        13,
                        45.72m,
                        3,
                        null,
                    },
                    {
                        13,
                        11,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3239
                        ),
                        false,
                        14,
                        19.77m,
                        2,
                        null,
                    },
                    {
                        14,
                        17,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3246
                        ),
                        false,
                        7,
                        63.04m,
                        1,
                        null,
                    },
                    {
                        15,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3254
                        ),
                        false,
                        12,
                        19.31m,
                        2,
                        null,
                    },
                    {
                        16,
                        13,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3262
                        ),
                        false,
                        11,
                        86.39m,
                        1,
                        null,
                    },
                    {
                        17,
                        17,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3269
                        ),
                        false,
                        9,
                        19.00m,
                        2,
                        null,
                    },
                    {
                        18,
                        18,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3278
                        ),
                        false,
                        7,
                        83.40m,
                        3,
                        null,
                    },
                    {
                        19,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3285
                        ),
                        false,
                        5,
                        24.30m,
                        2,
                        null,
                    },
                    {
                        20,
                        20,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3293
                        ),
                        false,
                        2,
                        94.06m,
                        2,
                        null,
                    },
                    {
                        21,
                        12,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3301
                        ),
                        false,
                        2,
                        90.20m,
                        1,
                        null,
                    },
                    {
                        22,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3308
                        ),
                        false,
                        1,
                        97.95m,
                        3,
                        null,
                    },
                    {
                        23,
                        16,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3316
                        ),
                        false,
                        1,
                        26.16m,
                        2,
                        null,
                    },
                    {
                        24,
                        12,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3324
                        ),
                        false,
                        10,
                        94.71m,
                        1,
                        null,
                    },
                    {
                        25,
                        19,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3331
                        ),
                        false,
                        8,
                        20.73m,
                        1,
                        null,
                    },
                    {
                        26,
                        16,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3339
                        ),
                        false,
                        7,
                        96.20m,
                        1,
                        null,
                    },
                    {
                        27,
                        5,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3346
                        ),
                        false,
                        8,
                        19.23m,
                        3,
                        null,
                    },
                    {
                        28,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3353
                        ),
                        false,
                        14,
                        93.32m,
                        2,
                        null,
                    },
                    {
                        29,
                        14,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3362
                        ),
                        false,
                        6,
                        52.21m,
                        2,
                        null,
                    },
                    {
                        30,
                        6,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3370
                        ),
                        false,
                        15,
                        87.40m,
                        1,
                        null,
                    },
                    {
                        31,
                        20,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3377
                        ),
                        false,
                        8,
                        78.10m,
                        2,
                        null,
                    },
                    {
                        32,
                        7,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3384
                        ),
                        false,
                        7,
                        40.64m,
                        2,
                        null,
                    },
                    {
                        33,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3392
                        ),
                        false,
                        3,
                        20.54m,
                        1,
                        null,
                    },
                    {
                        34,
                        19,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3400
                        ),
                        false,
                        3,
                        39.49m,
                        3,
                        null,
                    },
                    {
                        35,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3408
                        ),
                        false,
                        7,
                        34.72m,
                        2,
                        null,
                    },
                    {
                        36,
                        12,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3415
                        ),
                        false,
                        6,
                        37.30m,
                        2,
                        null,
                    },
                    {
                        37,
                        12,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3423
                        ),
                        false,
                        11,
                        75.06m,
                        1,
                        null,
                    },
                    {
                        38,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3430
                        ),
                        false,
                        14,
                        56.76m,
                        3,
                        null,
                    },
                    {
                        39,
                        18,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3438
                        ),
                        false,
                        8,
                        12.35m,
                        3,
                        null,
                    },
                    {
                        40,
                        17,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3445
                        ),
                        false,
                        8,
                        96.99m,
                        2,
                        null,
                    },
                    {
                        41,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3453
                        ),
                        false,
                        12,
                        98.42m,
                        1,
                        null,
                    },
                    {
                        42,
                        4,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3461
                        ),
                        false,
                        5,
                        56.36m,
                        3,
                        null,
                    },
                    {
                        43,
                        12,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3567
                        ),
                        false,
                        7,
                        75.01m,
                        1,
                        null,
                    },
                    {
                        44,
                        13,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3575
                        ),
                        false,
                        3,
                        20.19m,
                        1,
                        null,
                    },
                    {
                        45,
                        16,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3583
                        ),
                        false,
                        10,
                        26.92m,
                        1,
                        null,
                    },
                    {
                        46,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3591
                        ),
                        false,
                        1,
                        41.58m,
                        2,
                        null,
                    },
                    {
                        47,
                        11,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3599
                        ),
                        false,
                        13,
                        26.70m,
                        2,
                        null,
                    },
                    {
                        48,
                        3,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3607
                        ),
                        false,
                        13,
                        58.60m,
                        2,
                        null,
                    },
                    {
                        49,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3615
                        ),
                        false,
                        1,
                        20.11m,
                        3,
                        null,
                    },
                    {
                        50,
                        18,
                        new DateTime(2024, 10, 22, 20, 33, 31, 318, DateTimeKind.Utc).AddTicks(
                            3622
                        ),
                        false,
                        15,
                        62.82m,
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
                        8,
                        "Magni itaque sed neque.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(990),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        2,
                        9,
                        "Inventore et consequatur natus quae id aut sint odio.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2451
                        ),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        3,
                        12,
                        "Ut quia dolorem atque nihil nemo aut.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2596
                        ),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        4,
                        12,
                        "Quia omnis quas sit non ut rerum et doloremque quisquam.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2623
                        ),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        5,
                        20,
                        "Qui debitis ad exercitationem fuga consequatur optio quis.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2658
                        ),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        6,
                        3,
                        "Et eaque placeat et ut omnis totam maxime.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2686
                        ),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        7,
                        13,
                        "Deserunt recusandae nam.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2712
                        ),
                        false,
                        1,
                        null,
                        7,
                    },
                    {
                        8,
                        16,
                        "Qui amet quae qui.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2730
                        ),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        9,
                        18,
                        "Officia non quis eveniet minima voluptatem autem magnam magnam.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2746
                        ),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        10,
                        7,
                        "Quia possimus vel qui ullam qui dolor.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2837
                        ),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        11,
                        2,
                        "Eum aut consequatur neque commodi autem magni deserunt.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2861
                        ),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        12,
                        15,
                        "Esse vel architecto repudiandae debitis non repudiandae iusto.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2882
                        ),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        13,
                        4,
                        "Dolor iusto voluptate fugit.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2906
                        ),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        14,
                        19,
                        "Esse voluptas impedit quo laborum.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2923
                        ),
                        false,
                        5,
                        null,
                        2,
                    },
                    {
                        15,
                        2,
                        "Quia id magnam qui dolor consequatur animi mollitia est.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2940
                        ),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        16,
                        19,
                        "Consequatur sed dignissimos laudantium molestiae non aut.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            2968
                        ),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        17,
                        8,
                        "Sunt placeat excepturi.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3010
                        ),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        18,
                        11,
                        "Quia qui aut tenetur quo qui.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3025
                        ),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        19,
                        19,
                        "Tempora aspernatur dignissimos.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3045
                        ),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        20,
                        4,
                        "Quia natus doloribus tempora optio eius aut.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3059
                        ),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        21,
                        8,
                        "Veniam nulla perspiciatis dolore quos voluptas delectus.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3082
                        ),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        22,
                        3,
                        "Est aperiam similique voluptatem.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3106
                        ),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        23,
                        6,
                        "Sed quasi sit maiores dolorem atque.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3125
                        ),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        24,
                        7,
                        "Assumenda impedit magni voluptas.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3143
                        ),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        25,
                        4,
                        "Ut sunt odit eos quod sit natus expedita vel.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3158
                        ),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        26,
                        9,
                        "Nihil doloribus dolorum.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3276
                        ),
                        false,
                        4,
                        null,
                        10,
                    },
                    {
                        27,
                        9,
                        "Repudiandae eius molestiae suscipit ea.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3290
                        ),
                        false,
                        3,
                        null,
                        4,
                    },
                    {
                        28,
                        6,
                        "Est sunt et sint dolor vitae non vero.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3309
                        ),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        29,
                        8,
                        "Odio et veritatis.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3331
                        ),
                        false,
                        2,
                        null,
                        2,
                    },
                    {
                        30,
                        6,
                        "Ut hic quia facilis in vitae sequi consequatur rerum.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3345
                        ),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        31,
                        9,
                        "Molestiae reiciendis et quia.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3369
                        ),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        32,
                        8,
                        "Sit et quia mollitia aut harum beatae.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3384
                        ),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        33,
                        13,
                        "Id dignissimos fugit sunt cum eveniet ut et ut.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3404
                        ),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        34,
                        11,
                        "Libero illum aliquam hic eligendi rem neque dolorem qui.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3461
                        ),
                        false,
                        5,
                        null,
                        2,
                    },
                    {
                        35,
                        18,
                        "Beatae voluptates sapiente quo laborum ipsam est voluptas.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3491
                        ),
                        false,
                        1,
                        null,
                        4,
                    },
                    {
                        36,
                        6,
                        "Doloremque fuga labore sit enim necessitatibus et ad reiciendis aut.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3514
                        ),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        37,
                        11,
                        "Porro consequatur rerum labore est.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3542
                        ),
                        false,
                        5,
                        null,
                        7,
                    },
                    {
                        38,
                        18,
                        "Molestias unde sit a occaecati praesentium beatae ab cupiditate.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3557
                        ),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        39,
                        6,
                        "Omnis delectus assumenda enim molestias quidem.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3583
                        ),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        40,
                        15,
                        "Magni aut dicta nemo enim.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3600
                        ),
                        false,
                        3,
                        null,
                        6,
                    },
                    {
                        41,
                        14,
                        "Libero quia minus.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3617
                        ),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        42,
                        6,
                        "Animi recusandae deserunt ea eos consequatur occaecati pariatur.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3658
                        ),
                        false,
                        5,
                        null,
                        5,
                    },
                    {
                        43,
                        11,
                        "Expedita cum rerum et ducimus ut harum.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3679
                        ),
                        false,
                        3,
                        null,
                        8,
                    },
                    {
                        44,
                        13,
                        "Voluptas dolores quaerat recusandae.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3698
                        ),
                        false,
                        5,
                        null,
                        2,
                    },
                    {
                        45,
                        6,
                        "Consectetur et vitae.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3712
                        ),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        46,
                        4,
                        "Et ipsam iste nobis non laboriosam sed atque sunt.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3725
                        ),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        47,
                        12,
                        "Iusto sit accusamus ut et voluptatem tenetur placeat.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3749
                        ),
                        false,
                        2,
                        null,
                        8,
                    },
                    {
                        48,
                        9,
                        "Reprehenderit aut repellendus exercitationem ad voluptatem enim dolores.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3770
                        ),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        49,
                        17,
                        "Asperiores suscipit nulla accusamus amet minima.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3793
                        ),
                        false,
                        4,
                        null,
                        3,
                    },
                    {
                        50,
                        8,
                        "Consequatur ex et repellat.",
                        new DateTime(2024, 10, 22, 20, 33, 31, 312, DateTimeKind.Utc).AddTicks(
                            3836
                        ),
                        false,
                        4,
                        null,
                        6,
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
                        12,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            7830
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        2,
                        19,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8064
                        ),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8071
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        4,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8074
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        14,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8077
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        6,
                        17,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8080
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        7,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8083
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        18,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8086
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        9,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8089
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        10,
                        3,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8092
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        11,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8095
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        12,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8097
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        13,
                        19,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8100
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        14,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8103
                        ),
                        false,
                        null,
                        5,
                    },
                    {
                        15,
                        15,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8106
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        16,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8109
                        ),
                        false,
                        null,
                        2,
                    },
                    {
                        17,
                        16,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8111
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        18,
                        13,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8114
                        ),
                        false,
                        null,
                        7,
                    },
                    {
                        19,
                        1,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8117
                        ),
                        false,
                        null,
                        5,
                    },
                    {
                        20,
                        8,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8120
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        21,
                        5,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8122
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        22,
                        3,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8125
                        ),
                        false,
                        null,
                        9,
                    },
                    {
                        23,
                        2,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8128
                        ),
                        false,
                        null,
                        4,
                    },
                    {
                        24,
                        15,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8131
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        25,
                        19,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8133
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        26,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8136
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        27,
                        9,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8139
                        ),
                        false,
                        null,
                        3,
                    },
                    {
                        28,
                        11,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8142
                        ),
                        false,
                        null,
                        8,
                    },
                    {
                        29,
                        14,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8145
                        ),
                        false,
                        null,
                        10,
                    },
                    {
                        30,
                        10,
                        new DateTime(2024, 10, 22, 20, 33, 31, 313, DateTimeKind.Utc).AddTicks(
                            8148
                        ),
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
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId"
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

            migrationBuilder.DropTable(name: "AspNetUsers");

            migrationBuilder.DropTable(name: "Authors");

            migrationBuilder.DropTable(name: "Publishers");
        }
    }
}
