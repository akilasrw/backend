

using Aeroclub.Cargo.Application.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.AirWayBillVMs
{
    public class AWBCreateStatusVM
    {
        public Guid Id { get; set; }
        public ServiceResponseStatus StatusCode { get; set; }
    }
}
