using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixedAnotherMistake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubTaskType",
                table: "SubTasks",
                newName: "Discriminator");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "SubTasks",
                newName: "SubTaskType");
        }
    }
}
