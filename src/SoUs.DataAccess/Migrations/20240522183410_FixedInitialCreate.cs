using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedInitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Tasks_TaskId",
                table: "Medications");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskEmployees_Tasks_TasksTaskId",
                table: "TaskEmployees");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Medications",
                newName: "AssignmentTaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Medications_TaskId",
                table: "Medications",
                newName: "IX_Medications_AssignmentTaskId");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Assignments_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ResidentId",
                table: "Assignments",
                column: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Assignments_AssignmentTaskId",
                table: "Medications",
                column: "AssignmentTaskId",
                principalTable: "Assignments",
                principalColumn: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEmployees_Assignments_TasksTaskId",
                table: "TaskEmployees",
                column: "TasksTaskId",
                principalTable: "Assignments",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Assignments_AssignmentTaskId",
                table: "Medications");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskEmployees_Assignments_TasksTaskId",
                table: "TaskEmployees");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.RenameColumn(
                name: "AssignmentTaskId",
                table: "Medications",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Medications_AssignmentTaskId",
                table: "Medications",
                newName: "IX_Medications_TaskId");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                    table.ForeignKey(
                        name: "FK_Tasks_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ResidentId",
                table: "Tasks",
                column: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Tasks_TaskId",
                table: "Medications",
                column: "TaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskEmployees_Tasks_TasksTaskId",
                table: "TaskEmployees",
                column: "TasksTaskId",
                principalTable: "Tasks",
                principalColumn: "TaskId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
