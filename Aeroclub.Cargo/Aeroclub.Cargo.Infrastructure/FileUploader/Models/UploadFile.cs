using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroclub.Cargo.Infrastructure.FileUploader.Models
{
    public class UploadFile
    {
        public UploadFile()
        {

        }
        public UploadFile(string fileName, string originalFileName, string absoluteURL)
        {
            FileName = fileName;
            OriginalFileName = originalFileName;
            AbsoluteURL = absoluteURL;
        }

        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public string AbsoluteURL { get; set; }
    }
}
