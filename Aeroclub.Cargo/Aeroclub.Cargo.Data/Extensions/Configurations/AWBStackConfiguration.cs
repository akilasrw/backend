using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AWBStackConfiguration : IEntityTypeConfiguration<AWBStack>
    {
        public void Configure(EntityTypeBuilder<AWBStack> builder)
        {
            builder.Property(p => p.StartSequenceNumber).HasColumnType("tinyint");
            builder.Property(p => p.EndSequenceNumber).HasColumnType("tinyint");
            builder.Property(p => p.LastUsedSequenceNumber).HasColumnType("tinyint");
            builder.HasQueryFilter(p => !EF.Property<bool>(p, "IsDeleted"));
        }
    }
}
