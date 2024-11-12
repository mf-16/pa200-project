using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.PostgreSQL.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditLogging : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EditCount",
                table: "Books",
                type: "integer",
                nullable: false,
                defaultValue: 0
            );

            migrationBuilder.AddColumn<int>(
                name: "LastEditorId",
                table: "Books",
                type: "integer",
                nullable: true
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Cartwrightville",
                    "Svalbard & Jan Mayen Islands",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(3612),
                    "Oklahoma",
                    "29257 Treutel Fork",
                    "00767",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Anaisport",
                    "United Arab Emirates",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(4235),
                    "Nevada",
                    "608 Carter Well",
                    "94680",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Christineberg",
                    "Spain",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(4368),
                    "South Dakota",
                    "668 Maximo Summit",
                    "64815",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Port Clydeland",
                    "Jersey",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(4630),
                    "Maryland",
                    "6136 Crist Plain",
                    "19434",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Anya",
                    "British Indian Ocean Territory (Chagos Archipelago)",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(4770),
                    "California",
                    "363 Louvenia Stream",
                    "69205",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Lake Kacichester",
                    "Sierra Leone",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(4898),
                    "Iowa",
                    "3761 Grant Drive",
                    "37099",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Dianatown",
                    "Afghanistan",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5060),
                    "Arkansas",
                    "7220 Jon Unions",
                    "46994-4165",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Harberville",
                    "Colombia",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5189),
                    "Colorado",
                    "84158 Gleichner Center",
                    "90413-2620",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Lupechester",
                    "United States of America",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5320),
                    "Ohio",
                    "668 Schulist Mountain",
                    "64014-2912",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Maudiehaven",
                    "El Salvador",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5452),
                    "South Carolina",
                    "8901 Eldridge Squares",
                    "44517-3124",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "New Jaceville",
                    "United Kingdom",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5566),
                    "North Dakota",
                    "155 Stephania Turnpike",
                    "24544",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Jimmie",
                    "Brazil",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5734),
                    "Maine",
                    "563 Deborah Crossroad",
                    "91559-1543",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Port Lorenzafurt",
                    "Lithuania",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5868),
                    "Pennsylvania",
                    "2276 Hessel Plain",
                    "09155-2173",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "New Werner",
                    "France",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(5996),
                    "Massachusetts",
                    "886 Mante Loaf",
                    "79606",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Elmofurt",
                    "Tuvalu",
                    new DateTime(2024, 11, 12, 23, 22, 46, 580, DateTimeKind.Utc).AddTicks(6115),
                    "Oklahoma",
                    "642 Bessie Neck",
                    "04066-9692",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[]
                {
                    "d63a5c12-3717-4a15-85d1-779007097d99",
                    "d7625962-1ada-49ed-98ab-3e32a285b702",
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
                    "ee49f8b3-8f97-4727-9a6d-12c7c368105b",
                    "Tavares.Jacobi@gmail.com",
                    "Eli Walsh",
                    "696-527-9709",
                    "f357057c-d36d-40c9-aba0-ef38b9b1ecc5",
                    "Harold39",
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
                    "a23933df-b187-4323-9d2d-a9edbec46fc2",
                    "Janie69@yahoo.com",
                    "Adelbert McKenzie",
                    "917.276.0155 x3451",
                    "6aa68372-45ba-4907-9334-140eca3b06c5",
                    "Milo97",
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
                    "cf66242f-1e2c-4f55-b1a4-44133507e7fb",
                    "Jamil18@yahoo.com",
                    "Elza Jakubowski",
                    "1-555-925-5036 x60144",
                    "a6273cb2-be48-4456-a384-b27aaa05ce43",
                    "Patrick.Labadie",
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
                    "d901d97f-4cbd-47c1-94fb-238d1e1dcd1d",
                    "Ashtyn.Bosco@yahoo.com",
                    "Madyson Watsica",
                    "459-541-4779",
                    "7212bd2d-ca15-4582-a323-5360cc3c0cfc",
                    "Lottie74",
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
                    "ffedf92e-d445-43b7-8ed9-2055b2018fb0",
                    "Alanna30@yahoo.com",
                    "Dejuan Schaden",
                    "(959) 501-6129 x397",
                    "cf0b5de3-d02e-4353-a863-f2a30658a86b",
                    "Nona36",
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
                    "b3378b73-faf1-4d91-aba5-f37daa396302",
                    "Roel_Kunde@hotmail.com",
                    "Kyla Brakus",
                    "729-692-4461",
                    "48b7d456-c52f-4b81-bf1f-26186be8bbb9",
                    "Austen.Jones",
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
                    "845069d6-6545-4fa3-91af-e8a128094de0",
                    "Markus.Lang@yahoo.com",
                    "Rosa Kemmer",
                    "427.311.4821",
                    "c648617b-e175-49d8-95d4-b2dc11b2ff75",
                    "Burley_Schaefer",
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
                    "4e835a05-6ba3-4398-8b41-3297a4ff981c",
                    "William24@gmail.com",
                    "Americo Lemke",
                    "625-470-2732",
                    "d3fb39e3-405d-4d97-b01a-9fcbd49dd627",
                    "Bruce.Barrows",
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
                    "c684c0fc-bd97-4485-9196-19d0d021e063",
                    "Betsy2@gmail.com",
                    "Karelle Labadie",
                    "(822) 368-1249 x905",
                    "1621f2f5-7553-4f39-8c8b-2639f73c08b7",
                    "Katlyn.Schultz",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Asperiores est voluptas quo voluptatem beatae omnis est dicta. Necessitatibus sequi mollitia dolor. Suscipit libero omnis nobis. Iusto aspernatur omnis beatae amet. Accusantium nostrum aperiam ab consequatur nemo. Sapiente neque quasi adipisci doloribus voluptate distinctio nihil ut.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(8046),
                    "Constance Monahan",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Error excepturi exercitationem et voluptates officia neque. Rem occaecati sed voluptas. Omnis atque optio quod sequi incidunt et officia culpa commodi.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(8502),
                    "Whitney Lindgren",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Dolorem maxime dolorem asperiores ut. Ducimus possimus rerum eum quibusdam. Maiores sint voluptate architecto qui similique atque. Corporis modi officia.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(8626),
                    "Mona Kiehn",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Autem ut officia modi perspiciatis in harum repellendus voluptas. Similique sint amet in eius quam doloribus voluptate facere. Nesciunt reiciendis veritatis. Odit distinctio libero id doloribus sunt sint.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(8705),
                    "Dolores Cassin",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quisquam nisi autem. Blanditiis consequuntur animi rerum sit quia vel quod similique. Assumenda veniam doloremque. Ullam totam officiis ea aut eos ea.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(8821),
                    "Aisha Kertzmann",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Expedita magnam natus voluptas enim eum consequatur earum aut et. Aliquam debitis ab sequi ut soluta necessitatibus recusandae. Eveniet sit cum provident. Sit officiis et. Dignissimos consequuntur earum corrupti ut assumenda cumque cumque porro sequi.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(8902),
                    "Dion West",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Sunt dolores eaque quis culpa laudantium quaerat et porro aspernatur. Autem et ipsum necessitatibus exercitationem est. Labore cumque est doloremque minus atque magnam ut qui repellat. Numquam accusamus cupiditate voluptas error pariatur sit possimus nemo enim. Laborum neque voluptatibus qui accusantium.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(9039),
                    "Trisha Monahan",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Aliquam nisi molestias temporibus aut provident qui. Neque aspernatur expedita omnis libero quia ex consequatur. Fugiat maiores laborum voluptatem nihil vitae aliquam voluptatem.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(9177),
                    "Clifton Frami",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Ab repellat eius quidem omnis aut dolores rem maxime perspiciatis. Dolor eligendi placeat totam itaque blanditiis consectetur et aut. Laboriosam cumque eum. Qui aperiam nostrum minus occaecati cumque modi voluptatem dolore ab. Ea aliquam soluta ex beatae tenetur corporis occaecati.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(9245),
                    "Estel Runolfsson",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Non delectus doloremque sunt facere. Enim in sunt nostrum. In ut corrupti voluptas et et possimus. Perferendis ut ut sit odit et consequuntur similique reiciendis excepturi. Dolorem quaerat laudantium ipsum aliquam ea autem.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 571, DateTimeKind.Utc).AddTicks(9371),
                    "Demarco Cole",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[]
                {
                    "CreatedDate",
                    "Description",
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(3420),
                    "Occaecati tenetur eveniet. Commodi libero eos temporibus molestiae. Qui laudantium quis pariatur error dolor sed amet quo. Eum fugiat asperiores vitae ad occaecati quaerat. Totam quidem et quasi itaque.",
                    0,
                    4,
                    "https://picsum.photos/640/480/?image=966",
                    null,
                    61.24m,
                    "Maxime sit aut.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(5961),
                    "Qui reiciendis consequatur. Voluptatem repellendus voluptates aut tempora ut nobis qui laudantium. Laboriosam sequi sunt at non incidunt ea.",
                    0,
                    3,
                    "https://picsum.photos/640/480/?image=491",
                    null,
                    34.31m,
                    5,
                    "Atque nemo illum.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(6281),
                    "Labore et odio sit. Temporibus quod excepturi voluptatem sint et magnam harum ea. Molestias atque totam. Non quia quo hic quidem. Rem totam nihil sint in voluptas non dolorum minima. Ab repudiandae praesentium autem praesentium nihil ab assumenda.",
                    0,
                    8,
                    "https://picsum.photos/640/480/?image=177",
                    null,
                    48.60m,
                    2,
                    "Quia provident voluptatum.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(6563),
                    "Atque blanditiis tempore doloribus sed impedit dolore et. Reprehenderit quidem quod sed dolor impedit quam. Deleniti quaerat quod quia sint.",
                    0,
                    0,
                    "https://picsum.photos/640/480/?image=974",
                    null,
                    35.00m,
                    2,
                    "Dolorem repudiandae ea.",
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
                    "EditCount",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(6680),
                    "Quo voluptatem sunt itaque. Animi quisquam non et ratione iste eum laudantium. Ut sunt quibusdam quam ea quibusdam fuga veniam et enim. Quo voluptatem explicabo eos non harum ea quaerat. Voluptas cupiditate similique ipsa in. Enim odit corporis.",
                    0,
                    "https://picsum.photos/640/480/?image=338",
                    null,
                    73.36m,
                    1,
                    "Odit voluptas assumenda.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(6828),
                    "Id ea reiciendis autem modi rerum voluptas. Totam et molestiae quae laborum deleniti et voluptatem est. Nisi natus dolores quam sed. Eos consectetur sint et corporis id voluptatum unde magni porro. Voluptatem ut expedita deserunt porro. Est enim cum soluta quis rerum distinctio fuga numquam quia.",
                    0,
                    8,
                    "https://picsum.photos/640/480/?image=714",
                    null,
                    60.16m,
                    5,
                    "Qui qui et.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7022),
                    "Soluta dolores voluptas porro sapiente. Nihil rerum doloremque cupiditate. Sit explicabo suscipit nemo. Voluptas autem est quia atque.",
                    0,
                    6,
                    "https://picsum.photos/640/480/?image=321",
                    null,
                    68.73m,
                    2,
                    "Delectus unde dolorem.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7161),
                    "Aspernatur quis et non pariatur. Itaque voluptate ipsa quidem sapiente iure. Voluptas et voluptas sit est totam impedit dolor provident quisquam. Distinctio praesentium libero quidem magni minima tempora non unde. Nisi omnis consequatur. Provident id quia in earum doloribus consequatur rerum reiciendis voluptas.",
                    0,
                    1,
                    "https://picsum.photos/640/480/?image=150",
                    null,
                    98.47m,
                    "Fuga sed ut.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7375),
                    "Quis placeat voluptatibus vel. Sed culpa tempora debitis eius aliquid eum sit quia. Laborum et molestiae animi illo aperiam sunt soluta non ex.",
                    0,
                    7,
                    "https://picsum.photos/640/480/?image=500",
                    null,
                    55.68m,
                    4,
                    "Voluptatem veritatis sunt.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7493),
                    "Rerum sunt quaerat aut accusamus quisquam facere. Assumenda dolor repudiandae doloremque odio. Qui sed qui eaque veniam laboriosam blanditiis.",
                    0,
                    2,
                    "https://picsum.photos/640/480/?image=989",
                    null,
                    53.21m,
                    3,
                    "Qui dolores qui.",
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
                    "EditCount",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7563),
                    "Corrupti placeat dignissimos earum. Consectetur culpa sed. Eveniet voluptatum adipisci voluptas reprehenderit rem laborum perferendis dolor. Repellat atque ipsa quisquam.",
                    0,
                    "https://picsum.photos/640/480/?image=987",
                    null,
                    18.31m,
                    2,
                    "Ratione molestiae distinctio.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7661),
                    "Doloremque quibusdam explicabo unde. Dolorem at assumenda rerum adipisci sit dolorem consequatur doloremque placeat. Deleniti maxime magnam corporis qui quia doloremque ut. Est velit odio eveniet aut et aperiam sit.",
                    0,
                    4,
                    "https://picsum.photos/640/480/?image=910",
                    null,
                    97.63m,
                    5,
                    "Molestias excepturi et.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7743),
                    "Debitis veniam ex consectetur est laudantium. Occaecati aut et quidem ut rem suscipit ullam soluta. Iure eos quidem.",
                    0,
                    3,
                    "https://picsum.photos/640/480/?image=670",
                    null,
                    84.81m,
                    1,
                    "Voluptates voluptatum officiis.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7832),
                    "Corporis id ea mollitia omnis cumque necessitatibus est placeat veniam. Laborum sit rerum non reiciendis corrupti rerum. Dicta tenetur enim ducimus corporis veritatis. Harum omnis dolorum quasi eligendi in deserunt id. Omnis voluptas cum placeat. Temporibus laudantium non consequatur fuga harum aut velit.",
                    0,
                    3,
                    "https://picsum.photos/640/480/?image=179",
                    null,
                    76.10m,
                    2,
                    "Fuga animi aut.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(7975),
                    "Provident nostrum fugit commodi eaque impedit et iure impedit sunt. Hic corrupti placeat est quidem distinctio ea ea. Dignissimos deleniti vel ducimus. Voluptatem eveniet unde est impedit. Qui nihil qui asperiores esse.",
                    0,
                    8,
                    "https://picsum.photos/640/480/?image=61",
                    null,
                    55.61m,
                    2,
                    "Molestiae quaerat non.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(8121),
                    "Est sit officiis veritatis qui. A tempore omnis eos quos repudiandae. Expedita veritatis ea. Doloremque aut asperiores et sed tempora dolorem cumque sunt. Qui sed cupiditate enim ut earum.",
                    0,
                    2,
                    "https://picsum.photos/640/480/?image=207",
                    null,
                    85.63m,
                    4,
                    "Quos odio enim.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(8207),
                    "Quod aspernatur consequatur hic quia. Inventore iure beatae nisi nam odio reprehenderit sit ratione in. Illo optio pariatur amet magni minus qui. Iusto ut aperiam laudantium. Vero aut ut maxime ut quo id quod animi.",
                    0,
                    3,
                    "https://picsum.photos/640/480/?image=414",
                    null,
                    53.64m,
                    4,
                    "Aut aut cumque.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(8334),
                    "Libero a autem dolore rerum error. Et porro sunt et ut rem ex tempora. Placeat dicta placeat et dolorem.",
                    0,
                    2,
                    "https://picsum.photos/640/480/?image=683",
                    null,
                    23.02m,
                    "Sint quisquam nihil.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(8414),
                    "Quia quo asperiores occaecati repellendus neque ab eos. Assumenda itaque et amet adipisci dolor corporis perferendis. Illo quidem consectetur consequuntur iste. Ea neque vitae repellendus rerum reiciendis.",
                    0,
                    2,
                    "https://picsum.photos/640/480/?image=976",
                    null,
                    21.83m,
                    1,
                    "Dolor voluptatum quidem.",
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
                    "EditCount",
                    "Genre",
                    "ImagePath",
                    "LastEditorId",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 12, 23, 22, 46, 575, DateTimeKind.Utc).AddTicks(8496),
                    "Perspiciatis nulla placeat sint ratione eligendi consequatur alias nihil nihil. Aut delectus magni consectetur perferendis minima consectetur qui dolores. Culpa ut et illum neque repellat est iure voluptas. Consequuntur sit est voluptas a dolorum. Molestias molestias nemo necessitatibus beatae consectetur enim.",
                    0,
                    6,
                    "https://picsum.photos/640/480/?image=778",
                    null,
                    37.90m,
                    2,
                    "Id tempora repellat.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2958)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2960)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2960)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2961)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2961)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2961)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2961)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2962)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2962)
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(955),
                    10,
                    23.75m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2275),
                    8,
                    89.02m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2329),
                    2,
                    85.36m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2341),
                    3,
                    45.81m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2350),
                    1,
                    59.78m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2360),
                    8,
                    19.69m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2369),
                    2,
                    70.82m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2376),
                    1,
                    85.92m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2383),
                    2,
                    98.22m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2426),
                    14,
                    52.30m,
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
                    18,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2435),
                    4,
                    55.99m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2442),
                    1,
                    38.00m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2450),
                    13,
                    80.59m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2456),
                    11,
                    67.92m,
                    1,
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
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2463),
                    15,
                    27.11m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2469),
                    5,
                    43.83m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2476),
                    15,
                    56.78m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2483),
                    1,
                    11.88m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2490),
                    15,
                    75.50m,
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
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2497),
                    5,
                    65.02m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2504),
                    54.35m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2511),
                    8,
                    15.83m,
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
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2518),
                    11,
                    38.70m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2524),
                    49.14m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2532),
                    9,
                    63.11m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2538),
                    46.93m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2545),
                    3,
                    15.14m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2552),
                    8,
                    26.60m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2559),
                    5,
                    29.66m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2565),
                    13,
                    12.65m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2572),
                    7,
                    61.23m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2578),
                    13,
                    81.28m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2584),
                    4,
                    80.58m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2591),
                    8,
                    47.15m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2598),
                    13,
                    20.22m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2605),
                    6,
                    16.19m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2611),
                    12,
                    89.20m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[]
                {
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2618),
                    62.90m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2625),
                    2,
                    72.41m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2632),
                    12,
                    39.66m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2720),
                    15,
                    36.27m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2728),
                    10,
                    78.44m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2736),
                    2,
                    38.95m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2742),
                    4,
                    51.11m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2750),
                    7,
                    33.60m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2757),
                    12,
                    75.50m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2763),
                    15,
                    84.94m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2770),
                    6,
                    15.23m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2777),
                    7,
                    56.14m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 586, DateTimeKind.Utc).AddTicks(2784),
                    4,
                    64.48m,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 11, 12, 23, 22, 46, 582, DateTimeKind.Utc).AddTicks(1146),
                    "Gail_Gusikowski54@yahoo.com",
                    "Gail Gusikowski",
                    14,
                    9,
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
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 582, DateTimeKind.Utc).AddTicks(3715),
                    "Tammy93@gmail.com",
                    "Tammy Tremblay",
                    11,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 582, DateTimeKind.Utc).AddTicks(4779),
                    "Alfred_Dickens@gmail.com",
                    "Alfred Dickens",
                    5,
                    10,
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
                    new DateTime(2024, 11, 12, 23, 22, 46, 582, DateTimeKind.Utc).AddTicks(5400),
                    "Antoinette.Wunsch@yahoo.com",
                    "Antoinette Wunsch",
                    12,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 12, 23, 22, 46, 582, DateTimeKind.Utc).AddTicks(6031),
                    "Lindsay_Wilderman56@gmail.com",
                    "Lindsay Wilderman",
                    2,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 582, DateTimeKind.Utc).AddTicks(6693),
                    "Veronica58@yahoo.com",
                    "Veronica O'Conner",
                    10,
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
                    "UserId",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(186),
                    "Tomas_Watsica@hotmail.com",
                    "Tomas Watsica",
                    5,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(1046),
                    "Becky14@gmail.com",
                    "Becky McLaughlin",
                    9,
                    4,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(1591),
                    "Dan.Nitzsche75@gmail.com",
                    "Dan Nitzsche",
                    6,
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
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(2231),
                    "Bethany.Legros89@hotmail.com",
                    "Bethany Legros",
                    13,
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
                    12,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(2731),
                    "Matt_Nienow@gmail.com",
                    "Matt Nienow",
                    11,
                    2,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(3333),
                    "Danielle_Crona@gmail.com",
                    "Danielle Crona",
                    7,
                    8,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(3897),
                    "Domingo85@gmail.com",
                    "Domingo Koelpin",
                    13,
                    10,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(4438),
                    "Stacy_Huels@yahoo.com",
                    "Stacy Huels",
                    3,
                    4,
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
                    13,
                    new DateTime(2024, 11, 12, 23, 22, 46, 584, DateTimeKind.Utc).AddTicks(4991),
                    "Jonathan67@yahoo.com",
                    "Jonathan Schuster",
                    1,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Minus fugiat omnis in velit illum culpa omnis. Quaerat error eligendi est dignissimos dolor ut animi. Aut ratione eveniet qui mollitia nisi minus. Nihil ad laborum. Sit est ipsam eius atque cupiditate rerum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 573, DateTimeKind.Utc).AddTicks(5575),
                    "Hauck, Klocko and McGlynn",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Recusandae voluptatibus nemo beatae sint pariatur perspiciatis molestiae suscipit. Blanditiis sed exercitationem aut libero rem fugit voluptatem. Ut aut iusto ad omnis laudantium est autem. Dolores sit molestiae. Fugiat et quia nihil. Dolorum ut quis accusantium consectetur dolor non id.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 573, DateTimeKind.Utc).AddTicks(6895),
                    "Reichert, Reichel and Bashirian",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Ratione et reiciendis omnis nulla aut rerum. Non deleniti voluptatem libero sit quasi laudantium. Eum molestiae fugiat et non quaerat. Quibusdam sapiente tempore enim tempore minima consequatur dolor officia. Expedita nemo earum commodi et harum labore earum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 573, DateTimeKind.Utc).AddTicks(7251),
                    "Schaden, Bogan and Marks",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Repellat minima voluptas. Omnis modi quo. Reprehenderit quia accusantium odio esse ut maxime ea aut ut. Minima ut est voluptatem autem aut ut est quod. Fugiat qui id velit similique.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 573, DateTimeKind.Utc).AddTicks(7696),
                    "Grimes Group",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Dolores dolorum amet perspiciatis ipsam. Voluptatem ratione aliquam velit tenetur perferendis. Laborum autem autem maiores laudantium dignissimos numquam vero.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 573, DateTimeKind.Utc).AddTicks(7911),
                    "Erdman and Sons",
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Cum aut molestiae eveniet.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(3385),
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
                    3,
                    "Sed suscipit dolor repudiandae ad similique minus necessitatibus cum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4460),
                    4,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Sunt voluptas delectus.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4547),
                    3,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    9,
                    "Enim aut autem.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4566),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    15,
                    "Quaerat sint aliquam.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4581),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    "Nihil modi excepturi et quos inventore.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4597),
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
                    13,
                    "Ea eius optio veniam tenetur reiciendis recusandae.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4618),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Assumenda ut non ipsum ullam consequatur possimus.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4644),
                    4,
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
                    2,
                    "Omnis nemo accusantium.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4672),
                    4,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Ipsam dolore necessitatibus fugit ab eos suscipit facilis quidem.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4691),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    20,
                    "Eos in eligendi voluptate ut quo.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4778),
                    1,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Ea occaecati consectetur sint non consequuntur in.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4800),
                    5,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    17,
                    "Et pariatur modi eum nostrum sit dolorum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4823),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    12,
                    "Autem alias molestiae soluta.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4843),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Hic incidunt nulla est nobis nihil dicta.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4859),
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
                    17,
                    "Enim omnis voluptatem est deserunt.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4882),
                    4,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "Illum ut labore ut omnis et dolore cum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4900),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    19,
                    "Consectetur odio consectetur qui qui minus quae et.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4921),
                    1,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Sit corrupti tenetur vero.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4972),
                    5,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    15,
                    "Quidem voluptatum quo.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(4988),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    8,
                    "Eum quae ut temporibus.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5001),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Earum voluptatem delectus repudiandae labore officia consequatur.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5016),
                    1,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    6,
                    "Quae saepe in.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5039),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Et et voluptatibus ullam voluptatibus itaque.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5052),
                    4,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Officiis tenetur impedit laboriosam repudiandae.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5071),
                    3,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Magnam rerum voluptas.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5089),
                    1,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Soluta in voluptatem rerum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5103),
                    3,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    "Explicabo necessitatibus sed voluptas iusto.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5145),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Labore quia at placeat cumque voluptatem.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5163),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    "Mollitia deleniti nihil voluptatum ab eum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5184),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "A dolor saepe quia.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5201),
                    1,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    4,
                    "Delectus rerum recusandae aliquam ratione.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5216),
                    5,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    "Enim molestiae deserunt distinctio et.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5232),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Quidem quos ducimus.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5248),
                    3,
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
                    9,
                    "Dignissimos mollitia magnam aut dolor nemo qui quae et.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5262),
                    4,
                    6,
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
                    "Odit neque omnis officia ut nihil aliquid sunt ut.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5283),
                    1,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    7,
                    "Earum alias odio et itaque voluptatum facere id quia.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5336),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Ut distinctio tempore ut nihil asperiores quo autem.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5359),
                    3,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Maiores voluptas doloremque pariatur aspernatur quia molestiae et ipsum.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5380),
                    5,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    18,
                    "Sint qui molestias iste.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5404),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "In et iste minus aut architecto commodi voluptatem sunt est.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5418),
                    3,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    11,
                    "Totam aliquid similique eveniet ipsam quod facere enim repellat.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5442),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    "Ut eos odit.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5462),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    "Voluptate sed nostrum eos sunt neque fugit esse.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5500),
                    7,
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
                    "Cum aut corporis consectetur adipisci quae est.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5521),
                    3,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Quasi minima cum vitae beatae qui.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5541),
                    4,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Sint saepe est qui quos minima nisi quasi aliquam.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5559),
                    3,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    19,
                    "Aliquid rerum minima eos corporis qui sequi.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5580),
                    1,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Excepturi nam sequi.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5599),
                    5,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    7,
                    "Dolore perspiciatis odit.",
                    new DateTime(2024, 11, 12, 23, 22, 46, 577, DateTimeKind.Utc).AddTicks(5612),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9821),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9975),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9981),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9984),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9987),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9990),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9992),
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
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9995),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 12, 23, 22, 46, 578, DateTimeKind.Utc).AddTicks(9998),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(3),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(6),
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
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(9),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(11),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(14),
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
                    15,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(17),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(19),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(22),
                    6,
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
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(25),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(28),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(31),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(34),
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
                    16,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(121),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(125),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(128),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(131),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(133),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(136),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(139),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 12, 23, 22, 46, 579, DateTimeKind.Utc).AddTicks(142),
                    7,
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_Books_LastEditorId",
                table: "Books",
                column: "LastEditorId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Books_AspNetUsers_LastEditorId",
                table: "Books",
                column: "LastEditorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_AspNetUsers_LastEditorId",
                table: "Books"
            );

            migrationBuilder.DropIndex(name: "IX_Books_LastEditorId", table: "Books");

            migrationBuilder.DropColumn(name: "EditCount", table: "Books");

            migrationBuilder.DropColumn(name: "LastEditorId", table: "Books");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Lefflerborough",
                    "Fiji",
                    new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(8783),
                    "Wisconsin",
                    "5695 Marjorie Burgs",
                    "41271-2994",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "South Marianna",
                    "Cocos (Keeling) Islands",
                    new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(9522),
                    "Minnesota",
                    "15584 Keeling Junction",
                    "13512",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Eliseoshire",
                    "Zimbabwe",
                    new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(9699),
                    "New Jersey",
                    "146 Reichel Terrace",
                    "51676-7184",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Darioside",
                    "Netherlands Antilles",
                    new DateTime(2024, 11, 9, 21, 0, 29, 490, DateTimeKind.Utc).AddTicks(9838),
                    "Utah",
                    "5426 Murray Underpass",
                    "14371-3426",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Port Margaretteburgh",
                    "Zimbabwe",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(28),
                    "Louisiana",
                    "34748 Tremayne Forest",
                    "36249-6315",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Vernie",
                    "Western Sahara",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(201),
                    "New Mexico",
                    "66654 Smith Ridge",
                    "44021-1608",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Rahsaanbury",
                    "Burkina Faso",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(333),
                    "Colorado",
                    "17979 Hand Knoll",
                    "84392",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "East Jewelland",
                    "Libyan Arab Jamahiriya",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(465),
                    "Indiana",
                    "3536 Rogelio Locks",
                    "86806-6886",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Hintzchester",
                    "Finland",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(614),
                    "Rhode Island",
                    "86993 Golda Circles",
                    "88887-9100",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "South Sylvesterbury",
                    "Spain",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(754),
                    "Indiana",
                    "16645 Ritchie Passage",
                    "45352-0359",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Leopold",
                    "Marshall Islands",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1268),
                    "Kentucky",
                    "13928 Ari Walks",
                    "61538",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Ayden",
                    "Panama",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1392),
                    "Kentucky",
                    "3303 Denesik Shore",
                    "14970",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Wilfridmouth",
                    "South Africa",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1546),
                    "Massachusetts",
                    "8681 Stracke Gardens",
                    "63326-0045",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Feeneyside",
                    "Haiti",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1708),
                    "Rhode Island",
                    "642 Jerel Ford",
                    "27394-0928",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "North Tiffany",
                    "Cambodia",
                    new DateTime(2024, 11, 9, 21, 0, 29, 491, DateTimeKind.Utc).AddTicks(1835),
                    "Ohio",
                    "8748 Monique Islands",
                    "75886-4496",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[]
                {
                    "1d7aa11f-1e47-4d15-9139-a3202e16e5e0",
                    "6315ff0e-b974-49ec-9c75-67dc803278e7",
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
                    "838e0d2c-77bf-4b37-a1f6-3b67411cbb60",
                    "Hiram.Adams@yahoo.com",
                    "Juliana Hand",
                    "1-289-832-6441 x008",
                    "c0c3db00-12f7-4657-b979-385113e80f0c",
                    "Mustafa.Larkin33",
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
                    "71c64bb0-6663-4813-9999-abb334e10fa6",
                    "Cordelia.Hessel93@gmail.com",
                    "Braulio Morar",
                    "221.534.0977 x60962",
                    "721d421c-cac0-4820-aaee-2b76da733a0a",
                    "Cole_Huel",
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
                    "c3244163-d105-4b87-b211-4e88b13e7134",
                    "Oma68@yahoo.com",
                    "Fletcher Davis",
                    "203.880.8063 x22710",
                    "e06299a9-7677-4c21-aac4-d5ed4a0e457e",
                    "Emmett.Moore",
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
                    "26b7ccb2-3699-48a1-a1bf-fbc7e0117ecb",
                    "Herman_Veum63@gmail.com",
                    "Willy Jacobi",
                    "1-373-441-8199",
                    "78d22e37-db7b-4924-8323-51234faa3f86",
                    "Zoey_Greenfelder",
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
                    "734cf6d0-2b13-421c-88ff-57dd9e1dcfee",
                    "Amina_King@yahoo.com",
                    "Melba Hansen",
                    "(218) 395-4438",
                    "adba5717-10f9-40fd-bf22-a776d68e1f86",
                    "Frances15",
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
                    "00c52566-d4d1-4390-b13b-922776ad4ad1",
                    "Kendra.McClure96@yahoo.com",
                    "Dalton Wiegand",
                    "688.813.3612 x6438",
                    "b3b08d53-02bc-4e7d-bc7e-1443b48a55c9",
                    "Jordy64",
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
                    "a6f5180c-51ba-4709-b568-a85e46ff174d",
                    "Nasir_Feest@hotmail.com",
                    "Lazaro Dibbert",
                    "588-982-6895",
                    "89a316ec-9746-4b4f-9239-d01b2aa436ac",
                    "Annetta64",
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
                    "9a58c1af-dfbe-45ec-ba64-0d84165af791",
                    "Arch.Orn89@gmail.com",
                    "Mariano Farrell",
                    "937-349-0078 x48080",
                    "5c72bcc5-f25f-42dc-993d-badb0a56f702",
                    "Cale93",
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
                    "d8dc519b-7d90-45f8-8a97-615da2529e92",
                    "Ines.Miller@hotmail.com",
                    "Layla Rice",
                    "1-282-435-2580",
                    "30fb67c8-0a43-45f0-8f49-f312f7b59e48",
                    "Ida37",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Nesciunt fuga nemo reiciendis quia ut. Placeat fugiat pariatur eius distinctio qui sit veritatis. Et asperiores doloremque temporibus exercitationem. Omnis voluptate magni ab qui.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(6801),
                    "Tanner Reinger",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Eos et consequatur id ea et sed tempore. Commodi cupiditate voluptatem quasi consectetur est repellat omnis voluptatem eaque. Doloremque ut et sapiente voluptatem. Adipisci veniam ratione voluptates at debitis reprehenderit. Perferendis omnis distinctio. Dignissimos maiores illo aut aliquid voluptatibus quis voluptatum.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7193),
                    "Kenny Botsford",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Fuga nesciunt reiciendis qui iste omnis facere earum vel. Culpa architecto eligendi iusto illo dolorem. Ut illo et est enim officia inventore similique velit voluptas. Molestiae at aliquam iusto.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7434),
                    "Michaela Deckow",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Ad asperiores occaecati sed dignissimos autem. Eaque perspiciatis rerum modi. Temporibus aliquam atque sint tenetur aperiam itaque et eius. Quia modi quae neque rerum quod hic. Quas occaecati explicabo ipsam aut consequatur eos. Asperiores nihil ullam facere.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7589),
                    "Marian Veum",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Veniam odio exercitationem officiis. Quibusdam quam cum voluptas et consequuntur veniam. Molestiae corrupti officia aut quia qui. Quisquam at consequatur soluta assumenda facilis. Deserunt vel placeat dicta.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7747),
                    "Nia Rohan",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Aperiam numquam quia occaecati alias fugiat blanditiis sed voluptatem. Tempore nisi voluptatibus eum amet excepturi. Repudiandae quo voluptate ea est nihil dolorem doloribus. Qui quod sapiente.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7878),
                    "Arno Goodwin",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Iste ipsum voluptatem dolores. Voluptatum quisquam facilis. Architecto a autem rem modi sit. Distinctio qui consequatur.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(7989),
                    "Ophelia Senger",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Itaque ut a consequuntur et cum beatae sed quisquam. Tempora libero aut porro voluptatem minus ut dolorem. Ut vel dicta ratione accusamus id non qui quia. Nostrum ratione nemo qui sed optio. Nobis amet ut dolore dicta aliquid qui eum error.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(8128),
                    "Kobe Kuhic",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Molestiae omnis illum enim eum neque soluta inventore. Illo enim repellendus sint eveniet. Et eius eos quae repellendus.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(8257),
                    "Kristina Kemmer",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Iste consectetur eveniet mollitia et laudantium porro aut. Molestias porro aut exercitationem rerum. Qui explicabo beatae quia quia. Laborum vitae consequatur sit maxime qui praesentium ut.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 483, DateTimeKind.Utc).AddTicks(8369),
                    "Neal Wunsch",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[]
                {
                    "CreatedDate",
                    "Description",
                    "Genre",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(4602),
                    "Rem quasi similique dolorem est ad cum. Magni vero cupiditate dicta nobis sint adipisci. Magnam aut magnam. Asperiores quo eaque dolor.",
                    3,
                    "https://picsum.photos/640/480/?image=56",
                    43.97m,
                    "Consequatur minus molestiae.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7035),
                    "Odio provident vel dolores quo quia voluptate non. Nesciunt nam expedita maxime dolorem asperiores officiis recusandae. In qui dolore. Cumque nam veniam. Sequi omnis aliquid aut accusantium sed enim dolores tempore. Voluptatibus numquam aperiam.",
                    7,
                    "https://picsum.photos/640/480/?image=208",
                    44.85m,
                    3,
                    "Eius rerum debitis.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7242),
                    "Totam tempora rerum. Dolorem id occaecati laboriosam assumenda consequatur maiores dignissimos eaque. Non et adipisci. Optio aut qui commodi.",
                    1,
                    "https://picsum.photos/640/480/?image=429",
                    54.75m,
                    5,
                    "Natus sequi et.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7365),
                    "Ad pariatur qui quae voluptatem. Porro autem ea illo modi natus. Earum alias ut accusantium voluptas hic est. Possimus veritatis et sint. Laboriosam occaecati non molestias omnis.",
                    7,
                    "https://picsum.photos/640/480/?image=1045",
                    28.62m,
                    5,
                    "Quia alias sed.",
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7494),
                    "In doloremque omnis atque nemo aliquid enim. Eius nihil eius atque dolor facere et qui. Voluptatem est sed inventore quibusdam maiores vel.",
                    "https://picsum.photos/640/480/?image=453",
                    34.61m,
                    2,
                    "Voluptate qui facere.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7568),
                    "Tenetur dolores dignissimos ipsam eos delectus. Corporis deserunt nam eligendi consequatur. Et non maiores.",
                    1,
                    "https://picsum.photos/640/480/?image=928",
                    75.38m,
                    1,
                    "Commodi sunt velit.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7652),
                    "Culpa vel a aspernatur mollitia eum dolores suscipit. Officiis alias quaerat dolorem. Sed voluptatibus sit distinctio sequi eligendi tenetur est labore pariatur. Deleniti hic doloribus molestiae dolore qui. Ea vero qui ut laudantium consectetur expedita aut. Dolores dignissimos quia voluptate odit suscipit.",
                    3,
                    "https://picsum.photos/640/480/?image=802",
                    21.91m,
                    3,
                    "Saepe natus nihil.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7851),
                    "Iure ut et et omnis ullam amet ut dolorem ratione. Ea eveniet eos qui nemo sed totam nihil aut. Voluptatem dignissimos facere voluptatem vero. Et aspernatur aperiam ipsam voluptates et. Quia officiis delectus.",
                    2,
                    "https://picsum.photos/640/480/?image=1067",
                    15.12m,
                    "Aspernatur perspiciatis sapiente.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(7960),
                    "Eaque amet voluptas dolore ratione. Voluptas nesciunt voluptatibus possimus officiis alias. Aut doloribus tempore repellat.",
                    8,
                    "https://picsum.photos/640/480/?image=181",
                    46.27m,
                    3,
                    "Voluptatem quasi laborum.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8060),
                    "Sunt ut cum veritatis dolorem quaerat recusandae quidem. Ut quo qui nihil et ullam eum. Id ex consequatur non nam sint qui ad velit dolore. Et reiciendis distinctio reiciendis assumenda.",
                    1,
                    "https://picsum.photos/640/480/?image=603",
                    61.93m,
                    4,
                    "Perspiciatis facere ipsam.",
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8178),
                    "Et architecto libero qui placeat ab repellendus. Iure eius enim. Pariatur pariatur veniam ut natus architecto atque aut laudantium.",
                    "https://picsum.photos/640/480/?image=348",
                    97.25m,
                    3,
                    "Sint ut nisi.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8243),
                    "Aliquid accusamus quasi laboriosam itaque ut perferendis. Tenetur exercitationem iste sint. Quisquam vel accusamus maiores quia veniam optio nam. Pariatur deleniti laboriosam ipsam earum pariatur ducimus aspernatur rerum minus.",
                    8,
                    "https://picsum.photos/640/480/?image=694",
                    43.39m,
                    3,
                    "Voluptates repellendus voluptates.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8353),
                    "Itaque possimus qui saepe consectetur iure id atque hic necessitatibus. Qui nihil in nihil exercitationem voluptatibus distinctio iusto molestiae. Est quis ratione est exercitationem. Voluptatem expedita accusantium ea.",
                    6,
                    "https://picsum.photos/640/480/?image=667",
                    28.92m,
                    2,
                    "Deserunt dolore et.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8464),
                    "Sint aspernatur qui voluptatem. Et asperiores ratione autem sapiente. Ea illum ut vero. Veniam officia rerum et voluptatibus eveniet. Vel doloribus enim inventore illo qui.",
                    8,
                    "https://picsum.photos/640/480/?image=335",
                    21.30m,
                    4,
                    "Adipisci ut soluta.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8547),
                    "Autem voluptatem consequatur et rerum rerum minus. Et consequatur mollitia expedita deserunt quo. Perferendis exercitationem facere adipisci qui aut ab qui harum eum.",
                    3,
                    "https://picsum.photos/640/480/?image=964",
                    63.11m,
                    3,
                    "Numquam non ut.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8644),
                    "Ipsum est tenetur. Nesciunt ut omnis. Eligendi a nam est aut atque et.",
                    6,
                    "https://picsum.photos/640/480/?image=261",
                    41.41m,
                    2,
                    "Reprehenderit inventore illo.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8700),
                    "Voluptatem non ut facilis. Hic provident sed voluptas laboriosam. Expedita pariatur odio quam et facere illum error.",
                    4,
                    "https://picsum.photos/640/480/?image=604",
                    41.33m,
                    2,
                    "Ut dolores mollitia.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[]
                {
                    "AuthorId",
                    "CreatedDate",
                    "Description",
                    "Genre",
                    "ImagePath",
                    "Price",
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8790),
                    "Sed dicta laborum quia magnam velit sit. Ut quis eos quae dolores alias sit. Veniam molestiae voluptate quisquam molestias. Laudantium reprehenderit aspernatur consequatur esse. Ullam et eum dolores et ducimus dolores ut perspiciatis.",
                    0,
                    "https://picsum.photos/640/480/?image=794",
                    93.90m,
                    "Sunt explicabo velit.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(8880),
                    "Quo consequuntur hic voluptatem provident voluptatem voluptatem aut. Esse non quasi odit veritatis quia doloribus culpa modi et. Sit itaque est voluptatum autem temporibus quod error adipisci quis. Quidem labore quos ut dolor a architecto et. Earum non illo.",
                    7,
                    "https://picsum.photos/640/480/?image=413",
                    26.59m,
                    3,
                    "Voluptates corrupti est.",
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
                    "Genre",
                    "ImagePath",
                    "Price",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 9, 21, 0, 29, 486, DateTimeKind.Utc).AddTicks(9040),
                    "Aut asperiores doloremque qui voluptatum officiis modi temporibus. Fugit numquam ad sed quo repellendus praesentium velit eum. Aut quidem consequatur id laudantium fugit qui. Laudantium tempore ipsam quis.",
                    1,
                    "https://picsum.photos/640/480/?image=1051",
                    25.57m,
                    4,
                    "Molestiae laboriosam quae.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9618)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9621)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9622)
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(7996),
                    5,
                    57.52m,
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
                    20,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9052),
                    1,
                    65.16m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9095),
                    1,
                    70.12m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9150),
                    13,
                    95.62m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9158),
                    7,
                    16.25m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9164),
                    14,
                    24.21m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9171),
                    8,
                    96.98m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9177),
                    7,
                    71.23m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9184),
                    13,
                    93.35m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9190),
                    10,
                    75.42m,
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
                    5,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9196),
                    5,
                    21.03m,
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
                    12,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9202),
                    5,
                    61.08m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9208),
                    8,
                    55.99m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9214),
                    6,
                    96.41m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9220),
                    10,
                    55.08m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9227),
                    6,
                    58.54m,
                    3,
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
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9233),
                    2,
                    89.81m,
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
                    16,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9239),
                    8,
                    79.59m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9245),
                    3,
                    47.79m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9251),
                    8,
                    78.71m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9257),
                    42.98m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9263),
                    13,
                    79.72m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9269),
                    9,
                    89.35m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9275),
                    13.11m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9281),
                    1,
                    17.42m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9287),
                    63.03m,
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
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9293),
                    10,
                    70.98m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9299),
                    5,
                    80.11m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9305),
                    12,
                    72.87m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9311),
                    15,
                    51.68m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9317),
                    8,
                    87.75m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9323),
                    15,
                    87.25m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9329),
                    3,
                    91.72m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9335),
                    11,
                    97.67m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9340),
                    14,
                    89.20m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9379),
                    13,
                    15.71m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9386),
                    3,
                    74.60m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[]
                {
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9393),
                    34.11m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9400),
                    11,
                    43.41m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9406),
                    15,
                    97.42m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9412),
                    12,
                    34.15m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9418),
                    1,
                    15.26m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9424),
                    15,
                    52.46m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9430),
                    2,
                    17.49m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9436),
                    15,
                    58.11m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9441),
                    13,
                    12.65m,
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
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9447),
                    13,
                    38.44m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9453),
                    10,
                    44.46m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9459),
                    13,
                    91.13m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 11, 9, 21, 0, 29, 494, DateTimeKind.Utc).AddTicks(9465),
                    7,
                    61.85m,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(4324),
                    "Irving.Hyatt@gmail.com",
                    "Irving Hyatt",
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
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(6859),
                    "Stella_Predovic71@gmail.com",
                    "Stella Predovic",
                    7,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(7842),
                    "Candice6@hotmail.com",
                    "Candice Feil",
                    14,
                    2,
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
                    14,
                    new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(8491),
                    "Lorena44@hotmail.com",
                    "Lorena Flatley",
                    11,
                    8,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(9123),
                    "Jeffery.Jacobson97@hotmail.com",
                    "Jeffery Jacobson",
                    13,
                    2,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 492, DateTimeKind.Utc).AddTicks(9746),
                    "Esther43@gmail.com",
                    "Esther Bayer",
                    9,
                    7,
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
                    "UserId",
                },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(291),
                    "Nettie.Feest76@gmail.com",
                    "Nettie Feest",
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(1022),
                    "Vivian68@yahoo.com",
                    "Vivian McLaughlin",
                    12,
                    6,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(1633),
                    "Dorothy_Berge97@hotmail.com",
                    "Dorothy Berge",
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
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(2169),
                    "Grant.Lemke@gmail.com",
                    "Grant Lemke",
                    1,
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
                    11,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(2832),
                    "Gail.Wolff30@gmail.com",
                    "Gail Wolff",
                    2,
                    5,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(3419),
                    "Kristina_Klocko10@yahoo.com",
                    "Kristina Klocko",
                    2,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(4049),
                    "Billy93@gmail.com",
                    "Billy Corkery",
                    12,
                    5,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(4610),
                    "Grace_Metz10@yahoo.com",
                    "Grace Metz",
                    14,
                    6,
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
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 493, DateTimeKind.Utc).AddTicks(5180),
                    "Colin84@hotmail.com",
                    "Colin Murazik",
                    2,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Facilis et at iusto. Quae id quaerat magni veritatis voluptatem voluptas enim sint est. Amet voluptas quo sunt nulla nihil. Saepe ut laudantium est suscipit libero corrupti voluptatem nostrum vel. Natus voluptatem ipsa.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(366),
                    "Waelchi, Cartwright and Rippin",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Quia facere mollitia maxime a exercitationem praesentium totam voluptatem aut. Voluptatem recusandae quam et. Dolorem vel placeat reprehenderit ut ut.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1210),
                    "Funk Inc",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Laboriosam culpa sed quaerat voluptas rerum doloribus velit. Quis explicabo et. In maxime est quia nam cumque quas. Nam quia nesciunt velit tenetur. Aperiam culpa sapiente. Vero distinctio deleniti dicta aliquam in et aliquam.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1468),
                    "Haley Group",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Neque molestiae qui molestiae et repudiandae ab. Fugiat numquam ipsam. Asperiores rem consequatur voluptatem aut minus maiores. Aspernatur expedita laborum nihil earum quo non est qui id. Sit aut est natus nisi ipsum culpa.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1693),
                    "Kertzmann, Mante and Satterfield",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Odio cumque velit eum vel ut optio magnam numquam. Harum eum et alias vel voluptatem nesciunt maiores est nihil. Temporibus quos ipsam vero minus nisi vel et sit ad. Inventore temporibus reprehenderit omnis sed et minima eligendi. Sit aliquam unde excepturi esse est nam.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 485, DateTimeKind.Utc).AddTicks(1931),
                    "Stanton - Johns",
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Sed est aliquam esse rerum voluptatem aspernatur.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(1727),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Fuga qui aut.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2786),
                    5,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    19,
                    "Commodi facere aliquam non quia facere officiis aspernatur voluptatibus dolorum.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2843),
                    5,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    11,
                    "Omnis omnis non maxime repellendus suscipit quaerat esse aliquam.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2914),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    3,
                    "A consequatur repudiandae minima necessitatibus sit id deleniti perspiciatis.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2940),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    "Et ipsa hic molestiae voluptas voluptates qui soluta sit eligendi.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2967),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    20,
                    "Et quaerat dolores neque libero aliquid quia.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(2991),
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
                    3,
                    "Dolore ab sit veritatis.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3009),
                    3,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Necessitatibus voluptatem ipsam praesentium fugiat officiis.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3023),
                    1,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Dolor possimus sit et ratione et aut.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3040),
                    5,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "Dolorem dolorum praesentium voluptatibus aut autem excepturi at occaecati molestias.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3061),
                    3,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Eius et in nemo debitis neque.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3122),
                    1,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    8,
                    "Ad illum quae.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3139),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    18,
                    "Dolore sit similique delectus non asperiores ipsam eos perspiciatis.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3151),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Ut sunt eius praesentium.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3173),
                    2,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Veniam illum aut repellendus nemo cum magnam cumque.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3186),
                    1,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Tempora dolorum voluptatem in adipisci voluptatum.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3206),
                    4,
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
                    3,
                    "Id aut facilis ullam sint amet adipisci.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3222),
                    2,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Quibusdam est doloribus.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3241),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    "Accusamus similique accusantium eius dolores consequatur tempora.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3289),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    12,
                    "Et et quidem.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3308),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Inventore consequatur minima odit magni voluptas quod nihil quas nisi.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3320),
                    5,
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
                    18,
                    "Et soluta temporibus consequatur soluta fugit laudantium sunt.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3343),
                    4,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Quis quod sapiente iusto odit aspernatur et.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3362),
                    2,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    15,
                    "Atque atque exercitationem est dolores est.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3380),
                    1,
                    6,
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
                    "Natus vel repellat eos amet qui.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3396),
                    4,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    6,
                    "Dolores laudantium aut.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3413),
                    2,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    "Repudiandae minus ipsa deleniti voluptates.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3444),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Repellendus voluptatem tempore praesentium ea.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3459),
                    4,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    "Aperiam dignissimos aperiam.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3475),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Expedita voluptatibus quis.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3486),
                    5,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Deleniti nemo tenetur sit explicabo.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3498),
                    1,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    "Esse temporibus molestiae quia et non.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3512),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    4,
                    "Qui magnam molestiae aliquid fuga quae.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3529),
                    2,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Voluptatem ipsam qui tempore quos.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3546),
                    1,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Enim libero a debitis odit.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3629),
                    5,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    8,
                    "Consectetur expedita ab accusamus id mollitia quo voluptatum animi et.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3648),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Cumque eos ut quos nemo aut voluptatibus ratione.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3672),
                    1,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Aspernatur est maiores enim harum dolorem ut voluptatem sint rerum.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3693),
                    3,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    9,
                    "Numquam deserunt distinctio.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3715),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Id est rerum et nesciunt tenetur optio voluptatibus qui.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3727),
                    5,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    "Quae culpa cupiditate deserunt.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3748),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    "Quo veritatis repellendus velit.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3761),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    "Magnam eligendi quia.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3818),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Qui laboriosam accusantium deserunt voluptatem architecto.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3831),
                    5,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Aut itaque ipsum magni nisi consectetur.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3849),
                    2,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Culpa nemo fuga at aut.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3865),
                    2,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Culpa eos laborum corporis amet eveniet voluptatem magni consectetur.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3879),
                    3,
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    "Consectetur ad cum ipsa cumque.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3899),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Sit tenetur harum totam ducimus praesentium voluptas exercitationem.",
                    new DateTime(2024, 11, 9, 21, 0, 29, 488, DateTimeKind.Utc).AddTicks(3913),
                    2,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6063),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6221),
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
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6227),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6250),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6254),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6257),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6260),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6262),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6265),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6267),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6270),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6272),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6275),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6277),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6280),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6282),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6285),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6287),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6290),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6292),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6294),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6297),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6299),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6302),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6304),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6306),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6309),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6311),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6314),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 11, 9, 21, 0, 29, 489, DateTimeKind.Utc).AddTicks(6316),
                    2,
                }
            );
        }
    }
}
