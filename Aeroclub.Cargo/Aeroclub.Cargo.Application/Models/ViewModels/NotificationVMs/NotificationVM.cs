
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Common.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.NotificationVMs
{
    public class NotificationVM : BaseVM
    {
        public string? Title;

        public string? Body;

        public NotificationType NotificationType;

        public bool IsRead;

        public Guid UserId;

        public DateTime Created;

        public string? SerializedData;
    }
}
