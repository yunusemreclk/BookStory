using Layer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
            public void Configure(EntityTypeBuilder<Book> builder)
            {
                builder.Property(x => x.Id).UseIdentityColumn();
                builder.Property(x => x.BookName).HasColumnType("varchar").HasMaxLength(150).IsRequired();
                builder.Property(x => x.Price).HasColumnType("money").IsRequired();
                builder.Property(x => x.Image).HasMaxLength(100).HasColumnType("varchar");
                builder.Property(x => x.Pages).IsRequired();
                builder.HasOne(x => x.Writer).WithMany(x => x.Books).HasForeignKey(x => x.WriterID) ;

          
            }

    }
}
