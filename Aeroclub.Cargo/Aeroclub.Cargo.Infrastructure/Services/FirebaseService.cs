using Aeroclub.Cargo.Infrastructure.Interfaces;

namespace Aeroclub.Cargo.Infrastructure.Services
{
    public class FirebaseService : IFirebaseService
    {

        public FirebaseService() { }


        public Task AddCollectionAsync(string collectionPath, object collectionObject)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDocumentAsync(string documentPath)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetDocumentAsync<T>(string collection, string document)
        {
            throw new NotImplementedException();
        }

        public Task SetDocumentAsync(string collection, string document, object update)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCollectionAsync(string documentPath, Dictionary<string, object> keyValues, string fieldPath, string value)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDocumentAsync(string documentPath, Dictionary<string, object> keyValues)
        {
            throw new NotImplementedException();
        }
    }
}
