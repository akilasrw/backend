﻿

using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AWBInformationConfigration : IEntityTypeConfiguration<AWBInformation>
    {
        public void Configure(EntityTypeBuilder<AWBInformation> builder)
        {
            builder.Property(p => p.ShipperName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.ShipperAccountNumber).HasColumnType("varchar(40)");
            builder.Property(p => p.ShipperAddress).HasColumnType("nvarchar(200)");
            builder.Property(p => p.ConsigneeName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.ConsigneeAccountNumber).HasColumnType("varchar(40)");
            builder.Property(p => p.ConsigneeAddress).HasColumnType("nvarchar(200)");
            builder.Property(p => p.AgentName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.AgentCity).HasColumnType("nvarchar(60)");
            builder.Property(p => p.AgentAITACode).HasColumnType("varchar(40)");
            builder.Property(p => p.AgentAccountNumber).HasColumnType("varchar(40)");
            builder.Property(p => p.AgentAccountInformation).HasColumnType("nvarchar(200)");
            builder.Property(p => p.RequestedRouting).HasColumnType("nvarchar(100)");
            builder.Property(p => p.RoutingAndDestinationBy).HasColumnType("nvarchar(100)");
            builder.Property(p => p.RoutingAndDestinationTo).HasColumnType("nvarchar(100)");
            builder.Property(p => p.DestinationAirportName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.ShippingReferenceNumber).HasColumnType("varchar(40)");
            builder.Property(p => p.Currency).HasColumnType("varchar(10)");
            builder.Property(p => p.NatureAndQualityOfGoods).HasColumnType("nvarchar(400)");
        }

    }
}
