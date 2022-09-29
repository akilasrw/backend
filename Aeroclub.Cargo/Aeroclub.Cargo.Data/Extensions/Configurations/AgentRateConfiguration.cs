using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AgentRateConfiguration : IEntityTypeConfiguration<AgentRate>
    {
        public void Configure(EntityTypeBuilder<AgentRate> builder)
        {
            builder.Property(p => p.WeightType).HasColumnType("tinyint").IsRequired();
        }
    }
}
