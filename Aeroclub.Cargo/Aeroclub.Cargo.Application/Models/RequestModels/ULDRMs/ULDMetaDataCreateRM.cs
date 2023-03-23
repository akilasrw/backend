using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.RequestModels.ULDRMs
{
    public class ULDMetaDataCreateRM : BaseRM
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public double MaxVolume { get; set; }
        public Guid VolumeUnitId { get; set; }
        public Guid WeightUnitId { get; set; }

    }
}