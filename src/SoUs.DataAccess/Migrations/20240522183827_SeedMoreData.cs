using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "TaskId", "IsCompleted", "Name", "ResidentId", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, false, "Hjælp til at komme op", 1, new DateTime(2021, 1, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, false, "Hjælp til at tage medicin", 2, new DateTime(2021, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, false, "Hjælp til at komme i bad", 3, new DateTime(2021, 1, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, false, "Hjælp til at komme i tøj", 4, new DateTime(2021, 1, 1, 11, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, false, "Hjælp til at komme i seng", 5, new DateTime(2021, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, false, "Hjælp til at komme i kørestol", 6, new DateTime(2021, 1, 1, 13, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, false, "Hjælp til at komme i stol", 7, new DateTime(2021, 1, 1, 14, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, false, "Hjælp til at komme i seng", 8, new DateTime(2021, 1, 1, 15, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 1, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "TaskId",
                keyValue: 8);
        }
    }
}
