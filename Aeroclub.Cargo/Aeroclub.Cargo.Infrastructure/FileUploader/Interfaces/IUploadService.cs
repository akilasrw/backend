using Aeroclub.Cargo.Infrastructure.FileUploader.Models;
using Microsoft.AspNetCore.Http;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces
{
    public interface IUploadService
    {
        UploadFile Upload(IFormFile file);
    }
}
