using EmployeeManagement.Models;
using EmployeeManagement.Repository;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ICompanyRepository<Employee> _companyRepositoryEmployee;
        public EmployeeController(ICompanyRepository<Employee> companyRepository)
        {
            _companyRepositoryEmployee = companyRepository;
        }

        public ViewResult Index()
        {
            return View(_companyRepositoryEmployee.GetAll());
        }

        public ViewResult Details(int id)
        {
            EmploeeDetailsVM details = new EmploeeDetailsVM
            {
                employee = _companyRepositoryEmployee.GetById(id)
            };
            details.title = details.employee.name + " - Details";
            return View(details);
        }



        //....api
        //...ObjectResult for the user to take even json or even xml format
        public ObjectResult ApiGetById(int id)
        {
            return new ObjectResult(_companyRepositoryEmployee.GetById(id));
        }
    }
}
