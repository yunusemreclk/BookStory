using Layer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Configurations
{
    public class Book_CategoryConfiguration : IEntityTypeConfiguration<Book_Category>
    {
        public void Configure(EntityTypeBuilder<Book_Category> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x=>x.ID).UseIdentityColumn();
            builder.Property(x=>x.CategoryID).IsRequired();
            builder.Property(x=>x.BookID).IsRequired();
            builder.HasOne(x => x.Book).WithMany(x => x.Book_Categories).HasForeignKey(x => x.BookID);
            builder.HasOne(x=>x.Category).WithMany(x=>x.Book_Categories).HasForeignKey(x=>x.CategoryID);
        }
    }
}
