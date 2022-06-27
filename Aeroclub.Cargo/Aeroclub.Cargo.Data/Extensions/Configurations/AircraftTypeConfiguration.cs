using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AircraftTypeConfiguration : IEntityTypeConfiguration<AircraftType>
    {
        public void Configure(EntityTypeBuilder<AircraftType> builder)
        {
            builder.Property(p => p.Name).HasColumnType("nvarchar(80)").IsRequired();
            builder.Property(p => p.Type).HasColumnType("smallint").IsRequired();

            builder.HasMany(ur => ur.AircraftSubTypes)
              .WithOne(u => u.AircraftType)
              .HasForeignKey(ur => ur.AircraftTypeId)
              .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
