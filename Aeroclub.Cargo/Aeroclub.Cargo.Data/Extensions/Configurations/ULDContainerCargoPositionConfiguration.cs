using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class ULDContainerCargoPositionConfiguration : IEntityTypeConfiguration<ULDContainerCargoPosition>
    {
        public void Configure(EntityTypeBuilder<ULDContainerCargoPosition> builder)
        {
            builder.HasKey(x => new { x.ULDContainerId, x.CargoPositionId });

            builder.HasOne(ur => ur.ULDContainer)
                .WithMany(u => u.ULDContainerCargoPositions)
                .HasForeignKey(ur => ur.ULDContainerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
