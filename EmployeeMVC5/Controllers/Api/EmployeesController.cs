using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeMVC5.Models;
using EmployeeMVC5.Dtos;
using AutoMapper;

namespace EmployeeMVC5.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET /api/employee
        public IEnumerable<EmployeeDto> GetEmployees()
        {
            return _context.Employees.ToList().Select(Mapper.Map<Employee, EmployeeDto>);
        }

        // GET /api/employees/1
        public IHttpActionResult GetEmployee(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employee == null)
                return NotFound();

            return Ok(Mapper.Map<Employee, EmployeeDto>(employee));
        }

        // POST /api/employees
        [HttpPost]
        public IHttpActionResult CreateEmployee(EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var employee = Mapper.Map<EmployeeDto, Employee>(employeeDto);
            _context.Employees.Add(employee);
            _context.SaveChanges();

            employeeDto.Id = employee.Id;

            return Created(new Uri(Request.RequestUri + "/" + employee.Id), employeeDto);
        }

        // PUT /api/employees/1
        [HttpPut]
        public void UpdateCustomer(int id, EmployeeDto employeeDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var employeeInDb = _context.Employees.SingleOrDefault(c => c.Id == id);

            if (employeeInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(employeeDto, employeeInDb);
           

            _context.SaveChanges();
        }

        // DELETE /api/employee/1
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
