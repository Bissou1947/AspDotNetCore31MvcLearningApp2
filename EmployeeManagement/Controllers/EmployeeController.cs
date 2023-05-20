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
            return View(_companyRepositoryEmployee.GetById(id));
        }

        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee data)
        {
            if (ModelState.IsValid)
            {
                _companyRepositoryEmployee.Add(data);
                return RedirectToAction("Details", new { id = data.id });
            }
            ModelState.AddModelError("","Faild: check the errors.");
            return View(data);
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
