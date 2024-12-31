using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.PostgreSQL.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddCouponsToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Rey",
                    "Taiwan",
                    new DateTime(2024, 12, 31, 16, 5, 52, 808, DateTimeKind.Utc).AddTicks(8919),
                    "North Carolina",
                    "4539 Angela Branch",
                    "34549",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Swiftborough",
                    "Equatorial Guinea",
                    new DateTime(2024, 12, 31, 16, 5, 52, 808, DateTimeKind.Utc).AddTicks(9544),
                    "Maine",
                    "90835 Zoey Expressway",
                    "05210",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Mandyborough",
                    "Aruba",
                    new DateTime(2024, 12, 31, 16, 5, 52, 808, DateTimeKind.Utc).AddTicks(9706),
                    "Colorado",
                    "4801 Schoen Meadow",
                    "34236-1217",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Konopelskiton",
                    "Fiji",
                    new DateTime(2024, 12, 31, 16, 5, 52, 808, DateTimeKind.Utc).AddTicks(9867),
                    "Indiana",
                    "16944 Johnson Locks",
                    "35192",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Sabrynahaven",
                    "Tokelau",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(3),
                    "Kentucky",
                    "8639 Torp Centers",
                    "64516",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Javier",
                    "Christmas Island",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(137),
                    "South Dakota",
                    "09329 Lora Village",
                    "76038-9652",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Haven",
                    "Central African Republic",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(260),
                    "New Mexico",
                    "157 Herman Ports",
                    "30621",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Keeblershire",
                    "Solomon Islands",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(435),
                    "Oklahoma",
                    "14015 Hosea Brooks",
                    "42175-8359",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Ludwigville",
                    "Faroe Islands",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(575),
                    "South Carolina",
                    "9690 Floy Station",
                    "91850",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Layla",
                    "Haiti",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(713),
                    "Arizona",
                    "6062 Wayne Groves",
                    "57610",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Astridtown",
                    "Cayman Islands",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(848),
                    "Mississippi",
                    "554 Waters Fields",
                    "02980",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Coyport",
                    "Iceland",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(975),
                    "Montana",
                    "4225 Gina Cliffs",
                    "45189",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Quintonview",
                    "Jordan",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(1098),
                    "Arizona",
                    "5029 Hansen Groves",
                    "58277",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Lake Shanna",
                    "Senegal",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(1252),
                    "Texas",
                    "84534 Torphy Grove",
                    "38611-2534",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Doylebury",
                    "Cook Islands",
                    new DateTime(2024, 12, 31, 16, 5, 52, 809, DateTimeKind.Utc).AddTicks(1370),
                    "Tennessee",
                    "991 Nils Squares",
                    "07728",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[]
                {
                    "9ee16a7f-157d-4654-b929-4587f61d4530",
                    "0ee536f6-121b-4649-ae0f-429419ebb7f1",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "2d85fd13-c2ab-4e12-bca2-351bc611b782",
                    "Ewell86@gmail.com",
                    "Moshe Schuppe",
                    "(755) 561-1356",
                    "05232e17-cb97-4bcb-977b-f45df2f28c55",
                    "Ewell86@gmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "e9866e20-b10a-4578-ba9c-1e7ea1603a3b",
                    "Trey4@yahoo.com",
                    "Treva Mitchell",
                    "827.431.4181 x14365",
                    "eacfb3f8-9d67-4412-a8d1-16639db58ada",
                    "Trey4@yahoo.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "1eeec576-758b-4431-abb3-1ab05b858604",
                    "Retha_OHara94@hotmail.com",
                    "Christ Heaney",
                    "1-751-914-6343 x1339",
                    "e2af5278-2017-4dcf-b867-55a0e6c1dbe3",
                    "Retha_OHara94@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "c32a1abe-3eee-414f-888e-52c1948c5edc",
                    "Tristin_Reichel@yahoo.com",
                    "Kennedy Fadel",
                    "(430) 541-1355",
                    "113b6fa9-7f15-40f5-8eaf-e7a3e35cc50a",
                    "Tristin_Reichel@yahoo.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "378dbe6b-b784-45a4-9096-3f0e3f1ef13c",
                    "Jany.Kreiger68@hotmail.com",
                    "Ewell Jacobs",
                    "1-535-603-9863 x5389",
                    "41e9f400-b244-4fb6-ac63-bf203f5ee9b0",
                    "Jany.Kreiger68@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "31390a34-afdf-4dd9-ac24-1945af6f0106",
                    "Burnice51@yahoo.com",
                    "Melisa Moore",
                    "(866) 554-5138",
                    "ab5f194f-16b9-43c4-9368-7708c536b0ac",
                    "Burnice51@yahoo.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "13c09a6c-102a-417d-8087-6e946f43643b",
                    "Damien87@yahoo.com",
                    "Manley Kassulke",
                    "(473) 977-6017",
                    "9ad762b3-d134-4814-aaa3-5be2ffce50d5",
                    "Damien87@yahoo.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "4fd4441b-a9c9-4e52-a596-65da73162d25",
                    "Eleanore.Schuster97@hotmail.com",
                    "Myron Roob",
                    "388-506-8018 x34952",
                    "7e4934ea-f359-40b0-bd4d-0f49c599ac08",
                    "Eleanore.Schuster97@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "669ed16d-e249-4072-a3ad-76ab22a8fe14",
                    "Jasen25@hotmail.com",
                    "Torrey Runolfsson",
                    "404-344-2984",
                    "43007d7e-d960-4e0b-a4af-12b9ba7677a6",
                    "Jasen25@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Iste dicta ipsum odit eaque voluptatum et. Dolorem ad est odio ipsum sint odit sed est. Et quidem eos minima perspiciatis placeat dignissimos deserunt doloremque. Et doloremque culpa quia ut eum. Illo rerum libero et et voluptas animi qui. Aliquid est adipisci maxime similique.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(1742),
                    "Tremaine Zboncak",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Pariatur quidem modi sapiente et vel hic et. Voluptatibus repellat recusandae magnam. Est et est enim tempora illo est molestias sed quo.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2208),
                    "Brian Schaden",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Voluptatem ea ea neque. Quia rem quia cum. Atque at neque.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2400),
                    "Lillie Stehr",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Odio fugiat molestiae quia reiciendis fugiat qui. Nisi hic vel neque eius. Quas ut aut. Qui eaque possimus ut cum sint suscipit. Voluptate enim necessitatibus eos inventore nisi quos asperiores.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2458),
                    "Cyrus Schaden",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Ut libero enim quia voluptatibus nam. Optio quas minima nihil ad id dolore. Laboriosam aut aut vel placeat aut et atque saepe. Esse similique expedita assumenda dolore ullam.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2561),
                    "Thea Stroman",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Amet corporis exercitationem fugit. Quas quia dolor dicta et. Blanditiis ratione distinctio enim et asperiores maxime qui voluptatem et. Velit consequuntur deserunt dolor eveniet ipsam nostrum atque tenetur. Asperiores rerum libero nesciunt. Occaecati aut accusamus ea aut quos quam non praesentium.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2689),
                    "Nyasia Rowe",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Qui quo sapiente fugit tempora sint praesentium quod commodi. Quis molestiae suscipit libero. Dignissimos rerum officiis ex officia exercitationem. Dolores natus sapiente. Reiciendis numquam et ipsam vero et autem ipsum totam. Voluptatem nam accusantium et.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2849),
                    "Damon Fritsch",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Voluptate nobis quas. Aspernatur sunt est ea dolor impedit. Quae blanditiis ab. Suscipit doloribus qui quae et omnis repellendus.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(2954),
                    "Edwardo Strosin",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Tempora molestiae velit aliquam modi. Ad impedit officia est fugit optio atque. Sed est aperiam atque commodi. Est possimus aliquid omnis qui et doloribus atque. Eaque sit quo quia qui et reiciendis. Molestiae totam expedita ullam ducimus cupiditate rerum odit.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(3049),
                    "Parker Shanahan",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Cumque excepturi doloribus earum. Quia libero aut exercitationem maiores iste ad quo sint. Laborum sint iusto et dolorem aut repellendus placeat necessitatibus. Velit doloremque aut qui dolores quo explicabo quia. Facere quas voluptatibus optio occaecati omnis rerum dicta.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 800, DateTimeKind.Utc).AddTicks(3178),
                    "Norwood Deckow",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 803, DateTimeKind.Utc).AddTicks(7289),
                    "Enim dolores veritatis voluptas voluptas optio excepturi. Atque asperiores facilis rem non beatae quis aliquid exercitationem. Dolores voluptatibus est harum molestias tempore quasi possimus alias neque. Quo culpa aliquid vitae atque amet quod totam. Consectetur pariatur culpa. Sed ex omnis aspernatur voluptates vel.",
                    "/images/cover-9.jpg",
                    13.86m,
                    3,
                    2,
                    "Hic in beatae.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 16, 5, 52, 803, DateTimeKind.Utc).AddTicks(9420),
                    "Voluptatem occaecati sapiente voluptatum amet distinctio fugiat dolor consequuntur. Repellendus odio fugit ea. Esse autem dolores consectetur sit voluptate debitis. Aliquam explicabo voluptas sapiente repellat sint ut qui quo. Occaecati accusamus occaecati. Minima sequi sed numquam placeat.",
                    "/images/cover-8.jpg",
                    71.48m,
                    5,
                    5,
                    "Doloribus pariatur nulla.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 803, DateTimeKind.Utc).AddTicks(9631),
                    "Quia et suscipit dolore voluptates et unde voluptas perspiciatis aut. Voluptas ut et maxime. Libero error ut quasi. Deserunt non sed ipsam velit beatae cupiditate nobis eveniet. Porro quo id veniam deserunt.",
                    "/images/cover-9.jpg",
                    43.41m,
                    7,
                    "Dolorem blanditiis ut.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 16, 5, 52, 803, DateTimeKind.Utc).AddTicks(9854),
                    "Aperiam modi alias omnis officiis deserunt vel dolores ea. Quibusdam qui facere iure illo praesentium saepe quo. Architecto libero suscipit illum quos at temporibus voluptatem qui quis. Provident id quisquam earum voluptas cumque amet. Eius rerum et repellendus non quaerat culpa molestiae ut.",
                    "/images/cover-6.jpg",
                    87.18m,
                    4,
                    1,
                    "Eligendi ea omnis.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(66),
                    "Non natus tenetur tempore fuga fuga dignissimos. Quasi nesciunt ratione nostrum aut eos. Reprehenderit nam blanditiis consequuntur minus tenetur qui neque quia. Tempore voluptatem sunt quas voluptas. Reprehenderit nihil quasi culpa minus praesentium earum praesentium cupiditate quia. Totam maxime et est dolor et repellat voluptatem perferendis.",
                    "/images/cover-9.jpg",
                    11.83m,
                    4,
                    3,
                    "Dolorem non dicta.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(238),
                    "Accusamus ipsa consectetur. Doloribus omnis tempore unde quia voluptatem est sapiente consequatur veritatis. Eos dignissimos ut eos aut quasi consequatur. Doloremque veniam voluptatum accusamus reiciendis cum odit aut expedita.",
                    "/images/cover-1.jpg",
                    98.46m,
                    5,
                    4,
                    "Cupiditate qui dicta.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(339),
                    "Et iste ipsum blanditiis perspiciatis libero qui totam rerum voluptas. Qui ipsum omnis cum corrupti quia architecto aperiam reiciendis non. Aut voluptatem rerum itaque vero qui asperiores saepe sequi. Neque molestiae consequatur fuga sit.",
                    "/images/cover-5.jpg",
                    58.30m,
                    1,
                    5,
                    "Tempora ut est.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(475),
                    "Veniam quia quibusdam et non voluptatum. Adipisci est aut voluptatem placeat. Quis blanditiis omnis voluptas rem dolores voluptas voluptas unde. Dolorem a voluptates voluptate. At sit distinctio et error.",
                    "/images/cover-3.jpg",
                    82.02m,
                    "Placeat dolorum ex.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(599),
                    "Doloribus aspernatur suscipit cupiditate tempore aut dolore. Molestias rerum architecto consectetur omnis est dolores. Placeat cum quasi maxime officiis dolor ea rerum voluptatem. Nulla laudantium perspiciatis architecto sunt repellendus.",
                    "/images/cover-7.jpg",
                    95.70m,
                    5,
                    "Officia corporis perspiciatis.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(685),
                    "Quaerat quo tempore. Quas enim voluptas. Velit ut sed alias nulla alias voluptatem voluptatem sequi possimus. Aliquam molestiae quo natus rem.",
                    "/images/cover-3.jpg",
                    98.27m,
                    2,
                    5,
                    "Laborum maiores labore.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(783),
                    "Ut placeat deserunt exercitationem. Sit ad debitis omnis sint. Doloribus laboriosam non officiis et quisquam nihil.",
                    "/images/cover-10.jpg",
                    45.89m,
                    6,
                    4,
                    "Aut impedit illum.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(845),
                    "Minus hic autem repellat. Qui qui inventore enim recusandae est neque qui et molestias. Numquam aliquid asperiores velit doloribus.",
                    "/images/cover-4.jpg",
                    35.83m,
                    7,
                    1,
                    "Autem corrupti optio.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(940),
                    "Voluptatibus nostrum fugit culpa. Ex minima accusamus porro distinctio corrupti ea tempora voluptatem quae. Vel odio voluptatem similique libero delectus consequatur. Fugit consequatur reiciendis aut neque voluptatem sint architecto voluptates. Ut voluptatem neque voluptatem cum nisi assumenda quo.",
                    "/images/cover-5.jpg",
                    96.49m,
                    3,
                    3,
                    "Accusamus ipsam blanditiis.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1062),
                    "Exercitationem quia doloremque sed. In nam alias. Officia voluptatem molestias doloribus quia qui sed a aut. Quisquam sit hic enim voluptatibus sunt alias qui non beatae. Nisi sapiente dolor eveniet.",
                    61.35m,
                    6,
                    "Deleniti laboriosam dicta.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1148),
                    "Quam eum omnis totam. Occaecati mollitia dignissimos possimus vel autem voluptas natus fuga. Veniam sint enim dolor amet ea officiis. Error quis nihil reprehenderit ullam error et qui sit. Ut eos eligendi blanditiis. Rem totam dolor deserunt doloribus.",
                    "/images/cover-4.jpg",
                    38.22m,
                    "A consectetur illo.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1366),
                    "Delectus qui expedita aut. Velit aut velit dolorum dolores vel. Provident exercitationem id eum aut optio eius ipsa. Aut voluptatem provident dolor. Minima voluptates doloremque enim dolorum rerum est et.",
                    "/images/cover-10.jpg",
                    37.01m,
                    6,
                    "Ducimus aliquid optio.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1496),
                    "Omnis explicabo maxime est ut. Reprehenderit reiciendis eligendi facere quia nihil non accusantium aliquid delectus. Est earum illum voluptates aut officia sit.",
                    "/images/cover-2.jpg",
                    33.54m,
                    4,
                    4,
                    "Enim tempora aliquam.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[]
                {
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1563),
                    "Aliquam et sed sint aut. Et id corporis voluptatum odit esse provident nihil est dolorum. Commodi doloremque voluptatum eum. Sapiente debitis nisi unde suscipit eos aspernatur ea molestiae voluptatem. Est deserunt odit dicta distinctio quia odit libero ut molestias.",
                    "/images/cover-5.jpg",
                    37.22m,
                    7,
                    3,
                    "Eos officia similique.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1690),
                    "Voluptatem quia non velit corrupti nihil aut ipsa qui quis. Aut quam natus soluta odio qui consequatur dolorem tempore repellendus. Quos beatae aspernatur error ipsa est laborum quas omnis. Impedit voluptatem voluptatem commodi nobis rem nam et.",
                    "/images/cover-7.jpg",
                    87.62m,
                    4,
                    2,
                    "Asperiores nihil velit.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 804, DateTimeKind.Utc).AddTicks(1814),
                    "Deleniti ad accusantium ducimus voluptatibus. Maiores consequuntur doloribus eos aut repellendus delectus quam officiis iste. Beatae dolores repellendus dolores aliquam provident quia. Sit dolore quaerat voluptatem magni esse doloremque. Nam dolorem ipsam consequuntur.",
                    "/images/cover-6.jpg",
                    81.51m,
                    6,
                    2,
                    "Quo nemo qui.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2421)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2422)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2423)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2423)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2423)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2424)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2424)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2424)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2425)
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(283),
                    9,
                    92.45m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1696),
                    7,
                    60.69m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1745),
                    14,
                    63.07m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1757),
                    9,
                    19.51m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1766),
                    71.60m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1775),
                    26.51m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1783),
                    10,
                    12.56m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1791),
                    8,
                    88.36m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1800),
                    12,
                    56.64m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1809),
                    11,
                    27.80m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1817),
                    7,
                    54.38m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1825),
                    1,
                    29.22m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1833),
                    2,
                    56.73m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1840),
                    12,
                    24.93m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1849),
                    14,
                    65.87m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1857),
                    13,
                    47.52m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1866),
                    10,
                    10.01m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1875),
                    14,
                    34.51m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1883),
                    14,
                    88.98m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1963),
                    5,
                    59.95m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1972),
                    8,
                    63.46m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1980),
                    15,
                    62.89m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1988),
                    5,
                    84.86m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(1995),
                    11,
                    89.22m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2004),
                    10,
                    41.69m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2012),
                    2,
                    96.39m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2020),
                    5,
                    31.07m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2028),
                    1,
                    29.66m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2037),
                    2,
                    33.58m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2045),
                    11,
                    66.42m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2053),
                    14,
                    98.94m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2061),
                    99.04m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2069),
                    12,
                    52.55m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2077),
                    10,
                    70.42m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2085),
                    4,
                    89.15m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2093),
                    15,
                    17.34m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2101),
                    12,
                    48.00m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2110),
                    15,
                    23.45m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2118),
                    4,
                    85.70m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2125),
                    35.72m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2133),
                    11,
                    90.86m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2141),
                    1,
                    97.44m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2149),
                    15,
                    31.57m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2157),
                    10,
                    48.61m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2164),
                    3,
                    82.28m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2172),
                    15,
                    74.11m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2180),
                    8,
                    91.27m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2188),
                    14,
                    89.12m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2196),
                    3,
                    14.74m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 16, 5, 52, 815, DateTimeKind.Utc).AddTicks(2204),
                    99.47m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 810, DateTimeKind.Utc).AddTicks(5940),
                    "Richard_Funk@yahoo.com",
                    "Richard Funk",
                    4,
                    11,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(342),
                    "Terrence.Steuber@gmail.com",
                    "Terrence Steuber",
                    3,
                    5,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(2047),
                    "Darlene_Reilly@hotmail.com",
                    "Darlene Reilly",
                    5,
                    10,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(2823),
                    "Lydia.Carroll78@hotmail.com",
                    "Lydia Carroll",
                    10,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(3636),
                    "Peggy85@gmail.com",
                    "Peggy Jerde",
                    3,
                    9,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(4272),
                    "Mildred_Pacocha@yahoo.com",
                    "Mildred Pacocha",
                    4,
                    7,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(4812),
                    "Saul_Schaefer29@hotmail.com",
                    "Saul Schaefer",
                    1,
                    3,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "UserId",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(5411),
                    "Nicole_White@hotmail.com",
                    "Nicole White",
                    2,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(5948),
                    "Ivan0@yahoo.com",
                    "Ivan Schaefer",
                    1,
                    14,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(6441),
                    "Sheila_McCullough86@hotmail.com",
                    "Sheila McCullough",
                    0,
                    1,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(7011),
                    "Shari.Toy43@gmail.com",
                    "Shari Toy",
                    10,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(7501),
                    "Rafael.Littel@gmail.com",
                    "Rafael Littel",
                    4,
                    14,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(8008),
                    "Terrance49@hotmail.com",
                    "Terrance Hilpert",
                    1,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(8526),
                    "Alberta78@gmail.com",
                    "Alberta Hamill",
                    4,
                    6,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 811, DateTimeKind.Utc).AddTicks(9103),
                    "Cecelia.DAmore95@hotmail.com",
                    "Cecelia D'Amore",
                    5,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quis cupiditate tempore omnis aut esse quia debitis. Fugit ipsum et omnis aut nostrum doloribus. Tempore veniam et quis. Voluptatem voluptatum commodi dicta omnis ipsam reprehenderit eos id.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 801, DateTimeKind.Utc).AddTicks(9871),
                    "Reilly Inc",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Doloremque modi beatae ratione voluptatem soluta fugit dicta quis qui. Delectus et id quasi vitae dignissimos inventore pariatur. Sequi corrupti est maxime qui amet omnis et placeat ab. Minima maxime voluptatibus et aut sit. Ut quisquam possimus voluptatem hic facere eius. Optio blanditiis tenetur vero.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 802, DateTimeKind.Utc).AddTicks(697),
                    "Ebert, Kuvalis and Kunde",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Et impedit fugiat nesciunt officia dolorum laudantium nam nobis. Sunt explicabo sunt dolor. Repellat in perferendis rerum unde fugiat quia.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 802, DateTimeKind.Utc).AddTicks(1001),
                    "Mayer - Prosacco",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Omnis doloribus libero est ut quis. Non consectetur aliquam et ut. Id fugiat assumenda excepturi. Quaerat fugiat debitis expedita fugiat aut sunt porro. Eum quia maiores.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 802, DateTimeKind.Utc).AddTicks(1147),
                    "Witting, Pfannerstill and Stanton",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Consectetur delectus maiores nisi consectetur aspernatur ducimus saepe ut libero. Ut et pariatur ex. Placeat ex exercitationem et. Repellendus molestiae quis nobis eligendi sint voluptas eos aspernatur nemo. Ipsa velit aut quis veniam occaecati. Ea asperiores consequatur natus aut nam explicabo autem exercitationem.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 802, DateTimeKind.Utc).AddTicks(1361),
                    "Lind - Kautzer",
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Cum quia accusantium asperiores nostrum ut dolorem.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(8489),
                    5,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Cumque eos quidem maxime ipsam cum aliquam rerum.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9648),
                    5,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    10,
                    "Sed quis ea facere qui doloribus qui sit aliquam architecto.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9735),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    10,
                    "Quis dignissimos consequatur cum omnis illum consequatur ut dolores.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9773),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "Quos ullam corporis quaerat at at et quis.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9803),
                    3,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Neque facere iusto tenetur aut.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9832),
                    4,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    "Non et fugiat eum delectus.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9854),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Voluptatum sit esse omnis libero est praesentium.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9875),
                    2,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Libero in delectus aliquid voluptatum quas fugiat et placeat.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9961),
                    2,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    "Quia omnis eveniet beatae itaque eius nemo necessitatibus.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 805, DateTimeKind.Utc).AddTicks(9988),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    14,
                    "Voluptatem voluptatibus repellat ut omnis odio quis.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(16),
                    3,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Illo qui ut.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(39),
                    3,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Velit aut fugiat aut quod.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(57),
                    3,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Suscipit fugit dolor totam iste rerum illo et.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(75),
                    2,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    4,
                    "Placeat autem esse excepturi hic.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(101),
                    2,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "Id vel veniam exercitationem recusandae beatae saepe cumque.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(119),
                    2,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Sequi autem modi quod.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(174),
                    3,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Maxime sed error voluptas sed commodi voluptatem laboriosam.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(189),
                    3,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    4,
                    "Sunt tenetur quae.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(218),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    16,
                    "Ipsam excepturi est alias consequatur ut.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(234),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Esse vitae id aut.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(253),
                    3,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "Harum maxime magni quaerat quod.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(270),
                    4,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Accusamus molestias rerum velit atque nostrum explicabo fugit.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(288),
                    3,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Voluptatem eveniet sed fuga qui non atque adipisci in quia.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(314),
                    1,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Sit quidem quam et perferendis aperiam perspiciatis distinctio.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(340),
                    2,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Voluptate et dolores impedit illo doloribus quos consectetur voluptatem sunt.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(396),
                    5,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    "Fugiat fugit ipsa doloribus corrupti saepe.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(427),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Expedita sit et porro minus dolorem et eveniet sunt voluptas.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(448),
                    1,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    6,
                    "Minus qui et amet et aut est velit ea.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(475),
                    1,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    16,
                    "Sit dolores molestiae odit.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(502),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Et tenetur et odio recusandae non maxime impedit ea voluptatem.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(518),
                    5,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    13,
                    "Dolorem tempore enim.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(542),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    10,
                    "Temporibus error voluptatem repellendus explicabo doloremque omnis sapiente repellendus.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(586),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    8,
                    "Quia molestias laudantium nihil asperiores rerum laborum.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(614),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Sunt soluta qui eveniet blanditiis laborum nisi voluptatem placeat ut.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(640),
                    2,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Quae quisquam ea ut dignissimos.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(667),
                    1,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Vel dolores dolorem odit earum quam et corrupti amet quia.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(684),
                    1,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    6,
                    "Qui deserunt neque sed culpa dolorem pariatur.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(709),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Optio enim quis laborum consequatur voluptatem.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(730),
                    3,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    2,
                    "Mollitia ab et laborum esse corrupti.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(766),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    20,
                    "In fuga perferendis inventore eum est laborum vitae et.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(785),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Ipsum at voluptatibus atque accusamus.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(809),
                    1,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    3,
                    "Ad ut sed culpa voluptatibus sunt.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(826),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Nam ipsam atque eum velit omnis ipsa fugiat perferendis assumenda.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(844),
                    1,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Necessitatibus veniam qui reprehenderit in et.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(868),
                    3,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    7,
                    "Nihil natus earum.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(886),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Veniam veritatis quia quae vero doloribus id excepturi nemo earum.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(900),
                    5,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    "Incidunt consequatur dolorem voluptas perspiciatis non necessitatibus quia voluptatibus.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(1022),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Ipsum similique autem repudiandae.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(1046),
                    5,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    14,
                    "Nam laborum quis fugit libero totam.",
                    new DateTime(2024, 12, 31, 16, 5, 52, 806, DateTimeKind.Utc).AddTicks(1066),
                    5,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(4987),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5142),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5148),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5152),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5155),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5158),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5161),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5164),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5168),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5171),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5174),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5177),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5180),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5183),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5186),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5189),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5192),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5195),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5199),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5201),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5205),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5208),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5211),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5214),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5217),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5220),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5223),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5226),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5229),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 16, 5, 52, 807, DateTimeKind.Utc).AddTicks(5232),
                    9,
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "South Wayne",
                    "Mali",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(6388),
                    "Maine",
                    "05794 Collier Points",
                    "90637",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Boganstad",
                    "Barbados",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(7482),
                    "Louisiana",
                    "16005 Lang Viaduct",
                    "75442",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Jasminland",
                    "Tuvalu",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(7667),
                    "Arkansas",
                    "44885 Autumn Villages",
                    "53039",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Karlee",
                    "Thailand",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(7810),
                    "Utah",
                    "8121 Zieme Prairie",
                    "16433-7525",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Ardithberg",
                    "Kazakhstan",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8019),
                    "Tennessee",
                    "4809 Jaida Park",
                    "14574-5488",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Vernice",
                    "Somalia",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8169),
                    "Idaho",
                    "90145 Lois Road",
                    "00137-3022",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Danielle",
                    "Finland",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8273),
                    "Virginia",
                    "11589 Evert Motorway",
                    "80084",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Alec",
                    "Cote d'Ivoire",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8407),
                    "Colorado",
                    "7528 Wilhelm Vista",
                    "01049-3162",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Jarrodmouth",
                    "Zimbabwe",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8541),
                    "Montana",
                    "672 Quinten Alley",
                    "49449",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "New Grace",
                    "France",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8675),
                    "Vermont",
                    "1133 Rohan Radial",
                    "58465",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Jamar",
                    "Estonia",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8806),
                    "Connecticut",
                    "55093 McDermott Islands",
                    "86132",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Theodoreshire",
                    "Angola",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(8938),
                    "Colorado",
                    "333 Runolfsdottir Ford",
                    "51070",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Randyfurt",
                    "Central African Republic",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(9067),
                    "Indiana",
                    "95586 Lempi Courts",
                    "30304-4562",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Konopelskiview",
                    "Austria",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(9238),
                    "Massachusetts",
                    "6152 Sasha Track",
                    "49557-3627",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "South Tracyfurt",
                    "Finland",
                    new DateTime(2024, 12, 31, 14, 16, 41, 155, DateTimeKind.Utc).AddTicks(9390),
                    "Kentucky",
                    "091 Dickens Loaf",
                    "37591-1480",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[]
                {
                    "b690f7cf-ffeb-4b70-816a-62c535911415",
                    "2662518b-a712-4722-8f28-fcd2c0727456",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "2aa63d91-2ea1-42da-b33c-9ab8821810d5",
                    "Jayde.Sawayn@hotmail.com",
                    "Sunny Kling",
                    "540.873.0076",
                    "b2fdd7a8-d7f6-4887-b523-9618c491ffad",
                    "Jayde.Sawayn@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "40a5ef2c-9845-4155-b20b-5d05238e1a4e",
                    "Tia_Block@gmail.com",
                    "Karen Mann",
                    "405.870.2667 x9967",
                    "704b9a69-ad9b-4ea7-a2fc-104dcb85b3ad",
                    "Tia_Block@gmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "5af37d28-07f7-4e80-bd1f-f0f4a901b919",
                    "Zackery42@yahoo.com",
                    "Eloisa Moen",
                    "622.849.2908 x600",
                    "ab478d2a-9e3f-4869-b3d1-67f6d5bbd8f4",
                    "Zackery42@yahoo.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "b6cdaa7d-80a0-47cf-bc7a-2901f0d9b610",
                    "Willow81@hotmail.com",
                    "Javonte Bosco",
                    "1-317-621-3114 x440",
                    "11083f85-00ca-4b67-a86d-bea43486298e",
                    "Willow81@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "ce8f592b-ef95-41bd-a20b-938f8f34f496",
                    "Frieda_Brown@gmail.com",
                    "Brennan Barrows",
                    "626.264.3291 x77043",
                    "45df4625-dcd3-4a68-b4c5-716f67697a6a",
                    "Frieda_Brown@gmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "c3ee1927-d176-496a-a1f6-545892e1a521",
                    "Arno_Runolfsdottir@yahoo.com",
                    "Ernestine Hills",
                    "1-384-573-6489",
                    "16a3b0bf-fc1c-4a2d-b384-3299733814e6",
                    "Arno_Runolfsdottir@yahoo.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "d520960f-527f-4d55-805c-5150d1ef772a",
                    "Llewellyn.McLaughlin58@gmail.com",
                    "Lavinia Watsica",
                    "1-728-434-5357 x35969",
                    "e87a95e4-006d-408c-86fc-0d2f4aa3e450",
                    "Llewellyn.McLaughlin58@gmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "078c8461-96fd-45b0-8bd8-6c5ff28f7e9e",
                    "Caterina_Robel7@gmail.com",
                    "Jensen Heller",
                    "1-764-322-6580",
                    "090128a5-1e90-4076-9560-18765d30b78a",
                    "Caterina_Robel7@gmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "ConcurrencyStamp",
                    "Email",
                    "Name",
                    "PhoneNumber",
                    "SecurityStamp",
                    "UserName",
                },
                values: new object[]
                {
                    "60d95153-92d3-4714-ab38-1043cb43fd09",
                    "Cyril.Upton64@hotmail.com",
                    "Nat Doyle",
                    "699.866.9472 x934",
                    "ab34e8de-0c7a-41d1-ba0c-bf2587db0ad0",
                    "Cyril.Upton64@hotmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Et laudantium omnis. Et suscipit culpa harum qui eos expedita sunt magni. Rerum ipsam sit. Totam ipsa possimus reprehenderit sint qui.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(6031),
                    "Marlin Carroll",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quaerat accusantium rerum sed. Voluptate voluptate sit ipsum illo. Quibusdam sint sed tempore. Veritatis omnis optio autem pariatur voluptates.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(6409),
                    "Sarai Kozey",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Unde est omnis alias. Dignissimos qui qui accusantium ratione non. Delectus saepe enim voluptatem temporibus. Quis sit ratione tempora et delectus expedita aperiam quo repellendus.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(6509),
                    "Nigel Ledner",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Aliquid sint aperiam explicabo odit. Rerum recusandae beatae expedita aspernatur modi. Sint tempore et possimus sunt in. Officiis laboriosam facere consequatur nobis est aperiam sit quas ullam. Soluta qui eum et odit voluptatem et dicta.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(6630),
                    "Isabell Lakin",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Omnis nostrum dolorem quis porro sequi laboriosam. Nihil soluta dolorem id quia praesentium aut sed repellat eum. Veniam minus aspernatur accusantium distinctio sint sed sed. Enim omnis quis. Minima necessitatibus ipsam voluptatum qui aliquid doloremque. Et laborum necessitatibus et aperiam earum nostrum et repudiandae.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(6774),
                    "Duncan Bailey",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Porro harum facere unde et consectetur saepe quia. Dicta molestias dignissimos doloremque. Eos ex voluptatibus magni eos dignissimos quasi qui magnam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(6916),
                    "Virginie Howell",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Nam officiis nisi ab deserunt. Placeat laboriosam dolor voluptatem nisi exercitationem ullam possimus alias. Quos ipsa laboriosam itaque nostrum.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(7016),
                    "Lilla Trantow",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quaerat dolores corrupti et ducimus velit. Repellendus rem id molestias molestiae quisquam qui recusandae. Dignissimos magni fugit non sapiente sed.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(7081),
                    "Clifton McCullough",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Voluptas voluptatem voluptatem dolore quos et ipsa quisquam ab. Soluta quos eum voluptate sit omnis in ab in. Distinctio qui voluptatem facere unde placeat maiores. Accusamus neque incidunt molestiae voluptatem assumenda quam eum. Doloremque impedit quo pariatur iure ea temporibus asperiores pariatur. Sit rerum fuga quisquam aut.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(7168),
                    "Roselyn Schimmel",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quia quod molestiae ipsa commodi ipsam velit voluptatem consectetur. Incidunt vel blanditiis. Autem eaque reiciendis et. Iure praesentium nostrum ab ex est voluptatem nam cum ab. Voluptas quisquam pariatur minus facilis quo amet aliquid temporibus inventore. Sunt placeat rem.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 146, DateTimeKind.Utc).AddTicks(7301),
                    "Delia Kulas",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(1467),
                    "Ipsam enim voluptas enim cupiditate cum corrupti. Ea ut quo. Sequi adipisci provident ea modi.",
                    "/images/cover-5.jpg",
                    34.14m,
                    4,
                    1,
                    "Reiciendis quia rerum.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3410),
                    "Vel quibusdam ipsa consectetur et. Qui dolor sequi dolore. Nulla voluptas earum assumenda voluptatem deleniti magni quia accusantium. Ratione fugit vel velit maiores ducimus.",
                    "/images/cover-2.jpg",
                    48.41m,
                    4,
                    2,
                    "Blanditiis sint omnis.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3620),
                    "Sit officia laboriosam eveniet aut. Consequatur qui perspiciatis inventore. Est suscipit delectus. Ut ipsum aut ipsam voluptates magnam voluptatem et suscipit.",
                    "/images/cover-4.jpg",
                    77.74m,
                    3,
                    "Quisquam maxime tempore.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3758),
                    "Ea sequi ut eius. Labore facere reiciendis sequi id in laudantium. Saepe nihil sed sunt laboriosam nulla commodi rem. Autem sit et eaque delectus eaque maxime animi quaerat. Sunt est ipsa libero doloribus voluptatem nemo animi repudiandae rem.",
                    "/images/cover-10.jpg",
                    29.43m,
                    6,
                    2,
                    "Cum incidunt ea.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3900),
                    "In ratione et dolorem dolores ut facilis. Ut est ad praesentium beatae iure. Voluptate ducimus non.",
                    "/images/cover-6.jpg",
                    78.12m,
                    2,
                    2,
                    "Velit placeat velit.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3985),
                    "Rerum quod dignissimos non consequuntur debitis qui vitae enim. Et neque est quaerat odio ullam temporibus explicabo aliquid modi. Sint qui est aut sit aperiam nostrum. Itaque praesentium qui est accusamus veritatis ut dolor.",
                    "/images/cover-3.jpg",
                    73.22m,
                    3,
                    1,
                    "Provident vero sed.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4207),
                    "Sint soluta consequatur sed. Aspernatur veniam optio et suscipit reprehenderit temporibus reiciendis autem. Consequatur est in officia pariatur quos vel quo sint.",
                    "/images/cover-10.jpg",
                    52.28m,
                    4,
                    4,
                    "Et sit optio.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4285),
                    "Pariatur sapiente facere ut id et debitis odio. Et recusandae adipisci quo porro eos exercitationem et consequatur. Non quidem ut dolore alias atque. Accusamus corrupti rerum.",
                    "/images/cover-8.jpg",
                    10.94m,
                    "Tempore soluta magni.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4455),
                    "Non fugiat tempora voluptatibus perspiciatis non non provident exercitationem molestiae. Inventore qui cum possimus odit. Id at magnam consequatur esse eum aspernatur quaerat.",
                    "/images/cover-5.jpg",
                    27.74m,
                    7,
                    "Quidem eos nobis.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4529),
                    "Aut eum nulla qui dolorum maiores provident quasi eum repellendus. A mollitia enim quia. Et architecto dolorem.",
                    "/images/cover-5.jpg",
                    45.41m,
                    5,
                    3,
                    "Quia voluptatum fugiat.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4631),
                    "Facere ea et perspiciatis voluptas. Quo iure excepturi hic voluptate beatae. Tempora ipsa eum nemo ea adipisci perferendis. Ut ea libero adipisci libero quod ea placeat. Quia nihil aspernatur nam voluptatem rem et.",
                    "/images/cover-7.jpg",
                    84.53m,
                    4,
                    5,
                    "Nulla omnis laudantium.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4759),
                    "Sint aut placeat aliquid minus quisquam iure dolores. Distinctio sequi perspiciatis dolorem nihil earum quia qui ut. Aperiam et corporis placeat id impedit cupiditate ut. Accusamus cumque temporibus id autem fugit alias minima. Doloribus quos voluptas. Sint totam neque vel.",
                    "/images/cover-2.jpg",
                    25.88m,
                    1,
                    4,
                    "Consequuntur adipisci aliquam.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4869),
                    "Molestiae architecto non esse minus qui qui repellendus corporis. Vero deserunt reiciendis. Officia omnis praesentium ipsa necessitatibus laborum vel repellat maxime. Numquam officiis quasi ex nisi recusandae et. Voluptatem dolores saepe quis in. Sequi aliquid ut et laudantium nam.",
                    "/images/cover-8.jpg",
                    37.92m,
                    1,
                    1,
                    "Est itaque eos.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5008),
                    "Voluptas consequatur dolor. Aliquam eveniet officiis fugiat qui veritatis temporibus. Et hic iusto. Fugit dicta ut quam et.",
                    65.90m,
                    7,
                    "Excepturi quia dicta.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5100),
                    "Dolorum aliquid rerum odio velit sint eum in minus. Consequuntur non suscipit doloribus animi sunt sunt doloribus labore est. Facere consequuntur ut ut nemo consequatur explicabo quia. Qui saepe ut veritatis et alias cumque dolores. Minima rerum non ea iste recusandae rerum possimus.",
                    "/images/cover-2.jpg",
                    83.55m,
                    "Facilis aliquid repellendus.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5237),
                    "Laborum nemo quia veritatis reprehenderit. Ipsum maiores reprehenderit porro magnam. Fuga est quis est hic libero aspernatur mollitia expedita corporis. Esse maxime dolor animi aut et vel iusto maxime repellat.",
                    "/images/cover-2.jpg",
                    88.48m,
                    7,
                    "Ut voluptatibus tenetur.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5319),
                    "Eos veritatis quo voluptas eveniet aut et. Et nobis quos tenetur necessitatibus dolor quam perferendis neque. Est quo magnam enim non ratione ullam voluptas voluptatem. Cumque alias enim voluptatem consequuntur unde modi. At accusamus ratione. Exercitationem ullam dolore maiores.",
                    "/images/cover-6.jpg",
                    52.69m,
                    2,
                    2,
                    "Placeat sint sunt.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[]
                {
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5439),
                    "Voluptas et nostrum debitis iusto ea est sunt. Alias quas nisi tempora qui et qui hic. Aliquam rerum nesciunt et. Minus quod totam suscipit ut atque. Molestias quam in quasi porro ut. Iste quis suscipit dignissimos magni reprehenderit nobis voluptatem laboriosam.",
                    "/images/cover-4.jpg",
                    12.79m,
                    5,
                    1,
                    "Repellendus corrupti sit.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5612),
                    "Non unde esse temporibus ex consequatur officiis voluptas. Voluptas neque eveniet atque voluptate animi non qui dignissimos eos. Quaerat quia recusandae. Quaerat id voluptatem. Sed aut temporibus quam est consequatur.",
                    "/images/cover-2.jpg",
                    68.28m,
                    5,
                    3,
                    "Sunt modi id.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5742),
                    "In at et ut doloribus. Similique autem asperiores corporis nobis nisi. Totam ipsam placeat iusto suscipit aut consectetur aliquam.",
                    "/images/cover-1.jpg",
                    59.97m,
                    7,
                    3,
                    "Consequatur est ut.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4523)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4525)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4525)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4525)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4526)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4526)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4526)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4526)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4527)
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(2336),
                    15,
                    66.15m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3661),
                    14,
                    16.76m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3880),
                    5,
                    99.20m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3894),
                    3,
                    75.26m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3904),
                    25.79m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3912),
                    72.38m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3920),
                    5,
                    45.82m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3928),
                    11,
                    82.22m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3935),
                    7,
                    34.46m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3942),
                    14,
                    85.61m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3951),
                    13,
                    75.93m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3959),
                    7,
                    86.91m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3966),
                    12,
                    93.37m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3974),
                    2,
                    40.70m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3982),
                    5,
                    87.91m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3989),
                    11,
                    47.98m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3996),
                    13,
                    48.37m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4003),
                    1,
                    38.03m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4011),
                    8,
                    85.20m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4080),
                    7,
                    68.84m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4089),
                    4,
                    29.83m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4096),
                    2,
                    78.38m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4104),
                    4,
                    58.85m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4111),
                    10,
                    73.40m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4119),
                    4,
                    40.71m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4126),
                    3,
                    32.50m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4133),
                    13,
                    81.89m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4141),
                    3,
                    15.07m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4148),
                    5,
                    40.18m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4156),
                    13,
                    55.74m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4163),
                    8,
                    33.41m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4171),
                    97.10m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4178),
                    8,
                    85.35m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4187),
                    11,
                    89.65m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4194),
                    9,
                    15.82m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4201),
                    10,
                    37.28m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4209),
                    13,
                    74.26m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4217),
                    6,
                    58.92m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4224),
                    9,
                    88.05m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4231),
                    33.64m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4238),
                    7,
                    24.14m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4246),
                    10,
                    57.78m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4253),
                    2,
                    47.11m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4261),
                    14,
                    82.13m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4269),
                    1,
                    47.89m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4278),
                    1,
                    10.97m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4285),
                    11,
                    30.25m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4293),
                    2,
                    86.68m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4300),
                    9,
                    10.98m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4308),
                    48.20m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 157, DateTimeKind.Utc).AddTicks(5846),
                    "Angie_Johns@yahoo.com",
                    "Angie Johns",
                    1,
                    12,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 157, DateTimeKind.Utc).AddTicks(9787),
                    "Opal.Denesik51@yahoo.com",
                    "Opal Denesik",
                    4,
                    6,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(1029),
                    "Rosalie.Gulgowski54@gmail.com",
                    "Rosalie Gulgowski",
                    3,
                    15,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(1737),
                    "Jay_Ledner32@hotmail.com",
                    "Jay Ledner",
                    13,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(2295),
                    "Patricia_Donnelly@hotmail.com",
                    "Patricia Donnelly",
                    1,
                    14,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(2825),
                    "Lindsey.Trantow@gmail.com",
                    "Lindsey Trantow",
                    0,
                    1,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(3502),
                    "Olga_West55@gmail.com",
                    "Olga West",
                    5,
                    13,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(4072),
                    "Albert_Prosacco42@yahoo.com",
                    "Albert Prosacco",
                    3,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(4627),
                    "Delores.Crona@yahoo.com",
                    "Delores Crona",
                    0,
                    11,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(5231),
                    "Lynda.Batz@gmail.com",
                    "Lynda Batz",
                    2,
                    9,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(5819),
                    "Ross.Feeney@yahoo.com",
                    "Ross Feeney",
                    7,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(6303),
                    "Elvira_Tillman89@yahoo.com",
                    "Elvira Tillman",
                    1,
                    13,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(6847),
                    "Rita_Runolfsson@hotmail.com",
                    "Rita Runolfsson",
                    3,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(7371),
                    "Yolanda84@yahoo.com",
                    "Yolanda Harber",
                    3,
                    2,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[]
                {
                    "BillingAddressId",
                    "CreatedDate",
                    "CustomerEmail",
                    "CustomerName",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(7892),
                    "Candice.Denesik@gmail.com",
                    "Candice Denesik",
                    7,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Hic magni nemo corporis quam a velit quo. Ab fugiat sunt sit harum dolorum. Cumque iusto voluptatem repudiandae soluta. Dolores beatae qui. Et iure ea reprehenderit quis.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 148, DateTimeKind.Utc).AddTicks(1005),
                    "Torp Group",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Nostrum aut et facere sed suscipit est rerum. Iste dolor laborum voluptas veritatis quos alias eius minima error. Qui amet ab neque voluptas ut possimus doloremque magni. Corporis et aliquid labore labore et rem aut blanditiis.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 148, DateTimeKind.Utc).AddTicks(1777),
                    "Ondricka LLC",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quasi non illum. Dolor ex culpa nobis ratione facere. Aut suscipit eum ea unde est impedit sed dolor.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 148, DateTimeKind.Utc).AddTicks(1969),
                    "Kub - Christiansen",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Minus qui necessitatibus repellat ipsum aut. Molestiae quia recusandae eos fugiat. Harum quod et aut repellat quod quos ut quis est.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 148, DateTimeKind.Utc).AddTicks(2167),
                    "White, Upton and Stokes",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Dolorum dolor tempora consequatur quis itaque nihil. Earum nisi sapiente voluptate explicabo enim fugit iste aut. Est sint vitae dolorum et. Velit consectetur odio atque voluptas error aut.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 148, DateTimeKind.Utc).AddTicks(2384),
                    "Altenwerth - Streich",
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    20,
                    "Laboriosam repellat labore et enim aperiam magnam repellendus omnis perferendis.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 151, DateTimeKind.Utc).AddTicks(9319),
                    2,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    6,
                    "Qui nulla iusto corrupti at quidem voluptatem laboriosam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(489),
                    2,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    "Iure temporibus amet consequuntur accusamus qui.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(568),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    13,
                    "Velit fugiat aut excepturi perferendis.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(593),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Qui corporis accusantium ipsa.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(612),
                    5,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Et et cupiditate porro velit cumque omnis.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(755),
                    5,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    "Et nulla ut reprehenderit velit ullam animi.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(779),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Accusantium autem ullam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(805),
                    5,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Deserunt et voluptate qui minima sint quaerat dolores quasi non.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(820),
                    1,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    "Perspiciatis quia distinctio iusto molestiae consectetur aperiam nam et.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(849),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Nihil dolor magnam voluptas qui nesciunt similique suscipit.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(876),
                    2,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    6,
                    "Quibusdam asperiores molestias nihil.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(900),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "Saepe minus odio.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(918),
                    1,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Sit quia alias.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(973),
                    5,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    19,
                    "Quibusdam saepe voluptatum doloribus ea ut quod consequatur quia quae.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(988),
                    1,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    14,
                    "Illo illum autem animi aliquid quia eaque.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1021),
                    4,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Reprehenderit qui enim in.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1042),
                    2,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Aut occaecati doloribus ad voluptas est iure.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1062),
                    2,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    3,
                    "Quam ut quasi deleniti vitae nam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1084),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    8,
                    "Aut ducimus molestias aut quam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1103),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Nihil est sint voluptatem mollitia.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1119),
                    1,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Perspiciatis quam ratione molestiae.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1136),
                    1,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Enim numquam ut ut odit officia est.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1218),
                    5,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "At ducimus voluptate distinctio fuga.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1242),
                    3,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    14,
                    "Corporis et sint eligendi rem aliquam tempore et.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1257),
                    4,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "Pariatur aliquam cum eos.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1280),
                    3,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    "Reprehenderit cumque suscipit ut eos voluptas id quas eligendi.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1296),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Atque ea ut nemo.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1320),
                    2,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Odit voluptas iure.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1338),
                    4,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    8,
                    "Nobis ut delectus occaecati nemo explicabo maxime.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1352),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Commodi ullam hic error atque ut voluptates id officiis sed.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1406),
                    4,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    18,
                    "Illum molestias quo.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1436),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    13,
                    "Impedit vitae ipsam esse ut autem dolorem.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1450),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    15,
                    "Aliquam expedita sit saepe quia dolorum nostrum est id et.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1472),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Aliquid amet molestiae.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1496),
                    4,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Qui sunt eum voluptas dolorum dolor.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1509),
                    3,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Iure facere non ratione sapiente quae sed sint expedita et.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1526),
                    5,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    11,
                    "Reiciendis occaecati velit voluptas ea et quibusdam odio.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1548),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    15,
                    "Sit nulla eum.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1598),
                    2,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    10,
                    "Esse dolores ut.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1611),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    15,
                    "Cumque veniam beatae accusantium autem minus.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1623),
                    4,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "Rerum est sed expedita quod id voluptatem aut error ipsa.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1641),
                    4,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    1,
                    "Earum veniam est facere porro ut.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1665),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Sit ut est impedit rerum dolore.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1682),
                    3,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "Necessitatibus porro nulla fuga ea dolorem.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1699),
                    1,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    1,
                    "Magni error id rerum qui provident amet esse.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1717),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Vero voluptas sunt animi modi.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1737),
                    1,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    "In et architecto.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1789),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Rem placeat debitis recusandae ad pariatur.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1803),
                    1,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Voluptatem in sed rerum adipisci error omnis in.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1822),
                    1,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8035),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8219),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8226),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8230),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8234),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8238),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8242),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8246),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8250),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8254),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8262),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8266),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8270),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8274),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8278),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8281),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8285),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8289),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8293),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8297),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8301),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8305),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8309),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8313),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8316),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8320),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8324),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8439),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8443),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8447),
                    3,
                }
            );
        }
    }
}
