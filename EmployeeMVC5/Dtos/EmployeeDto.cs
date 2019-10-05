using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeMVC5.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        public string LastName { get; set; }

      
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public bool IsSubscribedToNewsLetter { get; set; }

       
        public byte EmploymentTypeId { get; set; }
    }
}