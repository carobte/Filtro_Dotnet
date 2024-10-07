using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Filtro_Dotnet.Migrations
{
    /// <inheritdoc />
    public partial class FixMaxCapacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "max_occupancy_persons",
                table: "rooms",
                type: "int",
                nullable: false,
                oldClrType: typeof(ulong),
                oldType: "bit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<ulong>(
                name: "max_occupancy_persons",
                table: "rooms",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
