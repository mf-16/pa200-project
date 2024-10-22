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
                    DataInitializer = table.Column<string>(type: "text", nullable: false),
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
                        "cac187ae-7426-430d-aa2f-4315c402daa3",
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
                        "e40af3f6-131b-4505-8fef-84eda667596f",
                        false,
                        "admin",
                    },
                    {
                        2,
                        0,
                        "b4811c10-f2b3-457f-84ce-f2c1784b3206",
                        "Alyce41@yahoo.com",
                        true,
                        false,
                        null,
                        "Sierra Murphy",
                        null,
                        null,
                        null,
                        "823-535-3817 x4621",
                        false,
                        "d4bc2f24-25c2-4d3d-bc7c-699919364bd3",
                        false,
                        "Anika.Gerlach23",
                    },
                    {
                        3,
                        0,
                        "fa80490b-d570-442b-bf72-a7a29f6446f4",
                        "Elenor.Wolf16@yahoo.com",
                        true,
                        false,
                        null,
                        "Reva Jenkins",
                        null,
                        null,
                        null,
                        "(345) 694-6572",
                        false,
                        "48354627-cbd5-4279-89e1-e13189be5c42",
                        false,
                        "Xzavier.Terry17",
                    },
                    {
                        4,
                        0,
                        "a0f96fc7-e824-411f-bbaf-f539174a7018",
                        "Leon.Blanda@gmail.com",
                        true,
                        false,
                        null,
                        "Alverta Wisozk",
                        null,
                        null,
                        null,
                        "919.436.7920 x7862",
                        false,
                        "3e8e1518-e978-4d50-9d6b-2ed5e2298e06",
                        false,
                        "Rhett98",
                    },
                    {
                        5,
                        0,
                        "64139188-44bb-4805-8f58-e89fa992ce1f",
                        "Ellen_Harris32@yahoo.com",
                        true,
                        false,
                        null,
                        "Cynthia O'Reilly",
                        null,
                        null,
                        null,
                        "337-983-6669 x70592",
                        false,
                        "61cf847f-554b-4691-b931-682e69f0e452",
                        false,
                        "Edwardo_Auer21",
                    },
                    {
                        6,
                        0,
                        "9b357afe-39a4-4af6-bb9a-42bf7c039207",
                        "Leola_Nader62@yahoo.com",
                        true,
                        false,
                        null,
                        "Leonel Stanton",
                        null,
                        null,
                        null,
                        "1-944-279-9259 x4518",
                        false,
                        "be14a8fe-f90d-4b3d-9355-ecb7b9edf5ec",
                        false,
                        "Demetris25",
                    },
                    {
                        7,
                        0,
                        "c921a3fb-f283-4bbd-82aa-c41bffb59e19",
                        "Melyna_Koss30@hotmail.com",
                        true,
                        false,
                        null,
                        "Emilie Jaskolski",
                        null,
                        null,
                        null,
                        "957.629.8529 x45633",
                        false,
                        "b1e7b8ad-5360-4c34-b3b0-984c08a1d33c",
                        false,
                        "Melissa.OHara16",
                    },
                    {
                        8,
                        0,
                        "42cd9ead-ca31-4728-b12c-de871bd2290a",
                        "Verda_Mills@yahoo.com",
                        true,
                        false,
                        null,
                        "Destany Streich",
                        null,
                        null,
                        null,
                        "445-440-3246 x30222",
                        false,
                        "6375b327-0a7b-4b48-91be-a109d1291e08",
                        false,
                        "Flavie_Jacobi",
                    },
                    {
                        9,
                        0,
                        "93a29b58-ca50-4187-8097-b6f5d8f6aa5f",
                        "Callie64@hotmail.com",
                        true,
                        false,
                        null,
                        "Leif Goyette",
                        null,
                        null,
                        null,
                        "667.701.5633 x0789",
                        false,
                        "1b2efbb9-43ef-4f8e-a3ef-68bebd62fee7",
                        false,
                        "Wendy.Zulauf80",
                    },
                    {
                        10,
                        0,
                        "bb7bf59a-2bb9-4818-be65-101d950004fd",
                        "Rosamond_Littel37@yahoo.com",
                        true,
                        false,
                        null,
                        "Pansy Nader",
                        null,
                        null,
                        null,
                        "(552) 304-8903 x6107",
                        false,
                        "52fc2eb7-653b-4c44-a93f-0fb94a046bb9",
                        false,
                        "Marlon_Orn",
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
                        "At ut quia magni sunt doloribus excepturi. Exercitationem ducimus numquam. Odio fugiat voluptatum et tenetur molestiae aut at eveniet voluptatibus.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(2709),
                        false,
                        "Ron Bins",
                        null,
                    },
                    {
                        2,
                        "Quis ad non ex quaerat corporis voluptatum modi mollitia. Qui velit nemo distinctio. Explicabo explicabo iusto aut voluptates adipisci rem.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3023),
                        false,
                        "Florence Halvorson",
                        null,
                    },
                    {
                        3,
                        "Voluptatem fuga odit cupiditate dolore. Vitae delectus quod consequatur nemo suscipit excepturi nisi libero maiores. Id voluptatum at dolor libero eveniet vero minima et doloribus. Consequatur fugiat tenetur laudantium aut tempore esse.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3149),
                        false,
                        "Noble Blanda",
                        null,
                    },
                    {
                        4,
                        "Molestiae minus modi quia dolore et fugiat. Eligendi vel sint ea rem eligendi sit est. Dolores optio velit et quisquam corrupti minima laudantium. Sit eos natus impedit vel nemo tenetur illo rerum est. Quia laboriosam consequatur voluptate sed quo repellendus eveniet perspiciatis.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3257),
                        false,
                        "Pink Jacobs",
                        null,
                    },
                    {
                        5,
                        "Saepe quia nam ut in aut. Explicabo aspernatur ipsum repellat consectetur itaque. Esse pariatur voluptas sequi nobis cupiditate ipsa cum eaque. Ex et ut nobis rerum minus impedit voluptatibus illo. Voluptatibus qui fuga dolor rem laudantium nemo earum. Quia cum adipisci quae veritatis quos accusantium consequatur.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3432),
                        false,
                        "Gonzalo Morar",
                        null,
                    },
                    {
                        6,
                        "Possimus libero omnis. Numquam voluptatem occaecati fugiat voluptatem consequatur cumque numquam omnis mollitia. Odio occaecati est vel odio. Modi repellat minima aut sed aut ducimus sint voluptas. Et accusamus expedita nesciunt et eveniet ad sapiente rerum. Cumque id pariatur.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3603),
                        false,
                        "Chasity Brekke",
                        null,
                    },
                    {
                        7,
                        "Iusto explicabo enim voluptatem dolor. Totam velit aperiam voluptate. Itaque inventore repellat. Ut ad aut reprehenderit.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3751),
                        false,
                        "Ellie Rogahn",
                        null,
                    },
                    {
                        8,
                        "Hic est ad est. Aut dolorem rem ipsam velit occaecati omnis sint. Ab aut suscipit qui repellat esse fugit laudantium aut itaque. Et et expedita incidunt nesciunt sit doloremque atque.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3814),
                        false,
                        "Lindsey Reynolds",
                        null,
                    },
                    {
                        9,
                        "Ullam quia quo. Tempora expedita nesciunt repellat facilis modi. Temporibus qui minima molestiae tempore. Et deleniti officia ratione dolor voluptas sit molestiae iste aspernatur. Non quod voluptatem est voluptatum quia.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(3909),
                        false,
                        "Sandra Langosh",
                        null,
                    },
                    {
                        10,
                        "Quam est nobis quos quia. Sit qui molestiae aut sit voluptatibus aliquid optio qui. Ea excepturi veritatis quasi labore libero pariatur reprehenderit qui.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 931, DateTimeKind.Utc).AddTicks(4031),
                        false,
                        "Rosanna Goodwin",
                        null,
                    },
                }
            );

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[]
                {
                    "Id",
                    "Bio",
                    "CreatedDate",
                    "DataInitializer",
                    "IsDeleted",
                    "UpdatedDate",
                },
                values: new object[,]
                {
                    {
                        1,
                        "Eum est vel non deleniti. Nihil libero debitis. Expedita non laborum hic. Praesentium voluptatem sed doloremque. Dicta laborum quo est ratione quia voluptas odio ullam aut. Ut quos consequuntur et qui libero vero et optio aut.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 932, DateTimeKind.Utc).AddTicks(6631),
                        "Carter Inc",
                        false,
                        null,
                    },
                    {
                        2,
                        "Quasi mollitia optio architecto reiciendis nostrum et non. Aperiam earum in commodi quae blanditiis. Porro ut dolores asperiores ullam earum sed aperiam. Necessitatibus exercitationem consequatur.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 932, DateTimeKind.Utc).AddTicks(7291),
                        "Gutmann, Hoeger and Okuneva",
                        false,
                        null,
                    },
                    {
                        3,
                        "Quia iste dolor aliquam. Exercitationem et illo vero et et. Est sapiente sed qui labore sapiente. Culpa adipisci doloremque.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 932, DateTimeKind.Utc).AddTicks(7513),
                        "Kiehn and Sons",
                        false,
                        null,
                    },
                    {
                        4,
                        "Aut delectus et enim facere eaque assumenda quo hic esse. Tempore natus est delectus soluta officiis. Voluptatem at temporibus vero perferendis perferendis deserunt debitis officiis quibusdam.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 932, DateTimeKind.Utc).AddTicks(7692),
                        "Schiller, Schoen and Fay",
                        false,
                        null,
                    },
                    {
                        5,
                        "Blanditiis id ut qui consequatur et quo aliquid aliquam quasi. Qui hic nostrum sed. Odio numquam vel possimus iure consequuntur adipisci saepe eum unde. Velit inventore aut qui. Neque soluta sunt est. Delectus et illo temporibus aut.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 932, DateTimeKind.Utc).AddTicks(7869),
                        "Crona, Purdy and Hodkiewicz",
                        false,
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
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(1083),
                        7,
                        "https://picsum.photos/640/480/?image=662",
                        false,
                        27.35m,
                        2,
                        "Voluptate neque culpa.",
                        null,
                    },
                    {
                        2,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3453),
                        7,
                        "https://picsum.photos/640/480/?image=642",
                        false,
                        44.74m,
                        1,
                        "Quam sit aut.",
                        null,
                    },
                    {
                        3,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3597),
                        2,
                        "https://picsum.photos/640/480/?image=510",
                        false,
                        69.69m,
                        2,
                        "Aliquid qui qui.",
                        null,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3631),
                        4,
                        "https://picsum.photos/640/480/?image=799",
                        false,
                        54.31m,
                        4,
                        "Blanditiis alias dolorem.",
                        null,
                    },
                    {
                        5,
                        10,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3659),
                        0,
                        "https://picsum.photos/640/480/?image=607",
                        false,
                        24.06m,
                        5,
                        "Aut molestias laboriosam.",
                        null,
                    },
                    {
                        6,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3752),
                        7,
                        "https://picsum.photos/640/480/?image=60",
                        false,
                        13.43m,
                        3,
                        "Dolorem aliquid libero.",
                        null,
                    },
                    {
                        7,
                        3,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3779),
                        3,
                        "https://picsum.photos/640/480/?image=586",
                        false,
                        92.24m,
                        5,
                        "Deleniti sed et.",
                        null,
                    },
                    {
                        8,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3804),
                        7,
                        "https://picsum.photos/640/480/?image=668",
                        false,
                        39.08m,
                        3,
                        "Impedit accusantium quia.",
                        null,
                    },
                    {
                        9,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3827),
                        4,
                        "https://picsum.photos/640/480/?image=927",
                        false,
                        35.64m,
                        3,
                        "Ipsa quidem iusto.",
                        null,
                    },
                    {
                        10,
                        8,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3852),
                        2,
                        "https://picsum.photos/640/480/?image=197",
                        false,
                        40.61m,
                        3,
                        "Autem et illum.",
                        null,
                    },
                    {
                        11,
                        2,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3878),
                        3,
                        "https://picsum.photos/640/480/?image=277",
                        false,
                        37.81m,
                        4,
                        "Commodi odio enim.",
                        null,
                    },
                    {
                        12,
                        3,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3932),
                        4,
                        "https://picsum.photos/640/480/?image=379",
                        false,
                        85.35m,
                        1,
                        "Totam fuga corporis.",
                        null,
                    },
                    {
                        13,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3957),
                        6,
                        "https://picsum.photos/640/480/?image=759",
                        false,
                        51.32m,
                        5,
                        "Ea quos sit.",
                        null,
                    },
                    {
                        14,
                        6,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(3980),
                        4,
                        "https://picsum.photos/640/480/?image=958",
                        false,
                        97.50m,
                        2,
                        "Ex nemo et.",
                        null,
                    },
                    {
                        15,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(4004),
                        5,
                        "https://picsum.photos/640/480/?image=468",
                        false,
                        95.62m,
                        5,
                        "A velit beatae.",
                        null,
                    },
                    {
                        16,
                        8,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(4031),
                        6,
                        "https://picsum.photos/640/480/?image=635",
                        false,
                        56.65m,
                        4,
                        "Atque accusantium adipisci.",
                        null,
                    },
                    {
                        17,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(4055),
                        4,
                        "https://picsum.photos/640/480/?image=507",
                        false,
                        12.01m,
                        3,
                        "Voluptatibus totam similique.",
                        null,
                    },
                    {
                        18,
                        2,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(4111),
                        4,
                        "https://picsum.photos/640/480/?image=618",
                        false,
                        21.41m,
                        2,
                        "Et voluptatum voluptas.",
                        null,
                    },
                    {
                        19,
                        2,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(4137),
                        2,
                        "https://picsum.photos/640/480/?image=462",
                        false,
                        74.60m,
                        3,
                        "Magnam omnis accusantium.",
                        null,
                    },
                    {
                        20,
                        2,
                        new DateTime(2024, 10, 19, 6, 46, 36, 934, DateTimeKind.Utc).AddTicks(4162),
                        1,
                        "https://picsum.photos/640/480/?image=1028",
                        false,
                        34.84m,
                        5,
                        "Omnis error aut.",
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
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(39),
                        false,
                        null,
                        2,
                    },
                    {
                        3,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(40),
                        false,
                        null,
                        3,
                    },
                    {
                        4,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(41),
                        false,
                        null,
                        4,
                    },
                    {
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(41),
                        false,
                        null,
                        5,
                    },
                    {
                        6,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(41),
                        false,
                        null,
                        6,
                    },
                    {
                        7,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(41),
                        false,
                        null,
                        7,
                    },
                    {
                        8,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(42),
                        false,
                        null,
                        8,
                    },
                    {
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(42),
                        false,
                        null,
                        9,
                    },
                    {
                        10,
                        new DateTime(2024, 10, 19, 6, 46, 36, 942, DateTimeKind.Utc).AddTicks(42),
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
                        "443 Deckow Loaf, North Alethaburgh, Equatorial Guinea",
                        new DateTime(2024, 10, 19, 6, 46, 36, 938, DateTimeKind.Utc).AddTicks(7451),
                        "Elsie_Effertz1@hotmail.com",
                        "Elsie Effertz",
                        false,
                        "92916 Caleigh Drive, Sheridanside, Libyan Arab Jamahiriya",
                        0m,
                        null,
                        10,
                    },
                    {
                        2,
                        "396 Dangelo Fort, Bauchmouth, Comoros",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(1384),
                        "Casey.Moen26@hotmail.com",
                        "Casey Moen",
                        false,
                        "3697 Schumm Pine, Lake Preston, Somalia",
                        0m,
                        null,
                        5,
                    },
                    {
                        3,
                        "38200 Pacocha Forge, Lake Luciofort, Tokelau",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(2702),
                        "Bradley_Schulist@hotmail.com",
                        "Bradley Schulist",
                        false,
                        "785 McGlynn Mills, Haskelltown, Haiti",
                        0m,
                        null,
                        2,
                    },
                    {
                        4,
                        "882 Arianna Estate, Jastchester, Algeria",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(3728),
                        "Cesar.Bogan87@hotmail.com",
                        "Cesar Bogan",
                        false,
                        "996 Morissette Center, West Maida, Belize",
                        0m,
                        null,
                        8,
                    },
                    {
                        5,
                        "39566 Boehm Land, Trompmouth, Dominica",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(4702),
                        "Michele.Marvin90@gmail.com",
                        "Michele Marvin",
                        false,
                        "119 VonRueden Streets, East Marisaborough, Nepal",
                        0m,
                        null,
                        7,
                    },
                    {
                        6,
                        "4773 Corrine Hills, Boyerburgh, Bahrain",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(5591),
                        "Lynn19@hotmail.com",
                        "Lynn Satterfield",
                        false,
                        "24600 Hammes Highway, New Caylafort, South Africa",
                        0m,
                        null,
                        2,
                    },
                    {
                        7,
                        "57966 Douglas Locks, Lake Vergie, Mexico",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(6565),
                        "Carl50@yahoo.com",
                        "Carl Smitham",
                        false,
                        "3162 Monique Dale, Lake Robintown, Czech Republic",
                        0m,
                        null,
                        7,
                    },
                    {
                        8,
                        "2192 Randi Village, West Perrytown, Virgin Islands, U.S.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(7519),
                        "Jake.Treutel19@gmail.com",
                        "Jake Treutel",
                        false,
                        "022 Carole Alley, North Elishaland, Nigeria",
                        0m,
                        null,
                        3,
                    },
                    {
                        9,
                        "69365 Maryjane Drives, East Ansel, Dominican Republic",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(8441),
                        "Lucia1@yahoo.com",
                        "Lucia Abbott",
                        false,
                        "0317 Tito Walks, South Maximilianville, Pakistan",
                        0m,
                        null,
                        5,
                    },
                    {
                        10,
                        "209 Schultz Overpass, South Phyllisborough, Mongolia",
                        new DateTime(2024, 10, 19, 6, 46, 36, 939, DateTimeKind.Utc).AddTicks(9366),
                        "Phil_Dietrich16@hotmail.com",
                        "Phil Dietrich",
                        false,
                        "9495 Wisoky Hill, Gutmannborough, Jordan",
                        0m,
                        null,
                        5,
                    },
                    {
                        11,
                        "2607 Breitenberg Junctions, Lake Allybury, Guinea",
                        new DateTime(2024, 10, 19, 6, 46, 36, 940, DateTimeKind.Utc).AddTicks(305),
                        "Lynn_Beahan@hotmail.com",
                        "Lynn Beahan",
                        false,
                        "67442 Rachelle Freeway, Port Adolfo, Brazil",
                        0m,
                        null,
                        10,
                    },
                    {
                        12,
                        "83417 Kessler Stravenue, Kochside, Poland",
                        new DateTime(2024, 10, 19, 6, 46, 36, 940, DateTimeKind.Utc).AddTicks(1229),
                        "Jordan41@gmail.com",
                        "Jordan Schroeder",
                        false,
                        "99430 Cory Burgs, East Lenoraburgh, Hong Kong",
                        0m,
                        null,
                        8,
                    },
                    {
                        13,
                        "609 Brenden Spurs, Schneiderburgh, Aruba",
                        new DateTime(2024, 10, 19, 6, 46, 36, 940, DateTimeKind.Utc).AddTicks(2112),
                        "Rickey27@gmail.com",
                        "Rickey Bednar",
                        false,
                        "38672 Micah Wells, Parkerbury, Lesotho",
                        0m,
                        null,
                        5,
                    },
                    {
                        14,
                        "725 Leuschke Wall, South Hailey, Austria",
                        new DateTime(2024, 10, 19, 6, 46, 36, 940, DateTimeKind.Utc).AddTicks(3050),
                        "Michael13@gmail.com",
                        "Michael Boyle",
                        false,
                        "89230 Dorothea Points, Lake Madeline, Panama",
                        0m,
                        null,
                        10,
                    },
                    {
                        15,
                        "8447 Lebsack Neck, Pollichshire, New Zealand",
                        new DateTime(2024, 10, 19, 6, 46, 36, 940, DateTimeKind.Utc).AddTicks(3943),
                        "Madeline_Gibson2@hotmail.com",
                        "Madeline Gibson",
                        false,
                        "641 Gerhold Canyon, Hansenbury, Canada",
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
                        13,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(8168),
                        false,
                        4,
                        20.92m,
                        3,
                        null,
                    },
                    {
                        2,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9382),
                        false,
                        3,
                        98.13m,
                        1,
                        null,
                    },
                    {
                        3,
                        3,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9431),
                        false,
                        14,
                        35.97m,
                        1,
                        null,
                    },
                    {
                        4,
                        3,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9442),
                        false,
                        4,
                        70.59m,
                        1,
                        null,
                    },
                    {
                        5,
                        16,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9449),
                        false,
                        11,
                        33.11m,
                        2,
                        null,
                    },
                    {
                        6,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9456),
                        false,
                        4,
                        12.25m,
                        1,
                        null,
                    },
                    {
                        7,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9463),
                        false,
                        10,
                        17.04m,
                        1,
                        null,
                    },
                    {
                        8,
                        12,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9471),
                        false,
                        8,
                        55.12m,
                        3,
                        null,
                    },
                    {
                        9,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9528),
                        false,
                        11,
                        50.65m,
                        3,
                        null,
                    },
                    {
                        10,
                        7,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9536),
                        false,
                        2,
                        55.69m,
                        2,
                        null,
                    },
                    {
                        11,
                        20,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9543),
                        false,
                        2,
                        44.86m,
                        2,
                        null,
                    },
                    {
                        12,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9550),
                        false,
                        9,
                        77.60m,
                        2,
                        null,
                    },
                    {
                        13,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9557),
                        false,
                        13,
                        70.66m,
                        2,
                        null,
                    },
                    {
                        14,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9565),
                        false,
                        2,
                        56.50m,
                        3,
                        null,
                    },
                    {
                        15,
                        20,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9572),
                        false,
                        14,
                        25.74m,
                        2,
                        null,
                    },
                    {
                        16,
                        11,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9579),
                        false,
                        1,
                        62.13m,
                        1,
                        null,
                    },
                    {
                        17,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9586),
                        false,
                        8,
                        86.43m,
                        3,
                        null,
                    },
                    {
                        18,
                        19,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9593),
                        false,
                        12,
                        28.62m,
                        3,
                        null,
                    },
                    {
                        19,
                        10,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9600),
                        false,
                        9,
                        33.07m,
                        3,
                        null,
                    },
                    {
                        20,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9613),
                        false,
                        12,
                        14.50m,
                        1,
                        null,
                    },
                    {
                        21,
                        14,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9619),
                        false,
                        9,
                        13.99m,
                        1,
                        null,
                    },
                    {
                        22,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9626),
                        false,
                        2,
                        36.54m,
                        1,
                        null,
                    },
                    {
                        23,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9633),
                        false,
                        8,
                        99.15m,
                        1,
                        null,
                    },
                    {
                        24,
                        19,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9640),
                        false,
                        1,
                        69.51m,
                        2,
                        null,
                    },
                    {
                        25,
                        7,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9647),
                        false,
                        8,
                        72.42m,
                        1,
                        null,
                    },
                    {
                        26,
                        17,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9653),
                        false,
                        7,
                        63.03m,
                        2,
                        null,
                    },
                    {
                        27,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9660),
                        false,
                        2,
                        67.42m,
                        2,
                        null,
                    },
                    {
                        28,
                        12,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9667),
                        false,
                        10,
                        73.01m,
                        2,
                        null,
                    },
                    {
                        29,
                        11,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9674),
                        false,
                        6,
                        18.60m,
                        1,
                        null,
                    },
                    {
                        30,
                        4,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9681),
                        false,
                        14,
                        96.91m,
                        2,
                        null,
                    },
                    {
                        31,
                        11,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9688),
                        false,
                        12,
                        24.12m,
                        2,
                        null,
                    },
                    {
                        32,
                        13,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9695),
                        false,
                        6,
                        51.82m,
                        1,
                        null,
                    },
                    {
                        33,
                        12,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9702),
                        false,
                        2,
                        60.93m,
                        1,
                        null,
                    },
                    {
                        34,
                        14,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9709),
                        false,
                        11,
                        14.05m,
                        3,
                        null,
                    },
                    {
                        35,
                        3,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9715),
                        false,
                        14,
                        72.74m,
                        2,
                        null,
                    },
                    {
                        36,
                        11,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9722),
                        false,
                        14,
                        11.88m,
                        1,
                        null,
                    },
                    {
                        37,
                        7,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9729),
                        false,
                        4,
                        16.13m,
                        3,
                        null,
                    },
                    {
                        38,
                        19,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9736),
                        false,
                        6,
                        64.59m,
                        2,
                        null,
                    },
                    {
                        39,
                        6,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9742),
                        false,
                        1,
                        95.24m,
                        1,
                        null,
                    },
                    {
                        40,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9749),
                        false,
                        15,
                        79.74m,
                        1,
                        null,
                    },
                    {
                        41,
                        13,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9787),
                        false,
                        4,
                        48.49m,
                        1,
                        null,
                    },
                    {
                        42,
                        16,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9795),
                        false,
                        1,
                        89.31m,
                        3,
                        null,
                    },
                    {
                        43,
                        7,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9802),
                        false,
                        2,
                        10.10m,
                        1,
                        null,
                    },
                    {
                        44,
                        2,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9809),
                        false,
                        4,
                        11.79m,
                        1,
                        null,
                    },
                    {
                        45,
                        17,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9816),
                        false,
                        3,
                        20.36m,
                        1,
                        null,
                    },
                    {
                        46,
                        18,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9823),
                        false,
                        5,
                        65.14m,
                        3,
                        null,
                    },
                    {
                        47,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9830),
                        false,
                        3,
                        47.03m,
                        2,
                        null,
                    },
                    {
                        48,
                        16,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9837),
                        false,
                        7,
                        23.98m,
                        1,
                        null,
                    },
                    {
                        49,
                        12,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9844),
                        false,
                        9,
                        12.52m,
                        3,
                        null,
                    },
                    {
                        50,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 941, DateTimeKind.Utc).AddTicks(9855),
                        false,
                        13,
                        56.36m,
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
                        3,
                        "Veniam accusantium occaecati et fugiat labore laudantium ipsam rerum.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(7481),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        2,
                        14,
                        "Voluptas earum deserunt et laudantium reprehenderit.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8642),
                        false,
                        3,
                        null,
                        2,
                    },
                    {
                        3,
                        15,
                        "Quia quia dolorum ab molestiae vero aliquid et.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8712),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        4,
                        17,
                        "Voluptatem quaerat qui aut aspernatur et aut deleniti impedit fuga.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8742),
                        false,
                        4,
                        null,
                        5,
                    },
                    {
                        5,
                        9,
                        "Officiis earum consequatur.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8771),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        6,
                        7,
                        "Quia reiciendis quasi saepe in et commodi error eveniet.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8783),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        7,
                        4,
                        "Corporis qui eos voluptas nemo sed.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8808),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        8,
                        17,
                        "Et aliquam aspernatur vitae.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8826),
                        false,
                        5,
                        null,
                        3,
                    },
                    {
                        9,
                        9,
                        "Recusandae at eum hic voluptatibus earum ipsa aut vel.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8840),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        10,
                        4,
                        "Porro voluptas nemo aliquam illum modi adipisci exercitationem.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8910),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        11,
                        7,
                        "Enim ut veniam pariatur sequi.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8933),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        12,
                        10,
                        "Velit perferendis exercitationem ducimus numquam magnam.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8954),
                        false,
                        2,
                        null,
                        8,
                    },
                    {
                        13,
                        2,
                        "Non necessitatibus repudiandae optio vitae.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8971),
                        false,
                        1,
                        null,
                        8,
                    },
                    {
                        14,
                        8,
                        "Incidunt hic dolorem asperiores illo tempora.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(8989),
                        false,
                        4,
                        null,
                        6,
                    },
                    {
                        15,
                        16,
                        "Et laudantium nobis deserunt nesciunt qui placeat quidem.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9005),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        16,
                        12,
                        "Molestiae praesentium temporibus reiciendis officia molestias enim.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9031),
                        false,
                        5,
                        null,
                        6,
                    },
                    {
                        17,
                        11,
                        "Exercitationem est provident omnis voluptatem odit.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9084),
                        false,
                        1,
                        null,
                        3,
                    },
                    {
                        18,
                        1,
                        "Fuga ad expedita.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9107),
                        false,
                        5,
                        null,
                        10,
                    },
                    {
                        19,
                        3,
                        "Eligendi ut aut magni odio consequatur vitae.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9119),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        20,
                        6,
                        "Exercitationem dolores molestiae debitis possimus reprehenderit est eos.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9139),
                        false,
                        2,
                        null,
                        3,
                    },
                    {
                        21,
                        13,
                        "Mollitia sit velit in.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9161),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        22,
                        11,
                        "Voluptatem numquam dolorem non officiis assumenda delectus labore repudiandae voluptates.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9175),
                        false,
                        4,
                        null,
                        8,
                    },
                    {
                        23,
                        2,
                        "Adipisci voluptatem corporis rem et porro est.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9200),
                        false,
                        5,
                        null,
                        4,
                    },
                    {
                        24,
                        7,
                        "In quos recusandae dolor.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9220),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        25,
                        2,
                        "Adipisci voluptatem animi doloribus est.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9251),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        26,
                        12,
                        "Facilis qui cumque officiis reprehenderit vel minus et autem mollitia.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9272),
                        false,
                        5,
                        null,
                        5,
                    },
                    {
                        27,
                        9,
                        "Provident vel voluptas ut quidem earum omnis.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9296),
                        false,
                        2,
                        null,
                        7,
                    },
                    {
                        28,
                        19,
                        "Quis aut non beatae tempora fugit fugit.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9317),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        29,
                        19,
                        "Ducimus accusantium repellat.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9340),
                        false,
                        3,
                        null,
                        7,
                    },
                    {
                        30,
                        8,
                        "Corporis quia voluptate esse vero aspernatur error libero praesentium.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9352),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        31,
                        10,
                        "Laudantium aspernatur odio.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9374),
                        false,
                        3,
                        null,
                        3,
                    },
                    {
                        32,
                        20,
                        "Necessitatibus earum dolore architecto ut id aspernatur ad voluptatibus.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9386),
                        false,
                        4,
                        null,
                        9,
                    },
                    {
                        33,
                        11,
                        "Iure deleniti corporis neque qui enim deserunt pariatur ut rem.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9490),
                        false,
                        4,
                        null,
                        2,
                    },
                    {
                        34,
                        1,
                        "Sint nulla tempore dolor quibusdam nam sit odit sapiente odio.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9514),
                        false,
                        4,
                        null,
                        7,
                    },
                    {
                        35,
                        7,
                        "Mollitia aperiam ex quae.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9541),
                        false,
                        1,
                        null,
                        9,
                    },
                    {
                        36,
                        19,
                        "Porro eius sapiente rerum rerum quis debitis sit laboriosam.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9554),
                        false,
                        3,
                        null,
                        5,
                    },
                    {
                        37,
                        12,
                        "Illo ut et nam tempore praesentium quam expedita id.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9579),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        38,
                        12,
                        "Ut voluptas eligendi.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9602),
                        false,
                        3,
                        null,
                        9,
                    },
                    {
                        39,
                        9,
                        "Distinctio magni at adipisci.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9614),
                        false,
                        2,
                        null,
                        4,
                    },
                    {
                        40,
                        19,
                        "Dolorem omnis fugit harum voluptas voluptas doloribus qui.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9665),
                        false,
                        5,
                        null,
                        8,
                    },
                    {
                        41,
                        15,
                        "Autem pariatur repellat sed.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9689),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        42,
                        12,
                        "Quis dolorem vel.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9703),
                        false,
                        1,
                        null,
                        6,
                    },
                    {
                        43,
                        19,
                        "Consequatur consequuntur rerum ea similique et autem qui ut molestiae.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9716),
                        false,
                        3,
                        null,
                        10,
                    },
                    {
                        44,
                        8,
                        "Maiores vitae possimus deserunt nemo repudiandae incidunt autem.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9743),
                        false,
                        5,
                        null,
                        5,
                    },
                    {
                        45,
                        4,
                        "Magnam nisi quis fuga consequatur.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9765),
                        false,
                        2,
                        null,
                        5,
                    },
                    {
                        46,
                        16,
                        "Reprehenderit et natus consectetur molestiae laudantium.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9783),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        47,
                        13,
                        "Et nostrum qui mollitia ratione ut placeat animi vel ab.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9802),
                        false,
                        1,
                        null,
                        5,
                    },
                    {
                        48,
                        17,
                        "Maxime animi mollitia consequuntur fugiat reprehenderit neque.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9854),
                        false,
                        5,
                        null,
                        9,
                    },
                    {
                        49,
                        15,
                        "Sed molestiae vitae et.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9876),
                        false,
                        1,
                        null,
                        10,
                    },
                    {
                        50,
                        18,
                        "Quia accusantium occaecati nesciunt.",
                        new DateTime(2024, 10, 19, 6, 46, 36, 935, DateTimeKind.Utc).AddTicks(9890),
                        false,
                        2,
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
                        14,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3630),
                        false,
                        null,
                        7,
                    },
                    {
                        2,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3780),
                        false,
                        null,
                        10,
                    },
                    {
                        3,
                        7,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3787),
                        false,
                        null,
                        4,
                    },
                    {
                        4,
                        13,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3791),
                        false,
                        null,
                        9,
                    },
                    {
                        5,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3794),
                        false,
                        null,
                        7,
                    },
                    {
                        6,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3797),
                        false,
                        null,
                        3,
                    },
                    {
                        7,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3800),
                        false,
                        null,
                        9,
                    },
                    {
                        8,
                        6,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3803),
                        false,
                        null,
                        6,
                    },
                    {
                        9,
                        14,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3806),
                        false,
                        null,
                        6,
                    },
                    {
                        10,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3808),
                        false,
                        null,
                        8,
                    },
                    {
                        11,
                        13,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3811),
                        false,
                        null,
                        6,
                    },
                    {
                        12,
                        5,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3814),
                        false,
                        null,
                        9,
                    },
                    {
                        13,
                        18,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3868),
                        false,
                        null,
                        10,
                    },
                    {
                        14,
                        8,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3871),
                        false,
                        null,
                        10,
                    },
                    {
                        15,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3875),
                        false,
                        null,
                        3,
                    },
                    {
                        16,
                        1,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3878),
                        false,
                        null,
                        3,
                    },
                    {
                        17,
                        13,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3881),
                        false,
                        null,
                        7,
                    },
                    {
                        18,
                        12,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3884),
                        false,
                        null,
                        7,
                    },
                    {
                        19,
                        18,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3887),
                        false,
                        null,
                        10,
                    },
                    {
                        20,
                        4,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3890),
                        false,
                        null,
                        2,
                    },
                    {
                        21,
                        20,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3893),
                        false,
                        null,
                        6,
                    },
                    {
                        22,
                        9,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3896),
                        false,
                        null,
                        8,
                    },
                    {
                        23,
                        20,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3898),
                        false,
                        null,
                        5,
                    },
                    {
                        24,
                        17,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3901),
                        false,
                        null,
                        4,
                    },
                    {
                        25,
                        2,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3904),
                        false,
                        null,
                        8,
                    },
                    {
                        26,
                        15,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3907),
                        false,
                        null,
                        7,
                    },
                    {
                        27,
                        18,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3910),
                        false,
                        null,
                        10,
                    },
                    {
                        28,
                        16,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3912),
                        false,
                        null,
                        10,
                    },
                    {
                        29,
                        16,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3915),
                        false,
                        null,
                        9,
                    },
                    {
                        30,
                        17,
                        new DateTime(2024, 10, 19, 6, 46, 36, 937, DateTimeKind.Utc).AddTicks(3918),
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

            migrationBuilder.CreateIndex(name: "IX_Carts_UserId", table: "Carts", column: "UserId");

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
