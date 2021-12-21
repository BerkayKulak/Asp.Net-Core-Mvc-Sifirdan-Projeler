using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlRouting.Models;

namespace UrlRouting.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView",new Result()
            {
                Controller = "ProductController",
                Action = "Index"
            });
        }

        public IActionResult List()
        {
            return View("MyView", new Result()
            {
                Controller = "ProductController",
                Action = "List"
            });
        }

        public IActionResult Newest()
        {
            return View("MyView", new Result()
            {
                Controller = "ProductController",
                Action = "Newest"
            });
        }
    }
}
