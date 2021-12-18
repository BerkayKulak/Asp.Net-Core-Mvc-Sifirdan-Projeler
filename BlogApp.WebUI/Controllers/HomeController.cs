using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.WebUI.Models;

namespace BlogApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IBlogRepository _repository;

        public HomeController(IBlogRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var model = new HomeBlogModel();
            model.HomeBlogs = _repository.GetAll().Where(i => i.isApproved && i.isHome).ToList();
            model.SliderBlogs = _repository.GetAll().Where(i => i.isApproved && i.isSlider).ToList();
            return View(model);
        }



        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}
