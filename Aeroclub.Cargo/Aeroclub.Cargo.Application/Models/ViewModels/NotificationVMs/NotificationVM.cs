
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.NotificationVMs
{
    public class NotificationVM : BaseVM
    {
        public string? Title { get; set; }
        public string? Body { get; set; }
        public NotificationType NotificationType { get; set; }
        public bool IsRead { get; set; }
        public Guid UserId { get; set; }
        public DateTime Created { get; set; }
        public string? SerializedData { get; set; }
    }
}
