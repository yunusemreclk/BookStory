using Layer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(x=>x.Name).HasColumnType("varchar").HasMaxLength(150);
            builder.Property(x => x.Summary).HasColumnType("varchar").HasMaxLength(500);
            builder.Property(x => x.Price).HasColumnType("money");
            builder.Property(x => x.Pages).HasColumnType("short");
        }
    }
}
