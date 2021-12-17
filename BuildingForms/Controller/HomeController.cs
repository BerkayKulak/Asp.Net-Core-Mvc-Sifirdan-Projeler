using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.Categories = new SelectList(new List<string>()
            {
                "Telefon",
                "Tablet",
                "Laptop"
            });

            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            ProductRepository.AddProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Search(string q)
        {
            // gelen q ile arama işlemleri yapılır

            if (string.IsNullOrWhiteSpace(q))
            {
                return View();
            }
            else
            {
                return View("Index",ProductRepository.Products.Where(x=>x.Name.Contains(q)));
            }
            
        }
    }
}
