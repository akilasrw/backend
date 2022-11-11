
namespace Aeroclub.Cargo.Application.Models.Queries.ULDContainerCargoPositionQMs
{
    public class ULDCOntainerCargoPositionQM
    {
        public Guid CargoPositionId { get; set; }
        public Guid? ULDContainerId { get; set; }
        public bool IsIncludeULDContainer { get; set; }
        public bool IsIncludeCargoPosition { get; set; }
        public bool IsIncludePackageItem { get; set; }
    }
}
