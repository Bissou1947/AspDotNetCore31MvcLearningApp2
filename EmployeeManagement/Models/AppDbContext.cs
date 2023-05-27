using EmployeeManagement.Extensions;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
             base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        //...seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //...create extension methode seed, to make this class not to long
            modelBuilder.Seed();
        }
    }
}
