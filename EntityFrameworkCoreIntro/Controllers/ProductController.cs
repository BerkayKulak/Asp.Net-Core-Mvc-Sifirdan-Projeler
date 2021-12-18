using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkCoreIntro.Models;

namespace EntityFrameworkCoreIntro.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var products = _productRepository.Products;
            return View(products);
        }
    }
}
