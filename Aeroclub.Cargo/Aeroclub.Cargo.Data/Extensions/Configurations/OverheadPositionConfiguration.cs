using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class OverheadPositionConfiguration : IEntityTypeConfiguration<OverheadCompartment>
    {
        public void Configure(EntityTypeBuilder<OverheadCompartment> builder)
        {
            builder.Property(p => p.Sequence).HasColumnType("smallint").IsRequired();
        }
    }
}
