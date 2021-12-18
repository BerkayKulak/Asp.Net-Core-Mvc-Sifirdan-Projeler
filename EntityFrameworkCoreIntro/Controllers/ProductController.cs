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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productRepository.CreateProduct(product);
            return RedirectToAction("List");
        }

        public IActionResult Details(int id)
        {
            return View(_productRepository.GetById(id));
        }

        [HttpPost]
        public IActionResult Details(Product product)
        {
            _productRepository.UpdateProduct(product);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            _productRepository.DeleteProduct(id);
            return RedirectToAction("List");
        }


    }
}
