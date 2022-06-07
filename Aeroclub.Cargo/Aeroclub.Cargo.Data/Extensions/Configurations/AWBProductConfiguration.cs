using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class AWBProductConfiguration : IEntityTypeConfiguration<AWBProduct>
    {
        public void Configure(EntityTypeBuilder<AWBProduct> builder)
        {
            builder.Property(p => p.ProductRefNumber).HasColumnType("varchar(40)");
            builder.Property(p => p.ProductName).HasColumnType("nvarchar(100)");
            builder.Property(p => p.ProductType).HasColumnType("tinyint");
            builder.Property(p => p.Quantity).HasColumnType("tinyint");
            builder.HasQueryFilter(p => !EF.Property<bool>(p, "IsDeleted"));
        }
    }
}
