using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;

namespace Project.Infrastucture.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(b => b.Id)
                   .ValueGeneratedOnAdd();  // Auto-incremented primary key

            builder.Property(b => b.Name)
                   .IsRequired()
                   .HasMaxLength(50);  // Name is required and has a max length of 50

            builder.HasData(
                new Brand { Id = 1, Name = "Apple" },
                new Brand { Id = 2, Name = "Samsung" },
                new Brand { Id = 3, Name = "Microsoft" }
            );
        }
    }
}
