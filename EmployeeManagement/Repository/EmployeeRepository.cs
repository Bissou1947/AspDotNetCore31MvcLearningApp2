using EmployeeManagement.Models;
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
                new Employee{id=0,name="nan",departement="nan",email="nan",photoPath="/images/employees/avatar/no-avatar.jpg"},
                new Employee{id=1,name="a",departement="aa",email="aaa" ,photoPath="/images/employees/avatar/employee-avatar.jpeg"},
                new Employee{id=2,name="b",departement="bb",email="bbb" ,photoPath="/images/employees/avatar/employee-avatar.jpeg"},
                new Employee{id=3,name="c",departement="cc",email="ccc" ,photoPath="/images/employees/avatar/employee-avatar.jpeg"},
            };
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
