using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Models.CustomValidators
{
    class EmailDomainValidatorTest : ValidationAttribute
    {
        public string AllowedDomain { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(value != null)
            {
                string[] strings = value.ToString().Split('@');
                if (strings.Length > 1 && strings[1].ToUpper() == AllowedDomain.ToUpper())
                {
                    return null;
                }
            
                // specify the error message

                //return new ValidationResult($"Email Domain must be {AllowedDomain}",
                //    new[] { validationContext.MemberName });
            
                //OR

                // specify an error message or call the base class error message
                // to use the custom +message passed into the data annotation
                return new ValidationResult(ErrorMessage,
                    new[] { validationContext.MemberName });
            }
            return null;
        }
    }
}
