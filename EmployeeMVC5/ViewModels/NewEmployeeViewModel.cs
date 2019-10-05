using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeMVC5.Models;

namespace EmployeeMVC5.ViewModels
{
    public class EmployeeFormViewModel
    {
        public IEnumerable<EmploymentType> EmploymentTypes { get; set; } 
        public Employee Employee { get; set; }

    }
}