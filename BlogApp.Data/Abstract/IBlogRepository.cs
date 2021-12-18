using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogApp.Data.Abstract
{
    public interface IBlogRepository
    {
        Blog GetById(int blogId);
        IQueryable<Blog> GetAll();
        void AddBlog(Blog entity);
        void UpdateBlog(Blog entity);
        void DeleteBlog(int blogId);

    }
}
