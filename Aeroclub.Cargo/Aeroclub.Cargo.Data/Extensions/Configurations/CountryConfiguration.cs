﻿using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class CountryConfiguration: IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(p => p.Name).HasColumnType("nvarchar(60)").IsRequired();
            builder.Property(p => p.Code).HasColumnType("varchar(3)").IsRequired();
        }
    }
}