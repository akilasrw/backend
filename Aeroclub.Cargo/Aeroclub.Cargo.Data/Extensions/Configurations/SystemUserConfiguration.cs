using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class SystemUserConfiguration : IEntityTypeConfiguration<SystemUser>
    {
        public void Configure(EntityTypeBuilder<SystemUser> builder)
        {
            builder.Property(p => p.City).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(p => p.UserStatus).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.UserRole).HasColumnType("tinyint").IsRequired();
            builder.Property(p => p.AccessPortalLevel).HasColumnType("tinyint").IsRequired();
            builder.HasOne(e => e.Country)
            .WithMany()
            .HasForeignKey(e => e.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
