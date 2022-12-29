using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class Notification : AuditableEntity
    {
        public string? Title { get; set; }
        public string? Body { get; set; }
        public NotificationType NotificationType { get; set; }
        public bool IsRead { get; set; }
        public string? SerializedData { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }
    }
}
