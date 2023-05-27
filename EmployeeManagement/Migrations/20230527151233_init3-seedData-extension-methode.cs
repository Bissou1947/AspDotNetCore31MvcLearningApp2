using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class init3seedDataextensionmethode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "departement", "email", "name", "photoPath" },
                values: new object[] { 3, 2, "Hass@gmail.com", "Hass Hass", "/images/employees/avatar/employee-avatar.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
