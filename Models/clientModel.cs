using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Validations.Models
{
    public class clientModel
    {
        [Required(ErrorMessage ="Custom Error Mesage Enter Data")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Range(18,100)]
        public int Age { get; set; }
    }
}