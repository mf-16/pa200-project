using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.PostgreSQL.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddCouponsToCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "Coupons",
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
                    "Title",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(1467),
                    "Ipsam enim voluptas enim cupiditate cum corrupti. Ea ut quo. Sequi adipisci provident ea modi.",
                    "/images/cover-5.jpg",
                    34.14m,
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
                    "Title",
                },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3620),
                    "Sit officia laboriosam eveniet aut. Consequatur qui perspiciatis inventore. Est suscipit delectus. Ut ipsum aut ipsam voluptates magnam voluptatem et suscipit.",
                    "/images/cover-4.jpg",
                    77.74m,
                    "Quisquam maxime tempore.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Price", "PublisherId", "Title" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(3758),
                    "Ea sequi ut eius. Labore facere reiciendis sequi id in laudantium. Saepe nihil sed sunt laboriosam nulla commodi rem. Autem sit et eaque delectus eaque maxime animi quaerat. Sunt est ipsa libero doloribus voluptatem nemo animi repudiandae rem.",
                    29.43m,
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
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4285),
                    "Pariatur sapiente facere ut id et debitis odio. Et recusandae adipisci quo porro eos exercitationem et consequatur. Non quidem ut dolore alias atque. Accusamus corrupti rerum.",
                    "/images/cover-8.jpg",
                    10.94m,
                    7,
                    2,
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
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(4529),
                    "Aut eum nulla qui dolorum maiores provident quasi eum repellendus. A mollitia enim quia. Et architecto dolorem.",
                    "/images/cover-5.jpg",
                    45.41m,
                    5,
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5008),
                    "Voluptas consequatur dolor. Aliquam eveniet officiis fugiat qui veritatis temporibus. Et hic iusto. Fugit dicta ut quam et.",
                    65.90m,
                    7,
                    3,
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
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5100),
                    "Dolorum aliquid rerum odio velit sint eum in minus. Consequuntur non suscipit doloribus animi sunt sunt doloribus labore est. Facere consequuntur ut ut nemo consequatur explicabo quia. Qui saepe ut veritatis et alias cumque dolores. Minima rerum non ea iste recusandae rerum possimus.",
                    "/images/cover-2.jpg",
                    83.55m,
                    3,
                    2,
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 150, DateTimeKind.Utc).AddTicks(5237),
                    "Laborum nemo quia veritatis reprehenderit. Ipsum maiores reprehenderit porro magnam. Fuga est quis est hic libero aspernatur mollitia expedita corporis. Esse maxime dolor animi aut et vel iusto maxime repellat.",
                    "/images/cover-2.jpg",
                    88.48m,
                    2,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(2336),
                    15,
                    66.15m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3661),
                    14,
                    16.76m,
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
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3880),
                    5,
                    99.20m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3894),
                    3,
                    75.26m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3904),
                    5,
                    25.79m,
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
                    6,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3912),
                    12,
                    72.38m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    19,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3935),
                    7,
                    34.46m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3942),
                    14,
                    85.61m,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3974),
                    2,
                    40.70m,
                    2,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(3996),
                    13,
                    48.37m,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4080),
                    7,
                    68.84m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
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
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4119),
                    4,
                    40.71m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4126),
                    3,
                    32.50m,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4148),
                    5,
                    40.18m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4156),
                    13,
                    55.74m,
                    3,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4171),
                    11,
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
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4187),
                    89.65m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4194),
                    9,
                    15.82m,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4217),
                    6,
                    58.92m,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4231),
                    9,
                    33.64m,
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
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4246),
                    10,
                    57.78m,
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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4278),
                    1,
                    10.97m,
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
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4293),
                    86.68m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4300),
                    9,
                    10.98m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 14, 16, 41, 160, DateTimeKind.Utc).AddTicks(4308),
                    10,
                    48.20m,
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
                    new DateTime(2024, 12, 31, 14, 16, 41, 157, DateTimeKind.Utc).AddTicks(5846),
                    "Angie_Johns@yahoo.com",
                    "Angie Johns",
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
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(1737),
                    "Jay_Ledner32@hotmail.com",
                    "Jay Ledner",
                    0,
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
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(2295),
                    "Patricia_Donnelly@hotmail.com",
                    "Patricia Donnelly",
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
                    "ShippingAddressId",
                },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(5231),
                    "Lynda.Batz@gmail.com",
                    "Lynda Batz",
                    9,
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
                    "UserId",
                },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(6847),
                    "Rita_Runolfsson@hotmail.com",
                    "Rita Runolfsson",
                    3,
                    1,
                    9,
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
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(7371),
                    "Yolanda84@yahoo.com",
                    "Yolanda Harber",
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
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 14, 16, 41, 158, DateTimeKind.Utc).AddTicks(7892),
                    "Candice.Denesik@gmail.com",
                    "Candice Denesik",
                    5,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    "Qui nulla iusto corrupti at quidem voluptatem laboriosam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(489),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Iure temporibus amet consequuntur accusamus qui.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(568),
                    3,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Velit fugiat aut excepturi perferendis.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(593),
                    2,
                    6,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "Et nulla ut reprehenderit velit ullam animi.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(779),
                    4,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    "Deserunt et voluptate qui minima sint quaerat dolores quasi non.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(820),
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    13,
                    "Nihil dolor magnam voluptas qui nesciunt similique suscipit.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(876),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    6,
                    "Quibusdam asperiores molestias nihil.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(900),
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    "Quam ut quasi deleniti vitae nam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1084),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    8,
                    "Aut ducimus molestias aut quam.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1103),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    "Nihil est sint voluptatem mollitia.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1119),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    13,
                    "Perspiciatis quam ratione molestiae.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1136),
                    1,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    "Pariatur aliquam cum eos.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1280),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    17,
                    "Reprehenderit cumque suscipit ut eos voluptas id quas eligendi.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1296),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    18,
                    "Atque ea ut nemo.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1320),
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Nobis ut delectus occaecati nemo explicabo maxime.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1352),
                    4,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    4,
                    "Commodi ullam hic error atque ut voluptates id officiis sed.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1406),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Illum molestias quo.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1436),
                    4,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    13,
                    "Impedit vitae ipsam esse ut autem dolorem.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1450),
                    3,
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
                    15,
                    "Aliquam expedita sit saepe quia dolorum nostrum est id et.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1472),
                    3,
                    7,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    13,
                    "Iure facere non ratione sapiente quae sed sint expedita et.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1526),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Reiciendis occaecati velit voluptas ea et quibusdam odio.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1548),
                    3,
                    9,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Esse dolores ut.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1611),
                    1,
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    "Rerum est sed expedita quod id voluptatem aut error ipsa.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1641),
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
                    1,
                    "Earum veniam est facere porro ut.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1665),
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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    10,
                    "Vero voluptas sunt animi modi.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1737),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    20,
                    "In et architecto.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1789),
                    2,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    2,
                    "Rem placeat debitis recusandae ad pariatur.",
                    new DateTime(2024, 12, 31, 14, 16, 41, 152, DateTimeKind.Utc).AddTicks(1803),
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
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
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
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8234),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8238),
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
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8278),
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
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8285),
                    2,
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
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8293),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8297),
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
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8305),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8309),
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
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8316),
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
                    10,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8320),
                    6,
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
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8439),
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
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 14, 16, 41, 153, DateTimeKind.Utc).AddTicks(8447),
                    3,
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_CartId",
                table: "Coupons",
                column: "CartId"
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Carts_CartId",
                table: "Coupons",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Coupons_Carts_CartId", table: "Coupons");

            migrationBuilder.DropIndex(name: "IX_Coupons_CartId", table: "Coupons");

            migrationBuilder.DropColumn(name: "CartId", table: "Coupons");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Lylaside",
                    "Pitcairn Islands",
                    new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(8734),
                    "Delaware",
                    "573 Reilly Fort",
                    "49227",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Lake Monserratchester",
                    "Guadeloupe",
                    new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9380),
                    "Delaware",
                    "118 Cindy Circles",
                    "10359",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Yesseniabury",
                    "Jordan",
                    new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9559),
                    "Pennsylvania",
                    "9347 Stacy Dam",
                    "08927",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Lake Rae",
                    "Myanmar",
                    new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9703),
                    "South Carolina",
                    "48713 Kertzmann Junctions",
                    "82126",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Port Lenore",
                    "Aruba",
                    new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9851),
                    "Pennsylvania",
                    "225 Predovic Motorway",
                    "57087",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Jerrod",
                    "Ethiopia",
                    new DateTime(2024, 12, 31, 10, 21, 12, 316, DateTimeKind.Utc).AddTicks(9991),
                    "North Dakota",
                    "3836 Morar Street",
                    "35400-2307",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Wilfridfort",
                    "Zambia",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(143),
                    "North Dakota",
                    "50919 Dietrich Point",
                    "13721",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Madisentown",
                    "Peru",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(287),
                    "Pennsylvania",
                    "6982 Johanna Throughway",
                    "63055-9443",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Dachview",
                    "Afghanistan",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(427),
                    "Delaware",
                    "876 Wolff Court",
                    "26442",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "West Brennan",
                    "Mali",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(557),
                    "Massachusetts",
                    "74751 Dorthy Rest",
                    "56869-7537",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Carolineborough",
                    "Indonesia",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(697),
                    "Indiana",
                    "08696 Marquardt Groves",
                    "82408",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "New Mortimer",
                    "Ghana",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(839),
                    "Illinois",
                    "5964 Conn Plains",
                    "60565",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "Wildermanstad",
                    "Taiwan",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(971),
                    "Tennessee",
                    "7137 Gaylord Creek",
                    "52697",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "South Rudymouth",
                    "Myanmar",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(1140),
                    "Ohio",
                    "2949 Tracey Stream",
                    "22073",
                }
            );

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[]
                {
                    "New Rowan",
                    "Saint Vincent and the Grenadines",
                    new DateTime(2024, 12, 31, 10, 21, 12, 317, DateTimeKind.Utc).AddTicks(1311),
                    "Arizona",
                    "21642 Volkman Hills",
                    "28988-7958",
                }
            );

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[]
                {
                    "b9c3be38-82d1-488e-b809-94116487359b",
                    "279f6bf1-473a-4bb9-a299-1d42ed17aab3",
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
                    "e26b9886-3a64-4ae4-9537-62556e874c37",
                    "Price_Leannon26@hotmail.com",
                    "Orion Marks",
                    "(943) 237-3763 x6647",
                    "0962ea58-f8b5-43f1-9c72-76e7dd30f18c",
                    "Price_Leannon26@hotmail.com",
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
                    "62549ae6-6e00-4944-a66c-7cff204cec45",
                    "Amie57@yahoo.com",
                    "Richie Rice",
                    "637.421.0048",
                    "de290619-08b5-4d08-9096-ae333b6ab060",
                    "Amie57@yahoo.com",
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
                    "55d7046e-6d76-4275-b0c4-88c3651bdf65",
                    "Samanta.Bruen61@gmail.com",
                    "Emmy Wintheiser",
                    "782-255-1625 x539",
                    "0faba5f1-0bd6-4cd8-9b97-1ef714e739b1",
                    "Samanta.Bruen61@gmail.com",
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
                    "daed7a6b-972e-4b16-9e2c-2e1296ba0cf4",
                    "Friedrich_Robel@yahoo.com",
                    "Wanda Ledner",
                    "409-766-6109",
                    "a75b9401-8e02-48c5-b4d5-d61c05c4bc3c",
                    "Friedrich_Robel@yahoo.com",
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
                    "1b5a1f37-ed0e-4c73-9aa3-16ae5a2e31f2",
                    "Stephon55@hotmail.com",
                    "Mina MacGyver",
                    "850-733-1704 x451",
                    "e5f9f044-a69a-4fa4-b555-3bf31fb7dafd",
                    "Stephon55@hotmail.com",
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
                    "767c930b-3d73-414c-a31b-d7700cfb1e5a",
                    "Rylan14@yahoo.com",
                    "Golden Lind",
                    "436.963.4479 x9238",
                    "5a3d4d19-0812-4c13-a412-d2a1e8b0156c",
                    "Rylan14@yahoo.com",
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
                    "e9c585f7-ca1b-443e-b1ff-0c66ba8b1699",
                    "Jacky65@hotmail.com",
                    "Jackson Hyatt",
                    "1-601-719-5364",
                    "63d42e57-91a4-4aeb-b478-1ededbe525ca",
                    "Jacky65@hotmail.com",
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
                    "4d4825e9-530f-4624-84ba-db9b120a57f4",
                    "Janick.Wiegand@gmail.com",
                    "Jody Predovic",
                    "(362) 321-7035 x49347",
                    "7fb966f1-c8c8-4547-9233-0b2cd2613fad",
                    "Janick.Wiegand@gmail.com",
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
                    "2b28b1c3-b0e1-43b5-9c44-ddf77328b21a",
                    "Arely.Johnson21@gmail.com",
                    "Skyla White",
                    "1-632-741-3487",
                    "02ef7adb-1f9f-48a6-aa35-8e705fc19c8f",
                    "Arely.Johnson21@gmail.com",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Et pariatur possimus ut. Mollitia nihil tenetur totam labore aut et iure illo. Et in optio nam voluptas.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(1735),
                    "Jonathan Murray",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Ipsam deleniti officiis asperiores ad. Hic ut aut quasi recusandae dolorum ipsa molestiae laboriosam et. Numquam sint ea deleniti est voluptatem at voluptates aut. Et minima autem voluptatem sequi animi quo quae. Voluptas distinctio qui repellendus.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2174),
                    "Jeramie Bruen",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Explicabo molestiae sapiente temporibus. Non quis quia quia ducimus exercitationem consequatur atque unde. Nemo dolores et reprehenderit non et inventore voluptas.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2334),
                    "Kayley Roberts",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Praesentium consequatur odit praesentium necessitatibus dicta molestiae. Ut vel dolorum dolorum consequatur repudiandae et minus ratione aut. Consectetur voluptatem rerum sit perspiciatis quia vitae ut vel.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2460),
                    "Valerie Heathcote",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Consequuntur qui omnis. Minus animi fugiat. Ullam aspernatur veritatis aut neque ipsum dignissimos dolores sint. Ut facilis placeat.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2621),
                    "Alycia Rosenbaum",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Eaque cupiditate qui voluptatem quis aut illum delectus cupiditate. Sed temporibus sint. Numquam voluptate quidem id illum dolorum ut sed dicta totam. Inventore provident ad. Ea voluptas autem iste. Fuga eaque suscipit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2731),
                    "Christopher Abernathy",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Minus iste autem. At sapiente nisi. Nemo aspernatur qui fugiat nihil doloremque recusandae quia. Voluptates pariatur ut. Eos consequatur eos ut aut voluptate non.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2851),
                    "Samantha Swaniawski",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Facilis molestiae adipisci porro neque cupiditate omnis. Doloremque ut delectus quis ut quasi quisquam repellendus ea. Temporibus nobis est delectus. Aut unde ut perspiciatis possimus nihil eum praesentium. Dolore eligendi mollitia iure molestiae et dolor.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(2952),
                    "Lonie Ortiz",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Et blanditiis ullam dolorum iure voluptates. Et quaerat distinctio repellendus. Quos iusto autem consequuntur. Repudiandae iusto numquam repudiandae asperiores voluptate tenetur rerum amet eum. Iste porro nisi. Praesentium eveniet ut accusamus delectus veniam quas sint.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(3128),
                    "Amina Cummings",
                }
            );

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Dolores consequuntur est sequi repudiandae optio laborum officia quia quo. Assumenda totam ipsam deleniti neque eveniet. Cum est non atque voluptatum. Similique quae commodi necessitatibus optio in voluptate dolorem ut.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 308, DateTimeKind.Utc).AddTicks(3247),
                    "Orie Weber",
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
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(6201),
                    "Omnis reprehenderit eius doloribus unde inventore. Sint maxime nihil quam molestias. Et doloribus fuga similique. Sunt ullam neque.",
                    "/images/cover-7.jpg",
                    27.14m,
                    "Nulla est enim.",
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
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8297),
                    "Non velit nam libero fugiat ut incidunt inventore quos. Debitis earum provident nesciunt velit. Veritatis qui nemo id provident perspiciatis vitae earum.",
                    "/images/cover-5.jpg",
                    39.84m,
                    1,
                    1,
                    "Fuga adipisci voluptatem.",
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
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8449),
                    "Corrupti qui porro laboriosam et optio ad aspernatur ea. Libero totam aliquam eos quia nam esse sed excepturi quaerat. Quibusdam ut quibusdam maxime quam cupiditate ut officia.",
                    "/images/cover-1.jpg",
                    87.21m,
                    "Eum voluptatem nemo.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Price", "PublisherId", "Title" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8623),
                    "Ratione ab ipsum placeat doloribus. Ut unde voluptates. Libero sint et.",
                    23.29m,
                    1,
                    "Repellat occaecati aspernatur.",
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
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8715),
                    "Aut ratione quidem eveniet. Nihil voluptas cupiditate vitae nemo facere. Dolor culpa illo aut voluptas autem et eos. Dicta incidunt sunt ut enim veritatis. Omnis doloremque voluptas rem provident dicta repellat praesentium magnam odio. Et dicta vitae illo dicta laborum reiciendis.",
                    "/images/cover-4.jpg",
                    14.72m,
                    4,
                    "Rerum et excepturi.",
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(8989),
                    "Accusantium accusamus in architecto. Enim eos sint nobis at beatae impedit. Nesciunt et sit corporis temporibus nam accusamus ipsum ullam. Ducimus magnam est sunt. Et qui architecto accusamus voluptatem maiores dolorem architecto perspiciatis. Aut voluptate rerum quidem voluptates quasi facere adipisci hic aut.",
                    "/images/cover-7.jpg",
                    27.79m,
                    4,
                    "Praesentium laudantium officia.",
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
                    2,
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9245),
                    "Sint est animi repellendus ipsum mollitia voluptatem. Cumque nostrum consequuntur vero quidem facilis dolorem omnis dolor. In consequuntur earum esse odio eum ut sit et. Laboriosam quod eum at. Qui ea doloribus iusto voluptas.",
                    "/images/cover-5.jpg",
                    95.51m,
                    7,
                    5,
                    "Deleniti nostrum a.",
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
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9466),
                    "Ut ad quis occaecati et quos. Culpa voluptatem voluptas atque sit. Dignissimos debitis a nam non earum quis libero est optio. Quaerat sunt veritatis quis repellat voluptas. Doloribus cupiditate excepturi nam. Alias accusamus dignissimos et.",
                    "/images/cover-1.jpg",
                    49.86m,
                    2,
                    4,
                    "Autem quae et.",
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
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9675),
                    "Sequi vel delectus beatae. Expedita deserunt quos quos aspernatur. Similique fuga culpa sit eum illo. Expedita qui accusantium dolores. Maiores harum doloribus aliquam maiores ratione in expedita sint.",
                    "/images/cover-6.jpg",
                    20.92m,
                    6,
                    "Culpa id illum.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[]
                {
                    "CreatedDate",
                    "Description",
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "Title",
                },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 311, DateTimeKind.Utc).AddTicks(9833),
                    "Aspernatur sit aspernatur rem est cumque porro omnis. Fuga autem aut deserunt velit sint reprehenderit soluta cumque. Velit et quis sit quia est corrupti in quibusdam. Itaque quis corporis quasi. Quisquam sunt autem recusandae maxime. Dolorem harum quasi.",
                    "/images/cover-3.jpg",
                    83.95m,
                    1,
                    "Nisi accusamus blanditiis.",
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
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(9),
                    "Aut iste error impedit tenetur non deserunt est velit. At vitae cum est. Quasi et eos. Maxime quisquam eligendi consectetur quo ab. Autem debitis consectetur cumque adipisci voluptas aperiam accusamus nulla. Alias sit itaque quia quibusdam quaerat iure quo.",
                    "/images/cover-1.jpg",
                    54.02m,
                    3,
                    4,
                    "Qui in suscipit.",
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
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(205),
                    "Illo magnam dicta et esse amet necessitatibus aut alias. Officiis ex rem cum optio quia vel est. Officia nisi aliquid provident accusamus recusandae vel incidunt dicta. Ut suscipit cumque veritatis deserunt non ullam sint hic. Est saepe nesciunt molestiae est qui mollitia perspiciatis. Quis quo aliquam quas molestias aut magnam quisquam nesciunt.",
                    50.08m,
                    3,
                    2,
                    "Molestiae iste totam.",
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
                    10,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(426),
                    "Voluptas veniam odio dolorem. Eius soluta aut fuga temporibus. Doloremque quis et aut. Quos nihil enim quis nemo tempora aut et qui et. Fugiat sint sit possimus quia et mollitia doloribus rerum.",
                    "/images/cover-7.jpg",
                    89.33m,
                    4,
                    4,
                    "Architecto quod qui.",
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(540),
                    "Accusamus sunt numquam et possimus nihil deserunt est. Minima ea quo nemo dignissimos praesentium. Sed suscipit et ea exercitationem vero nemo ipsa. Dolorem non veritatis ratione occaecati non omnis quas quisquam voluptates. Non excepturi id cupiditate sunt. Magni nesciunt perspiciatis.",
                    12.94m,
                    3,
                    4,
                    "Exercitationem esse molestiae.",
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
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(719),
                    "Neque amet odit dolorem ut aut. Labore perspiciatis occaecati in est rerum ex. Quia sint et. Consequatur eaque ea non voluptatem dolores rerum dolores qui. Dolorem vel animi occaecati magnam sit fuga quisquam. Et iste possimus.",
                    "/images/cover-4.jpg",
                    13.03m,
                    1,
                    5,
                    "Et animi molestiae.",
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
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(862),
                    "Eligendi expedita odit quis recusandae doloribus est quia voluptatem rerum. Optio fugit incidunt qui. Ex rerum quasi consequatur quod facere.",
                    "/images/cover-5.jpg",
                    13.90m,
                    5,
                    "Autem ut commodi.",
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
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(938),
                    "Odit placeat beatae occaecati. Quis delectus et laboriosam et sint. Esse quia nihil dolorem. Velit sequi ut minima aspernatur.",
                    "/images/cover-8.jpg",
                    84.82m,
                    7,
                    4,
                    "Delectus nemo asperiores.",
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
                    "ImagePath",
                    "Price",
                    "PrimaryGenreId",
                    "PublisherId",
                    "Title",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(1050),
                    "Qui architecto explicabo illum est aut voluptas. Cumque perferendis atque. Incidunt sit at ducimus quidem quos delectus aperiam. Sapiente maxime ipsa perferendis facilis est repudiandae. Quaerat natus ea ut a. Deleniti eos asperiores.",
                    "/images/cover-5.jpg",
                    42.26m,
                    3,
                    3,
                    "Quia sed quis.",
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
                    10,
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(1188),
                    "Vel odio repellendus tempora recusandae velit. Ut voluptas eum soluta qui. Ut ducimus eius omnis sed mollitia optio. Ut consequatur rerum est amet minus aut necessitatibus.",
                    "/images/cover-10.jpg",
                    16.60m,
                    1,
                    5,
                    "Explicabo dolore ut.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
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
                    new DateTime(2024, 12, 31, 10, 21, 12, 312, DateTimeKind.Utc).AddTicks(1277),
                    "Ea aut quo sit. Consequatur qui non et ex et delectus nostrum. Impedit dolores aut. Molestiae et ipsa aperiam. Corrupti hic nostrum dolore in itaque inventore quia ut dolores.",
                    "/images/cover-3.jpg",
                    97.32m,
                    1,
                    2,
                    "Pariatur delectus consequatur.",
                }
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7919)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7922)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7922)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7922)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7923)
            );

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7924)
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(5955),
                    11,
                    70.45m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7233),
                    11,
                    46.12m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7293),
                    3,
                    69.26m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7307),
                    9,
                    89.57m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7317),
                    7,
                    65.90m,
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
                    13,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7325),
                    3,
                    98.35m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7334),
                    2,
                    84.08m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7343),
                    12,
                    21.10m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7350),
                    11,
                    73.39m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7358),
                    6,
                    71.79m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7366),
                    11,
                    57.36m,
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
                    3,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7373),
                    2,
                    16.06m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7380),
                    10,
                    17.20m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7438),
                    8,
                    59.29m,
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
                    13,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7446),
                    12,
                    38.30m,
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
                    14,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7454),
                    10,
                    55.66m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7462),
                    7,
                    78.33m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7470),
                    6,
                    99.79m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7477),
                    2,
                    29.47m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7486),
                    3,
                    45.72m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7493),
                    13,
                    74.85m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7501),
                    10,
                    70.16m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7508),
                    10,
                    28.83m,
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
                    19,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7516),
                    14,
                    25.04m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7524),
                    14,
                    26.04m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    4,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7531),
                    8,
                    11.03m,
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
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7539),
                    8,
                    30.51m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7547),
                    2,
                    44.54m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7555),
                    12,
                    52.90m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7562),
                    2,
                    55.92m,
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
                    17,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7569),
                    12,
                    37.16m,
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    18,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7577),
                    7,
                    25.90m,
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
                    14,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7585),
                    7,
                    12.20m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7592),
                    51.34m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7600),
                    11,
                    27.43m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7607),
                    2,
                    85.03m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7615),
                    9,
                    15.42m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7623),
                    5,
                    83.38m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7631),
                    12,
                    48.98m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7638),
                    14,
                    58.84m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7646),
                    10,
                    63.75m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7654),
                    3,
                    24.06m,
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
                    9,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7662),
                    8,
                    70.10m,
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
                    16,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7670),
                    15,
                    58.26m,
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
                    18,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7677),
                    7,
                    38.60m,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    9,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7719),
                    11,
                    48.38m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7727),
                    14,
                    36.25m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[]
                {
                    17,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7734),
                    62.57m,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[]
                {
                    11,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7742),
                    8,
                    64.30m,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 321, DateTimeKind.Utc).AddTicks(7750),
                    6,
                    77.37m,
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
                    11,
                    new DateTime(2024, 12, 31, 10, 21, 12, 318, DateTimeKind.Utc).AddTicks(5899),
                    "Audrey_Kessler@gmail.com",
                    "Audrey Kessler",
                    13,
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
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 10, 21, 12, 318, DateTimeKind.Utc).AddTicks(9645),
                    "Vanessa6@hotmail.com",
                    "Vanessa Vandervort",
                    0,
                    15,
                    9,
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
                    9,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(984),
                    "Teresa_Torp@gmail.com",
                    "Teresa Torp",
                    1,
                    13,
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
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(1859),
                    "Susie_Denesik@hotmail.com",
                    "Susie Denesik",
                    4,
                    1,
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
                    11,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(2665),
                    "Jeffrey_Monahan@hotmail.com",
                    "Jeffrey Monahan",
                    10,
                    5,
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
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(3383),
                    "Felix_McGlynn@gmail.com",
                    "Felix McGlynn",
                    1,
                    4,
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
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(4194),
                    "Elmer46@gmail.com",
                    "Elmer Lindgren",
                    4,
                    1,
                    3,
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
                    4,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(4928),
                    "Wanda.Langworth@gmail.com",
                    "Wanda Langworth",
                    2,
                    10,
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
                    3,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(5616),
                    "Margarita64@yahoo.com",
                    "Margarita Schuppe",
                    2,
                    5,
                    8,
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
                    2,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(6396),
                    "Bernice.Schultz7@gmail.com",
                    "Bernice Schultz",
                    2,
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
                    10,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(7080),
                    "Darla_Durgan75@hotmail.com",
                    "Darla Durgan",
                    10,
                    3,
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
                    2,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(7761),
                    "Gregg.McClure49@gmail.com",
                    "Gregg McClure",
                    5,
                    15,
                    6,
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
                    "UserId",
                },
                values: new object[]
                {
                    2,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(8475),
                    "Sandra58@hotmail.com",
                    "Sandra Pfeffer",
                    1,
                    3,
                    7,
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
                    11,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(9171),
                    "Stuart_Dickinson@gmail.com",
                    "Stuart Dickinson",
                    7,
                    3,
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
                    "OrderState",
                    "ShippingAddressId",
                    "UserId",
                },
                values: new object[]
                {
                    10,
                    new DateTime(2024, 12, 31, 10, 21, 12, 319, DateTimeKind.Utc).AddTicks(9875),
                    "Michael.Kerluke61@gmail.com",
                    "Michael Kerluke",
                    1,
                    12,
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
                    "Hic ipsa accusamus fuga corporis minus et minus. Explicabo voluptatibus et. Ea qui amet. Consequatur ea et nemo.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 309, DateTimeKind.Utc).AddTicks(9605),
                    "Wilderman, Reichert and O'Connell",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Reprehenderit ratione omnis tempore doloremque cumque dicta at facilis. Cumque alias odit et sed amet architecto odit eum dicta. Natus aut et sed perspiciatis modi labore placeat quam fugiat. Dolor iste nulla ratione non iste deserunt aspernatur ab. Facere reprehenderit ad ipsum voluptatum sint provident aut repudiandae. Consequuntur dignissimos eos tempore omnis temporibus aut fugit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(349),
                    "Schumm and Sons",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Esse eius fugit earum. Occaecati iure aut dignissimos quaerat sed et commodi et. Tempora saepe quis animi qui et omnis error in. Eum perferendis sit accusantium et harum nesciunt.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(743),
                    "Windler - Zieme",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Aliquid et aut veniam ullam omnis. Rerum voluptas dolores tempora sint consequatur ab laboriosam. Natus ex labore quia repellendus. Id corporis veritatis.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(957),
                    "Zemlak Group",
                }
            );

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[]
                {
                    "Neque in odit repellendus dicta maiores. Doloremque ad dolor quia sapiente fugit minima aliquid quo. Ullam adipisci odit amet culpa asperiores nostrum. Suscipit qui eum est aut cum officiis iste doloremque. Est enim commodi quia nihil eaque similique laboriosam. A voluptate dolorem perspiciatis.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 310, DateTimeKind.Utc).AddTicks(1138),
                    "Wisozk - Jenkins",
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    5,
                    "Ipsam dignissimos dolorem et delectus.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(7301),
                    1,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    "Rem et id officiis.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(8766),
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
                    9,
                    "Culpa ducimus nostrum sapiente quisquam adipisci consequuntur.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(8858),
                    2,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Quaerat debitis omnis voluptatem delectus ut.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(8971),
                    3,
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    4,
                    "Ut ea tempora eos assumenda qui quas dolorem praesentium.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9018),
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
                    15,
                    "Sapiente quis voluptatem.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9077),
                    2,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Quo aliquam omnis quia.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9107),
                    2,
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
                    19,
                    "Assumenda ratione sequi aut.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9131),
                    1,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    "Cumque aut aliquid qui error eum aut asperiores sit inventore.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9147),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    "Ut recusandae impedit sint sunt et odit et consequatur.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9179),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    "Et eligendi harum eum quibusdam saepe cumque doloremque.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9212),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    3,
                    "Reiciendis natus est qui sunt qui rerum qui omnis.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9269),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    2,
                    "Consequatur eos possimus sed dicta odit maiores explicabo ducimus praesentium.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9298),
                    4,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    16,
                    "Laborum magnam enim quo nulla aperiam et dicta sed voluptatibus.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9327),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Officia quidem officiis molestiae quae.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9358),
                    4,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    4,
                    "Aut doloremque ut ducimus aut non quasi et eaque cumque.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9376),
                    3,
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    17,
                    "Aut neque maxime voluptas sint unde et.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9409),
                    3,
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    15,
                    "Maiores sunt quibusdam ab autem voluptas nulla.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9433),
                    5,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    "Id maxime qui autem dolore.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9488),
                    10,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    1,
                    "Quis aliquam aspernatur blanditiis dolor voluptas optio et odit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9509),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    "Nemo voluptates odit cupiditate vel nihil.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9536),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    9,
                    "Provident eligendi quo quis aut eligendi voluptas.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9558),
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
                    5,
                    "Commodi illum ducimus eligendi optio distinctio qui.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9579),
                    3,
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Consequatur incidunt tenetur totam.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9602),
                    4,
                    3,
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
                    "Omnis temporibus non corporis cum sit fuga architecto.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9618),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    "Doloribus ratione eaque.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9642),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[]
                {
                    3,
                    "Quis veritatis soluta tempora rerum soluta rerum et suscipit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9658),
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    "Eum corrupti aut quia ut perspiciatis dicta deserunt.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9701),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Distinctio a et omnis officia culpa error.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9726),
                    1,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    18,
                    "Deleniti quo non vel ea sint tempora.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9749),
                    3,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    9,
                    "Consequatur odio dolor autem optio corporis omnis autem.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9772),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Quaerat sapiente ipsum saepe id sed ad non in.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9795),
                    1,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    3,
                    "Ab nesciunt perferendis recusandae.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9822),
                    2,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    10,
                    "Voluptatibus voluptatem voluptatem qui cupiditate voluptas delectus dolor.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9837),
                    5,
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    1,
                    "Consequuntur asperiores minus fugit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9946),
                    3,
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
                    12,
                    "Velit accusantium et et.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9963),
                    5,
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    16,
                    "Cumque autem consequatur molestias esse.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9979),
                    1,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    12,
                    "Voluptates odit odio enim aut et et sit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 313, DateTimeKind.Utc).AddTicks(9998),
                    1,
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
                    20,
                    "Ipsam velit aut voluptas qui repellat rerum atque soluta.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(21),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    9,
                    "Quibusdam dolores autem itaque aut qui.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(47),
                    3,
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
                    12,
                    "Delectus vel dignissimos.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(67),
                    2,
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
                    8,
                    "Vel dolores maxime aut.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(80),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    6,
                    "Molestias libero eaque voluptatem.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(136),
                    4,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Aperiam eveniet nam illo nulla autem.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(154),
                    4,
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
                    3,
                    "Illum ut ab ipsam deserunt necessitatibus sed consequuntur.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(175),
                    4,
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    13,
                    "Ipsam error voluptatibus.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(202),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[]
                {
                    17,
                    "Error ea vel dignissimos porro est harum velit.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(214),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    11,
                    "Quia laboriosam officiis fugiat animi assumenda suscipit similique placeat dolorem.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(237),
                    3,
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    "Debitis enim ea adipisci repellendus voluptate vel aut esse consequatur.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(263),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[]
                {
                    8,
                    "Ea natus sit et.",
                    new DateTime(2024, 12, 31, 10, 21, 12, 314, DateTimeKind.Utc).AddTicks(290),
                    5,
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
                    20,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4337),
                    8,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    16,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4525),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4533),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4536),
                    8,
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
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4540),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    6,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4543),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4546),
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
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4549),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    3,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4552),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4555),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    1,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4558),
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
                    14,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4562),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4565),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    14,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4568),
                    9,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4570),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4573),
                    2,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[]
                {
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4576),
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
                    15,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4579),
                    6,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    20,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4582),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    13,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4585),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4588),
                    5,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4591),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    8,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4594),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    7,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4597),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    5,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4643),
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
                    4,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4646),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    12,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4650),
                    3,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4653),
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    15,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4656),
                    7,
                }
            );

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[]
                {
                    19,
                    new DateTime(2024, 12, 31, 10, 21, 12, 315, DateTimeKind.Utc).AddTicks(4659),
                    7,
                }
            );
        }
    }
}
