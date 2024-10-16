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
                    OrderId = table.Column<int>(type: "integer", nullable: false),
                    BookId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
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
                        principalColumn: "Id"
                    );
                    table.ForeignKey(
                        name: "FK_CartItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
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
                        "fd6fc7dc-bda2-438a-9dde-0f7f73b3b506",
                        "admin@admin.com",
                        true,
                        false,
                        null,
                        "Admin",
                        null,
                        "ADMIN",
                        "AQAAAAIAAYagAAAAEHFEGk5lSP7kyKlEldAV6jaydzK+lIKYD5E+f3ceSSywyMTFV2ijWHTD7YDwlDA+Yg==",
                        "0123456987",
                        false,
                        "540237e7-8f09-462f-ae5f-5a928652b092",
                        false,
                        "admin",
                    },
                    {
                        2,
                        0,
                        "f8a31bd1-ff8b-44df-93eb-3153f6e1eb39",
                        "user@user.com",
                        true,
                        false,
                        null,
                        "Jonh Doe",
                        null,
                        "USER",
                        "AQAAAAIAAYagAAAAEHmDCBnN6QJSXns50B6+zQialmNHiXrwW6w+pEE0567QbELZT+ivcUWh0wAvl0xNrw==",
                        "0123456789",
                        false,
                        "b29bf609-c0a3-4961-a254-95be4aba6e22",
                        false,
                        "user",
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
                        "Aliquid eligendi deserunt quia molestiae expedita eveniet odio impedit. Inventore ipsa animi quo. Aut aut vel et autem ut iste optio. Dolores velit similique. Harum eaque aut ea eveniet. Blanditiis asperiores et aliquid in deleniti qui dolor sint.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            3846
                        ),
                        false,
                        "Kendall Moore",
                        null,
                    },
                    {
                        2,
                        "Debitis dignissimos id similique ut totam soluta accusamus. Deserunt nihil ut placeat laudantium reiciendis quis repellendus. Eos officiis consequuntur eligendi. Cumque blanditiis voluptatem eos.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            4550
                        ),
                        false,
                        "Henry Adams",
                        null,
                    },
                    {
                        3,
                        "Sit voluptas nesciunt id rerum. Perferendis non ipsum quibusdam ea provident ut provident temporibus nihil. At rerum vero aut vel impedit vitae magnam voluptatem expedita. Accusamus dolores nobis nemo. Sed praesentium repellendus.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            4694
                        ),
                        false,
                        "Leda Cruickshank",
                        null,
                    },
                    {
                        4,
                        "Quod velit iusto culpa corporis ducimus et dolores. Sint et ipsum. Possimus nulla illum totam natus et cumque.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            4953
                        ),
                        false,
                        "Eunice Kshlerin",
                        null,
                    },
                    {
                        5,
                        "Accusantium et nulla sint aspernatur reiciendis repudiandae ratione. Officiis deserunt molestiae reprehenderit autem dolore. Temporibus voluptatum sunt eveniet corporis ducimus. Possimus et saepe voluptatem eaque iure. Consectetur molestiae modi.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            5050
                        ),
                        false,
                        "Amara Schimmel",
                        null,
                    },
                    {
                        6,
                        "Dignissimos a ratione et consectetur maxime incidunt. Dignissimos velit eos. Vero in accusamus optio debitis et inventore asperiores exercitationem et. Voluptatem est sapiente non. Distinctio consequatur asperiores laudantium. Ullam est accusamus rerum in beatae iste sunt iste nihil.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            5143
                        ),
                        false,
                        "Luz Goodwin",
                        null,
                    },
                    {
                        7,
                        "Atque corporis impedit consequatur rem voluptatibus error. Quo eos voluptatibus fugiat. Quia voluptatem a. Est et facilis odit distinctio. Delectus soluta doloremque quo nostrum necessitatibus quisquam placeat id dolor. Consequuntur quia non.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            5284
                        ),
                        false,
                        "Elizabeth Schultz",
                        null,
                    },
                    {
                        8,
                        "Quia dignissimos natus et velit magni non minima et. Quaerat cum nisi. Reprehenderit tenetur illum sit provident autem et aliquam.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            5414
                        ),
                        false,
                        "Cassie Greenholt",
                        null,
                    },
                    {
                        9,
                        "Ea consequatur earum repellendus quis dignissimos voluptatum consequatur reprehenderit. Voluptatibus sed accusantium quae et. Eum dolores et at minima quos quia vero corporis. Esse dicta ratione ipsa consequatur similique. Beatae perferendis est saepe occaecati reiciendis fugit.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            5481
                        ),
                        false,
                        "Prudence Harris",
                        null,
                    },
                    {
                        10,
                        "Odit recusandae sit ipsum ipsum est cum doloremque illo soluta. Enim aliquam et molestiae et maxime. Quia est officia quia omnis aut qui et a repellendus. Non magni placeat quos aut est.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 164, DateTimeKind.Utc).AddTicks(
                            5646
                        ),
                        false,
                        "Garfield Wehner",
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
                        "Id culpa nemo nihil adipisci. Aliquid sed eos rerum autem aliquid hic eaque. Quidem natus tempore quia ut. Qui nobis non quisquam aperiam facilis omnis.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 166, DateTimeKind.Utc).AddTicks(
                            5616
                        ),
                        false,
                        "Davis Group",
                        null,
                    },
                    {
                        2,
                        "Beatae deleniti repudiandae blanditiis cum saepe iure. Labore et rem minima cum quia eum ipsa autem. Autem aliquid non ad. Laboriosam vitae labore perspiciatis quis voluptatem nam et eum.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 166, DateTimeKind.Utc).AddTicks(
                            6487
                        ),
                        false,
                        "O'Connell, Runte and Beier",
                        null,
                    },
                    {
                        3,
                        "Tempora qui consequuntur in. Veniam est aspernatur quibusdam. In quae itaque suscipit pariatur dolore sint.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 166, DateTimeKind.Utc).AddTicks(
                            6824
                        ),
                        false,
                        "Braun, DuBuque and Lehner",
                        null,
                    },
                    {
                        4,
                        "Ut et iste ut est et nesciunt. Consequatur laboriosam velit voluptas dolores itaque nam quia eos perspiciatis. Nostrum exercitationem quia accusantium ad est mollitia. Quis ipsam mollitia ea. Alias debitis perferendis iusto et est facere similique accusamus sed.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 166, DateTimeKind.Utc).AddTicks(
                            6987
                        ),
                        false,
                        "Kihn - Schiller",
                        null,
                    },
                    {
                        5,
                        "Sunt porro est sequi accusamus aut ut cumque eveniet. Perferendis totam in iure provident facilis qui nobis. Blanditiis quas numquam ut. Nihil voluptas consequatur porro consequuntur accusamus. Sequi aut quia autem expedita.",
                        new DateTime(2024, 10, 16, 11, 22, 45, 166, DateTimeKind.Utc).AddTicks(
                            7168
                        ),
                        false,
                        "Brown and Sons",
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
                        8,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            3283
                        ),
                        5,
                        "https://picsum.photos/640/480/?image=805",
                        false,
                        17.01m,
                        3,
                        "Iusto qui distinctio.",
                        null,
                    },
                    {
                        2,
                        2,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6127
                        ),
                        2,
                        "https://picsum.photos/640/480/?image=117",
                        false,
                        97.00m,
                        4,
                        "Est culpa porro.",
                        null,
                    },
                    {
                        3,
                        7,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6294
                        ),
                        6,
                        "https://picsum.photos/640/480/?image=547",
                        false,
                        84.61m,
                        2,
                        "Facere aspernatur quas.",
                        null,
                    },
                    {
                        4,
                        3,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6335
                        ),
                        6,
                        "https://picsum.photos/640/480/?image=141",
                        false,
                        97.14m,
                        3,
                        "Aliquid quis sunt.",
                        null,
                    },
                    {
                        5,
                        2,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6366
                        ),
                        8,
                        "https://picsum.photos/640/480/?image=754",
                        false,
                        32.77m,
                        3,
                        "Voluptatibus quos voluptatibus.",
                        null,
                    },
                    {
                        6,
                        8,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6397
                        ),
                        0,
                        "https://picsum.photos/640/480/?image=30",
                        false,
                        23.35m,
                        2,
                        "In est quis.",
                        null,
                    },
                    {
                        7,
                        3,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6423
                        ),
                        1,
                        "https://picsum.photos/640/480/?image=85",
                        false,
                        78.64m,
                        2,
                        "Quia earum quia.",
                        null,
                    },
                    {
                        8,
                        10,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6510
                        ),
                        1,
                        "https://picsum.photos/640/480/?image=631",
                        false,
                        55.94m,
                        1,
                        "Quia porro soluta.",
                        null,
                    },
                    {
                        9,
                        2,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6537
                        ),
                        6,
                        "https://picsum.photos/640/480/?image=391",
                        false,
                        44.61m,
                        3,
                        "Eveniet sunt hic.",
                        null,
                    },
                    {
                        10,
                        7,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6561
                        ),
                        7,
                        "https://picsum.photos/640/480/?image=789",
                        false,
                        94.47m,
                        3,
                        "Eos odio odio.",
                        null,
                    },
                    {
                        11,
                        3,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6587
                        ),
                        0,
                        "https://picsum.photos/640/480/?image=518",
                        false,
                        77.11m,
                        1,
                        "Enim ut dignissimos.",
                        null,
                    },
                    {
                        12,
                        2,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6614
                        ),
                        3,
                        "https://picsum.photos/640/480/?image=636",
                        false,
                        22.70m,
                        3,
                        "Adipisci hic praesentium.",
                        null,
                    },
                    {
                        13,
                        8,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6638
                        ),
                        6,
                        "https://picsum.photos/640/480/?image=369",
                        false,
                        49.63m,
                        4,
                        "Aut qui explicabo.",
                        null,
                    },
                    {
                        14,
                        9,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6698
                        ),
                        8,
                        "https://picsum.photos/640/480/?image=316",
                        false,
                        31.51m,
                        1,
                        "Minima et rem.",
                        null,
                    },
                    {
                        15,
                        8,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6725
                        ),
                        4,
                        "https://picsum.photos/640/480/?image=879",
                        false,
                        77.79m,
                        1,
                        "Ea consequatur quo.",
                        null,
                    },
                    {
                        16,
                        4,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6755
                        ),
                        0,
                        "https://picsum.photos/640/480/?image=679",
                        false,
                        78.90m,
                        3,
                        "Voluptatum incidunt qui.",
                        null,
                    },
                    {
                        17,
                        5,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6785
                        ),
                        1,
                        "https://picsum.photos/640/480/?image=1040",
                        false,
                        27.82m,
                        3,
                        "Cum et recusandae.",
                        null,
                    },
                    {
                        18,
                        6,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6814
                        ),
                        6,
                        "https://picsum.photos/640/480/?image=1064",
                        false,
                        59.64m,
                        2,
                        "Debitis libero corrupti.",
                        null,
                    },
                    {
                        19,
                        2,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6845
                        ),
                        3,
                        "https://picsum.photos/640/480/?image=785",
                        false,
                        46.81m,
                        1,
                        "Autem soluta sit.",
                        null,
                    },
                    {
                        20,
                        6,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            6869
                        ),
                        7,
                        "https://picsum.photos/640/480/?image=341",
                        false,
                        80.26m,
                        4,
                        "Deserunt temporibus aspernatur.",
                        null,
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
                        "123 Main St, City, Country",
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7246
                        ),
                        "user@user.com",
                        "Jonh Doe",
                        false,
                        "123 Main St, City, Country",
                        822m,
                        null,
                        2,
                    },
                    {
                        2,
                        "123 Main St, City, Country",
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7260
                        ),
                        "user@user.com",
                        "Jonh Doe",
                        false,
                        "123 Main St, City, Country",
                        622m,
                        null,
                        2,
                    },
                    {
                        3,
                        "123 Main St, City, Country",
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7260
                        ),
                        "user@user.com",
                        "Jonh Doe",
                        false,
                        "123 Main St, City, Country",
                        692m,
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
                        8,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7309
                        ),
                        false,
                        1,
                        93m,
                        1,
                        null,
                    },
                    {
                        2,
                        5,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7318
                        ),
                        false,
                        1,
                        57m,
                        3,
                        null,
                    },
                    {
                        3,
                        15,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7319
                        ),
                        false,
                        1,
                        81m,
                        3,
                        null,
                    },
                    {
                        4,
                        5,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7320
                        ),
                        false,
                        1,
                        84m,
                        3,
                        null,
                    },
                    {
                        5,
                        16,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7321
                        ),
                        false,
                        1,
                        63m,
                        1,
                        null,
                    },
                    {
                        6,
                        1,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7323
                        ),
                        false,
                        2,
                        71m,
                        3,
                        null,
                    },
                    {
                        7,
                        18,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7324
                        ),
                        false,
                        2,
                        56m,
                        1,
                        null,
                    },
                    {
                        8,
                        11,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7325
                        ),
                        false,
                        2,
                        91m,
                        1,
                        null,
                    },
                    {
                        9,
                        4,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7325
                        ),
                        false,
                        2,
                        58m,
                        3,
                        null,
                    },
                    {
                        10,
                        13,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7327
                        ),
                        false,
                        2,
                        88m,
                        1,
                        null,
                    },
                    {
                        11,
                        18,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7328
                        ),
                        false,
                        3,
                        67m,
                        3,
                        null,
                    },
                    {
                        12,
                        13,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7329
                        ),
                        false,
                        3,
                        56m,
                        2,
                        null,
                    },
                    {
                        13,
                        4,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7329
                        ),
                        false,
                        3,
                        76m,
                        2,
                        null,
                    },
                    {
                        14,
                        4,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7330
                        ),
                        false,
                        3,
                        66m,
                        2,
                        null,
                    },
                    {
                        15,
                        2,
                        new DateTime(2024, 10, 16, 11, 22, 45, 168, DateTimeKind.Utc).AddTicks(
                            7331
                        ),
                        false,
                        3,
                        95m,
                        1,
                        null,
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
                name: "IX_CartItems_OrderId",
                table: "CartItems",
                column: "OrderId"
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
