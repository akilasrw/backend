﻿using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AircraftSubTypeConfiguration : IEntityTypeConfiguration<AircraftSubType>
    {
        public void Configure(EntityTypeBuilder<AircraftSubType> builder)
        {
            builder.Property(p => p.Name).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.Type).HasColumnType("smallint").IsRequired();

        }
    }
}
