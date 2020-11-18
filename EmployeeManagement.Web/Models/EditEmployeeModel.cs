using EmployeeManagement.Models.CustomValidators;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
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
        public string  Email { get; set; }

        [CompareProperty("Email", ErrorMessage = "Email and Confirm Email fields must match")]
        public string  ConfirmEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        public int DepartmentId { get; set; }

        public string PhotoPath { get; set; }

        //[ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
