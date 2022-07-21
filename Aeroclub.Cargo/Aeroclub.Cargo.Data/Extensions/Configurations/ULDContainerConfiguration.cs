using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class ULDContainerConfiguration : IEntityTypeConfiguration<ULDContainer>
    {
        public void Configure(EntityTypeBuilder<ULDContainer> builder)
        {
            builder.Property(p => p.RowNumber).HasColumnType("smallint").IsRequired();
            builder.Property(p => p.ColumnNumber).HasColumnType("smallint").IsRequired();
        }
    }
}
