using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastucture.Data.SeedData
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            // Check if any Categories exist
            if (!await context.Categories.AnyAsync())
            {
                await context.Categories.AddRangeAsync(
                    new Category { Name = "Electronics" },
                    new Category { Name = "Books" }
                );
            }

            // Check if any Brands exist
            if (!await context.Brands.AnyAsync())
            {
                await context.Brands.AddRangeAsync(
                    new Brand { Name = "Apple" },
                    new Brand { Name = "Samsung" },
                    new Brand { Name = "Microsoft" }
                );
            }

            // Check if any Products exist
            if (!await context.Products.AnyAsync())
            {
                await context.Products.AddRangeAsync(
                    new Product
                    {
                        Name = "iPhone 14",
                     
                        CategoryId = 1,
                        BrandId = 1,
                        Price = 999.99M,
                       
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy S22",
                       
                        CategoryId = 1,
                        BrandId = 2,
                        Price = 799.99M,
                       
                    },
                    new Product
                    {
                        Name = "Surface Pro",
                        
                        CategoryId = 1,
                        BrandId = 3,
                        Price = 1199.99M,
                     
                    }
                );
            }

            // Save changes
            await context.SaveChangesAsync();
        }
    }
}
