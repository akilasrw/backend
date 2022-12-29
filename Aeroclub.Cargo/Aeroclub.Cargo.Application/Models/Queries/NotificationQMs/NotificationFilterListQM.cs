using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.NotificationRMs
{
    public class NotificationFilterListQM : BasePaginationQM
    {
        public Guid UserId { get; set; }
        public bool IsUnread { get; set; }

    }
}
