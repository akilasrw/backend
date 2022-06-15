using Aeroclub.Cargo.Application.Models.Core;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AirportVMs
{
    public class AirportVM : BaseVM
    {
        public string? Name { get; set; } = null;
        public string? Code { get; set; } = null;
        public double Lat { get; set; }
        public double Lon { get; set; }
        public string? CountryName { get; set; } = null;
    }
}
