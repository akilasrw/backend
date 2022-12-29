using Aeroclub.Cargo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Aeroclub.Cargo.Data.Extensions.Configurations
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(p => p.Title).HasColumnType("nvarchar(300)").IsRequired();
            builder.Property(p => p.NotificationType).HasColumnType("smallint").IsRequired();
        }
    }
}
