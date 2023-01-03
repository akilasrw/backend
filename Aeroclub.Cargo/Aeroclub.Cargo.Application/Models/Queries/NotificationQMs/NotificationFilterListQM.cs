using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Queries.NotificationRMs
{
    public class NotificationFilterListQM : BasePaginationQM
    {
        public Guid UserId { get; set; }
        public NotificationFilterType filterType { get; set; }

    }
}
