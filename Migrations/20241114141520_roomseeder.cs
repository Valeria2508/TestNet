using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TestNet.Migrations
{
    /// <inheritdoc />
    public partial class roomseeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "rooms",
                columns: new[] { "id", "aviability", "price_night", "room_number", "RoomTypeId" },
                values: new object[,]
                {
                    { 1, true, 50m, "101", 2 },
                    { 2, false, 150m, "102", 4 },
                    { 3, true, 80m, "103", 1 },
                    { 4, true, 200m, "104", 3 },
                    { 5, false, 50m, "105", 2 },
                    { 6, true, 150m, "106", 3 },
                    { 7, false, 80m, "107", 4 },
                    { 8, true, 200m, "108", 1 },
                    { 9, true, 50m, "109", 3 },
                    { 10, false, 150m, "110", 2 }
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
        }
    }
}
