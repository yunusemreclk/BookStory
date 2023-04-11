using Layer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.CategoryID);
            builder.Property(x=>x.CategoryID).UseIdentityColumn();
            builder.Property(x=>x.CategoryName).HasColumnType("varchar").HasMaxLength(50);
            builder.HasMany(x=>x.Book_Categories).WithOne(x=>x.Category).HasForeignKey(x=>x.CategoryID);
        }
    }
}
