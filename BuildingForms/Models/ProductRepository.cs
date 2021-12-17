using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingForms.Models
{
    public class ProductRepository
    {
        private static List<Product> _Products { get; set; }

        static ProductRepository()
        {
            _Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Description = "Description 1",
                    Price = 10,
                    isApproved = true
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Description = "Description 2",
                    Price = 10,
                    isApproved = true
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 3",
                    Description = "Description 3",
                    Price = 20,
                    isApproved = false
                },
                new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    Description = "Description 4",
                    Price = 30,
                    isApproved = true
                },

            };
        }

        public static List<Product> Products
        {
            get { return _Products; }
        }

        public static void AddProduct(Product entity)
        {
            _Products.Add(entity);
        }
    }
}
