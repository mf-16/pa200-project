using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.PostgreSQL.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Hudsonville", "Montenegro", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(8571), "Vermont", "4943 Gretchen Orchard", "36383" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Leonardoburgh", "Myanmar", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9125), "Idaho", "88605 Pouros Neck", "66222" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Feilborough", "Lithuania", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9245), "North Dakota", "3627 Cremin Ramp", "08391-0799" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Priceberg", "Nigeria", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9403), "Missouri", "8588 George Street", "86896-7731" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "South Leone", "Morocco", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9528), "Georgia", "8752 Green Burgs", "59223-1982" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Lindgrenton", "Tuvalu", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9640), "Arkansas", "1760 Crist Drive", "89593-7800" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Eltonside", "United States Minor Outlying Islands", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9789), "Delaware", "0585 Nolan Ferry", "44239-3010" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "New Augustus", "Samoa", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9874), "Colorado", "31356 Karina Circle", "35941-9765" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Murrayville", "Ireland", new DateTime(2024, 12, 11, 10, 37, 15, 312, DateTimeKind.Utc).AddTicks(9990), "Louisiana", "854 Jerde Junction", "86907" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Jovanmouth", "Aruba", new DateTime(2024, 12, 11, 10, 37, 15, 313, DateTimeKind.Utc).AddTicks(101), "Pennsylvania", "6368 Dewayne Isle", "70641" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Gerardomouth", "Bahrain", new DateTime(2024, 12, 11, 10, 37, 15, 313, DateTimeKind.Utc).AddTicks(213), "Utah", "873 Leannon Ranch", "19795" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Bonitatown", "Cayman Islands", new DateTime(2024, 12, 11, 10, 37, 15, 313, DateTimeKind.Utc).AddTicks(311), "Colorado", "37677 Price Island", "06623" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "North Alberta", "Hong Kong", new DateTime(2024, 12, 11, 10, 37, 15, 313, DateTimeKind.Utc).AddTicks(460), "West Virginia", "756 Mavis Square", "29305-1820" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Norahaven", "Russian Federation", new DateTime(2024, 12, 11, 10, 37, 15, 313, DateTimeKind.Utc).AddTicks(582), "Pennsylvania", "47395 Glover Squares", "99176-7972" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Mayerview", "Armenia", new DateTime(2024, 12, 11, 10, 37, 15, 313, DateTimeKind.Utc).AddTicks(693), "Indiana", "193 Larson Lodge", "27664-6784" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9d7cf6e6-339d-47e4-9f3a-9705318029df", "6c9cbbca-970a-4f21-9d92-9ff7788c19ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2eb72fa8-eb6b-4666-a48d-90b793d67460", "Vella.Kozey@hotmail.com", "Dwight Considine", "891.696.7718", "51ff2db4-9776-433b-8af7-5200b36ff34e", "Vella.Kozey@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "b2581bbd-9698-4930-9b07-5295ca502751", "Mya.Schmitt76@hotmail.com", "Eva Morissette", "747-537-6709 x16943", "a3996e9f-ec60-46c2-94bf-d8eee2551272", "Mya.Schmitt76@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a9196a24-81fb-4251-a3d1-77d2888705cb", "Blaze_Schuster36@hotmail.com", "Ramiro Cormier", "(450) 362-3959", "688fa992-5d60-4527-bda6-b2c1b3e900cd", "Blaze_Schuster36@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "0bc4241f-4524-4144-aacf-5ef235b7b3eb", "Geovanni72@yahoo.com", "Dustin Gutkowski", "(964) 214-2124 x472", "2ce47774-5946-4acb-bbf8-c96e04deed31", "Geovanni72@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "9529d757-7d32-4c8a-ad75-80c8016ddaf0", "Savion.Jacobi@gmail.com", "Katarina Sanford", "311-545-2157 x7094", "0ccf0104-606a-4c42-bca9-5dea04324188", "Savion.Jacobi@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "be88f3f8-68b7-4d1f-8b87-bdd952a0e0ca", "Corine.DuBuque6@hotmail.com", "Brando Mertz", "1-516-503-4451", "b02ffc91-0701-4b57-ad1c-bcc2e4e3a5a7", "Corine.DuBuque6@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "25139ef5-03d0-4518-b2cc-57a583f85573", "Jaren_Leannon@yahoo.com", "Raymond Schulist", "209.653.2355 x501", "029fdcdf-1fe4-4647-ab22-168cd96cdc84", "Jaren_Leannon@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "70db9879-e52f-4a83-8849-b90633457e9e", "Grayce.Willms3@gmail.com", "Ova Bayer", "581.621.4560", "390e05a1-2d26-4bd1-8612-c0faaf50b0a0", "Grayce.Willms3@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e6e85690-f782-4a1f-9256-5e62591ee5f9", "Zakary23@hotmail.com", "Marlene Prosacco", "728.616.3312", "47e2a451-ec05-4b46-9c95-80b6a86d2a2e", "Zakary23@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Quo facere iusto occaecati eos quo ipsum consequatur animi. Quod ipsa voluptas quam molestiae mollitia suscipit magnam et aut. Aliquid aut eos voluptas mollitia distinctio inventore aut. Omnis voluptatem explicabo nemo sit. Odio aliquid officiis.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(8179), "Sedrick Mayert" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Neque magnam possimus similique dolorum non qui cum qui. Et illum et reprehenderit voluptas est sed cupiditate eos quia. Excepturi iure error. Ea quo et sapiente officiis cum exercitationem illum. Voluptatum voluptatem quasi velit recusandae rem. Mollitia eaque repellat enim rerum necessitatibus fugiat.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(8615), "Sheridan Hand" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Deleniti aut quis asperiores tempore doloribus vel autem veniam. Veniam in quibusdam sit animi est ipsum quia non. Veniam minima quod excepturi libero. Esse aliquid inventore. Qui nisi neque rerum nostrum explicabo iusto natus. Quis pariatur hic iusto porro minima deserunt eveniet alias quis.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(8767), "Nathaniel Hackett" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Voluptates nesciunt animi qui. Qui sequi nulla et dolores est asperiores nemo consequatur. Nihil quia tempora impedit laborum sit. Veniam quia eius enim ratione fuga non sed quaerat quia. Explicabo unde non unde.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(8920), "Hanna Bogan" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Nulla labore aspernatur accusantium. Quia laborum perferendis tempore et officiis laborum porro alias illum. Sunt amet quia qui et adipisci esse. Sed consequatur aspernatur sed ducimus ut distinctio.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(9040), "Adolfo Hermann" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Sit nesciunt consequatur. Sunt deserunt numquam aut tempore repudiandae dolore occaecati. Ipsum magnam quis expedita.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(9122), "Lavon Glover" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Nisi ducimus sequi facere labore sed voluptatum rerum. Sint et omnis aut dolor sit ut. Ducimus voluptatem ipsa accusantium autem voluptate ut quaerat possimus.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(9197), "Forest Goodwin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Veniam ut optio cum deserunt ducimus. Blanditiis hic nemo enim tempora maiores. Itaque porro ducimus corporis magni minus quod odit numquam. Eveniet itaque repellat molestias nemo quia voluptatibus esse. Quaerat reiciendis possimus.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(9259), "Ida Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Facilis placeat impedit rem sint. Non at nihil dolorum. Porro sunt veritatis voluptas nam voluptatem ex ut. Facilis dolor aut deleniti quia adipisci molestias non porro vitae.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(9354), "Immanuel Runolfsson" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Id voluptatem quisquam autem sapiente voluptatem. Magni veritatis inventore aliquam culpa non iusto mollitia fugit. Laudantium animi accusantium blanditiis est vel impedit pariatur culpa quaerat. Ut magnam in tenetur ut id delectus vitae. Eum neque sit. Est possimus ducimus.", new DateTime(2024, 12, 11, 10, 37, 15, 305, DateTimeKind.Utc).AddTicks(9421), "Johnnie Lubowitz" });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Fantasy");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Horror");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Science Fiction");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Mystery");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Romance");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Thriller");

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "Name" },
                values: new object[] { 7, "Historical Fiction" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 308, DateTimeKind.Utc).AddTicks(8278), "Nisi vero aut a. Fugiat ipsam recusandae temporibus numquam est odio dicta quo. Eius delectus deleniti et. Vitae et hic voluptatem. Animi est modi.", "/images/cover-5.jpg", 95.69m, 7, 3, "Architecto numquam similique." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(83), "Eaque id non ab ut similique. Quam blanditiis quo aut iure ut. Facere et nobis in incidunt et sit. Iusto est sequi nihil vitae et repellendus ratione. Voluptatum cupiditate et tempora dolores.", "/images/cover-1.jpg", 60.54m, 7, 2, "Sapiente quo sequi." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(289), "Pariatur delectus ullam ut. Sed beatae culpa mollitia labore itaque consequatur. Est quasi repellat et illum fuga. Sed omnis harum consectetur.", "/images/cover-4.jpg", 68.67m, 7, 2, "Veniam commodi illum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(424), "Odit consectetur qui rerum omnis aut est ipsam fugit. Rerum omnis illo ut dolor aut. Ea quos cum corrupti dolorem.", "/images/cover-5.jpg", 69.53m, "Necessitatibus qui fugit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(496), "Consequuntur omnis eos ut quos deleniti sequi facere dolores. Praesentium enim aut voluptatem. Ratione est corrupti provident dolorum. Sunt exercitationem et quis sit in animi. Fugit quae ut.", 33.60m, 1, 2, "Dicta consequatur iusto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(606), "Explicabo quas enim non. Molestiae nostrum esse labore molestiae. Consectetur saepe earum. Beatae quaerat repellat et maxime laborum sit voluptatibus facere assumenda. Ut suscipit magni saepe magnam dolor provident expedita veritatis.", "/images/cover-7.jpg", 36.48m, 6, 5, "Vero eum corrupti." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(702), "Eveniet eum voluptate delectus iure a deserunt. Id ullam debitis. Molestias ut sapiente.", "/images/cover-5.jpg", 11.43m, 1, 5, "Qui dolorum qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(775), "Ut id culpa enim necessitatibus aliquam. Maxime omnis veniam est itaque in quisquam reprehenderit. Ea veritatis enim enim. Commodi deserunt dolor voluptatem. Unde ipsa aspernatur consequatur.", "/images/cover-8.jpg", 22.94m, 2, 4, "Voluptatem incidunt maiores." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(872), "Suscipit esse sit excepturi numquam. Eum deleniti molestias voluptatem et quod aut reprehenderit. Eos est nemo est fugiat quas illo et. Deserunt possimus odio et nulla voluptas et. Voluptas alias qui rem.", "/images/cover-9.jpg", 20.30m, 3, 5, "Commodi quaerat dolor." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(957), "Quia vitae sit iusto eum expedita et voluptate voluptatum. Unde ad et dolorem iste fugit non qui explicabo labore. Quo porro et deserunt laborum quibusdam ad. Similique sapiente unde.", "/images/cover-3.jpg", 46.06m, 6, 5, "Blanditiis sed minus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1059), "Officiis aliquam esse enim beatae. Molestiae at deleniti sunt quibusdam sit soluta. Laborum placeat est dicta sunt omnis natus itaque quibusdam ipsa. Neque quisquam rem quas dolor magnam explicabo dolores aperiam eaque. Nostrum et suscipit aut beatae nihil facilis velit hic. Architecto eos necessitatibus consequatur quasi repellat soluta.", "/images/cover-8.jpg", 39.76m, 4, "Aperiam ipsa architecto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PublisherId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1184), "Numquam molestias perspiciatis quia expedita quae necessitatibus et suscipit maiores. Velit odio nihil. Ut provident sit. Sint eum perferendis vero fuga eligendi. Vero nulla hic.", "/images/cover-10.jpg", 80.05m, 2, "Nostrum mollitia reiciendis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1256), "Sunt corporis id numquam ducimus. Ipsam culpa neque repellendus modi nihil tenetur. Dolorem vel exercitationem explicabo ipsa necessitatibus esse voluptatibus voluptatum provident. Nobis quam delectus. Aut animi quis ut aperiam. Quo et eos ut est eum fugit quidem earum.", "/images/cover-7.jpg", 14.46m, 7, 5, "Dolore temporibus et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PublisherId", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1423), "Dolor molestiae et labore deleniti. Sint animi quas tempore numquam aspernatur velit explicabo est est. Cumque veniam repellat. Eos illo non rem laboriosam.", "/images/cover-8.jpg", 31.40m, 5, "Et rem rerum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1522), "Odio dolorum quia fugit incidunt ad cumque totam laboriosam similique. Et omnis ad in voluptate ab ut ex culpa. Voluptatum suscipit rerum deserunt sit totam architecto. Illo quo libero suscipit ut sequi cumque placeat quibusdam similique.", "/images/cover-4.jpg", 90.57m, 7, 3, "Nesciunt et ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1603), "Fuga hic doloremque omnis. Tempora expedita ut ea ea blanditiis. Suscipit atque odio asperiores illo earum. Illo tempora est qui.", "/images/cover-9.jpg", 50.62m, 3, 2, "Nobis accusamus omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1687), "Assumenda asperiores voluptatem. Et est error et rem qui. Eius sed reiciendis laboriosam earum fugiat. Facilis dolores nihil facere cumque rerum commodi rem sint cumque. Sit quod vel autem ut laboriosam ut. Ipsam soluta deserunt.", "/images/cover-4.jpg", 36.82m, 1, 2, "Est aut non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1798), "Dicta est corrupti culpa facilis et pariatur nesciunt non. Eos ad modi nulla sit saepe ut corporis voluptatem eaque. Laboriosam ea ut corrupti porro delectus ipsum. Eum illo dolores iste consequatur impedit. Qui qui et laboriosam illo iste vel. Odio nostrum eaque.", "/images/cover-8.jpg", 43.39m, 7, 5, "Perferendis deleniti sint." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1910), "Repudiandae corrupti sit. Commodi fuga ipsa est voluptatibus fugit maiores sunt ullam perferendis. Ex et natus facilis beatae occaecati ipsam.", "/images/cover-5.jpg", 73.97m, 6, 2, "Omnis ut incidunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 309, DateTimeKind.Utc).AddTicks(1968), "Qui delectus repudiandae aspernatur vitae vitae est nemo ea hic. Odit voluptas vel expedita dolor. Et omnis ex iste libero dolor. Aut laudantium rem quia blanditiis in autem et.", "/images/cover-7.jpg", 25.42m, 6, 5, "Natus provident fugit." });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(4089), 11, 47.43m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5215), 5, 56.41m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5252), 1, 10.06m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5263), 13, 97.23m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5270), 1, 99.75m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5278), 15, 65.33m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5285), 10, 66.70m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5293), 13, 41.72m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5300), 82.25m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5308), 6, 44.04m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5315), 14, 85.27m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5322), 1, 99.39m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5329), 2, 41.14m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5336), 12, 18.17m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5344), 10, 28.72m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5350), 7, 67.68m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5357), 8, 38.64m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5363), 9, 13.43m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5370), 11, 34.92m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5377), 12, 60.39m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5383), 2, 36.98m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5390), 8, 93.31m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5397), 4, 82.25m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5405), 6, 52.63m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5411), 13, 79.03m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5418), 11, 35.02m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5424), 42.61m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5431), 10, 53.28m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5438), 38.53m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5445), 15, 96.50m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5501), 10, 10.18m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5509), 84.24m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5515), 2, 45.79m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5522), 3, 14.47m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5528), 10, 44.20m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5536), 1, 48.46m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5542), 15, 29.03m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5549), 11, 49.05m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5557), 11, 43.50m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5563), 4, 33.19m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5570), 13.77m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5576), 15, 94.45m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5583), 5, 53.51m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5589), 12, 32.95m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5596), 13, 31.36m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5602), 4, 65.13m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5609), 1, 22.68m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5615), 2, 49.87m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5622), 5, 64.69m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 316, DateTimeKind.Utc).AddTicks(5628), 14, 59.25m, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(1772), "Marco_Brown18@gmail.com", "Marco Brown", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(4167), "Dewey77@gmail.com", "Dewey Mayert", 13, 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(4953), "Karen_Krajcik@yahoo.com", "Karen Krajcik", 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(5604), "Ernest68@hotmail.com", "Ernest Powlowski", 6, 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(6078), "Sidney.Schmitt2@yahoo.com", "Sidney Schmitt", 9, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(6471), "Juan.Nolan90@yahoo.com", "Juan Nolan", 5, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(6983), "Delores.Thiel49@gmail.com", "Delores Thiel", 11, 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(7480), "Wendell_Ruecker@gmail.com", "Wendell Ruecker", 13, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(7888), "Jermaine_Satterfield@gmail.com", "Jermaine Satterfield", 7, 8 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(8364), "Margarita7@gmail.com", "Margarita Wehner", 11, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(8885), "Jessica50@hotmail.com", "Jessica Schamberger", 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(9338), "Lyle_Kunde@gmail.com", "Lyle Kunde", 7, 8 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 314, DateTimeKind.Utc).AddTicks(9745), "Ruth_Will@hotmail.com", "Ruth Will", 12, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 315, DateTimeKind.Utc).AddTicks(172), "Christine41@gmail.com", "Christine Reynolds", 3, 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 315, DateTimeKind.Utc).AddTicks(625), "Brian84@yahoo.com", "Brian Tillman", 5, 7 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "In animi et. Iure quam voluptas autem. Cum id quas et aut doloribus aspernatur. Quasi et esse qui. Enim similique adipisci eveniet vero perspiciatis exercitationem rerum. Autem laudantium rerum aut sunt reiciendis sapiente reiciendis aut.", new DateTime(2024, 12, 11, 10, 37, 15, 307, DateTimeKind.Utc).AddTicks(3897), "Mohr - Mills" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Ducimus nemo amet recusandae et doloremque natus ut dolor ipsa. Ut placeat eos. Omnis autem eaque voluptatem. Illo iste omnis ut.", new DateTime(2024, 12, 11, 10, 37, 15, 307, DateTimeKind.Utc).AddTicks(4561), "Pfannerstill - O'Reilly" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Voluptatem dicta et. Fuga assumenda dolor assumenda quis animi et beatae aut. Iusto fugiat tenetur placeat ab recusandae possimus. Accusantium consequatur voluptas omnis aut eius architecto. Quas et totam quod placeat sed consequatur.", new DateTime(2024, 12, 11, 10, 37, 15, 307, DateTimeKind.Utc).AddTicks(4721), "Glover - Weissnat" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Libero aut commodi eaque illo. Qui reiciendis deleniti dolorum quasi earum. Architecto sunt quidem sint aut iste exercitationem consequuntur. Iusto mollitia ipsam qui. Eaque vel voluptate rem sed earum et.", new DateTime(2024, 12, 11, 10, 37, 15, 307, DateTimeKind.Utc).AddTicks(4903), "Lowe, Nicolas and Turner" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Eos blanditiis et sed harum aut et at minus libero. Ullam impedit esse ea sapiente eos modi. Quis dolore delectus. Nostrum est vero reiciendis.", new DateTime(2024, 12, 11, 10, 37, 15, 307, DateTimeKind.Utc).AddTicks(5080), "Rosenbaum, VonRueden and Dach" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 2, "Molestias est est nihil quia.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(4520), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 20, "Vel aut nemo voluptatem veniam ut aut.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5535), 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Quod qui totam.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5603), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Eum consequuntur quia dolorem.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5619), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Est molestias et officiis.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5638), 3, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 8, "Doloremque delectus molestiae numquam saepe optio soluta et expedita ratione.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5653), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Similique fuga repellat est quod cupiditate.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5681), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Ullam accusantium quis.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5700), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Voluptatum eos corrupti placeat exercitationem in dolores exercitationem ut.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5762), 2, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Sapiente quasi recusandae ad dolorem blanditiis quia harum labore nostrum.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5789), 4, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Exercitationem sit maxime iusto illo.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5818), 1, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 13, "Voluptates atque neque.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5835), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 5, "Qui et ad ut eveniet perferendis.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5848), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 19, "Ut enim accusantium.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5866), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 20, "Optio velit saepe ab optio expedita.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5877), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 5, "Cum illum labore soluta molestiae.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5893), 5, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Voluptate laborum omnis repudiandae eum fuga nisi incidunt et est.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5929), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 19, "Delectus sed exercitationem aut ut nostrum aspernatur qui ut sint.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5954), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 1, "Saepe totam amet iusto saepe reprehenderit ut iusto culpa aspernatur.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(5978), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Minus laboriosam ab sunt sit quisquam.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6002), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Commodi sequi quis occaecati sunt dolorem aut.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6021), 1, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 14, "Accusantium molestias harum qui quasi iure et accusamus reprehenderit.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6042), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "Quo ratione quasi praesentium non.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6062), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Quae ab temporibus voluptatem nihil dolorem placeat.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6167), 5, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Ad voluptatibus labore beatae est est.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6187), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 7, "Tempore officiis consequatur.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6204), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "In consequatur tempora itaque nam occaecati reiciendis et qui.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6217), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 1, "Consequuntur distinctio illum error rerum perspiciatis fugit omnis impedit dolorem.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6242), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "At ex doloremque nihil culpa enim odio sit.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6268), 3, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 2, "Nisi totam dolor.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6286), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 6, "Sunt repellat aliquam.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6298), 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Facilis consequuntur sed repellat.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6340), 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 14, "Aut saepe perferendis perspiciatis perferendis voluptas et numquam placeat maxime.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6352), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 7, "Voluptas minus asperiores provident maxime odit dolores sed earum.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6376), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Quam saepe debitis necessitatibus ut id quisquam at reiciendis voluptatem.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6402), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 1, "Cum commodi eum asperiores et ut asperiores nobis illum at.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6428), 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[] { 9, "Inventore fugit sed sit ipsum quo quia ipsa quo facilis.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Et enim dolorum dicta sapiente.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6475), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Placeat aspernatur adipisci qui ex et perferendis aliquid rerum deleniti.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6507), 1, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 6, "Eos odit non.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6534), 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 15, "Iure iste dolor.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6546), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 6, "Aut atque quas cupiditate.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6557), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Aut eos aut.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6570), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 1, "Omnis sequi officia rerum quasi ducimus labore et aut corrupti.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6581), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Sed sit recusandae possimus illum et omnis dolor quis.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6665), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Ea voluptate soluta cumque beatae necessitatibus inventore.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6684), 2, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Dolores fuga ipsa quis.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6703), 4, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 1, "Fuga inventore et.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6715), 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 8, "Quos animi nihil repellat consequatur.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6727), 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 15, "Voluptas velit omnis consectetur est.", new DateTime(2024, 12, 11, 10, 37, 15, 310, DateTimeKind.Utc).AddTicks(6742), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(7958), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8077), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8082), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8085), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8087), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8090), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8093), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8095), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8098), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8101), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8104), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8106), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8109), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8112), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8115), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8117), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8150), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8153), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8156), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8159), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8162), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8164), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8167), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8170), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8173), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8176), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8179), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8181), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8184), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 10, 37, 15, 311, DateTimeKind.Utc).AddTicks(8187), 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "West Merlin", "Nauru", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(7085), "Kentucky", "7245 Johns Haven", "28768" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Mitchellhaven", "Saint Lucia", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(7697), "Missouri", "598 Blanda Rest", "81603-5344" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Creminberg", "Paraguay", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(7857), "Texas", "25513 Doyle Estate", "00903-2666" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Kosstown", "Japan", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(7995), "Minnesota", "652 Geo Creek", "97253-1240" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Lake Clark", "Cayman Islands", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8115), "Iowa", "928 Koch Garden", "36518" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "West Eileen", "Denmark", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8233), "Alabama", "33150 Betty Ridges", "40597" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Presleymouth", "Peru", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8347), "Illinois", "45189 Turner Causeway", "48673" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Priscillafurt", "Belize", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8497), "Minnesota", "25322 Schiller Land", "68316" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "West Michel", "India", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8601), "Colorado", "9602 Camilla Gardens", "84706" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "West Chandlermouth", "Kyrgyz Republic", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8753), "Washington", "576 Little Valleys", "84583" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "West Amiyamouth", "Tunisia", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(8889), "Maryland", "623 Victor Alley", "62882-0622" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "South Maynard", "Malaysia", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(9016), "West Virginia", "66253 Cronin Roads", "50634-2684" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Mayertstad", "Vietnam", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(9133), "Louisiana", "793 Vandervort Spur", "21333" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Carletonview", "France", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(9253), "Virginia", "9646 Glen Lights", "52310" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Brakusview", "Svalbard & Jan Mayen Islands", new DateTime(2024, 12, 11, 8, 40, 3, 916, DateTimeKind.Utc).AddTicks(9370), "Illinois", "4275 Vivienne Mill", "39595-1332" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c030ceea-9f17-4209-9510-99bf4a3fdf38", "c8154148-5168-4485-a280-ab2b7cf8dad7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "6f77b168-eedb-4619-a1f7-81112fe7a22b", "Carmela34@hotmail.com", "Sadye Durgan", "618-896-2994", "285739b3-7667-4b79-98ae-661e431e87e8", "Carmela34@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "f9ac9ec9-1d8b-4b1b-852e-9a3efd74cb58", "Donald_Fritsch16@yahoo.com", "Jessie Kovacek", "(414) 413-5297", "b495e0a3-15c2-4968-9c11-303676acf18d", "Donald_Fritsch16@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a1b49833-be02-4de0-9f4c-ea0af38c4765", "Mortimer36@gmail.com", "Hector Schoen", "1-930-464-7629 x6713", "4eeafa8d-fccc-40b1-9f49-c021dc1db8de", "Mortimer36@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "67d2791f-855b-4bae-a411-5fec031b9be4", "Mireya1@yahoo.com", "Matilda Larson", "(317) 992-0106 x7440", "b07e5b1c-7e34-4e08-ba6f-a84d785480d8", "Mireya1@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "e2f1991d-5a43-4afb-b26d-b95e75743dfa", "Sanford66@hotmail.com", "Nyah O'Hara", "388.786.7228 x949", "fd10c8be-2533-43e4-b384-fef3e3a0296a", "Sanford66@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "8bab4f15-678a-480f-ab06-44c8c12f9402", "Kaya.Leannon@yahoo.com", "Abagail DuBuque", "(921) 383-0565", "d750ff0b-6950-4b31-9cc6-acb0e0c21bbc", "Kaya.Leannon@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "687ad8d8-a6ca-4ff1-adc9-740c9d50f69d", "Ethan.Luettgen@yahoo.com", "Timmy Romaguera", "503.607.4606 x19855", "acfd016d-7714-45c9-8557-f5f82bb1aca3", "Ethan.Luettgen@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ba0514d1-f8a5-4d16-8640-d13c79b069ab", "Sedrick.Kiehn@gmail.com", "Brent Funk", "(318) 923-5614 x43648", "f25e94b2-075c-4ec4-b550-806c2957b0cc", "Sedrick.Kiehn@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "3ba2eaea-3ae6-4d9e-b8b5-5ae72366a31f", "Elaina.Gerhold@hotmail.com", "Danyka Raynor", "1-798-501-6880 x29406", "5ad02aad-8c05-4a0c-805c-924e00f4f486", "Elaina.Gerhold@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Temporibus error ad ut omnis rem. Temporibus qui magnam et non modi asperiores praesentium sed. Ducimus ullam officia quo molestias. Et dicta molestiae quia quis sit cum. Illo et dolores sequi sapiente consequatur.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(5788), "Jules Stamm" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Expedita quia occaecati accusantium sed tempore nostrum quo. Neque laudantium fuga ut quae. Et nisi et qui tenetur. Debitis tempora placeat quaerat magnam. Doloribus eos aut quibusdam error fugit vero iste aut sint.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6230), "Troy Conn" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Odit omnis minima vero ut. Nihil voluptates illo omnis eos perspiciatis ut ut quam praesentium. Sequi qui cumque. Explicabo sunt excepturi aut.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6396), "Noble Effertz" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Laboriosam tempore consequatur harum voluptatem est eveniet vel. Aspernatur excepturi ut quo mollitia animi adipisci. Totam reprehenderit ex temporibus inventore deleniti. Culpa inventore eum ut. Exercitationem modi doloremque facilis et quia repellendus eum impedit nostrum.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6473), "Jessyca Stehr" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Quibusdam consequatur ut praesentium quia. Laudantium omnis itaque aperiam ipsa. Ea eius aut nihil laboriosam in labore saepe non voluptas. Minus et modi quia est odit rerum quod. Ut qui dignissimos rerum qui vitae.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6619), "Kris Stamm" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Harum dignissimos ut sint alias asperiores ab tempore illo. Odio natus magnam sed velit commodi labore dolorem aut vitae. Minima necessitatibus est hic est sed. Quis dolores id rerum sint dolores velit. In et commodi assumenda similique dolores ipsam.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6722), "Hardy Douglas" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Eveniet ea ut exercitationem at fugiat vitae suscipit. Sint explicabo enim. Quia voluptatibus praesentium consequatur et. Cupiditate et nostrum deleniti unde quod. Quis eaque aut reiciendis.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6860), "Maeve Beatty" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Eligendi reiciendis dicta est ad rerum eos earum maxime. Odit maxime non pariatur amet. Quaerat dolores nihil et. Magnam corrupti eos. Laudantium cumque officia aut.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(6964), "Daija Smith" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Quis necessitatibus laboriosam id quasi. Nemo sed tempora architecto omnis aut delectus qui dolorem. Amet dolorum natus tempora sed. Delectus sint veritatis culpa molestiae non non quam inventore. Sit velit ut recusandae enim enim voluptatem sed.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(7040), "Freda Douglas" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Ducimus et quis non et autem omnis consequatur. Aut ab quam. Assumenda facilis qui voluptates. Dolor nobis consequatur impedit rerum quos.", new DateTime(2024, 12, 11, 8, 40, 3, 907, DateTimeKind.Utc).AddTicks(7186), "Kaley Greenfelder" });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Neque nisi animi.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Quod veritatis blanditiis.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Laudantium suscipit et.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Cumque tempora ad.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "In facilis esse.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Ut corporis non.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(1662), "Voluptatem quod qui. Nulla voluptates sint deleniti. Possimus rerum repellat. Laborum et mollitia cumque necessitatibus. Sint rerum numquam quia.", "/images/cover-1.jpg", 19.81m, 2, 1, "Temporibus quibusdam aliquid." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3144), "In id similique molestias. Cumque quibusdam dolorum velit ipsa et ab dolores ipsum omnis. Alias vitae a ducimus. Laboriosam ea necessitatibus aliquam commodi. Quibusdam quibusdam dolorem beatae.", "/images/cover-4.jpg", 25.23m, 1, 1, "Blanditiis aliquid itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3310), "Hic et in. Minus consequatur id harum qui velit est accusantium illo. Nihil error doloribus repellat totam beatae asperiores et voluptates id. Veritatis sit molestias deserunt nam eveniet qui.", "/images/cover-2.jpg", 86.20m, 5, 4, "Fuga est qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3524), "Facilis vero ipsum molestiae qui omnis et vel. Nulla voluptas sequi nemo non id. Sed commodi quaerat non pariatur nemo architecto commodi provident delectus.", "/images/cover-3.jpg", 61.41m, "Aut voluptatum corporis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3663), "Accusantium eveniet ut aliquam consequuntur natus quo hic. Dolorum pariatur nostrum quis perferendis in qui dicta quaerat. Consequatur qui aspernatur voluptatibus. Velit tempora rerum quis ex. Nihil natus et accusamus maiores. Itaque sed quam explicabo magnam inventore praesentium tenetur.", 59.36m, 2, 3, "Iusto dolor dignissimos." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3801), "Dolor delectus assumenda accusamus ex ipsum. Unde fuga recusandae ipsa facilis dolor velit. Asperiores nemo nobis iure ducimus explicabo maxime modi dolor mollitia. Consequatur ex sit fugit. Rem labore iste consequatur corporis vel provident. Fugiat rerum temporibus.", "/images/cover-8.jpg", 81.69m, 1, 2, "Unde perferendis vero." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3941), "Autem excepturi est nam iste aut sed est inventore non. Vel sit quo maiores. Consequatur non maxime nihil odio praesentium vel repellat dicta rerum. Et est facilis suscipit eum amet non consequuntur. Enim eum et dolorem quaerat voluptas sapiente officiis et. Dolores qui amet ipsa consequuntur.", "/images/cover-2.jpg", 31.67m, 3, 3, "Et est ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4101), "Enim omnis eos. Consectetur harum atque sequi quas voluptas enim. Natus earum doloremque aliquam sequi nihil eum quia qui voluptatem. Aspernatur fugit optio cum qui ea. Rerum perferendis nobis. Non recusandae suscipit mollitia mollitia.", "/images/cover-5.jpg", 61.27m, 6, 1, "Ipsa voluptas iusto." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4235), "Provident totam commodi officia nobis eos aut neque id itaque. Nostrum voluptatem quia illo ex eos amet fugit. Non quisquam inventore labore. Molestiae sunt qui aut. Voluptatum dolores et.", "/images/cover-10.jpg", 45.09m, 5, 4, "Eveniet architecto sed." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4387), "Officia velit aspernatur et aut aut quia porro. Autem adipisci voluptates aut reiciendis in sit earum. Sit blanditiis eius eius atque. Totam cumque id ipsum consequatur eos et velit. Aliquid explicabo ipsum dignissimos delectus qui. Pariatur quis sunt nihil provident ratione.", "/images/cover-6.jpg", 98.43m, 3, 1, "Repellendus ut porro." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4501), "Odit sit assumenda incidunt temporibus est quod. Eligendi fuga reprehenderit vero molestiae eos aspernatur ratione non. Sed reprehenderit perspiciatis qui. Blanditiis est at qui totam repellendus et labore et aliquam. Sit porro velit quasi dolorum odio sapiente.", "/images/cover-1.jpg", 26.06m, 2, "Dolorem sed error." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PublisherId", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4624), "Placeat molestiae vel dicta nobis in distinctio quaerat exercitationem. Sit qui voluptate minima qui reprehenderit et impedit sapiente quae. Temporibus dolorem sed.", "/images/cover-4.jpg", 85.05m, 4, "Et voluptate itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4711), "Non quae et ducimus quaerat. Qui veniam voluptate aliquid in reprehenderit aut dignissimos ut laborum. Aperiam incidunt autem tempore autem similique ducimus porro ullam.", "/images/cover-10.jpg", 84.17m, 4, 4, "Qui quisquam illum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PublisherId", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4782), "Est aut iure et nostrum odio. Nostrum quas quasi unde placeat non. Eum perferendis quia eum est esse. Quod voluptatem consequuntur.", "/images/cover-9.jpg", 45.29m, 4, "Quaerat quia deserunt." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4888), "Aut similique blanditiis est beatae repudiandae fugiat inventore error. Illo soluta voluptas nesciunt. Saepe et corrupti. Animi non molestias sed provident itaque. Officiis a omnis eius neque expedita molestiae similique non. Cumque molestiae odio ipsum illo aut sint hic.", "/images/cover-6.jpg", 57.58m, 5, 5, "Reiciendis necessitatibus quae." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5010), "Consequatur quis est quas aspernatur sequi qui minus consectetur voluptas. Est ad id dolorem. Qui praesentium numquam laboriosam ut qui nam enim. Rerum quia vel at in. Vitae qui mollitia et quia ipsam assumenda architecto.", "/images/cover-4.jpg", 82.13m, 1, 4, "Ut accusamus necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5100), "Deserunt unde dolores suscipit aut cumque quo aut. Est sit exercitationem voluptas repellat est. Ut aut consequatur quis fugiat vel sequi.", "/images/cover-9.jpg", 56.84m, 5, 1, "Quis temporibus aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5254), "Similique et vitae reiciendis deserunt dolor aut fugit eum maxime. Recusandae occaecati doloremque. Voluptatibus fugit non. Neque cupiditate explicabo nesciunt similique optio consequatur ut qui.", "/images/cover-7.jpg", 51.05m, 5, 2, "Perspiciatis qui nobis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5325), "Fuga et est. Praesentium non deserunt. Ducimus voluptas veniam maxime. Et deserunt esse ut.", "/images/cover-9.jpg", 16.88m, 5, 3, "Placeat deleniti quis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5412), "Eos tenetur corrupti inventore sit et. Tenetur sed doloremque qui accusantium. Iure ut iste accusamus minima suscipit magnam sunt minima pariatur.", "/images/cover-3.jpg", 83.95m, 5, 2, "Aperiam asperiores nisi." });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(1132), 12, 27.74m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2532), 15, 26.26m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2587), 10, 12.83m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2597), 12, 80.20m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2605), 9, 76.78m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2612), 11, 38.21m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2619), 7, 79.04m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2626), 7, 33.13m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2632), 58.82m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2638), 5, 76.05m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2645), 5, 43.27m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2651), 2, 98.59m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2659), 12, 31.34m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2665), 3, 41.07m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2671), 5, 26.39m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2678), 1, 88.43m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2684), 14, 33.53m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2691), 1, 36.82m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2697), 14, 20.44m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2704), 3, 65.10m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2766), 10, 94.64m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2773), 14, 71.86m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2780), 5, 31.74m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2787), 2, 61.77m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2793), 2, 48.82m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2800), 13, 82.45m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2806), 30.24m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2813), 13, 41.37m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2819), 87.29m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2826), 11, 31.73m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2833), 3, 93.73m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2839), 48.96m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2845), 6, 24.76m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2852), 9, 20.76m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2859), 4, 42.29m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2865), 4, 80.11m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2871), 12, 70.25m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2877), 6, 10.12m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2883), 1, 40.21m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2889), 12, 57.44m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2896), 64.87m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2903), 9, 85.37m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2909), 11, 72.95m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2915), 15, 47.17m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2922), 12, 31.04m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2928), 6, 37.18m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2934), 8, 99.62m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2941), 14, 92.65m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2947), 9, 68.75m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2954), 1, 97.17m, 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(2157), "Crystal62@yahoo.com", "Crystal Powlowski", 12, 8 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(5222), "Lynette.Considine29@gmail.com", "Lynette Considine", 3, 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(6456), "Guadalupe.Kassulke@gmail.com", "Guadalupe Kassulke", 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(6995), "Emily.Koepp24@hotmail.com", "Emily Koepp", 15, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(7476), "Bryant80@yahoo.com", "Bryant Bernier", 5, 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(8119), "Rachel_Cole4@gmail.com", "Rachel Cole", 4, 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(8605), "Ellen.Sporer@yahoo.com", "Ellen Sporer", 5, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(9148), "Alton5@gmail.com", "Alton Nienow", 7, 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(9691), "Joanna_MacGyver0@yahoo.com", "Joanna MacGyver", 14, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(304), "Pearl60@yahoo.com", "Pearl Shanahan", 6, 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(795), "Marilyn_Nitzsche59@yahoo.com", "Marilyn Nitzsche", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(1353), "Jennie63@hotmail.com", "Jennie Hammes", 5, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(1829), "Doreen.Goodwin@yahoo.com", "Doreen Goodwin", 7, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(2679), "Jeannie.Renner@yahoo.com", "Jeannie Renner", 13, 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(3237), "Kirk_Parker@hotmail.com", "Kirk Parker", 3, 3 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Voluptas aut consequatur velit alias et vel. Enim repellendus itaque incidunt sunt totam suscipit cum harum. Iure unde quis odit officiis. Molestiae et ipsum iusto facere labore quasi officiis ut voluptates. Error officia sequi.", new DateTime(2024, 12, 11, 8, 40, 3, 909, DateTimeKind.Utc).AddTicks(1986), "Schneider - Greenfelder" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Dolorem nobis vero ipsam. Omnis dolorem quia consequuntur vero. Facilis laudantium occaecati officia ipsa corrupti aut est tenetur esse.", new DateTime(2024, 12, 11, 8, 40, 3, 909, DateTimeKind.Utc).AddTicks(2675), "Feeney - Bashirian" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Et cumque quam. Reiciendis sapiente molestiae nostrum sequi quas ipsa et iure. Natus nulla qui.", new DateTime(2024, 12, 11, 8, 40, 3, 909, DateTimeKind.Utc).AddTicks(2823), "O'Kon LLC" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Sed sed ut eos. Voluptas qui omnis. Porro quia dicta accusantium. Dolorum dolorem tempora deserunt veniam. Sit vel voluptates eaque perferendis et voluptatem. Fuga nemo fugit magni accusantium.", new DateTime(2024, 12, 11, 8, 40, 3, 909, DateTimeKind.Utc).AddTicks(3033), "Durgan, Ferry and Cummerata" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Optio a sequi. Dolorem iusto dignissimos. Qui similique est minus aperiam totam minima. Provident ut quam. Quidem cum non incidunt.", new DateTime(2024, 12, 11, 8, 40, 3, 909, DateTimeKind.Utc).AddTicks(3366), "Grimes Inc" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 15, "Dicta illo vitae suscipit quasi quia tempora unde dolorum.", new DateTime(2024, 12, 11, 8, 40, 3, 913, DateTimeKind.Utc).AddTicks(9360), 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 14, "Et aspernatur autem est explicabo aut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(322), 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 4, "Est inventore dolore ut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(390), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 6, "Qui repellendus praesentium eos.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(413), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 20, "Ut velit recusandae voluptatem sunt sed omnis aut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(483), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 6, "Vel in quia rerum maxime consequatur itaque eius autem.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(514), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Veniam modi voluptas quos aut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(544), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Sint nostrum voluptatem vero rerum culpa.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(564), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 20, "Aut voluptatem repellendus hic.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(586), 3, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "Quia veniam aliquid.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(600), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Eaque harum voluptates fugiat consequatur consequuntur.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(613), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Natus totam in omnis.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(634), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 3, "Debitis quia veritatis nihil sapiente voluptas ut velit.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(650), 3, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 9, "Reiciendis nam dolore totam commodi amet.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(710), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 16, "Qui sint nesciunt quasi ut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(730), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Id ratione laborum ut est at.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(748), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Laboriosam amet ab quia dolores minima.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(769), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 3, "Eveniet dolores sit ipsum.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(789), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 18, "Libero facere iste nemo neque rerum maxime.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(806), 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "Temporibus culpa eaque doloremque alias corporis.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(828), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 15, "Perspiciatis sapiente provident blanditiis ipsa beatae nisi ea placeat doloribus.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(849), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 4, "Voluptas rerum consequatur est debitis.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(921), 4, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Unde sint unde numquam occaecati.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(937), 4, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Harum totam repudiandae reiciendis voluptas cupiditate quia iure sapiente voluptas.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(953), 2, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 3, "Voluptate porro perferendis magni et vel enim aut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(979), 5, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Sit eos perferendis earum qui pariatur est et qui ut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1008), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 2, "Ab et rem molestias qui itaque iste.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1038), 1, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 15, "Esse laborum et voluptatem.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1058), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 3, "Quaerat in molestias dolore rerum inventore et vitae consequatur.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1073), 1, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 15, "Sint laboriosam molestiae esse doloremque dignissimos doloremque.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1129), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 3, "Dolorum corrupti ipsa sunt beatae.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1150), 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Autem nesciunt quod ipsam illo sit autem et occaecati.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1168), 3, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 13, "Quisquam dignissimos eos esse repudiandae.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1194), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 12, "Aut tenetur quis et quia eaque repellendus ut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1209), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 20, "Totam aut doloribus sunt culpa veniam ipsam ducimus.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1231), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 14, "Earum nobis dolor nobis non voluptatem voluptatem nihil sequi.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1250), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate" },
                values: new object[] { 18, "Hic aut ex sed aut eaque amet quaerat voluptatum.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1302) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Qui est ut molestiae impedit.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1326), 1, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Dolorum iure non.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1340), 3, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 14, "Quaerat enim est in ut sapiente sapiente et.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1352), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 12, "Suscipit rem culpa cupiditate qui maiores doloribus quibusdam ab dolorem.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1373), 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Velit quia quis quod cupiditate a.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1399), 4, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 14, "Nihil debitis ut accusantium nihil sit distinctio.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1418), 3, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Suscipit corrupti at est itaque.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1440), 4, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 5, "Tenetur eveniet pariatur itaque libero hic omnis.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1470), 3, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Voluptatem eos ut omnis odit.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1488), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 8, "Natus doloremque voluptatum autem.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1505), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 14, "Nostrum error dolore sapiente occaecati est dignissimos.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1518), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Exercitationem quidem in vel optio quaerat repudiandae sunt molestiae doloremque.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1536), 1, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 8, "Quasi sed qui molestias optio.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1562), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5172), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5322), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5327), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5330), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5332), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5335), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5338), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5341), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 12, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5344), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5347), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5349), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5352), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5355), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5358), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5360), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5363), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5366), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5369), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5372), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5374), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5377), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5380), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5382), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5385), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5388), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5391), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5393), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5396), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5399), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5401), 7 });
        }
    }
}
