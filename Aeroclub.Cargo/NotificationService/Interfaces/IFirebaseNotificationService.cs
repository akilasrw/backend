
namespace Aeroclub.Cargo.NotificationService.Application.Interfaces
{
    public interface IFirebaseNotificationService
    {
        Task UpdateUserNotification(string userId, int count);
    }
}
