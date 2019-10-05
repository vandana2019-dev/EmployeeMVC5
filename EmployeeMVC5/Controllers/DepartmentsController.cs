using EmployeeMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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