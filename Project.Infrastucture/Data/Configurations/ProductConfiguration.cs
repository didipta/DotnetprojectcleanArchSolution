using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastucture.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id)
                   .ValueGeneratedOnAdd();  // Auto-incremented primary key

            builder.Property(c => c.Name)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.HasOne(p => p.Category)
                   .WithMany(c => c.Products)
                   .HasForeignKey(p => p.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Brand)
                   .WithMany(b => b.Products)
                   .HasForeignKey(p => p.BrandId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "iPhone 14",
                   
                    CategoryId = 1,  // Electronics
                    BrandId = 1,     // Apple
                    Price = 999.99M,
              
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S22",
                 
                    CategoryId = 1,  // Electronics
                    BrandId = 2,     // Samsung
                    Price = 799.99M,
                
                },
                new Product
                {
                    Id = 3,
                    Name = "Surface Pro",
                  
                    CategoryId = 1,  // Electronics
                    BrandId = 3,     // Microsoft
                    Price = 1199.99M,
                   
                });
        }
    }
}
