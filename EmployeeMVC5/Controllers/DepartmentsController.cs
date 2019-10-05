using EmployeeMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVC5.ViewModels;

namespace EmployeeMVC5.Controllers
{
    public class DepartmentsController : Controller
    {
        private ApplicationDbContext _context;

        public DepartmentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Departments
        public ActionResult Index()
        {
            var departments = _context.Departments.ToList();

            return View(departments);
        }

        public ActionResult Edit(int id)
        {
            var department = _context.Departments.SingleOrDefault(e => e.Id == id);

            if (department == null)
                return HttpNotFound();

            var viewmodel = new DepartmentFormViewModel
            {
                Department = department
            };

            return View("DepartmentForm", viewmodel);
        }

        public ActionResult New()
        {
            return View("DepartmentForm");
        }


        [HttpPost]
        public ActionResult Save(Department department)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new DepartmentFormViewModel
                {
                    Department = department,
                  
                };
                return View("DepartmentForm", viewModel);
            }
                // Adding New Department
                if (department.Id == 0)
                _context.Departments.Add(department);

            // Modifying an existing department
            else
            {
                var departmentInDb = _context.Departments.Single(e => e.Id == department.Id);
                departmentInDb.Name = department.Name;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Departments");
        }

        //private IEnumerable<Department> GetDepartments()
        //{
        //    return new List<Department>
        //    {
        //        new Department { Id = 1, Name = "HR"},
        //        new Department {Id = 1, Name = "Sales"},
        //        new Department {Id = 1, Name = "IT"}
        //    };

        //}
    }
}