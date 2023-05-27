using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class init2seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1,
                column: "photoPath",
                value: "/images/employees/avatar/employee-avatar.jpeg");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "departement", "email", "name", "photoPath" },
                values: new object[] { 2, 3, "fofo@gmail.com", "fofo fofo", "/images/employees/avatar/employee-avatar.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1,
                column: "photoPath",
                value: "/images/employee-avatar.jpeg");
        }
    }
}
