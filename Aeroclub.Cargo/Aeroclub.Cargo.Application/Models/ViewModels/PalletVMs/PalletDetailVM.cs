namespace Aeroclub.Cargo.Application.Models.ViewModels.PalletVMs
{
    public class PalletDetailVM
    {
        public Guid CargoPositionId { get; set; }
        public bool IsPalletAssigned { get; set; }
        public string? SerialNumber { get; set; }
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
    }
}
