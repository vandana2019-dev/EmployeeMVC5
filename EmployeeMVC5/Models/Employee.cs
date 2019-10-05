﻿using System;
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

        [Required(ErrorMessage = "Please enter Employee's First Name")]
        [StringLength(255)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Full Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public bool IsSubscribedToNewsLetter { get; set; }

        public EmploymentType EmploymentType { get; set; }

        [DisplayName("Employment Type")]
        public byte EmploymentTypeId { get; set; }
    }
}