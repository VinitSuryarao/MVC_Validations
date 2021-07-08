using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Validations.Models;

namespace MVC_Validations.Controllers
{
    public class CustomValidationController : Controller
    {
        // GET: CustomValidation
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitForm(brokerModel broker)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear(); // to Clear field data
                return View();
            }
            else
            {
                return View("Index");
            }
            
        }
    }
}