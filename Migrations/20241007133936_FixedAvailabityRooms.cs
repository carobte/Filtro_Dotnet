using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PruebaNET_CarolinaBustamante.Migrations
{
    /// <inheritdoc />
    public partial class FixedAvailabityRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48,
                column: "availability",
                value: false);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50,
                column: "availability",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 2,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 5,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 7,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 9,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 12,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 15,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 18,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 21,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 24,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 26,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 28,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 30,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 33,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 37,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 41,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 45,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 47,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 48,
                column: "availability",
                value: true);

            migrationBuilder.UpdateData(
                table: "rooms",
                keyColumn: "id",
                keyValue: 50,
                column: "availability",
                value: true);
        }
    }
}
