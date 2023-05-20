using System.Collections.Generic;

namespace EmployeeManagement.Repository
{
    public interface ICompanyRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
    }
}
