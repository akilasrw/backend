using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class LoadPlanConfiguration : IEntityTypeConfiguration<LoadPlan>
    {
        public void Configure(EntityTypeBuilder<LoadPlan> builder)
        {
            builder.Property(p => p.LoadPlanStatus).HasColumnType("tinyint").IsRequired();
        }
    }
}