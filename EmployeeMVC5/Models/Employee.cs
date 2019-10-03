using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMVC5.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}