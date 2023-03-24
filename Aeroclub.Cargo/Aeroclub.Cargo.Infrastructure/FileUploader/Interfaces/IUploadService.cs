using Microsoft.AspNetCore.Http;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces
{
    public interface IUploadService
    {
        string Upload(IFormFile file);
    }
}
