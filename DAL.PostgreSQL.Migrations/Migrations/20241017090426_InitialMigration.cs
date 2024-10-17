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
                        "497a9e42-e9b8-4e5e-a822-e66c288d24c2",
                        "admin@admin.com",
                        true,
                        false,
                        null,
                        "Admin",
                        null,
                        "ADMIN",
                        "AQAAAAIAAYagAAAAEPD3CZvtC3tU+IO+QfcZwqj37a7eDD39GMiTQDb8UFphyyTwTR1B3mHXy8ROogAQZQ==",
                        "0123456987",
                        false,
                        "546ce559-6643-455b-90e8-c380be3dd6ef",
                        false,
                        "admin",
                    },
                    {
                        2,
                        0,
                        "a536b094-3446-48b8-bc4f-c08801dbdcf3",
                        "user@user.com",
                        true,
                        false,
                        null,
                        "Jonh Doe",
                        null,
                        "USER",
                        "AQAAAAIAAYagAAAAEK2E60c5e/+t+4ZJnojuxYY9BupfArERL4iKBLZ7LMxK/a0F2Vts3LvSsM+SQBAy7g==",
                        "0123456789",
                        false,
                        "30668007-221f-46d0-8d0d-8fd93bdd5365",
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
                        "Sunt nulla dignissimos optio expedita necessitatibus explicabo nesciunt. Quod enim sit est vel et est recusandae dolorum consequatur. Accusamus illo accusantium omnis est. Itaque in et expedita dolor.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 807, DateTimeKind.Utc).AddTicks(7021),
                        false,
                        "Guiseppe Bernhard",
                        null,
                    },
                    {
                        2,
                        "Quo vel et eum. Dolore ea explicabo totam quos omnis non autem possimus. Est sunt eligendi porro molestiae inventore earum. In qui aspernatur maiores labore tempora ex hic. Quisquam aut quam sed ut libero qui.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 807, DateTimeKind.Utc).AddTicks(7908),
                        false,
                        "Justen Kunde",
                        null,
                    },
                    {
                        3,
                        "Nulla excepturi cupiditate ratione. Recusandae et necessitatibus fugiat dolores quia praesentium necessitatibus. Tempora recusandae rem nisi magnam dolor debitis placeat est. Aut autem fuga saepe quaerat aut esse.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 807, DateTimeKind.Utc).AddTicks(8199),
                        false,
                        "Raleigh Schulist",
                        null,
                    },
                    {
                        4,
                        "Eveniet qui corporis dolorem reiciendis sit. Fugit in earum. Quibusdam vitae officiis pariatur ut quia autem repellendus eos.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 807, DateTimeKind.Utc).AddTicks(8628),
                        false,
                        "Forrest Walker",
                        null,
                    },
                    {
                        5,
                        "Suscipit blanditiis et. Incidunt facilis qui molestiae vitae incidunt repellendus. Officia iusto ratione enim alias animi rerum.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 808, DateTimeKind.Utc).AddTicks(663),
                        false,
                        "Hobart Braun",
                        null,
                    },
                    {
                        6,
                        "Fuga corporis expedita odio voluptatem. Veritatis totam officia accusantium vitae mollitia dolores. Delectus et aperiam veniam adipisci deserunt laudantium.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 808, DateTimeKind.Utc).AddTicks(742),
                        false,
                        "Conor Runolfsson",
                        null,
                    },
                    {
                        7,
                        "Modi minus magni fuga perferendis et. Sit est quis. Qui commodi praesentium est sequi voluptatem animi. Molestias et illum qui numquam rerum. Nesciunt sed praesentium facere doloremque.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 808, DateTimeKind.Utc).AddTicks(831),
                        false,
                        "Zane Pollich",
                        null,
                    },
                    {
                        8,
                        "Veritatis nesciunt quo incidunt eveniet perspiciatis corporis ea alias minima. Deleniti sunt iusto ducimus nulla esse qui et autem. Dicta quidem voluptatum. Et totam sed.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 808, DateTimeKind.Utc).AddTicks(981),
                        false,
                        "Kenyatta Morar",
                        null,
                    },
                    {
                        9,
                        "Provident nisi libero provident et praesentium aut ipsam est. Voluptatum quidem facilis modi consequatur exercitationem tenetur. Et est deleniti incidunt culpa. Molestias velit et quod natus id ullam.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 808, DateTimeKind.Utc).AddTicks(1114),
                        false,
                        "Queenie Hilll",
                        null,
                    },
                    {
                        10,
                        "Illo maiores sint et eum rem aspernatur aliquid iure. Ea eos porro id ut. In omnis sapiente non voluptatem dolore quam nulla numquam. Dicta velit amet nemo nisi iusto rerum quaerat ipsum. Atque vel recusandae ut.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 808, DateTimeKind.Utc).AddTicks(1228),
                        false,
                        "Layla Von",
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
                        "Beatae asperiores facere in alias occaecati quam. Laudantium porro cumque ipsum voluptatem autem aut. Minus omnis aliquid laborum.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 810, DateTimeKind.Utc).AddTicks(3186),
                        false,
                        "Walter - Schoen",
                        null,
                    },
                    {
                        2,
                        "Magnam veritatis voluptatibus ut aliquid quos dolores. Aperiam neque cupiditate aut et. Magni dolor facere voluptatum explicabo enim qui dolores ipsum.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 810, DateTimeKind.Utc).AddTicks(4024),
                        false,
                        "Toy - Gutkowski",
                        null,
                    },
                    {
                        3,
                        "Quasi facere laborum non provident sint fugiat natus. Sapiente dignissimos voluptatem quam pariatur. Est minus voluptatem debitis explicabo consequuntur.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 810, DateTimeKind.Utc).AddTicks(4267),
                        false,
                        "Homenick - Bradtke",
                        null,
                    },
                    {
                        4,
                        "Ea incidunt asperiores vel cumque est cupiditate. Iste aut et voluptates quis eum aut reiciendis. Quam similique reiciendis. Et nobis dolor qui et magni. Voluptatem animi sunt sed.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 810, DateTimeKind.Utc).AddTicks(4497),
                        false,
                        "Mohr, Rowe and Schaden",
                        null,
                    },
                    {
                        5,
                        "Aperiam laboriosam consectetur vitae nihil nam dolor. Quibusdam ut qui quibusdam voluptates in accusantium blanditiis eum ratione. Repudiandae quo harum esse ex voluptatem sed quasi. Sint voluptate esse dignissimos dolores non quia. Non nostrum porro in. Optio quia aut.",
                        new DateTime(2024, 10, 17, 9, 4, 25, 810, DateTimeKind.Utc).AddTicks(4735),
                        false,
                        "Kunde LLC",
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
                        5,
                        new DateTime(2024, 10, 17, 9, 4, 25, 812, DateTimeKind.Utc).AddTicks(7354),
                        3,
                        "https://picsum.photos/640/480/?image=845",
                        false,
                        33.67m,
                        2,
                        "Cum perspiciatis sit.",
                        null,
                    },
                    {
                        2,
                        7,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(328),
                        1,
                        "https://picsum.photos/640/480/?image=271",
                        false,
                        46.57m,
                        1,
                        "Vero hic repudiandae.",
                        null,
                    },
                    {
                        3,
                        4,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(529),
                        2,
                        "https://picsum.photos/640/480/?image=936",
                        false,
                        64.35m,
                        4,
                        "Et delectus similique.",
                        null,
                    },
                    {
                        4,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(572),
                        4,
                        "https://picsum.photos/640/480/?image=528",
                        false,
                        24.21m,
                        3,
                        "Consequuntur impedit qui.",
                        null,
                    },
                    {
                        5,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(608),
                        1,
                        "https://picsum.photos/640/480/?image=278",
                        false,
                        50.17m,
                        5,
                        "Quos ipsam aperiam.",
                        null,
                    },
                    {
                        6,
                        7,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(640),
                        0,
                        "https://picsum.photos/640/480/?image=835",
                        false,
                        72.99m,
                        2,
                        "Ex qui quam.",
                        null,
                    },
                    {
                        7,
                        4,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(731),
                        7,
                        "https://picsum.photos/640/480/?image=301",
                        false,
                        70.84m,
                        1,
                        "Iste porro eligendi.",
                        null,
                    },
                    {
                        8,
                        8,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(759),
                        2,
                        "https://picsum.photos/640/480/?image=815",
                        false,
                        82.02m,
                        5,
                        "Quia voluptate ab.",
                        null,
                    },
                    {
                        9,
                        7,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(791),
                        3,
                        "https://picsum.photos/640/480/?image=718",
                        false,
                        82.22m,
                        4,
                        "Id fugit sunt.",
                        null,
                    },
                    {
                        10,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(829),
                        6,
                        "https://picsum.photos/640/480/?image=188",
                        false,
                        97.99m,
                        5,
                        "Molestias corrupti quia.",
                        null,
                    },
                    {
                        11,
                        8,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(863),
                        7,
                        "https://picsum.photos/640/480/?image=944",
                        false,
                        33.23m,
                        2,
                        "Nostrum est eligendi.",
                        null,
                    },
                    {
                        12,
                        10,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(892),
                        2,
                        "https://picsum.photos/640/480/?image=792",
                        false,
                        73.72m,
                        2,
                        "Et amet dolor.",
                        null,
                    },
                    {
                        13,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(956),
                        6,
                        "https://picsum.photos/640/480/?image=499",
                        false,
                        18.23m,
                        5,
                        "Dolore dolor dolores.",
                        null,
                    },
                    {
                        14,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(984),
                        5,
                        "https://picsum.photos/640/480/?image=684",
                        false,
                        94.22m,
                        1,
                        "Consequatur repellat eos.",
                        null,
                    },
                    {
                        15,
                        4,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1015),
                        1,
                        "https://picsum.photos/640/480/?image=67",
                        false,
                        15.15m,
                        5,
                        "Fuga nihil cumque.",
                        null,
                    },
                    {
                        16,
                        1,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1043),
                        7,
                        "https://picsum.photos/640/480/?image=151",
                        false,
                        22.03m,
                        4,
                        "Aspernatur accusamus praesentium.",
                        null,
                    },
                    {
                        17,
                        8,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1075),
                        4,
                        "https://picsum.photos/640/480/?image=84",
                        false,
                        14.84m,
                        5,
                        "Voluptatem est vero.",
                        null,
                    },
                    {
                        18,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1104),
                        6,
                        "https://picsum.photos/640/480/?image=736",
                        false,
                        48.63m,
                        5,
                        "Blanditiis qui aspernatur.",
                        null,
                    },
                    {
                        19,
                        1,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1164),
                        8,
                        "https://picsum.photos/640/480/?image=50",
                        false,
                        55.68m,
                        1,
                        "Ut itaque expedita.",
                        null,
                    },
                    {
                        20,
                        4,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1194),
                        0,
                        "https://picsum.photos/640/480/?image=197",
                        false,
                        75.08m,
                        2,
                        "Quidem dolorum voluptatem.",
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
                        1,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1803),
                        false,
                        null,
                        1,
                    },
                    {
                        2,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1806),
                        false,
                        null,
                        2,
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
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1566),
                        "user@user.com",
                        "Jonh Doe",
                        false,
                        "123 Main St, City, Country",
                        916m,
                        null,
                        2,
                    },
                    {
                        2,
                        "123 Main St, City, Country",
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1579),
                        "user@user.com",
                        "Jonh Doe",
                        false,
                        "123 Main St, City, Country",
                        575m,
                        null,
                        2,
                    },
                    {
                        3,
                        "123 Main St, City, Country",
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1579),
                        "user@user.com",
                        "Jonh Doe",
                        false,
                        "123 Main St, City, Country",
                        993m,
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
                        14,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1707),
                        false,
                        1,
                        83m,
                        3,
                        null,
                    },
                    {
                        2,
                        5,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1714),
                        false,
                        1,
                        55m,
                        2,
                        null,
                    },
                    {
                        3,
                        20,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1715),
                        false,
                        1,
                        93m,
                        2,
                        null,
                    },
                    {
                        4,
                        15,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1716),
                        false,
                        1,
                        64m,
                        2,
                        null,
                    },
                    {
                        5,
                        15,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1717),
                        false,
                        1,
                        81m,
                        3,
                        null,
                    },
                    {
                        6,
                        8,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1720),
                        false,
                        2,
                        57m,
                        2,
                        null,
                    },
                    {
                        7,
                        13,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1721),
                        false,
                        2,
                        56m,
                        2,
                        null,
                    },
                    {
                        8,
                        9,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1722),
                        false,
                        2,
                        72m,
                        1,
                        null,
                    },
                    {
                        9,
                        12,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1723),
                        false,
                        2,
                        89m,
                        1,
                        null,
                    },
                    {
                        10,
                        10,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1724),
                        false,
                        2,
                        94m,
                        2,
                        null,
                    },
                    {
                        11,
                        3,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1725),
                        false,
                        3,
                        77m,
                        2,
                        null,
                    },
                    {
                        12,
                        13,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1726),
                        false,
                        3,
                        94m,
                        2,
                        null,
                    },
                    {
                        13,
                        11,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1727),
                        false,
                        3,
                        83m,
                        3,
                        null,
                    },
                    {
                        14,
                        19,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1728),
                        false,
                        3,
                        62m,
                        3,
                        null,
                    },
                    {
                        15,
                        5,
                        new DateTime(2024, 10, 17, 9, 4, 25, 813, DateTimeKind.Utc).AddTicks(1729),
                        false,
                        3,
                        72m,
                        3,
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
