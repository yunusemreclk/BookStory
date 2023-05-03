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
    internal class WriterConfiguration : IEntityTypeConfiguration<Writer>
    {
        public void Configure(EntityTypeBuilder<Writer> builder)
        {
            builder.HasKey( x => x.Id);
            builder.Property(x=> x.Id).UseIdentityColumn();
            builder.Property(x=> x.Biography).IsRequired();
            builder.Property(x => x.WriterName).HasMaxLength(150).IsRequired();
         

        }
    }
}
