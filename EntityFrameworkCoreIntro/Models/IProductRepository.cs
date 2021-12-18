using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCoreIntro.Models
{
    public interface IProductRepository
    {
         IQueryable<Product> Products { get; }
         void CreateProduct(Product product);
    }
}
