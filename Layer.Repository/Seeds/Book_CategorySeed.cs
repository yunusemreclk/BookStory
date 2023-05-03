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
    internal class Book_CategorySeed : IEntityTypeConfiguration<Book_Category>
    {
        public void Configure(EntityTypeBuilder<Book_Category> builder)
        {
            builder.HasData(
                new Book_Category { Id = 1, BookID = 1, CategoryID = 3 },
                new Book_Category { Id = 2, BookID = 1, CategoryID = 7 },
                new Book_Category { Id = 3, BookID = 2, CategoryID = 3 },
                new Book_Category { Id = 4, BookID = 2, CategoryID = 7 },
                new Book_Category { Id = 5, BookID = 2, CategoryID = 8 },
                new Book_Category { Id = 6, BookID = 3, CategoryID = 7 },
                new Book_Category { Id = 7, BookID = 4, CategoryID = 3 },
                new Book_Category { Id = 8, BookID = 4, CategoryID = 7 },
                new Book_Category { Id = 9, BookID = 4, CategoryID = 2 },
                new Book_Category { Id = 10, BookID = 5, CategoryID = 7 },
                new Book_Category { Id = 11, BookID = 6, CategoryID = 9 },
                new Book_Category { Id = 12, BookID = 7, CategoryID = 7 },
                new Book_Category { Id = 13, BookID = 7, CategoryID = 2 },
                new Book_Category { Id = 14, BookID = 8, CategoryID = 7 },
                new Book_Category { Id = 15, BookID = 9, CategoryID = 1 },
                new Book_Category { Id = 16, BookID = 9, CategoryID = 4 },
                new Book_Category { Id = 17, BookID = 10, CategoryID = 9 },
                new Book_Category { Id = 18, BookID = 10, CategoryID = 8 },
                new Book_Category { Id = 19, BookID = 11, CategoryID = 6 },
                new Book_Category { Id = 20, BookID = 12, CategoryID = 4 },
                new Book_Category { Id = 21, BookID = 13, CategoryID = 4 },
                new Book_Category { Id = 22, BookID = 14, CategoryID = 4 },
                new Book_Category { Id = 23, BookID = 15, CategoryID = 7 }
                );
        }
    }
}
