using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkCoreIntro.Models
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            // contextte product oluşturulmuş mu ??
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    
                    new Product()
                    {
                        Name = "Product 1",
                        Description = "Product Description 1",
                        Price = 100,
                        Category = "Kategori 1",
                    },
                    new Product()
                    {
                        Name = "Product 2",
                        Description = "Product Description 2",
                        Price = 200,
                        Category = "Kategori 1",
                    },
                    new Product()
                    {
                        Name = "Product 3",
                        Description = "Product Description 3",
                        Price = 300,
                        Category = "Kategori 3",
                    },
                    new Product()
                    {
                        Name = "Product 4",
                        Description = "Product Description 4",
                        Price = 400,
                        Category = "Kategori 4",
                    }
                    

                );

                context.SaveChanges();
            }
        }
    }
}
