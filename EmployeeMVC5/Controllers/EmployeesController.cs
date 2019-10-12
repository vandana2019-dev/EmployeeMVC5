using EmployeeMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using EmployeeMVC5.ViewModels;


namespace EmployeeMVC5.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Employees
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var employeeTypes = _context.EmploymentTypes.ToList();
            var viewModel = new EmployeeFormViewModel
            {
                Employee = new Employee(),
                EmploymentTypes = employeeTypes
            };
            return View("EmployeeForm", viewModel);
        }
        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if(!ModelState.IsValid)
            {
                var viewModel = new EmployeeFormViewModel
                {
                    Employee = employee,
                    EmploymentTypes = _context.EmploymentTypes.ToList()
                };
                return View("EmployeeForm", viewModel);
                
            }

            // Adding new Employee
            if(employee.Id == 0)
               _context.Employees.Add(employee);

            // Modifying an existing employee
            else
            {
                var employeeInDb = _context.Employees.Single(e => e.Id == employee.Id);

                employeeInDb.FirstName = employee.FirstName;
                employeeInDb.LastName = employee.LastName;
                employeeInDb.EmploymentTypeId = employee.EmploymentTypeId;
                employeeInDb.IsSubscribedToNewsLetter = employee.IsSubscribedToNewsLetter;

            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Employees");
        }
        
        public ActionResult Edit(int id)
        {
            var employee = _context.Employees.SingleOrDefault(e => e.Id == id);

            if (employee == null)
                return HttpNotFound();

            var viewModel = new EmployeeFormViewModel
            {
                Employee = employee,
                EmploymentTypes = _context.EmploymentTypes.ToList()
            };
            return View("EmployeeForm", viewModel);
        }

        public ActionResult Details(int id)
        {
            var employee = _context.Employees.Include(e => e.EmploymentType).SingleOrDefault(c => c.Id == id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        //private IEnumerable<Employee> GetEmployees()
        //{
        //    return new List<Employee>
        //    {
        //        new Employee { Id = 1, FirstName = "Vandana", LastName = "Caringula"},
        //        new Employee { Id = 2, FirstName = "Apeksha", LastName = "Logishetty"},
        //        new Employee { Id = 3, FirstName = "Apoorva", LastName = "Murali"}

        //    };
        //}
    }
}