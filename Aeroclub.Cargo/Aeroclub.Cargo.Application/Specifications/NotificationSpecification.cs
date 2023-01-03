using Aeroclub.Cargo.Application.Enums;
using Aeroclub.Cargo.Application.Models.Queries.NotificationQMs;
using Aeroclub.Cargo.Application.Models.Queries.NotificationRMs;
using Aeroclub.Cargo.Core.Entities;
using Aeroclub.Cargo.Core.Services;

namespace Aeroclub.Cargo.Application.Specifications
{
    public class NotificationSpecification : BaseSpecification<Notification>
    {
        public NotificationSpecification(NotificationQM query)
           : base(x => (x.Id == query.Id))
        {

        }

        public NotificationSpecification(NotificationListQM query)
            : base(x => (query.UserId == Guid.Empty || x.UserId == query.UserId) &&
                        (!query.IsUnread || !x.IsRead))
        {

        }

        public NotificationSpecification(NotificationFilterListQM query, bool isCount = false)
            : base(x => (query.UserId == Guid.Empty || x.UserId == query.UserId) && 
            (query.filterType == NotificationFilterType.All || 
            ((query.filterType == NotificationFilterType.Read) ? x.IsRead: !x.IsRead)
            )
            )
        {
            if (!isCount)
            {
                AddOrderByDescending(x => x.Created);
                ApplyPaging(query.PageSize * (query.PageIndex - 1), query.PageSize);
            }
        }

        public NotificationSpecification(NotificationCountQM query)
            : base(x => (query.UserId == Guid.Empty || x.UserId == query.UserId) &&
               (!query.IsUnread || !x.IsRead))
        {

        }

    }
}
