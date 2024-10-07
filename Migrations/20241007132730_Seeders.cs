using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PruebaNET_CarolinaBustamante.Migrations
{
    /// <inheritdoc />
    public partial class Seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "room_types",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "A cozy basic room with a single bed, ideal for solo travelers.", "Single Room" },
                    { 2, "Offers flexibility with two single beds or a double bed, perfect for couples or friends.", "Double Room" },
                    { 3, "Spacious and luxurious, with a king-sized bed and a separate living area, ideal for those seeking comfort and exclusivity.", "Suite" },
                    { 4, "Designed for families, with additional space and multiple beds for a comfortable stay.", "Family Room" }
                });

            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "availability", "max_occupancy_persons", "price_per_night", "room_number", "room_type_id" },
                values: new object[,]
                {
                    { 1, true, 1, 50.0, "101", 1 },
                    { 2, true, 1, 50.0, "102", 1 },
                    { 3, true, 1, 50.0, "103", 1 },
                    { 4, true, 1, 50.0, "104", 1 },
                    { 5, true, 1, 50.0, "105", 1 },
                    { 6, true, 2, 80.0, "106", 2 },
                    { 7, true, 2, 80.0, "107", 2 },
                    { 8, true, 2, 80.0, "108", 2 },
                    { 9, true, 2, 80.0, "109", 2 },
                    { 10, true, 2, 80.0, "110", 2 },
                    { 11, true, 2, 150.0, "201", 3 },
                    { 12, true, 2, 150.0, "202", 3 },
                    { 13, true, 2, 150.0, "203", 3 },
                    { 14, true, 2, 150.0, "204", 3 },
                    { 15, true, 2, 150.0, "205", 3 },
                    { 16, true, 4, 200.0, "206", 4 },
                    { 17, true, 4, 200.0, "207", 4 },
                    { 18, true, 4, 200.0, "208", 4 },
                    { 19, true, 4, 200.0, "209", 4 },
                    { 20, true, 4, 200.0, "210", 4 },
                    { 21, true, 1, 50.0, "301", 1 },
                    { 22, true, 1, 50.0, "302", 1 },
                    { 23, true, 1, 50.0, "303", 1 },
                    { 24, true, 1, 50.0, "304", 1 },
                    { 25, true, 1, 50.0, "305", 1 },
                    { 26, true, 2, 80.0, "306", 2 },
                    { 27, true, 2, 80.0, "307", 2 },
                    { 28, true, 2, 80.0, "308", 2 },
                    { 29, true, 2, 80.0, "309", 2 },
                    { 30, true, 2, 80.0, "310", 2 },
                    { 31, true, 2, 150.0, "401", 3 },
                    { 32, true, 2, 150.0, "402", 3 },
                    { 33, true, 2, 150.0, "403", 3 },
                    { 34, true, 2, 150.0, "404", 3 },
                    { 35, true, 2, 150.0, "405", 3 },
                    { 36, true, 4, 200.0, "406", 4 },
                    { 37, true, 4, 200.0, "407", 4 },
                    { 38, true, 4, 200.0, "408", 4 },
                    { 39, true, 4, 200.0, "409", 4 },
                    { 40, true, 4, 200.0, "410", 4 },
                    { 41, true, 1, 50.0, "501", 1 },
                    { 42, true, 1, 50.0, "502", 1 },
                    { 43, true, 1, 50.0, "503", 1 },
                    { 44, true, 1, 50.0, "504", 1 },
                    { 45, true, 1, 50.0, "505", 1 },
                    { 46, true, 4, 200.0, "506", 4 },
                    { 47, true, 4, 200.0, "507", 4 },
                    { 48, true, 4, 200.0, "508", 4 },
                    { 49, true, 4, 200.0, "509", 4 },
                    { 50, true, 4, 200.0, "510", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "room_types",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
