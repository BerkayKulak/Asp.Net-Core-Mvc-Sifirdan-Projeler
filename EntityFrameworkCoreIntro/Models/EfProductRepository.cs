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

        public Product GetById(int productId)
        {
            return _context.Products.FirstOrDefault(x => x.ProductId == productId);
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = GetById(productId: id);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
