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
    internal class CategorySeed:IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Name = "Macera" },
                new Category { Id = 2, Name = "Tarih" },
                new Category { Id = 3, Name = "Dünya Klasikleri" },
                new Category { Id = 4, Name = "Hikaye" },
                new Category { Id = 5, Name = "BilimKurgu" },
                new Category { Id = 6, Name = "Türk Edebiyatı" },
                new Category { Id = 7, Name = "Roman" }
                );
        }
    }
}

