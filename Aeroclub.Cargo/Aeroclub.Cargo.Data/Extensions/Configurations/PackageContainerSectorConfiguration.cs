using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class PackageContainerSectorConfiguration : IEntityTypeConfiguration<PackageContainerSector>
    {
        public void Configure(EntityTypeBuilder<PackageContainerSector> builder)
        {
            builder.HasKey(x => new { x.PackageContainerId, x.SectorId });

            builder.HasOne(ur => ur.PackageContainer)
                .WithMany(u => u.PackageContainerSector)
                .HasForeignKey(ur => ur.PackageContainerId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
