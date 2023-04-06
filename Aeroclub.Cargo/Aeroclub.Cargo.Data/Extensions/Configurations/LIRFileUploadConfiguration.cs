using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class LIRFileUploadConfiguration : IEntityTypeConfiguration<LIRFileUpload>
    {
        public void Configure(EntityTypeBuilder<LIRFileUpload> builder)
        {
            builder.Property(p => p.FileName).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(p => p.Extesnsion).HasColumnType("nvarchar(5)");
        }
    }
}
