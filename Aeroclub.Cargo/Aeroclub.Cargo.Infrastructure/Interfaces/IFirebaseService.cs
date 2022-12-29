
namespace Aeroclub.Cargo.Infrastructure.Interfaces
{
    public interface IFirebaseService
    {
        Task AddCollectionAsync(string collectionPath, object collectionObject);
        Task UpdateDocumentAsync(string documentPath, Dictionary<string, object> keyValues);
        Task SetDocumentAsync(string collection, string document, object update);
        Task DeleteDocumentAsync(string documentPath);
        Task UpdateCollectionAsync(string documentPath, Dictionary<string, object> keyValues, string fieldPath, string value);
        Task<T> GetDocumentAsync<T>(string collection, string document);
    }
}
