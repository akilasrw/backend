using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Services
{
    public class BlobUploaderService : UploadService
    {
        private readonly IConfiguration _configuration;

        public BlobUploaderService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public override string Upload(IFormFile file)
        {
            var filename = file.FileName;//GenerateblobFileName(file.FileName);
            string containerName = _configuration["Azure:Blob:Container"];
            return AsyncUploadFile(containerName, GetFileStream(file), filename, "application/pdf").Result;
        }

        private async Task<string> AsyncUploadFile(string containerName, byte[] arr, string filename, string filetype)
        {
            // connection to be given in configuration files or env variable  - Get value from step 10 given in article
            string connectionString = _configuration["Azure:Blob:ConnectionString"].ToString();
            // create a client with the connection
            BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);

            // container name which we created
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = containerClient.GetBlobClient(filename);
            var blobHttpHeader = new BlobHttpHeaders();

            blobHttpHeader.ContentType = filetype;

            using (MemoryStream ms = new MemoryStream(arr))
            {
                var res = await blobClient.UploadAsync(ms, blobHttpHeader); // can use memory stream or file stream or Direct File path
            }

            return blobClient.Uri.AbsoluteUri;
        }

        private byte[] GetFileStream(IFormFile file)
        {
            byte[] fileData;
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                fileData = ms.ToArray();
            }

            return fileData;

        }
    }
}
