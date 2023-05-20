using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public class EmployeeRepository : ICompanyRepository<Employee>
    {
        private readonly List<Employee> employees;
        public EmployeeRepository()
        {
            employees = new List<Employee>
            {
                new Employee{id=0,name="nan",departement=Department.NAN,email="nan",photoPath="/images/employees/avatar/no-avatar.jpg"},
                new Employee{id=1,name="a",departement=Department.Networking,email="aaa" ,photoPath="/images/employees/avatar/employee-avatar.jpeg"},
                new Employee{id=2,name="b",departement=Department.HR,email="bbb" ,photoPath="/images/employees/avatar/employee-avatar.jpeg"},
                new Employee{id=3,name="c",departement=Department.IT,email="ccc" ,photoPath="/images/employees/avatar/employee-avatar.jpeg"},
            };
        }

        public void Add(Employee entity)
        {
            entity.id = employees.Max(e => e.id) + 1;
            entity.photoPath = "/images/employees/avatar/employee-avatar.jpeg";
            employees.Add(entity);
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetById(int id)
        {
            return employees.SingleOrDefault(a=>a.id.Equals(id));
        }
    }
}
