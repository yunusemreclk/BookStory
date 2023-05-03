using Layer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Seeds
{
    internal class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id =  1, CategoryName = "Macera" },
                new Category { Id = 2, CategoryName = "Tarih" },
                new Category { Id = 3, CategoryName = "Dünya Klasikleri" },
                new Category { Id = 4, CategoryName = "Hikaye" },
                new Category { Id = 5, CategoryName = "BilimKurgu" },
                new Category { Id = 6, CategoryName = "Türk Edebiyatı" },
                new Category { Id = 7, CategoryName = "Roman" },
                new Category { Id = 8, CategoryName = "Polisiye"},
                new Category { Id = 9, CategoryName = "Drama"}
                );
        }
    }
}
