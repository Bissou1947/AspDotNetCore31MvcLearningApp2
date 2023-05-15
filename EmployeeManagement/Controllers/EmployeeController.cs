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

        //[Route("")]
        public ViewResult Index()
        {
            return View(_companyRepositoryEmployee.GetAll());
        }
        //[HttpGet("Modify/{id:int:min(1)}")]
        public string Edit(int id)
        {
            return "Edit: " + id.ToString();
        }
        //[HttpGet("Remove/{id:int:min(1)}")]
        public string Delete(int id)
        {
            return "deleted: " + id.ToString();
        }

        //[Route("Informations")]
        public ViewResult Details(int id)
        {
            return View(_companyRepositoryEmployee.GetById(id));
        }



        //....api
        //...ObjectResult for the user to take even json or even xml format
        //[Route("Informations-Web/{id:int:min(1)}")]
        public ObjectResult ApiGetById(int id)
        {
            return new ObjectResult(_companyRepositoryEmployee.GetById(id));
        }
    }
}
