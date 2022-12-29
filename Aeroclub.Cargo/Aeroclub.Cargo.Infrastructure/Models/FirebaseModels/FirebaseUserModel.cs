using Google.Cloud.Firestore;

namespace Aeroclub.Cargo.Infrastructure.Models.FirebaseModels
{
    [FirestoreData]
    public class FirebaseUserModel
    {
        [FirestoreProperty]
        public bool UnreadNotificationAvailable { get; set; }
        [FirestoreProperty]
        public int UnreadNotificationCount { get; set; }

    }
}
