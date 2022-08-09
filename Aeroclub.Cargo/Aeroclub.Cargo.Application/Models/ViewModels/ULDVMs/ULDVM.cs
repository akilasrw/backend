using Aeroclub.Cargo.Application.Models.Core;
using Aeroclub.Cargo.Application.Models.ViewModels.ULDMetaDataVMs;
using Aeroclub.Cargo.Common.Enums;


namespace Aeroclub.Cargo.Application.Models.ViewModels.ULDVMs
{
    public class ULDVM : BaseVM
    {
        public ULDType ULDType { get; set; }
        public string? SerialNumber { get; set; }
        public Guid ULDMetaDataId { get; set; }
        public ULDMetaDataVM ULDMetaData { get; set; }
    }
}
