using Aeroclub.Cargo.Infrastructure.Configurations;
using Aeroclub.Cargo.Infrastructure.Interfaces;
using Google.Cloud.Firestore;
using Microsoft.Extensions.Options;

namespace Aeroclub.Cargo.Infrastructure.Services
{
    public class FirebaseService : IFirebaseService
    {

        private readonly FirebaseConfiguration _firebaseConfiguration;

        public FirebaseService(IOptions<FirebaseConfiguration> firebaseConfiguration)
        {
            _firebaseConfiguration = firebaseConfiguration.Value;
        }
        private async Task<FirestoreDb> GetDb()
        {
            return await FirestoreDb.CreateAsync(_firebaseConfiguration.ProjectId);
        }

        public async Task AddCollectionAsync(string collectionPath, object collectionObject)
        {
            var db = await GetDb();

            var collection = db.Collection(collectionPath);
            await collection.AddAsync(collectionObject);
        }

        public async Task UpdateDocumentAsync(string documentPath, Dictionary<string, object> keyValues)
        {
            Dictionary<FieldPath, object> updates = new();
            foreach (var keyvaluePair in keyValues)
            {
                updates.Add(new FieldPath(keyvaluePair.Key), keyvaluePair.Value);
            }

            var db = await GetDb();
            var document = db.Document(documentPath);
            await document.UpdateAsync(updates);
        }
        public async Task SetDocumentAsync(string collection, string document, object update)
        {
            var db = await GetDb();
            DocumentReference docRef = db.Collection(collection).Document(document);
            await docRef.SetAsync(update, SetOptions.MergeAll);
        }

        public async Task DeleteDocumentAsync(string documentPath)
        {
            try
            {
                var db = await GetDb();
                var collectionReference = db.Collection(documentPath);
                QuerySnapshot snapshot = await collectionReference.GetSnapshotAsync();
                IReadOnlyList<DocumentSnapshot> documents = snapshot.Documents;
                while (documents.Count > 0)
                {
                    foreach (DocumentSnapshot document in documents)
                    {
                        Console.WriteLine("Deleting document {0}", document.Id);
                        await document.Reference.DeleteAsync();
                    }
                    snapshot = await collectionReference.GetSnapshotAsync();
                    documents = snapshot.Documents;
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }

        public async Task<T> GetDocumentAsync<T>(string collection, string document)
        {
            var db = await GetDb();
            DocumentReference docRef = db.Collection(collection).Document(document);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Console.WriteLine("Document data for {0} document:", snapshot.Id);
                Dictionary<string, object> city = snapshot.ToDictionary();
                foreach (KeyValuePair<string, object> pair in city)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }

                return snapshot.ConvertTo<T>();
            }
            else
            {
                Console.WriteLine("Document {0} does not exist!", snapshot.Id);
                return default;
            }
        }



        public async Task UpdateCollectionAsync(string documentPath, Dictionary<string, object> keyValues, string fieldPath, string value)
        {
            try
            {
                Dictionary<FieldPath, object> updates = new();
                foreach (var keyvaluePair in keyValues)
                {
                    updates.Add(new FieldPath(keyvaluePair.Key), keyvaluePair.Value);
                }

                var db = await GetDb();
                CollectionReference collection = db.Collection(documentPath);
                Query workstationQuery = collection.WhereEqualTo(fieldPath, value);

                QuerySnapshot workstationQuerySnapShot = await workstationQuery.GetSnapshotAsync();
                foreach (var documentSnapshot in workstationQuerySnapShot.Documents)
                {
                    var documentReference = documentSnapshot.Reference;
                    await documentReference.UpdateAsync(updates);
                }
            }
            catch (Exception)
            {
                //TODO
            }
        }

       
    }
}
