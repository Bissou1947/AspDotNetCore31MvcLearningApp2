using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Extensions
{
    public static class ModelBuilderExtensions
    {
        //...extension
        //... use this to return for the instance of ModelBuilder
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                id = 1,
                departement = Department.IT,
                name = "bissou bissou",
                email = "bissou@gmail.com",
                photoPath = "/images/employees/avatar/employee-avatar.jpeg",
            },
            new Employee
            {
                id = 2,
                departement = Department.Networking,
                name = "fofo fofo",
                email = "fofo@gmail.com",
                photoPath = "/images/employees/avatar/employee-avatar.jpeg",
            },
            new Employee
            {
                id = 3,
                departement = Department.HR,
                name = "Hass Hass",
                email = "Hass@gmail.com",
                photoPath = "/images/employees/avatar/employee-avatar.jpeg",
            });
        }
    }
}
