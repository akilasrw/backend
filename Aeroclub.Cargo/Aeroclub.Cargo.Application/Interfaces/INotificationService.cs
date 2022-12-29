
using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.Queries.NotificationQMs;
using Aeroclub.Cargo.Application.Models.Queries.NotificationRMs;
using Aeroclub.Cargo.Application.Models.ViewModels.NotificationVMs;

namespace Aeroclub.Cargo.Application.Interfaces
{
    public interface INotificationService
    {
        Task<NotificationVM> GetAsync(NotificationQM query);
        Task<IReadOnlyList<NotificationVM>> GetListAsync(NotificationListQM query);
        Task<Pagination<NotificationVM>> GetFilteredListAsync(NotificationFilterListQM query);
        Task<bool> DeleteAsync(Guid id);
        Task<Tuple<bool, Guid>> MarkAsReadAsync(Guid id);
        Task<bool> MarkAllAsReadAsync(Guid userId);
        Task<int> CountAsync(NotificationCountQM query);

    }
}
