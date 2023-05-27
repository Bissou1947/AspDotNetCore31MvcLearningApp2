using System.Collections.Generic;

namespace EmployeeManagement.Repository
{
    public interface ICompanyRepository<T>
    {
        T GetById(int id);
        T Add(T entity);
        IEnumerable<T> GetAll();
        T Delete(int id);
        T Update(T entity);
    }
}
