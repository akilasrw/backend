using Aeroclub.Cargo.Infrastructure.Interfaces;
using Aeroclub.Cargo.Infrastructure.Models.FirebaseModels;
using Aeroclub.Cargo.NotificationService.Application.Interfaces;

namespace Aeroclub.Cargo.NotificationService.Application.Services
{
    public class FirebaseNotificationService : IFirebaseNotificationService
    {
        private readonly IFirebaseService _firebaseService;

        public FirebaseNotificationService(IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
        }

        public async Task UpdateUserNotification(string userId, int count)
        {
            try
            {
                var model = new FirebaseUserModel
                {
                    UnreadNotificationAvailable = true,
                    UnreadNotificationCount = count
                };

                await _firebaseService.SetDocumentAsync("users", userId, model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
