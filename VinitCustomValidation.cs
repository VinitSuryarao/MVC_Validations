using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Validations
{
    public class VinitCustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string message = value.ToString();
                if (message.Contains("vinit"))
                {
                    return ValidationResult.Success;
                }
            }
            return new ValidationResult("Name must Contain Vinit Word");
        }
    }
}