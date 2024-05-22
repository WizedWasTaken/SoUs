using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1,
                columns: new[] { "City", "State", "Street", "ZipCode" },
                values: new object[] { "Middelfart", "Syddanmark", "Solsikkevej 55", "5500" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 1,
                columns: new[] { "City", "State", "Street", "ZipCode" },
                values: new object[] { "Example City", "EX", "123 Example St", "12345" });
        }
    }
}
