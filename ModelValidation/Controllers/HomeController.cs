using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelValidation.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Register",new Register(){Birthdate = DateTime.Now});
        }

        [HttpPost]
        public IActionResult Register(Register model)
        {
            return View("Completed",model);
        }

    }
}
