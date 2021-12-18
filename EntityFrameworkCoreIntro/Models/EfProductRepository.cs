using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreIntro.Models
{
    public class EfProductRepository:IProductRepository
    {
        private ApplicationDbContext _context;

        public EfProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            
        }
    }
}
