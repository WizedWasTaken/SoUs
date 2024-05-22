using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCrazyTestDataMaybeLol1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRoles");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Roles",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "ResidentId", "BirthDate", "CareCenterId", "Name", "Notes", "RoomNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(1930, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hans Hansen", "Hans har brug for hjælp til at komme op om morgenen.", "101" },
                    { 2, new DateTime(1940, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lise Jensen", "Lise har brug for hjælp til at tage medicin.", "102" },
                    { 3, new DateTime(1950, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mads Nielsen", "Mads har brug for hjælp til at komme i bad.", "103" },
                    { 4, new DateTime(1960, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lone Pedersen", "Lone har brug for hjælp til at komme i tøj.", "104" },
                    { 5, new DateTime(1970, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jens Madsen", "Jens har brug for hjælp til at komme i seng.", "105" },
                    { 6, new DateTime(1980, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Helle Hansen", "Helle har brug for hjælp til at komme i kørestol.", "106" },
                    { 7, new DateTime(1990, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mette Jensen", "Mette har brug for hjælp til at komme i stol.", "107" },
                    { 8, new DateTime(2000, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lars Nielsen", "Lars har brug for hjælp til at komme i seng.", "108" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3,
                column: "EmployeeId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles");

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "ResidentId",
                keyValue: 8);

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Roles");

            migrationBuilder.CreateTable(
                name: "EmployeeRoles",
                columns: table => new
                {
                    EmployeesEmployeeId = table.Column<int>(type: "int", nullable: false),
                    RolesRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRoles", x => new { x.EmployeesEmployeeId, x.RolesRoleId });
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRoles_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRoles_RolesRoleId",
                table: "EmployeeRoles",
                column: "RolesRoleId");
        }
    }
}
