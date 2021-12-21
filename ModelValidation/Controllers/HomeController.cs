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
            if (string.IsNullOrEmpty(model.UserName))
            {
                ModelState.AddModelError(nameof(model.UserName),"Username zorunlu bir alan");
            }

            if (string.IsNullOrEmpty(model.Email))
            {
                ModelState.AddModelError(nameof(model.Email),"Email Zorunlu alan");
            }
            else
            {
                if (!model.Email.Contains("@"))
                {
                    ModelState.AddModelError(nameof(model.Email), "Email Düzgün girilmemiş");
                }
            }

            

            if (!model.TermsAccepted)
            {
                ModelState.AddModelError(nameof(model.TermsAccepted),"Kullanımı koşullarını kabul etmelisiniz");
            }

            if (ModelState.IsValid)
            {
                return View("Completed", model);
            }
            else
            {
                return View(model);
            }

        }



    }
}
