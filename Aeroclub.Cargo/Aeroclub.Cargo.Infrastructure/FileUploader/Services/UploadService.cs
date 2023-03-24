using Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Services
{
    public abstract class UploadService : IUploadService
    {
        public abstract string Upload(IFormFile file);

        // generate a unique name for the files we upload
        public static string GenerateblobFileName(string fileName)
        {
            string strFileName = string.Empty;
            string[] strName = fileName.Split('.');
            strFileName = "lir" + DateTime.Now.ToUniversalTime().ToString("yyyyMMddHHmmss");// + "." + strName[strName.Length - 1];
            return strFileName;

        }

    }
}
