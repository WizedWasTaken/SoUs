using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataInDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "State", "Street", "ZipCode" },
                values: new object[] { 1, "Example City", "EX", "123 Example St", "12345" });

            migrationBuilder.InsertData(
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[] { 1, 1, "Care Center 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1);
        }
    }
}
