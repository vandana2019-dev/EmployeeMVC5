using EmployeeMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC5.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            var employee = GetEmployees();

            return View(employee);
        }

        public ActionResult Details(int id)
        {
            var employee = GetEmployees().SingleOrDefault(c => c.Id == id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        private IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Vandana", LastName = "Caringula"},
                new Employee { Id = 2, FirstName = "Apeksha", LastName = "Logishetty"},
                new Employee { Id = 3, FirstName = "Apoorva", LastName = "Murali"}

            };
        }
    }
}