using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AgentRateManagementHistoryConfiguration : IEntityTypeConfiguration<AgentRateManagementHistory>
    {
        public void Configure(EntityTypeBuilder<AgentRateManagementHistory> builder)
        {
            builder.Property(p => p.OriginAirportCode).HasColumnType("varchar(3)").IsRequired();
            builder.Property(p => p.DestinationAirportCode).HasColumnType("varchar(3)").IsRequired();
            builder.Property(p => p.OriginAirportName).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.DestinationAirportName).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.WeightType).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.CreatedUser).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
