using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMVC5.Models
{
    public class EmploymentType
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }
        public byte DurationInMonths { get; set; }
    }
}