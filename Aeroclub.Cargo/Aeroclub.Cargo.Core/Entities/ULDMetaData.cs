using Aeroclub.Cargo.Core.Entities.Core;

namespace Aeroclub.Cargo.Core.Entities
{
    public class ULDMetaData : AuditableEntity
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public double MaxVolume { get; set; }
        public int? Sequence { get; set; }
        public virtual ICollection<ULD> ULDs { get; set; }
    }
}
