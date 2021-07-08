using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MVC_Validations.Models;

namespace MVC_Validations.Models
{
    public class brokerModel
    {
        [Required]
        public string Name { get; set; }
        [VinitCustomValidation]
        public string Message { get; set; }
    }
}