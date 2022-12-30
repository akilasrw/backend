using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.RequestModels.Notification
{
    public class NotificationRM
    {
        public string? Title;

        public string? Body;

        public NotificationType NotificationType;

        public Guid UserId;

    }
}
