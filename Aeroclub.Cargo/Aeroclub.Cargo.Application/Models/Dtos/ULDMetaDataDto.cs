using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.Dtos
{
    public class ULDMetaDataDto: BaseDto
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double MaxWeight { get; set; }
        public double MaxVolume { get; set; }
        public int Sequence { get; set; }
    }
}