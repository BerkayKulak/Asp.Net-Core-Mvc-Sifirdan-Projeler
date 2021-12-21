using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelBinding.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index(int? id)
        {
            Customer customer;
            if (id.HasValue && (customer = repository.Get(id.Value)) != null)
            {
                return View(customer);
            }
            else
            {
                return NotFound();
            }
            return View();
        }



    }
}
