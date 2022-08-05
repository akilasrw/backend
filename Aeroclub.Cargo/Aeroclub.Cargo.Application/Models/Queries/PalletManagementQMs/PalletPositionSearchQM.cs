
namespace Aeroclub.Cargo.Application.Models.Queries.PalletManagementQMs
{
    public class PalletPositionSearchQM
    {
        public string FlightNumber { get; set; }
        public DateTime FlightDate { get; set; } = DateTime.MinValue;

    }
}
