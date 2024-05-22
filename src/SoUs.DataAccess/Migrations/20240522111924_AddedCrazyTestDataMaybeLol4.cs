using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCrazyTestDataMaybeLol4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRoles_Employees_EmployeesEmployeeId",
                table: "EmployeeRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRoles_Roles_RolesRoleId",
                table: "EmployeeRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRoles",
                table: "EmployeeRoles");

            migrationBuilder.RenameTable(
                name: "EmployeeRoles",
                newName: "EmployeeRole");

            migrationBuilder.RenameColumn(
                name: "RolesRoleId",
                table: "EmployeeRole",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "EmployeesEmployeeId",
                table: "EmployeeRole",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRoles_RolesRoleId",
                table: "EmployeeRole",
                newName: "IX_EmployeeRole_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole",
                columns: new[] { "EmployeeId", "RoleId" });

            migrationBuilder.InsertData(
                table: "EmployeeRole",
                columns: new[] { "EmployeeId", "RoleId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 1 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 7, 1 },
                    { 8, 1 },
                    { 9, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 12, 1 },
                    { 13, 1 },
                    { 14, 1 },
                    { 15, 1 },
                    { 16, 1 },
                    { 17, 1 },
                    { 18, 1 },
                    { 19, 1 },
                    { 20, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRole_Employees_EmployeeId",
                table: "EmployeeRole",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRole_Roles_RoleId",
                table: "EmployeeRole",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRole_Employees_EmployeeId",
                table: "EmployeeRole");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRole_Roles_RoleId",
                table: "EmployeeRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole");

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 7, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 9, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 12, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 15, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 16, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 17, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 19, 1 });

            migrationBuilder.DeleteData(
                table: "EmployeeRole",
                keyColumns: new[] { "EmployeeId", "RoleId" },
                keyValues: new object[] { 20, 1 });

            migrationBuilder.RenameTable(
                name: "EmployeeRole",
                newName: "EmployeeRoles");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "EmployeeRoles",
                newName: "RolesRoleId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeeRoles",
                newName: "EmployeesEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRole_RoleId",
                table: "EmployeeRoles",
                newName: "IX_EmployeeRoles_RolesRoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRoles",
                table: "EmployeeRoles",
                columns: new[] { "EmployeesEmployeeId", "RolesRoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRoles_Employees_EmployeesEmployeeId",
                table: "EmployeeRoles",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRoles_Roles_RolesRoleId",
                table: "EmployeeRoles",
                column: "RolesRoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
