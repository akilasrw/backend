using Aeroclub.Cargo.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.Notification
{
    public class NotificationRM
    {
        [Required(ErrorMessage = "Title required.")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Content required.")]
        public string Body { get; set; } = null!;

        [Required(ErrorMessage = "Type required.")]
        public NotificationType NotificationType { get; set; }
        public Guid UserId { get; set; }
        public Guid CargoAgentId { get; set; }
    }
}
