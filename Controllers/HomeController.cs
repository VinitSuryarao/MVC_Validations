using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Validations.Models;

namespace MVC_Validations.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitForm(clientModel client)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("Index");
            }
        }
    }
}