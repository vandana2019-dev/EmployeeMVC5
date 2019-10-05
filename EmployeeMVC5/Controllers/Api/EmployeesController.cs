using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeMVC5.Models;

namespace EmployeeMVC5.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/customers
        public IEnumerable<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }

        // GET /api/customers/1
        public Employee GetEmployee(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employee == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return employee;
        }

        // POST /api/customers
        [HttpPost]
        public Employee CreateEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return employee;
        }

        // PUT /api/employees/1
        [HttpPut]
        public void UpdateCustomer(int id, Employee employee)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var employeeInDb = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            employeeInDb.FirstName = employee.FirstName;
            employeeInDb.LastName = employee.LastName;
            employeeInDb.IsSubscribedToNewsLetter = employee.IsSubscribedToNewsLetter;
            employeeInDb.EmploymentTypeId = employee.EmploymentTypeId;

            _context.SaveChanges();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var employeeInDb = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Employees.Remove(employeeInDb);
            _context.SaveChanges();
        }
    }
}
