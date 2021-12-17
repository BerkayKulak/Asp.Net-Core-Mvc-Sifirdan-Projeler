using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingForms.Models;

namespace BuildingForms.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
            // gelen q ile arama işlemleri yapılır

            return View();
        }
    }
}
