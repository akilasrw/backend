using Aeroclub.Cargo.Application.Enums;

namespace Aeroclub.Cargo.Application.Models.ViewModels.PackageItemVMs
{
    public class PackageItemCreateResponseM
    {
        public Guid Id { get; set; }
        public ServiceResponseStatus StatusCode { get; set; }
    }
}
