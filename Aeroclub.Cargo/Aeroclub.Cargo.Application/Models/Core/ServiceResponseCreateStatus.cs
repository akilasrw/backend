using Aeroclub.Cargo.Application.Enums;

namespace Aeroclub.Cargo.Application.Models.Core
{
    public class ServiceResponseCreateStatus
    {
        public Guid Id { get; set; }
        public ServiceResponseStatus StatusCode { get; set; }
        public string? Message { get; set; }


    }
}
