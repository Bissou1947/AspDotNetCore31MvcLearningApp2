using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Repository
{
    public class SqlEmployeeRepository : ICompanyRepository<Employee>
    {
        private readonly AppDbContext _appDbContext;
        public SqlEmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Employee Add(Employee entity)
        {
            _appDbContext.Employees.Add(entity);
            _appDbContext.SaveChanges();
            return entity;
        }

        public Employee Delete(int id)
        {
            var emp = GetById(id);
            if (emp != null)
            {
                _appDbContext.Employees.Remove(emp);
                _appDbContext.SaveChanges();
            }
            return emp;
        }

        public IEnumerable<Employee> GetAll()
        {
            return _appDbContext.Employees;
        }

        public Employee GetById(int id)
        {
            return _appDbContext.Employees.SingleOrDefault(x => x.id == id);
        }

        public Employee Update(Employee entity)
        {
            var emp = _appDbContext.Employees.Attach(entity);
            emp.State = EntityState.Modified;
            _appDbContext.SaveChanges();
            return entity;
        }
    }
}
