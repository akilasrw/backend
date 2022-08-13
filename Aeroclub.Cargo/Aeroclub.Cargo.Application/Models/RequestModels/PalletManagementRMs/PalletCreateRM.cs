using System.ComponentModel.DataAnnotations;

namespace Aeroclub.Cargo.Application.Models.RequestModels.PalletManagementRMs
{
    public class PalletCreateRM
    {
        [Required(ErrorMessage = "Pallet serial number required.")]
        public string SerialNumber { get; set; } = null!;

        [Required(ErrorMessage = "Aircraft position ID required.")]
        public Guid PositionId { get; set; }

        [Required(ErrorMessage = "Width required.")]
        public double Width { get; set; }

        [Required(ErrorMessage = "Length required.")]
        public double Length { get; set; }

        [Required(ErrorMessage = "Height required.")]
        public double Height { get; set; }
        public Guid VolumeUnitId { get; set; }

        [Required(ErrorMessage = "Weight required.")]
        public double Weight { get; set; }
        public Guid WeightUnitId { get; set; }
    }
}
