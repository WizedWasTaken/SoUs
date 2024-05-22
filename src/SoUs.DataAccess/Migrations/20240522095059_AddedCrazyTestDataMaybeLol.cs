using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SoUs.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCrazyTestDataMaybeLol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 1, "Middelfart Plejehjem" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 2,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 2, "Roskilde Plejehjem" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 3,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 3, "København Plejehjem" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 4,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 4, "Viborg Plejehjem" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 5,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 5, "Herning Plejehjem" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 6,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 6, "Odense Plejehjem" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 7,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 7, "Aalborg Plejehjem" });

            migrationBuilder.InsertData(
                table: "CareCenters",
                columns: new[] { "CareCenterId", "AddressId", "Name" },
                values: new object[,]
                {
                    { 8, 8, "Esbjerg Plejehjem" },
                    { 9, 9, "Horsens Plejehjem" },
                    { 10, 10, "Randers Plejehjem" }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "DiagnosisId", "Description", "Name", "ResidentId" },
                values: new object[,]
                {
                    { 1, "Alzheimer er en sygdom, der angriber hjernen og fører til hukommelsestab og nedsat kognitiv funktion.", "Alzheimer", null },
                    { 2, "Demens er en samlet betegnelse for en række symptomer, der skyldes sygdomme i hjernen.", "Demens", null },
                    { 3, "Parkinson er en kronisk sygdom, der angriber hjernen og fører til rysten, stivhed og langsomme bevægelser.", "Parkinson", null },
                    { 4, "KOL er en samlet betegnelse for en række lungesygdomme, der gør det svært at trække vejret.", "KOL", null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "CareCenterId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Mette Jensen" },
                    { 2, 1, "Lars Nielsen" },
                    { 3, 1, "Helle Pedersen" },
                    { 4, 1, "Mads Hansen" },
                    { 5, 1, "Lone Madsen" },
                    { 6, 1, "Jens Pedersen" },
                    { 7, 2, "Lise Jensen" },
                    { 8, 2, "Hans Nielsen" },
                    { 9, 2, "Mette Pedersen" },
                    { 10, 2, "Lars Hansen" },
                    { 11, 2, "Helle Madsen" },
                    { 12, 2, "Mads Pedersen" },
                    { 13, 3, "Lone Hansen" },
                    { 14, 3, "Jens Madsen" },
                    { 15, 3, "Lise Pedersen" },
                    { 16, 3, "Hans Jensen" },
                    { 17, 4, "Mette Nielsen" },
                    { 18, 4, "Lars Pedersen" },
                    { 19, 4, "Helle Hansen" },
                    { 20, 4, "Mads Madsen" }
                });

            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "MedicineId", "Administered", "Amount", "Name", "TaskId", "Unit" },
                values: new object[,]
                {
                    { 1, false, 500, "Paracetamol", null, "mg" },
                    { 2, true, 400, "Ibuprofen", null, "mg" },
                    { 3, false, 10, "Vitamin D", null, "ug" },
                    { 4, false, 100, "Vitamin C", null, "mg" },
                    { 5, false, 2, "Vitamin B12", null, "ug" },
                    { 6, true, 200, "Magnesium", null, "mg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "SoSu Hjælper" },
                    { 2, "Task planner" },
                    { 3, "Administrativ medarbejder" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "DiagnosisId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicineId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicineId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "MedicineId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 1,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 4, "GGM (Glade Gamle Mennesker)" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 2,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 8, "Hjemmet" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 3,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 5, "Smilets Hus" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 4,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 2, "SFG (Sjov For Gamle)" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 5,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 1, "Solskinshjemmet" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 6,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 3, "Hyggehuset" });

            migrationBuilder.UpdateData(
                table: "CareCenters",
                keyColumn: "CareCenterId",
                keyValue: 7,
                columns: new[] { "AddressId", "Name" },
                values: new object[] { 6, "De Gamles Hus" });
        }
    }
}
