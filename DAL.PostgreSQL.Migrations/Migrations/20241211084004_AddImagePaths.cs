using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.PostgreSQL.Migrations.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePaths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(1662), "Voluptatem quod qui. Nulla voluptates sint deleniti. Possimus rerum repellat. Laborum et mollitia cumque necessitatibus. Sint rerum numquam quia.", "/images/cover-1.jpg", 19.81m, 1, "Temporibus quibusdam aliquid." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3144), "In id similique molestias. Cumque quibusdam dolorum velit ipsa et ab dolores ipsum omnis. Alias vitae a ducimus. Laboriosam ea necessitatibus aliquam commodi. Quibusdam quibusdam dolorem beatae.", "/images/cover-4.jpg", 25.23m, 1, 1, "Blanditiis aliquid itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3310), "Hic et in. Minus consequatur id harum qui velit est accusantium illo. Nihil error doloribus repellat totam beatae asperiores et voluptates id. Veritatis sit molestias deserunt nam eveniet qui.", "/images/cover-2.jpg", 86.20m, 5, "Fuga est qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3524), "Facilis vero ipsum molestiae qui omnis et vel. Nulla voluptas sequi nemo non id. Sed commodi quaerat non pariatur nemo architecto commodi provident delectus.", "/images/cover-3.jpg", 61.41m, 2, "Aut voluptatum corporis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(3663), "Accusantium eveniet ut aliquam consequuntur natus quo hic. Dolorum pariatur nostrum quis perferendis in qui dicta quaerat. Consequatur qui aspernatur voluptatibus. Velit tempora rerum quis ex. Nihil natus et accusamus maiores. Itaque sed quam explicabo magnam inventore praesentium tenetur.", "/images/cover-6.jpg", 59.36m, 2, "Iusto dolor dignissimos." });

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
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4624), "Placeat molestiae vel dicta nobis in distinctio quaerat exercitationem. Sit qui voluptate minima qui reprehenderit et impedit sapiente quae. Temporibus dolorem sed.", "/images/cover-4.jpg", 85.05m, 1, "Et voluptate itaque." });

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
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(4782), "Est aut iure et nostrum odio. Nostrum quas quasi unde placeat non. Eum perferendis quia eum est esse. Quod voluptatem consequuntur.", "/images/cover-9.jpg", 45.29m, 5, "Quaerat quia deserunt." });

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
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "Title" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5010), "Consequatur quis est quas aspernatur sequi qui minus consectetur voluptas. Est ad id dolorem. Qui praesentium numquam laboriosam ut qui nam enim. Rerum quia vel at in. Vitae qui mollitia et quia ipsam assumenda architecto.", "/images/cover-4.jpg", 82.13m, "Ut accusamus necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5100), "Deserunt unde dolores suscipit aut cumque quo aut. Est sit exercitationem voluptas repellat est. Ut aut consequatur quis fugiat vel sequi.", "/images/cover-9.jpg", 56.84m, 5, 1, "Quis temporibus aut." });

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
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 912, DateTimeKind.Utc).AddTicks(5325), "Fuga et est. Praesentium non deserunt. Ducimus voluptas veniam maxime. Et deserunt esse ut.", "/images/cover-9.jpg", 16.88m, 5, 3, "Placeat deleniti quis." });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(1132), 12, 27.74m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2532), 15, 26.26m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2587), 10, 12.83m, 1 });

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
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2605), 76.78m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2612), 11, 38.21m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2619), 7, 79.04m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2626), 7, 33.13m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2632), 11, 58.82m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 7, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2638), 5, 76.05m });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2651), 2, 98.59m, 2 });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2665), 3, 41.07m });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2678), 1, 88.43m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2684), 14, 33.53m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 15, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2691), 1, 36.82m, 3 });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2704), 3, 65.10m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 6, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2766), 10, 94.64m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 19, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2773), 14, 71.86m, 1 });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2787), 2, 61.77m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2793), 2, 48.82m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2800), 82.45m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2806), 4, 30.24m });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 8, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2819), 11, 87.29m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2826), 11, 31.73m });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2839), 4, 48.96m, 1 });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2865), 4, 80.11m, 1 });

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
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[] { 18, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2883), 40.21m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 17, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2889), 12, 57.44m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2896), 11, 64.87m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 14, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2903), 9, 85.37m, 1 });

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
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 16, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2915), 15, 47.17m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2922), 12, 31.04m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2928), 6, 37.18m, 1 });

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
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[] { 20, new DateTime(2024, 12, 11, 8, 40, 3, 921, DateTimeKind.Utc).AddTicks(2947), 68.75m });

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
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 10, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(8119), "Rachel_Cole4@gmail.com", "Rachel Cole", 4 });

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
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(9148), "Alton5@gmail.com", "Alton Nienow", 7, 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 11, 8, 40, 3, 918, DateTimeKind.Utc).AddTicks(9691), "Joanna_MacGyver0@yahoo.com", "Joanna MacGyver", 14, 4 });

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
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(795), "Marilyn_Nitzsche59@yahoo.com", "Marilyn Nitzsche", 1, 2 });

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
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 13, new DateTime(2024, 12, 11, 8, 40, 3, 919, DateTimeKind.Utc).AddTicks(1829), "Doreen.Goodwin@yahoo.com", "Doreen Goodwin", 7 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 15, "Dicta illo vitae suscipit quasi quia tempora unde dolorum.", new DateTime(2024, 12, 11, 8, 40, 3, 913, DateTimeKind.Utc).AddTicks(9360), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 14, "Et aspernatur autem est explicabo aut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(322), 1, 9 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 6, "Qui repellendus praesentium eos.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(413), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Ut velit recusandae voluptatem sunt sed omnis aut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(483), 5, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 6, "Vel in quia rerum maxime consequatur itaque eius autem.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(514), 2, 8 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 20, "Aut voluptatem repellendus hic.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(586), 4 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 18, "Eaque harum voluptates fugiat consequatur consequuntur.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(613), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 19, "Natus totam in omnis.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(634), 5 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Reiciendis nam dolore totam commodi amet.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(710), 3, 3 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 5, "Laboriosam amet ab quia dolores minima.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(769), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 3, "Eveniet dolores sit ipsum.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(789), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Libero facere iste nemo neque rerum maxime.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(806), 2, 8 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 15, "Perspiciatis sapiente provident blanditiis ipsa beatae nisi ea placeat doloribus.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(849), 2 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 7, "Harum totam repudiandae reiciendis voluptas cupiditate quia iure sapiente voluptas.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(953), 2, 10 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 3, "Quaerat in molestias dolore rerum inventore et vitae consequatur.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1073), 6 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 3, "Dolorum corrupti ipsa sunt beatae.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1150), 2, 7 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Aut tenetur quis et quia eaque repellendus ut.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1209), 3, 5 });

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
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Earum nobis dolor nobis non voluptatem voluptatem nihil sequi.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1250), 1, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Hic aut ex sed aut eaque amet quaerat voluptatum.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1302), 2, 9 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Suscipit rem culpa cupiditate qui maiores doloribus quibusdam ab dolorem.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1373), 1, 6 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 14, "Nihil debitis ut accusantium nihil sit distinctio.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1418), 3 });

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
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 14, "Nostrum error dolore sapiente occaecati est dignissimos.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1518), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 12, "Exercitationem quidem in vel optio quaerat repudiandae sunt molestiae doloremque.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1536), 1 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 8, "Quasi sed qui molestias optio.", new DateTime(2024, 12, 11, 8, 40, 3, 914, DateTimeKind.Utc).AddTicks(1562), 4, 9 });

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
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 11, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5347), 4 });

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
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5358) });

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
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5369), 8 });

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
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5377), 7 });

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
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2024, 12, 11, 8, 40, 3, 915, DateTimeKind.Utc).AddTicks(5388) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "East Euna", "Christmas Island", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(780), "Illinois", "29543 Treutel Trafficway", "03034" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Lake Penelope", "Aruba", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(1563), "Ohio", "4897 Rempel Vista", "23040-4792" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Magnoliachester", "Armenia", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(1731), "Arkansas", "4395 Haag Court", "52788" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Sonnyberg", "Syrian Arab Republic", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(1883), "South Dakota", "0524 Abdiel Stream", "69510-1994" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Pietroview", "French Guiana", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2031), "Texas", "90318 Schowalter Corners", "65379" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Vandervortfort", "Guatemala", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2170), "Florida", "4648 Crawford Union", "58378" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Oberbrunnermouth", "Cameroon", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2301), "Pennsylvania", "22733 Geo Creek", "40694" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "South Curt", "United Kingdom", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2459), "Alabama", "5013 Mekhi Crescent", "25777-6946" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Trompfort", "Antigua and Barbuda", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2617), "Alaska", "54230 Crona Plains", "06052-9403" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Madgeborough", "China", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2743), "Colorado", "32171 Rocio Court", "00631-4029" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "New Abbey", "Burundi", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(2873), "Arkansas", "47521 Tyshawn Parkways", "35210" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Marisolstad", "Barbados", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3003), "Florida", "4106 Bogisich Glens", "65280" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "West Wandafort", "Maldives", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3131), "New Jersey", "86561 Myrtie Ports", "24574" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Octaviamouth", "Tonga", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3271), "Wyoming", "2912 Kub Village", "06411" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "City", "Country", "CreatedDate", "State", "Street", "ZipCode" },
                values: new object[] { "Lake Macy", "Wallis and Futuna", new DateTime(2024, 12, 9, 22, 20, 33, 301, DateTimeKind.Utc).AddTicks(3387), "Wisconsin", "2675 Ritchie Walk", "88006-5759" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7d3f3d4c-e3af-4979-8f41-21fe962ed7a3", "096465a3-e925-40a4-a08d-71d592e347c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "f87dfe8e-bbe1-4260-8135-5cc0127997a7", "Jewel.Haag39@yahoo.com", "Scot Kuhn", "204-579-4186 x041", "359e810f-6b58-4c65-8d1c-fa54ed235085", "Jewel.Haag39@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "dfc926a1-b7cb-40f1-a1fa-1ce5f97a4b72", "Diana_Altenwerth@yahoo.com", "Odell Heaney", "775-575-0909 x88931", "0e7c77ea-4417-4aa4-9082-e5de9bd1d1bd", "Diana_Altenwerth@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "c23d3ae3-7848-42b7-9503-75cbd23aae9c", "Georgiana69@gmail.com", "Bennett Howell", "1-378-374-0247 x40962", "aa8d56be-7208-4f1e-9ec4-2f07385e6261", "Georgiana69@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "afd7acfa-5224-4f38-8800-b68217cdb723", "Marjorie.Brakus1@hotmail.com", "Riley Schuster", "455-350-6677", "9a76a42f-0964-4432-ab2f-2272bd54be12", "Marjorie.Brakus1@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "d27d2d8f-2de4-4ea2-b4cb-1f980d767ea6", "Tristin_Smitham30@yahoo.com", "Bryon Koepp", "207-243-1087 x06484", "94c922f2-65d8-4b70-9691-b26a6ef0849c", "Tristin_Smitham30@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "307a044e-63f4-4108-914b-490aeb34cb67", "Florida3@hotmail.com", "Lia Homenick", "(470) 694-2517 x67915", "2d1ba4d9-a888-4a33-b647-584a49de3769", "Florida3@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "124c2baa-7a3d-423d-9116-0ea790d2967a", "Jailyn11@hotmail.com", "Lemuel Schumm", "1-683-740-5638 x12823", "96534116-7a75-419c-94fc-26ad3a28b1e9", "Jailyn11@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "2ab0d7e7-286b-400f-aa86-aa92bb1fb320", "Marquis20@hotmail.com", "Tyreek McDermott", "319-732-0313", "58c3bf84-541b-47ad-9de4-d889c24d7db1", "Marquis20@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ConcurrencyStamp", "Email", "Name", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "a69dc809-85c7-4c95-87c5-3c4694158d07", "Louisa.Kozey@hotmail.com", "Shanelle Wiza", "969.742.0386 x529", "cddff05d-4e1b-406c-96dc-6a8b8ee670d2", "Louisa.Kozey@hotmail.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Ut magnam at molestiae sed a corrupti impedit. Cupiditate quae ex nostrum voluptates qui doloremque aut fuga. Et architecto omnis soluta non. Autem quam laborum harum et quibusdam. Veritatis qui provident dolorem eligendi saepe tempore commodi et. Et sapiente quasi placeat reiciendis.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(3878), "Hunter Runte" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Voluptatibus fuga illo temporibus qui ut illo autem. Omnis eligendi quia et. Optio maxime magni sed cupiditate velit assumenda illum.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4488), "Adelle Ullrich" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Magni in ut dolores ad veniam veritatis. Harum nisi provident corrupti consequatur consequatur id consequatur et. Eaque qui est iure nesciunt non.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4635), "Nico Kemmer" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Quas dolorem tempore fuga dolorem. Adipisci voluptas laudantium dolorum recusandae praesentium pariatur aliquam. Sed rerum excepturi corporis animi quas recusandae perferendis. Asperiores sunt enim. Ratione id placeat commodi consequatur ipsam quia aut nobis dolor.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4743), "Carlos Labadie" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Libero et et illo. Ipsum earum sunt cupiditate recusandae itaque. Omnis tempora nesciunt. Nihil voluptatum magnam. Eum molestiae inventore. Officiis omnis quia officia nemo.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(4937), "Nicholas Marvin" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Quos quas fuga placeat tempora rem est aut. In qui voluptate maxime aperiam dolorem minus. Dolor inventore facilis qui sed. Harum et sed sed. Natus velit ipsa. Et vel et dignissimos eum consequatur nesciunt.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5046), "Hugh Pouros" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Eaque debitis sint velit sed enim alias id. Aut dolorem atque perferendis tempore sapiente alias harum. Libero dolor cupiditate in non ut natus itaque fugit ea.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5195), "Janae Nader" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Culpa corrupti est omnis culpa sapiente. Molestiae suscipit officia id reiciendis tempore. Non et repellat non. Consequatur provident quam.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5271), "Aric Casper" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Modi ab ex provident dolores beatae. Totam sequi nihil repellat placeat fugiat perferendis officia. Magnam debitis rerum.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5362), "Luz Moore" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Nostrum provident provident. Ullam est ad. Incidunt qui officiis labore porro quas. Ullam qui quia.", new DateTime(2024, 12, 9, 22, 20, 33, 292, DateTimeKind.Utc).AddTicks(5429), "Rubie Kris" });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Iusto sunt et.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Aut nam non.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Qui ipsam facere.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Est iusto mollitia.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Ea tempora perferendis.");

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Nulla mollitia voluptas.");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(6808), "Voluptates fugit et aperiam sint vitae et in vel aut. Molestiae officia non vero atque est adipisci. Quo non eos.", "https://picsum.photos/640/480/?image=558", 60.69m, 4, "Culpa rem non." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8421), "Tempore enim commodi tempora ad est. Asperiores dolor sed. Aperiam praesentium maiores excepturi voluptatem ut. Aut voluptatibus eos quia minima incidunt id. Perspiciatis porro cupiditate necessitatibus commodi iste voluptas aspernatur quam.", "https://picsum.photos/640/480/?image=928", 13.30m, 3, 4, "Voluptatem sint hic." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8608), "Non voluptas vel ducimus soluta enim ipsum unde quis non. Autem est ex sit tempore. Itaque ipsum rerum omnis ut eligendi eligendi velit. Doloribus officiis nostrum est. Dolores eaque libero eum voluptatum modi.", "https://picsum.photos/640/480/?image=568", 16.42m, 1, "Distinctio alias et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8750), "Esse fugiat quia ut modi aut quis. Vero iusto ut error. Consequatur iure eligendi consequuntur dolore et.", "https://picsum.photos/640/480/?image=715", 41.26m, 6, "Eveniet occaecati quas." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8821), "Autem quas mollitia quibusdam molestias aut dolor id minima molestias. Natus sint voluptatem facilis ut recusandae labore aliquam eos voluptatibus. Ut soluta est numquam illo vitae ipsum nihil. Recusandae sed quo reprehenderit ad adipisci. Accusantium ullam dolores aliquam corrupti corporis.", "https://picsum.photos/640/480/?image=452", 76.19m, 6, "Rerum ex ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(8977), "Asperiores et doloremque quia laborum quia eos. Commodi illo vitae ut temporibus similique eius quia. Numquam expedita magnam neque cum nihil sint quod. Et delectus est. Minima quae ut corporis aliquid in minima.", "https://picsum.photos/640/480/?image=798", 78.99m, 3, 3, "Ullam aliquam nihil." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9092), "Optio ex et est nihil voluptatem laudantium nam. Expedita impedit velit sit ab quae voluptates. Doloremque quia libero sequi quasi. Deleniti qui est laudantium deserunt possimus tenetur. Eaque dolorum harum a aut et non sunt deserunt. Officia nulla reprehenderit.", "https://picsum.photos/640/480/?image=216", 75.64m, 1, 2, "Rem qui eaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9279), "Et mollitia ab iure recusandae similique dolor vel aliquam. Quis qui excepturi. Vero sunt nihil praesentium minus sed. Qui voluptas dignissimos amet sunt. Blanditiis ex commodi totam repudiandae sunt quia dicta minus sapiente. Voluptatem architecto iure.", "https://picsum.photos/640/480/?image=382", 94.26m, 3, 2, "Est deleniti distinctio." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9433), "Cupiditate velit et minus eos iste voluptates in. Pariatur non voluptas voluptatem et. Pariatur nihil dolor recusandae ipsam ducimus ipsum et. Distinctio facere perferendis aliquid recusandae qui aut quam.", "https://picsum.photos/640/480/?image=834", 99.12m, 4, 3, "Dolores ducimus aut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9516), "Omnis labore reprehenderit ut veniam veritatis quibusdam dolorem atque libero. Quo sed explicabo repudiandae perspiciatis. Occaecati deleniti molestiae et et quis omnis. Earum reiciendis voluptatibus voluptatem omnis. Deleniti quasi vitae et reprehenderit laborum ab iusto. Ipsam id pariatur animi nobis dignissimos.", "https://picsum.photos/640/480/?image=390", 12.52m, 4, 2, "Sequi est earum." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9657), "Doloribus explicabo repudiandae veritatis quia. Quis et incidunt perspiciatis distinctio illo. Voluptas repellat voluptatibus impedit asperiores ea officiis tempore sint blanditiis. Quidem ut occaecati velit magni beatae aliquam aut eius voluptatem. Ut quibusdam quo ipsa qui non dolor. Maiores ullam modi.", "https://picsum.photos/640/480/?image=208", 36.62m, 1, "Perferendis accusantium sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9800), "Quas explicabo id quos qui necessitatibus nihil. Excepturi id quo est et a pariatur in aut est. Aut excepturi sapiente magni sit odio quaerat nesciunt. Eveniet quo voluptatum. Consequatur exercitationem maxime soluta velit delectus sed.", "https://picsum.photos/640/480/?image=710", 48.07m, 6, "Numquam explicabo quo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 6, new DateTime(2024, 12, 9, 22, 20, 33, 296, DateTimeKind.Utc).AddTicks(9990), "Ducimus alias et dolore porro omnis. Assumenda ipsum consequatur molestiae in officiis ullam natus quos. Ut blanditiis est.", "https://picsum.photos/640/480/?image=478", 54.56m, 5, 1, "Rem fuga cumque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "Title" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(54), "Sit beatae quos. Laudantium ullam aut molestiae eveniet dolorum. Possimus accusamus provident aspernatur quos dolores molestiae. Officia ullam eos eum cum ipsam quo quis. Vel saepe velit consequatur. Et optio reiciendis accusantium repellendus consequatur aut omnis.", "https://picsum.photos/640/480/?image=156", 79.82m, 1, "Fugit ipsa molestias." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(181), "Et sit in fuga eaque nihil id sit qui corporis. Dolorem et necessitatibus animi recusandae dolorum quia nihil. Ex dicta in deserunt accusamus quas odit voluptatem similique aut. Minima tempore dolor non autem velit blanditiis consequatur. Aperiam qui dicta et et ut aliquid consequatur illum cum.", "https://picsum.photos/640/480/?image=253", 52.25m, 2, 1, "Ut labore nihil." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "Title" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(340), "Velit est ut et sunt eum sunt. Minima sed et adipisci repudiandae dolor totam. Ab sunt qui consequatur aspernatur. Repellat voluptatem ex laboriosam. Quos reprehenderit aspernatur fuga.", "https://picsum.photos/640/480/?image=104", 68.83m, "Et id quibusdam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(454), "Vero reiciendis atque nihil possimus dolorem sunt. Laboriosam voluptatem earum eos non distinctio amet. Blanditiis aut libero. At cupiditate autem impedit illo amet sed sed nemo. Quis voluptatem ea sequi velit voluptate. Sunt autem ducimus quia voluptate et et occaecati.", "https://picsum.photos/640/480/?image=253", 90.28m, 1, 5, "Iste sit maxime." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 4, new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(611), "Expedita laborum laboriosam aspernatur voluptas ut nulla rerum dolorem. Ipsum porro ex eligendi quas ex occaecati consequatur aut quo. Maiores doloribus laboriosam esse aut sit iste ut odit. Aspernatur nobis inventore qui sapiente aliquid.", "https://picsum.photos/640/480/?image=962", 14.09m, 2, 1, "Delectus temporibus omnis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(698), "Sed voluptatem perferendis eum incidunt eaque quis fuga odit optio. Unde voluptas quia ullam et. Hic quis quisquam et tenetur dolor labore animi est. Velit possimus eos inventore et debitis alias sequi.", "https://picsum.photos/640/480/?image=521", 62.99m, 1, 2, "Nesciunt amet et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CreatedDate", "Description", "ImagePath", "Price", "PrimaryGenreId", "PublisherId", "Title" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 297, DateTimeKind.Utc).AddTicks(820), "Non eligendi tempore sed rerum amet qui pariatur beatae voluptatem. Sit voluptatibus itaque molestiae quaerat perferendis ducimus dolor. Iure omnis inventore ut velit veritatis dignissimos nulla.", "https://picsum.photos/640/480/?image=1084", 16.20m, 3, 3, "Culpa fugit voluptas." });

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 17, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(2442), 15, 19.98m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3822), 3, 21.14m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3870), 3, 36.96m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 18, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3881), 13, 41.15m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Price" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3888), 69.55m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3894), 12, 61.73m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3901), 6, 61.74m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 15, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3946), 3, 37.22m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3953), 5, 22.48m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3960), 12, 66.76m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3967), 13, 55.16m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3973), 8, 28.88m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3979), 7, 93.31m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 8, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3985), 4, 61.63m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3991), 2, 32.25m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(3997), 7, 63.52m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4004), 1, 39.49m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4010), 7, 54.59m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4016), 9, 49.51m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4022), 11, 69.28m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4028), 9, 62.37m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4035), 9, 40.04m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4043), 10, 91.64m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 13, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4050), 3, 19.40m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4062), 3, 26.94m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Price", "Quantity" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4068), 42.72m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4079), 7, 13.07m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 8, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4085), 15, 18.14m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 18, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4102), 8, 86.67m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 12, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4110), 2, 18.24m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4117), 9, 64.06m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4128), 11, 61.69m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4135), 1, 18.03m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4141), 2, 35.63m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 1, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4147), 10, 48.01m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 16, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4153), 5, 67.05m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4160), 10, 66.32m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4166), 2, 21.64m, 1 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4172), 74.84m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4210), 4, 94.79m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4217), 5, 21.54m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4223), 7, 97.89m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 4, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4230), 15, 79.86m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4237), 10, 66.25m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 11, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4243), 9, 42.56m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4249), 7, 73.57m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4255), 13, 29.41m, 2 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 6, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4261), 13, 51.05m, 3 });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "CreatedDate", "Price" },
                values: new object[] { 1, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4268), 95.06m });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "CreatedDate", "OrderId", "Price", "Quantity" },
                values: new object[] { 20, new DateTime(2024, 12, 9, 22, 20, 33, 306, DateTimeKind.Utc).AddTicks(4274), 5, 96.78m, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 8, new DateTime(2024, 12, 9, 22, 20, 33, 302, DateTimeKind.Utc).AddTicks(5925), "Maria.Mante@hotmail.com", "Maria Mante", 8, 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 302, DateTimeKind.Utc).AddTicks(8625), "Jerry.Considine@gmail.com", "Jerry Considine", 8, 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 13, new DateTime(2024, 12, 9, 22, 20, 33, 302, DateTimeKind.Utc).AddTicks(9672), "Chester_Hintz85@yahoo.com", "Chester Hintz", 6 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(415), "Susan.Jaskolski@hotmail.com", "Susan Jaskolski", 7, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 8, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(1083), "Lora.Boyle@yahoo.com", "Lora Boyle", 12, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 6, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(1642), "Elizabeth_Ortiz@gmail.com", "Elizabeth Ortiz", 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(2346), "Melody.Tremblay18@gmail.com", "Melody Tremblay", 15, 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(2984), "Gilberto_Waelchi62@yahoo.com", "Gilberto Waelchi", 14, 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(3639), "Archie58@gmail.com", "Archie Zemlak", 4, 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(4237), "Janet_Goodwin@yahoo.com", "Janet Goodwin", 1, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 13, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(4848), "Kristopher_Kihn@hotmail.com", "Kristopher Kihn", 12, 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 11, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(5519), "Dixie.Daniel@gmail.com", "Dixie Daniel", 7, 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId" },
                values: new object[] { 4, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(6220), "Alexandra_Nitzsche@hotmail.com", "Alexandra Nitzsche", 2 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 303, DateTimeKind.Utc).AddTicks(6868), "Alejandro29@gmail.com", "Alejandro O'Kon", 3, 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BillingAddressId", "CreatedDate", "CustomerEmail", "CustomerName", "ShippingAddressId", "UserId" },
                values: new object[] { 5, new DateTime(2024, 12, 9, 22, 20, 33, 304, DateTimeKind.Utc).AddTicks(8030), "Jean92@yahoo.com", "Jean Monahan", 1, 4 });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Ratione eligendi omnis ut ad. Eius est mollitia eum est dolorum quia nobis id sit. Accusantium officia ut maxime tenetur iste et officiis nihil. Esse fuga qui esse ut veritatis corporis quisquam ex sint. Aut distinctio natus voluptatem eveniet quod aut doloremque autem.", new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(8144), "Wolff, Turcotte and Welch" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Asperiores quasi veniam veritatis laboriosam hic quae corporis. Ut eius perferendis omnis consectetur sed nisi aut et. Facilis facilis voluptatum incidunt aliquam minus unde porro impedit nihil.", new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9012), "Heathcote and Sons" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Aperiam aliquid omnis dolores voluptas et vero aliquam quod assumenda. Dolor iure rerum voluptas sunt quisquam similique. Incidunt neque ut totam minima accusamus cum ullam. Exercitationem officiis eum non vel delectus.", new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9292), "Cremin - Bartell" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Voluptatem non ut eos molestiae quis et. Sed ut et fugiat veritatis est dolorum in. Eveniet animi autem molestias tempore quia ea.", new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9487), "Medhurst Inc" });

            migrationBuilder.UpdateData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Bio", "CreatedDate", "Name" },
                values: new object[] { "Qui magni quia enim consequuntur commodi qui ipsum. Voluptatem modi magni quo architecto asperiores quis veniam. Totam repudiandae fugiat consequatur maiores doloremque aut. Ipsa nobis illo dignissimos repellendus mollitia qui nobis perferendis. Consequuntur aliquam qui vel sed accusantium dolores maxime architecto. Est magnam dignissimos quis ad laudantium fuga.", new DateTime(2024, 12, 9, 22, 20, 33, 293, DateTimeKind.Utc).AddTicks(9640), "Monahan LLC" });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 10, "Labore fugit quia dolorem.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(3535), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Eaque ut quae.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4636), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 3, "Necessitatibus atque consequatur qui.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4695), 3, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 10, "Est exercitationem aut earum nulla quisquam dolores id vel.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4713), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Voluptas nulla est.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4735), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 5, "Dolor quasi aliquid sint laboriosam.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4746), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 4, "Nihil error quas.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4762), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 15, "Nobis assumenda praesentium omnis recusandae.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4773), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 15, "Delectus unde suscipit omnis dolorum ipsam qui eaque sed vero.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4789), 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 6, "Non enim quidem tenetur a odit reiciendis id.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4913), 4, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 10, "Nostrum laudantium illum et illo quam.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4933), 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 1, "Tempore dolorem voluptatem voluptates temporibus fuga voluptatem et accusantium.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4949), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 10, "Ipsa ipsum beatae qui quibusdam ab.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4973), 1, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 4, "Quibusdam qui omnis ut sit vero est odio.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(4989), 2, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 2, "Voluptates eaque quam vel dicta saepe enim quo in.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5008), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 20, "Accusantium sint repellat unde enim hic aperiam suscipit voluptates.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5029), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Quia rerum blanditiis deleniti quos nobis ducimus ea nobis nihil.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5091), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Corporis dolor vero exercitationem vitae non.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5114), 2, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "Quo officia consequatur est sed error id corrupti ullam at.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5128), 3, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Maxime laboriosam officia vitae quis.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5152), 1, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 19, "Ullam eos placeat enim ut.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5165), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 20, "Voluptatem odit enim facilis officia mollitia eum.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5179), 5, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 10, "Et reprehenderit quo minus dolores error dicta accusantium.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5196), 1, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Optio qui molestias consequatur consequatur voluptatem ut officiis culpa vel.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5243), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 20, "Suscipit beatae hic qui ea reiciendis voluptatem.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5267), 1, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 2, "Ab pariatur iure aliquam et.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5285), 5, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 7, "Quis exercitationem vitae ad et ex adipisci voluptas doloremque.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5301), 4, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 13, "Impedit omnis laboriosam nobis saepe error molestias quia qui.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5322), 1, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "Comment", "CreatedDate", "UserId" },
                values: new object[] { 16, "Delectus aut est expedita.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5342), 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Ipsa et rerum et veritatis delectus velit.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5357), 2, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 12, "Hic impedit cum autem tempore.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5376), 4, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "Non ipsa cumque recusandae qui.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5419), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 16, "Beatae iste illum qui distinctio sunt.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5433), 5, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 8, "Illo ut expedita vel asperiores repellat minus ipsum.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5452), 2, 2 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 17, "Est sit aspernatur commodi sed qui maxime et magni architecto.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5471), 2, 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { "Id quo et temporibus animi sequi.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5493), 2, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 10, "Dolorem autem aut accusantium ut dignissimos.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5509), 3, 8 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 2, "Nihil totam aperiam.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5524), 5, 6 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 4, "Maxime maxime rerum tempora earum expedita illo.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5535), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Voluptatem cumque autem molestias eum et atque quasi doloribus.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5584), 2, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Et vitae iure sequi modi doloribus officia quis illum eaque.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5606), 4, 9 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 2, "Est vitae est molestias labore qui fuga doloribus nihil assumenda.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5628), 1, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 19, "Autem voluptate maxime harum eum quia debitis natus.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5650), 4 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 9, "Quis id et quo dignissimos suscipit.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5668), 5, 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Esse nihil odio ipsum cum molestiae.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5684), 1, 10 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 11, "Repudiandae consequatur expedita sapiente.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5700), 5, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 19, "Sed quia enim iste quis iure ducimus sint.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5742), 4, 5 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 18, "Ut eum quas sit reprehenderit delectus.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5763), 3, 7 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars" },
                values: new object[] { 2, "Repudiandae et nemo magnam consequatur.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5778), 3 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BookId", "Comment", "CreatedDate", "Stars", "UserId" },
                values: new object[] { 6, "Eum voluptatem consequatur quo aspernatur in laboriosam illum fugit optio.", new DateTime(2024, 12, 9, 22, 20, 33, 298, DateTimeKind.Utc).AddTicks(5792), 3, 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8413), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8597), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 2, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8604), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8607), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 12, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8610), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 14, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8612), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 14, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8615), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8618), 2 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8620), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8623), 9 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8625), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8628), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8630), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[] { 8, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 10, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8635), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8638), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8641), 7 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UserId" },
                values: new object[] { new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8644), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 19, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8646), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 4, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8649), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 18, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8651), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8654), 8 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 11, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8656), 10 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 7, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8659), 4 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BookId", "CreatedDate" },
                values: new object[] { 13, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8664), 3 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8667), 6 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 1, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8669), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 9, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8672), 5 });

            migrationBuilder.UpdateData(
                table: "WishlistItems",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookId", "CreatedDate", "UserId" },
                values: new object[] { 3, new DateTime(2024, 12, 9, 22, 20, 33, 299, DateTimeKind.Utc).AddTicks(8674), 10 });
        }
    }
}
