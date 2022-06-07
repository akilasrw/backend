using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class PackageItemConfiguration : IEntityTypeConfiguration<PackageItem>
    {
        public void Configure(EntityTypeBuilder<PackageItem> builder)
        {
            builder.Property(p => p.PackageRefNumber).HasColumnType("varchar(40)").IsRequired();
            builder.Property(p => p.Description).HasColumnType("nvarchar(250)");
            builder.Property(p => p.PackageItemStatus).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.PackageItemCategory).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.PackagePriorityType).HasColumnType("tinyint").IsRequired();
            builder.HasQueryFilter(p => !EF.Property<bool>(p, "IsDeleted"));
        }
    }
}