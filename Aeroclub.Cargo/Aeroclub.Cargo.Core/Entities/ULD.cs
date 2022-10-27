using Aeroclub.Cargo.Common.Enums;
using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ULD : AuditableEntity 
    {
        public ULDType ULDType { get; set; }
        public string SerialNumber { get; set; } = null!;
        public Guid ULDMetaDataId { get; set; }
        public ULDMetaData ULDMetaData { get; set; }

        public ULDCargoPosition ULDCargoPosition { get; set; }
    }
}