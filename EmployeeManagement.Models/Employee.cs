using EmployeeManagement.Models.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "First Name is a required field")]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        //[EmailDomainValidatorTest(AllowedDomain = "Pragimtech.com", ErrorMessage = "Email Domain must be Pragimtech.com")]
        public string  Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public int DepartmentId { get; set; }

        public string PhotoPath { get; set; }

        public Department Department { get; set; }
    }
}
