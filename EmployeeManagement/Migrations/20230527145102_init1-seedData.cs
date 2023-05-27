using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Migrations
{
    public partial class init1seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "departement", "email", "name", "photoPath" },
                values: new object[] { 1, 1, "bissou@gmail.com", "bissou bissou", "/images/employee-avatar.jpeg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
