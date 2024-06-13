using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedmoreStuff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Discriminator",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "MedicineId",
                table: "SubTasks");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "SubTasks");

            migrationBuilder.CreateTable(
                name: "MedicineTasks",
                columns: table => new
                {
                    SubTaskId = table.Column<int>(type: "int", nullable: false),
                    MedicineId = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    AssignmentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicineTasks", x => x.SubTaskId);
                    table.ForeignKey(
                        name: "FK_MedicineTasks_Assignments_AssignmentId1",
                        column: x => x.AssignmentId1,
                        principalTable: "Assignments",
                        principalColumn: "AssignmentId");
                    table.ForeignKey(
                        name: "FK_MedicineTasks_Medications_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medications",
                        principalColumn: "MedicineId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicineTasks_SubTasks_SubTaskId",
                        column: x => x.SubTaskId,
                        principalTable: "SubTasks",
                        principalColumn: "SubTaskId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_AssignmentId1",
                table: "MedicineTasks",
                column: "AssignmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_MedicineTasks_MedicineId",
                table: "MedicineTasks",
                column: "MedicineId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicineTasks");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "SubTasks",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MedicineId",
                table: "SubTasks",
                type: "int",
                nullable: true);

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
    }
}
