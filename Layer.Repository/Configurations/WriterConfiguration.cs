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
    internal class WriterConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.Property(x=>x.Name).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x=>x.Biography).HasColumnType("varchar").HasMaxLength(500);

        }
    }
}
