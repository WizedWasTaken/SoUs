using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class maybefixedSomething : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                table: "EmployeeTask");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTask_Tasks_TasksTaskId",
                table: "EmployeeTask");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeTask",
                table: "EmployeeTask");

            migrationBuilder.RenameTable(
                name: "EmployeeTask",
                newName: "TaskEmployees");

            migrationBuilder.RenameColumn(
                name: "Completed",
                table: "Tasks",
                newName: "IsCompleted");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeTask_TasksTaskId",
                table: "TaskEmployees",
                newName: "IX_TaskEmployees_TasksTaskId");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Residents",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Medications",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CareCenters",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaskEmployees",
                table: "TaskEmployees",
                columns: new[] { "EmployeesEmployeeId", "TasksTaskId" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "State", "Street", "ZipCode" },
                values: new object[,]
                {
                    { 2, "Roskilde", "Sjælland", "Roskildevej 12", "4000" },
                    { 3, "København", "Hovedstaden", "Hovedgaden 1", "1000" },
                    { 4, "Viborg", "Midtjylland", "Viborgvej 5", "8800" },
                    { 5, "Herning", "Midtjylland", "Herningvej 10", "7400" },
                    { 6, "Odense", "Syddanmark", "Odensevej 15", "5000" },
                    { 7, "Aalborg", "Nordjylland", "Aalborgvej 20", "9000" },
                    { 8, "Esbjerg", "Syddanmark", "Esbjergvej 25", "6700" },
                    { 9, "Horsens", "Midtjylland", "Horsensvej 30", "8700" },
                    { 10, "Randers", "Midtjylland", "Randersvej 35", "8900" }
                });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 4, "GGM (Glade Gamle Mennesker)" });

            migrationBuilder.InsertData(
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[,]
                {
                    { 5, 1, "Solskinshjemmet" },
                    { 2, 8, "Hjemmet" },
                    { 3, 5, "Smilets Hus" },
                    { 4, 2, "SFG (Sjov For Gamle)" },
                    { 6, 3, "Hyggehuset" },
                    { 7, 6, "" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEmployees_Employees_EmployeesEmployeeId",
                table: "TaskEmployees",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEmployees_Tasks_TasksTaskId",
                table: "TaskEmployees",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskEmployees_Employees_EmployeesEmployeeId",
                table: "TaskEmployees");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskEmployees_Tasks_TasksTaskId",
                table: "TaskEmployees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaskEmployees",
                table: "TaskEmployees");

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: 8);

            migrationBuilder.RenameTable(
                name: "TaskEmployees",
                newName: "EmployeeTask");

            migrationBuilder.RenameColumn(
                name: "IsCompleted",
                table: "Tasks",
                newName: "Completed");

            migrationBuilder.RenameIndex(
                name: "IX_TaskEmployees_TasksTaskId",
                table: "EmployeeTask",
                newName: "IX_EmployeeTask_TasksTaskId");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "RoomNumber",
                table: "Residents",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Residents",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Residents",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Unit",
                table: "Medications",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "CareCenters",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Addresses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeTask",
                table: "EmployeeTask",
                columns: new[] { "EmployeesEmployeeId", "TasksTaskId" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 1, "Care Center 1" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTask_Employees_EmployeesEmployeeId",
                table: "EmployeeTask",
                column: "EmployeesEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTask_Tasks_TasksTaskId",
                table: "EmployeeTask",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
