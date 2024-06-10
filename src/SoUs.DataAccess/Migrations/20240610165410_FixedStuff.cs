using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medications_SubTasks_SubTaskId",
                table: "Medications");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Assignments_AssignmentId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_Medications_SubTaskId",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "Administered",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "SubTaskId",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "Medications");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "SubTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId1",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "SubTasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubTaskType",
                table: "SubTasks",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "SubTasks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_AssignmentId1",
                table: "SubTasks",
                column: "AssignmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_SubTasks_MedicineId",
                table: "SubTasks",
                column: "MedicineId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Assignments_AssignmentId",
                table: "SubTasks",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Assignments_AssignmentId1",
                table: "SubTasks",
                column: "AssignmentId1",
                principalTable: "Assignments",
                principalColumn: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Medications_MedicineId",
                table: "SubTasks",
                column: "MedicineId",
                principalTable: "Medications",
                principalColumn: "MedicineId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Assignments_AssignmentId",
                table: "SubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Assignments_AssignmentId1",
                table: "SubTasks");

            migrationBuilder.DropForeignKey(
                name: "FK_SubTasks_Medications_MedicineId",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_AssignmentId1",
                table: "SubTasks");

            migrationBuilder.DropIndex(
                name: "IX_SubTasks_MedicineId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "AssignmentId1",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "SubTaskType",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "SubTasks");

            migrationBuilder.AlterColumn<int>(
                name: "AssignmentId",
                table: "SubTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Administered",
                table: "Medications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Medications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubTaskId",
                table: "Medications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "Medications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Medications_SubTaskId",
                table: "Medications",
                column: "SubTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_SubTasks_SubTaskId",
                table: "Medications",
                column: "SubTaskId",
                principalTable: "SubTasks",
                principalColumn: "SubTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_SubTasks_Assignments_AssignmentId",
                table: "SubTasks",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
