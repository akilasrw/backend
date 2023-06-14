using Aeroclub.Cargo.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Interfaces
{
    public interface IUploadFactory
    {
        IUploadService CreateUploadServiceAsync(UploadStorageType uploadType);
    }
}
