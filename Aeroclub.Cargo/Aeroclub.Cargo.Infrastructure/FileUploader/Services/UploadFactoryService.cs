using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Services
{
    public class UploadFactoryService: IUploadFactory
    {
        private readonly IConfiguration _configuration;

        public UploadFactoryService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private IUploadService _uploadService { get; set; }
        public IUploadService CreateUploadServiceAsync(UploadStorageType uploadType)
        {
            switch (uploadType)
            {
                case UploadStorageType.Blob:
                    _uploadService = new BlobUploaderService(_configuration);
                    break;
            }
            return _uploadService;
        }
    }
}
