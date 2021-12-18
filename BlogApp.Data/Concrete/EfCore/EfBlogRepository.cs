using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Data.Abstract;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class EfBlogRepository:IBlogRepository
    {
        private BlogContext _context;

        public EfBlogRepository(BlogContext context)
        {
            _context = context;
        }
        public Blog GetById(int blogId)
        {
            return _context.Blogs.FirstOrDefault(x => x.BlogId == blogId);
        }

        public IQueryable<Blog> GetAll()
        {
            return _context.Blogs;
        }

        public void AddBlog(Blog entity)
        {
            _context.Blogs.Add(entity);
            _context.SaveChanges();
        }

        public void UpdateBlog(Blog entity)
        {
            //var blog = GetById(entity.BlogId);
            //if (blog != null)
            //{
            //    blog.Title = entity.Title;
            //    blog.Description = entity.Description;
            //    blog.CategoryId = entity.CategoryId;
            //    blog.Image = entity.Image;
                
            //}
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteBlog(int blogId)
        {
            var blog = _context.Blogs.FirstOrDefault(x => x.BlogId == blogId);
            if (blog != null)
            {
                _context.Blogs.Remove(blog);
                _context.SaveChanges();
            }
        }

        public void SaveBlog(Blog entity)
        {
            // ekleme yapıyor
            if (entity.BlogId == 0)
            {
                entity.Date = DateTime.Now;
                _context.Blogs.Add(entity);
            }
            // güncelleme yapıyor
            else
            {
                _context.Entry(entity).State = EntityState.Modified;

            }

            _context.SaveChanges();
        }
    }
}
