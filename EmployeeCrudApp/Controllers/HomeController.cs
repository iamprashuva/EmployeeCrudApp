using EmployeeCrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EmployeeCrudApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public HomeController(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public IActionResult Index()
        {
            var models = _employeeDbContext.Employees.ToList();
            return View(models);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Employees employee) //model binding
        {
            var models = _employeeDbContext.Employees.Add(employee);
            _employeeDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _employeeDbContext.Employees.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Employees employee) 
        {
            var model = _employeeDbContext.Employees.Update(employee);
            _employeeDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var model = _employeeDbContext.Employees.Find(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Employees employee)
        {
            var model = _employeeDbContext.Employees.Remove(employee);
            _employeeDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult About()
        {

            return View();
        }
    }
}
