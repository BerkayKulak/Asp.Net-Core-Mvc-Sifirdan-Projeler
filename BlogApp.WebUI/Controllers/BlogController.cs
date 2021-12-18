using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogApp.WebUI.Controllers
{
  
    public class BlogController : Controller
    {
        private IBlogRepository _blogRepository;
        private ICategoryRepository _categoryRepository;
        public BlogController(IBlogRepository blogRepository, ICategoryRepository categoryRepository)
        {
            _blogRepository = blogRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View(_blogRepository.GetAll().Where(i=>i.isApproved).OrderByDescending(i=>i.Date));
        }

        public IActionResult List()
        {
            return View(_blogRepository.GetAll());
        }

        [HttpGet]
        public IActionResult AddOrUpdate(int? id)
        {
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            if (id == null)
            {
                // yeni bir kayıt 
                
                return View(new Blog());

            }
            else
            {
                // güncelleme
                return View(_blogRepository.GetById((int)id));
            }
        }

        [HttpPost]
        public IActionResult AddOrUpdate(Blog entity)
        {
            if (ModelState.IsValid)
            {
                _blogRepository.SaveBlog(entity);
                TempData["message"] = $"{entity.Title} kayıt edildi";
                return RedirectToAction("List");
            }
            ViewBag.Categories = new SelectList(_categoryRepository.GetAll(), "CategoryId", "Name");

            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int BlogId)
        {
            return View(_blogRepository.GetById(BlogId));
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int BlogId)
        {
            _blogRepository.DeleteBlog(blogId: BlogId);
            TempData["message"] = $"{BlogId} numaralı kayıt silindi";
            return RedirectToAction("List");
        }
    }
}
