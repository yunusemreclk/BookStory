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
                new Category { CategoryID=  1, CategoryName = "Macera" },
                new Category { CategoryID = 2, CategoryName = "Tarih" },
                new Category { CategoryID = 3, CategoryName = "Dünya Klasikleri" },
                new Category { CategoryID = 4, CategoryName = "Hikaye" },
                new Category { CategoryID = 5, CategoryName = "BilimKurgu" },
                new Category { CategoryID = 6, CategoryName = "Türk Edebiyatı" },
                new Category { CategoryID = 7, CategoryName = "Roman" },
                new Category { CategoryID = 8, CategoryName = "Polisiye"},
                new Category { CategoryID = 9, CategoryName = "Drama"}
                );
        }
    }
}
